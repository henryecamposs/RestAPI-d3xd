using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CODINTER : ICloneable
    {

        private double mBCAJAS = 0.0;
        private double mCANTIDAD = 0.0;
        private string mCODIGOP = "";
        private string mCOD_INT = "";
        private double mDESCU1 = 0.0;
        private double mDESCU2 = 0.0;
        private double mDESCU3 = 0.0;
        private double mDESCU4 = 0.0;
        private double mDESCU5 = 0.0;
        private double mDESCUENTO = 0.0;
        private double mDOCU = 0.0;
        private DateTime mFECHA_R = new DateTime(2000, 01, 01);
        private int mID = 0;
        private double mIMPLICOR = 0.0;
        private double mMARGENC = 0.0;
        private double mMARGENU = 0.0;
        private double mPCAJAS = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO3 = 0.0;
        private double mPRECIOSU = 0.0;
        private double mPROMEDIO = 0.0;
        private string mPROVEE = "";
        private string mTDOCU = "";
        private double mULTIMO = 0.0;
        private DateTime mULT_COMPRA = new DateTime(2000, 01, 01);
        private double mUNIDAD = 0.0;
        private double mUNIDADE = 0.0;

        public Double BCAJAS
        {
            get
            {
                return mBCAJAS;
            }
            set
            {
                mBCAJAS = value;
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

        public string COD_INT
        {
            get
            {
                return mCOD_INT;
            }
            set
            {
                mCOD_INT = value;
            }
        }

        public Double DESCU1
        {
            get
            {
                return mDESCU1;
            }
            set
            {
                mDESCU1 = value;
            }
        }

        public Double DESCU2
        {
            get
            {
                return mDESCU2;
            }
            set
            {
                mDESCU2 = value;
            }
        }

        public Double DESCU3
        {
            get
            {
                return mDESCU3;
            }
            set
            {
                mDESCU3 = value;
            }
        }

        public Double DESCU4
        {
            get
            {
                return mDESCU4;
            }
            set
            {
                mDESCU4 = value;
            }
        }

        public Double DESCU5
        {
            get
            {
                return mDESCU5;
            }
            set
            {
                mDESCU5 = value;
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

        public Double IMPLICOR
        {
            get
            {
                return mIMPLICOR;
            }
            set
            {
                mIMPLICOR = value;
            }
        }

        public Double MARGENC
        {
            get
            {
                return mMARGENC;
            }
            set
            {
                mMARGENC = value;
            }
        }

        public Double MARGENU
        {
            get
            {
                return mMARGENU;
            }
            set
            {
                mMARGENU = value;
            }
        }

        public Double PCAJAS
        {
            get
            {
                return mPCAJAS;
            }
            set
            {
                mPCAJAS = value;
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

        public Double PRECIOSU
        {
            get
            {
                return mPRECIOSU;
            }
            set
            {
                mPRECIOSU = value;
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

        CODINTER()
        {
        }

        CODINTER(double BCAJAS, double CANTIDAD, string CODIGOP, string COD_INT, double DESCU1, double DESCU2, double DESCU3, double DESCU4, double DESCU5, double DESCUENTO, double DOCU, DateTime FECHA_R, int ID, double IMPLICOR, double MARGENC, double MARGENU, double PCAJAS, double PRECIO1, double PRECIO2, double PRECIO3, double PRECIOSU, double PROMEDIO, string PROVEE, string TDOCU, double ULTIMO, DateTime ULT_COMPRA, double UNIDAD, double UNIDADE)
        {
            mBCAJAS = BCAJAS;
            mCANTIDAD = CANTIDAD;
            mCODIGOP = CODIGOP;
            mCOD_INT = COD_INT;
            mDESCU1 = DESCU1;
            mDESCU2 = DESCU2;
            mDESCU3 = DESCU3;
            mDESCU4 = DESCU4;
            mDESCU5 = DESCU5;
            mDESCUENTO = DESCUENTO;
            mDOCU = DOCU;
            mFECHA_R = FECHA_R;
            mID = ID;
            mIMPLICOR = IMPLICOR;
            mMARGENC = MARGENC;
            mMARGENU = MARGENU;
            mPCAJAS = PCAJAS;
            mPRECIO1 = PRECIO1;
            mPRECIO2 = PRECIO2;
            mPRECIO3 = PRECIO3;
            mPRECIOSU = PRECIOSU;
            mPROMEDIO = PROMEDIO;
            mPROVEE = PROVEE;
            mTDOCU = TDOCU;
            mULTIMO = ULTIMO;
            mULT_COMPRA = ULT_COMPRA;
            mUNIDAD = UNIDAD;
            mUNIDADE = UNIDADE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
