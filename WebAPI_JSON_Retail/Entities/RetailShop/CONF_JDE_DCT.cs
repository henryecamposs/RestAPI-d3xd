using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONF_JDE_DCT : ICloneable
    {

        private string mCOD = "";
        private string mDESCR = "";
        private int mID = 0;
        private string mMAQFIS = "";

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

        public string MAQFIS
        {
            get
            {
                return mMAQFIS;
            }
            set
            {
                mMAQFIS = value;
            }
        }

        CONF_JDE_DCT()
        {
        }

        CONF_JDE_DCT(string COD, string DESCR, int ID, string MAQFIS)
        {
            mCOD = COD;
            mDESCR = DESCR;
            mID = ID;
            mMAQFIS = MAQFIS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
