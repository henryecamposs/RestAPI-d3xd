using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_TINTA : ICloneable
    {

        private int mCODITINT = 0;
        private string mDESCTINT = "";
        private double mPRECTINT = 0.0;

        public int CODITINT
        {
            get
            {
                return mCODITINT;
            }
            set
            {
                mCODITINT = value;
            }
        }

        public string DESCTINT
        {
            get
            {
                return mDESCTINT;
            }
            set
            {
                mDESCTINT = value;
            }
        }

        public Double PRECTINT
        {
            get
            {
                return mPRECTINT;
            }
            set
            {
                mPRECTINT = value;
            }
        }

        PINTURA_TINTA()
        {
        }

        PINTURA_TINTA(int CODITINT, string DESCTINT, double PRECTINT)
        {
            mCODITINT = CODITINT;
            mDESCTINT = DESCTINT;
            mPRECTINT = PRECTINT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
