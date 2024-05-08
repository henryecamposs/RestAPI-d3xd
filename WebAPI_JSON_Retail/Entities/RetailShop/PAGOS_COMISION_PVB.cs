using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PAGOS_COMISION_PVB : ICloneable
    {

        private double mCOMISION = 0.0;
        private double mCOMOTROB = 0.0;
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_PAGO = 0;
        private int mID_PVB = 0;
        private double mINACTIVO = 0.0;
        private double mISLR = 0.0;

        public Double COMISION
        {
            get
            {
                return mCOMISION;
            }
            set
            {
                mCOMISION = value;
            }
        }

        public Double COMOTROB
        {
            get
            {
                return mCOMOTROB;
            }
            set
            {
                mCOMOTROB = value;
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

        public int ID_PAGO
        {
            get
            {
                return mID_PAGO;
            }
            set
            {
                mID_PAGO = value;
            }
        }

        public int ID_PVB
        {
            get
            {
                return mID_PVB;
            }
            set
            {
                mID_PVB = value;
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

        public Double ISLR
        {
            get
            {
                return mISLR;
            }
            set
            {
                mISLR = value;
            }
        }

        PAGOS_COMISION_PVB()
        {
        }

        PAGOS_COMISION_PVB(double COMISION, double COMOTROB, int ID, int IDSUC, int ID_PAGO, int ID_PVB, double INACTIVO, double ISLR)
        {
            mCOMISION = COMISION;
            mCOMOTROB = COMOTROB;
            mID = ID;
            mIDSUC = IDSUC;
            mID_PAGO = ID_PAGO;
            mID_PVB = ID_PVB;
            mINACTIVO = INACTIVO;
            mISLR = ISLR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
