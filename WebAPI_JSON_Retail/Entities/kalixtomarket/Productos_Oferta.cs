using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Oferta : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_TipoOferta = 0;
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

        public int Id_TipoOferta
        {
            get
            {
                return mId_TipoOferta;
            }
            set
            {
                mId_TipoOferta = value;
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

        Productos_Oferta()
        {
        }

        Productos_Oferta(int ID, int id_Producto, int id_TipoOferta, string Descripcion, DateTime FechaActual, DateTime FechaUltima, bool esActivo)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_TipoOferta = Id_TipoOferta;
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
