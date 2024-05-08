using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_TIPO : ICloneable
    {

        private int mCODITIPO = 0;
        private string mDESCTIPO = "";

        public int CODITIPO
        {
            get
            {
                return mCODITIPO;
            }
            set
            {
                mCODITIPO = value;
            }
        }

        public string DESCTIPO
        {
            get
            {
                return mDESCTIPO;
            }
            set
            {
                mDESCTIPO = value;
            }
        }

        PINTURA_TIPO()
        {
        }

        PINTURA_TIPO(int CODITIPO, string DESCTIPO)
        {
            mCODITIPO = CODITIPO;
            mDESCTIPO = DESCTIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
