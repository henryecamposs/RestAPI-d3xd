using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MONEDAE : ICloneable
    {

        private double mCODIGO = 0.0;
        private string mDESCR = "";
        private double mFACTOR = 0.0;
        private int mID = 0;

        public Double CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
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

        public Double FACTOR
        {
            get
            {
                return mFACTOR;
            }
            set
            {
                mFACTOR = value;
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

        MONEDAE()
        {
        }

        MONEDAE(double CODIGO, string DESCR, double FACTOR, int ID)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mFACTOR = FACTOR;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
