using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_DEPOSITO_BANCO : ICloneable
    {

        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private string mOBSERVA = "";
        private string mUID = "";

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

        public DateTime FECHAV
        {
            get
            {
                return mFECHAV;
            }
            set
            {
                mFECHAV = value;
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

        CAJAS_DEPOSITO_BANCO()
        {
        }

        CAJAS_DEPOSITO_BANCO(string EMPLE, DateTime FECHA, DateTime FECHAV, int ID, int IDSUC, string OBSERVA, string UID)
        {
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAV = FECHAV;
            mID = ID;
            mIDSUC = IDSUC;
            mOBSERVA = OBSERVA;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
