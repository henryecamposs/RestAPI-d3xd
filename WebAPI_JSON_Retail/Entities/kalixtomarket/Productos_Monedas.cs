using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Monedas : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_Moneda = 0;
        private double mMontoPrecio1 = 0.0;
        private double mMontoPrecio2 = 0.0;
        private double mMontoPrecio3 = 0.0;
        private bool mEsMonedaDefault = false;
        private bool mEsActivo = false;

        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public int Id_Producto
        {
            get
            {
                return mId_Producto;
            }
            set
            {
                mId_Producto = value;
            }
        }

        public int Id_Moneda
        {
            get
            {
                return mId_Moneda;
            }
            set
            {
                mId_Moneda = value;
            }
        }

        public Double MontoPrecio1
        {
            get
            {
                return mMontoPrecio1;
            }
            set
            {
                mMontoPrecio1 = value;
            }
        }

        public Double MontoPrecio2
        {
            get
            {
                return mMontoPrecio2;
            }
            set
            {
                mMontoPrecio2 = value;
            }
        }

        public Double MontoPrecio3
        {
            get
            {
                return mMontoPrecio3;
            }
            set
            {
                mMontoPrecio3 = value;
            }
        }

        public Boolean EsMonedaDefault
        {
            get
            {
                return mEsMonedaDefault;
            }
            set
            {
                mEsMonedaDefault = value;
            }
        }

        public Boolean EsActivo
        {
            get
            {
                return mEsActivo;
            }
            set
            {
                mEsActivo = value;
            }
        }

        Productos_Monedas()
        {
        }

        Productos_Monedas(int ID, int id_Producto, int id_Moneda, double MontoPrecio1, double MontoPrecio2, double MontoPrecio3, bool esMonedaDefault, bool esActivo)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_Moneda = Id_Moneda;
            mMontoPrecio1 = MontoPrecio1;
            mMontoPrecio2 = MontoPrecio2;
            mMontoPrecio3 = MontoPrecio3;
            mEsMonedaDefault = EsMonedaDefault;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
