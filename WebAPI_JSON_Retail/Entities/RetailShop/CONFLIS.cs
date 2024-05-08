using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONFLIS : ICloneable
    {

        private double mACTUAL = 0.0;
        private string mDIR = "";
        private string mEMAIL = "";
        private DateTime mFECHA_EXP = new DateTime(2000, 01, 01);
        private int mID = 0;
        private string mNOMBRE = "";
        private string mTELE = "";
        private double mVECES_EXP = 0.0;
        private string mWEBSITE = "";

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

        public string DIR
        {
            get
            {
                return mDIR;
            }
            set
            {
                mDIR = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return mEMAIL;
            }
            set
            {
                mEMAIL = value;
            }
        }

        public DateTime FECHA_EXP
        {
            get
            {
                return mFECHA_EXP;
            }
            set
            {
                mFECHA_EXP = value;
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

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public string TELE
        {
            get
            {
                return mTELE;
            }
            set
            {
                mTELE = value;
            }
        }

        public Double VECES_EXP
        {
            get
            {
                return mVECES_EXP;
            }
            set
            {
                mVECES_EXP = value;
            }
        }

        public string WEBSITE
        {
            get
            {
                return mWEBSITE;
            }
            set
            {
                mWEBSITE = value;
            }
        }

        CONFLIS()
        {
        }

        CONFLIS(double ACTUAL, string DIR, string EMAIL, DateTime FECHA_EXP, int ID, string NOMBRE, string TELE, double VECES_EXP, string WEBSITE)
        {
            mACTUAL = ACTUAL;
            mDIR = DIR;
            mEMAIL = EMAIL;
            mFECHA_EXP = FECHA_EXP;
            mID = ID;
            mNOMBRE = NOMBRE;
            mTELE = TELE;
            mVECES_EXP = VECES_EXP;
            mWEBSITE = WEBSITE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
