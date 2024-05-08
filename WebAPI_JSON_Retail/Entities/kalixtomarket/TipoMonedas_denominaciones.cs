using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoMonedas_denominaciones : ICloneable
    {

        private int mID = 0;
        private int mId_tipoMoneda = 0;
        private string mDescripcion = "";
        private string mImagenArchivo = "";
        private double mMontoValor = 0.0;
        private bool mEsBillete = false;

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

        public int Id_tipoMoneda
        {
            get
            {
                return mId_tipoMoneda;
            }
            set
            {
                mId_tipoMoneda = value;
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

        public string ImagenArchivo
        {
            get
            {
                return mImagenArchivo;
            }
            set
            {
                mImagenArchivo = value;
            }
        }

        public Double MontoValor
        {
            get
            {
                return mMontoValor;
            }
            set
            {
                mMontoValor = value;
            }
        }

        public Boolean EsBillete
        {
            get
            {
                return mEsBillete;
            }
            set
            {
                mEsBillete = value;
            }
        }

        TipoMonedas_denominaciones()
        {
        }

        TipoMonedas_denominaciones(int ID, int id_tipoMoneda, string Descripcion, string ImagenArchivo, double MontoValor, bool esBillete)
        {
            mID = ID;
            mId_tipoMoneda = Id_tipoMoneda;
            mDescripcion = Descripcion;
            mImagenArchivo = ImagenArchivo;
            mMontoValor = MontoValor;
            mEsBillete = EsBillete;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
