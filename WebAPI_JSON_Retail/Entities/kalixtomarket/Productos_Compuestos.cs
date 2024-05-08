using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Compuestos : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private string mId_TipoUnidadMedida = "";
        private string mDescripcion = "";
        private string mCodigoReferencia = "";
        private double mCantidadUnidad = 0.0;
        private DateTime mFechaCreado = new DateTime(2000, 01, 01);
        private DateTime mFechaModificado = new DateTime(2000, 01, 01);
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

        public string Id_TipoUnidadMedida
        {
            get
            {
                return mId_TipoUnidadMedida;
            }
            set
            {
                mId_TipoUnidadMedida = value;
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

        public string CodigoReferencia
        {
            get
            {
                return mCodigoReferencia;
            }
            set
            {
                mCodigoReferencia = value;
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

        public DateTime FechaCreado
        {
            get
            {
                return mFechaCreado;
            }
            set
            {
                mFechaCreado = value;
            }
        }

        public DateTime FechaModificado
        {
            get
            {
                return mFechaModificado;
            }
            set
            {
                mFechaModificado = value;
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

        Productos_Compuestos()
        {
        }

        Productos_Compuestos(int ID, int id_Producto, string id_TipoUnidadMedida, string Descripcion, string CodigoReferencia, double CantidadUnidad, DateTime FechaCreado, DateTime FechaModificado, bool esActivo)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_TipoUnidadMedida = Id_TipoUnidadMedida;
            mDescripcion = Descripcion;
            mCodigoReferencia = CodigoReferencia;
            mCantidadUnidad = CantidadUnidad;
            mFechaCreado = FechaCreado;
            mFechaModificado = FechaModificado;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
