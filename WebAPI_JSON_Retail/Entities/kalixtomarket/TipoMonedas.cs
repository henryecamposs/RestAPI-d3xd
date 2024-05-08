using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoMonedas : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private double mFactor = 0.0;
        private string mNomenclatura = "";
        private string mURLReferencia = "";
        private string mImagenArchivo = "";
        private bool mEsDivide = false;
        private bool mEsLocal = false;
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

        public Double Factor
        {
            get
            {
                return mFactor;
            }
            set
            {
                mFactor = value;
            }
        }

        public string Nomenclatura
        {
            get
            {
                return mNomenclatura;
            }
            set
            {
                mNomenclatura = value;
            }
        }

        public string URLReferencia
        {
            get
            {
                return mURLReferencia;
            }
            set
            {
                mURLReferencia = value;
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

        public Boolean EsDivide
        {
            get
            {
                return mEsDivide;
            }
            set
            {
                mEsDivide = value;
            }
        }

        public Boolean EsLocal
        {
            get
            {
                return mEsLocal;
            }
            set
            {
                mEsLocal = value;
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

        TipoMonedas()
        {
        }

        TipoMonedas(int ID, string Descripcion, double Factor, string Nomenclatura, string URLReferencia, string ImagenArchivo, bool esDivide, bool esLocal, bool esActivo)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mFactor = Factor;
            mNomenclatura = Nomenclatura;
            mURLReferencia = URLReferencia;
            mImagenArchivo = ImagenArchivo;
            mEsDivide = EsDivide;
            mEsLocal = EsLocal;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
