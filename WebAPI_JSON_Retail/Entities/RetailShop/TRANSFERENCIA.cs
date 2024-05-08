using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TRANSFERENCIA : ICloneable
    {

        private string mCONCEPTO = "";
        private double mCOSTOT = 0.0;
        private double mCOSTOTU = 0.0;
        private string mDPTOD = "";
        private string mDPTODD = "";
        private string mDPTOO = "";
        private string mDPTOOD = "";
        private string mESTADO = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNRO = 0.0;
        private double mNROA = 0.0;

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

        public Double COSTOT
        {
            get
            {
                return mCOSTOT;
            }
            set
            {
                mCOSTOT = value;
            }
        }

        public Double COSTOTU
        {
            get
            {
                return mCOSTOTU;
            }
            set
            {
                mCOSTOTU = value;
            }
        }

        public string DPTOD
        {
            get
            {
                return mDPTOD;
            }
            set
            {
                mDPTOD = value;
            }
        }

        public string DPTODD
        {
            get
            {
                return mDPTODD;
            }
            set
            {
                mDPTODD = value;
            }
        }

        public string DPTOO
        {
            get
            {
                return mDPTOO;
            }
            set
            {
                mDPTOO = value;
            }
        }

        public string DPTOOD
        {
            get
            {
                return mDPTOOD;
            }
            set
            {
                mDPTOOD = value;
            }
        }

        public string ESTADO
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

        public Double NROA
        {
            get
            {
                return mNROA;
            }
            set
            {
                mNROA = value;
            }
        }

        TRANSFERENCIA()
        {
        }

        TRANSFERENCIA(string CONCEPTO, double COSTOT, double COSTOTU, string DPTOD, string DPTODD, string DPTOO, string DPTOOD, string ESTADO, DateTime FECHA, string FECHAC, int ID, int IDSUC, double NRO, double NROA)
        {
            mCONCEPTO = CONCEPTO;
            mCOSTOT = COSTOT;
            mCOSTOTU = COSTOTU;
            mDPTOD = DPTOD;
            mDPTODD = DPTODD;
            mDPTOO = DPTOO;
            mDPTOOD = DPTOOD;
            mESTADO = ESTADO;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mNRO = NRO;
            mNROA = NROA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
