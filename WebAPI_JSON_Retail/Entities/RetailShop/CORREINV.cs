using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CORREINV : ICloneable
    {

        private int mID = 0;
        private double mNRO = 0.0;

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

        CORREINV()
        {
        }

        CORREINV(int ID, double NRO)
        {
            mID = ID;
            mNRO = NRO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}