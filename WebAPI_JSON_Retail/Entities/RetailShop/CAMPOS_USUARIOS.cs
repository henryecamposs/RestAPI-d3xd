using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAMPOS_USUARIOS : ICloneable
    {

        private double mDEC = 0.0;
        private string mDESCR = "";
        private string mFORMAT = "";
        private int mID_CAMPO = 0;
        private double mID_TABLA = 0.0;
        private string mIMASK = "";
        private double mKEY = 0.0;
        private double mKEYDES = 0.0;
        private double mLONG = 0.0;
        private double mREQUE = 0.0;
        private double mRTF = 0.0;
        private string mTIPO = "";

        public Double DEC
        {
            get
            {
                return mDEC;
            }
            set
            {
                mDEC = value;
            }
        }

        public string DESCR
        {
            get
            {
                return mDESCR;
            }
            set
            {
                mDESCR = value;
            }
        }

        public string FORMAT
        {
            get
            {
                return mFORMAT;
            }
            set
            {
                mFORMAT = value;
            }
        }

        public int ID_CAMPO
        {
            get
            {
                return mID_CAMPO;
            }
            set
            {
                mID_CAMPO = value;
            }
        }

        public Double ID_TABLA
        {
            get
            {
                return mID_TABLA;
            }
            set
            {
                mID_TABLA = value;
            }
        }

        public string IMASK
        {
            get
            {
                return mIMASK;
            }
            set
            {
                mIMASK = value;
            }
        }

        public Double KEY
        {
            get
            {
                return mKEY;
            }
            set
            {
                mKEY = value;
            }
        }

        public Double KEYDES
        {
            get
            {
                return mKEYDES;
            }
            set
            {
                mKEYDES = value;
            }
        }

        public Double LONG
        {
            get
            {
                return mLONG;
            }
            set
            {
                mLONG = value;
            }
        }

        public Double REQUE
        {
            get
            {
                return mREQUE;
            }
            set
            {
                mREQUE = value;
            }
        }

        public Double RTF
        {
            get
            {
                return mRTF;
            }
            set
            {
                mRTF = value;
            }
        }

        public string TIPO
        {
            get
            {
                return mTIPO;
            }
            set
            {
                mTIPO = value;
            }
        }

        CAMPOS_USUARIOS()
        {
        }

        CAMPOS_USUARIOS(double DEC, string DESCR, string FORMAT, int ID_CAMPO, double ID_TABLA, string IMASK, double KEY, double KEYDES, double LONG, double REQUE, double RTF, string TIPO)
        {
            mDEC = DEC;
            mDESCR = DESCR;
            mFORMAT = FORMAT;
            mID_CAMPO = ID_CAMPO;
            mID_TABLA = ID_TABLA;
            mIMASK = IMASK;
            mKEY = KEY;
            mKEYDES = KEYDES;
            mLONG = LONG;
            mREQUE = REQUE;
            mRTF = RTF;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
