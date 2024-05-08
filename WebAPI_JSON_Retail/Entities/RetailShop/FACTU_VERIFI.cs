using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class FACTU_VERIFI : ICloneable
    {

        private string mCAJA = "";
        private double mCFISCAL = 0.0;
        private double mESTATUS = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private string mHORA = "";
        private int mIDVERIFI = 0;
        private string mMAQFIS = "";
        private double mNRO = 0.0;
        private string mUSUARIO = "";

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

        public Double CFISCAL
        {
            get
            {
                return mCFISCAL;
            }
            set
            {
                mCFISCAL = value;
            }
        }

        public Double ESTATUS
        {
            get
            {
                return mESTATUS;
            }
            set
            {
                mESTATUS = value;
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

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
            }
        }

        public string HORA
        {
            get
            {
                return mHORA;
            }
            set
            {
                mHORA = value;
            }
        }

        public int IDVERIFI
        {
            get
            {
                return mIDVERIFI;
            }
            set
            {
                mIDVERIFI = value;
            }
        }

        public string MAQFIS
        {
            get
            {
                return mMAQFIS;
            }
            set
            {
                mMAQFIS = value;
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

        public string USUARIO
        {
            get
            {
                return mUSUARIO;
            }
            set
            {
                mUSUARIO = value;
            }
        }

        FACTU_VERIFI()
        {
        }

        FACTU_VERIFI(string CAJA, double CFISCAL, double ESTATUS, DateTime FECHA, string FECHAC, string HORA, int IDVERIFI, string MAQFIS, double NRO, string USUARIO)
        {
            mCAJA = CAJA;
            mCFISCAL = CFISCAL;
            mESTATUS = ESTATUS;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mHORA = HORA;
            mIDVERIFI = IDVERIFI;
            mMAQFIS = MAQFIS;
            mNRO = NRO;
            mUSUARIO = USUARIO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
