using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MENU_BARRA : ICloneable
    {

        private bool mACCESO = false;
        private double mANCHO = 0.0;
        private string mCODIGO = "";
        private string mCOMANDO = "";
        private int mID = 0;
        private string mIMAGEN = "";
        private string mKEY_ = "";
        private string mMTAG = "";
        private string mSUB_KEY = "";
        private string mTITULO = "";

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

        public Double ANCHO
        {
            get
            {
                return mANCHO;
            }
            set
            {
                mANCHO = value;
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

        public string COMANDO
        {
            get
            {
                return mCOMANDO;
            }
            set
            {
                mCOMANDO = value;
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

        public string IMAGEN
        {
            get
            {
                return mIMAGEN;
            }
            set
            {
                mIMAGEN = value;
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

        public string MTAG
        {
            get
            {
                return mMTAG;
            }
            set
            {
                mMTAG = value;
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

        public string TITULO
        {
            get
            {
                return mTITULO;
            }
            set
            {
                mTITULO = value;
            }
        }

        MENU_BARRA()
        {
        }

        MENU_BARRA(bool ACCESO, double ANCHO, string CODIGO, string COMANDO, int ID, string IMAGEN, string KEY_, string MTAG, string SUB_KEY, string TITULO)
        {
            mACCESO = ACCESO;
            mANCHO = ANCHO;
            mCODIGO = CODIGO;
            mCOMANDO = COMANDO;
            mID = ID;
            mIMAGEN = IMAGEN;
            mKEY_ = KEY_;
            mMTAG = MTAG;
            mSUB_KEY = SUB_KEY;
            mTITULO = TITULO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
