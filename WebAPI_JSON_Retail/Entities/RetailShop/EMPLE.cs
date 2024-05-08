using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class EMPLE : ICloneable
    {

        private string mAPELLIDO = "";
        private string mCARGO = "";
        private bool mCHOFER = false;
        private double mCLAVE = 0.0;
        private string mCLAVEC = "";
        private string mCODIGO = "";
        private string mCONTACTO = "";
        private string mDESCR = "";
        private string mDIR1 = "";
        private DateTime mFECHAESPI = new DateTime(2000, 01, 01);
        private DateTime mFECHAI = new DateTime(2000, 01, 01);
        private DateTime mFECHAN = new DateTime(2000, 01, 01);
        private DateTime mFECHAS = new DateTime(2000, 01, 01);
        private string mFOTO = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private string mNIT = "";
        private double mNIVEL = 0.0;
        private double mNLICENSIA = 0.0;
        private bool mNOCAMBIAC = false;
        private string mOBSERVA = "";
        private double mPROPINA = 0.0;
        private string mRIF = "";
        private double mSUELDO = 0.0;
        private string mTELE = "";
        private double mTPAGO = 0.0;
        private string mCampo1 = "";

        public string APELLIDO
        {
            get
            {
                return mAPELLIDO;
            }
            set
            {
                mAPELLIDO = value;
            }
        }

        public string CARGO
        {
            get
            {
                return mCARGO;
            }
            set
            {
                mCARGO = value;
            }
        }

        public Boolean CHOFER
        {
            get
            {
                return mCHOFER;
            }
            set
            {
                mCHOFER = value;
            }
        }

        public Double CLAVE
        {
            get
            {
                return mCLAVE;
            }
            set
            {
                mCLAVE = value;
            }
        }

        public string CLAVEC
        {
            get
            {
                return mCLAVEC;
            }
            set
            {
                mCLAVEC = value;
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

        public DateTime FECHAESPI
        {
            get
            {
                return mFECHAESPI;
            }
            set
            {
                mFECHAESPI = value;
            }
        }

        public DateTime FECHAI
        {
            get
            {
                return mFECHAI;
            }
            set
            {
                mFECHAI = value;
            }
        }

        public DateTime FECHAN
        {
            get
            {
                return mFECHAN;
            }
            set
            {
                mFECHAN = value;
            }
        }

        public DateTime FECHAS
        {
            get
            {
                return mFECHAS;
            }
            set
            {
                mFECHAS = value;
            }
        }

        public string FOTO
        {
            get
            {
                return mFOTO;
            }
            set
            {
                mFOTO = value;
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

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
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

        public Double NIVEL
        {
            get
            {
                return mNIVEL;
            }
            set
            {
                mNIVEL = value;
            }
        }

        public Double NLICENSIA
        {
            get
            {
                return mNLICENSIA;
            }
            set
            {
                mNLICENSIA = value;
            }
        }

        public Boolean NOCAMBIAC
        {
            get
            {
                return mNOCAMBIAC;
            }
            set
            {
                mNOCAMBIAC = value;
            }
        }

        public string OBSERVA
        {
            get
            {
                return mOBSERVA;
            }
            set
            {
                mOBSERVA = value;
            }
        }

        public Double PROPINA
        {
            get
            {
                return mPROPINA;
            }
            set
            {
                mPROPINA = value;
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

        public Double SUELDO
        {
            get
            {
                return mSUELDO;
            }
            set
            {
                mSUELDO = value;
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

        public Double TPAGO
        {
            get
            {
                return mTPAGO;
            }
            set
            {
                mTPAGO = value;
            }
        }

        public string Campo1
        {
            get
            {
                return mCampo1;
            }
            set
            {
                mCampo1 = value;
            }
        }

        EMPLE()
        {
        }

        EMPLE(string APELLIDO, string CARGO, bool CHOFER, double CLAVE, string CLAVEC, string CODIGO, string CONTACTO, string DESCR, string DIR1, DateTime FECHAESPI, DateTime FECHAI, DateTime FECHAN, DateTime FECHAS, string FOTO, int ID, int IDSUC, double INACTIVO, string NIT, double NIVEL, double NLICENSIA, bool NOCAMBIAC, string OBSERVA, double PROPINA, string RIF, double SUELDO, string TELE, double TPAGO, string campo1)
        {
            mAPELLIDO = APELLIDO;
            mCARGO = CARGO;
            mCHOFER = CHOFER;
            mCLAVE = CLAVE;
            mCLAVEC = CLAVEC;
            mCODIGO = CODIGO;
            mCONTACTO = CONTACTO;
            mDESCR = DESCR;
            mDIR1 = DIR1;
            mFECHAESPI = FECHAESPI;
            mFECHAI = FECHAI;
            mFECHAN = FECHAN;
            mFECHAS = FECHAS;
            mFOTO = FOTO;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mNIT = NIT;
            mNIVEL = NIVEL;
            mNLICENSIA = NLICENSIA;
            mNOCAMBIAC = NOCAMBIAC;
            mOBSERVA = OBSERVA;
            mPROPINA = PROPINA;
            mRIF = RIF;
            mSUELDO = SUELDO;
            mTELE = TELE;
            mTPAGO = TPAGO;
            mCampo1 = Campo1;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
