using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class NDCOMPRAS_C : ICloneable
    {

        private string mNCOMPRA = "";
        private string mNDCOMPRA = "";
        private string mPROVEE = "";

        public string NCOMPRA
        {
            get
            {
                return mNCOMPRA;
            }
            set
            {
                mNCOMPRA = value;
            }
        }

        public string NDCOMPRA
        {
            get
            {
                return mNDCOMPRA;
            }
            set
            {
                mNDCOMPRA = value;
            }
        }

        public string PROVEE
        {
            get
            {
                return mPROVEE;
            }
            set
            {
                mPROVEE = value;
            }
        }

        NDCOMPRAS_C()
        {
        }

        NDCOMPRAS_C(string NCOMPRA, string NDCOMPRA, string PROVEE)
        {
            mNCOMPRA = NCOMPRA;
            mNDCOMPRA = NDCOMPRA;
            mPROVEE = PROVEE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
