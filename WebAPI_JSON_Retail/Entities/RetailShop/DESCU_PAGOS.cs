using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DESCU_PAGOS : ICloneable
    {

        private string mDESCU = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private string mPAGO = "";
        private double mTIPO = 0.0;

        public string DESCU
        {
            get
            {
                return mDESCU;
            }
            set
            {
                mDESCU = value;
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

        public string PAGO
        {
            get
            {
                return mPAGO;
            }
            set
            {
                mPAGO = value;
            }
        }

        public Double TIPO
        {
            get
            {
                return mTIPO;
            }
            set
            {
                mTIPO = value;
            }
        }

        DESCU_PAGOS()
        {
        }

        DESCU_PAGOS(string DESCU, int ID, int IDSUC, string PAGO, double TIPO)
        {
            mDESCU = DESCU;
            mID = ID;
            mIDSUC = IDSUC;
            mPAGO = PAGO;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
