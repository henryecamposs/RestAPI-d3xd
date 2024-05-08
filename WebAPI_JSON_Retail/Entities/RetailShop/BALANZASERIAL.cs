using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BALANZASERIAL : ICloneable
    {

        private string mCODIGO = "";
        private double mCONSO = 0.0;
        private double mETI = 0.0;
        private double mFAMILIA = 0.0;
        private int mID = 0;
        private string mNOMBRE = "";
        private double mPESADO = 0.0;
        private double mPUERTO = 0.0;
        private double mSECCION = 0.0;

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

        public Double CONSO
        {
            get
            {
                return mCONSO;
            }
            set
            {
                mCONSO = value;
            }
        }

        public Double ETI
        {
            get
            {
                return mETI;
            }
            set
            {
                mETI = value;
            }
        }

        public Double FAMILIA
        {
            get
            {
                return mFAMILIA;
            }
            set
            {
                mFAMILIA = value;
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

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double PESADO
        {
            get
            {
                return mPESADO;
            }
            set
            {
                mPESADO = value;
            }
        }

        public Double PUERTO
        {
            get
            {
                return mPUERTO;
            }
            set
            {
                mPUERTO = value;
            }
        }

        public Double SECCION
        {
            get
            {
                return mSECCION;
            }
            set
            {
                mSECCION = value;
            }
        }

        BALANZASERIAL()
        {
        }

        BALANZASERIAL(string CODIGO, double CONSO, double ETI, double FAMILIA, int ID, string NOMBRE, double PESADO, double PUERTO, double SECCION)
        {
            mCODIGO = CODIGO;
            mCONSO = CONSO;
            mETI = ETI;
            mFAMILIA = FAMILIA;
            mID = ID;
            mNOMBRE = NOMBRE;
            mPESADO = PESADO;
            mPUERTO = PUERTO;
            mSECCION = SECCION;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
