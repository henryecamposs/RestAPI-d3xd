using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RECARGOS : ICloneable
    {

        private int mCODIGO = 0;
        private string mDESCR = "";
        private int mIDSUC = 0;
        private double mPORC = 0.0;

        public int CODIGO
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

        public Double PORC
        {
            get
            {
                return mPORC;
            }
            set
            {
                mPORC = value;
            }
        }

        RECARGOS()
        {
        }

        RECARGOS(int CODIGO, string DESCR, int IDSUC, double PORC)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mIDSUC = IDSUC;
            mPORC = PORC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
