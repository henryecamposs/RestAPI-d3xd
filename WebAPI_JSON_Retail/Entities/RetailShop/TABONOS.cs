using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TABONOS : ICloneable
    {

        private double mABONOREFE = 0.0;
        private string mCAJA = "";
        private string mDTIPO = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private double mMONTO = 0.0;
        private double mMONTOREFE = 0.0;
        private double mREFERENCIA = 0.0;
        private string mTIPO = "";

        public Double ABONOREFE
        {
            get
            {
                return mABONOREFE;
            }
            set
            {
                mABONOREFE = value;
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

        public string DTIPO
        {
            get
            {
                return mDTIPO;
            }
            set
            {
                mDTIPO = value;
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

        public Double MONTOREFE
        {
            get
            {
                return mMONTOREFE;
            }
            set
            {
                mMONTOREFE = value;
            }
        }

        public Double REFERENCIA
        {
            get
            {
                return mREFERENCIA;
            }
            set
            {
                mREFERENCIA = value;
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

        TABONOS()
        {
        }

        TABONOS(double ABONOREFE, string CAJA, string DTIPO, DateTime FECHA, int ID, int IDSUC, double MONTO, double MONTOREFE, double REFERENCIA, string TIPO)
        {
            mABONOREFE = ABONOREFE;
            mCAJA = CAJA;
            mDTIPO = DTIPO;
            mFECHA = FECHA;
            mID = ID;
            mIDSUC = IDSUC;
            mMONTO = MONTO;
            mMONTOREFE = MONTOREFE;
            mREFERENCIA = REFERENCIA;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
