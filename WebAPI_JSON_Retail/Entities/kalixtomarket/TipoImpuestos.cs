using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoImpuestos : ICloneable
    {

        private int mID = 0;
        private string mAbreviatura = "";
        private string mDescirpcion = "";
        private DateTime mFechaModificado = new DateTime(2000, 01, 01);
        private double mMontoTasa = 0.0;
        private bool mEsIncluido = false;

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

        public string Abreviatura
        {
            get
            {
                return mAbreviatura;
            }
            set
            {
                mAbreviatura = value;
            }
        }

        public string Descirpcion
        {
            get
            {
                return mDescirpcion;
            }
            set
            {
                mDescirpcion = value;
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

        public Boolean EsIncluido
        {
            get
            {
                return mEsIncluido;
            }
            set
            {
                mEsIncluido = value;
            }
        }

        TipoImpuestos()
        {
        }

        TipoImpuestos(int ID, string Abreviatura, string Descirpcion, DateTime FechaModificado, double MontoTasa, bool esIncluido)
        {
            mID = ID;
            mAbreviatura = Abreviatura;
            mDescirpcion = Descirpcion;
            mFechaModificado = FechaModificado;
            mMontoTasa = MontoTasa;
            mEsIncluido = EsIncluido;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
