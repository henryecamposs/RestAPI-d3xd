using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_DEPOSITO_BANCO_DET_DESG : ICloneable
    {

        private string mCATAPORTED = "";
        private string mDEPOSITOD = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mID_DEP_DET = 0;
        private int mID_PAGO = 0;
        private double mMONTO = 0.0;
        private string mNRO_CUENTA = "";
        private string mTIPO = "";
        private string mUID_DET_DEP = "";
        private string mUID_RESPON = "";

        public string CATAPORTED
        {
            get
            {
                return mCATAPORTED;
            }
            set
            {
                mCATAPORTED = value;
            }
        }

        public string DEPOSITOD
        {
            get
            {
                return mDEPOSITOD;
            }
            set
            {
                mDEPOSITOD = value;
            }
        }

        public DateTime FECHA
        {
            get
            {
                return mFECHA;
            }
            set
            {
                mFECHA = value;
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

        public int ID_DEP_DET
        {
            get
            {
                return mID_DEP_DET;
            }
            set
            {
                mID_DEP_DET = value;
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

        public string NRO_CUENTA
        {
            get
            {
                return mNRO_CUENTA;
            }
            set
            {
                mNRO_CUENTA = value;
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

        public string UID_DET_DEP
        {
            get
            {
                return mUID_DET_DEP;
            }
            set
            {
                mUID_DET_DEP = value;
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

        CAJAS_DEPOSITO_BANCO_DET_DESG()
        {
        }

        CAJAS_DEPOSITO_BANCO_DET_DESG(string CATAPORTED, string DEPOSITOD, DateTime FECHA, int ID, int ID_DEP_DET, int ID_PAGO, double MONTO, string NRO_CUENTA, string TIPO, string UID_DET_DEP, string UID_RESPON)
        {
            mCATAPORTED = CATAPORTED;
            mDEPOSITOD = DEPOSITOD;
            mFECHA = FECHA;
            mID = ID;
            mID_DEP_DET = ID_DEP_DET;
            mID_PAGO = ID_PAGO;
            mMONTO = MONTO;
            mNRO_CUENTA = NRO_CUENTA;
            mTIPO = TIPO;
            mUID_DET_DEP = UID_DET_DEP;
            mUID_RESPON = UID_RESPON;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
