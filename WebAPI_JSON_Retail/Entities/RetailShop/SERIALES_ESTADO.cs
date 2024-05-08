using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERIALES_ESTADO : ICloneable
    {

        private string mCODIGO = "";
        private string mEMPLE = "";
        private string mEMPLEA = "";
        private double mESTADON = 0.0;
        private double mESTADOO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private string mMOTIVO = "";
        private string mSERIAL = "";

        public string CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
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

        public string EMPLEA
        {
            get
            {
                return mEMPLEA;
            }
            set
            {
                mEMPLEA = value;
            }
        }

        public Double ESTADON
        {
            get
            {
                return mESTADON;
            }
            set
            {
                mESTADON = value;
            }
        }

        public Double ESTADOO
        {
            get
            {
                return mESTADOO;
            }
            set
            {
                mESTADOO = value;
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

        public string MOTIVO
        {
            get
            {
                return mMOTIVO;
            }
            set
            {
                mMOTIVO = value;
            }
        }

        public string SERIAL
        {
            get
            {
                return mSERIAL;
            }
            set
            {
                mSERIAL = value;
            }
        }

        SERIALES_ESTADO()
        {
        }

        SERIALES_ESTADO(string CODIGO, string EMPLE, string EMPLEA, double ESTADON, double ESTADOO, DateTime FECHA, int ID, int IDSUC, string MOTIVO, string SERIAL)
        {
            mCODIGO = CODIGO;
            mEMPLE = EMPLE;
            mEMPLEA = EMPLEA;
            mESTADON = ESTADON;
            mESTADOO = ESTADOO;
            mFECHA = FECHA;
            mID = ID;
            mIDSUC = IDSUC;
            mMOTIVO = MOTIVO;
            mSERIAL = SERIAL;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
