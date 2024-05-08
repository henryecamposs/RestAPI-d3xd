using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CORTE : ICloneable
    {

        private double mABONOS = 0.0;
        private string mACTUAL = "";
        private double mAPARTADOS = 0.0;
        private double mBASE1 = 0.0;
        private double mBASE1D = 0.0;
        private double mBASE1_C = 0.0;
        private double mBASE1_NC = 0.0;
        private double mBASE2 = 0.0;
        private double mBASE2D = 0.0;
        private double mBASE2_C = 0.0;
        private double mBASE2_NC = 0.0;
        private double mBASE3 = 0.0;
        private double mBASE3D = 0.0;
        private double mBASE3_C = 0.0;
        private double mBASE3_NC = 0.0;
        private string mCAJA = "";
        private double mCONTADO = 0.0;
        private double mDBASE1_C = 0.0;
        private double mDBASE1_NC = 0.0;
        private double mDBASE2_C = 0.0;
        private double mDBASE2_NC = 0.0;
        private double mDBASE3_C = 0.0;
        private double mDBASE3_NC = 0.0;
        private double mDEPOSITO = 0.0;
        private double mDESCU = 0.0;
        private double mDESDE = 0.0;
        private double mDESDEC = 0.0;
        private string mDESDECF = "";
        private double mDESDED = 0.0;
        private double mDEVOLUCION = 0.0;
        private double mDEXENTO_C = 0.0;
        private double mDEXENTO_NC = 0.0;
        private double mDIVA1_C = 0.0;
        private double mDIVA1_NC = 0.0;
        private double mDIVA2_C = 0.0;
        private double mDIVA2_NC = 0.0;
        private double mDIVA3_C = 0.0;
        private double mDIVA3_NC = 0.0;
        private double mENVIO = 0.0;
        private double mERETENCION = 0.0;
        private double mEXENTO = 0.0;
        private double mEXENTOD = 0.0;
        private double mEXENTO_C = 0.0;
        private double mEXENTO_NC = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAF = new DateTime(2000, 01, 01);
        private string mFECHAFC = "";
        private double mGASTOS = 0.0;
        private double mHASTA = 0.0;
        private double mHASTAC = 0.0;
        private string mHASTACF = "";
        private double mHASTAD = 0.0;
        private string mHORAA = "";
        private string mHORAF = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_CONSO = 0;
        private double mIMPTUR = 0.0;
        private double mIVA = 0.0;
        private double mIVA1 = 0.0;
        private double mIVA1D = 0.0;
        private double mIVA1_C = 0.0;
        private double mIVA1_NC = 0.0;
        private double mIVA2 = 0.0;
        private double mIVA2D = 0.0;
        private double mIVA2_C = 0.0;
        private double mIVA2_NC = 0.0;
        private double mIVA3 = 0.0;
        private double mIVA3D = 0.0;
        private double mIVA3_C = 0.0;
        private double mIVA3_NC = 0.0;
        private string mMAQFIS = "";
        private double mMONTO = 0.0;
        private double mMONTO2 = 0.0;
        private double mMONTO3 = 0.0;
        private double mMONTOI = 0.0;
        private double mNRO = 0.0;
        private double mOTRO = 0.0;
        private double mSERVICIO = 0.0;
        private double mTOTAL = 0.0;
        private double mTOTAL2 = 0.0;
        private double mTOTAL3 = 0.0;
        private string mUID = "";
        private string mUID_DEP = "";
        private double mVALE = 0.0;
        private double mZDEXT = 0.0;
        private double mZDIVA1 = 0.0;
        private double mZDIVA2 = 0.0;
        private double mZDIVA3 = 0.0;
        private double mZDVTA1 = 0.0;
        private double mZDVTA2 = 0.0;
        private double mZDVTA3 = 0.0;
        private double mZEXT = 0.0;
        private string mZFISCAL = "";
        private double mZIVA1 = 0.0;
        private double mZIVA2 = 0.0;
        private double mZIVA3 = 0.0;
        private double mZVTA1 = 0.0;
        private double mZVTA2 = 0.0;
        private double mZVTA3 = 0.0;

        public Double ABONOS
        {
            get
            {
                return mABONOS;
            }
            set
            {
                mABONOS = value;
            }
        }

        public string ACTUAL
        {
            get
            {
                return mACTUAL;
            }
            set
            {
                mACTUAL = value;
            }
        }

        public Double APARTADOS
        {
            get
            {
                return mAPARTADOS;
            }
            set
            {
                mAPARTADOS = value;
            }
        }

        public Double BASE1
        {
            get
            {
                return mBASE1;
            }
            set
            {
                mBASE1 = value;
            }
        }

        public Double BASE1D
        {
            get
            {
                return mBASE1D;
            }
            set
            {
                mBASE1D = value;
            }
        }

        public Double BASE1_C
        {
            get
            {
                return mBASE1_C;
            }
            set
            {
                mBASE1_C = value;
            }
        }

        public Double BASE1_NC
        {
            get
            {
                return mBASE1_NC;
            }
            set
            {
                mBASE1_NC = value;
            }
        }

        public Double BASE2
        {
            get
            {
                return mBASE2;
            }
            set
            {
                mBASE2 = value;
            }
        }

        public Double BASE2D
        {
            get
            {
                return mBASE2D;
            }
            set
            {
                mBASE2D = value;
            }
        }

        public Double BASE2_C
        {
            get
            {
                return mBASE2_C;
            }
            set
            {
                mBASE2_C = value;
            }
        }

        public Double BASE2_NC
        {
            get
            {
                return mBASE2_NC;
            }
            set
            {
                mBASE2_NC = value;
            }
        }

        public Double BASE3
        {
            get
            {
                return mBASE3;
            }
            set
            {
                mBASE3 = value;
            }
        }

        public Double BASE3D
        {
            get
            {
                return mBASE3D;
            }
            set
            {
                mBASE3D = value;
            }
        }

        public Double BASE3_C
        {
            get
            {
                return mBASE3_C;
            }
            set
            {
                mBASE3_C = value;
            }
        }

        public Double BASE3_NC
        {
            get
            {
                return mBASE3_NC;
            }
            set
            {
                mBASE3_NC = value;
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

        public Double CONTADO
        {
            get
            {
                return mCONTADO;
            }
            set
            {
                mCONTADO = value;
            }
        }

        public Double DBASE1_C
        {
            get
            {
                return mDBASE1_C;
            }
            set
            {
                mDBASE1_C = value;
            }
        }

        public Double DBASE1_NC
        {
            get
            {
                return mDBASE1_NC;
            }
            set
            {
                mDBASE1_NC = value;
            }
        }

        public Double DBASE2_C
        {
            get
            {
                return mDBASE2_C;
            }
            set
            {
                mDBASE2_C = value;
            }
        }

        public Double DBASE2_NC
        {
            get
            {
                return mDBASE2_NC;
            }
            set
            {
                mDBASE2_NC = value;
            }
        }

        public Double DBASE3_C
        {
            get
            {
                return mDBASE3_C;
            }
            set
            {
                mDBASE3_C = value;
            }
        }

        public Double DBASE3_NC
        {
            get
            {
                return mDBASE3_NC;
            }
            set
            {
                mDBASE3_NC = value;
            }
        }

        public Double DEPOSITO
        {
            get
            {
                return mDEPOSITO;
            }
            set
            {
                mDEPOSITO = value;
            }
        }

        public Double DESCU
        {
            get
            {
                return mDESCU;
            }
            set
            {
                mDESCU = value;
            }
        }

        public Double DESDE
        {
            get
            {
                return mDESDE;
            }
            set
            {
                mDESDE = value;
            }
        }

        public Double DESDEC
        {
            get
            {
                return mDESDEC;
            }
            set
            {
                mDESDEC = value;
            }
        }

        public string DESDECF
        {
            get
            {
                return mDESDECF;
            }
            set
            {
                mDESDECF = value;
            }
        }

        public Double DESDED
        {
            get
            {
                return mDESDED;
            }
            set
            {
                mDESDED = value;
            }
        }

        public Double DEVOLUCION
        {
            get
            {
                return mDEVOLUCION;
            }
            set
            {
                mDEVOLUCION = value;
            }
        }

        public Double DEXENTO_C
        {
            get
            {
                return mDEXENTO_C;
            }
            set
            {
                mDEXENTO_C = value;
            }
        }

        public Double DEXENTO_NC
        {
            get
            {
                return mDEXENTO_NC;
            }
            set
            {
                mDEXENTO_NC = value;
            }
        }

        public Double DIVA1_C
        {
            get
            {
                return mDIVA1_C;
            }
            set
            {
                mDIVA1_C = value;
            }
        }

        public Double DIVA1_NC
        {
            get
            {
                return mDIVA1_NC;
            }
            set
            {
                mDIVA1_NC = value;
            }
        }

        public Double DIVA2_C
        {
            get
            {
                return mDIVA2_C;
            }
            set
            {
                mDIVA2_C = value;
            }
        }

        public Double DIVA2_NC
        {
            get
            {
                return mDIVA2_NC;
            }
            set
            {
                mDIVA2_NC = value;
            }
        }

        public Double DIVA3_C
        {
            get
            {
                return mDIVA3_C;
            }
            set
            {
                mDIVA3_C = value;
            }
        }

        public Double DIVA3_NC
        {
            get
            {
                return mDIVA3_NC;
            }
            set
            {
                mDIVA3_NC = value;
            }
        }

        public Double ENVIO
        {
            get
            {
                return mENVIO;
            }
            set
            {
                mENVIO = value;
            }
        }

        public Double ERETENCION
        {
            get
            {
                return mERETENCION;
            }
            set
            {
                mERETENCION = value;
            }
        }

        public Double EXENTO
        {
            get
            {
                return mEXENTO;
            }
            set
            {
                mEXENTO = value;
            }
        }

        public Double EXENTOD
        {
            get
            {
                return mEXENTOD;
            }
            set
            {
                mEXENTOD = value;
            }
        }

        public Double EXENTO_C
        {
            get
            {
                return mEXENTO_C;
            }
            set
            {
                mEXENTO_C = value;
            }
        }

        public Double EXENTO_NC
        {
            get
            {
                return mEXENTO_NC;
            }
            set
            {
                mEXENTO_NC = value;
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

        public DateTime FECHAF
        {
            get
            {
                return mFECHAF;
            }
            set
            {
                mFECHAF = value;
            }
        }

        public string FECHAFC
        {
            get
            {
                return mFECHAFC;
            }
            set
            {
                mFECHAFC = value;
            }
        }

        public Double GASTOS
        {
            get
            {
                return mGASTOS;
            }
            set
            {
                mGASTOS = value;
            }
        }

        public Double HASTA
        {
            get
            {
                return mHASTA;
            }
            set
            {
                mHASTA = value;
            }
        }

        public Double HASTAC
        {
            get
            {
                return mHASTAC;
            }
            set
            {
                mHASTAC = value;
            }
        }

        public string HASTACF
        {
            get
            {
                return mHASTACF;
            }
            set
            {
                mHASTACF = value;
            }
        }

        public Double HASTAD
        {
            get
            {
                return mHASTAD;
            }
            set
            {
                mHASTAD = value;
            }
        }

        public string HORAA
        {
            get
            {
                return mHORAA;
            }
            set
            {
                mHORAA = value;
            }
        }

        public string HORAF
        {
            get
            {
                return mHORAF;
            }
            set
            {
                mHORAF = value;
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

        public int ID_CONSO
        {
            get
            {
                return mID_CONSO;
            }
            set
            {
                mID_CONSO = value;
            }
        }

        public Double IMPTUR
        {
            get
            {
                return mIMPTUR;
            }
            set
            {
                mIMPTUR = value;
            }
        }

        public Double IVA
        {
            get
            {
                return mIVA;
            }
            set
            {
                mIVA = value;
            }
        }

        public Double IVA1
        {
            get
            {
                return mIVA1;
            }
            set
            {
                mIVA1 = value;
            }
        }

        public Double IVA1D
        {
            get
            {
                return mIVA1D;
            }
            set
            {
                mIVA1D = value;
            }
        }

        public Double IVA1_C
        {
            get
            {
                return mIVA1_C;
            }
            set
            {
                mIVA1_C = value;
            }
        }

        public Double IVA1_NC
        {
            get
            {
                return mIVA1_NC;
            }
            set
            {
                mIVA1_NC = value;
            }
        }

        public Double IVA2
        {
            get
            {
                return mIVA2;
            }
            set
            {
                mIVA2 = value;
            }
        }

        public Double IVA2D
        {
            get
            {
                return mIVA2D;
            }
            set
            {
                mIVA2D = value;
            }
        }

        public Double IVA2_C
        {
            get
            {
                return mIVA2_C;
            }
            set
            {
                mIVA2_C = value;
            }
        }

        public Double IVA2_NC
        {
            get
            {
                return mIVA2_NC;
            }
            set
            {
                mIVA2_NC = value;
            }
        }

        public Double IVA3
        {
            get
            {
                return mIVA3;
            }
            set
            {
                mIVA3 = value;
            }
        }

        public Double IVA3D
        {
            get
            {
                return mIVA3D;
            }
            set
            {
                mIVA3D = value;
            }
        }

        public Double IVA3_C
        {
            get
            {
                return mIVA3_C;
            }
            set
            {
                mIVA3_C = value;
            }
        }

        public Double IVA3_NC
        {
            get
            {
                return mIVA3_NC;
            }
            set
            {
                mIVA3_NC = value;
            }
        }

        public string MAQFIS
        {
            get
            {
                return mMAQFIS;
            }
            set
            {
                mMAQFIS = value;
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

        public Double MONTO2
        {
            get
            {
                return mMONTO2;
            }
            set
            {
                mMONTO2 = value;
            }
        }

        public Double MONTO3
        {
            get
            {
                return mMONTO3;
            }
            set
            {
                mMONTO3 = value;
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

        public Double OTRO
        {
            get
            {
                return mOTRO;
            }
            set
            {
                mOTRO = value;
            }
        }

        public Double SERVICIO
        {
            get
            {
                return mSERVICIO;
            }
            set
            {
                mSERVICIO = value;
            }
        }

        public Double TOTAL
        {
            get
            {
                return mTOTAL;
            }
            set
            {
                mTOTAL = value;
            }
        }

        public Double TOTAL2
        {
            get
            {
                return mTOTAL2;
            }
            set
            {
                mTOTAL2 = value;
            }
        }

        public Double TOTAL3
        {
            get
            {
                return mTOTAL3;
            }
            set
            {
                mTOTAL3 = value;
            }
        }

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
            }
        }

        public string UID_DEP
        {
            get
            {
                return mUID_DEP;
            }
            set
            {
                mUID_DEP = value;
            }
        }

        public Double VALE
        {
            get
            {
                return mVALE;
            }
            set
            {
                mVALE = value;
            }
        }

        public Double ZDEXT
        {
            get
            {
                return mZDEXT;
            }
            set
            {
                mZDEXT = value;
            }
        }

        public Double ZDIVA1
        {
            get
            {
                return mZDIVA1;
            }
            set
            {
                mZDIVA1 = value;
            }
        }

        public Double ZDIVA2
        {
            get
            {
                return mZDIVA2;
            }
            set
            {
                mZDIVA2 = value;
            }
        }

        public Double ZDIVA3
        {
            get
            {
                return mZDIVA3;
            }
            set
            {
                mZDIVA3 = value;
            }
        }

        public Double ZDVTA1
        {
            get
            {
                return mZDVTA1;
            }
            set
            {
                mZDVTA1 = value;
            }
        }

        public Double ZDVTA2
        {
            get
            {
                return mZDVTA2;
            }
            set
            {
                mZDVTA2 = value;
            }
        }

        public Double ZDVTA3
        {
            get
            {
                return mZDVTA3;
            }
            set
            {
                mZDVTA3 = value;
            }
        }

        public Double ZEXT
        {
            get
            {
                return mZEXT;
            }
            set
            {
                mZEXT = value;
            }
        }

        public string ZFISCAL
        {
            get
            {
                return mZFISCAL;
            }
            set
            {
                mZFISCAL = value;
            }
        }

        public Double ZIVA1
        {
            get
            {
                return mZIVA1;
            }
            set
            {
                mZIVA1 = value;
            }
        }

        public Double ZIVA2
        {
            get
            {
                return mZIVA2;
            }
            set
            {
                mZIVA2 = value;
            }
        }

        public Double ZIVA3
        {
            get
            {
                return mZIVA3;
            }
            set
            {
                mZIVA3 = value;
            }
        }

        public Double ZVTA1
        {
            get
            {
                return mZVTA1;
            }
            set
            {
                mZVTA1 = value;
            }
        }

        public Double ZVTA2
        {
            get
            {
                return mZVTA2;
            }
            set
            {
                mZVTA2 = value;
            }
        }

        public Double ZVTA3
        {
            get
            {
                return mZVTA3;
            }
            set
            {
                mZVTA3 = value;
            }
        }

        CORTE()
        {
        }

        CORTE(double ABONOS, string ACTUAL, double APARTADOS, double BASE1, double BASE1D, double BASE1_C, double BASE1_NC, double BASE2, double BASE2D, double BASE2_C, double BASE2_NC, double BASE3, double BASE3D, double BASE3_C, double BASE3_NC, string CAJA, double CONTADO, double DBASE1_C, double DBASE1_NC, double DBASE2_C, double DBASE2_NC, double DBASE3_C, double DBASE3_NC, double DEPOSITO, double DESCU, double DESDE, double DESDEC, string DESDECF, double DESDED, double DEVOLUCION, double DEXENTO_C, double DEXENTO_NC, double DIVA1_C, double DIVA1_NC, double DIVA2_C, double DIVA2_NC, double DIVA3_C, double DIVA3_NC, double ENVIO, double ERETENCION, double EXENTO, double EXENTOD, double EXENTO_C, double EXENTO_NC, DateTime FECHA, string FECHAC, DateTime FECHAF, string FECHAFC, double GASTOS, double HASTA, double HASTAC, string HASTACF, double HASTAD, string HORAA, string HORAF, int ID, int IDSUC, int ID_CONSO, double IMPTUR, double IVA, double IVA1, double IVA1D, double IVA1_C, double IVA1_NC, double IVA2, double IVA2D, double IVA2_C, double IVA2_NC, double IVA3, double IVA3D, double IVA3_C, double IVA3_NC, string MAQFIS, double MONTO, double MONTO2, double MONTO3, double MONTOI, double NRO, double OTRO, double SERVICIO, double TOTAL, double TOTAL2, double TOTAL3, string UID, string UID_DEP, double VALE, double ZDEXT, double ZDIVA1, double ZDIVA2, double ZDIVA3, double ZDVTA1, double ZDVTA2, double ZDVTA3, double ZEXT, string ZFISCAL, double ZIVA1, double ZIVA2, double ZIVA3, double ZVTA1, double ZVTA2, double ZVTA3)
        {
            mABONOS = ABONOS;
            mACTUAL = ACTUAL;
            mAPARTADOS = APARTADOS;
            mBASE1 = BASE1;
            mBASE1D = BASE1D;
            mBASE1_C = BASE1_C;
            mBASE1_NC = BASE1_NC;
            mBASE2 = BASE2;
            mBASE2D = BASE2D;
            mBASE2_C = BASE2_C;
            mBASE2_NC = BASE2_NC;
            mBASE3 = BASE3;
            mBASE3D = BASE3D;
            mBASE3_C = BASE3_C;
            mBASE3_NC = BASE3_NC;
            mCAJA = CAJA;
            mCONTADO = CONTADO;
            mDBASE1_C = DBASE1_C;
            mDBASE1_NC = DBASE1_NC;
            mDBASE2_C = DBASE2_C;
            mDBASE2_NC = DBASE2_NC;
            mDBASE3_C = DBASE3_C;
            mDBASE3_NC = DBASE3_NC;
            mDEPOSITO = DEPOSITO;
            mDESCU = DESCU;
            mDESDE = DESDE;
            mDESDEC = DESDEC;
            mDESDECF = DESDECF;
            mDESDED = DESDED;
            mDEVOLUCION = DEVOLUCION;
            mDEXENTO_C = DEXENTO_C;
            mDEXENTO_NC = DEXENTO_NC;
            mDIVA1_C = DIVA1_C;
            mDIVA1_NC = DIVA1_NC;
            mDIVA2_C = DIVA2_C;
            mDIVA2_NC = DIVA2_NC;
            mDIVA3_C = DIVA3_C;
            mDIVA3_NC = DIVA3_NC;
            mENVIO = ENVIO;
            mERETENCION = ERETENCION;
            mEXENTO = EXENTO;
            mEXENTOD = EXENTOD;
            mEXENTO_C = EXENTO_C;
            mEXENTO_NC = EXENTO_NC;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAF = FECHAF;
            mFECHAFC = FECHAFC;
            mGASTOS = GASTOS;
            mHASTA = HASTA;
            mHASTAC = HASTAC;
            mHASTACF = HASTACF;
            mHASTAD = HASTAD;
            mHORAA = HORAA;
            mHORAF = HORAF;
            mID = ID;
            mIDSUC = IDSUC;
            mID_CONSO = ID_CONSO;
            mIMPTUR = IMPTUR;
            mIVA = IVA;
            mIVA1 = IVA1;
            mIVA1D = IVA1D;
            mIVA1_C = IVA1_C;
            mIVA1_NC = IVA1_NC;
            mIVA2 = IVA2;
            mIVA2D = IVA2D;
            mIVA2_C = IVA2_C;
            mIVA2_NC = IVA2_NC;
            mIVA3 = IVA3;
            mIVA3D = IVA3D;
            mIVA3_C = IVA3_C;
            mIVA3_NC = IVA3_NC;
            mMAQFIS = MAQFIS;
            mMONTO = MONTO;
            mMONTO2 = MONTO2;
            mMONTO3 = MONTO3;
            mMONTOI = MONTOI;
            mNRO = NRO;
            mOTRO = OTRO;
            mSERVICIO = SERVICIO;
            mTOTAL = TOTAL;
            mTOTAL2 = TOTAL2;
            mTOTAL3 = TOTAL3;
            mUID = UID;
            mUID_DEP = UID_DEP;
            mVALE = VALE;
            mZDEXT = ZDEXT;
            mZDIVA1 = ZDIVA1;
            mZDIVA2 = ZDIVA2;
            mZDIVA3 = ZDIVA3;
            mZDVTA1 = ZDVTA1;
            mZDVTA2 = ZDVTA2;
            mZDVTA3 = ZDVTA3;
            mZEXT = ZEXT;
            mZFISCAL = ZFISCAL;
            mZIVA1 = ZIVA1;
            mZIVA2 = ZIVA2;
            mZIVA3 = ZIVA3;
            mZVTA1 = ZVTA1;
            mZVTA2 = ZVTA2;
            mZVTA3 = ZVTA3;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
