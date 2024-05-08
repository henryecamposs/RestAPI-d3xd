using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJA_PROMO_ACUM : ICloneable
    {

        private double mACUMULADO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mID_CAJAPRO = 0;
        private double mNIVEL = 0.0;

        public Double ACUMULADO
        {
            get
            {
                return mACUMULADO;
            }
            set
            {
                mACUMULADO = value;
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

        public int ID_CAJAPRO
        {
            get
            {
                return mID_CAJAPRO;
            }
            set
            {
                mID_CAJAPRO = value;
            }
        }

        public Double NIVEL
        {
            get
            {
                return mNIVEL;
            }
            set
            {
                mNIVEL = value;
            }
        }

        CAJA_PROMO_ACUM()
        {
        }

        CAJA_PROMO_ACUM(double ACUMULADO, DateTime FECHA, int ID, int ID_CAJAPRO, double NIVEL)
        {
            mACUMULADO = ACUMULADO;
            mFECHA = FECHA;
            mID = ID;
            mID_CAJAPRO = ID_CAJAPRO;
            mNIVEL = NIVEL;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
