using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CONFBALANZA : ICloneable
    {

        private double mCAMPO1F = 0.0;
        private double mCAMPO1I = 0.0;
        private string mCAMPO1V = "";
        private string mCODIGO = "";
        private string mDESCR = "";
        private string mDIASCON = "";
        private double mDIASCONF = 0.0;
        private double mDIASCONI = 0.0;
        private string mDIR = "";
        private double mECO1F = 0.0;
        private double mECO1I = 0.0;
        private string mECO1VAL = "";
        private string mFILEDEST = "";
        private int mID = 0;
        private double mNOM_PROF = 0.0;
        private double mNOM_PROI = 0.0;
        private double mPLUF = 0.0;
        private double mPLUI = 0.0;
        private double mPRECIO1F = 0.0;
        private double mPRECIOI = 0.0;
        private string mPROG1 = "";
        private string mPROG2 = "";
        private string mPROG3 = "";
        private string mPROG4 = "";
        private string mPROG5 = "";
        private double mREEMPREF = 0.0;
        private double mREEMPREI = 0.0;
        private double mSUBDPTOF = 0.0;
        private double mSUBDPTOI = 0.0;
        private string mSUBFA = "";
        private double mSUBFAMF = 0.0;
        private double mSUBFAMI = 0.0;
        private double mTESPERA = 0.0;
        private double mTIPENV = 0.0;
        private double mTIPENVF = 0.0;
        private double mTIVAF = 0.0;
        private double mTIVAI = 0.0;
        private double mTPESOF = 0.0;
        private double mTPESOI = 0.0;
        private double mTPLUF = 0.0;
        private double mTPLUI = 0.0;

        public Double CAMPO1F
        {
            get
            {
                return mCAMPO1F;
            }
            set
            {
                mCAMPO1F = value;
            }
        }

        public Double CAMPO1I
        {
            get
            {
                return mCAMPO1I;
            }
            set
            {
                mCAMPO1I = value;
            }
        }

        public string CAMPO1V
        {
            get
            {
                return mCAMPO1V;
            }
            set
            {
                mCAMPO1V = value;
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

        public string DIASCON
        {
            get
            {
                return mDIASCON;
            }
            set
            {
                mDIASCON = value;
            }
        }

        public Double DIASCONF
        {
            get
            {
                return mDIASCONF;
            }
            set
            {
                mDIASCONF = value;
            }
        }

        public Double DIASCONI
        {
            get
            {
                return mDIASCONI;
            }
            set
            {
                mDIASCONI = value;
            }
        }

        public string DIR
        {
            get
            {
                return mDIR;
            }
            set
            {
                mDIR = value;
            }
        }

        public Double ECO1F
        {
            get
            {
                return mECO1F;
            }
            set
            {
                mECO1F = value;
            }
        }

        public Double ECO1I
        {
            get
            {
                return mECO1I;
            }
            set
            {
                mECO1I = value;
            }
        }

        public string ECO1VAL
        {
            get
            {
                return mECO1VAL;
            }
            set
            {
                mECO1VAL = value;
            }
        }

        public string FILEDEST
        {
            get
            {
                return mFILEDEST;
            }
            set
            {
                mFILEDEST = value;
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

        public Double NOM_PROF
        {
            get
            {
                return mNOM_PROF;
            }
            set
            {
                mNOM_PROF = value;
            }
        }

        public Double NOM_PROI
        {
            get
            {
                return mNOM_PROI;
            }
            set
            {
                mNOM_PROI = value;
            }
        }

        public Double PLUF
        {
            get
            {
                return mPLUF;
            }
            set
            {
                mPLUF = value;
            }
        }

        public Double PLUI
        {
            get
            {
                return mPLUI;
            }
            set
            {
                mPLUI = value;
            }
        }

        public Double PRECIO1F
        {
            get
            {
                return mPRECIO1F;
            }
            set
            {
                mPRECIO1F = value;
            }
        }

        public Double PRECIOI
        {
            get
            {
                return mPRECIOI;
            }
            set
            {
                mPRECIOI = value;
            }
        }

        public string PROG1
        {
            get
            {
                return mPROG1;
            }
            set
            {
                mPROG1 = value;
            }
        }

        public string PROG2
        {
            get
            {
                return mPROG2;
            }
            set
            {
                mPROG2 = value;
            }
        }

        public string PROG3
        {
            get
            {
                return mPROG3;
            }
            set
            {
                mPROG3 = value;
            }
        }

        public string PROG4
        {
            get
            {
                return mPROG4;
            }
            set
            {
                mPROG4 = value;
            }
        }

        public string PROG5
        {
            get
            {
                return mPROG5;
            }
            set
            {
                mPROG5 = value;
            }
        }

        public Double REEMPREF
        {
            get
            {
                return mREEMPREF;
            }
            set
            {
                mREEMPREF = value;
            }
        }

        public Double REEMPREI
        {
            get
            {
                return mREEMPREI;
            }
            set
            {
                mREEMPREI = value;
            }
        }

        public Double SUBDPTOF
        {
            get
            {
                return mSUBDPTOF;
            }
            set
            {
                mSUBDPTOF = value;
            }
        }

        public Double SUBDPTOI
        {
            get
            {
                return mSUBDPTOI;
            }
            set
            {
                mSUBDPTOI = value;
            }
        }

        public string SUBFA
        {
            get
            {
                return mSUBFA;
            }
            set
            {
                mSUBFA = value;
            }
        }

        public Double SUBFAMF
        {
            get
            {
                return mSUBFAMF;
            }
            set
            {
                mSUBFAMF = value;
            }
        }

        public Double SUBFAMI
        {
            get
            {
                return mSUBFAMI;
            }
            set
            {
                mSUBFAMI = value;
            }
        }

        public Double TESPERA
        {
            get
            {
                return mTESPERA;
            }
            set
            {
                mTESPERA = value;
            }
        }

        public Double TIPENV
        {
            get
            {
                return mTIPENV;
            }
            set
            {
                mTIPENV = value;
            }
        }

        public Double TIPENVF
        {
            get
            {
                return mTIPENVF;
            }
            set
            {
                mTIPENVF = value;
            }
        }

        public Double TIVAF
        {
            get
            {
                return mTIVAF;
            }
            set
            {
                mTIVAF = value;
            }
        }

        public Double TIVAI
        {
            get
            {
                return mTIVAI;
            }
            set
            {
                mTIVAI = value;
            }
        }

        public Double TPESOF
        {
            get
            {
                return mTPESOF;
            }
            set
            {
                mTPESOF = value;
            }
        }

        public Double TPESOI
        {
            get
            {
                return mTPESOI;
            }
            set
            {
                mTPESOI = value;
            }
        }

        public Double TPLUF
        {
            get
            {
                return mTPLUF;
            }
            set
            {
                mTPLUF = value;
            }
        }

        public Double TPLUI
        {
            get
            {
                return mTPLUI;
            }
            set
            {
                mTPLUI = value;
            }
        }

        CONFBALANZA()
        {
        }

        CONFBALANZA(double CAMPO1F, double CAMPO1I, string CAMPO1V, string CODIGO, string DESCR, string DIASCON, double DIASCONF, double DIASCONI, string DIR, double ECO1F, double ECO1I, string ECO1VAL, string FILEDEST, int ID, double NOM_PROF, double NOM_PROI, double PLUF, double PLUI, double PRECIO1F, double PRECIOI, string PROG1, string PROG2, string PROG3, string PROG4, string PROG5, double REEMPREF, double REEMPREI, double SUBDPTOF, double SUBDPTOI, string SUBFA, double SUBFAMF, double SUBFAMI, double TESPERA, double TIPENV, double TIPENVF, double TIVAF, double TIVAI, double TPESOF, double TPESOI, double TPLUF, double TPLUI)
        {
            mCAMPO1F = CAMPO1F;
            mCAMPO1I = CAMPO1I;
            mCAMPO1V = CAMPO1V;
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDIASCON = DIASCON;
            mDIASCONF = DIASCONF;
            mDIASCONI = DIASCONI;
            mDIR = DIR;
            mECO1F = ECO1F;
            mECO1I = ECO1I;
            mECO1VAL = ECO1VAL;
            mFILEDEST = FILEDEST;
            mID = ID;
            mNOM_PROF = NOM_PROF;
            mNOM_PROI = NOM_PROI;
            mPLUF = PLUF;
            mPLUI = PLUI;
            mPRECIO1F = PRECIO1F;
            mPRECIOI = PRECIOI;
            mPROG1 = PROG1;
            mPROG2 = PROG2;
            mPROG3 = PROG3;
            mPROG4 = PROG4;
            mPROG5 = PROG5;
            mREEMPREF = REEMPREF;
            mREEMPREI = REEMPREI;
            mSUBDPTOF = SUBDPTOF;
            mSUBDPTOI = SUBDPTOI;
            mSUBFA = SUBFA;
            mSUBFAMF = SUBFAMF;
            mSUBFAMI = SUBFAMI;
            mTESPERA = TESPERA;
            mTIPENV = TIPENV;
            mTIPENVF = TIPENVF;
            mTIVAF = TIVAF;
            mTIVAI = TIVAI;
            mTPESOF = TPESOF;
            mTPESOI = TPESOI;
            mTPLUF = TPLUF;
            mTPLUI = TPLUI;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
