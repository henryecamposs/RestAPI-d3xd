using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_PAGOS : ICloneable
    {

        private string mCAJA = "";
        private string mCODIGO = "";
        private double mCOM_PVB = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mID_BANCO = 0;
        private int mID_DOCU = 0;
        private int mID_PAGO = 0;
        private int mID_PVB = 0;
        private double mISLR_PVB = 0.0;
        private double mMONTO = 0.0;
        private double mNRO = 0.0;
        private string mTIPOD = "";
        private double mTIPOP = 0.0;

        public string CAJA
        {
            get
            {
                return mCAJA;
            }
            set
            {
                mCAJA = value;
            }
        }

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

        public int ID_BANCO
        {
            get
            {
                return mID_BANCO;
            }
            set
            {
                mID_BANCO = value;
            }
        }

        public int ID_DOCU
        {
            get
            {
                return mID_DOCU;
            }
            set
            {
                mID_DOCU = value;
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

        public Double NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        public string TIPOD
        {
            get
            {
                return mTIPOD;
            }
            set
            {
                mTIPOD = value;
            }
        }

        public Double TIPOP
        {
            get
            {
                return mTIPOP;
            }
            set
            {
                mTIPOP = value;
            }
        }

        CAJAS_PAGOS()
        {
        }

        CAJAS_PAGOS(string CAJA, string CODIGO, double COM_PVB, DateTime FECHA, int ID, int ID_BANCO, int ID_DOCU, int ID_PAGO, int ID_PVB, double ISLR_PVB, double MONTO, double NRO, string TIPOD, double TIPOP)
        {
            mCAJA = CAJA;
            mCODIGO = CODIGO;
            mCOM_PVB = COM_PVB;
            mFECHA = FECHA;
            mID = ID;
            mID_BANCO = ID_BANCO;
            mID_DOCU = ID_DOCU;
            mID_PAGO = ID_PAGO;
            mID_PVB = ID_PVB;
            mISLR_PVB = ISLR_PVB;
            mMONTO = MONTO;
            mNRO = NRO;
            mTIPOD = TIPOD;
            mTIPOP = TIPOP;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
