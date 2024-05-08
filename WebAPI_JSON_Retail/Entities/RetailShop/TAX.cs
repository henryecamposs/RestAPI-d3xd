using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TAX : ICloneable
    {

        private string mCOD_SAPB1 = "";
        private int mID_TAX = 0;
        private string mNOMBRE = "";
        private string mNOMENCLA = "";
        private double mTIPO = 0.0;
        private double mVALOR = 0.0;

        public string COD_SAPB1
        {
            get
            {
                return mCOD_SAPB1;
            }
            set
            {
                mCOD_SAPB1 = value;
            }
        }

        public int ID_TAX
        {
            get
            {
                return mID_TAX;
            }
            set
            {
                mID_TAX = value;
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

        public string NOMENCLA
        {
            get
            {
                return mNOMENCLA;
            }
            set
            {
                mNOMENCLA = value;
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

        public Double VALOR
        {
            get
            {
                return mVALOR;
            }
            set
            {
                mVALOR = value;
            }
        }

        TAX()
        {
        }

        TAX(string COD_SAPB1, int ID_TAX, string NOMBRE, string NOMENCLA, double TIPO, double VALOR)
        {
            mCOD_SAPB1 = COD_SAPB1;
            mID_TAX = ID_TAX;
            mNOMBRE = NOMBRE;
            mNOMENCLA = NOMENCLA;
            mTIPO = TIPO;
            mVALOR = VALOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
