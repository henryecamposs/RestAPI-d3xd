using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_MOV : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mID = 0;
        private string mTIPO = "";

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

        public string TIPO
        {
            get
            {
                return mTIPO;
            }
            set
            {
                mTIPO = value;
            }
        }

        TIPO_MOV()
        {
        }

        TIPO_MOV(string CODIGO, string DESCR, int ID, string TIPO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
