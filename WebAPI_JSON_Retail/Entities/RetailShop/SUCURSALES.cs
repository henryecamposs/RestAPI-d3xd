using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SUCURSALES : ICloneable
    {

        private double mCHANGED = 0.0;
        private string mDESCRIP = "";
        private string mDIR1 = "";
        private string mDIR2 = "";
        private string mGUID = "";
        private int mID = 0;
        private string mNOMBRE1 = "";
        private string mNOMBRE2 = "";
        private bool mPRINCIPAL = false;
        private string mRIF = "";
        private bool mSTATUS = false;
        private string mTELEF = "";
        private double mIdsuc = 0.0;

        public Double CHANGED
        {
            get
            {
                return mCHANGED;
            }
            set
            {
                mCHANGED = value;
            }
        }

        public string DESCRIP
        {
            get
            {
                return mDESCRIP;
            }
            set
            {
                mDESCRIP = value;
            }
        }

        public string DIR1
        {
            get
            {
                return mDIR1;
            }
            set
            {
                mDIR1 = value;
            }
        }

        public string DIR2
        {
            get
            {
                return mDIR2;
            }
            set
            {
                mDIR2 = value;
            }
        }

        public string GUID
        {
            get
            {
                return mGUID;
            }
            set
            {
                mGUID = value;
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

        public string NOMBRE1
        {
            get
            {
                return mNOMBRE1;
            }
            set
            {
                mNOMBRE1 = value;
            }
        }

        public string NOMBRE2
        {
            get
            {
                return mNOMBRE2;
            }
            set
            {
                mNOMBRE2 = value;
            }
        }

        public Boolean PRINCIPAL
        {
            get
            {
                return mPRINCIPAL;
            }
            set
            {
                mPRINCIPAL = value;
            }
        }

        public string RIF
        {
            get
            {
                return mRIF;
            }
            set
            {
                mRIF = value;
            }
        }

        public Boolean STATUS
        {
            get
            {
                return mSTATUS;
            }
            set
            {
                mSTATUS = value;
            }
        }

        public string TELEF
        {
            get
            {
                return mTELEF;
            }
            set
            {
                mTELEF = value;
            }
        }

        public Double Idsuc
        {
            get
            {
                return mIdsuc;
            }
            set
            {
                mIdsuc = value;
            }
        }

        SUCURSALES()
        {
        }

        SUCURSALES(double CHANGED, string DESCRIP, string DIR1, string DIR2, string GUID, int ID, string NOMBRE1, string NOMBRE2, bool PRINCIPAL, string RIF, bool STATUS, string TELEF, double idsuc)
        {
            mCHANGED = CHANGED;
            mDESCRIP = DESCRIP;
            mDIR1 = DIR1;
            mDIR2 = DIR2;
            mGUID = GUID;
            mID = ID;
            mNOMBRE1 = NOMBRE1;
            mNOMBRE2 = NOMBRE2;
            mPRINCIPAL = PRINCIPAL;
            mRIF = RIF;
            mSTATUS = STATUS;
            mTELEF = TELEF;
            mIdsuc = Idsuc;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
