using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CORRELATIVOS_ : ICloneable
    {

        private int mID = 0;
        private double mNRO = 0.0;
        private string mNROC = "";
        private string mTABLA = "";

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

        public string NROC
        {
            get
            {
                return mNROC;
            }
            set
            {
                mNROC = value;
            }
        }

        public string TABLA
        {
            get
            {
                return mTABLA;
            }
            set
            {
                mTABLA = value;
            }
        }

        CORRELATIVOS_()
        {
        }

        CORRELATIVOS_(int ID, double NRO, string NROC, string TABLA)
        {
            mID = ID;
            mNRO = NRO;
            mNROC = NROC;
            mTABLA = TABLA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
