using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTES_ABONOS : ICloneable
    {

        private int mCLIENTE = 0;
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNRO = 0.0;
        private string mUID = "";
        private string mUIDFACTU = "";

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

        public string UIDFACTU
        {
            get
            {
                return mUIDFACTU;
            }
            set
            {
                mUIDFACTU = value;
            }
        }

        CLIENTES_ABONOS()
        {
        }

        CLIENTES_ABONOS(int CLIENTE, string EMPLE, DateTime FECHA, string FECHAC, int ID, int IDSUC, double NRO, string UID, string UIDFACTU)
        {
            mCLIENTE = CLIENTE;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mNRO = NRO;
            mUID = UID;
            mUIDFACTU = UIDFACTU;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
