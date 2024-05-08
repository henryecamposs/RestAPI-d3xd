using kssLibWeb;
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using wResAPI_d3xd.Entities.kssMarket;
using wResAPI_d3xd.Entities.RetailShop;
using System.IO;
using wResAPI_d3xd.DSRetailTableAdapters;
using wResAPI_d3xd;
using wResAPI_d3xd.Entities;
using wresapi_d3xd.Entities;

namespace wResAPI_d3xd
{
    public class ServiceAPI : IServiceAPI
    {
        kssLibWeb.clsConfigAPPXML _clsConfigGral;
        OleDbConnection dbConnection;
        private d3xd_dbaseEntities db = new d3xd_dbaseEntities();

        string cnnstring;
        public ServiceAPI()
        {
            Program.Main();
            dbConnection = DBConnect.getConnection();
            _clsConfigGral = new clsConfigAPPXML();
            _clsConfigGral.leer_config();
        }

        public List<string> FilesPublicidad()
        {
            try
            {
                return System.IO.Directory.GetFiles("\\Publicidad").ToList();
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("FilesPublicidad Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return null;
            }
        }

        public string GetFechaArchivo(string Archivo)
        {
            try
            {
                string sArchivo = _clsConfigGral.DirHuespedServer + "\\inven.dbf";
                if (System.IO.File.Exists(sArchivo))
                {
                    DateTime dt = System.IO.File.GetLastWriteTime(sArchivo);
                    return string.Format("{0:g}", dt);
                }
                else
                {
                    string sdate = "01-01-1999";
                    return sdate;
                }
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("GetFechaArchivo Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return "01-01-1000";
            }
        }

        public string GetNombreEmpresa()
        {
            try
            {
                return _clsConfigGral.empresa_nombre;
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("GetNombreEmpresa Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return "";
            }
        }

        private void guardadCnnstring()
        {
            //cnnstring = conexionstring.Text;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionstrings = config.ConnectionStrings;
            foreach (ConnectionStringSettings connectionstring in connectionstrings.ConnectionStrings)
            {
                if (!Program.esSQLServer)
                {
                    if (connectionstring.Name == "RetailTrump.Properties.Settings.cnnRetailTrump")
                        connectionstring.ConnectionString = cnnstring;
                }
                else
                {
                    if (connectionstring.Name == "RetailTrump.Properties.Settings.cnnRetailTrump_SQLServer")
                        connectionstring.ConnectionString = cnnstring;
                }
            }
            config.Save(ConfigurationSaveMode.Modified);
        }
        private DataTable generarDT(DataTable Tabla, string metodo = "")
        {
            DataTable dt = new DataTable();
            if (metodo.Length == 0)
                metodo = "generarDT";
            try
            {
                foreach (DataColumn dc in Tabla.Columns)
                {
                    switch ((dc.DataType).Name)
                    {
                        case "String":
                            dt.Columns.Add(new DataColumn(dc.ColumnName, typeof(string)));
                            break;
                        case "Decimal":
                            dt.Columns.Add(new DataColumn(dc.ColumnName, typeof(Decimal)));
                            break;
                        case "Boolean":
                            dt.Columns.Add(new DataColumn(dc.ColumnName, typeof(Boolean)));
                            break;
                        case "int":
                            dt.Columns.Add(new DataColumn(dc.ColumnName, typeof(int)));
                            break;
                        case "DateTime":
                            dt.Columns.Add(new DataColumn(dc.ColumnName, typeof(DateTime)));
                            break;
                        default:

                            break;
                    }
                }
                foreach (DataRow item in Tabla.Rows)
                {
                    dt.ImportRow(item);
                }
                return dt;
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting(metodo + " Error-" + Tabla.TableName + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return null;
            }
            finally
            {
                dt.Dispose();
            }
        }

        #region Miembros de IServiceAPI Retail

        #region MONEDAS
        public DataTable GetMoneda_Nomenclatura(string nomenclatura)
            => generarDT(new monedasTableAdapter().GetDataBy(nomenclatura), "GetMoneda_Nomenclatura");

        public DataTable GetMoneda_Codigo(int codigo)
            => generarDT(new monedasTableAdapter().GetDataBy2(codigo), "GetMoneda_Codigo");

        public DataTable GetMonedas()
            => generarDT(new monedasTableAdapter().GetData(), "GetMonedas");

        public int SetUpdateMonedaFactor(int codigo, double factor)
        {
            try
            {
                return new monedasTableAdapter().UpdateQueryByCodigo(Convert.ToDecimal(factor), codigo);
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("GetMonedas Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }

        }

        #endregion

        #region PRODUCTOS
        public inven_verificador GetProductoPorBarra(string codigoBarra)
        {
            //Licencia
            if (DateTime.Now > new DateTime(2022, 01, 01))
                return null;
            List<otrmoney> monedas = getd3xd_monedas();
            productos item = null;
            inven_verificador inven = new inven_verificador();

            item = db.productos.FirstOrDefault(x => x.pcode == codigoBarra);
            if (item != null)
            {
                double precioBs = 0;
                double precioDvisa = 0;
                double? tasadivisa1 = null;
                double? tasadivisa2 = null;
                if (monedas.Count > 0)
                    tasadivisa1 = monedas[0].vcambioa1;
                if (monedas.Count > 1)
                    tasadivisa2 = monedas[1].vcambioa2;
                if (item.pmoneydif > 0)
                {
                    if (item.pmoneydif == 1 && item.pventa1 > 0)
                        precioBs = Convert.ToDouble(item.pventa1 * tasadivisa1);
                    if (item.pmoneydif == 2 && item.pventa1 > 0)
                        precioBs = Convert.ToDouble(item.pventa1 * tasadivisa2);
                    precioDvisa = Convert.ToDouble(item.pventa1);
                }
                else
                {
                    if (item.pmoneydif == 0 && item.pventa1 > 0)
                        precioDvisa = Convert.ToDouble(item.pventa1 / tasadivisa1);
                    precioBs = Convert.ToDouble(item.pventa1);
                }
                inven = new inven_verificador()
                {
                    codigo = item.preferencia,
                    descr = item.pdescribe,
                    tiva = Convert.ToInt32(item.piva),
                    barra = item.pcode,
                    precio = precioBs,
                    precio3 = precioDvisa,
                    ult_actu = new DateTime(200, 01, 01),
                    ult_compra = new DateTime(200, 01, 01),
                    ult_venta = new DateTime(200, 01, 01)
                };
            }
            return inven;
        }
        public List<otrmoney> getd3xd_monedas()
        {
            return db.otrmoney.ToList();
        }
        public List<inven_verificador> GetProductos()
        {
            //Licencia
            if (DateTime.Now > new DateTime(2022, 01, 01))
                return null;

            List<otrmoney> monedas = getd3xd_monedas();
            List<productos> result = null;
            List<inven_verificador> inven = new List<inven_verificador>();
            result = db.productos.ToList<productos>();
            foreach (var item in result)
            {
                double precioBs = 0;
                double precioDvisa = 0;
                double? tasadivisa1 = null;
                double? tasadivisa2 = null;
                if (monedas.Count > 0)
                    tasadivisa1 = monedas[0].vcambioa1;
                if (monedas.Count > 1)
                    tasadivisa2 = monedas[1].vcambioa2;
                if (item.pmoneydif > 0)
                {
                    if (item.pmoneydif == 1 && item.pventa1 > 0)
                        precioBs = Convert.ToDouble(item.pventa1 * tasadivisa1);
                    if (item.pmoneydif == 2 && item.pventa1 > 0)
                        precioBs = Convert.ToDouble(item.pventa1 * tasadivisa2);
                    precioDvisa = Convert.ToDouble(item.pventa1);
                }
                else
                {
                    if (item.pmoneydif == 0 && item.pventa1 > 0)
                        precioDvisa = Convert.ToDouble(item.pventa1 / tasadivisa1);
                    precioBs = Convert.ToDouble(item.pventa1);
                }
                inven.Add(
                    new inven_verificador()
                    {
                        codigo = item.preferencia,
                        descr = item.pdescribe,
                        tiva = Convert.ToInt32(item.piva),
                        barra = item.pcode,
                        precio = precioBs,
                        precio3 = precioDvisa,
                        ult_actu = new DateTime(200, 01, 01),
                        ult_compra = new DateTime(200, 01, 01),
                        ult_venta = new DateTime(200, 01, 01)
                    });
            }
            return inven;
        }

        public DataTable GetProductoPorDescr(string Descr, bool esDescrExacta)
            => generarDT(new invenTableAdapter().GetDataByDescr(esDescrExacta ? Descr : "%" + Descr + "%"), "GetProductoPorDescr");

        public int setInsertUpdate_producto(string codigo, string descr, decimal precio, decimal precio2, decimal tiva, decimal unidade, string nombre, string barra, decimal margen3, DateTime ult_actu, decimal precio2m, decimal margen3m, decimal pbalanza, decimal tiva2, string grupo, decimal pidepre, decimal pidecanti, string promo, string contenidou, string unidadv, string unidadc, decimal pideobse, DateTime ult_venta, DateTime ult_compra, DateTime desde_o, DateTime hasta_o, DateTime fecha_r, DateTime fecha_m, DateTime fecha_v1, DateTime fecha_v2, string dgrupo, string tipo)
        {
            wResAPI_d3xd.DSRetailTableAdapters.invenTableAdapter da = new wResAPI_d3xd.DSRetailTableAdapters.invenTableAdapter();
            /**
             * precio2= divisa
             * margen3= divisafactor
             * margen3m= divisamargenfactor
             * precio2m = divisacosto
             **/
            try
            {
                DateTime newDateCero = new DateTime(2000, 01, 01);
                if (da.GetDataByCodigo(codigo).Rows.Count == 0)
                {
                    return da.InsertQuery_ProductoNuevo(codigo, descr, precio, precio2, tiva, unidade, descr, barra, margen3, ult_actu, precio2m, margen3m, pbalanza, tiva, grupo, pidepre, pidecanti, promo, contenidou, unidadv, unidadc, pideobse, newDateCero, newDateCero, newDateCero, newDateCero, newDateCero, newDateCero, newDateCero, newDateCero, dgrupo, tipo);
                }
                else
                {
                    return da.UpdateQuery_Productos(precio, precio2, margen3, precio2m, margen3m, grupo, tiva, descr, unidadc, unidadv, promo, tiva, unidade, contenidou, barra, pbalanza, pidecanti, pideobse, pidepre, ult_actu, descr, precio2m * margen3, ult_actu, dgrupo, tipo, codigo);
                }
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("setInsertUpdate_producto Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }
            finally
            {
                da.Dispose();
            }
        }

        public int setInsertUpdate_producto(INVEN inven)
            => setInsertUpdate_producto(inven.CODIGO, inven.DESCR, Convert.ToDecimal(inven.PRECIO), Convert.ToDecimal(inven.PRECIO2), Convert.ToDecimal(inven.TIVA), Convert.ToDecimal(inven.UNIDADE), inven.NOMBRE, inven.BARRA, Convert.ToDecimal(inven.MARGEN3), inven.ULT_ACTU, Convert.ToDecimal(inven.PRECIO2M), Convert.ToDecimal(inven.MARGEN3M), Convert.ToDecimal(inven.PBALANZA), Convert.ToDecimal(inven.TIVA2), inven.GRUPO, Convert.ToDecimal(inven.PIDEPRE), Convert.ToDecimal(inven.PIDECANTI), inven.PROMO, inven.CONTENIDOU, inven.UNIDADV, inven.UNIDADC, Convert.ToDecimal(inven.PIDEOBSE), inven.ULT_VENTA, inven.ULT_COMPRA, inven.DESDE_O, inven.HASTA_O, inven.FECHA_R, inven.FECHA_M, inven.FECHA_V1, inven.FECHA_V2, inven.DGRUPO, inven.TIPO);

        #endregion

        #region IVA
        public List<iva_verificador> getIVAs()
        {
            List<iva_verificador> result = new List<iva_verificador>();
            result.Add(
                    new iva_verificador()
                    {
                        nombre = "excento",
                        tipo = 0,
                        valor = 0,
                        nomencla = "EXENTO"
                    });
            result.Add(
                    new iva_verificador()
                    {
                        nombre = "IVA",
                        tipo = 1,
                        valor = 16,
                        nomencla = "IVA"
                    });
            result.Add(
                    new iva_verificador()
                    {
                        nombre = "REDUCIDO",
                        tipo = 2,
                        valor = 8,
                        nomencla = "REDUCIONO"
                    });
            result.Add(
                    new iva_verificador()
                    {
                        nombre = "REDUCIDO",
                        tipo = 3,
                        valor = 31,
                        nomencla = "REDUCIONO"
                    });
            return result;
        }

        public iva_verificador getIVA_Tipo(int tipo)
        {
            return   getIVAs().FirstOrDefault(e => e.tipo == tipo);
        }


        #endregion

        #region INVENTARIO

        public DataTable getInventario()
            => generarDT(new exisTableAdapter().GetDataRelacion(), "getInventario");

        public DataTable getInventario_Almacen(string codigo, string periodo)
            => generarDT(new exisTableAdapter().GetDataByAlmacen(codigo, periodo), "getInventario_Almacen");

        public DataTable getInventario_Producto(string codigo, string periodo)
            => generarDT(new exisTableAdapter().GetDataByCodigoProducto(codigo, periodo), "getInventario_Producto");

        public DataTable getInventario_ProductoAlmacen(string codigo, string periodo, string dpto)
            => generarDT(new exisTableAdapter().getDataByCodigoPeriodoDpto(dpto, codigo, periodo), "getInventario_ProductoAlmacen");

        public int setInventario_Producto(string codigo, string periodo, string dpto, double Existencia)
        {
            wResAPI_d3xd.DSRetailTableAdapters.exisTableAdapter da = new wResAPI_d3xd.DSRetailTableAdapters.exisTableAdapter();
            try
            {
                if (da.getDataByCodigoPeriodoDpto(codigo, periodo, dpto).Rows.Count == 0)
                {
                    if (da.getDataByCodigoPeriodoDpto(codigo, periodo, "00").Rows.Count == 0)
                        da.InsertQueryNvoProducto(codigo, periodo, 0, "00", Convert.ToDecimal(Existencia));
                    return da.InsertQueryNvoProducto(codigo, periodo, 0, dpto, Convert.ToDecimal(Existencia));
                }
                else
                {
                    if (da.UpdateQuery_ConteoFisicobyCodigoDptoPeriodo(Convert.ToDecimal(Existencia), codigo, "00", periodo) >= 0)
                        return da.UpdateQuery_ConteoFisicobyCodigoDptoPeriodo(Convert.ToDecimal(Existencia), codigo, dpto, periodo);
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("setInventario_Producto Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }
            finally
            {
                da.Dispose();
            }
        }

        #endregion

        #region ALMACENES
        public DataTable getAlmacenes()
            => generarDT(new dptoTableAdapter().GetData(), "getAlmacenes");

        public DataTable getAlmacen_Codigo(string codigo)
            => generarDT(new dptoTableAdapter().GetDataBy(codigo), "getAlmacen_Codigo");
        public int setMovimientoInventario(bool esAjuste, int NRO, string Motivo, DateTime Fecha, string Comentario, List<EXIS_Movimiento> INVEN_AjusteDetalle)
        {
            exisTableAdapter exisTableAdapter = new exisTableAdapter();
            moviTableAdapter moviTableAdapter = new moviTableAdapter();
            a_089TableAdapter aj_TableAdapter = new a_089TableAdapter();
            cf_088TableAdapter cf_TableAdapter = new cf_088TableAdapter();
            ajusteeTableAdapter ajusteeTableAdapter = new ajusteeTableAdapter();
            ajusteTableAdapter ajusteTableAdapter = new ajusteTableAdapter();
            correlacfTableAdapter correlacfTableAdapter = new correlacfTableAdapter();

            string archivoAjuste_Template = Program.clsConfig.DirHuespedServer + "\\a_089.dbf";
            string archivoConteo_Template = Program.clsConfig.DirHuespedServer + "\\cf_088.dbf";
            try
            {
                if (INVEN_AjusteDetalle != null)
                {
                    string newFileDBF;
                    if (esAjuste)
                    {
                        if (NRO == 0)
                            NRO = ajusteeTableAdapter.GetData().Rows[0][0] == DBNull.Value ? 1 : Convert.ToInt16(ajusteeTableAdapter.GetData().Rows[0][0]);
                        newFileDBF = Program.clsConfig.DirHuespedServer + $"\\aj_{NRO}.dbf";
                        if (File.Exists(archivoAjuste_Template))
                            if (File.Exists(newFileDBF))
                                File.Delete(newFileDBF);
                        File.Copy(archivoAjuste_Template, newFileDBF);
                        aj_TableAdapter.cambiarTabla("a_089", newFileDBF.Replace(".dbf", ""));

                        //aqui
                        //aj_TableAdapter.Insert();
                    }
                    else //ConteoFisico
                    {
                        if (File.Exists(archivoConteo_Template))
                        {

                        }
                    }


                }
                //_cajad01TableAdapter.cambiarTabla("cajad01", "cajad" + Program.DatosConfiguracion.CodigoCaja);
                /*
                 * Para Ajustes:
                 * //Crear una copia local del archivo a_089.dbf
                    * Cambiar nombre por aj_(NRO).dbf
                 * Para COnteo Fisico:
                    * //Crear una copia local del archivo cj_088.dbf
                    * Cambiar nombre por cj_(NRO).dbf
                */

                /* 
                 * AJUSTE: ENTRADA NRO 10, cant. 20, almacen 01
                 * //Añadir registro a ajustes.dbf
                   * nro,fecha,tipo,concepto,estado,fechac
                 * //Crear tabla aj_10dbf
                    * cantidad=10
                    * tdescu=1
                    * dpto=01
                    * costult=1000
                    * PAQUETE=1
                    * UNIEMPA=1
                 * //Modificar Ajustee.dbf
                    * nro++
                 * //Modificar EXIS.dbf
                   *periodo=año
                   *codigo= codigo
                   *dpto=01
                   *E09=10
                 * //Añadir a MOVI.dbf
                   * codigo=
                   * descr
                   * canti=10
                   * MONTO=1000
                   * IVA=0
                   * tipo=02
                   * nro=6
                   * dpto=01
                   * BARRA=BARRA
                   * concepto=prueba1
                */
            }
            catch (Exception)
            {


                throw;
            }
            finally
            {
                exisTableAdapter = null;
                moviTableAdapter = null;
                aj_TableAdapter = null;
                cf_TableAdapter = null;
                ajusteeTableAdapter = null;
                ajusteTableAdapter = null;
            }

            throw new NotImplementedException();
        }

        public int setComprasInventario(bool esCompra, string NRO, string CodigoProveedor, DateTime FechaProcesado, DateTime FechaEmision, DateTime FechaVencimiento, string nroControl, int DiasCredito, string CodigoRetencion, bool esProducto, List<EXIS_Movimiento> INVEN_AjusteDetalle)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region GRUPOS
        public DataTable getGrupoProductos()
            => generarDT(new gruinvTableAdapter().GetData(), "getGrupoProductos");

        public DataTable getGrupoProductos_Codigo(string codigo)
            => generarDT(new gruinvTableAdapter().GetDataByCodigo(codigo), "getGrupoProductos_Codigo");

        public DataTable getGrupoProductos_Descr(string descripcion)
            => generarDT(new gruinvTableAdapter().GetDataByCodigo(descripcion), "getGrupoProductos_Descr");

        public int setInsertUpdateGrupoProductos(string codigo, string descripcion, double porGastos)
        {
            gruinvTableAdapter da = new gruinvTableAdapter();
            try
            {
                if (da.GetDataByCodigo(codigo).Rows.Count == 0)
                {
                    return da.InsertQuery(descripcion, codigo, Convert.ToDecimal(porGastos));
                }
                else
                {
                    return da.UpdateQuery(descripcion, Convert.ToDecimal(porGastos), codigo);
                }
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("setInsertUpdateGrupoProductos Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }
        }

        #endregion

        #region EMPAQUES
        public DataTable getTipoUnidades()
            => generarDT(new tipo_empaTableAdapter().GetData(), "getTipoUnidades");
        public DataTable getTipoUnidades_Codigo(string codigo)
            => generarDT(new tipo_empaTableAdapter().GetDataByCodigo(codigo), "getTipoUnidades_Codigo");

        public DataTable getTipoUnidades_Descr(string descripcion)
                   => generarDT(new tipo_empaTableAdapter().GetDataByDescr(descripcion), "getTipoUnidades_Descr");

        public int setInsertUpdateTipoUnidades(string codigo, string descripcion)
        {
            tipo_empaTableAdapter da = new tipo_empaTableAdapter();
            try
            {
                return da.GetDataByCodigo(codigo).Rows.Count == 0 ? da.InsertQuery(codigo, descripcion, "") : da.UpdateQuery(descripcion, "", codigo);
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("setInsertUpdateTipoUnidades Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }
            finally
            { da.Dispose(); }
        }


        #endregion

        #region EMPLEADOS
        public DataTable getEmpleados()
            => generarDT(new empleTableAdapter().GetData(), "getEmpleados");

        public DataTable getEmpleados_Codigo(string codigo)
            => generarDT(new empleTableAdapter().GetDataByCodigo(codigo), "getEmpleados_Codigo");

        public DataTable getEmpleados_Descr(string descripcion)
            => generarDT(new empleTableAdapter().GetDataByDescr(descripcion), "getEmpleados_Descr");

        public DataTable getEmpleados_Clave(string clave)
            => generarDT(new empleTableAdapter().GetDataByClave(clave), "getEmpleados_Clave");

        public int setInsertUpdateEmpleados(string codigo, string descripcion, string clave, int nivel, string cargo, string rif, string telefono = "", string direccion = "")
        {
            empleTableAdapter da = new empleTableAdapter();
            try
            {
                return da.GetDataByCodigo(codigo).Rows.Count == 0
                    ? da.InsertQuery(codigo, descripcion, rif, direccion, telefono, nivel, "", clave, new DateTime(), cargo, clave)
                    : da.UpdateQuery(descripcion, rif, direccion, telefono, nivel, clave, cargo, clave, codigo);
            }
            catch (Exception ex)
            {
                cls_ConfigSettings.WriteSetting("setInsertUpdateEmpleados Error-" + string.Format("{0:yyyyMddHHmmss}", DateTime.Now), ex.Message, "key", "value");
                return 0;
            }
            finally
            { da.Dispose(); }
        }


        #endregion

        #endregion

        #region IServiceAPI kssDB

        public DataTable getProductos_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getProductos_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getProductos_descripcion_kssDB(string descripicon, bool esExacta)
        {
            throw new NotImplementedException();
        }

        public DataTable getProductos_barra_kssDB(string barra, bool esExacta)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateProductos_kssDB(Productos productos)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateProductos_kssDB(int id_TipoProductoGrupo, int id_unidadMedida, int id_UnidadEmpaque, string Descripcion, string Producto_DescripcionLarga, string Producto_LinkWeb, string CodigoBarras, string CodigoInterno, double CantidadUnidad, double CantidadEmpaque, DateTime FechaCreacion, DateTime FechaUltimaCompra, DateTime FechaUltimaModificacion, DateTime FechaUltimaVenta, double MargenGananciaPrecio1, double MargenGananciaPrecio2, double MargenGananciaPrecio3, double MontoPrecio1, double MontoPrecio2, double MontoPrecio3, double MontoUltimoCosto, double MontoPrecioDivisa, double MontoCostoDivisa, int MinStock, int MaxStock, string ImagenArchivo, bool esRegulado, bool esPidePeso, bool esPidePrecio, bool esActivo, bool esTroquelado, bool esPideBalanza, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteProducto_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoMonedas_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoMonedas_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoMonedas_Nomenclatura_kssDB(string nomenclatura)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateTipoMonedas_kssDB(string Descripcion, double Factor, string Nomenclatura, string URLReferencia, string ImagenArchivo, bool esDivide, bool esLocal, bool esActivo, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteTipoMoneda_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoImpuestos_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoImpuestos_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public int setInsetUpdateTipoImpuesto_kssDB(string Abreviatura, string Descirpcion, DateTime FechaModificado, double MontoTasa, bool esIncluido, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteTipoImpuesto_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getProductosExistencia_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getProductosExistencia_Almacen_kssDB(int idAlmacen)
        {
            throw new NotImplementedException();
        }

        public DataTable getProductosExistencia_Producto_kssDB(int idAlmacen, int idProducto)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateProductosExistencia_Producto_kssDB(int ID_Producto, int ID_Almacen, int? ID_UbicacionStock, double StockFisico, double? StockPedidoCompra, double? StockPedidoVenta, double? StockProcesoVenta, DateTime FechaActual, bool esAjuste, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteProductosExistencia_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getAlmacenes_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getAlmacenes_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getAlmacenes_Descripcion_kssDB(string Descripcion)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateAlmacenes_kssDB(string Descripcion, string Direccion, string Responsable, int? id_Sucursal, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteAlmacenes_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoUnidadesMedida_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoUnidadesMedida_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoUnidadesMedida_Descripcion_kssDB(string Descripcion)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateTipoUnidadesMedida_kssDB(int id_UnidadMedidaUniversal, string Abreviatura, string Descripcion, double CantidadPredeterminada, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteTipoUnidadesMedida_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoProductos_Grupo_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoProductos_Grupo_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getTipoProductos_Grupo_Descripcion_kssDB(string Descripcion)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateTipoProductos_Grupo_kssDB(string Descripcion, string CodigoRef, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setDeleteTipoTipoProductos_Grupo_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getUsuarios_kssDB()
        {
            throw new NotImplementedException();
        }

        public DataTable getUsuarios_ID_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable getUsuarios_Descripcion_kssDB(string Descripcion)
        {
            throw new NotImplementedException();
        }

        public DataTable getUsuarios_Login_kssDB(string Nombre, string Password)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateUsuarios(int id_TipoGrupoUsuario, int id_Empleado, int id_defTipoNivelAcceso, string Nombre, string Password, DateTime? FechaCaduca, DateTime? FechaFin, DateTime? FechaInicio, bool? esCaduca, bool? esActivo, bool? esLogged, int Original_ID)
        {
            throw new NotImplementedException();
        }

        public int setInsertUpdateUsuarios_kssDB(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public int setDeleteUsuarios_kssDB(int ID)
        {
            throw new NotImplementedException();
        }

        DataTable IServiceAPI.GetProductoPorBarra(string codigoBarra)
        {
            throw new NotImplementedException();
        }

        DataTable IServiceAPI.GetProductos()
        {
            throw new NotImplementedException();
        }

        DataTable IServiceAPI.getIVAs()
        {
            throw new NotImplementedException();
        }

        DataTable IServiceAPI.getIVA_Tipo(int tipo)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}