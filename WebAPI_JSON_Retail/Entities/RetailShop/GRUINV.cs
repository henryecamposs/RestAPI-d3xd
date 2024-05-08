using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class GRUINV : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mPOR_GASTOS = 0.0;

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

        public Double POR_GASTOS
        {
            get
            {
                return mPOR_GASTOS;
            }
            set
            {
                mPOR_GASTOS = value;
            }
        }

        GRUINV()
        {
        }

        GRUINV(string CODIGO, string DESCR, int ID, int IDSUC, double POR_GASTOS)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mPOR_GASTOS = POR_GASTOS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
