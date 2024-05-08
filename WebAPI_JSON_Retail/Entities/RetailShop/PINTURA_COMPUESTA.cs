using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_COMPUESTA : ICloneable
    {

        private int mCODIBASE = 0;
        private int mCODICOMB = 0;
        private int mCODIPINT = 0;
        private int mCODITIPO = 0;
        private string mDESCPINT = "";

        public int CODIBASE
        {
            get
            {
                return mCODIBASE;
            }
            set
            {
                mCODIBASE = value;
            }
        }

        public int CODICOMB
        {
            get
            {
                return mCODICOMB;
            }
            set
            {
                mCODICOMB = value;
            }
        }

        public int CODIPINT
        {
            get
            {
                return mCODIPINT;
            }
            set
            {
                mCODIPINT = value;
            }
        }

        public int CODITIPO
        {
            get
            {
                return mCODITIPO;
            }
            set
            {
                mCODITIPO = value;
            }
        }

        public string DESCPINT
        {
            get
            {
                return mDESCPINT;
            }
            set
            {
                mDESCPINT = value;
            }
        }

        PINTURA_COMPUESTA()
        {
        }

        PINTURA_COMPUESTA(int CODIBASE, int CODICOMB, int CODIPINT, int CODITIPO, string DESCPINT)
        {
            mCODIBASE = CODIBASE;
            mCODICOMB = CODICOMB;
            mCODIPINT = CODIPINT;
            mCODITIPO = CODITIPO;
            mDESCPINT = DESCPINT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
