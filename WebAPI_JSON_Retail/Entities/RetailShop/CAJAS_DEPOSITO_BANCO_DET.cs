using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_DEPOSITO_BANCO_DET : ICloneable
    {

        private string mCATAPORTE = "";
        private double mCOM_PVB = 0.0;
        private string mDEPOSITO = "";
        private int mID = 0;
        private int mID_DEP = 0;
        private int mID_PAGO = 0;
        private int mID_PVB = 0;
        private double mISLR_PVB = 0.0;
        private double mMONTO = 0.0;
        private double mMONTO_CON = 0.0;
        private string mNROCTA = "";
        private string mTIPO = "";
        private string mUID = "";
        private string mUID_DEPOSITO = "";
        private string mUID_RESPON = "";

        public string CATAPORTE
        {
            get
            {
                return mCATAPORTE;
            }
            set
            {
                mCATAPORTE = value;
            }
        }

        public Double COM_PVB
        {
            get
            {
                return mCOM_PVB;
            }
            set
            {
                mCOM_PVB = value;
            }
        }

        public string DEPOSITO
        {
            get
            {
                return mDEPOSITO;
            }
            set
            {
                mDEPOSITO = value;
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

        public int ID_DEP
        {
            get
            {
                return mID_DEP;
            }
            set
            {
                mID_DEP = value;
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

        public Double ISLR_PVB
        {
            get
            {
                return mISLR_PVB;
            }
            set
            {
                mISLR_PVB = value;
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

        public Double MONTO_CON
        {
            get
            {
                return mMONTO_CON;
            }
            set
            {
                mMONTO_CON = value;
            }
        }

        public string NROCTA
        {
            get
            {
                return mNROCTA;
            }
            set
            {
                mNROCTA = value;
            }
        }

        public string TIPO
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

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
            }
        }

        public string UID_DEPOSITO
        {
            get
            {
                return mUID_DEPOSITO;
            }
            set
            {
                mUID_DEPOSITO = value;
            }
        }

        public string UID_RESPON
        {
            get
            {
                return mUID_RESPON;
            }
            set
            {
                mUID_RESPON = value;
            }
        }

        CAJAS_DEPOSITO_BANCO_DET()
        {
        }

        CAJAS_DEPOSITO_BANCO_DET(string CATAPORTE, double COM_PVB, string DEPOSITO, int ID, int ID_DEP, int ID_PAGO, int ID_PVB, double ISLR_PVB, double MONTO, double MONTO_CON, string NROCTA, string TIPO, string UID, string UID_DEPOSITO, string UID_RESPON)
        {
            mCATAPORTE = CATAPORTE;
            mCOM_PVB = COM_PVB;
            mDEPOSITO = DEPOSITO;
            mID = ID;
            mID_DEP = ID_DEP;
            mID_PAGO = ID_PAGO;
            mID_PVB = ID_PVB;
            mISLR_PVB = ISLR_PVB;
            mMONTO = MONTO;
            mMONTO_CON = MONTO_CON;
            mNROCTA = NROCTA;
            mTIPO = TIPO;
            mUID = UID;
            mUID_DEPOSITO = UID_DEPOSITO;
            mUID_RESPON = UID_RESPON;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
