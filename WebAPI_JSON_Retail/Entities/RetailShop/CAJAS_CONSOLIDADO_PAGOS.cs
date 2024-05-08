using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS_CONSOLIDADO_PAGOS : ICloneable
    {

        private string mCATAPORTE = "";
        private double mCOM_PVB = 0.0;
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_PAGO = 0;
        private int mID_PVB = 0;
        private double mISLR_PVB = 0.0;
        private double mMONTO = 0.0;
        private string mNOMEMP = "";
        private string mNROCUENTA = "";
        private string mNRODEPO = "";
        private int mNRO_OPE = 0;

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

        public string EMPLE
        {
            get
            {
                return mEMPLE;
            }
            set
            {
                mEMPLE = value;
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

        public string NOMEMP
        {
            get
            {
                return mNOMEMP;
            }
            set
            {
                mNOMEMP = value;
            }
        }

        public string NROCUENTA
        {
            get
            {
                return mNROCUENTA;
            }
            set
            {
                mNROCUENTA = value;
            }
        }

        public string NRODEPO
        {
            get
            {
                return mNRODEPO;
            }
            set
            {
                mNRODEPO = value;
            }
        }

        public int NRO_OPE
        {
            get
            {
                return mNRO_OPE;
            }
            set
            {
                mNRO_OPE = value;
            }
        }

        CAJAS_CONSOLIDADO_PAGOS()
        {
        }

        CAJAS_CONSOLIDADO_PAGOS(string CATAPORTE, double COM_PVB, string EMPLE, DateTime FECHA, int ID, int IDSUC, int ID_PAGO, int ID_PVB, double ISLR_PVB, double MONTO, string NOMEMP, string NROCUENTA, string NRODEPO, int NRO_OPE)
        {
            mCATAPORTE = CATAPORTE;
            mCOM_PVB = COM_PVB;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mID = ID;
            mIDSUC = IDSUC;
            mID_PAGO = ID_PAGO;
            mID_PVB = ID_PVB;
            mISLR_PVB = ISLR_PVB;
            mMONTO = MONTO;
            mNOMEMP = NOMEMP;
            mNROCUENTA = NROCUENTA;
            mNRODEPO = NRODEPO;
            mNRO_OPE = NRO_OPE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
