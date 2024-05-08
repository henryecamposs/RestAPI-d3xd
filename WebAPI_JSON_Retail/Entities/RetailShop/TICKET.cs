using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TICKET : ICloneable
    {

        private int mID = 0;
        private string mNTRAN = "";
        private string mTK01 = "";
        private string mTK02 = "";
        private string mTK03 = "";
        private string mTK04 = "";
        private string mTK05 = "";
        private string mTK06 = "";
        private string mTK07 = "";
        private string mTK08 = "";
        private string mTK09 = "";
        private string mTK10 = "";
        private string mTK11 = "";
        private string mTK12 = "";
        private string mTK13 = "";
        private string mTK14 = "";
        private string mTK15 = "";
        private string mTK16 = "";
        private string mTK17 = "";
        private string mTK18 = "";
        private string mTK19 = "";
        private string mTK20 = "";

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

        public string NTRAN
        {
            get
            {
                return mNTRAN;
            }
            set
            {
                mNTRAN = value;
            }
        }

        public string TK01
        {
            get
            {
                return mTK01;
            }
            set
            {
                mTK01 = value;
            }
        }

        public string TK02
        {
            get
            {
                return mTK02;
            }
            set
            {
                mTK02 = value;
            }
        }

        public string TK03
        {
            get
            {
                return mTK03;
            }
            set
            {
                mTK03 = value;
            }
        }

        public string TK04
        {
            get
            {
                return mTK04;
            }
            set
            {
                mTK04 = value;
            }
        }

        public string TK05
        {
            get
            {
                return mTK05;
            }
            set
            {
                mTK05 = value;
            }
        }

        public string TK06
        {
            get
            {
                return mTK06;
            }
            set
            {
                mTK06 = value;
            }
        }

        public string TK07
        {
            get
            {
                return mTK07;
            }
            set
            {
                mTK07 = value;
            }
        }

        public string TK08
        {
            get
            {
                return mTK08;
            }
            set
            {
                mTK08 = value;
            }
        }

        public string TK09
        {
            get
            {
                return mTK09;
            }
            set
            {
                mTK09 = value;
            }
        }

        public string TK10
        {
            get
            {
                return mTK10;
            }
            set
            {
                mTK10 = value;
            }
        }

        public string TK11
        {
            get
            {
                return mTK11;
            }
            set
            {
                mTK11 = value;
            }
        }

        public string TK12
        {
            get
            {
                return mTK12;
            }
            set
            {
                mTK12 = value;
            }
        }

        public string TK13
        {
            get
            {
                return mTK13;
            }
            set
            {
                mTK13 = value;
            }
        }

        public string TK14
        {
            get
            {
                return mTK14;
            }
            set
            {
                mTK14 = value;
            }
        }

        public string TK15
        {
            get
            {
                return mTK15;
            }
            set
            {
                mTK15 = value;
            }
        }

        public string TK16
        {
            get
            {
                return mTK16;
            }
            set
            {
                mTK16 = value;
            }
        }

        public string TK17
        {
            get
            {
                return mTK17;
            }
            set
            {
                mTK17 = value;
            }
        }

        public string TK18
        {
            get
            {
                return mTK18;
            }
            set
            {
                mTK18 = value;
            }
        }

        public string TK19
        {
            get
            {
                return mTK19;
            }
            set
            {
                mTK19 = value;
            }
        }

        public string TK20
        {
            get
            {
                return mTK20;
            }
            set
            {
                mTK20 = value;
            }
        }

        TICKET()
        {
        }

        TICKET(int ID, string NTRAN, string TK01, string TK02, string TK03, string TK04, string TK05, string TK06, string TK07, string TK08, string TK09, string TK10, string TK11, string TK12, string TK13, string TK14, string TK15, string TK16, string TK17, string TK18, string TK19, string TK20)
        {
            mID = ID;
            mNTRAN = NTRAN;
            mTK01 = TK01;
            mTK02 = TK02;
            mTK03 = TK03;
            mTK04 = TK04;
            mTK05 = TK05;
            mTK06 = TK06;
            mTK07 = TK07;
            mTK08 = TK08;
            mTK09 = TK09;
            mTK10 = TK10;
            mTK11 = TK11;
            mTK12 = TK12;
            mTK13 = TK13;
            mTK14 = TK14;
            mTK15 = TK15;
            mTK16 = TK16;
            mTK17 = TK17;
            mTK18 = TK18;
            mTK19 = TK19;
            mTK20 = TK20;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
