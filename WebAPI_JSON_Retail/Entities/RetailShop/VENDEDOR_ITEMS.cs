using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VENDEDOR_ITEMS : ICloneable
    {

        private string mCAJA = "";
        private double mCOMI = 0.0;
        private int mID = 0;
        private int mID_ITEM = 0;
        private double mORIGEN = 0.0;
        private string mUIDFAC = "";
        private string mUIDITEM = "";
        private string mVENDEDOR = "";

        public string CAJA
        {
            get
            {
                return mCAJA;
            }
            set
            {
                mCAJA = value;
            }
        }

        public Double COMI
        {
            get
            {
                return mCOMI;
            }
            set
            {
                mCOMI = value;
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

        public int ID_ITEM
        {
            get
            {
                return mID_ITEM;
            }
            set
            {
                mID_ITEM = value;
            }
        }

        public Double ORIGEN
        {
            get
            {
                return mORIGEN;
            }
            set
            {
                mORIGEN = value;
            }
        }

        public string UIDFAC
        {
            get
            {
                return mUIDFAC;
            }
            set
            {
                mUIDFAC = value;
            }
        }

        public string UIDITEM
        {
            get
            {
                return mUIDITEM;
            }
            set
            {
                mUIDITEM = value;
            }
        }

        public string VENDEDOR
        {
            get
            {
                return mVENDEDOR;
            }
            set
            {
                mVENDEDOR = value;
            }
        }

        VENDEDOR_ITEMS()
        {
        }

        VENDEDOR_ITEMS(string CAJA, double COMI, int ID, int ID_ITEM, double ORIGEN, string UIDFAC, string UIDITEM, string VENDEDOR)
        {
            mCAJA = CAJA;
            mCOMI = COMI;
            mID = ID;
            mID_ITEM = ID_ITEM;
            mORIGEN = ORIGEN;
            mUIDFAC = UIDFAC;
            mUIDITEM = UIDITEM;
            mVENDEDOR = VENDEDOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
