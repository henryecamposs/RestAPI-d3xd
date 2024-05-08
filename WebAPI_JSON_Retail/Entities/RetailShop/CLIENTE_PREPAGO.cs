using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_PREPAGO : ICloneable
    {

        private double mANULADO = 0.0;
        private string mCAJA = "";
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_CUSTO = 0;
        private int mID_DOCU = 0;
        private double mMONTO = 0.0;
        private string mNOMEMP = "";
        private double mNRODOCU = 0.0;
        private string mTIPO = "";
        private string mUID = "";
        private string mUIDFAC = "";

        public Double ANULADO
        {
            get
            {
                return mANULADO;
            }
            set
            {
                mANULADO = value;
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

        public string NOMEMP
        {
            get
            {
                return mNOMEMP;
            }
            set
            {
                mNOMEMP = value;
            }
        }

        public Double NRODOCU
        {
            get
            {
                return mNRODOCU;
            }
            set
            {
                mNRODOCU = value;
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

        CLIENTE_PREPAGO()
        {
        }

        CLIENTE_PREPAGO(double ANULADO, string CAJA, string EMPLE, DateTime FECHA, int ID, int IDSUC, int ID_CUSTO, int ID_DOCU, double MONTO, string NOMEMP, double NRODOCU, string TIPO, string UID, string UIDFAC)
        {
            mANULADO = ANULADO;
            mCAJA = CAJA;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mID = ID;
            mIDSUC = IDSUC;
            mID_CUSTO = ID_CUSTO;
            mID_DOCU = ID_DOCU;
            mMONTO = MONTO;
            mNOMEMP = NOMEMP;
            mNRODOCU = NRODOCU;
            mTIPO = TIPO;
            mUID = UID;
            mUIDFAC = UIDFAC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
