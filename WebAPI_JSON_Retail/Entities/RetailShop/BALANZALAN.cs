using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BALANZALAN : ICloneable
    {

        private double mBARCODE = 0.0;
        private double mBARCODE5 = 0.0;
        private string mCODIGO = "";
        private double mCONSO = 0.0;
        private int mID = 0;
        private string mIP = "";
        private double mLABEL = 0.0;
        private double mLABEL2 = 0.0;
        private double mMSG = 0.0;
        private string mNOMBRE = "";
        private double mPORT = 0.0;
        private double mPREF = 0.0;
        private double mTFONT = 0.0;

        public Double BARCODE
        {
            get
            {
                return mBARCODE;
            }
            set
            {
                mBARCODE = value;
            }
        }

        public Double BARCODE5
        {
            get
            {
                return mBARCODE5;
            }
            set
            {
                mBARCODE5 = value;
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

        public Double CONSO
        {
            get
            {
                return mCONSO;
            }
            set
            {
                mCONSO = value;
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

        public string IP
        {
            get
            {
                return mIP;
            }
            set
            {
                mIP = value;
            }
        }

        public Double LABEL
        {
            get
            {
                return mLABEL;
            }
            set
            {
                mLABEL = value;
            }
        }

        public Double LABEL2
        {
            get
            {
                return mLABEL2;
            }
            set
            {
                mLABEL2 = value;
            }
        }

        public Double MSG
        {
            get
            {
                return mMSG;
            }
            set
            {
                mMSG = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double PORT
        {
            get
            {
                return mPORT;
            }
            set
            {
                mPORT = value;
            }
        }

        public Double PREF
        {
            get
            {
                return mPREF;
            }
            set
            {
                mPREF = value;
            }
        }

        public Double TFONT
        {
            get
            {
                return mTFONT;
            }
            set
            {
                mTFONT = value;
            }
        }

        BALANZALAN()
        {
        }

        BALANZALAN(double BARCODE, double BARCODE5, string CODIGO, double CONSO, int ID, string IP, double LABEL, double LABEL2, double MSG, string NOMBRE, double PORT, double PREF, double TFONT)
        {
            mBARCODE = BARCODE;
            mBARCODE5 = BARCODE5;
            mCODIGO = CODIGO;
            mCONSO = CONSO;
            mID = ID;
            mIP = IP;
            mLABEL = LABEL;
            mLABEL2 = LABEL2;
            mMSG = MSG;
            mNOMBRE = NOMBRE;
            mPORT = PORT;
            mPREF = PREF;
            mTFONT = TFONT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
