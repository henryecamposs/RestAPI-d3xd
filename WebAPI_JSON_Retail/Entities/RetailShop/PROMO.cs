using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROMO : ICloneable
    {

        private double mACUMULA = 0.0;
        private string mCITEMPROMO = "";
        private string mCODIGO = "";
        private double mDELY = 0.0;
        private string mDESCR = "";
        private string mDESCR1 = "";
        private double mDESCUENTO = 0.0;
        private DateTime mDFECHA = new DateTime(2000, 01, 01);
        private string mDHORA = "";
        private double mDHORAM = 0.0;
        private string mDITEMPROMO = "";
        private double mDOMINGO = 0.0;
        private double mGLOBAL = 0.0;
        private DateTime mHFECHA = new DateTime(2000, 01, 01);
        private string mHHORA = "";
        private double mHHORAM = 0.0;
        private double mID = 0.0;
        private int mIDSUC = 0;
        private int mID_PROMO = 0;
        private double mINACTIVA = 0.0;
        private double mJUEVES = 0.0;
        private double mLLEVAR = 0.0;
        private double mLUNES = 0.0;
        private double mMARTES = 0.0;
        private double mMESAS = 0.0;
        private double mMIERCOLES = 0.0;
        private double mPROMO = 0.0;
        private double mSABADO = 0.0;
        private double mTDESCU = 0.0;
        private double mTIPO = 0.0;
        private double mTPRECIO = 0.0;
        private double mVD = 0.0;
        private double mVIERNES = 0.0;

        public Double ACUMULA
        {
            get
            {
                return mACUMULA;
            }
            set
            {
                mACUMULA = value;
            }
        }

        public string CITEMPROMO
        {
            get
            {
                return mCITEMPROMO;
            }
            set
            {
                mCITEMPROMO = value;
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

        public Double DELY
        {
            get
            {
                return mDELY;
            }
            set
            {
                mDELY = value;
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

        public string DESCR1
        {
            get
            {
                return mDESCR1;
            }
            set
            {
                mDESCR1 = value;
            }
        }

        public Double DESCUENTO
        {
            get
            {
                return mDESCUENTO;
            }
            set
            {
                mDESCUENTO = value;
            }
        }

        public DateTime DFECHA
        {
            get
            {
                return mDFECHA;
            }
            set
            {
                mDFECHA = value;
            }
        }

        public string DHORA
        {
            get
            {
                return mDHORA;
            }
            set
            {
                mDHORA = value;
            }
        }

        public Double DHORAM
        {
            get
            {
                return mDHORAM;
            }
            set
            {
                mDHORAM = value;
            }
        }

        public string DITEMPROMO
        {
            get
            {
                return mDITEMPROMO;
            }
            set
            {
                mDITEMPROMO = value;
            }
        }

        public Double DOMINGO
        {
            get
            {
                return mDOMINGO;
            }
            set
            {
                mDOMINGO = value;
            }
        }

        public Double GLOBAL
        {
            get
            {
                return mGLOBAL;
            }
            set
            {
                mGLOBAL = value;
            }
        }

        public DateTime HFECHA
        {
            get
            {
                return mHFECHA;
            }
            set
            {
                mHFECHA = value;
            }
        }

        public string HHORA
        {
            get
            {
                return mHHORA;
            }
            set
            {
                mHHORA = value;
            }
        }

        public Double HHORAM
        {
            get
            {
                return mHHORAM;
            }
            set
            {
                mHHORAM = value;
            }
        }

        public Double ID
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

        public int ID_PROMO
        {
            get
            {
                return mID_PROMO;
            }
            set
            {
                mID_PROMO = value;
            }
        }

        public Double INACTIVA
        {
            get
            {
                return mINACTIVA;
            }
            set
            {
                mINACTIVA = value;
            }
        }

        public Double JUEVES
        {
            get
            {
                return mJUEVES;
            }
            set
            {
                mJUEVES = value;
            }
        }

        public Double LLEVAR
        {
            get
            {
                return mLLEVAR;
            }
            set
            {
                mLLEVAR = value;
            }
        }

        public Double LUNES
        {
            get
            {
                return mLUNES;
            }
            set
            {
                mLUNES = value;
            }
        }

        public Double MARTES
        {
            get
            {
                return mMARTES;
            }
            set
            {
                mMARTES = value;
            }
        }

        public Double MESAS
        {
            get
            {
                return mMESAS;
            }
            set
            {
                mMESAS = value;
            }
        }

        public Double MIERCOLES
        {
            get
            {
                return mMIERCOLES;
            }
            set
            {
                mMIERCOLES = value;
            }
        }

        public Double pROMO
        {
            get
            {
                return mPROMO;
            }
            set
            {
                mPROMO = value;
            }
        }

        public Double SABADO
        {
            get
            {
                return mSABADO;
            }
            set
            {
                mSABADO = value;
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

        public Double TPRECIO
        {
            get
            {
                return mTPRECIO;
            }
            set
            {
                mTPRECIO = value;
            }
        }

        public Double VD
        {
            get
            {
                return mVD;
            }
            set
            {
                mVD = value;
            }
        }

        public Double VIERNES
        {
            get
            {
                return mVIERNES;
            }
            set
            {
                mVIERNES = value;
            }
        }

        PROMO()
        {
        }

        PROMO(double ACUMULA, string CITEMPROMO, string CODIGO, double DELY, string DESCR, string DESCR1, double DESCUENTO, DateTime DFECHA, string DHORA, double DHORAM, string DITEMPROMO, double DOMINGO, double GLOBAL, DateTime HFECHA, string HHORA, double HHORAM, double ID, int IDSUC, int ID_PROMO, double INACTIVA, double JUEVES, double LLEVAR, double LUNES, double MARTES, double MESAS, double MIERCOLES, double PROMO, double SABADO, double TDESCU, double TIPO, double TPRECIO, double VD, double VIERNES)
        {
            mACUMULA = ACUMULA;
            mCITEMPROMO = CITEMPROMO;
            mCODIGO = CODIGO;
            mDELY = DELY;
            mDESCR = DESCR;
            mDESCR1 = DESCR1;
            mDESCUENTO = DESCUENTO;
            mDFECHA = DFECHA;
            mDHORA = DHORA;
            mDHORAM = DHORAM;
            mDITEMPROMO = DITEMPROMO;
            mDOMINGO = DOMINGO;
            mGLOBAL = GLOBAL;
            mHFECHA = HFECHA;
            mHHORA = HHORA;
            mHHORAM = HHORAM;
            mID = ID;
            mIDSUC = IDSUC;
            mID_PROMO = ID_PROMO;
            mINACTIVA = INACTIVA;
            mJUEVES = JUEVES;
            mLLEVAR = LLEVAR;
            mLUNES = LUNES;
            mMARTES = MARTES;
            mMESAS = MESAS;
            mMIERCOLES = MIERCOLES;
            mPROMO = PROMO;
            mSABADO = SABADO;
            mTDESCU = TDESCU;
            mTIPO = TIPO;
            mTPRECIO = TPRECIO;
            mVD = VD;
            mVIERNES = VIERNES;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
