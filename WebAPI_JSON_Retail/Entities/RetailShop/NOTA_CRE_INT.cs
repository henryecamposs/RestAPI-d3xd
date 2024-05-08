using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class NOTA_CRE_INT : ICloneable
    {

        private string mCAJA = "";
        private int mCODCLI = 0;
        private double mEGRESO = 0.0;
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mMODO = 0.0;
        private double mMONTO = 0.0;
        private double mNRO = 0.0;
        private double mNRO_NCF = 0.0;
        private double mNRO_REFE = 0.0;
        private double mTIPO = 0.0;
        private string mTREFE = "";
        private string mUID = "";
        private string mUIDMOVCLI = "";
        private string mUID_CORTE = "";
        private string mUID_REFE = "";
        private double mMonto_ref = 0.0;

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

        public int CODCLI
        {
            get
            {
                return mCODCLI;
            }
            set
            {
                mCODCLI = value;
            }
        }

        public Double EGRESO
        {
            get
            {
                return mEGRESO;
            }
            set
            {
                mEGRESO = value;
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

        public Double NRO_NCF
        {
            get
            {
                return mNRO_NCF;
            }
            set
            {
                mNRO_NCF = value;
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

        public string UIDMOVCLI
        {
            get
            {
                return mUIDMOVCLI;
            }
            set
            {
                mUIDMOVCLI = value;
            }
        }

        public string UID_CORTE
        {
            get
            {
                return mUID_CORTE;
            }
            set
            {
                mUID_CORTE = value;
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

        public Double Monto_ref
        {
            get
            {
                return mMonto_ref;
            }
            set
            {
                mMonto_ref = value;
            }
        }

        NOTA_CRE_INT()
        {
        }

        NOTA_CRE_INT(string CAJA, int CODCLI, double EGRESO, string EMPLE, DateTime FECHA, string FECHAC, int ID, int IDSUC, double MODO, double MONTO, double NRO, double NRO_NCF, double NRO_REFE, double TIPO, string TREFE, string UID, string UIDMOVCLI, string UID_CORTE, string UID_REFE, double monto_ref)
        {
            mCAJA = CAJA;
            mCODCLI = CODCLI;
            mEGRESO = EGRESO;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mMODO = MODO;
            mMONTO = MONTO;
            mNRO = NRO;
            mNRO_NCF = NRO_NCF;
            mNRO_REFE = NRO_REFE;
            mTIPO = TIPO;
            mTREFE = TREFE;
            mUID = UID;
            mUIDMOVCLI = UIDMOVCLI;
            mUID_CORTE = UID_CORTE;
            mUID_REFE = UID_REFE;
            mMonto_ref = Monto_ref;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
