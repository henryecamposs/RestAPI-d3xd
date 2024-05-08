using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RANGO_ID : ICloneable
    {

        private string mDESDE = "";
        private string mHASTA = "";
        private int mID = 0;

        public string DESDE
        {
            get
            {
                return mDESDE;
            }
            set
            {
                mDESDE = value;
            }
        }

        public string HASTA
        {
            get
            {
                return mHASTA;
            }
            set
            {
                mHASTA = value;
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

        RANGO_ID()
        {
        }

        RANGO_ID(string DESDE, string HASTA, int ID)
        {
            mDESDE = DESDE;
            mHASTA = HASTA;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
