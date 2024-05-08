using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TRANSFE_DET : ICloneable
    {

        private double mCANTIDAD = 0.0;
        private string mCODIGO = "";
        private double mCOSPRO = 0.0;
        private double mCOSULT = 0.0;
        private string mDESCR = "";
        private int mID = 0;
        private int mID_TRANSFE = 0;
        private double mPAQUETE = 0.0;
        private string mUNIDAD = "";
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

        public int ID_TRANSFE
        {
            get
            {
                return mID_TRANSFE;
            }
            set
            {
                mID_TRANSFE = value;
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

        public string UNIDAD
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

        TRANSFE_DET()
        {
        }

        TRANSFE_DET(double CANTIDAD, string CODIGO, double COSPRO, double COSULT, string DESCR, int ID, int ID_TRANSFE, double PAQUETE, string UNIDAD, double UNIEMPA)
        {
            mCANTIDAD = CANTIDAD;
            mCODIGO = CODIGO;
            mCOSPRO = COSPRO;
            mCOSULT = COSULT;
            mDESCR = DESCR;
            mID = ID;
            mID_TRANSFE = ID_TRANSFE;
            mPAQUETE = PAQUETE;
            mUNIDAD = UNIDAD;
            mUNIEMPA = UNIEMPA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
