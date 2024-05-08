using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CORRELABP : ICloneable
    {

        private int mID = 0;
        private double mNRO = 0.0;
        private string mPREFIJO = "";

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

        public Double NRO
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

        CORRELABP()
        {
        }

        CORRELABP(int ID, double NRO, string PREFIJO)
        {
            mID = ID;
            mNRO = NRO;
            mPREFIJO = PREFIJO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
