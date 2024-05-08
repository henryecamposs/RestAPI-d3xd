using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAS : ICloneable
    {

        private string mACCOUNT_INT = "";
        private string mACTIVO = "";
        private double mALERET = 0.0;
        private string mARTICULOS = "";
        private double mBLOQUEAR = 0.0;
        private string mCLAVE = "";
        private string mCODIGO = "";
        private string mDNCSAPB1 = "";
        private string mDPTO = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private DateTime mFECHAANT = new DateTime(2000, 01, 01);
        private string mHORA = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private string mLNCSAPB1 = "";
        private double mMONTOI = 0.0;
        private string mNOMBRE = "";
        private double mNRO = 0.0;
        private double mPROY_E = 0.0;
        private double mPROY_VENTA = 0.0;
        private string mSALIDA = "";
        private string mSERIE = "";
        private string mS_D_SAPB1 = "";
        private string mS_L_SAPB1 = "";

        public string ACCOUNT_INT
        {
            get
            {
                return mACCOUNT_INT;
            }
            set
            {
                mACCOUNT_INT = value;
            }
        }

        public string ACTIVO
        {
            get
            {
                return mACTIVO;
            }
            set
            {
                mACTIVO = value;
            }
        }

        public Double ALERET
        {
            get
            {
                return mALERET;
            }
            set
            {
                mALERET = value;
            }
        }

        public string ARTICULOS
        {
            get
            {
                return mARTICULOS;
            }
            set
            {
                mARTICULOS = value;
            }
        }

        public Double BLOQUEAR
        {
            get
            {
                return mBLOQUEAR;
            }
            set
            {
                mBLOQUEAR = value;
            }
        }

        public string CLAVE
        {
            get
            {
                return mCLAVE;
            }
            set
            {
                mCLAVE = value;
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

        public string DNCSAPB1
        {
            get
            {
                return mDNCSAPB1;
            }
            set
            {
                mDNCSAPB1 = value;
            }
        }

        public string DPTO
        {
            get
            {
                return mDPTO;
            }
            set
            {
                mDPTO = value;
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

        public DateTime FECHAANT
        {
            get
            {
                return mFECHAANT;
            }
            set
            {
                mFECHAANT = value;
            }
        }

        public string HORA
        {
            get
            {
                return mHORA;
            }
            set
            {
                mHORA = value;
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

        public string LNCSAPB1
        {
            get
            {
                return mLNCSAPB1;
            }
            set
            {
                mLNCSAPB1 = value;
            }
        }

        public Double MONTOI
        {
            get
            {
                return mMONTOI;
            }
            set
            {
                mMONTOI = value;
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

        public Double NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        public Double PROY_E
        {
            get
            {
                return mPROY_E;
            }
            set
            {
                mPROY_E = value;
            }
        }

        public Double PROY_VENTA
        {
            get
            {
                return mPROY_VENTA;
            }
            set
            {
                mPROY_VENTA = value;
            }
        }

        public string SALIDA
        {
            get
            {
                return mSALIDA;
            }
            set
            {
                mSALIDA = value;
            }
        }

        public string SERIE
        {
            get
            {
                return mSERIE;
            }
            set
            {
                mSERIE = value;
            }
        }

        public string S_D_SAPB1
        {
            get
            {
                return mS_D_SAPB1;
            }
            set
            {
                mS_D_SAPB1 = value;
            }
        }

        public string S_L_SAPB1
        {
            get
            {
                return mS_L_SAPB1;
            }
            set
            {
                mS_L_SAPB1 = value;
            }
        }

        CAJAS()
        {
        }

        CAJAS(string ACCOUNT_INT, string ACTIVO, double ALERET, string ARTICULOS, double BLOQUEAR, string CLAVE, string CODIGO, string DNCSAPB1, string DPTO, DateTime FECHA, DateTime FECHAANT, string HORA, int ID, int IDSUC, double INACTIVO, string LNCSAPB1, double MONTOI, string NOMBRE, double NRO, double PROY_E, double PROY_VENTA, string SALIDA, string SERIE, string S_D_SAPB1, string S_L_SAPB1)
        {
            mACCOUNT_INT = ACCOUNT_INT;
            mACTIVO = ACTIVO;
            mALERET = ALERET;
            mARTICULOS = ARTICULOS;
            mBLOQUEAR = BLOQUEAR;
            mCLAVE = CLAVE;
            mCODIGO = CODIGO;
            mDNCSAPB1 = DNCSAPB1;
            mDPTO = DPTO;
            mFECHA = FECHA;
            mFECHAANT = FECHAANT;
            mHORA = HORA;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mLNCSAPB1 = LNCSAPB1;
            mMONTOI = MONTOI;
            mNOMBRE = NOMBRE;
            mNRO = NRO;
            mPROY_E = PROY_E;
            mPROY_VENTA = PROY_VENTA;
            mSALIDA = SALIDA;
            mSERIE = SERIE;
            mS_D_SAPB1 = S_D_SAPB1;
            mS_L_SAPB1 = S_L_SAPB1;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
