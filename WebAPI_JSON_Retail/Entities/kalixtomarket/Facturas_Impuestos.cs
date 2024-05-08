using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Impuestos : ICloneable
    {

        private int mID = 0;
        private int mId_Factura = 0;
        private int mId_Impuesto = 0;
        private double mTasa = 0.0;

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

        public int Id_Factura
        {
            get
            {
                return mId_Factura;
            }
            set
            {
                mId_Factura = value;
            }
        }

        public int Id_Impuesto
        {
            get
            {
                return mId_Impuesto;
            }
            set
            {
                mId_Impuesto = value;
            }
        }

        public Double Tasa
        {
            get
            {
                return mTasa;
            }
            set
            {
                mTasa = value;
            }
        }

        Facturas_Impuestos()
        {
        }

        Facturas_Impuestos(int ID, int Id_Factura, int Id_Impuesto, double Tasa)
        {
            mID = ID;
            mId_Factura = Id_Factura;
            mId_Impuesto = Id_Impuesto;
            mTasa = Tasa;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
