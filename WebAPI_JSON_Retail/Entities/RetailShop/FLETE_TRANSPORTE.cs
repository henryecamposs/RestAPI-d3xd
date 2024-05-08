using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class FLETE_TRANSPORTE : ICloneable
    {

        private string mCOD = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private double mTIPO = 0.0;
        private double mVALOR = 0.0;

        public string COD
        {
            get
            {
                return mCOD;
            }
            set
            {
                mCOD = value;
            }
        }

        public string DESCR
        {
            get
            {
                return mDESCR;
            }
            set
            {
                mDESCR = value;
            }
        }

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

        public int IDSUC
        {
            get
            {
                return mIDSUC;
            }
            set
            {
                mIDSUC = value;
            }
        }

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public Double TIPO
        {
            get
            {
                return mTIPO;
            }
            set
            {
                mTIPO = value;
            }
        }

        public Double VALOR
        {
            get
            {
                return mVALOR;
            }
            set
            {
                mVALOR = value;
            }
        }

        FLETE_TRANSPORTE()
        {
        }

        FLETE_TRANSPORTE(string COD, string DESCR, int ID, int IDSUC, double INACTIVO, double TIPO, double VALOR)
        {
            mCOD = COD;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mTIPO = TIPO;
            mVALOR = VALOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
