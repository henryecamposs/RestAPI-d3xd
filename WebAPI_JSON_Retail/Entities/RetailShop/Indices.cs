using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class Indices : ICloneable
    {

        private string mKey_name = "";
        private string mDESCRIP = "";
        private string mCOLUMNAS = "";

        public string Key_name
        {
            get
            {
                return mKey_name;
            }
            set
            {
                mKey_name = value;
            }
        }

        public string DESCRIP
        {
            get
            {
                return mDESCRIP;
            }
            set
            {
                mDESCRIP = value;
            }
        }

        public string COLUMNAS
        {
            get
            {
                return mCOLUMNAS;
            }
            set
            {
                mCOLUMNAS = value;
            }
        }

        Indices()
        {
        }

        Indices(string Key_name, string DESCRIP, string COLUMNAS)
        {
            mKey_name = Key_name;
            mDESCRIP = DESCRIP;
            mCOLUMNAS = COLUMNAS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
