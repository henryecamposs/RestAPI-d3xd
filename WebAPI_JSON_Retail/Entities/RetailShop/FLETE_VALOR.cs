using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class FLETE_VALOR : ICloneable
    {

        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_DEST = 0;
        private int mID_TRANS = 0;
        private double mINACTIVO = 0.0;
        private string mOBSER = "";
        private double mVALOR = 0.0;
        private double mTipo = 0.0;

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

        public int ID_DEST
        {
            get
            {
                return mID_DEST;
            }
            set
            {
                mID_DEST = value;
            }
        }

        public int ID_TRANS
        {
            get
            {
                return mID_TRANS;
            }
            set
            {
                mID_TRANS = value;
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

        public string OBSER
        {
            get
            {
                return mOBSER;
            }
            set
            {
                mOBSER = value;
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

        public Double Tipo
        {
            get
            {
                return mTipo;
            }
            set
            {
                mTipo = value;
            }
        }

        FLETE_VALOR()
        {
        }

        FLETE_VALOR(int ID, int IDSUC, int ID_DEST, int ID_TRANS, double INACTIVO, string OBSER, double VALOR, double tipo)
        {
            mID = ID;
            mIDSUC = IDSUC;
            mID_DEST = ID_DEST;
            mID_TRANS = ID_TRANS;
            mINACTIVO = INACTIVO;
            mOBSER = OBSER;
            mVALOR = VALOR;
            mTipo = Tipo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
