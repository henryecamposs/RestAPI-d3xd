using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROMO_RIFA : ICloneable
    {

        private double mCANTI = 0.0;
        private string mDESCR = "";
        private string mFECHACD = "";
        private string mFECHACH = "";
        private DateTime mFECHAD = new DateTime(2000, 01, 01);
        private DateTime mFECHAH = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private double mMONTO = 0.0;
        private double mTICKETS = 0.0;
        private double mTIPO = 0.0;

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
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

        public string FECHACD
        {
            get
            {
                return mFECHACD;
            }
            set
            {
                mFECHACD = value;
            }
        }

        public string FECHACH
        {
            get
            {
                return mFECHACH;
            }
            set
            {
                mFECHACH = value;
            }
        }

        public DateTime FECHAD
        {
            get
            {
                return mFECHAD;
            }
            set
            {
                mFECHAD = value;
            }
        }

        public DateTime FECHAH
        {
            get
            {
                return mFECHAH;
            }
            set
            {
                mFECHAH = value;
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

        public Double TICKETS
        {
            get
            {
                return mTICKETS;
            }
            set
            {
                mTICKETS = value;
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

        PROMO_RIFA()
        {
        }

        PROMO_RIFA(double CANTI, string DESCR, string FECHACD, string FECHACH, DateTime FECHAD, DateTime FECHAH, int ID, int IDSUC, double INACTIVO, double MONTO, double TICKETS, double TIPO)
        {
            mCANTI = CANTI;
            mDESCR = DESCR;
            mFECHACD = FECHACD;
            mFECHACH = FECHACH;
            mFECHAD = FECHAD;
            mFECHAH = FECHAH;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mMONTO = MONTO;
            mTICKETS = TICKETS;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
