using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Promociones : ICloneable
    {

        private int mID = 0;
        private int mId_producto = 0;
        private int mId_TipoPromocion = 0;
        private string mDescripcion = "";
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaUltima = new DateTime(2000, 01, 01);
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

        public int Id_producto
        {
            get
            {
                return mId_producto;
            }
            set
            {
                mId_producto = value;
            }
        }

        public int Id_TipoPromocion
        {
            get
            {
                return mId_TipoPromocion;
            }
            set
            {
                mId_TipoPromocion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return mFechaActual;
            }
            set
            {
                mFechaActual = value;
            }
        }

        public DateTime FechaUltima
        {
            get
            {
                return mFechaUltima;
            }
            set
            {
                mFechaUltima = value;
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

        Productos_Promociones()
        {
        }

        Productos_Promociones(int ID, int id_producto, int id_TipoPromocion, string Descripcion, DateTime FechaActual, DateTime FechaUltima, bool esActivo)
        {
            mID = ID;
            mId_producto = Id_producto;
            mId_TipoPromocion = Id_TipoPromocion;
            mDescripcion = Descripcion;
            mFechaActual = FechaActual;
            mFechaUltima = FechaUltima;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
