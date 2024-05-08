using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class OPTIONACCESS : ICloneable
    {

        private double mCODIGO = 0.0;
        private string mDESCR = "";
        private string mDESCRIP = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNIVEL = 0.0;

        public Double CODIGO
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

        public Double NIVEL
        {
            get
            {
                return mNIVEL;
            }
            set
            {
                mNIVEL = value;
            }
        }

        OPTIONACCESS()
        {
        }

        OPTIONACCESS(double CODIGO, string DESCR, string DESCRIP, int ID, int IDSUC, double NIVEL)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDESCRIP = DESCRIP;
            mID = ID;
            mIDSUC = IDSUC;
            mNIVEL = NIVEL;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
