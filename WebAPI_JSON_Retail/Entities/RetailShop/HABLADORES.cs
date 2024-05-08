using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class HABLADORES : ICloneable
    {

        private double mCANTI = 0.0;
        private string mCODIGO = "";
        private string mCONTENIDO = "";
        private string mDESCR = "";
        private DateTime mDESDE_O = new DateTime(2000, 01, 01);
        private DateTime mHASTA_O = new DateTime(2000, 01, 01);
        private int mID = 0;
        private double mIVA = 0.0;
        private double mIVA_O = 0.0;
        private double mMARCA = 0.0;
        private double mMONTO = 0.0;
        private double mMONTO_O = 0.0;
        private double mTOTAL = 0.0;
        private double mTOTAL_O = 0.0;

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
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

        public string CONTENIDO
        {
            get
            {
                return mCONTENIDO;
            }
            set
            {
                mCONTENIDO = value;
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

        public DateTime DESDE_O
        {
            get
            {
                return mDESDE_O;
            }
            set
            {
                mDESDE_O = value;
            }
        }

        public DateTime HASTA_O
        {
            get
            {
                return mHASTA_O;
            }
            set
            {
                mHASTA_O = value;
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

        public Double IVA
        {
            get
            {
                return mIVA;
            }
            set
            {
                mIVA = value;
            }
        }

        public Double IVA_O
        {
            get
            {
                return mIVA_O;
            }
            set
            {
                mIVA_O = value;
            }
        }

        public Double MARCA
        {
            get
            {
                return mMARCA;
            }
            set
            {
                mMARCA = value;
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

        public Double MONTO_O
        {
            get
            {
                return mMONTO_O;
            }
            set
            {
                mMONTO_O = value;
            }
        }

        public Double TOTAL
        {
            get
            {
                return mTOTAL;
            }
            set
            {
                mTOTAL = value;
            }
        }

        public Double TOTAL_O
        {
            get
            {
                return mTOTAL_O;
            }
            set
            {
                mTOTAL_O = value;
            }
        }

        HABLADORES()
        {
        }

        HABLADORES(double CANTI, string CODIGO, string CONTENIDO, string DESCR, DateTime DESDE_O, DateTime HASTA_O, int ID, double IVA, double IVA_O, double MARCA, double MONTO, double MONTO_O, double TOTAL, double TOTAL_O)
        {
            mCANTI = CANTI;
            mCODIGO = CODIGO;
            mCONTENIDO = CONTENIDO;
            mDESCR = DESCR;
            mDESDE_O = DESDE_O;
            mHASTA_O = HASTA_O;
            mID = ID;
            mIVA = IVA;
            mIVA_O = IVA_O;
            mMARCA = MARCA;
            mMONTO = MONTO;
            mMONTO_O = MONTO_O;
            mTOTAL = TOTAL;
            mTOTAL_O = TOTAL_O;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
