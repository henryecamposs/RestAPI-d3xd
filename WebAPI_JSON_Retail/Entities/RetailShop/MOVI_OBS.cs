using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MOVI_OBS : ICloneable
    {

        private string mCAJA = "";
        private string mFECHAC = "";
        private int mID = 0;
        private int mID_DOCU = 0;
        private int mID_ITEM = 0;
        private double mNRO = 0.0;
        private double mNROITEM = 0.0;
        private string mOBSERVA = "";
        private double mSESION = 0.0;
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

        public int ID_ITEM
        {
            get
            {
                return mID_ITEM;
            }
            set
            {
                mID_ITEM = value;
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

        public Double NROITEM
        {
            get
            {
                return mNROITEM;
            }
            set
            {
                mNROITEM = value;
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

        MOVI_OBS()
        {
        }

        MOVI_OBS(string CAJA, string FECHAC, int ID, int ID_DOCU, int ID_ITEM, double NRO, double NROITEM, string OBSERVA, double SESION, string UIDCORTE, string UIDFAC)
        {
            mCAJA = CAJA;
            mFECHAC = FECHAC;
            mID = ID;
            mID_DOCU = ID_DOCU;
            mID_ITEM = ID_ITEM;
            mNRO = NRO;
            mNROITEM = NROITEM;
            mOBSERVA = OBSERVA;
            mSESION = SESION;
            mUIDCORTE = UIDCORTE;
            mUIDFAC = UIDFAC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
