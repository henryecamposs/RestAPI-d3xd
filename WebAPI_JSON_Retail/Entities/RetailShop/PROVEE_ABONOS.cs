using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROVEE_ABONOS : ICloneable
    {

        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNRO = 0.0;
        private string mNROC = "";
        private string mNROCTA = "";
        private string mNROC_DEV = "";
        private string mNROPAGO = "";
        private double mNRO_DEV = 0.0;
        private int mPROVEE = 0;

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

        public string NROC
        {
            get
            {
                return mNROC;
            }
            set
            {
                mNROC = value;
            }
        }

        public string NROCTA
        {
            get
            {
                return mNROCTA;
            }
            set
            {
                mNROCTA = value;
            }
        }

        public string NROC_DEV
        {
            get
            {
                return mNROC_DEV;
            }
            set
            {
                mNROC_DEV = value;
            }
        }

        public string NROPAGO
        {
            get
            {
                return mNROPAGO;
            }
            set
            {
                mNROPAGO = value;
            }
        }

        public Double NRO_DEV
        {
            get
            {
                return mNRO_DEV;
            }
            set
            {
                mNRO_DEV = value;
            }
        }

        public int PROVEE
        {
            get
            {
                return mPROVEE;
            }
            set
            {
                mPROVEE = value;
            }
        }

        PROVEE_ABONOS()
        {
        }

        PROVEE_ABONOS(string EMPLE, DateTime FECHA, string FECHAC, int ID, int IDSUC, double NRO, string NROC, string NROCTA, string NROC_DEV, string NROPAGO, double NRO_DEV, int PROVEE)
        {
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mNRO = NRO;
            mNROC = NROC;
            mNROCTA = NROCTA;
            mNROC_DEV = NROC_DEV;
            mNROPAGO = NROPAGO;
            mNRO_DEV = NRO_DEV;
            mPROVEE = PROVEE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
