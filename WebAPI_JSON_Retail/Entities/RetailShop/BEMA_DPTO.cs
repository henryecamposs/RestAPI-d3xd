using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BEMA_DPTO : ICloneable
    {

        private double mACUMU = 0.0;
        private string mCODIGO = "";
        private string mDESCR = "";
        private int mID = 0;
        private double mUTILIZADO = 0.0;

        public Double ACUMU
        {
            get
            {
                return mACUMU;
            }
            set
            {
                mACUMU = value;
            }
        }

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

        public Double UTILIZADO
        {
            get
            {
                return mUTILIZADO;
            }
            set
            {
                mUTILIZADO = value;
            }
        }

        BEMA_DPTO()
        {
        }

        BEMA_DPTO(double ACUMU, string CODIGO, string DESCR, int ID, double UTILIZADO)
        {
            mACUMU = ACUMU;
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
            mUTILIZADO = UTILIZADO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
