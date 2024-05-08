using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class REPORTES_USUARIOS : ICloneable
    {

        private double mANCLAR = 0.0;
        private string mDESCR = "";
        private int mID_REPOR = 0;
        private double mID_TABLA = 0.0;
        private string mNOTA = "";
        private double mORIENTA = 0.0;
        private string mTDESCR = "";

        public Double ANCLAR
        {
            get
            {
                return mANCLAR;
            }
            set
            {
                mANCLAR = value;
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

        public int ID_REPOR
        {
            get
            {
                return mID_REPOR;
            }
            set
            {
                mID_REPOR = value;
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

        public string NOTA
        {
            get
            {
                return mNOTA;
            }
            set
            {
                mNOTA = value;
            }
        }

        public Double ORIENTA
        {
            get
            {
                return mORIENTA;
            }
            set
            {
                mORIENTA = value;
            }
        }

        public string TDESCR
        {
            get
            {
                return mTDESCR;
            }
            set
            {
                mTDESCR = value;
            }
        }

        REPORTES_USUARIOS()
        {
        }

        REPORTES_USUARIOS(double ANCLAR, string DESCR, int ID_REPOR, double ID_TABLA, string NOTA, double ORIENTA, string TDESCR)
        {
            mANCLAR = ANCLAR;
            mDESCR = DESCR;
            mID_REPOR = ID_REPOR;
            mID_TABLA = ID_TABLA;
            mNOTA = NOTA;
            mORIENTA = ORIENTA;
            mTDESCR = TDESCR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
