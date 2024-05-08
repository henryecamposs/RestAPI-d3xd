using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MONEDAS : ICloneable
    {

        private double mCODIGO = 0.0;
        private string mDESCR = "";
        private double mFACTOR = 0.0;
        private double mFDECIMAL = 0.0;
        private double mFENTERO = 0.0;
        private int mID_MON = 0;
        private double mLOCAL = 0.0;
        private double mMODDEC = 0.0;
        private double mMODENT = 0.0;
        private string mNOMEN = "";
        private double mREDSIMP = 0.0;
        private double mTIPO = 0.0;
        private double mUNIDAD = 0.0;
        private double mVALREDDEC = 0.0;
        private double mVALREDENT = 0.0;
        private double mVALREDTOT = 0.0;

        public Double CODIGO
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

        public Double FACTOR
        {
            get
            {
                return mFACTOR;
            }
            set
            {
                mFACTOR = value;
            }
        }

        public Double FDECIMAL
        {
            get
            {
                return mFDECIMAL;
            }
            set
            {
                mFDECIMAL = value;
            }
        }

        public Double FENTERO
        {
            get
            {
                return mFENTERO;
            }
            set
            {
                mFENTERO = value;
            }
        }

        public int ID_MON
        {
            get
            {
                return mID_MON;
            }
            set
            {
                mID_MON = value;
            }
        }

        public Double LOCAL
        {
            get
            {
                return mLOCAL;
            }
            set
            {
                mLOCAL = value;
            }
        }

        public Double MODDEC
        {
            get
            {
                return mMODDEC;
            }
            set
            {
                mMODDEC = value;
            }
        }

        public Double MODENT
        {
            get
            {
                return mMODENT;
            }
            set
            {
                mMODENT = value;
            }
        }

        public string NOMEN
        {
            get
            {
                return mNOMEN;
            }
            set
            {
                mNOMEN = value;
            }
        }

        public Double REDSIMP
        {
            get
            {
                return mREDSIMP;
            }
            set
            {
                mREDSIMP = value;
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

        public Double UNIDAD
        {
            get
            {
                return mUNIDAD;
            }
            set
            {
                mUNIDAD = value;
            }
        }

        public Double VALREDDEC
        {
            get
            {
                return mVALREDDEC;
            }
            set
            {
                mVALREDDEC = value;
            }
        }

        public Double VALREDENT
        {
            get
            {
                return mVALREDENT;
            }
            set
            {
                mVALREDENT = value;
            }
        }

        public Double VALREDTOT
        {
            get
            {
                return mVALREDTOT;
            }
            set
            {
                mVALREDTOT = value;
            }
        }

        MONEDAS()
        {
        }

        MONEDAS(double CODIGO, string DESCR, double FACTOR, double FDECIMAL, double FENTERO, int ID_MON, double LOCAL, double MODDEC, double MODENT, string NOMEN, double REDSIMP, double TIPO, double UNIDAD, double VALREDDEC, double VALREDENT, double VALREDTOT)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mFACTOR = FACTOR;
            mFDECIMAL = FDECIMAL;
            mFENTERO = FENTERO;
            mID_MON = ID_MON;
            mLOCAL = LOCAL;
            mMODDEC = MODDEC;
            mMODENT = MODENT;
            mNOMEN = NOMEN;
            mREDSIMP = REDSIMP;
            mTIPO = TIPO;
            mUNIDAD = UNIDAD;
            mVALREDDEC = VALREDDEC;
            mVALREDENT = VALREDENT;
            mVALREDTOT = VALREDTOT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
