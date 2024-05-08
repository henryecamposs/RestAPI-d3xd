using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_ALMACENAMIENTO : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private double mESTATUS = 0.0;
        private int mID = 0;

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

        public Double ESTATUS
        {
            get
            {
                return mESTATUS;
            }
            set
            {
                mESTATUS = value;
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

        TIPO_ALMACENAMIENTO()
        {
        }

        TIPO_ALMACENAMIENTO(string CODIGO, string DESCR, double ESTATUS, int ID)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mESTATUS = ESTATUS;
            mID = ID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
