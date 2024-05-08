using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Msmreports : ICloneable
    {

        private int mId = 0;
        private string mRepalias = "";
        private string mRepname = "";
        private string mSource = "";

        public int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }

        public string Repalias
        {
            get
            {
                return mRepalias;
            }
            set
            {
                mRepalias = value;
            }
        }

        public string Repname
        {
            get
            {
                return mRepname;
            }
            set
            {
                mRepname = value;
            }
        }

        public string Source
        {
            get
            {
                return mSource;
            }
            set
            {
                mSource = value;
            }
        }

        Msmreports()
        {
        }

        Msmreports(int id, string repalias, string repname, string source)
        {
            mId = Id;
            mRepalias = Repalias;
            mRepname = Repname;
            mSource = Source;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
