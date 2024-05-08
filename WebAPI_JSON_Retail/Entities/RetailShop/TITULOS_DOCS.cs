using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TITULOS_DOCS : ICloneable
    {

        private string mABO_CLI = "";
        private string mEGRESO = "";
        private string mEXOIMP = "";
        private string mFACTURA = "";
        private int mID = 0;
        private string mNC = "";
        private string mNOTA_C = "";
        private string mRETENIMP = "";
        private string mRETENISLR = "";

        public string ABO_CLI
        {
            get
            {
                return mABO_CLI;
            }
            set
            {
                mABO_CLI = value;
            }
        }

        public string EGRESO
        {
            get
            {
                return mEGRESO;
            }
            set
            {
                mEGRESO = value;
            }
        }

        public string EXOIMP
        {
            get
            {
                return mEXOIMP;
            }
            set
            {
                mEXOIMP = value;
            }
        }

        public string FACTURA
        {
            get
            {
                return mFACTURA;
            }
            set
            {
                mFACTURA = value;
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

        public string NC
        {
            get
            {
                return mNC;
            }
            set
            {
                mNC = value;
            }
        }

        public string NOTA_C
        {
            get
            {
                return mNOTA_C;
            }
            set
            {
                mNOTA_C = value;
            }
        }

        public string RETENIMP
        {
            get
            {
                return mRETENIMP;
            }
            set
            {
                mRETENIMP = value;
            }
        }

        public string RETENISLR
        {
            get
            {
                return mRETENISLR;
            }
            set
            {
                mRETENISLR = value;
            }
        }

        TITULOS_DOCS()
        {
        }

        TITULOS_DOCS(string ABO_CLI, string EGRESO, string EXOIMP, string FACTURA, int ID, string NC, string NOTA_C, string RETENIMP, string RETENISLR)
        {
            mABO_CLI = ABO_CLI;
            mEGRESO = EGRESO;
            mEXOIMP = EXOIMP;
            mFACTURA = FACTURA;
            mID = ID;
            mNC = NC;
            mNOTA_C = NOTA_C;
            mRETENIMP = RETENIMP;
            mRETENISLR = RETENISLR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
