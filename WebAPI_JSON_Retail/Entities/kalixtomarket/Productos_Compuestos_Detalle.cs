using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Compuestos_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_Productos_Compuestos = 0;
        private int mId_TipoUnidad = 0;
        private double mCantidadUnidad = 0.0;

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

        public int Id_Productos_Compuestos
        {
            get
            {
                return mId_Productos_Compuestos;
            }
            set
            {
                mId_Productos_Compuestos = value;
            }
        }

        public int Id_TipoUnidad
        {
            get
            {
                return mId_TipoUnidad;
            }
            set
            {
                mId_TipoUnidad = value;
            }
        }

        public Double CantidadUnidad
        {
            get
            {
                return mCantidadUnidad;
            }
            set
            {
                mCantidadUnidad = value;
            }
        }

        Productos_Compuestos_Detalle()
        {
        }

        Productos_Compuestos_Detalle(int ID, int id_Productos_Compuestos, int id_TipoUnidad, double CantidadUnidad)
        {
            mID = ID;
            mId_Productos_Compuestos = Id_Productos_Compuestos;
            mId_TipoUnidad = Id_TipoUnidad;
            mCantidadUnidad = CantidadUnidad;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
