using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MENU_ACCESO : ICloneable
    {

        private string mCOMANDO = "";
        private string mCONDICION = "";
        private string mDEFINEPAD = "";
        private int mID = 0;
        private bool mITEMNIVEL2 = false;
        private string mKEY_ = "";
        private string mPOPUP_A = "";
        private string mPOPUP_C = "";
        private bool mSEPARA = false;
        private string mSUB_KEY = "";
        private string mTECLA = "";
        private string mTITULO = "";
        private string mCod_grupo = "";

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

        public string CONDICION
        {
            get
            {
                return mCONDICION;
            }
            set
            {
                mCONDICION = value;
            }
        }

        public string DEFINEPAD
        {
            get
            {
                return mDEFINEPAD;
            }
            set
            {
                mDEFINEPAD = value;
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

        public Boolean ITEMNIVEL2
        {
            get
            {
                return mITEMNIVEL2;
            }
            set
            {
                mITEMNIVEL2 = value;
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

        public string POPUP_A
        {
            get
            {
                return mPOPUP_A;
            }
            set
            {
                mPOPUP_A = value;
            }
        }

        public string POPUP_C
        {
            get
            {
                return mPOPUP_C;
            }
            set
            {
                mPOPUP_C = value;
            }
        }

        public Boolean SEPARA
        {
            get
            {
                return mSEPARA;
            }
            set
            {
                mSEPARA = value;
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

        public string TECLA
        {
            get
            {
                return mTECLA;
            }
            set
            {
                mTECLA = value;
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

        public string Cod_grupo
        {
            get
            {
                return mCod_grupo;
            }
            set
            {
                mCod_grupo = value;
            }
        }

        MENU_ACCESO()
        {
        }

        MENU_ACCESO(string COMANDO, string CONDICION, string DEFINEPAD, int ID, bool ITEMNIVEL2, string KEY_, string POPUP_A, string POPUP_C, bool SEPARA, string SUB_KEY, string TECLA, string TITULO, string cod_grupo)
        {
            mCOMANDO = COMANDO;
            mCONDICION = CONDICION;
            mDEFINEPAD = DEFINEPAD;
            mID = ID;
            mITEMNIVEL2 = ITEMNIVEL2;
            mKEY_ = KEY_;
            mPOPUP_A = POPUP_A;
            mPOPUP_C = POPUP_C;
            mSEPARA = SEPARA;
            mSUB_KEY = SUB_KEY;
            mTECLA = TECLA;
            mTITULO = TITULO;
            mCod_grupo = Cod_grupo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
