using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONC_GASTOS : ICloneable
    {

        private string mCODIGO = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mMONTO = 0.0;
        private string mNOMBRE = "";
        private double mTAX = 0.0;
        private double mTIPO_GASTO = 0.0;

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

        public Double MONTO
        {
            get
            {
                return mMONTO;
            }
            set
            {
                mMONTO = value;
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

        public Double TAX
        {
            get
            {
                return mTAX;
            }
            set
            {
                mTAX = value;
            }
        }

        public Double TIPO_GASTO
        {
            get
            {
                return mTIPO_GASTO;
            }
            set
            {
                mTIPO_GASTO = value;
            }
        }

        CONC_GASTOS()
        {
        }

        CONC_GASTOS(string CODIGO, int ID, int IDSUC, double MONTO, string NOMBRE, double TAX, double TIPO_GASTO)
        {
            mCODIGO = CODIGO;
            mID = ID;
            mIDSUC = IDSUC;
            mMONTO = MONTO;
            mNOMBRE = NOMBRE;
            mTAX = TAX;
            mTIPO_GASTO = TIPO_GASTO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
