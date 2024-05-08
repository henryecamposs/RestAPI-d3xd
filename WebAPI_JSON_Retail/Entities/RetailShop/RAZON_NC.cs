using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RAZON_NC : ICloneable
    {

        private string mCOD = "";
        private string mDESCR = "";
        private int mID = 0;

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

        RAZON_NC()
        {
        }

        RAZON_NC(string COD, string DESCR, int ID)
        {
            mCOD = COD;
            mDESCR = DESCR;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
