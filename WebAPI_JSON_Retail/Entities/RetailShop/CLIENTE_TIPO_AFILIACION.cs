using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_TIPO_AFILIACION : ICloneable
    {

        private string mDESCR = "";
        private double mFACTOR = 0.0;
        private int mID = 0;
        private double mINACTIVO = 0.0;

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

        public Double FACTOR
        {
            get
            {
                return mFACTOR;
            }
            set
            {
                mFACTOR = value;
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

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        CLIENTE_TIPO_AFILIACION()
        {
        }

        CLIENTE_TIPO_AFILIACION(string DESCR, double FACTOR, int ID, double INACTIVO)
        {
            mDESCR = DESCR;
            mFACTOR = FACTOR;
            mID = ID;
            mINACTIVO = INACTIVO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
