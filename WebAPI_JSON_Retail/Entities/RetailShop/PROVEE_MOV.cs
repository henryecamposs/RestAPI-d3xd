using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PROVEE_MOV : ICloneable
    {

        private double mABONO = 0.0;
        private double mABONOINI = 0.0;
        private string mCAJA = "";
        private string mCAJAREFE = "";
        private double mDIAS = 0.0;
        private string mEMPLE = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAREFE = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_DOCU = 0;
        private int mID_REFE = 0;
        private double mMONREFE = 0.0;
        private double mMONTO = 0.0;
        private double mNRO = 0.0;
        private string mNROC = "";
        private string mNROC_REFE = "";
        private double mNRO_REFE = 0.0;
        private int mPROVEE = 0;
        private double mTIPO = 0.0;
        private double mTIPOREFE = 0.0;

        public Double ABONO
        {
            get
            {
                return mABONO;
            }
            set
            {
                mABONO = value;
            }
        }

        public Double ABONOINI
        {
            get
            {
                return mABONOINI;
            }
            set
            {
                mABONOINI = value;
            }
        }

        public string CAJA
        {
            get
            {
                return mCAJA;
            }
            set
            {
                mCAJA = value;
            }
        }

        public string CAJAREFE
        {
            get
            {
                return mCAJAREFE;
            }
            set
            {
                mCAJAREFE = value;
            }
        }

        public Double DIAS
        {
            get
            {
                return mDIAS;
            }
            set
            {
                mDIAS = value;
            }
        }

        public string EMPLE
        {
            get
            {
                return mEMPLE;
            }
            set
            {
                mEMPLE = value;
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

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
            }
        }

        public DateTime FECHAREFE
        {
            get
            {
                return mFECHAREFE;
            }
            set
            {
                mFECHAREFE = value;
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

        public int ID_DOCU
        {
            get
            {
                return mID_DOCU;
            }
            set
            {
                mID_DOCU = value;
            }
        }

        public int ID_REFE
        {
            get
            {
                return mID_REFE;
            }
            set
            {
                mID_REFE = value;
            }
        }

        public Double MONREFE
        {
            get
            {
                return mMONREFE;
            }
            set
            {
                mMONREFE = value;
            }
        }

        public Double MONTO
        {
            get
            {
                return mMONTO;
            }
            set
            {
                mMONTO = value;
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

        public string NROC
        {
            get
            {
                return mNROC;
            }
            set
            {
                mNROC = value;
            }
        }

        public string NROC_REFE
        {
            get
            {
                return mNROC_REFE;
            }
            set
            {
                mNROC_REFE = value;
            }
        }

        public Double NRO_REFE
        {
            get
            {
                return mNRO_REFE;
            }
            set
            {
                mNRO_REFE = value;
            }
        }

        public int PROVEE
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

        public Double TIPOREFE
        {
            get
            {
                return mTIPOREFE;
            }
            set
            {
                mTIPOREFE = value;
            }
        }

        PROVEE_MOV()
        {
        }

        PROVEE_MOV(double ABONO, double ABONOINI, string CAJA, string CAJAREFE, double DIAS, string EMPLE, DateTime FECHA, string FECHAC, DateTime FECHAREFE, int ID, int IDSUC, int ID_DOCU, int ID_REFE, double MONREFE, double MONTO, double NRO, string NROC, string NROC_REFE, double NRO_REFE, int PROVEE, double TIPO, double TIPOREFE)
        {
            mABONO = ABONO;
            mABONOINI = ABONOINI;
            mCAJA = CAJA;
            mCAJAREFE = CAJAREFE;
            mDIAS = DIAS;
            mEMPLE = EMPLE;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAREFE = FECHAREFE;
            mID = ID;
            mIDSUC = IDSUC;
            mID_DOCU = ID_DOCU;
            mID_REFE = ID_REFE;
            mMONREFE = MONREFE;
            mMONTO = MONTO;
            mNRO = NRO;
            mNROC = NROC;
            mNROC_REFE = NROC_REFE;
            mNRO_REFE = NRO_REFE;
            mPROVEE = PROVEE;
            mTIPO = TIPO;
            mTIPOREFE = TIPOREFE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
