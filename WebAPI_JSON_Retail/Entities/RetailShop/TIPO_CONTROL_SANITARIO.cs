using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_CONTROL_SANITARIO : ICloneable
    {

        private double mAUTORIZA = 0.0;
        private string mDESCR = "";
        private int mID = 0;
        private string mRECIPE = "";

        public Double AUTORIZA
        {
            get
            {
                return mAUTORIZA;
            }
            set
            {
                mAUTORIZA = value;
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

        public string RECIPE
        {
            get
            {
                return mRECIPE;
            }
            set
            {
                mRECIPE = value;
            }
        }

        TIPO_CONTROL_SANITARIO()
        {
        }

        TIPO_CONTROL_SANITARIO(double AUTORIZA, string DESCR, int ID, string RECIPE)
        {
            mAUTORIZA = AUTORIZA;
            mDESCR = DESCR;
            mID = ID;
            mRECIPE = RECIPE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
