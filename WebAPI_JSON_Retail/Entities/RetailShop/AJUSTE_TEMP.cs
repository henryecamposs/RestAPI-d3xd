using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class AJUSTE_TEMP : ICloneable
    {

        private double mCANTI = 0.0;
        private string mCODACTI = "";
        private string mCODALM = "";
        private string mCODIGO = "";
        private double mDOC = 0.0;
        private string mFECHAC = "";
        private int mID = 0;
        private string mRESULT = "";
        private double mSTA = 0.0;
        private double mTIPO = 0.0;

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
            }
        }

        public string CODACTI
        {
            get
            {
                return mCODACTI;
            }
            set
            {
                mCODACTI = value;
            }
        }

        public string CODALM
        {
            get
            {
                return mCODALM;
            }
            set
            {
                mCODALM = value;
            }
        }

        public string CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
            }
        }

        public Double DOC
        {
            get
            {
                return mDOC;
            }
            set
            {
                mDOC = value;
            }
        }

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
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

        public string RESULT
        {
            get
            {
                return mRESULT;
            }
            set
            {
                mRESULT = value;
            }
        }

        public Double STA
        {
            get
            {
                return mSTA;
            }
            set
            {
                mSTA = value;
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

        AJUSTE_TEMP()
        {
        }

        AJUSTE_TEMP(double CANTI, string CODACTI, string CODALM, string CODIGO, double DOC, string FECHAC, int ID, string RESULT, double STA, double TIPO)
        {
            mCANTI = CANTI;
            mCODACTI = CODACTI;
            mCODALM = CODALM;
            mCODIGO = CODIGO;
            mDOC = DOC;
            mFECHAC = FECHAC;
            mID = ID;
            mRESULT = RESULT;
            mSTA = STA;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
