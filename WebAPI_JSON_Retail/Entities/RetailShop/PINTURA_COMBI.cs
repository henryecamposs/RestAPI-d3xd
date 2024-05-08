using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_COMBI : ICloneable
    {

        private int mCODICOMB = 0;
        private string mDESCCOMB = "";

        public int CODICOMB
        {
            get
            {
                return mCODICOMB;
            }
            set
            {
                mCODICOMB = value;
            }
        }

        public string DESCCOMB
        {
            get
            {
                return mDESCCOMB;
            }
            set
            {
                mDESCCOMB = value;
            }
        }

        PINTURA_COMBI()
        {
        }

        PINTURA_COMBI(int CODICOMB, string DESCCOMB)
        {
            mCODICOMB = CODICOMB;
            mDESCCOMB = DESCCOMB;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
