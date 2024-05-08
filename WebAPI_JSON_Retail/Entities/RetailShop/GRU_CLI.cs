using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class GRU_CLI : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
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

        GRU_CLI()
        {
        }

        GRU_CLI(string CODIGO, string DESCR, int ID)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
