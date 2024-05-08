using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class GRUPO_USUARIO : ICloneable
    {

        private bool mACCESO = false;
        private string mCOD_GRUPO = "";
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

        public string COD_GRUPO
        {
            get
            {
                return mCOD_GRUPO;
            }
            set
            {
                mCOD_GRUPO = value;
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

        GRUPO_USUARIO()
        {
        }

        GRUPO_USUARIO(bool ACCESO, string COD_GRUPO, int ID, string KEY_, string SUB_KEY)
        {
            mACCESO = ACCESO;
            mCOD_GRUPO = COD_GRUPO;
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
