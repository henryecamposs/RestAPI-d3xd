using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DESCU : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mPORC = 0.0;
        private double mTIPO = 0.0;

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

        public int IDSUC
        {
            get
            {
                return mIDSUC;
            }
            set
            {
                mIDSUC = value;
            }
        }

        public Double PORC
        {
            get
            {
                return mPORC;
            }
            set
            {
                mPORC = value;
            }
        }

        public Double TIPO
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

        DESCU()
        {
        }

        DESCU(string CODIGO, string DESCR, int ID, int IDSUC, double PORC, double TIPO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mPORC = PORC;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
