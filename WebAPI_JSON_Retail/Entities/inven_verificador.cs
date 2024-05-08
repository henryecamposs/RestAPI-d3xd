
using System;

namespace wresapi_d3xd.Entities
{
    public class inven_verificador
    {

        private string mbarra = "";
        private string mcodigo = "";
        private string mdescr = "";
        private string mnombre = "";
        private double mprecio = 0.0;
        private double mprecio1 = 0.0;
        private double mprecio2 = 0.0;
        private double mprecio3 = 0.0; 
        private double mtiva = 0.0;
        private string multimau = "";
        private double multimo = 0.0;
        private DateTime mult_actu = new DateTime(2000, 01, 01);
        private DateTime mult_compra = new DateTime(2000, 01, 01);
        private DateTime mult_venta = new DateTime(2000, 01, 01);
   

        public string barra
        {
            get
            {
                return mbarra;
            }
            set
            {
                mbarra = value;
            }
        }

        public string codigo
        {
            get
            {
                return mcodigo;
            }
            set
            {
                mcodigo = value;
            }
        }

        public string descr
        {
            get
            {
                return mdescr;
            }
            set
            {
                mdescr = value;
            }
        }

        public string nombre
        {
            get
            {
                return mnombre;
            }
            set
            {
                mnombre = value;
            }
        }

        public double precio
        {
            get
            {
                return mprecio;
            }
            set
            {
                mprecio = value;
            }
        }

        public double precio1
        {
            get
            {
                return mprecio1;
            }
            set
            {
                mprecio1 = value;
            }
        }


        public double precio2
        {
            get
            {
                return mprecio2;
            }
            set
            {
                mprecio2 = value;
            }
        }

        public double precio3
        {
            get
            {
                return mprecio3;
            }
            set
            {
                mprecio3 = value;
            }
        }

        public double tiva
        {
            get
            {
                return mtiva;
            }
            set
            {
                mtiva = value;
            }
        }
        public string ultimau
        {
            get
            {
                return multimau;
            }
            set
            {
                multimau = value;
            }
        }

        public double ultimo
        {
            get
            {
                return multimo;
            }
            set
            {
                multimo = value;
            }
        }

        public DateTime ult_actu
        {
            get
            {
                return mult_actu;
            }
            set
            {
                mult_actu = value;
            }
        }

        public DateTime ult_compra
        {
            get
            {
                return mult_compra;
            }
            set
            {
                mult_compra = value;
            }
        }

        public DateTime ult_venta
        {
            get
            {
                return mult_venta;
            }
            set
            {
                mult_venta = value;
            }
        }

        public inven_verificador()
        {
        }
    }
}
