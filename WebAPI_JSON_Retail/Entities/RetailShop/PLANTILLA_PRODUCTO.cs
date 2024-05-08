using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PLANTILLA_PRODUCTO : ICloneable
    {

        private string mDESCR = "";
        private bool mGENERAL = false;
        private int mID_PLANTI = 0;
        private bool mPUNTOV = false;

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

        public Boolean GENERAL
        {
            get
            {
                return mGENERAL;
            }
            set
            {
                mGENERAL = value;
            }
        }

        public int ID_PLANTI
        {
            get
            {
                return mID_PLANTI;
            }
            set
            {
                mID_PLANTI = value;
            }
        }

        public Boolean PUNTOV
        {
            get
            {
                return mPUNTOV;
            }
            set
            {
                mPUNTOV = value;
            }
        }

        PLANTILLA_PRODUCTO()
        {
        }

        PLANTILLA_PRODUCTO(string DESCR, bool GENERAL, int ID_PLANTI, bool PUNTOV)
        {
            mDESCR = DESCR;
            mGENERAL = GENERAL;
            mID_PLANTI = ID_PLANTI;
            mPUNTOV = PUNTOV;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
