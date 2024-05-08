using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONTEO_FIS : ICloneable
    {

        private string mCONCEPTO = "";
        private string mESTADO = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNRO = 0.0;
        private string mTIPO = "";

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

        CONTEO_FIS()
        {
        }

        CONTEO_FIS(string CONCEPTO, string ESTADO, DateTime FECHA, string FECHAC, int ID, int IDSUC, double NRO, string TIPO)
        {
            mCONCEPTO = CONCEPTO;
            mESTADO = ESTADO;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mNRO = NRO;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
