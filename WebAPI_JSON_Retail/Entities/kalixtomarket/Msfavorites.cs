using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Msfavorites : ICloneable
    {

        private int mID = 0;
        private string mFav_name = "";
        private string mFav_source = "";
        private string mFav_path = "";

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

        public string Fav_name
        {
            get
            {
                return mFav_name;
            }
            set
            {
                mFav_name = value;
            }
        }

        public string Fav_source
        {
            get
            {
                return mFav_source;
            }
            set
            {
                mFav_source = value;
            }
        }

        public string Fav_path
        {
            get
            {
                return mFav_path;
            }
            set
            {
                mFav_path = value;
            }
        }

        Msfavorites()
        {
        }

        Msfavorites(int ID, string fav_name, string fav_source, string fav_path)
        {
            mID = ID;
            mFav_name = Fav_name;
            mFav_source = Fav_source;
            mFav_path = Fav_path;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
