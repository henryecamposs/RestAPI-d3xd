using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SINC_SAPB1 : ICloneable
    {

        private string mCOMENTARIO = "";
        private string mESTACION = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mIDSINC = 0;

        public string COMENTARIO
        {
            get
            {
                return mCOMENTARIO;
            }
            set
            {
                mCOMENTARIO = value;
            }
        }

        public string ESTACION
        {
            get
            {
                return mESTACION;
            }
            set
            {
                mESTACION = value;
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

        public int IDSINC
        {
            get
            {
                return mIDSINC;
            }
            set
            {
                mIDSINC = value;
            }
        }

        SINC_SAPB1()
        {
        }

        SINC_SAPB1(string COMENTARIO, string ESTACION, DateTime FECHA, int IDSINC)
        {
            mCOMENTARIO = COMENTARIO;
            mESTACION = ESTACION;
            mFECHA = FECHA;
            mIDSINC = IDSINC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
