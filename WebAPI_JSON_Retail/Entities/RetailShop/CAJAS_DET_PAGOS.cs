using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_DET_PAGOS : ICloneable
    {

        private string mBANCO = "";
        private string mCAJA = "";
        private string mCEDU = "";
        private double mCHEQUE = 0.0;
        private string mCODIGO = "";
        private double mCODMON = 0.0;
        private double mCOD_VAL = 0.0;
        private double mCOM_PVB = 0.0;
        private double mDONACION = 0.0;
        private string mEMISOR = "";
        private string mEMPLE = "";
        private string mEXPIRA = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private string mID = "";
        private int mIDSUC = 0;
        private int mID_BANCO = 0;
        private int mID_CUSTO = 0;
        private int mID_DETPA = 0;
        private int mID_DOCU = 0;
        private int mID_PVB = 0;
        private double mISLR_PVB = 0.0;
        private double mMONTO = 0.0;
        private double mMON_CONV = 0.0;
        private double mNRO = 0.0;
        private double mPORC = 0.0;
        private double mPROPI = 0.0;
        private double mRECIBIDO = 0.0;
        private double mSALDO_FAV = 0.0;
        private double mSESION = 0.0;
        private string mTELE = "";
        private string mTIPO = "";
        private string mTIPOD = "";
        private string mUIDCORTE = "";
        private string mUIDFAC = "";
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

        public string CEDU
        {
            get
            {
                return mCEDU;
            }
            set
            {
                mCEDU = value;
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

        public string EMPLE
        {
            get
            {
                return mEMPLE;
            }
            set
            {
                mEMPLE = value;
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

        public DateTime FECHA
        {
            get
            {
                return mFECHA;
            }
            set
            {
                mFECHA = value;
            }
        }

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
            }
        }

        public string ID
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

        public int ID_DETPA
        {
            get
            {
                return mID_DETPA;
            }
            set
            {
                mID_DETPA = value;
            }
        }

        public int ID_DOCU
        {
            get
            {
                return mID_DOCU;
            }
            set
            {
                mID_DOCU = value;
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

        public Double PROPI
        {
            get
            {
                return mPROPI;
            }
            set
            {
                mPROPI = value;
            }
        }

        public Double RECIBIDO
        {
            get
            {
                return mRECIBIDO;
            }
            set
            {
                mRECIBIDO = value;
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

        public Double SESION
        {
            get
            {
                return mSESION;
            }
            set
            {
                mSESION = value;
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

        public string TIPOD
        {
            get
            {
                return mTIPOD;
            }
            set
            {
                mTIPOD = value;
            }
        }

        public string UIDCORTE
        {
            get
            {
                return mUIDCORTE;
            }
            set
            {
                mUIDCORTE = value;
            }
        }

        public string UIDFAC
        {
            get
            {
                return mUIDFAC;
            }
            set
            {
                mUIDFAC = value;
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

        CAJAS_DET_PAGOS()
        {
        }

        CAJAS_DET_PAGOS(string BANCO, string CAJA, string CEDU, double CHEQUE, string CODIGO, double CODMON, double COD_VAL, double COM_PVB, double DONACION, string EMISOR, string EMPLE, string EXPIRA, DateTime FECHA, string FECHAC, string ID, int IDSUC, int ID_BANCO, int ID_CUSTO, int ID_DETPA, int ID_DOCU, int ID_PVB, double ISLR_PVB, double MONTO, double MON_CONV, double NRO, double PORC, double PROPI, double RECIBIDO, double SALDO_FAV, double SESION, string TELE, string TIPO, string TIPOD, string UIDCORTE, string UIDFAC, double VAUCHE)
        {
            mBANCO = BANCO;
            mCAJA = CAJA;
            mCEDU = CEDU;
            mCHEQUE = CHEQUE;
            mCODIGO = CODIGO;
            mCODMON = CODMON;
            mCOD_VAL = COD_VAL;
            mCOM_PVB = COM_PVB;
            mDONACION = DONACION;
            mEMISOR = EMISOR;
            mEMPLE = EMPLE;
            mEXPIRA = EXPIRA;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mID_BANCO = ID_BANCO;
            mID_CUSTO = ID_CUSTO;
            mID_DETPA = ID_DETPA;
            mID_DOCU = ID_DOCU;
            mID_PVB = ID_PVB;
            mISLR_PVB = ISLR_PVB;
            mMONTO = MONTO;
            mMON_CONV = MON_CONV;
            mNRO = NRO;
            mPORC = PORC;
            mPROPI = PROPI;
            mRECIBIDO = RECIBIDO;
            mSALDO_FAV = SALDO_FAV;
            mSESION = SESION;
            mTELE = TELE;
            mTIPO = TIPO;
            mTIPOD = TIPOD;
            mUIDCORTE = UIDCORTE;
            mUIDFAC = UIDFAC;
            mVAUCHE = VAUCHE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
