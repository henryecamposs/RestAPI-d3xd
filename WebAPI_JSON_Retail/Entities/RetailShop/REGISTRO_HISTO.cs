using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class REGISTRO_HISTO : ICloneable
    {

        private string mARCHI = "";
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAD = new DateTime(2000, 01, 01);
        private DateTime mFECHAH = new DateTime(2000, 01, 01);
        private string mHORAF = "";
        private string mHORAI = "";
        private int mID = 0;

        public string ARCHI
        {
            get
            {
                return mARCHI;
            }
            set
            {
                mARCHI = value;
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

        public DateTime FECHAD
        {
            get
            {
                return mFECHAD;
            }
            set
            {
                mFECHAD = value;
            }
        }

        public DateTime FECHAH
        {
            get
            {
                return mFECHAH;
            }
            set
            {
                mFECHAH = value;
            }
        }

        public string HORAF
        {
            get
            {
                return mHORAF;
            }
            set
            {
                mHORAF = value;
            }
        }

        public string HORAI
        {
            get
            {
                return mHORAI;
            }
            set
            {
                mHORAI = value;
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

        REGISTRO_HISTO()
        {
        }

        REGISTRO_HISTO(string ARCHI, string EMPLE, DateTime FECHA, string FECHAC, DateTime FECHAD, DateTime FECHAH, string HORAF, string HORAI, int ID)
        {
            mARCHI = ARCHI;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAD = FECHAD;
            mFECHAH = FECHAH;
            mHORAF = HORAF;
            mHORAI = HORAI;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
