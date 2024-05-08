using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DPTO_CAJAS : ICloneable
    {

        private string mBANDERA = "";
        private string mCADUCIDAD = "";
        private double mCLASE = 0.0;
        private string mCODIGO = "";
        private string mDESCR = "";
        private string mFAMILIA = "";
        private string mFLAG = "";
        private string mGRUPO = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mIVA = 0.0;
        private double mMONTO = 0.0;
        private double mPESO = 0.0;
        private double mPIDE_DES = 0.0;
        private double mPORC = 0.0;
        private double mPORC_C = 0.0;
        private double mPORC_M = 0.0;
        private string mSECCION = "";
        private string mSUB_SECC = "";
        private string mTECLA = "";
        private string mTECLA1 = "";
        private double mTIVA = 0.0;
        private double mTIVA2 = 0.0;

        public string BANDERA
        {
            get
            {
                return mBANDERA;
            }
            set
            {
                mBANDERA = value;
            }
        }

        public string CADUCIDAD
        {
            get
            {
                return mCADUCIDAD;
            }
            set
            {
                mCADUCIDAD = value;
            }
        }

        public Double CLASE
        {
            get
            {
                return mCLASE;
            }
            set
            {
                mCLASE = value;
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

        public string FAMILIA
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

        public string FLAG
        {
            get
            {
                return mFLAG;
            }
            set
            {
                mFLAG = value;
            }
        }

        public string GRUPO
        {
            get
            {
                return mGRUPO;
            }
            set
            {
                mGRUPO = value;
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

        public Double PESO
        {
            get
            {
                return mPESO;
            }
            set
            {
                mPESO = value;
            }
        }

        public Double PIDE_DES
        {
            get
            {
                return mPIDE_DES;
            }
            set
            {
                mPIDE_DES = value;
            }
        }

        public Double PORC
        {
            get
            {
                return mPORC;
            }
            set
            {
                mPORC = value;
            }
        }

        public Double PORC_C
        {
            get
            {
                return mPORC_C;
            }
            set
            {
                mPORC_C = value;
            }
        }

        public Double PORC_M
        {
            get
            {
                return mPORC_M;
            }
            set
            {
                mPORC_M = value;
            }
        }

        public string SECCION
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

        public string SUB_SECC
        {
            get
            {
                return mSUB_SECC;
            }
            set
            {
                mSUB_SECC = value;
            }
        }

        public string TECLA
        {
            get
            {
                return mTECLA;
            }
            set
            {
                mTECLA = value;
            }
        }

        public string TECLA1
        {
            get
            {
                return mTECLA1;
            }
            set
            {
                mTECLA1 = value;
            }
        }

        public Double TIVA
        {
            get
            {
                return mTIVA;
            }
            set
            {
                mTIVA = value;
            }
        }

        public Double TIVA2
        {
            get
            {
                return mTIVA2;
            }
            set
            {
                mTIVA2 = value;
            }
        }

        DPTO_CAJAS()
        {
        }

        DPTO_CAJAS(string BANDERA, string CADUCIDAD, double CLASE, string CODIGO, string DESCR, string FAMILIA, string FLAG, string GRUPO, int ID, int IDSUC, double IVA, double MONTO, double PESO, double PIDE_DES, double PORC, double PORC_C, double PORC_M, string SECCION, string SUB_SECC, string TECLA, string TECLA1, double TIVA, double TIVA2)
        {
            mBANDERA = BANDERA;
            mCADUCIDAD = CADUCIDAD;
            mCLASE = CLASE;
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mFAMILIA = FAMILIA;
            mFLAG = FLAG;
            mGRUPO = GRUPO;
            mID = ID;
            mIDSUC = IDSUC;
            mIVA = IVA;
            mMONTO = MONTO;
            mPESO = PESO;
            mPIDE_DES = PIDE_DES;
            mPORC = PORC;
            mPORC_C = PORC_C;
            mPORC_M = PORC_M;
            mSECCION = SECCION;
            mSUB_SECC = SUB_SECC;
            mTECLA = TECLA;
            mTECLA1 = TECLA1;
            mTIVA = TIVA;
            mTIVA2 = TIVA2;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
