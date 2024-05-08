using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class AUTORIZA : ICloneable
    {

        private string mACCION = "";
        private string mDOPCION = "";
        private string mEMPLEA = "";
        private string mEMPLEO = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private string mHORA = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mNIVEL = 0.0;
        private string mNOMEMPA = "";
        private string mNOMEMPO = "";
        private double mOPCION = 0.0;

        public string ACCION
        {
            get
            {
                return mACCION;
            }
            set
            {
                mACCION = value;
            }
        }

        public string DOPCION
        {
            get
            {
                return mDOPCION;
            }
            set
            {
                mDOPCION = value;
            }
        }

        public string EMPLEA
        {
            get
            {
                return mEMPLEA;
            }
            set
            {
                mEMPLEA = value;
            }
        }

        public string EMPLEO
        {
            get
            {
                return mEMPLEO;
            }
            set
            {
                mEMPLEO = value;
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

        public Double NIVEL
        {
            get
            {
                return mNIVEL;
            }
            set
            {
                mNIVEL = value;
            }
        }

        public string NOMEMPA
        {
            get
            {
                return mNOMEMPA;
            }
            set
            {
                mNOMEMPA = value;
            }
        }

        public string NOMEMPO
        {
            get
            {
                return mNOMEMPO;
            }
            set
            {
                mNOMEMPO = value;
            }
        }

        public Double OPCION
        {
            get
            {
                return mOPCION;
            }
            set
            {
                mOPCION = value;
            }
        }

        AUTORIZA()
        {
        }

        AUTORIZA(string ACCION, string DOPCION, string EMPLEA, string EMPLEO, DateTime FECHA, string FECHAC, string HORA, int ID, int IDSUC, double NIVEL, string NOMEMPA, string NOMEMPO, double OPCION)
        {
            mACCION = ACCION;
            mDOPCION = DOPCION;
            mEMPLEA = EMPLEA;
            mEMPLEO = EMPLEO;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mHORA = HORA;
            mID = ID;
            mIDSUC = IDSUC;
            mNIVEL = NIVEL;
            mNOMEMPA = NOMEMPA;
            mNOMEMPO = NOMEMPO;
            mOPCION = OPCION;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
