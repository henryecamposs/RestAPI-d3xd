using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TABLAS_USUARIOS : ICloneable
    {

        private double mANCLAR = 0.0;
        private string mDESCR = "";
        private double mENLACE = 0.0;
        private double mFICHA = 0.0;
        private int mID_TABLA = 0;
        private double mTIPO = 0.0;

        public Double ANCLAR
        {
            get
            {
                return mANCLAR;
            }
            set
            {
                mANCLAR = value;
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

        public Double ENLACE
        {
            get
            {
                return mENLACE;
            }
            set
            {
                mENLACE = value;
            }
        }

        public Double FICHA
        {
            get
            {
                return mFICHA;
            }
            set
            {
                mFICHA = value;
            }
        }

        public int ID_TABLA
        {
            get
            {
                return mID_TABLA;
            }
            set
            {
                mID_TABLA = value;
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

        TABLAS_USUARIOS()
        {
        }

        TABLAS_USUARIOS(double ANCLAR, string DESCR, double ENLACE, double FICHA, int ID_TABLA, double TIPO)
        {
            mANCLAR = ANCLAR;
            mDESCR = DESCR;
            mENLACE = ENLACE;
            mFICHA = FICHA;
            mID_TABLA = ID_TABLA;
            mTIPO = TIPO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
