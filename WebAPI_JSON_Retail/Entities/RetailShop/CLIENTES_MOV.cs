using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTES_MOV : ICloneable
    {

        private double mABONO = 0.0;
        private double mABONOINI = 0.0;
        private double mABONO_NR = 0.0;
        private string mCAJA = "";
        private string mCAJAREFE = "";
        private int mCLIENTE = 0;
        private double mDIAS = 0.0;
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAREFE = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDCLIASO2 = 0;
        private int mIDCLIASO3 = 0;
        private int mIDSUC = 0;
        private int mID_DOCU = 0;
        private int mID_REFE = 0;
        private double mMONREFE = 0.0;
        private double mMONTO = 0.0;
        private double mNRO = 0.0;
        private double mNRO_REFE = 0.0;
        private double mTIPO = 0.0;
        private double mTIPOREFE = 0.0;
        private string mUID = "";
        private string mUIDFAC = "";
        private string mUID_REFE = "";

        public Double ABONO
        {
            get
            {
                return mABONO;
            }
            set
            {
                mABONO = value;
            }
        }

        public Double ABONOINI
        {
            get
            {
                return mABONOINI;
            }
            set
            {
                mABONOINI = value;
            }
        }

        public Double ABONO_NR
        {
            get
            {
                return mABONO_NR;
            }
            set
            {
                mABONO_NR = value;
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

        public string CAJAREFE
        {
            get
            {
                return mCAJAREFE;
            }
            set
            {
                mCAJAREFE = value;
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

        public Double DIAS
        {
            get
            {
                return mDIAS;
            }
            set
            {
                mDIAS = value;
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

        public DateTime FECHAREFE
        {
            get
            {
                return mFECHAREFE;
            }
            set
            {
                mFECHAREFE = value;
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

        public int IDCLIASO2
        {
            get
            {
                return mIDCLIASO2;
            }
            set
            {
                mIDCLIASO2 = value;
            }
        }

        public int IDCLIASO3
        {
            get
            {
                return mIDCLIASO3;
            }
            set
            {
                mIDCLIASO3 = value;
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

        public int ID_REFE
        {
            get
            {
                return mID_REFE;
            }
            set
            {
                mID_REFE = value;
            }
        }

        public Double MONREFE
        {
            get
            {
                return mMONREFE;
            }
            set
            {
                mMONREFE = value;
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

        public Double NRO_REFE
        {
            get
            {
                return mNRO_REFE;
            }
            set
            {
                mNRO_REFE = value;
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

        public Double TIPOREFE
        {
            get
            {
                return mTIPOREFE;
            }
            set
            {
                mTIPOREFE = value;
            }
        }

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
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

        public string UID_REFE
        {
            get
            {
                return mUID_REFE;
            }
            set
            {
                mUID_REFE = value;
            }
        }

        CLIENTES_MOV()
        {
        }

        CLIENTES_MOV(double ABONO, double ABONOINI, double ABONO_NR, string CAJA, string CAJAREFE, int CLIENTE, double DIAS, string EMPLE, DateTime FECHA, string FECHAC, DateTime FECHAREFE, int ID, int IDCLIASO2, int IDCLIASO3, int IDSUC, int ID_DOCU, int ID_REFE, double MONREFE, double MONTO, double NRO, double NRO_REFE, double TIPO, double TIPOREFE, string UID, string UIDFAC, string UID_REFE)
        {
            mABONO = ABONO;
            mABONOINI = ABONOINI;
            mABONO_NR = ABONO_NR;
            mCAJA = CAJA;
            mCAJAREFE = CAJAREFE;
            mCLIENTE = CLIENTE;
            mDIAS = DIAS;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAREFE = FECHAREFE;
            mID = ID;
            mIDCLIASO2 = IDCLIASO2;
            mIDCLIASO3 = IDCLIASO3;
            mIDSUC = IDSUC;
            mID_DOCU = ID_DOCU;
            mID_REFE = ID_REFE;
            mMONREFE = MONREFE;
            mMONTO = MONTO;
            mNRO = NRO;
            mNRO_REFE = NRO_REFE;
            mTIPO = TIPO;
            mTIPOREFE = TIPOREFE;
            mUID = UID;
            mUIDFAC = UIDFAC;
            mUID_REFE = UID_REFE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
