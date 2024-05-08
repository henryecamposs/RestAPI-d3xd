using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_BASE : ICloneable
    {

        private int mCODIBASE = 0;
        private string mDESCBASE = "";
        private double mPRECBASE = 0.0;

        public int CODIBASE
        {
            get
            {
                return mCODIBASE;
            }
            set
            {
                mCODIBASE = value;
            }
        }

        public string DESCBASE
        {
            get
            {
                return mDESCBASE;
            }
            set
            {
                mDESCBASE = value;
            }
        }

        public Double PRECBASE
        {
            get
            {
                return mPRECBASE;
            }
            set
            {
                mPRECBASE = value;
            }
        }

        PINTURA_BASE()
        {
        }

        PINTURA_BASE(int CODIBASE, string DESCBASE, double PRECBASE)
        {
            mCODIBASE = CODIBASE;
            mDESCBASE = DESCBASE;
            mPRECBASE = PRECBASE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
