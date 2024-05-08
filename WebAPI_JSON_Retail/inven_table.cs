using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WebAPI_JSON_Retail
{
    class inven_table
    {

        string codigo;
        string descr;
        decimal precio;
        decimal precio2;
        decimal tiva;
        decimal unidade;
        string nombre;
        string barra;
        decimal margen3;
        DateTime ult_actu;
        decimal precio2m;
        decimal margen3m;
        decimal pbalanza;
        decimal tiva2;
        string grupo;
        decimal pidepre;
        decimal pidecanti;
        string promo;
        string contenidou;
        string unidadv;
        string unidadc;
        decimal pideobse;
        DateTime ult_venta;
        DateTime ult_compra;
        DateTime desde_o;
        DateTime hasta_o;
        DateTime fecha_r;
        DateTime fecha_m;
        DateTime fecha_v1;
        DateTime fecha_v2;
        string dgrupo;
        string tipo;

        public inven_table()
        {
            Codigo = "";
            Descr = "";
            Precio = 0;
            Precio2 = 0;
            Tiva = 0;
            Unidade = 0;
            Nombre = "";
            Barra = "";
            Margen3 = 0;
            Ult_actu = new DateTime();
            Precio2m = 0;
            Margen3m = 0;
            Pbalanza = 0;
            Tiva2 = 0;
            Grupo = "";
            Pidepre = 0;
            Pidecanti = 0;
            Promo = "";
            Contenidou = "";
            Unidadv = "";
            Unidadc = "";
            Pideobse = 0;
            Ult_venta = new DateTime();
            Ult_compra = new DateTime();
            Desde_o = new DateTime();
            Hasta_o = new DateTime();
            Fecha_r = new DateTime();
            Fecha_m = new DateTime();
            Fecha_v1 = new DateTime();
            Fecha_v2 = new DateTime();
            Dgrupo = "";
            Tipo = "0";
        }

        public inven_table(string codigo, string descr, decimal precio, decimal precio2, decimal tiva, decimal unidade, string nombre, string barra, decimal margen3, DateTime ult_actu, decimal precio2m, decimal margen3m, decimal pbalanza, decimal tiva2, string grupo, decimal pidepre, decimal pidecanti, string promo, string contenidou, string unidadv, string unidadc, decimal pideobse, DateTime ult_venta, DateTime ult_compra, DateTime desde_o, DateTime hasta_o, DateTime fecha_r, DateTime fecha_m, DateTime fecha_v1, DateTime fecha_v2, string dgrupo, string tipo)
        {
            Codigo =  codigo;
            Descr = descr;
            Precio = precio;
            Precio2 = precio2;  
            Tiva = tiva;
            Unidade = unidade;
            Nombre = nombre;
            Barra = barra;
            Margen3 = margen3;
            Ult_actu = ult_actu;
            Precio2m = precio2m;
            Margen3m = margen3m;
            Pbalanza = pbalanza;
            Tiva2 = tiva2;
            Grupo = grupo;
            Pidepre = pidepre;
            Pidecanti = pidecanti;
            Promo = promo;
            Contenidou = contenidou;
            Unidadv = unidadv;
            Unidadc = unidadc;
            Pideobse = pideobse;
            Ult_venta = ult_venta;
            Ult_compra = ult_compra;
            Desde_o = desde_o;
            Hasta_o = hasta_o;
            Fecha_r = fecha_r;
            Fecha_m = fecha_m;
            Fecha_v1 = fecha_v1;
            Fecha_v2 = fecha_v2;
            Dgrupo = dgrupo;
            Tipo = tipo;
             
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descr { get => descr; set => descr = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Precio2 { get => precio2; set => precio2 = value; }
        public decimal Tiva { get => tiva; set => tiva = value; }
        public decimal Unidade { get => unidade; set => unidade = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Barra { get => barra; set => barra = value; }
        public decimal Margen3 { get => margen3; set => margen3 = value; }
        public DateTime Ult_actu { get => ult_actu; set => ult_actu = value; }
        public decimal Precio2m { get => precio2m; set => precio2m = value; }
        public decimal Margen3m { get => margen3m; set => margen3m = value; }
        public decimal Pbalanza { get => pbalanza; set => pbalanza = value; }
        public decimal Tiva2 { get => tiva2; set => tiva2 = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public decimal Pidepre { get => pidepre; set => pidepre = value; }
        public decimal Pidecanti { get => pidecanti; set => pidecanti = value; }
        public string Promo { get => promo; set => promo = value; }
        public string Contenidou { get => contenidou; set => contenidou = value; }
        public string Unidadv { get => unidadv; set => unidadv = value; }
        public string Unidadc { get => unidadc; set => unidadc = value; }
        public decimal Pideobse { get => pideobse; set => pideobse = value; }
        public DateTime Ult_venta { get => ult_venta; set => ult_venta = value; }
        public DateTime Ult_compra { get => ult_compra; set => ult_compra = value; }
        public DateTime Desde_o { get => desde_o; set => desde_o = value; }
        public DateTime Hasta_o { get => hasta_o; set => hasta_o = value; }
        public DateTime Fecha_r { get => fecha_r; set => fecha_r = value; }
        public DateTime Fecha_m { get => fecha_m; set => fecha_m = value; }
        public DateTime Fecha_v1 { get => fecha_v1; set => fecha_v1 = value; }
        public DateTime Fecha_v2 { get => fecha_v2; set => fecha_v2 = value; }
        public string Dgrupo { get => dgrupo; set => dgrupo = value; }
        public string Tipo { get => tipo; set => tipo = value; }




        //public inven_table(string json)
        //{
        //    JObject jObject = JObject.Parse(json);
        //    JToken jInven = jObject["inven"];

        //    codigo = (string)jInven["codigo"];
        //    descr = (string)jInven["descr"];
        //    precio = (double)jInven["precio"];
        //    tiva = (int)jInven["tiva"];
        //    barra = (string)jInven["barra"];
        //    pidepre = (int)jInven["pidepre"];
        //    precio_o = (double)jInven["precio_o"];
        //    desde_o = (DateTime)jInven["desde_o"];
        //    hasta_o = (DateTime)jInven["hasta_o"];

        //}

    }
    //SeriaLizar Json
    //Product product = new Product();
    //product.Name = "Apple";
    //product.Expiry = new DateTime(2008, 12, 28);
    //product.Price = 3.99M;
    //product.Sizes = new string[] { "Small", "Medium", "Large" };

    //string json = JsonConvert.SerializeObject(product);
    //{
    //  "Name": "Apple",
    //  "Expiry": "2008-12-28T00:00:00",
    //  "Price": 3.99,
    //  "Sizes": [
    //    "Small",
    //    "Medium",
    //    "Large"
    //  ]
    //}

}
