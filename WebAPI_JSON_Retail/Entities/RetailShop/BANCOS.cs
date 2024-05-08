using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BANCOS : ICloneable
    {

        private double mALTOI = 0.0;
        private double mANCHOI = 0.0;
        private string mBOTON = "";
        private string mCODIGO = "";
        private string mCODSAP = "";
        private double mCOLORF = 0.0;
        private double mFUENTEC = 0.0;
        private string mFUENTEF = "";
        private double mFUENTES = 0.0;
        private string mFUENTET = "";
        private string mHORAD = "";
        private string mHORAH = "";
        private int mID = 0;
        private string mIMAGEN = "";
        private string mIMAGENT = "";
        private double mINACTIVO = 0.0;
        private string mNOMBRE = "";
        private bool mOCULTO = false;
        private string mTIPO = "";
        private double mTITULO = 0.0;
        private double mTRANSPA = 0.0;

        public Double ALTOI
        {
            get
            {
                return mALTOI;
            }
            set
            {
                mALTOI = value;
            }
        }

        public Double ANCHOI
        {
            get
            {
                return mANCHOI;
            }
            set
            {
                mANCHOI = value;
            }
        }

        public string BOTON
        {
            get
            {
                return mBOTON;
            }
            set
            {
                mBOTON = value;
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

        public string CODSAP
        {
            get
            {
                return mCODSAP;
            }
            set
            {
                mCODSAP = value;
            }
        }

        public Double COLORF
        {
            get
            {
                return mCOLORF;
            }
            set
            {
                mCOLORF = value;
            }
        }

        public Double FUENTEC
        {
            get
            {
                return mFUENTEC;
            }
            set
            {
                mFUENTEC = value;
            }
        }

        public string FUENTEF
        {
            get
            {
                return mFUENTEF;
            }
            set
            {
                mFUENTEF = value;
            }
        }

        public Double FUENTES
        {
            get
            {
                return mFUENTES;
            }
            set
            {
                mFUENTES = value;
            }
        }

        public string FUENTET
        {
            get
            {
                return mFUENTET;
            }
            set
            {
                mFUENTET = value;
            }
        }

        public string HORAD
        {
            get
            {
                return mHORAD;
            }
            set
            {
                mHORAD = value;
            }
        }

        public string HORAH
        {
            get
            {
                return mHORAH;
            }
            set
            {
                mHORAH = value;
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

        public string IMAGEN
        {
            get
            {
                return mIMAGEN;
            }
            set
            {
                mIMAGEN = value;
            }
        }

        public string IMAGENT
        {
            get
            {
                return mIMAGENT;
            }
            set
            {
                mIMAGENT = value;
            }
        }

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Boolean OCULTO
        {
            get
            {
                return mOCULTO;
            }
            set
            {
                mOCULTO = value;
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

        public Double TITULO
        {
            get
            {
                return mTITULO;
            }
            set
            {
                mTITULO = value;
            }
        }

        public Double TRANSPA
        {
            get
            {
                return mTRANSPA;
            }
            set
            {
                mTRANSPA = value;
            }
        }

        BANCOS()
        {
        }

        BANCOS(double ALTOI, double ANCHOI, string BOTON, string CODIGO, string CODSAP, double COLORF, double FUENTEC, string FUENTEF, double FUENTES, string FUENTET, string HORAD, string HORAH, int ID, string IMAGEN, string IMAGENT, double INACTIVO, string NOMBRE, bool OCULTO, string TIPO, double TITULO, double TRANSPA)
        {
            mALTOI = ALTOI;
            mANCHOI = ANCHOI;
            mBOTON = BOTON;
            mCODIGO = CODIGO;
            mCODSAP = CODSAP;
            mCOLORF = COLORF;
            mFUENTEC = FUENTEC;
            mFUENTEF = FUENTEF;
            mFUENTES = FUENTES;
            mFUENTET = FUENTET;
            mHORAD = HORAD;
            mHORAH = HORAH;
            mID = ID;
            mIMAGEN = IMAGEN;
            mIMAGENT = IMAGENT;
            mINACTIVO = INACTIVO;
            mNOMBRE = NOMBRE;
            mOCULTO = OCULTO;
            mTIPO = TIPO;
            mTITULO = TITULO;
            mTRANSPA = TRANSPA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
