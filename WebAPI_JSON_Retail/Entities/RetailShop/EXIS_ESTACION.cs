using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class EXIS_ESTACION : ICloneable
    {

        private string mCODIGO = "";
        private string mDPTO = "";
        private double mENT = 0.0;
        private string mESTACION = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private string mPERIODO = "";
        private double mSAL = 0.0;

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

        public string DPTO
        {
            get
            {
                return mDPTO;
            }
            set
            {
                mDPTO = value;
            }
        }

        public Double ENT
        {
            get
            {
                return mENT;
            }
            set
            {
                mENT = value;
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

        public string PERIODO
        {
            get
            {
                return mPERIODO;
            }
            set
            {
                mPERIODO = value;
            }
        }

        public Double SAL
        {
            get
            {
                return mSAL;
            }
            set
            {
                mSAL = value;
            }
        }

        EXIS_ESTACION()
        {
        }

        EXIS_ESTACION(string CODIGO, string DPTO, double ENT, string ESTACION, DateTime FECHA, int ID, string PERIODO, double SAL)
        {
            mCODIGO = CODIGO;
            mDPTO = DPTO;
            mENT = ENT;
            mESTACION = ESTACION;
            mFECHA = FECHA;
            mID = ID;
            mPERIODO = PERIODO;
            mSAL = SAL;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
