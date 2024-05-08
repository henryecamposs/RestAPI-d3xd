using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ORDEN_TRABAJO : ICloneable
    {

        private double mABONO = 0.0;
        private string mCAJA = "";
        private string mEMPLE = "";
        private double mFACTURADO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mID_CLI = "";
        private int mID_ORD = 0;

        public Double ABONO
        {
            get
            {
                return mABONO;
            }
            set
            {
                mABONO = value;
            }
        }

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

        public Double FACTURADO
        {
            get
            {
                return mFACTURADO;
            }
            set
            {
                mFACTURADO = value;
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

        public string ID_CLI
        {
            get
            {
                return mID_CLI;
            }
            set
            {
                mID_CLI = value;
            }
        }

        public int ID_ORD
        {
            get
            {
                return mID_ORD;
            }
            set
            {
                mID_ORD = value;
            }
        }

        ORDEN_TRABAJO()
        {
        }

        ORDEN_TRABAJO(double ABONO, string CAJA, string EMPLE, double FACTURADO, DateTime FECHA, string ID_CLI, int ID_ORD)
        {
            mABONO = ABONO;
            mCAJA = CAJA;
            mEMPLE = EMPLE;
            mFACTURADO = FACTURADO;
            mFECHA = FECHA;
            mID_CLI = ID_CLI;
            mID_ORD = ID_ORD;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
