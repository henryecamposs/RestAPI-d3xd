using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class IMPORTACOMPRA : ICloneable
    {

        private string mARCHIVO = "";
        private string mCANTI = "";
        private string mCOD_PRO = "";
        private string mDPTO = "";
        private string mFECHAV = "";
        private string mFEC_COM = "";
        private int mID = 0;
        private string mNROCOMP = "";
        private string mNROLOTE = "";
        private string mPRECIO = "";
        private string mPROVEE = "";

        public string ARCHIVO
        {
            get
            {
                return mARCHIVO;
            }
            set
            {
                mARCHIVO = value;
            }
        }

        public string CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
            }
        }

        public string COD_PRO
        {
            get
            {
                return mCOD_PRO;
            }
            set
            {
                mCOD_PRO = value;
            }
        }

        public string DPTO
        {
            get
            {
                return mDPTO;
            }
            set
            {
                mDPTO = value;
            }
        }

        public string FECHAV
        {
            get
            {
                return mFECHAV;
            }
            set
            {
                mFECHAV = value;
            }
        }

        public string FEC_COM
        {
            get
            {
                return mFEC_COM;
            }
            set
            {
                mFEC_COM = value;
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

        public string NROCOMP
        {
            get
            {
                return mNROCOMP;
            }
            set
            {
                mNROCOMP = value;
            }
        }

        public string NROLOTE
        {
            get
            {
                return mNROLOTE;
            }
            set
            {
                mNROLOTE = value;
            }
        }

        public string PRECIO
        {
            get
            {
                return mPRECIO;
            }
            set
            {
                mPRECIO = value;
            }
        }

        public string PROVEE
        {
            get
            {
                return mPROVEE;
            }
            set
            {
                mPROVEE = value;
            }
        }

        IMPORTACOMPRA()
        {
        }

        IMPORTACOMPRA(string ARCHIVO, string CANTI, string COD_PRO, string DPTO, string FECHAV, string FEC_COM, int ID, string NROCOMP, string NROLOTE, string PRECIO, string PROVEE)
        {
            mARCHIVO = ARCHIVO;
            mCANTI = CANTI;
            mCOD_PRO = COD_PRO;
            mDPTO = DPTO;
            mFECHAV = FECHAV;
            mFEC_COM = FEC_COM;
            mID = ID;
            mNROCOMP = NROCOMP;
            mNROLOTE = NROLOTE;
            mPRECIO = PRECIO;
            mPROVEE = PROVEE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
