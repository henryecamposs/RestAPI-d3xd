using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_EMPA : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private string mDESCR1 = "";
        private int mID = 0;

        public string CODIGO
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

        public string DESCR1
        {
            get
            {
                return mDESCR1;
            }
            set
            {
                mDESCR1 = value;
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

        TIPO_EMPA()
        {
        }

        TIPO_EMPA(string CODIGO, string DESCR, string DESCR1, int ID)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDESCR1 = DESCR1;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
