using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TABULADOR_PRECIOS : ICloneable
    {

        private double mCANTI = 0.0;
        private double mCANT_EMP = 0.0;
        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mTIPOE = 0.0;
        private double mTIPOP = 0.0;
        private double mTIPOT = 0.0;
        private double mTODOSP = 0.0;

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

        public Double CANT_EMP
        {
            get
            {
                return mCANT_EMP;
            }
            set
            {
                mCANT_EMP = value;
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

        public Double TIPOE
        {
            get
            {
                return mTIPOE;
            }
            set
            {
                mTIPOE = value;
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

        public Double TIPOT
        {
            get
            {
                return mTIPOT;
            }
            set
            {
                mTIPOT = value;
            }
        }

        public Double TODOSP
        {
            get
            {
                return mTODOSP;
            }
            set
            {
                mTODOSP = value;
            }
        }

        TABULADOR_PRECIOS()
        {
        }

        TABULADOR_PRECIOS(double CANTI, double CANT_EMP, string DESCR, int ID, int IDSUC, double TIPOE, double TIPOP, double TIPOT, double TODOSP)
        {
            mCANTI = CANTI;
            mCANT_EMP = CANT_EMP;
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mTIPOE = TIPOE;
            mTIPOP = TIPOP;
            mTIPOT = TIPOT;
            mTODOSP = TODOSP;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
