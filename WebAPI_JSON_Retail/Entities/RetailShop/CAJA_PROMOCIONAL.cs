using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJA_PROMOCIONAL : ICloneable
    {

        private double mACUM = 0.0;
        private string mCODCTA = "";
        private string mDESCR = "";
        private DateTime mFECHAD = new DateTime(2000, 01, 01);
        private DateTime mFECHAH = new DateTime(2000, 01, 01);
        private int mID = 0;
        private double mINACTIVO = 0.0;
        private double mREINICIO = 0.0;
        private double mTIPO = 0.0;

        public Double ACUM
        {
            get
            {
                return mACUM;
            }
            set
            {
                mACUM = value;
            }
        }

        public string CODCTA
        {
            get
            {
                return mCODCTA;
            }
            set
            {
                mCODCTA = value;
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

        public DateTime FECHAD
        {
            get
            {
                return mFECHAD;
            }
            set
            {
                mFECHAD = value;
            }
        }

        public DateTime FECHAH
        {
            get
            {
                return mFECHAH;
            }
            set
            {
                mFECHAH = value;
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

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public Double REINICIO
        {
            get
            {
                return mREINICIO;
            }
            set
            {
                mREINICIO = value;
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

        CAJA_PROMOCIONAL()
        {
        }

        CAJA_PROMOCIONAL(double ACUM, string CODCTA, string DESCR, DateTime FECHAD, DateTime FECHAH, int ID, double INACTIVO, double REINICIO, double TIPO)
        {
            mACUM = ACUM;
            mCODCTA = CODCTA;
            mDESCR = DESCR;
            mFECHAD = FECHAD;
            mFECHAH = FECHAH;
            mID = ID;
            mINACTIVO = INACTIVO;
            mREINICIO = REINICIO;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
