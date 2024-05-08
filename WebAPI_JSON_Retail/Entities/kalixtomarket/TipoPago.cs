using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoPago : ICloneable
    {

        private int mID = 0;
        private int mId_TipoMoneda = 0;
        private int mId_TipoPago_Doc = 0;
        private string mDescripcion = "";
        private string mImagenArchivo = "";
        private double mPorcentajeBanco = 0.0;
        private bool mEsBonoAlimentacion = false;
        private bool mEsCredito = false;
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

        public int Id_TipoMoneda
        {
            get
            {
                return mId_TipoMoneda;
            }
            set
            {
                mId_TipoMoneda = value;
            }
        }

        public int Id_TipoPago_Doc
        {
            get
            {
                return mId_TipoPago_Doc;
            }
            set
            {
                mId_TipoPago_Doc = value;
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

        public Double PorcentajeBanco
        {
            get
            {
                return mPorcentajeBanco;
            }
            set
            {
                mPorcentajeBanco = value;
            }
        }

        public Boolean EsBonoAlimentacion
        {
            get
            {
                return mEsBonoAlimentacion;
            }
            set
            {
                mEsBonoAlimentacion = value;
            }
        }

        public Boolean EsCredito
        {
            get
            {
                return mEsCredito;
            }
            set
            {
                mEsCredito = value;
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

        TipoPago()
        {
        }

        TipoPago(int ID, int id_TipoMoneda, int id_TipoPago_Doc, string Descripcion, string ImagenArchivo, double PorcentajeBanco, bool esBonoAlimentacion, bool esCredito, bool esActivo)
        {
            mID = ID;
            mId_TipoMoneda = Id_TipoMoneda;
            mId_TipoPago_Doc = Id_TipoPago_Doc;
            mDescripcion = Descripcion;
            mImagenArchivo = ImagenArchivo;
            mPorcentajeBanco = PorcentajeBanco;
            mEsBonoAlimentacion = EsBonoAlimentacion;
            mEsCredito = EsCredito;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
