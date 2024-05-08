using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROMO_RIFA_PROD : ICloneable
    {

        private string mCODPRO = "";
        private int mID = 0;
        private int mID_RIFA = 0;

        public string CODPRO
        {
            get
            {
                return mCODPRO;
            }
            set
            {
                mCODPRO = value;
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

        public int ID_RIFA
        {
            get
            {
                return mID_RIFA;
            }
            set
            {
                mID_RIFA = value;
            }
        }

        PROMO_RIFA_PROD()
        {
        }

        PROMO_RIFA_PROD(string CODPRO, int ID, int ID_RIFA)
        {
            mCODPRO = CODPRO;
            mID = ID;
            mID_RIFA = ID_RIFA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
