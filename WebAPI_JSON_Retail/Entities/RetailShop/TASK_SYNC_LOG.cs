using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TASK_SYNC_LOG : ICloneable
    {

        private int mACTION = 0;
        private DateTime mDateTimePRO = new DateTime(2000, 01, 01);
        private int mDESTINY = 0;
        private int mID = 0;
        private int mSOURCE = 0;
        private int mTYPE = 0;

        public int ACTION
        {
            get
            {
                return mACTION;
            }
            set
            {
                mACTION = value;
            }
        }

        public DateTime DateTimePRO
        {
            get
            {
                return mDateTimePRO;
            }
            set
            {
                mDateTimePRO = value;
            }
        }

        public int DESTINY
        {
            get
            {
                return mDESTINY;
            }
            set
            {
                mDESTINY = value;
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

        public int SOURCE
        {
            get
            {
                return mSOURCE;
            }
            set
            {
                mSOURCE = value;
            }
        }

        public int TYPE
        {
            get
            {
                return mTYPE;
            }
            set
            {
                mTYPE = value;
            }
        }

        TASK_SYNC_LOG()
        {
        }

        TASK_SYNC_LOG(int ACTION, DateTime DateTimePRO, int DESTINY, int ID, int SOURCE, int TYPE)
        {
            mACTION = ACTION;
            mDateTimePRO = DateTimePRO;
            mDESTINY = DESTINY;
            mID = ID;
            mSOURCE = SOURCE;
            mTYPE = TYPE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
