using System;
using System.Collections.Generic;
using System.Data;
using wResAPI_d3xd.Entities.kssMarket;
using wResAPI_d3xd.Entities.RetailShop;

namespace wResAPI_d3xd
{
    public interface IServiceAPI
    {
        string GetFechaArchivo(string Archivo);
        string GetNombreEmpresa();

        #region RetailShopBD
        //Productos
        DataTable GetProductoPorDescr(string Descr, bool esDescrExacta);
        DataTable GetProductoPorBarra(string codigoBarra);
        DataTable GetProductos();
        int setInsertUpdate_producto(INVEN inven);
        int setInsertUpdate_producto(string codigo, string descr, decimal precio, decimal precio2, decimal tiva, decimal unidade, string nombre, string barra, decimal margen3, System.DateTime ult_actu, decimal precio2m, decimal margen3m, decimal pbalanza, decimal tiva2, string grupo, decimal pidepre, decimal pidecanti, string promo, string contenidou, string unidadv, string unidadc, decimal pideobse, System.DateTime ult_venta, System.DateTime ult_compra, System.DateTime desde_o, System.DateTime hasta_o, System.DateTime fecha_r, System.DateTime fecha_m, System.DateTime fecha_v1, System.DateTime fecha_v2, string dgrupo, string tipo);

        //Monedas
        DataTable GetMonedas();
        DataTable GetMoneda_Nomenclatura(string nomenclatura);
        DataTable GetMoneda_Codigo(int codigo);
        int SetUpdateMonedaFactor(int codigo, double factor);

        //Impuestos
        DataTable getIVA_Tipo(int tipo);
        DataTable getIVAs();

        //Inventario
        DataTable getInventario();
        DataTable getInventario_Almacen(string dpto, string periodo);
        DataTable getInventario_Producto(string codigo, string periodo);
        DataTable getInventario_ProductoAlmacen(string codigo, string periodo, string dpto);
        int setInventario_Producto(string codigo, string periodo, string dpto, double Existencia);
        int setMovimientoInventario(bool esAjuste, int NRO, string Motivo, DateTime Fecha, string Comentario, List<EXIS_Movimiento> INVEN_AjusteDetalle);
        int setComprasInventario(bool esCompra, string NRO, string CodigoProveedor, DateTime FechaProcesado, DateTime FechaEmision, DateTime FechaVencimiento, string nroControl,int DiasCredito,string CodigoRetencion,bool esProducto, List<EXIS_Movimiento> INVEN_AjusteDetalle);

        //Almacenes
        DataTable getAlmacenes();
        DataTable getAlmacen_Codigo(string codigo);

        //Grupos Productos
        DataTable getGrupoProductos();
        DataTable getGrupoProductos_Codigo(string codigo);
        DataTable getGrupoProductos_Descr(string descripcion);
        int setInsertUpdateGrupoProductos(string codigo, string descripcion, double porGastos);

        //Unidades Medida
        DataTable getTipoUnidades();
        DataTable getTipoUnidades_Codigo(string codigo);
        DataTable getTipoUnidades_Descr(string descripcion);
        int setInsertUpdateTipoUnidades(string codigo, string descripcion);

        //Empleados
        DataTable getEmpleados();
        DataTable getEmpleados_Codigo(string codigo);
        DataTable getEmpleados_Descr(string descripcion);
        DataTable getEmpleados_Clave(string clave);
        int setInsertUpdateEmpleados(string codigo, string descripcion, string clave, int nivel, string cargo, string rif, string telefono = "", string direccion = "");

        //Publicidad
        List<string> FilesPublicidad();

        #endregion

        #region Base datos KSSDB SQLServer
        //Productos
        DataTable getProductos_kssDB();
        DataTable getProductos_ID_kssDB(int ID);
        DataTable getProductos_descripcion_kssDB(string descripicon, bool esExacta);
        DataTable getProductos_barra_kssDB(string barra, bool esExacta);
        int setInsertUpdateProductos_kssDB(Productos productos);
        int setInsertUpdateProductos_kssDB(int id_TipoProductoGrupo, int id_unidadMedida, int id_UnidadEmpaque, string Descripcion, string Producto_DescripcionLarga, string Producto_LinkWeb, string CodigoBarras, string CodigoInterno, double CantidadUnidad, double CantidadEmpaque, System.DateTime FechaCreacion, System.DateTime FechaUltimaCompra, System.DateTime FechaUltimaModificacion, System.DateTime FechaUltimaVenta, double MargenGananciaPrecio1, double MargenGananciaPrecio2, double MargenGananciaPrecio3, double MontoPrecio1, double MontoPrecio2, double MontoPrecio3, double MontoUltimoCosto, double MontoPrecioDivisa, double MontoCostoDivisa, int MinStock, int MaxStock, string ImagenArchivo, bool esRegulado, bool esPidePeso, bool esPidePrecio, bool esActivo, bool esTroquelado, bool esPideBalanza, int Original_ID);
        int setDeleteProducto_kssDB(int ID);

