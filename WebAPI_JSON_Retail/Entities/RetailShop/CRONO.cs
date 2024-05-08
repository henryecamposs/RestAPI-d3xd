using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CRONO : ICloneable
    {

        private string mCODIGO = "";
        private DateTime mDFECHA = new DateTime(2000, 01, 01);
        private string mDHORA = "";
        private double mDHORAM = 0.0;
        private double mDOMINGO = 0.0;
        private DateTime mHFECHA = new DateTime(2000, 01, 01);
        private string mHHORA = "";
        private double mHHORAM = 0.0;
        private int mID = 0;
        private int mIDSUC = 0;
        private double mJUEVES = 0.0;
        private double mLUNES = 0.0;
        private double mMARTES = 0.0;
        private double mMIERCOLES = 0.0;
        private string mNOMBRE = "";
        private double mPRECIO = 0.0;
        private double mSABADO = 0.0;
        private double mVIERNES = 0.0;

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

        public DateTime DFECHA
        {
            get
            {
                return mDFECHA;
            }
            set
            {
                mDFECHA = value;
            }
        }

        public string DHORA
        {
            get
            {
                return mDHORA;
            }
            set
            {
                mDHORA = value;
            }
        }

        public Double DHORAM
        {
            get
            {
                return mDHORAM;
            }
            set
            {
                mDHORAM = value;
            }
        }

        public Double DOMINGO
        {
            get
            {
                return mDOMINGO;
            }
            set
            {
                mDOMINGO = value;
            }
        }

        public DateTime HFECHA
        {
            get
            {
                return mHFECHA;
            }
            set
            {
                mHFECHA = value;
            }
        }

        public string HHORA
        {
            get
            {
                return mHHORA;
            }
            set
            {
                mHHORA = value;
            }
        }

        public Double HHORAM
        {
            get
            {
                return mHHORAM;
            }
            set
            {
                mHHORAM = value;
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

        public Double JUEVES
        {
            get
            {
                return mJUEVES;
            }
            set
            {
                mJUEVES = value;
            }
        }

        public Double LUNES
        {
            get
            {
                return mLUNES;
            }
            set
            {
                mLUNES = value;
            }
        }

        public Double MARTES
        {
            get
            {
                return mMARTES;
            }
            set
            {
                mMARTES = value;
            }
        }

        public Double MIERCOLES
        {
            get
            {
                return mMIERCOLES;
            }
            set
            {
                mMIERCOLES = value;
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

        public Double PRECIO
        {
            get
            {
                return mPRECIO;
            }
            set
            {
                mPRECIO = value;
            }
        }

        public Double SABADO
        {
            get
            {
                return mSABADO;
            }
            set
            {
                mSABADO = value;
            }
        }

        public Double VIERNES
        {
            get
            {
                return mVIERNES;
            }
            set
            {
                mVIERNES = value;
            }
        }

        CRONO()
        {
        }

        CRONO(string CODIGO, DateTime DFECHA, string DHORA, double DHORAM, double DOMINGO, DateTime HFECHA, string HHORA, double HHORAM, int ID, int IDSUC, double JUEVES, double LUNES, double MARTES, double MIERCOLES, string NOMBRE, double PRECIO, double SABADO, double VIERNES)
        {
            mCODIGO = CODIGO;
            mDFECHA = DFECHA;
            mDHORA = DHORA;
            mDHORAM = DHORAM;
            mDOMINGO = DOMINGO;
            mHFECHA = HFECHA;
            mHHORA = HHORA;
            mHHORAM = HHORAM;
            mID = ID;
            mIDSUC = IDSUC;
            mJUEVES = JUEVES;
            mLUNES = LUNES;
            mMARTES = MARTES;
            mMIERCOLES = MIERCOLES;
            mNOMBRE = NOMBRE;
            mPRECIO = PRECIO;
            mSABADO = SABADO;
            mVIERNES = VIERNES;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
