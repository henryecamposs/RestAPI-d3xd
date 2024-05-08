using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ETIBARRA : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private string mFORMATO = "";
        private int mID = 0;
        private double mMODELO = 0.0;

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

        public string FORMATO
        {
            get
            {
                return mFORMATO;
            }
            set
            {
                mFORMATO = value;
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

        public Double MODELO
        {
            get
            {
                return mMODELO;
            }
            set
            {
                mMODELO = value;
            }
        }

        ETIBARRA()
        {
        }

        ETIBARRA(string CODIGO, string DESCR, string FORMATO, int ID, double MODELO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mFORMATO = FORMATO;
            mID = ID;
            mMODELO = MODELO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
