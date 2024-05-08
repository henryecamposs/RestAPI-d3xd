using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MENU_USUARIO : ICloneable
    {

        private bool mACCESO = false;
        private string mCODIGO = "";
        private int mID = 0;
        private string mKEY_ = "";
        private string mSUB_KEY = "";

        public Boolean ACCESO
        {
            get
            {
                return mACCESO;
            }
            set
            {
                mACCESO = value;
            }
        }

        public string CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
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

        public string KEY_
        {
            get
            {
                return mKEY_;
            }
            set
            {
                mKEY_ = value;
            }
        }

        public string SUB_KEY
        {
            get
            {
                return mSUB_KEY;
            }
            set
            {
                mSUB_KEY = value;
            }
        }

        MENU_USUARIO()
        {
        }

        MENU_USUARIO(bool ACCESO, string CODIGO, int ID, string KEY_, string SUB_KEY)
        {
            mACCESO = ACCESO;
            mCODIGO = CODIGO;
            mID = ID;
            mKEY_ = KEY_;
            mSUB_KEY = SUB_KEY;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
