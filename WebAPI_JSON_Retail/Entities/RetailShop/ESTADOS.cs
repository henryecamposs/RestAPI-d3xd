using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ESTADOS : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCRIP = "";
        private int mIDESTADO = 0;
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

        public string DESCRIP
        {
            get
            {
                return mDESCRIP;
            }
            set
            {
                mDESCRIP = value;
            }
        }

        public int IDESTADO
        {
            get
            {
                return mIDESTADO;
            }
            set
            {
                mIDESTADO = value;
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

        ESTADOS()
        {
        }

        ESTADOS(string CODIGO, string DESCRIP, int IDESTADO, int IDPAIS)
        {
            mCODIGO = CODIGO;
            mDESCRIP = DESCRIP;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
