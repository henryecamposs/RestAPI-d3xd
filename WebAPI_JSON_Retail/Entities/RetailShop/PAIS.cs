using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PAIS : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private int mIDPAIS = 0;

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

        public int IDPAIS
        {
            get
            {
                return mIDPAIS;
            }
            set
            {
                mIDPAIS = value;
            }
        }

        PAIS()
        {
        }

        PAIS(string CODIGO, string DESCR, int IDPAIS)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mIDPAIS = IDPAIS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
