using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_RETENCIONES : ICloneable
    {

        private double mACTUAL = 0.0;
        private string mCAJA = "";
        private string mCOD_PAGO = "";
        private string mEMPLE = "";
        private double mESTADO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private DateTime mFECHA_RET = new DateTime(2000, 01, 01);
        private DateTime mFREFE = new DateTime(2000, 01, 01);
        private string mGUID_CXC = "";
        private int mID = 0;
        private double mMODO = 0.0;
        private double mMONTO_RET = 0.0;
        private string mNRO_RET = "";
        private double mPRET = 0.0;
        private double mSOBRE = 0.0;
        private double mTIPO_RET = 0.0;
        private string mTREFE = "";
        private string mUID = "";
        private string mUID_NCI = "";
        private string mUID_REF = "";
        private double mEstatus = 0.0;

        public Double ACTUAL
        {
            get
            {
                return mACTUAL;
            }
            set
            {
                mACTUAL = value;
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

        public string COD_PAGO
        {
            get
            {
                return mCOD_PAGO;
            }
            set
            {
                mCOD_PAGO = value;
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

        public Double ESTADO
        {
            get
            {
                return mESTADO;
            }
            set
            {
                mESTADO = value;
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

        public DateTime FECHA_RET
        {
            get
            {
                return mFECHA_RET;
            }
            set
            {
                mFECHA_RET = value;
            }
        }

        public DateTime FREFE
        {
            get
            {
                return mFREFE;
            }
            set
            {
                mFREFE = value;
            }
        }

        public string GUID_CXC
        {
            get
            {
                return mGUID_CXC;
            }
            set
            {
                mGUID_CXC = value;
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

        public Double MODO
        {
            get
            {
                return mMODO;
            }
            set
            {
                mMODO = value;
            }
        }

        public Double MONTO_RET
        {
            get
            {
                return mMONTO_RET;
            }
            set
            {
                mMONTO_RET = value;
            }
        }

        public string NRO_RET
        {
            get
            {
                return mNRO_RET;
            }
            set
            {
                mNRO_RET = value;
            }
        }

        public Double PRET
        {
            get
            {
                return mPRET;
            }
            set
            {
                mPRET = value;
            }
        }

        public Double SOBRE
        {
            get
            {
                return mSOBRE;
            }
            set
            {
                mSOBRE = value;
            }
        }

        public Double TIPO_RET
        {
            get
            {
                return mTIPO_RET;
            }
            set
            {
                mTIPO_RET = value;
            }
        }

        public string TREFE
        {
            get
            {
                return mTREFE;
            }
            set
            {
                mTREFE = value;
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

        public string UID_NCI
        {
            get
            {
                return mUID_NCI;
            }
            set
            {
                mUID_NCI = value;
            }
        }

        public string UID_REF
        {
            get
            {
                return mUID_REF;
            }
            set
            {
                mUID_REF = value;
            }
        }

        public Double Estatus
        {
            get
            {
                return mEstatus;
            }
            set
            {
                mEstatus = value;
            }
        }

        CLIENTE_RETENCIONES()
        {
        }

        CLIENTE_RETENCIONES(double ACTUAL, string CAJA, string COD_PAGO, string EMPLE, double ESTADO, DateTime FECHA, DateTime FECHA_RET, DateTime FREFE, string GUID_CXC, int ID, double MODO, double MONTO_RET, string NRO_RET, double PRET, double SOBRE, double TIPO_RET, string TREFE, string UID, string UID_NCI, string UID_REF, double estatus)
        {
            mACTUAL = ACTUAL;
            mCAJA = CAJA;
            mCOD_PAGO = COD_PAGO;
            mEMPLE = EMPLE;
            mESTADO = ESTADO;
            mFECHA = FECHA;
            mFECHA_RET = FECHA_RET;
            mFREFE = FREFE;
            mGUID_CXC = GUID_CXC;
            mID = ID;
            mMODO = MODO;
            mMONTO_RET = MONTO_RET;
            mNRO_RET = NRO_RET;
            mPRET = PRET;
            mSOBRE = SOBRE;
            mTIPO_RET = TIPO_RET;
            mTREFE = TREFE;
            mUID = UID;
            mUID_NCI = UID_NCI;
            mUID_REF = UID_REF;
            mEstatus = Estatus;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
