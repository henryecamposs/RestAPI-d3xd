using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RETENCIONES : ICloneable
    {

        private int mID_RETEN = 0;
        private double mMINIMO = 0.0;
        private string mNOMBRE = "";
        private double mPORC = 0.0;

        public int ID_RETEN
        {
            get
            {
                return mID_RETEN;
            }
            set
            {
                mID_RETEN = value;
            }
        }

        public Double MINIMO
        {
            get
            {
                return mMINIMO;
            }
            set
            {
                mMINIMO = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double PORC
        {
            get
            {
                return mPORC;
            }
            set
            {
                mPORC = value;
            }
        }

        RETENCIONES()
        {
        }

        RETENCIONES(int ID_RETEN, double MINIMO, string NOMBRE, double PORC)
        {
            mID_RETEN = ID_RETEN;
            mMINIMO = MINIMO;
            mNOMBRE = NOMBRE;
            mPORC = PORC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
