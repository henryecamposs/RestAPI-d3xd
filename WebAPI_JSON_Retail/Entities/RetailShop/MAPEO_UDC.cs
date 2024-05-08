using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MAPEO_UDC : ICloneable
    {

        private string mDESCRIP = "";
        private int mID = 0;
        private string mNAMETABLEPT = "";
        private string mVALRT = "";
        private string mVALSY = "";

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

        public string NAMETABLEPT
        {
            get
            {
                return mNAMETABLEPT;
            }
            set
            {
                mNAMETABLEPT = value;
            }
        }

        public string VALRT
        {
            get
            {
                return mVALRT;
            }
            set
            {
                mVALRT = value;
            }
        }

        public string VALSY
        {
            get
            {
                return mVALSY;
            }
            set
            {
                mVALSY = value;
            }
        }

        MAPEO_UDC()
        {
        }

        MAPEO_UDC(string DESCRIP, int ID, string NAMETABLEPT, string VALRT, string VALSY)
        {
            mDESCRIP = DESCRIP;
            mID = ID;
            mNAMETABLEPT = NAMETABLEPT;
            mVALRT = VALRT;
            mVALSY = VALSY;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
