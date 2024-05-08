using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class IMPRI_ETI : ICloneable
    {

        private double mCANTI = 0.0;
        private string mCODIGO = "";
        private string mCONT = "";
        private string mCONTU = "";
        private string mDDPTO = "";
        private string mDESCR = "";
        private string mDESCR_PRO = "";
        private string mDGRUPO = "";
        private string mDMARCA = "";
        private string mGRUPO = "";
        private int mID = 0;
        private string mNOMBRE = "";
        private double mPRECIO = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO3 = 0.0;
        private string mPROVEE = "";
        private string mSERIAL = "";
        private double mTIVA = 0.0;

        public Double CANTI
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

        public string CONT
        {
            get
            {
                return mCONT;
            }
            set
            {
                mCONT = value;
            }
        }

        public string CONTU
        {
            get
            {
                return mCONTU;
            }
            set
            {
                mCONTU = value;
            }
        }

        public string DDPTO
        {
            get
            {
                return mDDPTO;
            }
            set
            {
                mDDPTO = value;
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

        public string DESCR_PRO
        {
            get
            {
                return mDESCR_PRO;
            }
            set
            {
                mDESCR_PRO = value;
            }
        }

        public string DGRUPO
        {
            get
            {
                return mDGRUPO;
            }
            set
            {
                mDGRUPO = value;
            }
        }

        public string DMARCA
        {
            get
            {
                return mDMARCA;
            }
            set
            {
                mDMARCA = value;
            }
        }

        public string GRUPO
        {
            get
            {
                return mGRUPO;
            }
            set
            {
                mGRUPO = value;
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

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double PRECIO
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

        public Double PRECIO1
        {
            get
            {
                return mPRECIO1;
            }
            set
            {
                mPRECIO1 = value;
            }
        }

        public Double PRECIO2
        {
            get
            {
                return mPRECIO2;
            }
            set
            {
                mPRECIO2 = value;
            }
        }

        public Double PRECIO3
        {
            get
            {
                return mPRECIO3;
            }
            set
            {
                mPRECIO3 = value;
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

        public string SERIAL
        {
            get
            {
                return mSERIAL;
            }
            set
            {
                mSERIAL = value;
            }
        }

        public Double TIVA
        {
            get
            {
                return mTIVA;
            }
            set
            {
                mTIVA = value;
            }
        }

        IMPRI_ETI()
        {
        }

        IMPRI_ETI(double CANTI, string CODIGO, string CONT, string CONTU, string DDPTO, string DESCR, string DESCR_PRO, string DGRUPO, string DMARCA, string GRUPO, int ID, string NOMBRE, double PRECIO, double PRECIO1, double PRECIO2, double PRECIO3, string PROVEE, string SERIAL, double TIVA)
        {
            mCANTI = CANTI;
            mCODIGO = CODIGO;
            mCONT = CONT;
            mCONTU = CONTU;
            mDDPTO = DDPTO;
            mDESCR = DESCR;
            mDESCR_PRO = DESCR_PRO;
            mDGRUPO = DGRUPO;
            mDMARCA = DMARCA;
            mGRUPO = GRUPO;
            mID = ID;
            mNOMBRE = NOMBRE;
            mPRECIO = PRECIO;
            mPRECIO1 = PRECIO1;
            mPRECIO2 = PRECIO2;
            mPRECIO3 = PRECIO3;
            mPROVEE = PROVEE;
            mSERIAL = SERIAL;
            mTIVA = TIVA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
