using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONTEO_FIS_DET : ICloneable
    {

        private double mCANTIDAD = 0.0;
        private string mCODIGO = "";
        private double mCOSPRO = 0.0;
        private double mCOSULT = 0.0;
        private string mDESCR = "";
        private string mDPTO = "";
        private double mEXIS = 0.0;
        private int mID = 0;
        private int mID_CONTEO = 0;
        private double mPAQUETE = 0.0;
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

        public Double EXIS
        {
            get
            {
                return mEXIS;
            }
            set
            {
                mEXIS = value;
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

        public int ID_CONTEO
        {
            get
            {
                return mID_CONTEO;
            }
            set
            {
                mID_CONTEO = value;
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

        CONTEO_FIS_DET()
        {
        }

        CONTEO_FIS_DET(double CANTIDAD, string CODIGO, double COSPRO, double COSULT, string DESCR, string DPTO, double EXIS, int ID, int ID_CONTEO, double PAQUETE, double UNIEMPA)
        {
            mCANTIDAD = CANTIDAD;
            mCODIGO = CODIGO;
            mCOSPRO = COSPRO;
            mCOSULT = COSULT;
            mDESCR = DESCR;
            mDPTO = DPTO;
            mEXIS = EXIS;
            mID = ID;
            mID_CONTEO = ID_CONTEO;
            mPAQUETE = PAQUETE;
            mUNIEMPA = UNIEMPA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
