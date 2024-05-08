using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class FORMATO_CODCLI : ICloneable
    {

        private string mDESCR = "";
        private double mECONTRI = 0.0;
        private double mESTANDAR = 0.0;
        private string mFORMATO = "";
        private int mID = 0;
        private double mLONGMIN = 0.0;
        private string mMASCARA = "";
        private string mNOTA = "";
        private string mPREFIJO = "";
        private double mVALSENIAT = 0.0;

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

        public Double ECONTRI
        {
            get
            {
                return mECONTRI;
            }
            set
            {
                mECONTRI = value;
            }
        }

        public Double ESTANDAR
        {
            get
            {
                return mESTANDAR;
            }
            set
            {
                mESTANDAR = value;
            }
        }

        public string FORMATO
        {
            get
            {
                return mFORMATO;
            }
            set
            {
                mFORMATO = value;
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

        public Double LONGMIN
        {
            get
            {
                return mLONGMIN;
            }
            set
            {
                mLONGMIN = value;
            }
        }

        public string MASCARA
        {
            get
            {
                return mMASCARA;
            }
            set
            {
                mMASCARA = value;
            }
        }

        public string NOTA
        {
            get
            {
                return mNOTA;
            }
            set
            {
                mNOTA = value;
            }
        }

        public string PREFIJO
        {
            get
            {
                return mPREFIJO;
            }
            set
            {
                mPREFIJO = value;
            }
        }

        public Double VALSENIAT
        {
            get
            {
                return mVALSENIAT;
            }
            set
            {
                mVALSENIAT = value;
            }
        }

        FORMATO_CODCLI()
        {
        }

        FORMATO_CODCLI(string DESCR, double ECONTRI, double ESTANDAR, string FORMATO, int ID, double LONGMIN, string MASCARA, string NOTA, string PREFIJO, double VALSENIAT)
        {
            mDESCR = DESCR;
            mECONTRI = ECONTRI;
            mESTANDAR = ESTANDAR;
            mFORMATO = FORMATO;
            mID = ID;
            mLONGMIN = LONGMIN;
            mMASCARA = MASCARA;
            mNOTA = NOTA;
            mPREFIJO = PREFIJO;
            mVALSENIAT = VALSENIAT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
