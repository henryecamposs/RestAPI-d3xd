using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_SALDO_FAVOR : ICloneable
    {

        private string mCODIGO1 = "";
        private string mCODIGO2 = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private double mORIGEN = 0.0;
        private double mTIPODOC = 0.0;

        public string CODIGO1
        {
            get
            {
                return mCODIGO1;
            }
            set
            {
                mCODIGO1 = value;
            }
        }

        public string CODIGO2
        {
            get
            {
                return mCODIGO2;
            }
            set
            {
                mCODIGO2 = value;
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

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public Double ORIGEN
        {
            get
            {
                return mORIGEN;
            }
            set
            {
                mORIGEN = value;
            }
        }

        public Double TIPODOC
        {
            get
            {
                return mTIPODOC;
            }
            set
            {
                mTIPODOC = value;
            }
        }

        TIPO_SALDO_FAVOR()
        {
        }

        TIPO_SALDO_FAVOR(string CODIGO1, string CODIGO2, string DESCR, int ID, int IDSUC, double INACTIVO, double ORIGEN, double TIPODOC)
        {
            mCODIGO1 = CODIGO1;
            mCODIGO2 = CODIGO2;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mORIGEN = ORIGEN;
            mTIPODOC = TIPODOC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
