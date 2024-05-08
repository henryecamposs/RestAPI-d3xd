using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROVEE : ICloneable
    {

        private string mCODA = "";
        private string mCODIGO = "";
        private string mCONTACTO = "";
        private double mCREDITOS = 0.0;
        private string mCUEN_BAN = "";
        private double mDEBITOS = 0.0;
        private string mDESCR = "";
        private string mDIR1 = "";
        private string mDIR2 = "";
        private string mDIR3 = "";
        private int mID = 0;
        private double mMONTO = 0.0;
        private string mNIT = "";
        private string mOBS = "";
        private string mRIF = "";
        private string mTELE = "";

        public string CODA
        {
            get
            {
                return mCODA;
            }
            set
            {
                mCODA = value;
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

        public string CONTACTO
        {
            get
            {
                return mCONTACTO;
            }
            set
            {
                mCONTACTO = value;
            }
        }

        public Double CREDITOS
        {
            get
            {
                return mCREDITOS;
            }
            set
            {
                mCREDITOS = value;
            }
        }

        public string CUEN_BAN
        {
            get
            {
                return mCUEN_BAN;
            }
            set
            {
                mCUEN_BAN = value;
            }
        }

        public Double DEBITOS
        {
            get
            {
                return mDEBITOS;
            }
            set
            {
                mDEBITOS = value;
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

        public string DIR1
        {
            get
            {
                return mDIR1;
            }
            set
            {
                mDIR1 = value;
            }
        }

        public string DIR2
        {
            get
            {
                return mDIR2;
            }
            set
            {
                mDIR2 = value;
            }
        }

        public string DIR3
        {
            get
            {
                return mDIR3;
            }
            set
            {
                mDIR3 = value;
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

        public string NIT
        {
            get
            {
                return mNIT;
            }
            set
            {
                mNIT = value;
            }
        }

        public string OBS
        {
            get
            {
                return mOBS;
            }
            set
            {
                mOBS = value;
            }
        }

        public string RIF
        {
            get
            {
                return mRIF;
            }
            set
            {
                mRIF = value;
            }
        }

        public string TELE
        {
            get
            {
                return mTELE;
            }
            set
            {
                mTELE = value;
            }
        }

        PROVEE()
        {
        }

        PROVEE(string CODA, string CODIGO, string CONTACTO, double CREDITOS, string CUEN_BAN, double DEBITOS, string DESCR, string DIR1, string DIR2, string DIR3, int ID, double MONTO, string NIT, string OBS, string RIF, string TELE)
        {
            mCODA = CODA;
            mCODIGO = CODIGO;
            mCONTACTO = CONTACTO;
            mCREDITOS = CREDITOS;
            mCUEN_BAN = CUEN_BAN;
            mDEBITOS = DEBITOS;
            mDESCR = DESCR;
            mDIR1 = DIR1;
            mDIR2 = DIR2;
            mDIR3 = DIR3;
            mID = ID;
            mMONTO = MONTO;
            mNIT = NIT;
            mOBS = OBS;
            mRIF = RIF;
            mTELE = TELE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
