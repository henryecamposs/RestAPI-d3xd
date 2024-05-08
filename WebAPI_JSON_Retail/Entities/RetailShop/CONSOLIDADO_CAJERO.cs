using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONSOLIDADO_CAJERO : ICloneable
    {

        private double mCONTADO = 0.0;
        private string mFECHAC = "";
        private int mID = 0;
        private int mID_EMPLE = 0;
        private int mID_PAGO = 0;
        private double mMONTOI = 0.0;
        private int mSUC = 0;
        private double mTTARJETA = 0.0;
        private string mUID = "";

        public Double CONTADO
        {
            get
            {
                return mCONTADO;
            }
            set
            {
                mCONTADO = value;
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

        public int ID_EMPLE
        {
            get
            {
                return mID_EMPLE;
            }
            set
            {
                mID_EMPLE = value;
            }
        }

        public int ID_PAGO
        {
            get
            {
                return mID_PAGO;
            }
            set
            {
                mID_PAGO = value;
            }
        }

        public Double MONTOI
        {
            get
            {
                return mMONTOI;
            }
            set
            {
                mMONTOI = value;
            }
        }

        public int SUC
        {
            get
            {
                return mSUC;
            }
            set
            {
                mSUC = value;
            }
        }

        public Double TTARJETA
        {
            get
            {
                return mTTARJETA;
            }
            set
            {
                mTTARJETA = value;
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

        CONSOLIDADO_CAJERO()
        {
        }

        CONSOLIDADO_CAJERO(double CONTADO, string FECHAC, int ID, int ID_EMPLE, int ID_PAGO, double MONTOI, int SUC, double TTARJETA, string UID)
        {
            mCONTADO = CONTADO;
            mFECHAC = FECHAC;
            mID = ID;
            mID_EMPLE = ID_EMPLE;
            mID_PAGO = ID_PAGO;
            mMONTOI = MONTOI;
            mSUC = SUC;
            mTTARJETA = TTARJETA;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
