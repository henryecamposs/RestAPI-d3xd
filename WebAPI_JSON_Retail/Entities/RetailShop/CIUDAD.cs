using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CIUDAD : ICloneable
    {

        private string mCODIGO = "";
        private string mCODPOS = "";
        private string mDESCR = "";
        private int mIDCIUDAD = 0;
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

        public string CODPOS
        {
            get
            {
                return mCODPOS;
            }
            set
            {
                mCODPOS = value;
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

        public int IDCIUDAD
        {
            get
            {
                return mIDCIUDAD;
            }
            set
            {
                mIDCIUDAD = value;
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

        CIUDAD()
        {
        }

        CIUDAD(string CODIGO, string CODPOS, string DESCR, int IDCIUDAD, int IDESTADO, int IDPAIS)
        {
            mCODIGO = CODIGO;
            mCODPOS = CODPOS;
            mDESCR = DESCR;
            mIDCIUDAD = IDCIUDAD;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
