using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ESTACIONES : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mIDSUC = 0;
        private int mID_ESTA = 0;
        private double mID_PLANTI = 0.0;
        private double mINACTIVO = 0.0;
        private bool mMODI_CLI = false;
        private bool mMODI_PRO = false;
        private string mRUTA = "";
        private double mTRANSMITE = 0.0;
        private double mVERSIONA = 0.0;

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

        public string DESCR
        {
            get
            {
                return mDESCR;
            }
            set
            {
                mDESCR = value;
            }
        }

        public int IDSUC
        {
            get
            {
                return mIDSUC;
            }
            set
            {
                mIDSUC = value;
            }
        }

        public int ID_ESTA
        {
            get
            {
                return mID_ESTA;
            }
            set
            {
                mID_ESTA = value;
            }
        }

        public Double ID_PLANTI
        {
            get
            {
                return mID_PLANTI;
            }
            set
            {
                mID_PLANTI = value;
            }
        }

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public Boolean MODI_CLI
        {
            get
            {
                return mMODI_CLI;
            }
            set
            {
                mMODI_CLI = value;
            }
        }

        public Boolean MODI_PRO
        {
            get
            {
                return mMODI_PRO;
            }
            set
            {
                mMODI_PRO = value;
            }
        }

        public string RUTA
        {
            get
            {
                return mRUTA;
            }
            set
            {
                mRUTA = value;
            }
        }

        public Double TRANSMITE
        {
            get
            {
                return mTRANSMITE;
            }
            set
            {
                mTRANSMITE = value;
            }
        }

        public Double VERSIONA
        {
            get
            {
                return mVERSIONA;
            }
            set
            {
                mVERSIONA = value;
            }
        }

        ESTACIONES()
        {
        }

        ESTACIONES(string CODIGO, string DESCR, int IDSUC, int ID_ESTA, double ID_PLANTI, double INACTIVO, bool MODI_CLI, bool MODI_PRO, string RUTA, double TRANSMITE, double VERSIONA)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mIDSUC = IDSUC;
            mID_ESTA = ID_ESTA;
            mID_PLANTI = ID_PLANTI;
            mINACTIVO = INACTIVO;
            mMODI_CLI = MODI_CLI;
            mMODI_PRO = MODI_PRO;
            mRUTA = RUTA;
            mTRANSMITE = TRANSMITE;
            mVERSIONA = VERSIONA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
