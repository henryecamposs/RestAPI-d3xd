using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class FACTU : ICloneable
    {

        private double mABONO = 0.0;
        private string mANULADO = "";
        private double mBASE1 = 0.0;
        private double mBASE2 = 0.0;
        private double mBASE3 = 0.0;
        private double mBONOD = 0.0;
        private string mCAJA = "";
        private string mCAJADEV = "";
        private string mCANCEL = "";
        private double mCANCELADO = 0.0;
        private double mCANTI = 0.0;
        private double mCANTIELIM = 0.0;
        private string mCCONTABLE = "";
        private string mCDESCU = "";
        private double mCFISCAL = 0.0;
        private double mCFISCALD = 0.0;
        private int mCLIENTE = 0;
        private string mCMATRICU = "";
        private int mCODCLI = 0;
        private int mCODCLI2 = 0;
        private string mCODENC = "";
        private string mCODIGOBP = "";
        private string mCODPEDIDO = "";
        private double mCOMICOB = 0.0;
        private double mCOMIVEN = 0.0;
        private double mCOMIVENTA = 0.0;
        private double mCOMRET = 0.0;
        private double mCONTRI = 0.0;
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mDDESCU = "";
        private double mDESCU = 0.0;
        private double mDESCUT = 0.0;
        private double mDESC_TAR = 0.0;
        private double mDIASCRE = 0.0;
        private string mDIRECCION = "";
        private string mEMPLE = "";
        private string mEMPLEC = "";
        private double mESTATUSR = 0.0;
        private double mEXENTO = 0.0;
        private double mFACTOR_AFI = 0.0;
        private double mFDESCU = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFISLR = new DateTime(2000, 01, 01);
        private double mGUIA_DESPA = 0.0;
        private string mHORA = "";
        private string mHORAA = "";
        private string mHORAC = "";
        private int mID = 0;
        private int mIDCIUDAD = 0;
        private int mIDCLIASO = 0;
        private int mIDDIRCENT = 0;
        private int mIDESTADO = 0;
        private int mIDPAIS = 0;
        private int mIDSUC = 0;
        private int mIDTERPAG = 0;
        private int mID_CREDI = 0;
        private int mID_REFE = 0;
        private double mIVA = 0.0;
        private double mIVA1 = 0.0;
        private double mIVA2 = 0.0;
        private double mIVA3 = 0.0;
        private string mLICENCIA = "";
        private string mMAQFIS = "";
        private string mMAQFISDE = "";
        private string mMODULO = "";
        private double mMONTO = 0.0;
        private string mNIT = "";
        private string mNOMCLI = "";
        private double mNRO = 0.0;
        private double mNRODEV = 0.0;
        private double mN_PUN = 0.0;
        private double mPDESCU = 0.0;
        private double mPDESCUB = 0.0;
        private double mPORCD = 0.0;
        private double mPRET = 0.0;
        private double mPROPINA = 0.0;
        private double mRECARGO = 0.0;
        private double mRECIBIDO = 0.0;
        private string mRIF = "";
        private double mSERVICIO = 0.0;
        private double mSESION = 0.0;
        private double mT1 = 0.0;
        private double mTAX1 = 0.0;
        private double mTAX2 = 0.0;
        private double mTAX3 = 0.0;
        private double mTDESCU = 0.0;
        private double mTDESTINO = 0.0;
        private string mTELEFONO = "";
        private string mTIPO = "";
        private double mTIPOD = 0.0;
        private int mTIPO_AFI = 0;
        private double mTISLR = 0.0;
        private double mTOTAL = 0.0;
        private string mTPAGO = "";
        private double mTRETEN = 0.0;
        private string mUID = "";
        private string mUIDCLIMOV = "";
        private string mUIDCORTE = "";
        private double mVAL_PUN = 0.0;
        private string mVENDEDOR = "";
        private double mVERIFI = 0.0;
        private double mComisrl = 0.0;
        private double mEstatus = 0.0;
        private double mModonc = 0.0;
        private double mPisrl = 0.0;
        private double mTiponc = 0.0;

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

        public string ANULADO
        {
            get
            {
                return mANULADO;
            }
            set
            {
                mANULADO = value;
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

        public Double BONOD
        {
            get
            {
                return mBONOD;
            }
            set
            {
                mBONOD = value;
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

        public string CAJADEV
        {
            get
            {
                return mCAJADEV;
            }
            set
            {
                mCAJADEV = value;
            }
        }

        public string CANCEL
        {
            get
            {
                return mCANCEL;
            }
            set
            {
                mCANCEL = value;
            }
        }

        public Double CANCELADO
        {
            get
            {
                return mCANCELADO;
            }
            set
            {
                mCANCELADO = value;
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

        public string CCONTABLE
        {
            get
            {
                return mCCONTABLE;
            }
            set
            {
                mCCONTABLE = value;
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

        public Double CFISCAL
        {
            get
            {
                return mCFISCAL;
            }
            set
            {
                mCFISCAL = value;
            }
        }

        public Double CFISCALD
        {
            get
            {
                return mCFISCALD;
            }
            set
            {
                mCFISCALD = value;
            }
        }

        public int CLIENTE
        {
            get
            {
                return mCLIENTE;
            }
            set
            {
                mCLIENTE = value;
            }
        }

        public string CMATRICU
        {
            get
            {
                return mCMATRICU;
            }
            set
            {
                mCMATRICU = value;
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

        public int CODCLI2
        {
            get
            {
                return mCODCLI2;
            }
            set
            {
                mCODCLI2 = value;
            }
        }

        public string CODENC
        {
            get
            {
                return mCODENC;
            }
            set
            {
                mCODENC = value;
            }
        }

        public string CODIGOBP
        {
            get
            {
                return mCODIGOBP;
            }
            set
            {
                mCODIGOBP = value;
            }
        }

        public string CODPEDIDO
        {
            get
            {
                return mCODPEDIDO;
            }
            set
            {
                mCODPEDIDO = value;
            }
        }

        public Double COMICOB
        {
            get
            {
                return mCOMICOB;
            }
            set
            {
                mCOMICOB = value;
            }
        }

        public Double COMIVEN
        {
            get
            {
                return mCOMIVEN;
            }
            set
            {
                mCOMIVEN = value;
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

        public Double COMRET
        {
            get
            {
                return mCOMRET;
            }
            set
            {
                mCOMRET = value;
            }
        }

        public Double CONTRI
        {
            get
            {
                return mCONTRI;
            }
            set
            {
                mCONTRI = value;
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

        public Double DESCUT
        {
            get
            {
                return mDESCUT;
            }
            set
            {
                mDESCUT = value;
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

        public Double DIASCRE
        {
            get
            {
                return mDIASCRE;
            }
            set
            {
                mDIASCRE = value;
            }
        }

        public string DIRECCION
        {
            get
            {
                return mDIRECCION;
            }
            set
            {
                mDIRECCION = value;
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

        public Double ESTATUSR
        {
            get
            {
                return mESTATUSR;
            }
            set
            {
                mESTATUSR = value;
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

        public Double FACTOR_AFI
        {
            get
            {
                return mFACTOR_AFI;
            }
            set
            {
                mFACTOR_AFI = value;
            }
        }

        public Double FDESCU
        {
            get
            {
                return mFDESCU;
            }
            set
            {
                mFDESCU = value;
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

        public DateTime FISLR
        {
            get
            {
                return mFISLR;
            }
            set
            {
                mFISLR = value;
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

        public int IDCIUDAD
        {
            get
            {
                return mIDCIUDAD;
            }
            set
            {
                mIDCIUDAD = value;
            }
        }

        public int IDCLIASO
        {
            get
            {
                return mIDCLIASO;
            }
            set
            {
                mIDCLIASO = value;
            }
        }

        public int IDDIRCENT
        {
            get
            {
                return mIDDIRCENT;
            }
            set
            {
                mIDDIRCENT = value;
            }
        }

        public int IDESTADO
        {
            get
            {
                return mIDESTADO;
            }
            set
            {
                mIDESTADO = value;
            }
        }

        public int IDPAIS
        {
            get
            {
                return mIDPAIS;
            }
            set
            {
                mIDPAIS = value;
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

        public int IDTERPAG
        {
            get
            {
                return mIDTERPAG;
            }
            set
            {
                mIDTERPAG = value;
            }
        }

        public int ID_CREDI
        {
            get
            {
                return mID_CREDI;
            }
            set
            {
                mID_CREDI = value;
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

        public string LICENCIA
        {
            get
            {
                return mLICENCIA;
            }
            set
            {
                mLICENCIA = value;
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

        public string MAQFISDE
        {
            get
            {
                return mMAQFISDE;
            }
            set
            {
                mMAQFISDE = value;
            }
        }

        public string MODULO
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

        public string NIT
        {
            get
            {
                return mNIT;
            }
            set
            {
                mNIT = value;
            }
        }

        public string NOMCLI
        {
            get
            {
                return mNOMCLI;
            }
            set
            {
                mNOMCLI = value;
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

        public Double PORCD
        {
            get
            {
                return mPORCD;
            }
            set
            {
                mPORCD = value;
            }
        }

        public Double PRET
        {
            get
            {
                return mPRET;
            }
            set
            {
                mPRET = value;
            }
        }

        public Double PROPINA
        {
            get
            {
                return mPROPINA;
            }
            set
            {
                mPROPINA = value;
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

        public Double RECIBIDO
        {
            get
            {
                return mRECIBIDO;
            }
            set
            {
                mRECIBIDO = value;
            }
        }

        public string RIF
        {
            get
            {
                return mRIF;
            }
            set
            {
                mRIF = value;
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

        public Double T1
        {
            get
            {
                return mT1;
            }
            set
            {
                mT1 = value;
            }
        }

        public Double TAX1
        {
            get
            {
                return mTAX1;
            }
            set
            {
                mTAX1 = value;
            }
        }

        public Double TAX2
        {
            get
            {
                return mTAX2;
            }
            set
            {
                mTAX2 = value;
            }
        }

        public Double TAX3
        {
            get
            {
                return mTAX3;
            }
            set
            {
                mTAX3 = value;
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

        public Double TDESTINO
        {
            get
            {
                return mTDESTINO;
            }
            set
            {
                mTDESTINO = value;
            }
        }

        public string TELEFONO
        {
            get
            {
                return mTELEFONO;
            }
            set
            {
                mTELEFONO = value;
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

        public Double TIPOD
        {
            get
            {
                return mTIPOD;
            }
            set
            {
                mTIPOD = value;
            }
        }

        public int TIPO_AFI
        {
            get
            {
                return mTIPO_AFI;
            }
            set
            {
                mTIPO_AFI = value;
            }
        }

        public Double TISLR
        {
            get
            {
                return mTISLR;
            }
            set
            {
                mTISLR = value;
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

        public string TPAGO
        {
            get
            {
                return mTPAGO;
            }
            set
            {
                mTPAGO = value;
            }
        }

        public Double TRETEN
        {
            get
            {
                return mTRETEN;
            }
            set
            {
                mTRETEN = value;
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

        public string UIDCLIMOV
        {
            get
            {
                return mUIDCLIMOV;
            }
            set
            {
                mUIDCLIMOV = value;
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

        public Double VAL_PUN
        {
            get
            {
                return mVAL_PUN;
            }
            set
            {
                mVAL_PUN = value;
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

        public Double VERIFI
        {
            get
            {
                return mVERIFI;
            }
            set
            {
                mVERIFI = value;
            }
        }

        public Double Comisrl
        {
            get
            {
                return mComisrl;
            }
            set
            {
                mComisrl = value;
            }
        }

        public Double Estatus
        {
            get
            {
                return mEstatus;
            }
            set
            {
                mEstatus = value;
            }
        }

        public Double Modonc
        {
            get
            {
                return mModonc;
            }
            set
            {
                mModonc = value;
            }
        }

        public Double Pisrl
        {
            get
            {
                return mPisrl;
            }
            set
            {
                mPisrl = value;
            }
        }

        public Double Tiponc
        {
            get
            {
                return mTiponc;
            }
            set
            {
                mTiponc = value;
            }
        }

        FACTU()
        {
        }

        FACTU(double ABONO, string ANULADO, double BASE1, double BASE2, double BASE3, double BONOD, string CAJA, string CAJADEV, string CANCEL, double CANCELADO, double CANTI, double CANTIELIM, string CCONTABLE, string CDESCU, double CFISCAL, double CFISCALD, int CLIENTE, string CMATRICU, int CODCLI, int CODCLI2, string CODENC, string CODIGOBP, string CODPEDIDO, double COMICOB, double COMIVEN, double COMIVENTA, double COMRET, double CONTRI, double COSTOP, double COSTOU, string DDESCU, double DESCU, double DESCUT, double DESC_TAR, double DIASCRE, string DIRECCION, string EMPLE, string EMPLEC, double ESTATUSR, double EXENTO, double FACTOR_AFI, double FDESCU, DateTime FECHA, string FECHAC, DateTime FISLR, double GUIA_DESPA, string HORA, string HORAA, string HORAC, int ID, int IDCIUDAD, int IDCLIASO, int IDDIRCENT, int IDESTADO, int IDPAIS, int IDSUC, int IDTERPAG, int ID_CREDI, int ID_REFE, double IVA, double IVA1, double IVA2, double IVA3, string LICENCIA, string MAQFIS, string MAQFISDE, string MODULO, double MONTO, string NIT, string NOMCLI, double NRO, double NRODEV, double N_PUN, double PDESCU, double PDESCUB, double PORCD, double PRET, double PROPINA, double RECARGO, double RECIBIDO, string RIF, double SERVICIO, double SESION, double T1, double TAX1, double TAX2, double TAX3, double TDESCU, double TDESTINO, string TELEFONO, string TIPO, double TIPOD, int TIPO_AFI, double TISLR, double TOTAL, string TPAGO, double TRETEN, string UID, string UIDCLIMOV, string UIDCORTE, double VAL_PUN, string VENDEDOR, double VERIFI, double comisrl, double estatus, double modonc, double pisrl, double tiponc)
        {
            mABONO = ABONO;
            mANULADO = ANULADO;
            mBASE1 = BASE1;
            mBASE2 = BASE2;
            mBASE3 = BASE3;
            mBONOD = BONOD;
            mCAJA = CAJA;
            mCAJADEV = CAJADEV;
            mCANCEL = CANCEL;
            mCANCELADO = CANCELADO;
            mCANTI = CANTI;
            mCANTIELIM = CANTIELIM;
            mCCONTABLE = CCONTABLE;
            mCDESCU = CDESCU;
            mCFISCAL = CFISCAL;
            mCFISCALD = CFISCALD;
            mCLIENTE = CLIENTE;
            mCMATRICU = CMATRICU;
            mCODCLI = CODCLI;
            mCODCLI2 = CODCLI2;
            mCODENC = CODENC;
            mCODIGOBP = CODIGOBP;
            mCODPEDIDO = CODPEDIDO;
            mCOMICOB = COMICOB;
            mCOMIVEN = COMIVEN;
            mCOMIVENTA = COMIVENTA;
            mCOMRET = COMRET;
            mCONTRI = CONTRI;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mDDESCU = DDESCU;
            mDESCU = DESCU;
            mDESCUT = DESCUT;
            mDESC_TAR = DESC_TAR;
            mDIASCRE = DIASCRE;
            mDIRECCION = DIRECCION;
            mEMPLE = EMPLE;
            mEMPLEC = EMPLEC;
            mESTATUSR = ESTATUSR;
            mEXENTO = EXENTO;
            mFACTOR_AFI = FACTOR_AFI;
            mFDESCU = FDESCU;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFISLR = FISLR;
            mGUIA_DESPA = GUIA_DESPA;
            mHORA = HORA;
            mHORAA = HORAA;
            mHORAC = HORAC;
            mID = ID;
            mIDCIUDAD = IDCIUDAD;
            mIDCLIASO = IDCLIASO;
            mIDDIRCENT = IDDIRCENT;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
            mIDSUC = IDSUC;
            mIDTERPAG = IDTERPAG;
            mID_CREDI = ID_CREDI;
            mID_REFE = ID_REFE;
            mIVA = IVA;
            mIVA1 = IVA1;
            mIVA2 = IVA2;
            mIVA3 = IVA3;
            mLICENCIA = LICENCIA;
            mMAQFIS = MAQFIS;
            mMAQFISDE = MAQFISDE;
            mMODULO = MODULO;
            mMONTO = MONTO;
            mNIT = NIT;
            mNOMCLI = NOMCLI;
            mNRO = NRO;
            mNRODEV = NRODEV;
            mN_PUN = N_PUN;
            mPDESCU = PDESCU;
            mPDESCUB = PDESCUB;
            mPORCD = PORCD;
            mPRET = PRET;
            mPROPINA = PROPINA;
            mRECARGO = RECARGO;
            mRECIBIDO = RECIBIDO;
            mRIF = RIF;
            mSERVICIO = SERVICIO;
            mSESION = SESION;
            mT1 = T1;
            mTAX1 = TAX1;
            mTAX2 = TAX2;
            mTAX3 = TAX3;
            mTDESCU = TDESCU;
            mTDESTINO = TDESTINO;
            mTELEFONO = TELEFONO;
            mTIPO = TIPO;
            mTIPOD = TIPOD;
            mTIPO_AFI = TIPO_AFI;
            mTISLR = TISLR;
            mTOTAL = TOTAL;
            mTPAGO = TPAGO;
            mTRETEN = TRETEN;
            mUID = UID;
            mUIDCLIMOV = UIDCLIMOV;
            mUIDCORTE = UIDCORTE;
            mVAL_PUN = VAL_PUN;
            mVENDEDOR = VENDEDOR;
            mVERIFI = VERIFI;
            mComisrl = Comisrl;
            mEstatus = Estatus;
            mModonc = Modonc;
            mPisrl = Pisrl;
            mTiponc = Tiponc;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
