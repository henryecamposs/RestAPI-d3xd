using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONFIESCANER : ICloneable
    {

        private double mCANTADID = 0.0;
        private double mCANTADIH = 0.0;
        private string mCODIGO = "";
        private string mDELIMITADO = "";
        private string mDESCR = "";
        private double mFECHATD = 0.0;
        private double mFECHATH = 0.0;
        private double mHORATD = 0.0;
        private double mHORATH = 0.0;
        private int mID = 0;
        private string mIDENCA = "";
        private string mIDITEM = "";
        private string mIDTOTAL = "";
        private double mLONGLINE = 0.0;
        private double mNTRD = 0.0;
        private double mNTRH = 0.0;
        private double mPOSCANTI = 0.0;
        private double mPOSCANTIF = 0.0;
        private double mPOSCODIGO = 0.0;
        private double mPOSCODIGOF = 0.0;
        private double mPOSDECCAN = 0.0;
        private double mPOSDECMON = 0.0;
        private double mPOSMONTO = 0.0;
        private double mPOSMONTOF = 0.0;
        private double mPOSUMTD = 0.0;
        private double mPOSUMTH = 0.0;
        private double mPOSVD = 0.0;
        private double mPOSVDF = 0.0;
        private double mQUITACERO = 0.0;
        private double mTIPOLD = 0.0;
        private double mTIPOLH = 0.0;

        public Double CANTADID
        {
            get
            {
                return mCANTADID;
            }
            set
            {
                mCANTADID = value;
            }
        }

        public Double CANTADIH
        {
            get
            {
                return mCANTADIH;
            }
            set
            {
                mCANTADIH = value;
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

        public string DELIMITADO
        {
            get
            {
                return mDELIMITADO;
            }
            set
            {
                mDELIMITADO = value;
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

        public Double FECHATD
        {
            get
            {
                return mFECHATD;
            }
            set
            {
                mFECHATD = value;
            }
        }

        public Double FECHATH
        {
            get
            {
                return mFECHATH;
            }
            set
            {
                mFECHATH = value;
            }
        }

        public Double HORATD
        {
            get
            {
                return mHORATD;
            }
            set
            {
                mHORATD = value;
            }
        }

        public Double HORATH
        {
            get
            {
                return mHORATH;
            }
            set
            {
                mHORATH = value;
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

        public string IDENCA
        {
            get
            {
                return mIDENCA;
            }
            set
            {
                mIDENCA = value;
            }
        }

        public string IDITEM
        {
            get
            {
                return mIDITEM;
            }
            set
            {
                mIDITEM = value;
            }
        }

        public string IDTOTAL
        {
            get
            {
                return mIDTOTAL;
            }
            set
            {
                mIDTOTAL = value;
            }
        }

        public Double LONGLINE
        {
            get
            {
                return mLONGLINE;
            }
            set
            {
                mLONGLINE = value;
            }
        }

        public Double NTRD
        {
            get
            {
                return mNTRD;
            }
            set
            {
                mNTRD = value;
            }
        }

        public Double NTRH
        {
            get
            {
                return mNTRH;
            }
            set
            {
                mNTRH = value;
            }
        }

        public Double POSCANTI
        {
            get
            {
                return mPOSCANTI;
            }
            set
            {
                mPOSCANTI = value;
            }
        }

        public Double POSCANTIF
        {
            get
            {
                return mPOSCANTIF;
            }
            set
            {
                mPOSCANTIF = value;
            }
        }

        public Double POSCODIGO
        {
            get
            {
                return mPOSCODIGO;
            }
            set
            {
                mPOSCODIGO = value;
            }
        }

        public Double POSCODIGOF
        {
            get
            {
                return mPOSCODIGOF;
            }
            set
            {
                mPOSCODIGOF = value;
            }
        }

        public Double POSDECCAN
        {
            get
            {
                return mPOSDECCAN;
            }
            set
            {
                mPOSDECCAN = value;
            }
        }

        public Double POSDECMON
        {
            get
            {
                return mPOSDECMON;
            }
            set
            {
                mPOSDECMON = value;
            }
        }

        public Double POSMONTO
        {
            get
            {
                return mPOSMONTO;
            }
            set
            {
                mPOSMONTO = value;
            }
        }

        public Double POSMONTOF
        {
            get
            {
                return mPOSMONTOF;
            }
            set
            {
                mPOSMONTOF = value;
            }
        }

        public Double POSUMTD
        {
            get
            {
                return mPOSUMTD;
            }
            set
            {
                mPOSUMTD = value;
            }
        }

        public Double POSUMTH
        {
            get
            {
                return mPOSUMTH;
            }
            set
            {
                mPOSUMTH = value;
            }
        }

        public Double POSVD
        {
            get
            {
                return mPOSVD;
            }
            set
            {
                mPOSVD = value;
            }
        }

        public Double POSVDF
        {
            get
            {
                return mPOSVDF;
            }
            set
            {
                mPOSVDF = value;
            }
        }

        public Double QUITACERO
        {
            get
            {
                return mQUITACERO;
            }
            set
            {
                mQUITACERO = value;
            }
        }

        public Double TIPOLD
        {
            get
            {
                return mTIPOLD;
            }
            set
            {
                mTIPOLD = value;
            }
        }

        public Double TIPOLH
        {
            get
            {
                return mTIPOLH;
            }
            set
            {
                mTIPOLH = value;
            }
        }

        CONFIESCANER()
        {
        }

        CONFIESCANER(double CANTADID, double CANTADIH, string CODIGO, string DELIMITADO, string DESCR, double FECHATD, double FECHATH, double HORATD, double HORATH, int ID, string IDENCA, string IDITEM, string IDTOTAL, double LONGLINE, double NTRD, double NTRH, double POSCANTI, double POSCANTIF, double POSCODIGO, double POSCODIGOF, double POSDECCAN, double POSDECMON, double POSMONTO, double POSMONTOF, double POSUMTD, double POSUMTH, double POSVD, double POSVDF, double QUITACERO, double TIPOLD, double TIPOLH)
        {
            mCANTADID = CANTADID;
            mCANTADIH = CANTADIH;
            mCODIGO = CODIGO;
            mDELIMITADO = DELIMITADO;
            mDESCR = DESCR;
            mFECHATD = FECHATD;
            mFECHATH = FECHATH;
            mHORATD = HORATD;
            mHORATH = HORATH;
            mID = ID;
            mIDENCA = IDENCA;
            mIDITEM = IDITEM;
            mIDTOTAL = IDTOTAL;
            mLONGLINE = LONGLINE;
            mNTRD = NTRD;
            mNTRH = NTRH;
            mPOSCANTI = POSCANTI;
            mPOSCANTIF = POSCANTIF;
            mPOSCODIGO = POSCODIGO;
            mPOSCODIGOF = POSCODIGOF;
            mPOSDECCAN = POSDECCAN;
            mPOSDECMON = POSDECMON;
            mPOSMONTO = POSMONTO;
            mPOSMONTOF = POSMONTOF;
            mPOSUMTD = POSUMTD;
            mPOSUMTH = POSUMTH;
            mPOSVD = POSVD;
            mPOSVDF = POSVDF;
            mQUITACERO = QUITACERO;
            mTIPOLD = TIPOLD;
            mTIPOLH = TIPOLH;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
