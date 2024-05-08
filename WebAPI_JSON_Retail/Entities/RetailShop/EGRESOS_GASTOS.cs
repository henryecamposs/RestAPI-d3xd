using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class EGRESOS_GASTOS : ICloneable
    {

        private string mCOD = "";
        private string mCODCTA = "";
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;

        public string COD
        {
            get
            {
                return mCOD;
            }
            set
            {
                mCOD = value;
            }
        }

        public string CODCTA
        {
            get
            {
                return mCODCTA;
            }
            set
            {
                mCODCTA = value;
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

        EGRESOS_GASTOS()
        {
        }

        EGRESOS_GASTOS(string COD, string CODCTA, string DESCR, int ID, int IDSUC, double INACTIVO)
        {
            mCOD = COD;
            mCODCTA = CODCTA;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
