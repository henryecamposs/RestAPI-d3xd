using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class OPERADOR : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private double mDESCU = 0.0;
        private int mID = 0;
        private string mNOMBRE = "";
        private double mNUEVA = 0.0;
        private string mRIF = "";
        private string mTELE = "";

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

        public Double DESCU
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

        public Double NUEVA
        {
            get
            {
                return mNUEVA;
            }
            set
            {
                mNUEVA = value;
            }
        }

        public string RIF
        {
            get
            {
                return mRIF;
            }
            set
            {
                mRIF = value;
            }
        }

        public string TELE
        {
            get
            {
                return mTELE;
            }
            set
            {
                mTELE = value;
            }
        }

        OPERADOR()
        {
        }

        OPERADOR(string CODIGO, string DESCR, double DESCU, int ID, string NOMBRE, double NUEVA, string RIF, string TELE)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDESCU = DESCU;
            mID = ID;
            mNOMBRE = NOMBRE;
            mNUEVA = NUEVA;
            mRIF = RIF;
            mTELE = TELE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
