using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CARGOS : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNIVEL = 0.0;
        private double mTPAGO = 0.0;

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

        public Double TPAGO
        {
            get
            {
                return mTPAGO;
            }
            set
            {
                mTPAGO = value;
            }
        }

        CARGOS()
        {
        }

        CARGOS(string CODIGO, string DESCR, int ID, int IDSUC, double NIVEL, double TPAGO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mNIVEL = NIVEL;
            mTPAGO = TPAGO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
