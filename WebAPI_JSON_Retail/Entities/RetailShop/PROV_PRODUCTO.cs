using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROV_PRODUCTO : ICloneable
    {

        private string mBARRA = "";
        private double mBASE_MARGE = 0.0;
        private double mCAL_UTI = 0.0;
        private string mCAMBIO = "";
        private double mCANTIDAD = 0.0;
        private string mCODIGOP = "";
        private double mDESCUENTO = 0.0;
        private double mDOCU = 0.0;
        private double mENT = 0.0;
        private double mEXIS = 0.0;
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
        private string mNOMBRE = "";
        private double mPAQUETE = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO3 = 0.0;
        private double mPROMEDIO = 0.0;
        private string mPROVEE = "";
        private double mSAL = 0.0;
        private string mTDOCU = "";
        private double mULTIMO = 0.0;
        private DateTime mULT_COMPRA = new DateTime(2000, 01, 01);
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

        public Double CANTIDAD
        {
            get
            {
                return mCANTIDAD;
            }
            set
            {
                mCANTIDAD = value;
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

        public Double DESCUENTO
        {
            get
            {
                return mDESCUENTO;
            }
            set
            {
                mDESCUENTO = value;
            }
        }

        public Double DOCU
        {
            get
            {
                return mDOCU;
            }
            set
            {
                mDOCU = value;
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

        public Double PAQUETE
        {
            get
            {
                return mPAQUETE;
            }
            set
            {
                mPAQUETE = value;
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

        public string PROVEE
        {
            get
            {
                return mPROVEE;
            }
            set
            {
                mPROVEE = value;
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

        public string TDOCU
        {
            get
            {
                return mTDOCU;
            }
            set
            {
                mTDOCU = value;
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

        PROV_PRODUCTO()
        {
        }

        PROV_PRODUCTO(string BARRA, double BASE_MARGE, double CAL_UTI, string CAMBIO, double CANTIDAD, string CODIGOP, double DESCUENTO, double DOCU, double ENT, double EXIS, DateTime FECHA_R, int ID, double INI, double MARCA, double MARGEN1, double MARGEN2, double MARGEN3, double MAX, double MIN, double MODO_PRE, string NOMBRE, double PAQUETE, double PRECIO1, double PRECIO2, double PRECIO3, double PROMEDIO, string PROVEE, double SAL, string TDOCU, double ULTIMO, DateTime ULT_COMPRA, double UNIDAD, string UNIDADC, double UNIDADE, string UNIDADV, double UNIDADVC)
        {
            mBARRA = BARRA;
            mBASE_MARGE = BASE_MARGE;
            mCAL_UTI = CAL_UTI;
            mCAMBIO = CAMBIO;
            mCANTIDAD = CANTIDAD;
            mCODIGOP = CODIGOP;
            mDESCUENTO = DESCUENTO;
            mDOCU = DOCU;
            mENT = ENT;
            mEXIS = EXIS;
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
            mNOMBRE = NOMBRE;
            mPAQUETE = PAQUETE;
            mPRECIO1 = PRECIO1;
            mPRECIO2 = PRECIO2;
            mPRECIO3 = PRECIO3;
            mPROMEDIO = PROMEDIO;
            mPROVEE = PROVEE;
            mSAL = SAL;
            mTDOCU = TDOCU;
            mULTIMO = ULTIMO;
            mULT_COMPRA = ULT_COMPRA;
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
