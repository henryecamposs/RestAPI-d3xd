using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPOP : ICloneable
    {

        private string mBANCO = "";
        private double mCANTI = 0.0;
        private string mCBANCO = "";
        private string mCEDULA = "";
        private double mCHEQUE = 0.0;
        private string mCODIGO = "";
        private double mCODMON = 0.0;
        private double mCOD_VAL = 0.0;
        private double mCOM_PVB = 0.0;
        private string mDESCR = "";
        private string mDIRECCION = "";
        private double mDONACION = 0.0;
        private string mEMISOR = "";
        private string mEXPIRA = "";
        private int mID = 0;
        private int mID_BANCO = 0;
        private int mID_CUSTO = 0;
        private int mID_PAGO = 0;
        private int mID_PVB = 0;
        private double mISLR_PVB = 0.0;
        private double mMONTO = 0.0;
        private double mMON_CONV = 0.0;
        private double mMON_DES = 0.0;
        private double mPCANTI = 0.0;
        private double mPMONTO = 0.0;
        private double mPORC = 0.0;
        private double mPROPINA = 0.0;
        private double mRIMPALI = 0.0;
        private double mSALDO_FAV = 0.0;
        private string mTELEFONO = "";
        private string mTIPO = "";
        private double mVAN = 0.0;
        private double mVAUCHE = 0.0;

        public string BANCO
        {
            get
            {
                return mBANCO;
            }
            set
            {
                mBANCO = value;
            }
        }

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

        public string CBANCO
        {
            get
            {
                return mCBANCO;
            }
            set
            {
                mCBANCO = value;
            }
        }

        public string CEDULA
        {
            get
            {
                return mCEDULA;
            }
            set
            {
                mCEDULA = value;
            }
        }

        public Double CHEQUE
        {
            get
            {
                return mCHEQUE;
            }
            set
            {
                mCHEQUE = value;
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

        public Double CODMON
        {
            get
            {
                return mCODMON;
            }
            set
            {
                mCODMON = value;
            }
        }

        public Double COD_VAL
        {
            get
            {
                return mCOD_VAL;
            }
            set
            {
                mCOD_VAL = value;
            }
        }

        public Double COM_PVB
        {
            get
            {
                return mCOM_PVB;
            }
            set
            {
                mCOM_PVB = value;
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

        public string DIRECCION
        {
            get
            {
                return mDIRECCION;
            }
            set
            {
                mDIRECCION = value;
            }
        }

        public Double DONACION
        {
            get
            {
                return mDONACION;
            }
            set
            {
                mDONACION = value;
            }
        }

        public string EMISOR
        {
            get
            {
                return mEMISOR;
            }
            set
            {
                mEMISOR = value;
            }
        }

        public string EXPIRA
        {
            get
            {
                return mEXPIRA;
            }
            set
            {
                mEXPIRA = value;
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

        public int ID_BANCO
        {
            get
            {
                return mID_BANCO;
            }
            set
            {
                mID_BANCO = value;
            }
        }

        public int ID_CUSTO
        {
            get
            {
                return mID_CUSTO;
            }
            set
            {
                mID_CUSTO = value;
            }
        }

        public int ID_PAGO
        {
            get
            {
                return mID_PAGO;
            }
            set
            {
                mID_PAGO = value;
            }
        }

        public int ID_PVB
        {
            get
            {
                return mID_PVB;
            }
            set
            {
                mID_PVB = value;
            }
        }

        public Double ISLR_PVB
        {
            get
            {
                return mISLR_PVB;
            }
            set
            {
                mISLR_PVB = value;
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

        public Double MON_CONV
        {
            get
            {
                return mMON_CONV;
            }
            set
            {
                mMON_CONV = value;
            }
        }

        public Double MON_DES
        {
            get
            {
                return mMON_DES;
            }
            set
            {
                mMON_DES = value;
            }
        }

        public Double PCANTI
        {
            get
            {
                return mPCANTI;
            }
            set
            {
                mPCANTI = value;
            }
        }

        public Double PMONTO
        {
            get
            {
                return mPMONTO;
            }
            set
            {
                mPMONTO = value;
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

        public Double RIMPALI
        {
            get
            {
                return mRIMPALI;
            }
            set
            {
                mRIMPALI = value;
            }
        }

        public Double SALDO_FAV
        {
            get
            {
                return mSALDO_FAV;
            }
            set
            {
                mSALDO_FAV = value;
            }
        }

        public string TELEFONO
        {
            get
            {
                return mTELEFONO;
            }
            set
            {
                mTELEFONO = value;
            }
        }

        public string TIPO
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

        public Double VAN
        {
            get
            {
                return mVAN;
            }
            set
            {
                mVAN = value;
            }
        }

        public Double VAUCHE
        {
            get
            {
                return mVAUCHE;
            }
            set
            {
                mVAUCHE = value;
            }
        }

        TIPOP()
        {
        }

        TIPOP(string BANCO, double CANTI, string CBANCO, string CEDULA, double CHEQUE, string CODIGO, double CODMON, double COD_VAL, double COM_PVB, string DESCR, string DIRECCION, double DONACION, string EMISOR, string EXPIRA, int ID, int ID_BANCO, int ID_CUSTO, int ID_PAGO, int ID_PVB, double ISLR_PVB, double MONTO, double MON_CONV, double MON_DES, double PCANTI, double PMONTO, double PORC, double PROPINA, double RIMPALI, double SALDO_FAV, string TELEFONO, string TIPO, double VAN, double VAUCHE)
        {
            mBANCO = BANCO;
            mCANTI = CANTI;
            mCBANCO = CBANCO;
            mCEDULA = CEDULA;
            mCHEQUE = CHEQUE;
            mCODIGO = CODIGO;
            mCODMON = CODMON;
            mCOD_VAL = COD_VAL;
            mCOM_PVB = COM_PVB;
            mDESCR = DESCR;
            mDIRECCION = DIRECCION;
            mDONACION = DONACION;
            mEMISOR = EMISOR;
            mEXPIRA = EXPIRA;
            mID = ID;
            mID_BANCO = ID_BANCO;
            mID_CUSTO = ID_CUSTO;
            mID_PAGO = ID_PAGO;
            mID_PVB = ID_PVB;
            mISLR_PVB = ISLR_PVB;
            mMONTO = MONTO;
            mMON_CONV = MON_CONV;
            mMON_DES = MON_DES;
            mPCANTI = PCANTI;
            mPMONTO = PMONTO;
            mPORC = PORC;
            mPROPINA = PROPINA;
            mRIMPALI = RIMPALI;
            mSALDO_FAV = SALDO_FAV;
            mTELEFONO = TELEFONO;
            mTIPO = TIPO;
            mVAN = VAN;
            mVAUCHE = VAUCHE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
