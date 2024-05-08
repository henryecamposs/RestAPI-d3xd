using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class NCONTROL_C : ICloneable
    {

        private int mID = 0;
        private int mIDSUC = 0;
        private double mNCONTROL = 0.0;
        private string mNCONTROL_C = "";
        private string mNRO = "";
        private string mNROC = "";
        private string mPROVEE = "";

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

        public Double NCONTROL
        {
            get
            {
                return mNCONTROL;
            }
            set
            {
                mNCONTROL = value;
            }
        }

        public string nCONTROL_C
        {
            get
            {
                return mNCONTROL_C;
            }
            set
            {
                mNCONTROL_C = value;
            }
        }

        public string NRO
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

        public string PROVEE
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

        NCONTROL_C()
        {
        }

        NCONTROL_C(int ID, int IDSUC, double NCONTROL, string NCONTROL_C, string NRO, string NROC, string PROVEE)
        {
            mID = ID;
            mIDSUC = IDSUC;
            mNCONTROL = NCONTROL;
            mNCONTROL_C = NCONTROL_C;
            mNRO = NRO;
            mNROC = NROC;
            mPROVEE = PROVEE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
