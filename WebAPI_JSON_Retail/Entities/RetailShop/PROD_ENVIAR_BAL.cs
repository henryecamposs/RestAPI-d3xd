using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROD_ENVIAR_BAL : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private double mDIASV = 0.0;
        private string mDPTO = "";
        private int mID = 0;
        private string mNOMBRE = "";
        private double mPRECIO = 0.0;
        private double mTENVIO = 0.0;
        private double mTIVA = 0.0;
        private double mTPESO = 0.0;

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

        public Double DIASV
        {
            get
            {
                return mDIASV;
            }
            set
            {
                mDIASV = value;
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

        public Double TENVIO
        {
            get
            {
                return mTENVIO;
            }
            set
            {
                mTENVIO = value;
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

        public Double TPESO
        {
            get
            {
                return mTPESO;
            }
            set
            {
                mTPESO = value;
            }
        }

        PROD_ENVIAR_BAL()
        {
        }

        PROD_ENVIAR_BAL(string CODIGO, string DESCR, double DIASV, string DPTO, int ID, string NOMBRE, double PRECIO, double TENVIO, double TIVA, double TPESO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDIASV = DIASV;
            mDPTO = DPTO;
            mID = ID;
            mNOMBRE = NOMBRE;
            mPRECIO = PRECIO;
            mTENVIO = TENVIO;
            mTIVA = TIVA;
            mTPESO = TPESO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
