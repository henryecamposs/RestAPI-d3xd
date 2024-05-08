using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DATOSCONF : ICloneable
    {

        private int mLIMBLOQ = 0;

        public int LIMBLOQ
        {
            get
            {
                return mLIMBLOQ;
            }
            set
            {
                mLIMBLOQ = value;
            }
        }

        DATOSCONF()
        {
        }

        DATOSCONF(int LIMBLOQ)
        {
            mLIMBLOQ = LIMBLOQ;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
