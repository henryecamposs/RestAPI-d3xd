using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BOTON : ICloneable
    {

        private int mBoton = 0;
        private string mCodibarr = "";
        private int mCodiboto = 0;
        private double mCodipagi = 0.0;
        private double mColoboto = 0.0;
        private string mDescboto = "";
        private string mDesccorta = "";
        private string mImagboto = "";

        public int Boton
        {
            get
            {
                return mBoton;
            }
            set
            {
                mBoton = value;
            }
        }

        public string Codibarr
        {
            get
            {
                return mCodibarr;
            }
            set
            {
                mCodibarr = value;
            }
        }

        public int Codiboto
        {
            get
            {
                return mCodiboto;
            }
            set
            {
                mCodiboto = value;
            }
        }

        public Double Codipagi
        {
            get
            {
                return mCodipagi;
            }
            set
            {
                mCodipagi = value;
            }
        }

        public Double Coloboto
        {
            get
            {
                return mColoboto;
            }
            set
            {
                mColoboto = value;
            }
        }

        public string Descboto
        {
            get
            {
                return mDescboto;
            }
            set
            {
                mDescboto = value;
            }
        }

        public string Desccorta
        {
            get
            {
                return mDesccorta;
            }
            set
            {
                mDesccorta = value;
            }
        }

        public string Imagboto
        {
            get
            {
                return mImagboto;
            }
            set
            {
                mImagboto = value;
            }
        }

        BOTON()
        {
        }

        BOTON(int boton, string codibarr, int codiboto, double codipagi, double coloboto, string descboto, string desccorta, string imagboto)
        {
            mBoton = Boton;
            mCodibarr = Codibarr;
            mCodiboto = Codiboto;
            mCodipagi = Codipagi;
            mColoboto = Coloboto;
            mDescboto = Descboto;
            mDesccorta = Desccorta;
            mImagboto = Imagboto;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
