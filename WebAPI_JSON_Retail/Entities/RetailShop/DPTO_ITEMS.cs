using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DPTO_ITEMS : ICloneable
    {

        private double mCANTI = 0.0;
        private string mCOD_DPTO = "";
        private int mID = 0;
        private int mID_ITEM = 0;
        private string mNROITEM = "";
        private double mTIPO_DOC = 0.0;
        private string mUID = "";
        private string mUIDITEM = "";
        private string mUID_COMP = "";

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
            }
        }

        public string COD_DPTO
        {
            get
            {
                return mCOD_DPTO;
            }
            set
            {
                mCOD_DPTO = value;
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

        public string NROITEM
        {
            get
            {
                return mNROITEM;
            }
            set
            {
                mNROITEM = value;
            }
        }

        public Double TIPO_DOC
        {
            get
            {
                return mTIPO_DOC;
            }
            set
            {
                mTIPO_DOC = value;
            }
        }

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
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

        public string UID_COMP
        {
            get
            {
                return mUID_COMP;
            }
            set
            {
                mUID_COMP = value;
            }
        }

        DPTO_ITEMS()
        {
        }

        DPTO_ITEMS(double CANTI, string COD_DPTO, int ID, int ID_ITEM, string NROITEM, double TIPO_DOC, string UID, string UIDITEM, string UID_COMP)
        {
            mCANTI = CANTI;
            mCOD_DPTO = COD_DPTO;
            mID = ID;
            mID_ITEM = ID_ITEM;
            mNROITEM = NROITEM;
            mTIPO_DOC = TIPO_DOC;
            mUID = UID;
            mUIDITEM = UIDITEM;
            mUID_COMP = UID_COMP;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
