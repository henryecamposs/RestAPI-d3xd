using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Impuestos : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_Impuesto = 0;
        private double mMontoTasa = 0.0;

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

        public Double MontoTasa
        {
            get
            {
                return mMontoTasa;
            }
            set
            {
                mMontoTasa = value;
            }
        }

        Productos_Impuestos()
        {
        }

        Productos_Impuestos(int ID, int Id_Producto, int Id_Impuesto, double MontoTasa)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_Impuesto = Id_Impuesto;
            mMontoTasa = MontoTasa;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