        //Monedas
        DataTable getTipoMonedas_kssDB();
        DataTable getTipoMonedas_ID_kssDB(int ID);
        DataTable getTipoMonedas_Nomenclatura_kssDB(string nomenclatura);
        int setInsertUpdateTipoMonedas_kssDB(string Descripcion, double Factor, string Nomenclatura, string URLReferencia, string ImagenArchivo, bool esDivide, bool esLocal, bool esActivo, int Original_ID);
        int setDeleteTipoMoneda_kssDB(int ID);

        //Impuestos
        DataTable getTipoImpuestos_kssDB();
        DataTable getTipoImpuestos_ID_kssDB(int ID);
        int setInsetUpdateTipoImpuesto_kssDB(string Abreviatura, string Descirpcion, System.DateTime FechaModificado, double MontoTasa, bool esIncluido, int Original_ID);
        int setDeleteTipoImpuesto_kssDB(int ID);

        //Inventario
        DataTable getProductosExistencia_kssDB();
        DataTable getProductosExistencia_Almacen_kssDB(int idAlmacen);
        DataTable getProductosExistencia_Producto_kssDB(int idAlmacen, int idProducto);
        int setInsertUpdateProductosExistencia_Producto_kssDB(int ID_Producto, int ID_Almacen, global::System.Nullable<int> ID_UbicacionStock, double StockFisico, global::System.Nullable<double> StockPedidoCompra, global::System.Nullable<double> StockPedidoVenta, global::System.Nullable<double> StockProcesoVenta, System.DateTime FechaActual, bool esAjuste, int Original_ID);
        int setDeleteProductosExistencia_kssDB(int ID);

        //Almacenes
        DataTable getAlmacenes_kssDB();
        DataTable getAlmacenes_ID_kssDB(int ID);
        DataTable getAlmacenes_Descripcion_kssDB(string Descripcion);
        int setInsertUpdateAlmacenes_kssDB(string Descripcion, string Direccion, string Responsable, global::System.Nullable<int> id_Sucursal, int Original_ID);
        int setDeleteAlmacenes_kssDB(int ID);

        //Unidades Medida
        DataTable getTipoUnidadesMedida_kssDB();
        DataTable getTipoUnidadesMedida_ID_kssDB(int ID);
        DataTable getTipoUnidadesMedida_Descripcion_kssDB(string Descripcion);
        int setInsertUpdateTipoUnidadesMedida_kssDB(int id_UnidadMedidaUniversal, string Abreviatura, string Descripcion, double CantidadPredeterminada, int Original_ID);
        int setDeleteTipoUnidadesMedida_kssDB(int ID);

        //TipoProductos_Grupo
        DataTable getTipoProductos_Grupo_kssDB();
        DataTable getTipoProductos_Grupo_ID_kssDB(int ID);
        DataTable getTipoProductos_Grupo_Descripcion_kssDB(string Descripcion);
        int setInsertUpdateTipoProductos_Grupo_kssDB(string Descripcion, string CodigoRef, int Original_ID);
        int setDeleteTipoTipoProductos_Grupo_kssDB(int ID);

        //Usuarios
        DataTable getUsuarios_kssDB();
        DataTable getUsuarios_ID_kssDB(int ID);
        DataTable getUsuarios_Descripcion_kssDB(string Descripcion);
        DataTable getUsuarios_Login_kssDB(string Nombre, string Password);
        int setInsertUpdateUsuarios(int id_TipoGrupoUsuario, int id_Empleado, int id_defTipoNivelAcceso, string Nombre, string Password, global::System.Nullable<global::System.DateTime> FechaCaduca, global::System.Nullable<global::System.DateTime> FechaFin, global::System.Nullable<global::System.DateTime> FechaInicio, global::System.Nullable<bool> esCaduca, global::System.Nullable<bool> esActivo, global::System.Nullable<bool> esLogged, int Original_ID);
        int setInsertUpdateUsuarios_kssDB(Usuarios usuarios);
        int setDeleteUsuarios_kssDB(int ID);
        #endregion
    }
}

/*
public JSONObject UserAuthentication(string userName, string passsword) throws Exception
{
    JSONObject result = null;
    JSONObject o = new JSONObject();
JSONObject p = new JSONObject();
o.put("interface","RestAPI");
        o.put("method", "UserAuthentication");
        p.put("userName",mapObject(userName));
        p.put("passsword",mapObject(passsword));
        o.put("parameters", p);
        string s = o.tostring();
string r = load(s);
result = new JSONObject(r);
        return result;
    }
*/
