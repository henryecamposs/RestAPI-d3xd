using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CREDITO_TERPAGO : ICloneable
    {

        private string mCOD = "";
        private string mDESCR = "";
        private double mDIAS = 0.0;
        private int mID = 0;
        private double mInactivo = 0.0;

        public string COD
        {
            get
            {
                return mCOD;
            }
            set
            {
                mCOD = value;
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

        public Double DIAS
        {
            get
            {
                return mDIAS;
            }
            set
            {
                mDIAS = value;
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

        public Double Inactivo
        {
            get
            {
                return mInactivo;
            }
            set
            {
                mInactivo = value;
            }
        }

        CREDITO_TERPAGO()
        {
        }

        CREDITO_TERPAGO(string COD, string DESCR, double DIAS, int ID, double inactivo)
        {
            mCOD = COD;
            mDESCR = DESCR;
            mDIAS = DIAS;
            mID = ID;
            mInactivo = Inactivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
