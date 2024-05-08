using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class AJUSTE_DET : ICloneable
    {

        private double mCANTIDAD = 0.0;
        private double mCLASIFI = 0.0;
        private string mCODIGO = "";
        private double mCOSPRO = 0.0;
        private double mCOSULT = 0.0;
        private string mDESCR = "";
        private string mDPTO = "";
        private int mID = 0;
        private int mID_AJUSTE = 0;
        private double mPAQUETE = 0.0;
        private double mPRECIO = 0.0;
        private string mSERIAL = "";
        private int mSYSSERIAL = 0;
        private double mTDESCU = 0.0;
        private double mUNIEMPA = 0.0;

        public Double CANTIDAD
        {
            get
            {
                return mCANTIDAD;
            }
            set
            {
                mCANTIDAD = value;
            }
        }

        public Double CLASIFI
        {
            get
            {
                return mCLASIFI;
            }
            set
            {
                mCLASIFI = value;
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

        public Double COSPRO
        {
            get
            {
                return mCOSPRO;
            }
            set
            {
                mCOSPRO = value;
            }
        }

        public Double COSULT
        {
            get
            {
                return mCOSULT;
            }
            set
            {
                mCOSULT = value;
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

        public int ID_AJUSTE
        {
            get
            {
                return mID_AJUSTE;
            }
            set
            {
                mID_AJUSTE = value;
            }
        }

        public Double PAQUETE
        {
            get
            {
                return mPAQUETE;
            }
            set
            {
                mPAQUETE = value;
            }
        }

        public Double PRECIO
        {
            get
            {
                return mPRECIO;
            }
            set
            {
                mPRECIO = value;
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

        public int SYSSERIAL
        {
            get
            {
                return mSYSSERIAL;
            }
            set
            {
                mSYSSERIAL = value;
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

        public Double UNIEMPA
        {
            get
            {
                return mUNIEMPA;
            }
            set
            {
                mUNIEMPA = value;
            }
        }

        AJUSTE_DET()
        {
        }

        AJUSTE_DET(double CANTIDAD, double CLASIFI, string CODIGO, double COSPRO, double COSULT, string DESCR, string DPTO, int ID, int ID_AJUSTE, double PAQUETE, double PRECIO, string SERIAL, int SYSSERIAL, double TDESCU, double UNIEMPA)
        {
            mCANTIDAD = CANTIDAD;
            mCLASIFI = CLASIFI;
            mCODIGO = CODIGO;
            mCOSPRO = COSPRO;
            mCOSULT = COSULT;
            mDESCR = DESCR;
            mDPTO = DPTO;
            mID = ID;
            mID_AJUSTE = ID_AJUSTE;
            mPAQUETE = PAQUETE;
            mPRECIO = PRECIO;
            mSERIAL = SERIAL;
            mSYSSERIAL = SYSSERIAL;
            mTDESCU = TDESCU;
            mUNIEMPA = UNIEMPA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
