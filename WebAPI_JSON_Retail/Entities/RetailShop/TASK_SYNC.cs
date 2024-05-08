using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TASK_SYNC : ICloneable
    {

        private int mACTION = 0;
        private DateTime mDateTimeCREA = new DateTime(2000, 01, 01);
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

        public DateTime DateTimeCREA
        {
            get
            {
                return mDateTimeCREA;
            }
            set
            {
                mDateTimeCREA = value;
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

        TASK_SYNC()
        {
        }

        TASK_SYNC(int ACTION, DateTime DateTimeCREA, int DESTINY, int ID, int SOURCE, int TYPE)
        {
            mACTION = ACTION;
            mDateTimeCREA = DateTimeCREA;
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
