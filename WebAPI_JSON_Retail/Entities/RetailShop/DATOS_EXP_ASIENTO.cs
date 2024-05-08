using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DATOS_EXP_ASIENTO : ICloneable
    {

        private string mCENTCOST = "";
        private string mCODICUEN1 = "";
        private string mCODICUEN2 = "";
        private string mCODICUEN3 = "";
        private string mDETACONS1 = "";
        private string mDETACONS2 = "";
        private string mDETACONS3 = "";
        private int mIDCONSDOCU = 0;
        private string mNUMECOMP = "";
        private string mPLAZCONS = "";
        private string mPREFDOCU = "";
        private string mPREFREFE = "";
        private string mRUTACONS = "";
        private double mTIPODEBE = 0.0;
        private double mTIPOHABE = 0.0;
        private string mTRANCONS = "";

        public string CENTCOST
        {
            get
            {
                return mCENTCOST;
            }
            set
            {
                mCENTCOST = value;
            }
        }

        public string CODICUEN1
        {
            get
            {
                return mCODICUEN1;
            }
            set
            {
                mCODICUEN1 = value;
            }
        }

        public string CODICUEN2
        {
            get
            {
                return mCODICUEN2;
            }
            set
            {
                mCODICUEN2 = value;
            }
        }

        public string CODICUEN3
        {
            get
            {
                return mCODICUEN3;
            }
            set
            {
                mCODICUEN3 = value;
            }
        }

        public string DETACONS1
        {
            get
            {
                return mDETACONS1;
            }
            set
            {
                mDETACONS1 = value;
            }
        }

        public string DETACONS2
        {
            get
            {
                return mDETACONS2;
            }
            set
            {
                mDETACONS2 = value;
            }
        }

        public string DETACONS3
        {
            get
            {
                return mDETACONS3;
            }
            set
            {
                mDETACONS3 = value;
            }
        }

        public int IDCONSDOCU
        {
            get
            {
                return mIDCONSDOCU;
            }
            set
            {
                mIDCONSDOCU = value;
            }
        }

        public string NUMECOMP
        {
            get
            {
                return mNUMECOMP;
            }
            set
            {
                mNUMECOMP = value;
            }
        }

        public string PLAZCONS
        {
            get
            {
                return mPLAZCONS;
            }
            set
            {
                mPLAZCONS = value;
            }
        }

        public string PREFDOCU
        {
            get
            {
                return mPREFDOCU;
            }
            set
            {
                mPREFDOCU = value;
            }
        }

        public string PREFREFE
        {
            get
            {
                return mPREFREFE;
            }
            set
            {
                mPREFREFE = value;
            }
        }

        public string RUTACONS
        {
            get
            {
                return mRUTACONS;
            }
            set
            {
                mRUTACONS = value;
            }
        }

        public Double TIPODEBE
        {
            get
            {
                return mTIPODEBE;
            }
            set
            {
                mTIPODEBE = value;
            }
        }

        public Double TIPOHABE
        {
            get
            {
                return mTIPOHABE;
            }
            set
            {
                mTIPOHABE = value;
            }
        }

        public string TRANCONS
        {
            get
            {
                return mTRANCONS;
            }
            set
            {
                mTRANCONS = value;
            }
        }

        DATOS_EXP_ASIENTO()
        {
        }

        DATOS_EXP_ASIENTO(string CENTCOST, string CODICUEN1, string CODICUEN2, string CODICUEN3, string DETACONS1, string DETACONS2, string DETACONS3, int IDCONSDOCU, string NUMECOMP, string PLAZCONS, string PREFDOCU, string PREFREFE, string RUTACONS, double TIPODEBE, double TIPOHABE, string TRANCONS)
        {
            mCENTCOST = CENTCOST;
            mCODICUEN1 = CODICUEN1;
            mCODICUEN2 = CODICUEN2;
            mCODICUEN3 = CODICUEN3;
            mDETACONS1 = DETACONS1;
            mDETACONS2 = DETACONS2;
            mDETACONS3 = DETACONS3;
            mIDCONSDOCU = IDCONSDOCU;
            mNUMECOMP = NUMECOMP;
            mPLAZCONS = PLAZCONS;
            mPREFDOCU = PREFDOCU;
            mPREFREFE = PREFREFE;
            mRUTACONS = RUTACONS;
            mTIPODEBE = TIPODEBE;
            mTIPOHABE = TIPOHABE;
            mTRANCONS = TRANCONS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
