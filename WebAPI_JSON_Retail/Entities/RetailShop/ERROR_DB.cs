using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ERROR_DB : ICloneable
    {

        private string mCONCEPTO = "";
        private string mESTACION = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;

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

        public string ESTACION
        {
            get
            {
                return mESTACION;
            }
            set
            {
                mESTACION = value;
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

        ERROR_DB()
        {
        }

        ERROR_DB(string CONCEPTO, string ESTACION, DateTime FECHA, int ID)
        {
            mCONCEPTO = CONCEPTO;
            mESTACION = ESTACION;
            mFECHA = FECHA;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
