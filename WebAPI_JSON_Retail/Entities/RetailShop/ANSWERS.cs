using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ANSWERS : ICloneable
    {

        private string mNameFile = "";
        private int mId = 0;

        public string NameFile
        {
            get
            {
                return mNameFile;
            }
            set
            {
                mNameFile = value;
            }
        }

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

        ANSWERS()
        {
        }

        ANSWERS(string NameFile, int id)
        {
            mNameFile = NameFile;
            mId = Id;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
