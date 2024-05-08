using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DPTO : ICloneable
    {

        private string mCODIGO = "";
        private string mCODPRIN = "";
        private string mDESCR = "";
        private string mDPTO_SAPB1 = "";
        private int mID = 0;
        private int mIDSUC = 0;

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

        public string CODPRIN
        {
            get
            {
                return mCODPRIN;
            }
            set
            {
                mCODPRIN = value;
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

        public string DPTO_SAPB1
        {
            get
            {
                return mDPTO_SAPB1;
            }
            set
            {
                mDPTO_SAPB1 = value;
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

        DPTO()
        {
        }

        DPTO(string CODIGO, string CODPRIN, string DESCR, string DPTO_SAPB1, int ID, int IDSUC)
        {
            mCODIGO = CODIGO;
            mCODPRIN = CODPRIN;
            mDESCR = DESCR;
            mDPTO_SAPB1 = DPTO_SAPB1;
            mID = ID;
            mIDSUC = IDSUC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
