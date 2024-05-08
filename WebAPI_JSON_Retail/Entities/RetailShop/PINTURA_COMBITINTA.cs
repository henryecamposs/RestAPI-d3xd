using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PINTURA_COMBITINTA : ICloneable
    {

        private int mCODICOMB = 0;
        private int mCODITINT = 0;
        private int mCOMBITINTA = 0;
        private double mOZ = 0.0;
        private double mU128 = 0.0;
        private double mU32 = 0.0;
        private double mU64 = 0.0;

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

        public int CODITINT
        {
            get
            {
                return mCODITINT;
            }
            set
            {
                mCODITINT = value;
            }
        }

        public int COMBITINTA
        {
            get
            {
                return mCOMBITINTA;
            }
            set
            {
                mCOMBITINTA = value;
            }
        }

        public Double OZ
        {
            get
            {
                return mOZ;
            }
            set
            {
                mOZ = value;
            }
        }

        public Double U128
        {
            get
            {
                return mU128;
            }
            set
            {
                mU128 = value;
            }
        }

        public Double U32
        {
            get
            {
                return mU32;
            }
            set
            {
                mU32 = value;
            }
        }

        public Double U64
        {
            get
            {
                return mU64;
            }
            set
            {
                mU64 = value;
            }
        }

        PINTURA_COMBITINTA()
        {
        }

        PINTURA_COMBITINTA(int CODICOMB, int CODITINT, int COMBITINTA, double OZ, double U128, double U32, double U64)
        {
            mCODICOMB = CODICOMB;
            mCODITINT = CODITINT;
            mCOMBITINTA = COMBITINTA;
            mOZ = OZ;
            mU128 = U128;
            mU32 = U32;
            mU64 = U64;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
