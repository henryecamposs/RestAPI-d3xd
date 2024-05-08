using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class COD_PRO : ICloneable
    {

        private string mBARRA = "";
        private double mBASE_MARGE = 0.0;
        private double mCAL_UTI = 0.0;
        private string mCAMBIO = "";
        private string mCODIGO = "";
        private string mCODIGOP = "";
        private string mDESCR = "";
        private double mENT = 0.0;
        private double mEXIS = 0.0;
        private DateTime mFECHA_M = new DateTime(2000, 01, 01);
        private DateTime mFECHA_R = new DateTime(2000, 01, 01);
        private int mID = 0;
        private double mINI = 0.0;
        private double mMARCA = 0.0;
        private double mMARGEN1 = 0.0;
        private double mMARGEN2 = 0.0;
        private double mMARGEN3 = 0.0;
        private double mMAX = 0.0;
        private double mMIN = 0.0;
        private double mMODO_PRE = 0.0;
        private double mPRECIO = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO3 = 0.0;
        private double mPROMEDIO = 0.0;
        private double mSAL = 0.0;
        private double mULTIMO = 0.0;
        private DateTime mULT_COMPRA = new DateTime(2000, 01, 01);
        private DateTime mULT_VENTA = new DateTime(2000, 01, 01);
        private double mUNIDAD = 0.0;
        private string mUNIDADC = "";
        private double mUNIDADE = 0.0;
        private string mUNIDADV = "";
        private double mUNIDADVC = 0.0;

        public string BARRA
        {
            get
            {
                return mBARRA;
            }
            set
            {
                mBARRA = value;
            }
        }

        public Double BASE_MARGE
        {
            get
            {
                return mBASE_MARGE;
            }
            set
            {
                mBASE_MARGE = value;
            }
        }

        public Double CAL_UTI
        {
            get
            {
                return mCAL_UTI;
            }
            set
            {
                mCAL_UTI = value;
            }
        }

        public string CAMBIO
        {
            get
            {
                return mCAMBIO;
            }
            set
            {
                mCAMBIO = value;
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

        public string CODIGOP
        {
            get
            {
                return mCODIGOP;
            }
            set
            {
                mCODIGOP = value;
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

        public Double ENT
        {
            get
            {
                return mENT;
            }
            set
            {
                mENT = value;
            }
        }

        public Double EXIS
        {
            get
            {
                return mEXIS;
            }
            set
            {
                mEXIS = value;
            }
        }

        public DateTime FECHA_M
        {
            get
            {
                return mFECHA_M;
            }
            set
            {
                mFECHA_M = value;
            }
        }

        public DateTime FECHA_R
        {
            get
            {
                return mFECHA_R;
            }
            set
            {
                mFECHA_R = value;
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

        public Double INI
        {
            get
            {
                return mINI;
            }
            set
            {
                mINI = value;
            }
        }

        public Double MARCA
        {
            get
            {
                return mMARCA;
            }
            set
            {
                mMARCA = value;
            }
        }

        public Double MARGEN1
        {
            get
            {
                return mMARGEN1;
            }
            set
            {
                mMARGEN1 = value;
            }
        }

        public Double MARGEN2
        {
            get
            {
                return mMARGEN2;
            }
            set
            {
                mMARGEN2 = value;
            }
        }

        public Double MARGEN3
        {
            get
            {
                return mMARGEN3;
            }
            set
            {
                mMARGEN3 = value;
            }
        }

        public Double MAX
        {
            get
            {
                return mMAX;
            }
            set
            {
                mMAX = value;
            }
        }

        public Double MIN
        {
            get
            {
                return mMIN;
            }
            set
            {
                mMIN = value;
            }
        }

        public Double MODO_PRE
        {
            get
            {
                return mMODO_PRE;
            }
            set
            {
                mMODO_PRE = value;
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

        public Double PRECIO1
        {
            get
            {
                return mPRECIO1;
            }
            set
            {
                mPRECIO1 = value;
            }
        }

        public Double PRECIO2
        {
            get
            {
                return mPRECIO2;
            }
            set
            {
                mPRECIO2 = value;
            }
        }

        public Double PRECIO3
        {
            get
            {
                return mPRECIO3;
            }
            set
            {
                mPRECIO3 = value;
            }
        }

        public Double PROMEDIO
        {
            get
            {
                return mPROMEDIO;
            }
            set
            {
                mPROMEDIO = value;
            }
        }

        public Double SAL
        {
            get
            {
                return mSAL;
            }
            set
            {
                mSAL = value;
            }
        }

        public Double ULTIMO
        {
            get
            {
                return mULTIMO;
            }
            set
            {
                mULTIMO = value;
            }
        }

        public DateTime ULT_COMPRA
        {
            get
            {
                return mULT_COMPRA;
            }
            set
            {
                mULT_COMPRA = value;
            }
        }

        public DateTime ULT_VENTA
        {
            get
            {
                return mULT_VENTA;
            }
            set
            {
                mULT_VENTA = value;
            }
        }

        public Double UNIDAD
        {
            get
            {
                return mUNIDAD;
            }
            set
            {
                mUNIDAD = value;
            }
        }

        public string UNIDADC
        {
            get
            {
                return mUNIDADC;
            }
            set
            {
                mUNIDADC = value;
            }
        }

        public Double UNIDADE
        {
            get
            {
                return mUNIDADE;
            }
            set
            {
                mUNIDADE = value;
            }
        }

        public string UNIDADV
        {
            get
            {
                return mUNIDADV;
            }
            set
            {
                mUNIDADV = value;
            }
        }

        public Double UNIDADVC
        {
            get
            {
                return mUNIDADVC;
            }
            set
            {
                mUNIDADVC = value;
            }
        }

        COD_PRO()
        {
        }

        COD_PRO(string BARRA, double BASE_MARGE, double CAL_UTI, string CAMBIO, string CODIGO, string CODIGOP, string DESCR, double ENT, double EXIS, DateTime FECHA_M, DateTime FECHA_R, int ID, double INI, double MARCA, double MARGEN1, double MARGEN2, double MARGEN3, double MAX, double MIN, double MODO_PRE, double PRECIO, double PRECIO1, double PRECIO2, double PRECIO3, double PROMEDIO, double SAL, double ULTIMO, DateTime ULT_COMPRA, DateTime ULT_VENTA, double UNIDAD, string UNIDADC, double UNIDADE, string UNIDADV, double UNIDADVC)
        {
            mBARRA = BARRA;
            mBASE_MARGE = BASE_MARGE;
            mCAL_UTI = CAL_UTI;
            mCAMBIO = CAMBIO;
            mCODIGO = CODIGO;
            mCODIGOP = CODIGOP;
            mDESCR = DESCR;
            mENT = ENT;
            mEXIS = EXIS;
            mFECHA_M = FECHA_M;
            mFECHA_R = FECHA_R;
            mID = ID;
            mINI = INI;
            mMARCA = MARCA;
            mMARGEN1 = MARGEN1;
            mMARGEN2 = MARGEN2;
            mMARGEN3 = MARGEN3;
            mMAX = MAX;
            mMIN = MIN;
            mMODO_PRE = MODO_PRE;
            mPRECIO = PRECIO;
            mPRECIO1 = PRECIO1;
            mPRECIO2 = PRECIO2;
            mPRECIO3 = PRECIO3;
            mPROMEDIO = PROMEDIO;
            mSAL = SAL;
            mULTIMO = ULTIMO;
            mULT_COMPRA = ULT_COMPRA;
            mULT_VENTA = ULT_VENTA;
            mUNIDAD = UNIDAD;
            mUNIDADC = UNIDADC;
            mUNIDADE = UNIDADE;
            mUNIDADV = UNIDADV;
            mUNIDADVC = UNIDADVC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
