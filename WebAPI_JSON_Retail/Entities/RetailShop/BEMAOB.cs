using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BEMAOB : ICloneable
    {

        private string mEDOC = "";
        private string mELINEAS = "";
        private double mFAGUJAS = 0.0;
        private int mID = 0;
        private string mNMONEDA = "";

        public string EDOC
        {
            get
            {
                return mEDOC;
            }
            set
            {
                mEDOC = value;
            }
        }

        public string ELINEAS
        {
            get
            {
                return mELINEAS;
            }
            set
            {
                mELINEAS = value;
            }
        }

        public Double FAGUJAS
        {
            get
            {
                return mFAGUJAS;
            }
            set
            {
                mFAGUJAS = value;
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

        public string NMONEDA
        {
            get
            {
                return mNMONEDA;
            }
            set
            {
                mNMONEDA = value;
            }
        }

        BEMAOB()
        {
        }

        BEMAOB(string EDOC, string ELINEAS, double FAGUJAS, int ID, string NMONEDA)
        {
            mEDOC = EDOC;
            mELINEAS = ELINEAS;
            mFAGUJAS = FAGUJAS;
            mID = ID;
            mNMONEDA = NMONEDA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
