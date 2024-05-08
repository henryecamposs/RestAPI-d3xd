using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class EGRESOS : ICloneable
    {

        private string mCAJA = "";
        private string mCANCELA = "";
        private string mCONCEPTO = "";
        private string mDTIPO = "";
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private string mHORA = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_DOCU = 0;
        private double mMONTO = 0.0;
        private double mNRO = 0.0;
        private double mSESION = 0.0;
        private double mTIPO = 0.0;
        private string mUID = "";
        private string mUIDCORTE = "";
        private string mUIDFAC = "";

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

        public string CANCELA
        {
            get
            {
                return mCANCELA;
            }
            set
            {
                mCANCELA = value;
            }
        }

        public string CONCEPTO
        {
            get
            {
                return mCONCEPTO;
            }
            set
            {
                mCONCEPTO = value;
            }
        }

        public string DTIPO
        {
            get
            {
                return mDTIPO;
            }
            set
            {
                mDTIPO = value;
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

        public string HORA
        {
            get
            {
                return mHORA;
            }
            set
            {
                mHORA = value;
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

        EGRESOS()
        {
        }

        EGRESOS(string CAJA, string CANCELA, string CONCEPTO, string DTIPO, string EMPLE, DateTime FECHA, string FECHAC, string HORA, int ID, int IDSUC, int ID_DOCU, double MONTO, double NRO, double SESION, double TIPO, string UID, string UIDCORTE, string UIDFAC)
        {
            mCAJA = CAJA;
            mCANCELA = CANCELA;
            mCONCEPTO = CONCEPTO;
            mDTIPO = DTIPO;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mHORA = HORA;
            mID = ID;
            mIDSUC = IDSUC;
            mID_DOCU = ID_DOCU;
            mMONTO = MONTO;
            mNRO = NRO;
            mSESION = SESION;
            mTIPO = TIPO;
            mUID = UID;
            mUIDCORTE = UIDCORTE;
            mUIDFAC = UIDFAC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
