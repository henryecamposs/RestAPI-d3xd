using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SPARKDAT : ICloneable
    {

        private string mCONCEPTO = "";
        private string mDESCR = "";
        private int mID = 0;
        private string mNRO = "";
        private string mORIGINAL = "";
        private string mTIPO = "";

        public string CONCEPTO
        {
            get
            {
                return mCONCEPTO;
            }
            set
            {
                mCONCEPTO = value;
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

        public string NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        public string ORIGINAL
        {
            get
            {
                return mORIGINAL;
            }
            set
            {
                mORIGINAL = value;
            }
        }

        public string TIPO
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

        SPARKDAT()
        {
        }

        SPARKDAT(string CONCEPTO, string DESCR, int ID, string NRO, string ORIGINAL, string TIPO)
        {
            mCONCEPTO = CONCEPTO;
            mDESCR = DESCR;
            mID = ID;
            mNRO = NRO;
            mORIGINAL = ORIGINAL;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
