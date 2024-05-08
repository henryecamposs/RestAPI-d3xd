using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class INACTIVO_ID : ICloneable
    {

        private int mID = 0;
        private string mNRO = "";

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

        INACTIVO_ID()
        {
        }

        INACTIVO_ID(int ID, string NRO)
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
