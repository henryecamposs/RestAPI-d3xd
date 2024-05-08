using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class EGRESOS_DETALLE : ICloneable
    {

        private string mCOD = "";
        private string mDESCR = "";
        private int mID = 0;
        private double mMONTO = 0.0;
        private string mUID = "";
        private string mUID_EGRESO = "";

        public string COD
        {
            get
            {
                return mCOD;
            }
            set
            {
                mCOD = value;
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

        public Double MONTO
        {
            get
            {
                return mMONTO;
            }
            set
            {
                mMONTO = value;
            }
        }

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
            }
        }

        public string UID_EGRESO
        {
            get
            {
                return mUID_EGRESO;
            }
            set
            {
                mUID_EGRESO = value;
            }
        }

        EGRESOS_DETALLE()
        {
        }

        EGRESOS_DETALLE(string COD, string DESCR, int ID, double MONTO, string UID, string UID_EGRESO)
        {
            mCOD = COD;
            mDESCR = DESCR;
            mID = ID;
            mMONTO = MONTO;
            mUID = UID;
            mUID_EGRESO = UID_EGRESO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
