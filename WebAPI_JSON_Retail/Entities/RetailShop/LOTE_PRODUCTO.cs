using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class LOTE_PRODUCTO : ICloneable
    {

        private double mCANT = 0.0;
        private string mCODIGO = "";
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mFECHAC = "";
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNROCOMPRA = 0.0;
        private string mNROCOMPRAC = "";
        private string mNROLOTE = "";
        private double mPRECIO = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO3 = 0.0;
        private string mPROVEE = "";
        private double mSAL = 0.0;

        public Double CANT
        {
            get
            {
                return mCANT;
            }
            set
            {
                mCANT = value;
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

        public Double COSTOP
        {
            get
            {
                return mCOSTOP;
            }
            set
            {
                mCOSTOP = value;
            }
        }

        public Double COSTOU
        {
            get
            {
                return mCOSTOU;
            }
            set
            {
                mCOSTOU = value;
            }
        }

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
            }
        }

        public DateTime FECHAV
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

        public Double NROCOMPRA
        {
            get
            {
                return mNROCOMPRA;
            }
            set
            {
                mNROCOMPRA = value;
            }
        }

        public string NROCOMPRAC
        {
            get
            {
                return mNROCOMPRAC;
            }
            set
            {
                mNROCOMPRAC = value;
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

        public Double SAL
        {
            get
            {
                return mSAL;
            }
            set
            {
                mSAL = value;
            }
        }

        LOTE_PRODUCTO()
        {
        }

        LOTE_PRODUCTO(double CANT, string CODIGO, double COSTOP, double COSTOU, string FECHAC, DateTime FECHAV, int ID, int IDSUC, double NROCOMPRA, string NROCOMPRAC, string NROLOTE, double PRECIO, double PRECIO1, double PRECIO2, double PRECIO3, string PROVEE, double SAL)
        {
            mCANT = CANT;
            mCODIGO = CODIGO;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mFECHAC = FECHAC;
            mFECHAV = FECHAV;
            mID = ID;
            mIDSUC = IDSUC;
            mNROCOMPRA = NROCOMPRA;
            mNROCOMPRAC = NROCOMPRAC;
            mNROLOTE = NROLOTE;
            mPRECIO = PRECIO;
            mPRECIO1 = PRECIO1;
            mPRECIO2 = PRECIO2;
            mPRECIO3 = PRECIO3;
            mPROVEE = PROVEE;
            mSAL = SAL;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
