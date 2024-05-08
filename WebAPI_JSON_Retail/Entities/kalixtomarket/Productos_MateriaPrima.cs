using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_MateriaPrima : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_TipoUnidadCompuesto = 0;
        private double mCantidadDesperdicio = 0.0;
        private double mCantidadManejo = 0.0;
        private double mCantidadOperativos = 0.0;

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

        public int Id_TipoUnidadCompuesto
        {
            get
            {
                return mId_TipoUnidadCompuesto;
            }
            set
            {
                mId_TipoUnidadCompuesto = value;
            }
        }

        public Double CantidadDesperdicio
        {
            get
            {
                return mCantidadDesperdicio;
            }
            set
            {
                mCantidadDesperdicio = value;
            }
        }

        public Double CantidadManejo
        {
            get
            {
                return mCantidadManejo;
            }
            set
            {
                mCantidadManejo = value;
            }
        }

        public Double CantidadOperativos
        {
            get
            {
                return mCantidadOperativos;
            }
            set
            {
                mCantidadOperativos = value;
            }
        }

        Productos_MateriaPrima()
        {
        }

        Productos_MateriaPrima(int ID, int id_Producto, int id_TipoUnidadCompuesto, double CantidadDesperdicio, double CantidadManejo, double CantidadOperativos)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_TipoUnidadCompuesto = Id_TipoUnidadCompuesto;
            mCantidadDesperdicio = CantidadDesperdicio;
            mCantidadManejo = CantidadManejo;
            mCantidadOperativos = CantidadOperativos;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
