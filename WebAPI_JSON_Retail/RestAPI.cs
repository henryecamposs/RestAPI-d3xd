/* JSON API for android appliation for Retail */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace webAPI_Retail  {
    public class RestAPI {
        private  string urlString = "http://localhost:23250/handler1.ashx";
        private const int bufferSize = 4096;
        public RestAPI(  string DirServer)
        {
             
            if (!string.IsNullOrEmpty(DirServer))
            {
                urlString = DirServer;
            }
        }
        private string Load(string contents)
       {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urlString);
            req.AllowWriteStreamBuffering = true;
            req.Method = "POST";
            req.Timeout = 60000;
            Stream outStream = req.GetRequestStream();
            StreamWriter outStreamWriter = new StreamWriter(outStream);
            outStreamWriter.Write(contents);
            outStreamWriter.Flush();
            outStream.Close();
            WebResponse res = req.GetResponse();
            Stream httpStream = res.GetResponseStream();
            MemoryStream memoryStream = new MemoryStream();
            try
            {
                byte[] buff = new byte[bufferSize];
                int readedBytes = httpStream.Read(buff, 0, buff.Length);
                while (readedBytes > 0)
                {
                    memoryStream.Write(buff, 0, readedBytes);
                    readedBytes = httpStream.Read(buff, 0, buff.Length);
                }
            }
            finally
            {
                if (httpStream != null)
                {
                    httpStream.Close();
                }

                if (memoryStream != null)
                {
                    memoryStream.Close();
                }
            }
            byte[] data = memoryStream.ToArray();
            string result = Encoding.UTF8.GetString(data, 0, data.Length);
            return result;
        }

        public JObject getTipoProductos_Grupo_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoProductos_Grupo_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoProductos_Grupo_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoProductos_Grupo_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoProductos_Grupo_Descripcion_kssDB(string Descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoProductos_Grupo_Descripcion_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateTipoProductos_Grupo_kssDB(string Descripcion,string CodigoRef,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateTipoProductos_Grupo_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            p["CodigoRef"]= JToken.FromObject(CodigoRef);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteTipoTipoProductos_Grupo_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteTipoTipoProductos_Grupo_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getUsuarios_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getUsuarios_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getUsuarios_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getUsuarios_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getUsuarios_Descripcion_kssDB(string Descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getUsuarios_Descripcion_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getUsuarios_Login_kssDB(string Nombre,string Password) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getUsuarios_Login_kssDB";
            p["Nombre"]= JToken.FromObject(Nombre);
            p["Password"]= JToken.FromObject(Password);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateUsuarios(int id_TipoGrupoUsuario,int id_Empleado,int id_defTipoNivelAcceso,string Nombre,string Password,object FechaCaduca,object FechaFin,object FechaInicio,object esCaduca,object esActivo,object esLogged,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateUsuarios";
            p["id_TipoGrupoUsuario"]= JToken.FromObject(id_TipoGrupoUsuario);
            p["id_Empleado"]= JToken.FromObject(id_Empleado);
            p["id_defTipoNivelAcceso"]= JToken.FromObject(id_defTipoNivelAcceso);
            p["Nombre"]= JToken.FromObject(Nombre);
            p["Password"]= JToken.FromObject(Password);
            p["FechaCaduca"]= JToken.FromObject(FechaCaduca);
            p["FechaFin"]= JToken.FromObject(FechaFin);
            p["FechaInicio"]= JToken.FromObject(FechaInicio);
            p["esCaduca"]= JToken.FromObject(esCaduca);
            p["esActivo"]= JToken.FromObject(esActivo);
            p["esLogged"]= JToken.FromObject(esLogged);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateUsuarios_kssDB(object usuarios) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateUsuarios_kssDB";
            p["usuarios"]= JToken.FromObject(usuarios);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteUsuarios_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteUsuarios_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetFechaArchivo(string Archivo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetFechaArchivo";
            p["Archivo"]= JToken.FromObject(Archivo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetNombreEmpresa() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetNombreEmpresa";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetProductoPorDescr(string Descr,bool esDescrExacta) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetProductoPorDescr";
            p["Descr"]= JToken.FromObject(Descr);
            p["esDescrExacta"]= JToken.FromObject(esDescrExacta);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetProductoPorBarra(string codigoBarra) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetProductoPorBarra";
            p["codigoBarra"]= JToken.FromObject(codigoBarra);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetProductos() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetProductos";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdate_producto(object inven) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdate_producto";
            p["inven"]= JToken.FromObject(inven);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdate_producto(string codigo,string descr,double precio,double precio2,double tiva,double unidade,string nombre,string barra,double margen3,DateTime ult_actu,double precio2m,double margen3m,double pbalanza,double tiva2,string grupo,double pidepre,double pidecanti,string promo,string contenidou,string unidadv,string unidadc,double pideobse,DateTime ult_venta,DateTime ult_compra,DateTime desde_o,DateTime hasta_o,DateTime fecha_r,DateTime fecha_m,DateTime fecha_v1,DateTime fecha_v2,string dgrupo,string tipo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdate_producto";
            p["codigo"]= JToken.FromObject(codigo);
            p["descr"]= JToken.FromObject(descr);
            p["precio"]= JToken.FromObject(precio);
            p["precio2"]= JToken.FromObject(precio2);
            p["tiva"]= JToken.FromObject(tiva);
            p["unidade"]= JToken.FromObject(unidade);
            p["nombre"]= JToken.FromObject(nombre);
            p["barra"]= JToken.FromObject(barra);
            p["margen3"]= JToken.FromObject(margen3);
            p["ult_actu"]= JToken.FromObject(ult_actu);
            p["precio2m"]= JToken.FromObject(precio2m);
            p["margen3m"]= JToken.FromObject(margen3m);
            p["pbalanza"]= JToken.FromObject(pbalanza);
            p["tiva2"]= JToken.FromObject(tiva2);
            p["grupo"]= JToken.FromObject(grupo);
            p["pidepre"]= JToken.FromObject(pidepre);
            p["pidecanti"]= JToken.FromObject(pidecanti);
            p["promo"]= JToken.FromObject(promo);
            p["contenidou"]= JToken.FromObject(contenidou);
            p["unidadv"]= JToken.FromObject(unidadv);
            p["unidadc"]= JToken.FromObject(unidadc);
            p["pideobse"]= JToken.FromObject(pideobse);
            p["ult_venta"]= JToken.FromObject(ult_venta);
            p["ult_compra"]= JToken.FromObject(ult_compra);
            p["desde_o"]= JToken.FromObject(desde_o);
            p["hasta_o"]= JToken.FromObject(hasta_o);
            p["fecha_r"]= JToken.FromObject(fecha_r);
            p["fecha_m"]= JToken.FromObject(fecha_m);
            p["fecha_v1"]= JToken.FromObject(fecha_v1);
            p["fecha_v2"]= JToken.FromObject(fecha_v2);
            p["dgrupo"]= JToken.FromObject(dgrupo);
            p["tipo"]= JToken.FromObject(tipo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetMonedas() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetMonedas";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetMoneda_Nomenclatura(string nomenclatura) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetMoneda_Nomenclatura";
            p["nomenclatura"]= JToken.FromObject(nomenclatura);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject GetMoneda_Codigo(int codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "GetMoneda_Codigo";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject SetFactorMoneda(int codigo,double factor) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "SetFactorMoneda";
            p["codigo"]= JToken.FromObject(codigo);
            p["factor"]= JToken.FromObject(factor);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getIVA_Tipo(int tipo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getIVA_Tipo";
            p["tipo"]= JToken.FromObject(tipo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getIVAs() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getIVAs";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getInventario() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getInventario";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getInventario_Almacen(string dpto) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getInventario_Almacen";
            p["dpto"]= JToken.FromObject(dpto);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getInventario_Producto(string codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getInventario_Producto";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInventario_Producto(string codigo,string periodo,string dpto,double Existencia) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInventario_Producto";
            p["codigo"]= JToken.FromObject(codigo);
            p["periodo"]= JToken.FromObject(periodo);
            p["dpto"]= JToken.FromObject(dpto);
            p["Existencia"]= JToken.FromObject(Existencia);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getAlmacenes() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getAlmacenes";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getAlmacen_Codigo(string codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getAlmacen_Codigo";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getGrupoProductos() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getGrupoProductos";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getGrupoProductos_Codigo(string codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getGrupoProductos_Codigo";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getGrupoProductos_Descr(string descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getGrupoProductos_Descr";
            p["descripcion"]= JToken.FromObject(descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateGrupoProductos(string codigo,string descripcion,double porGastos) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateGrupoProductos";
            p["codigo"]= JToken.FromObject(codigo);
            p["descripcion"]= JToken.FromObject(descripcion);
            p["porGastos"]= JToken.FromObject(porGastos);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidades() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidades";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidades_Codigo(string codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidades_Codigo";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidades_Descr(string descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidades_Descr";
            p["descripcion"]= JToken.FromObject(descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateTipoUnidades(string codigo,string descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateTipoUnidades";
            p["codigo"]= JToken.FromObject(codigo);
            p["descripcion"]= JToken.FromObject(descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getEmpleados() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getEmpleados";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getEmpleados_Codigo(string codigo) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getEmpleados_Codigo";
            p["codigo"]= JToken.FromObject(codigo);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getEmpleados_Descr(string descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getEmpleados_Descr";
            p["descripcion"]= JToken.FromObject(descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getEmpleados_Clave(string clave) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getEmpleados_Clave";
            p["clave"]= JToken.FromObject(clave);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateEmpleados(string codigo,string descripcion,string clave,int nivel,string cargo,string rif,string telefono,string direccion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateEmpleados";
            p["codigo"]= JToken.FromObject(codigo);
            p["descripcion"]= JToken.FromObject(descripcion);
            p["clave"]= JToken.FromObject(clave);
            p["nivel"]= JToken.FromObject(nivel);
            p["cargo"]= JToken.FromObject(cargo);
            p["rif"]= JToken.FromObject(rif);
            p["telefono"]= JToken.FromObject(telefono);
            p["direccion"]= JToken.FromObject(direccion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject FilesPublicidad() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "FilesPublicidad";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductos_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductos_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductos_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductos_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductos_descripcion_kssDB(string descripicon,bool esExacta) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductos_descripcion_kssDB";
            p["descripicon"]= JToken.FromObject(descripicon);
            p["esExacta"]= JToken.FromObject(esExacta);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductos_barra_kssDB(string barra,bool esExacta) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductos_barra_kssDB";
            p["barra"]= JToken.FromObject(barra);
            p["esExacta"]= JToken.FromObject(esExacta);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateProductos_kssDB(object productos) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateProductos_kssDB";
            p["productos"]= JToken.FromObject(productos);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateProductos_kssDB(int id_TipoProductoGrupo,int id_unidadMedida,int id_UnidadEmpaque,string Descripcion,string Producto_DescripcionLarga,string Producto_LinkWeb,string CodigoBarras,string CodigoInterno,double CantidadUnidad,double CantidadEmpaque,DateTime FechaCreacion,DateTime FechaUltimaCompra,DateTime FechaUltimaModificacion,DateTime FechaUltimaVenta,double MargenGananciaPrecio1,double MargenGananciaPrecio2,double MargenGananciaPrecio3,double MontoPrecio1,double MontoPrecio2,double MontoPrecio3,double MontoUltimoCosto,double MontoPrecioDivisa,double MontoCostoDivisa,int MinStock,int MaxStock,string ImagenArchivo,bool esRegulado,bool esPidePeso,bool esPidePrecio,bool esActivo,bool esTroquelado,bool esPideBalanza,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateProductos_kssDB";
            p["id_TipoProductoGrupo"]= JToken.FromObject(id_TipoProductoGrupo);
            p["id_unidadMedida"]= JToken.FromObject(id_unidadMedida);
            p["id_UnidadEmpaque"]= JToken.FromObject(id_UnidadEmpaque);
            p["Descripcion"]= JToken.FromObject(Descripcion);
            p["Producto_DescripcionLarga"]= JToken.FromObject(Producto_DescripcionLarga);
            p["Producto_LinkWeb"]= JToken.FromObject(Producto_LinkWeb);
            p["CodigoBarras"]= JToken.FromObject(CodigoBarras);
            p["CodigoInterno"]= JToken.FromObject(CodigoInterno);
            p["CantidadUnidad"]= JToken.FromObject(CantidadUnidad);
            p["CantidadEmpaque"]= JToken.FromObject(CantidadEmpaque);
            p["FechaCreacion"]= JToken.FromObject(FechaCreacion);
            p["FechaUltimaCompra"]= JToken.FromObject(FechaUltimaCompra);
            p["FechaUltimaModificacion"]= JToken.FromObject(FechaUltimaModificacion);
            p["FechaUltimaVenta"]= JToken.FromObject(FechaUltimaVenta);
            p["MargenGananciaPrecio1"]= JToken.FromObject(MargenGananciaPrecio1);
            p["MargenGananciaPrecio2"]= JToken.FromObject(MargenGananciaPrecio2);
            p["MargenGananciaPrecio3"]= JToken.FromObject(MargenGananciaPrecio3);
            p["MontoPrecio1"]= JToken.FromObject(MontoPrecio1);
            p["MontoPrecio2"]= JToken.FromObject(MontoPrecio2);
            p["MontoPrecio3"]= JToken.FromObject(MontoPrecio3);
            p["MontoUltimoCosto"]= JToken.FromObject(MontoUltimoCosto);
            p["MontoPrecioDivisa"]= JToken.FromObject(MontoPrecioDivisa);
            p["MontoCostoDivisa"]= JToken.FromObject(MontoCostoDivisa);
            p["MinStock"]= JToken.FromObject(MinStock);
            p["MaxStock"]= JToken.FromObject(MaxStock);
            p["ImagenArchivo"]= JToken.FromObject(ImagenArchivo);
            p["esRegulado"]= JToken.FromObject(esRegulado);
            p["esPidePeso"]= JToken.FromObject(esPidePeso);
            p["esPidePrecio"]= JToken.FromObject(esPidePrecio);
            p["esActivo"]= JToken.FromObject(esActivo);
            p["esTroquelado"]= JToken.FromObject(esTroquelado);
            p["esPideBalanza"]= JToken.FromObject(esPideBalanza);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteProducto_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteProducto_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoMonedas_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoMonedas_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoMonedas_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoMonedas_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoMonedas_Nomenclatura_kssDB(string nomenclatura) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoMonedas_Nomenclatura_kssDB";
            p["nomenclatura"]= JToken.FromObject(nomenclatura);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateTipoMonedas_kssDB(string Descripcion,double Factor,string Nomenclatura,string URLReferencia,string ImagenArchivo,bool esDivide,bool esLocal,bool esActivo,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateTipoMonedas_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            p["Factor"]= JToken.FromObject(Factor);
            p["Nomenclatura"]= JToken.FromObject(Nomenclatura);
            p["URLReferencia"]= JToken.FromObject(URLReferencia);
            p["ImagenArchivo"]= JToken.FromObject(ImagenArchivo);
            p["esDivide"]= JToken.FromObject(esDivide);
            p["esLocal"]= JToken.FromObject(esLocal);
            p["esActivo"]= JToken.FromObject(esActivo);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteTipoMoneda_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteTipoMoneda_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoImpuestos_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoImpuestos_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoImpuestos_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoImpuestos_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsetUpdateTipoImpuesto_kssDB(string Abreviatura,string Descirpcion,DateTime FechaModificado,double MontoTasa,bool esIncluido,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsetUpdateTipoImpuesto_kssDB";
            p["Abreviatura"]= JToken.FromObject(Abreviatura);
            p["Descirpcion"]= JToken.FromObject(Descirpcion);
            p["FechaModificado"]= JToken.FromObject(FechaModificado);
            p["MontoTasa"]= JToken.FromObject(MontoTasa);
            p["esIncluido"]= JToken.FromObject(esIncluido);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteTipoImpuesto_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteTipoImpuesto_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductosExistencia_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductosExistencia_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductosExistencia_Almacen_kssDB(int idAlmacen) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductosExistencia_Almacen_kssDB";
            p["idAlmacen"]= JToken.FromObject(idAlmacen);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getProductosExistencia_Producto_kssDB(int idAlmacen,int idProducto) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getProductosExistencia_Producto_kssDB";
            p["idAlmacen"]= JToken.FromObject(idAlmacen);
            p["idProducto"]= JToken.FromObject(idProducto);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateProductosExistencia_Producto_kssDB(int ID_Producto,int ID_Almacen,object ID_UbicacionStock,double StockFisico,object StockPedidoCompra,object StockPedidoVenta,object StockProcesoVenta,DateTime FechaActual,bool esAjuste,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateProductosExistencia_Producto_kssDB";
            p["ID_Producto"]= JToken.FromObject(ID_Producto);
            p["ID_Almacen"]= JToken.FromObject(ID_Almacen);
            p["ID_UbicacionStock"]= JToken.FromObject(ID_UbicacionStock);
            p["StockFisico"]= JToken.FromObject(StockFisico);
            p["StockPedidoCompra"]= JToken.FromObject(StockPedidoCompra);
            p["StockPedidoVenta"]= JToken.FromObject(StockPedidoVenta);
            p["StockProcesoVenta"]= JToken.FromObject(StockProcesoVenta);
            p["FechaActual"]= JToken.FromObject(FechaActual);
            p["esAjuste"]= JToken.FromObject(esAjuste);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteProductosExistencia_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteProductosExistencia_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getAlmacenes_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getAlmacenes_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getAlmacenes_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getAlmacenes_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getAlmacenes_Descripcion_kssDB(string Descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getAlmacenes_Descripcion_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateAlmacenes_kssDB(string Descripcion,string Direccion,string Responsable,object id_Sucursal,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateAlmacenes_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            p["Direccion"]= JToken.FromObject(Direccion);
            p["Responsable"]= JToken.FromObject(Responsable);
            p["id_Sucursal"]= JToken.FromObject(id_Sucursal);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteAlmacenes_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteAlmacenes_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidadesMedida_kssDB() {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidadesMedida_kssDB";
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidadesMedida_ID_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidadesMedida_ID_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject getTipoUnidadesMedida_Descripcion_kssDB(string Descripcion) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "getTipoUnidadesMedida_Descripcion_kssDB";
            p["Descripcion"]= JToken.FromObject(Descripcion);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setInsertUpdateTipoUnidadesMedida_kssDB(int id_UnidadMedidaUniversal,string Abreviatura,string Descripcion,double CantidadPredeterminada,int Original_ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setInsertUpdateTipoUnidadesMedida_kssDB";
            p["id_UnidadMedidaUniversal"]= JToken.FromObject(id_UnidadMedidaUniversal);
            p["Abreviatura"]= JToken.FromObject(Abreviatura);
            p["Descripcion"]= JToken.FromObject(Descripcion);
            p["CantidadPredeterminada"]= JToken.FromObject(CantidadPredeterminada);
            p["Original_ID"]= JToken.FromObject(Original_ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

        public JObject setDeleteTipoUnidadesMedida_kssDB(int ID) {
            JObject result = null;
            JObject o = new JObject();
            JObject p = new JObject();
            o["interface"] = "RestAPI";
            o["method"]= "setDeleteTipoUnidadesMedida_kssDB";
            p["ID"]= JToken.FromObject(ID);
            o["parameters"] = p;
            string s = JsonConvert.SerializeObject(o);
            string r = Load(s);
            result = JObject.Parse(r);
            return result;
        }

    }


}
