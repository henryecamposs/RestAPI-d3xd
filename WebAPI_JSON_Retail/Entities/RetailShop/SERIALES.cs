using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERIALES : ICloneable
    {

        private string mCAJA = "";
        private string mCAJADEV = "";
        private int mCLIENTE = 0;
        private string mCODIGO = "";
        private double mDEV = 0.0;
        private string mDPTO = "";
        private double mESTADO = 0.0;
        private DateTime mFECHAD = new DateTime(2000, 01, 01);
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private double mGARANTIA = 0.0;
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNRO = 0.0;
        private double mNROCOMPRA = 0.0;
        private string mNROCOMPRAC = "";
        private string mPROVEE = "";
        private string mSERIAL = "";
        private int mSysserial = 0;

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

        public string CAJADEV
        {
            get
            {
                return mCAJADEV;
            }
            set
            {
                mCAJADEV = value;
            }
        }

        public int CLIENTE
        {
            get
            {
                return mCLIENTE;
            }
            set
            {
                mCLIENTE = value;
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

        public Double DEV
        {
            get
            {
                return mDEV;
            }
            set
            {
                mDEV = value;
            }
        }

        public string DPTO
        {
            get
            {
                return mDPTO;
            }
            set
            {
                mDPTO = value;
            }
        }

        public Double ESTADO
        {
            get
            {
                return mESTADO;
            }
            set
            {
                mESTADO = value;
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

        public DateTime FECHAV
        {
            get
            {
                return mFECHAV;
            }
            set
            {
                mFECHAV = value;
            }
        }

        public Double GARANTIA
        {
            get
            {
                return mGARANTIA;
            }
            set
            {
                mGARANTIA = value;
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

        public Double NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        public Double NROCOMPRA
        {
            get
            {
                return mNROCOMPRA;
            }
            set
            {
                mNROCOMPRA = value;
            }
        }

        public string NROCOMPRAC
        {
            get
            {
                return mNROCOMPRAC;
            }
            set
            {
                mNROCOMPRAC = value;
            }
        }

        public string PROVEE
        {
            get
            {
                return mPROVEE;
            }
            set
            {
                mPROVEE = value;
            }
        }

        public string SERIAL
        {
            get
            {
                return mSERIAL;
            }
            set
            {
                mSERIAL = value;
            }
        }

        public int Sysserial
        {
            get
            {
                return mSysserial;
            }
            set
            {
                mSysserial = value;
            }
        }

        SERIALES()
        {
        }

        SERIALES(string CAJA, string CAJADEV, int CLIENTE, string CODIGO, double DEV, string DPTO, double ESTADO, DateTime FECHAD, DateTime FECHAV, double GARANTIA, int ID, int IDSUC, double NRO, double NROCOMPRA, string NROCOMPRAC, string PROVEE, string SERIAL, int sysserial)
        {
            mCAJA = CAJA;
            mCAJADEV = CAJADEV;
            mCLIENTE = CLIENTE;
            mCODIGO = CODIGO;
            mDEV = DEV;
            mDPTO = DPTO;
            mESTADO = ESTADO;
            mFECHAD = FECHAD;
            mFECHAV = FECHAV;
            mGARANTIA = GARANTIA;
            mID = ID;
            mIDSUC = IDSUC;
            mNRO = NRO;
            mNROCOMPRA = NROCOMPRA;
            mNROCOMPRAC = NROCOMPRAC;
            mPROVEE = PROVEE;
            mSERIAL = SERIAL;
            mSysserial = Sysserial;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
