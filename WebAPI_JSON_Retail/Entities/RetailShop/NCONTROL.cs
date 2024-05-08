using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class NCONTROL : ICloneable
    {

        private int mID = 0;
        private int mIDSUC = 0;
        private double mNCONTROL = 0.0;
        private double mNRO = 0.0;
        private double mSESION = 0.0;
        private string mTIPO = "";

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

        public Double nCONTROL
        {
            get
            {
                return mNCONTROL;
            }
            set
            {
                mNCONTROL = value;
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

        public Double SESION
        {
            get
            {
                return mSESION;
            }
            set
            {
                mSESION = value;
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

        NCONTROL()
        {
        }

        NCONTROL(int ID, int IDSUC, double NCONTROL, double NRO, double SESION, string TIPO)
        {
            mID = ID;
            mIDSUC = IDSUC;
            mNCONTROL = NCONTROL;
            mNRO = NRO;
            mSESION = SESION;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
