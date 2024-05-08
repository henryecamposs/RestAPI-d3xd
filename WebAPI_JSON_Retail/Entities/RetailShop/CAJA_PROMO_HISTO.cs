using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJA_PROMO_HISTO : ICloneable
    {

        private double mACUM_TIPO = 0.0;
        private double mACUM_TOTALIZADO = 0.0;
        private string mCAJA = "";
        private int mCOD_PROMO = 0;
        private int mCOD_TIENDA = 0;
        private double mDCTO_NIVEL = 0.0;
        private string mDESCR = "";
        private string mEMPLE = "";
        private DateTime mFECHAFAC = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_TIPO = 0;
        private double mMONDES = 0.0;
        private double mMONTO_FACT = 0.0;
        private double mMONTO_NIVEL = 0.0;
        private double mNIVEL = 0.0;
        private double mNRO_FACT = 0.0;
        private double mRANGO = 0.0;
        private double mTDESCU = 0.0;
        private string mUIDCORTE = "";

        public Double ACUM_TIPO
        {
            get
            {
                return mACUM_TIPO;
            }
            set
            {
                mACUM_TIPO = value;
            }
        }

        public Double ACUM_TOTALIZADO
        {
            get
            {
                return mACUM_TOTALIZADO;
            }
            set
            {
                mACUM_TOTALIZADO = value;
            }
        }

        public string CAJA
        {
            get
            {
                return mCAJA;
            }
            set
            {
                mCAJA = value;
            }
        }

        public int COD_PROMO
        {
            get
            {
                return mCOD_PROMO;
            }
            set
            {
                mCOD_PROMO = value;
            }
        }

        public int COD_TIENDA
        {
            get
            {
                return mCOD_TIENDA;
            }
            set
            {
                mCOD_TIENDA = value;
            }
        }

        public Double DCTO_NIVEL
        {
            get
            {
                return mDCTO_NIVEL;
            }
            set
            {
                mDCTO_NIVEL = value;
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

        public string EMPLE
        {
            get
            {
                return mEMPLE;
            }
            set
            {
                mEMPLE = value;
            }
        }

        public DateTime FECHAFAC
        {
            get
            {
                return mFECHAFAC;
            }
            set
            {
                mFECHAFAC = value;
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

        public int ID_TIPO
        {
            get
            {
                return mID_TIPO;
            }
            set
            {
                mID_TIPO = value;
            }
        }

        public Double MONDES
        {
            get
            {
                return mMONDES;
            }
            set
            {
                mMONDES = value;
            }
        }

        public Double MONTO_FACT
        {
            get
            {
                return mMONTO_FACT;
            }
            set
            {
                mMONTO_FACT = value;
            }
        }

        public Double MONTO_NIVEL
        {
            get
            {
                return mMONTO_NIVEL;
            }
            set
            {
                mMONTO_NIVEL = value;
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

        public Double NRO_FACT
        {
            get
            {
                return mNRO_FACT;
            }
            set
            {
                mNRO_FACT = value;
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

        public string UIDCORTE
        {
            get
            {
                return mUIDCORTE;
            }
            set
            {
                mUIDCORTE = value;
            }
        }

        CAJA_PROMO_HISTO()
        {
        }

        CAJA_PROMO_HISTO(double ACUM_TIPO, double ACUM_TOTALIZADO, string CAJA, int COD_PROMO, int COD_TIENDA, double DCTO_NIVEL, string DESCR, string EMPLE, DateTime FECHAFAC, int ID, int IDSUC, int ID_TIPO, double MONDES, double MONTO_FACT, double MONTO_NIVEL, double NIVEL, double NRO_FACT, double RANGO, double TDESCU, string UIDCORTE)
        {
            mACUM_TIPO = ACUM_TIPO;
            mACUM_TOTALIZADO = ACUM_TOTALIZADO;
            mCAJA = CAJA;
            mCOD_PROMO = COD_PROMO;
            mCOD_TIENDA = COD_TIENDA;
            mDCTO_NIVEL = DCTO_NIVEL;
            mDESCR = DESCR;
            mEMPLE = EMPLE;
            mFECHAFAC = FECHAFAC;
            mID = ID;
            mIDSUC = IDSUC;
            mID_TIPO = ID_TIPO;
            mMONDES = MONDES;
            mMONTO_FACT = MONTO_FACT;
            mMONTO_NIVEL = MONTO_NIVEL;
            mNIVEL = NIVEL;
            mNRO_FACT = NRO_FACT;
            mRANGO = RANGO;
            mTDESCU = TDESCU;
            mUIDCORTE = UIDCORTE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
