using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PAGOS : ICloneable
    {

        private string mBOTON = "";
        private bool mCOBRASER = false;
        private string mCODCTA = "";
        private string mCODIGO = "";
        private double mCODMON = 0.0;
        private string mCOD_SAPB1 = "";
        private string mDESCR_REC = "";
        private string mHORAD = "";
        private string mHORAH = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private string mIMAGEN = "";
        private string mIMAGENT = "";
        private double mINACTIVO = 0.0;
        private string mNOMBRE = "";
        private bool mOCULTO = false;
        private double mPORC = 0.0;
        private double mRECARGO = 0.0;
        private double mRIMPALI = 0.0;
        private string mTIPO = "";
        private double mTIPOP = 0.0;
        private double mTITULO = 0.0;
        private double mTRECARGO = 0.0;
        private double mTTARJETA = 0.0;
        private double mVALIDA = 0.0;

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

        public Boolean COBRASER
        {
            get
            {
                return mCOBRASER;
            }
            set
            {
                mCOBRASER = value;
            }
        }

        public string CODCTA
        {
            get
            {
                return mCODCTA;
            }
            set
            {
                mCODCTA = value;
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

        public Double CODMON
        {
            get
            {
                return mCODMON;
            }
            set
            {
                mCODMON = value;
            }
        }

        public string COD_SAPB1
        {
            get
            {
                return mCOD_SAPB1;
            }
            set
            {
                mCOD_SAPB1 = value;
            }
        }

        public string DESCR_REC
        {
            get
            {
                return mDESCR_REC;
            }
            set
            {
                mDESCR_REC = value;
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

        public Double PORC
        {
            get
            {
                return mPORC;
            }
            set
            {
                mPORC = value;
            }
        }

        public Double RECARGO
        {
            get
            {
                return mRECARGO;
            }
            set
            {
                mRECARGO = value;
            }
        }

        public Double RIMPALI
        {
            get
            {
                return mRIMPALI;
            }
            set
            {
                mRIMPALI = value;
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

        public Double TRECARGO
        {
            get
            {
                return mTRECARGO;
            }
            set
            {
                mTRECARGO = value;
            }
        }

        public Double TTARJETA
        {
            get
            {
                return mTTARJETA;
            }
            set
            {
                mTTARJETA = value;
            }
        }

        public Double VALIDA
        {
            get
            {
                return mVALIDA;
            }
            set
            {
                mVALIDA = value;
            }
        }

        PAGOS()
        {
        }

        PAGOS(string BOTON, bool COBRASER, string CODCTA, string CODIGO, double CODMON, string COD_SAPB1, string DESCR_REC, string HORAD, string HORAH, int ID, int IDSUC, string IMAGEN, string IMAGENT, double INACTIVO, string NOMBRE, bool OCULTO, double PORC, double RECARGO, double RIMPALI, string TIPO, double TIPOP, double TITULO, double TRECARGO, double TTARJETA, double VALIDA)
        {
            mBOTON = BOTON;
            mCOBRASER = COBRASER;
            mCODCTA = CODCTA;
            mCODIGO = CODIGO;
            mCODMON = CODMON;
            mCOD_SAPB1 = COD_SAPB1;
            mDESCR_REC = DESCR_REC;
            mHORAD = HORAD;
            mHORAH = HORAH;
            mID = ID;
            mIDSUC = IDSUC;
            mIMAGEN = IMAGEN;
            mIMAGENT = IMAGENT;
            mINACTIVO = INACTIVO;
            mNOMBRE = NOMBRE;
            mOCULTO = OCULTO;
            mPORC = PORC;
            mRECARGO = RECARGO;
            mRIMPALI = RIMPALI;
            mTIPO = TIPO;
            mTIPOP = TIPOP;
            mTITULO = TITULO;
            mTRECARGO = TRECARGO;
            mTTARJETA = TTARJETA;
            mVALIDA = VALIDA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
