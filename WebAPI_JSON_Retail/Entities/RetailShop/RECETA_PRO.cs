using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RECETA_PRO : ICloneable
    {

        private double mCANTI = 0.0;
        private string mCODIGO = "";
        private string mCODIGO_C = "";
        private double mCOSTO = 0.0;
        private double mCOSTOU = 0.0;
        private string mDESCR = "";
        private string mDUNIDAD = "";
        private double mFACTURA = 0.0;
        private int mID = 0;
        private int mIDSUC = 0;
        private double mMODULO = 0.0;
        private double mPORCP = 0.0;
        private double mPORCU = 0.0;
        private double mPRECIO = 0.0;
        private double mTIPO = 0.0;
        private string mUNIDAD = "";

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
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

        public string CODIGO_C
        {
            get
            {
                return mCODIGO_C;
            }
            set
            {
                mCODIGO_C = value;
            }
        }

        public Double COSTO
        {
            get
            {
                return mCOSTO;
            }
            set
            {
                mCOSTO = value;
            }
        }

        public Double COSTOU
        {
            get
            {
                return mCOSTOU;
            }
            set
            {
                mCOSTOU = value;
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

        public string DUNIDAD
        {
            get
            {
                return mDUNIDAD;
            }
            set
            {
                mDUNIDAD = value;
            }
        }

        public Double FACTURA
        {
            get
            {
                return mFACTURA;
            }
            set
            {
                mFACTURA = value;
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

        public Double MODULO
        {
            get
            {
                return mMODULO;
            }
            set
            {
                mMODULO = value;
            }
        }

        public Double PORCP
        {
            get
            {
                return mPORCP;
            }
            set
            {
                mPORCP = value;
            }
        }

        public Double PORCU
        {
            get
            {
                return mPORCU;
            }
            set
            {
                mPORCU = value;
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

        public string UNIDAD
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

        RECETA_PRO()
        {
        }

        RECETA_PRO(double CANTI, string CODIGO, string CODIGO_C, double COSTO, double COSTOU, string DESCR, string DUNIDAD, double FACTURA, int ID, int IDSUC, double MODULO, double PORCP, double PORCU, double PRECIO, double TIPO, string UNIDAD)
        {
            mCANTI = CANTI;
            mCODIGO = CODIGO;
            mCODIGO_C = CODIGO_C;
            mCOSTO = COSTO;
            mCOSTOU = COSTOU;
            mDESCR = DESCR;
            mDUNIDAD = DUNIDAD;
            mFACTURA = FACTURA;
            mID = ID;
            mIDSUC = IDSUC;
            mMODULO = MODULO;
            mPORCP = PORCP;
            mPORCU = PORCU;
            mPRECIO = PRECIO;
            mTIPO = TIPO;
            mUNIDAD = UNIDAD;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
