using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJA_PROMO_NIVEL : ICloneable
    {

        private double mCONDIC = 0.0;
        private double mDCTO = 0.0;
        private DateTime mFECHAD = new DateTime(2000, 01, 01);
        private DateTime mFECHAH = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mID_CAJAPRO = 0;
        private double mMONTO = 0.0;
        private double mNIVEL = 0.0;
        private double mRANGO = 0.0;
        private double mTDESCU = 0.0;

        public Double CONDIC
        {
            get
            {
                return mCONDIC;
            }
            set
            {
                mCONDIC = value;
            }
        }

        public Double DCTO
        {
            get
            {
                return mDCTO;
            }
            set
            {
                mDCTO = value;
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

        public int ID_CAJAPRO
        {
            get
            {
                return mID_CAJAPRO;
            }
            set
            {
                mID_CAJAPRO = value;
            }
        }

        public Double MONTO
        {
            get
            {
                return mMONTO;
            }
            set
            {
                mMONTO = value;
            }
        }

        public Double NIVEL
        {
            get
            {
                return mNIVEL;
            }
            set
            {
                mNIVEL = value;
            }
        }

        public Double RANGO
        {
            get
            {
                return mRANGO;
            }
            set
            {
                mRANGO = value;
            }
        }

        public Double TDESCU
        {
            get
            {
                return mTDESCU;
            }
            set
            {
                mTDESCU = value;
            }
        }

        CAJA_PROMO_NIVEL()
        {
        }

        CAJA_PROMO_NIVEL(double CONDIC, double DCTO, DateTime FECHAD, DateTime FECHAH, int ID, int ID_CAJAPRO, double MONTO, double NIVEL, double RANGO, double TDESCU)
        {
            mCONDIC = CONDIC;
            mDCTO = DCTO;
            mFECHAD = FECHAD;
            mFECHAH = FECHAH;
            mID = ID;
            mID_CAJAPRO = ID_CAJAPRO;
            mMONTO = MONTO;
            mNIVEL = NIVEL;
            mRANGO = RANGO;
            mTDESCU = TDESCU;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
