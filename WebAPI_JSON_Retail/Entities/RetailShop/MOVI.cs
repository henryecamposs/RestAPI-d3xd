using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class MOVI : ICloneable
    {

        private string mBARRA = "";
        private string mCAJA = "";
        private double mCANTI = 0.0;
        private double mCANTIE = 0.0;
        private double mCANTIELIM = 0.0;
        private double mCANTIEP = 0.0;
        private double mCANTIPROMO = 0.0;
        private double mCANTI_DES = 0.0;
        private string mCATEGORIA = "";
        private string mCDESCU = "";
        private double mCLASIF = 0.0;
        private int mCODCLI = 0;
        private string mCODIGO = "";
        private string mCODIGOE = "";
        private string mCODIGOI = "";
        private double mCOMIVENTA = 0.0;
        private string mCONCEPTO = "";
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mDDESCU = "";
        private string mDESCR = "";
        private double mDESCU = 0.0;
        private double mDESC_TAR = 0.0;
        private double mDEVOLU = 0.0;
        private string mDPTO = "";
        private string mEMPLE = "";
        private string mEMPLEC = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAP = new DateTime(2000, 01, 01);
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private double mGUIA_DESPA = 0.0;
        private string mGUID = "";
        private string mHORA = "";
        private string mHORAA = "";
        private string mHORAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_DEST = 0;
        private int mID_DOCU = 0;
        private int mID_TRANS = 0;
        private double mIVA = 0.0;
        private double mIVASD = 0.0;
        private double mIVA_TIVA1 = 0.0;
        private double mIVA_TIVA2 = 0.0;
        private int mLINENUM = 0;
        private string mLOTE = "";
        private double mMARCA = 0.0;
        private double mMONCARGA = 0.0;
        private double mMONTO = 0.0;
        private double mMONTOPROMO = 0.0;
        private double mMONTOSD = 0.0;
        private double mNRO = 0.0;
        private string mNROC = "";
        private double mNRODEV = 0.0;
        private double mNROITEM = 0.0;
        private double mN_PUN = 0.0;
        private double mPDESCU = 0.0;
        private double mPDESCUB = 0.0;
        private double mPDESCUG = 0.0;
        private double mPIDEOBSE = 0.0;
        private double mPIMP = 0.0;
        private double mPRECIOP = 0.0;
        private double mPRECIOU = 0.0;
        private string mPROMO = "";
        private double mPSERVI = 0.0;
        private double mRECARGO = 0.0;
        private string mSERIAL = "";
        private double mSERVI = 0.0;
        private double mSERVIBP = 0.0;
        private double mSESION = 0.0;
        private double mSYSSERIAL = 0.0;
        private double mTAX = 0.0;
        private double mTAX_TIVA1 = 0.0;
        private double mTAX_TIVA2 = 0.0;
        private double mTDESCU = 0.0;
        private string mTIPO = "";
        private string mTIPOITEM = "";
        private double mTIPO_EMPA = 0.0;
        private double mTIVA = 0.0;
        private double mTIVA2 = 0.0;
        private double mTOTAL = 0.0;
        private double mTPRECIO = 0.0;
        private double mTPROMO = 0.0;
        private string mUIDCORTE = "";
        private string mUIDFAC = "";
        private string mUNIDAD = "";
        private double mUNIDADE = 0.0;
        private string mVENDEDOR = "";

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

        public Double CANTIE
        {
            get
            {
                return mCANTIE;
            }
            set
            {
                mCANTIE = value;
            }
        }

        public Double CANTIELIM
        {
            get
            {
                return mCANTIELIM;
            }
            set
            {
                mCANTIELIM = value;
            }
        }

        public Double CANTIEP
        {
            get
            {
                return mCANTIEP;
            }
            set
            {
                mCANTIEP = value;
            }
        }

        public Double CANTIPROMO
        {
            get
            {
                return mCANTIPROMO;
            }
            set
            {
                mCANTIPROMO = value;
            }
        }

        public Double CANTI_DES
        {
            get
            {
                return mCANTI_DES;
            }
            set
            {
                mCANTI_DES = value;
            }
        }

        public string CATEGORIA
        {
            get
            {
                return mCATEGORIA;
            }
            set
            {
                mCATEGORIA = value;
            }
        }

        public string CDESCU
        {
            get
            {
                return mCDESCU;
            }
            set
            {
                mCDESCU = value;
            }
        }

        public Double CLASIF
        {
            get
            {
                return mCLASIF;
            }
            set
            {
                mCLASIF = value;
            }
        }

        public int CODCLI
        {
            get
            {
                return mCODCLI;
            }
            set
            {
                mCODCLI = value;
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

        public string CODIGOE
        {
            get
            {
                return mCODIGOE;
            }
            set
            {
                mCODIGOE = value;
            }
        }

        public string CODIGOI
        {
            get
            {
                return mCODIGOI;
            }
            set
            {
                mCODIGOI = value;
            }
        }

        public Double COMIVENTA
        {
            get
            {
                return mCOMIVENTA;
            }
            set
            {
                mCOMIVENTA = value;
            }
        }

        public string CONCEPTO
        {
            get
            {
                return mCONCEPTO;
            }
            set
            {
                mCONCEPTO = value;
            }
        }

        public Double COSTOP
        {
            get
            {
                return mCOSTOP;
            }
            set
            {
                mCOSTOP = value;
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

        public string DDESCU
        {
            get
            {
                return mDDESCU;
            }
            set
            {
                mDDESCU = value;
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

        public Double DESC_TAR
        {
            get
            {
                return mDESC_TAR;
            }
            set
            {
                mDESC_TAR = value;
            }
        }

        public Double DEVOLU
        {
            get
            {
                return mDEVOLU;
            }
            set
            {
                mDEVOLU = value;
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

        public string EMPLEC
        {
            get
            {
                return mEMPLEC;
            }
            set
            {
                mEMPLEC = value;
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

        public DateTime FECHAP
        {
            get
            {
                return mFECHAP;
            }
            set
            {
                mFECHAP = value;
            }
        }

        public DateTime FECHAV
        {
            get
            {
                return mFECHAV;
            }
            set
            {
                mFECHAV = value;
            }
        }

        public Double GUIA_DESPA
        {
            get
            {
                return mGUIA_DESPA;
            }
            set
            {
                mGUIA_DESPA = value;
            }
        }

        public string GUID
        {
            get
            {
                return mGUID;
            }
            set
            {
                mGUID = value;
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

        public string HORAC
        {
            get
            {
                return mHORAC;
            }
            set
            {
                mHORAC = value;
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

        public int ID_DEST
        {
            get
            {
                return mID_DEST;
            }
            set
            {
                mID_DEST = value;
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

        public int ID_TRANS
        {
            get
            {
                return mID_TRANS;
            }
            set
            {
                mID_TRANS = value;
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

        public Double IVASD
        {
            get
            {
                return mIVASD;
            }
            set
            {
                mIVASD = value;
            }
        }

        public Double IVA_TIVA1
        {
            get
            {
                return mIVA_TIVA1;
            }
            set
            {
                mIVA_TIVA1 = value;
            }
        }

        public Double IVA_TIVA2
        {
            get
            {
                return mIVA_TIVA2;
            }
            set
            {
                mIVA_TIVA2 = value;
            }
        }

        public int LINENUM
        {
            get
            {
                return mLINENUM;
            }
            set
            {
                mLINENUM = value;
            }
        }

        public string LOTE
        {
            get
            {
                return mLOTE;
            }
            set
            {
                mLOTE = value;
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

        public Double MONCARGA
        {
            get
            {
                return mMONCARGA;
            }
            set
            {
                mMONCARGA = value;
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

        public Double MONTOPROMO
        {
            get
            {
                return mMONTOPROMO;
            }
            set
            {
                mMONTOPROMO = value;
            }
        }

        public Double MONTOSD
        {
            get
            {
                return mMONTOSD;
            }
            set
            {
                mMONTOSD = value;
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

        public Double NRODEV
        {
            get
            {
                return mNRODEV;
            }
            set
            {
                mNRODEV = value;
            }
        }

        public Double NROITEM
        {
            get
            {
                return mNROITEM;
            }
            set
            {
                mNROITEM = value;
            }
        }

        public Double N_PUN
        {
            get
            {
                return mN_PUN;
            }
            set
            {
                mN_PUN = value;
            }
        }

        public Double PDESCU
        {
            get
            {
                return mPDESCU;
            }
            set
            {
                mPDESCU = value;
            }
        }

        public Double PDESCUB
        {
            get
            {
                return mPDESCUB;
            }
            set
            {
                mPDESCUB = value;
            }
        }

        public Double PDESCUG
        {
            get
            {
                return mPDESCUG;
            }
            set
            {
                mPDESCUG = value;
            }
        }

        public Double PIDEOBSE
        {
            get
            {
                return mPIDEOBSE;
            }
            set
            {
                mPIDEOBSE = value;
            }
        }

        public Double PIMP
        {
            get
            {
                return mPIMP;
            }
            set
            {
                mPIMP = value;
            }
        }

        public Double PRECIOP
        {
            get
            {
                return mPRECIOP;
            }
            set
            {
                mPRECIOP = value;
            }
        }

        public Double PRECIOU
        {
            get
            {
                return mPRECIOU;
            }
            set
            {
                mPRECIOU = value;
            }
        }

        public string PROMO
        {
            get
            {
                return mPROMO;
            }
            set
            {
                mPROMO = value;
            }
        }

        public Double PSERVI
        {
            get
            {
                return mPSERVI;
            }
            set
            {
                mPSERVI = value;
            }
        }

        public Double RECARGO
        {
            get
            {
                return mRECARGO;
            }
            set
            {
                mRECARGO = value;
            }
        }

        public string SERIAL
        {
            get
            {
                return mSERIAL;
            }
            set
            {
                mSERIAL = value;
            }
        }

        public Double SERVI
        {
            get
            {
                return mSERVI;
            }
            set
            {
                mSERVI = value;
            }
        }

        public Double SERVIBP
        {
            get
            {
                return mSERVIBP;
            }
            set
            {
                mSERVIBP = value;
            }
        }

        public Double SESION
        {
            get
            {
                return mSESION;
            }
            set
            {
                mSESION = value;
            }
        }

        public Double SYSSERIAL
        {
            get
            {
                return mSYSSERIAL;
            }
            set
            {
                mSYSSERIAL = value;
            }
        }

        public Double TAX
        {
            get
            {
                return mTAX;
            }
            set
            {
                mTAX = value;
            }
        }

        public Double TAX_TIVA1
        {
            get
            {
                return mTAX_TIVA1;
            }
            set
            {
                mTAX_TIVA1 = value;
            }
        }

        public Double TAX_TIVA2
        {
            get
            {
                return mTAX_TIVA2;
            }
            set
            {
                mTAX_TIVA2 = value;
            }
        }

        public Double TDESCU
        {
            get
            {
                return mTDESCU;
            }
            set
            {
                mTDESCU = value;
            }
        }

        public string TIPO
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

        public string TIPOITEM
        {
            get
            {
                return mTIPOITEM;
            }
            set
            {
                mTIPOITEM = value;
            }
        }

        public Double TIPO_EMPA
        {
            get
            {
                return mTIPO_EMPA;
            }
            set
            {
                mTIPO_EMPA = value;
            }
        }

        public Double TIVA
        {
            get
            {
                return mTIVA;
            }
            set
            {
                mTIVA = value;
            }
        }

        public Double TIVA2
        {
            get
            {
                return mTIVA2;
            }
            set
            {
                mTIVA2 = value;
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

        public Double TPRECIO
        {
            get
            {
                return mTPRECIO;
            }
            set
            {
                mTPRECIO = value;
            }
        }

        public Double TPROMO
        {
            get
            {
                return mTPROMO;
            }
            set
            {
                mTPROMO = value;
            }
        }

        public string UIDCORTE
        {
            get
            {
                return mUIDCORTE;
            }
            set
            {
                mUIDCORTE = value;
            }
        }

        public string UIDFAC
        {
            get
            {
                return mUIDFAC;
            }
            set
            {
                mUIDFAC = value;
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

        public string VENDEDOR
        {
            get
            {
                return mVENDEDOR;
            }
            set
            {
                mVENDEDOR = value;
            }
        }

        MOVI()
        {
        }

        MOVI(string BARRA, string CAJA, double CANTI, double CANTIE, double CANTIELIM, double CANTIEP, double CANTIPROMO, double CANTI_DES, string CATEGORIA, string CDESCU, double CLASIF, int CODCLI, string CODIGO, string CODIGOE, string CODIGOI, double COMIVENTA, string CONCEPTO, double COSTOP, double COSTOU, string DDESCU, string DESCR, double DESCU, double DESC_TAR, double DEVOLU, string DPTO, string EMPLE, string EMPLEC, DateTime FECHA, string FECHAC, DateTime FECHAP, DateTime FECHAV, double GUIA_DESPA, string GUID, string HORA, string HORAA, string HORAC, int ID, int IDSUC, int ID_DEST, int ID_DOCU, int ID_TRANS, double IVA, double IVASD, double IVA_TIVA1, double IVA_TIVA2, int LINENUM, string LOTE, double MARCA, double MONCARGA, double MONTO, double MONTOPROMO, double MONTOSD, double NRO, string NROC, double NRODEV, double NROITEM, double N_PUN, double PDESCU, double PDESCUB, double PDESCUG, double PIDEOBSE, double PIMP, double PRECIOP, double PRECIOU, string PROMO, double PSERVI, double RECARGO, string SERIAL, double SERVI, double SERVIBP, double SESION, double SYSSERIAL, double TAX, double TAX_TIVA1, double TAX_TIVA2, double TDESCU, string TIPO, string TIPOITEM, double TIPO_EMPA, double TIVA, double TIVA2, double TOTAL, double TPRECIO, double TPROMO, string UIDCORTE, string UIDFAC, string UNIDAD, double UNIDADE, string VENDEDOR)
        {
            mBARRA = BARRA;
            mCAJA = CAJA;
            mCANTI = CANTI;
            mCANTIE = CANTIE;
            mCANTIELIM = CANTIELIM;
            mCANTIEP = CANTIEP;
            mCANTIPROMO = CANTIPROMO;
            mCANTI_DES = CANTI_DES;
            mCATEGORIA = CATEGORIA;
            mCDESCU = CDESCU;
            mCLASIF = CLASIF;
            mCODCLI = CODCLI;
            mCODIGO = CODIGO;
            mCODIGOE = CODIGOE;
            mCODIGOI = CODIGOI;
            mCOMIVENTA = COMIVENTA;
            mCONCEPTO = CONCEPTO;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mDDESCU = DDESCU;
            mDESCR = DESCR;
            mDESCU = DESCU;
            mDESC_TAR = DESC_TAR;
            mDEVOLU = DEVOLU;
            mDPTO = DPTO;
            mEMPLE = EMPLE;
            mEMPLEC = EMPLEC;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAP = FECHAP;
            mFECHAV = FECHAV;
            mGUIA_DESPA = GUIA_DESPA;
            mGUID = GUID;
            mHORA = HORA;
            mHORAA = HORAA;
            mHORAC = HORAC;
            mID = ID;
            mIDSUC = IDSUC;
            mID_DEST = ID_DEST;
            mID_DOCU = ID_DOCU;
            mID_TRANS = ID_TRANS;
            mIVA = IVA;
            mIVASD = IVASD;
            mIVA_TIVA1 = IVA_TIVA1;
            mIVA_TIVA2 = IVA_TIVA2;
            mLINENUM = LINENUM;
            mLOTE = LOTE;
            mMARCA = MARCA;
            mMONCARGA = MONCARGA;
            mMONTO = MONTO;
            mMONTOPROMO = MONTOPROMO;
            mMONTOSD = MONTOSD;
            mNRO = NRO;
            mNROC = NROC;
            mNRODEV = NRODEV;
            mNROITEM = NROITEM;
            mN_PUN = N_PUN;
            mPDESCU = PDESCU;
            mPDESCUB = PDESCUB;
            mPDESCUG = PDESCUG;
            mPIDEOBSE = PIDEOBSE;
            mPIMP = PIMP;
            mPRECIOP = PRECIOP;
            mPRECIOU = PRECIOU;
            mPROMO = PROMO;
            mPSERVI = PSERVI;
            mRECARGO = RECARGO;
            mSERIAL = SERIAL;
            mSERVI = SERVI;
            mSERVIBP = SERVIBP;
            mSESION = SESION;
            mSYSSERIAL = SYSSERIAL;
            mTAX = TAX;
            mTAX_TIVA1 = TAX_TIVA1;
            mTAX_TIVA2 = TAX_TIVA2;
            mTDESCU = TDESCU;
            mTIPO = TIPO;
            mTIPOITEM = TIPOITEM;
            mTIPO_EMPA = TIPO_EMPA;
            mTIVA = TIVA;
            mTIVA2 = TIVA2;
            mTOTAL = TOTAL;
            mTPRECIO = TPRECIO;
            mTPROMO = TPROMO;
            mUIDCORTE = UIDCORTE;
            mUIDFAC = UIDFAC;
            mUNIDAD = UNIDAD;
            mUNIDADE = UNIDADE;
            mVENDEDOR = VENDEDOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
