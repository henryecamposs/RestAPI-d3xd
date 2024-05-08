using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PRESU_ITEMS : ICloneable
    {

        private double mANULADOS = 0.0;
        private double mANULA_TEMP = 0.0;
        private string mCAJA = "";
        private string mCANCEL = "";
        private double mCANTI = 0.0;
        private double mCANTIE = 0.0;
        private double mCANTIELIM = 0.0;
        private double mCANTIEP = 0.0;
        private double mCANTIPROMO = 0.0;
        private double mCANTI_DES = 0.0;
        private string mCANTT = "";
        private string mCATEGORIA = "";
        private string mCDESCU = "";
        private double mCLASE = 0.0;
        private int mCLIENTE = 0;
        private int mCODCLI = 0;
        private string mCODIGO = "";
        private string mCODIGOCOM = "";
        private string mCODIGOE = "";
        private string mCODIGOI = "";
        private string mCODIGOPRO = "";
        private double mCOMANDA = 0.0;
        private double mCOMIVENTA = 0.0;
        private string mCONCEPTO = "";
        private string mCONTENIDO = "";
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mDDESCU = "";
        private string mDESCR = "";
        private double mDESCU = 0.0;
        private double mDESC_TAR = 0.0;
        private string mDPTO = "";
        private string mEMPAQUE = "";
        private string mEMPLE = "";
        private string mEMPLEC = "";
        private double mESPERA = 0.0;
        private string mEXTRAS = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private double mGARANTIA = 0.0;
        private string mGDENVASE = "";
        private string mGDESPECI = "";
        private double mGRADOS = 0.0;
        private string mGRUPO = "";
        private double mGUIA_DESPA = 0.0;
        private string mGUID = "";
        private string mHORA = "";
        private string mHORAA = "";
        private string mHORAC = "";
        private int mID = 0;
        private string mIDDATOSBAL = "";
        private double mIDGUIA = 0.0;
        private double mIDGUIAC = 0.0;
        private int mID_DEST = 0;
        private int mID_DOCU = 0;
        private int mID_TABP = 0;
        private int mID_TRANS = 0;
        private string mIMPRESO = "";
        private string mINVEN = "";
        private double mIVA = 0.0;
        private double mIVACOM = 0.0;
        private double mIVASD = 0.0;
        private double mIVA_TIVA1 = 0.0;
        private double mIVA_TIVA2 = 0.0;
        private double mJETAVGAS = 0.0;
        private double mKILOS = 0.0;
        private string mKP = "";
        private double mLICOR = 0.0;
        private int mLINENUM = 0;
        private string mLOTE = "";
        private double mMARCA = 0.0;
        private double mMAXMONTO = 0.0;
        private string mMESA = "";
        private string mMESO = "";
        private string mMODULO = "";
        private double mMONCARGA = 0.0;
        private double mMONTO = 0.0;
        private string mMONTOD = "";
        private double mMONTOM = 0.0;
        private double mMONTOPROMO = 0.0;
        private double mMONTOSD = 0.0;
        private double mMONTOT = 0.0;
        private string mNMESA = "";
        private string mNOMEMP = "";
        private string mNOMEMPC = "";
        private string mNOMVEN = "";
        private double mNRO = 0.0;
        private double mNRODEV = 0.0;
        private int mNROID = 0;
        private double mNROITEM = 0.0;
        private double mN_PUN = 0.0;
        private string mOBSERVA = "";
        private string mOPERADOR = "";
        private double mPDESCU = 0.0;
        private double mPDESCUB = 0.0;
        private double mPIDEOBSE = 0.0;
        private double mPIMP = 0.0;
        private string mPLLEVAR = "";
        private double mPRECIOCOM = 0.0;
        private string mPROMO = "";
        private string mPROVEE = "";
        private double mPSERVI = 0.0;
        private double mRECARGO = 0.0;
        private string mRIF = "";
        private string mSECCION = "";
        private string mSERIAL = "";
        private double mSERVI = 0.0;
        private double mSERVIBP = 0.0;
        private double mSESION = 0.0;
        private double mSNROITEM = 0.0;
        private double mTAX = 0.0;
        private double mTAX_TIVA1 = 0.0;
        private double mTAX_TIVA2 = 0.0;
        private double mTDESCU = 0.0;
        private string mTIEMPO = "";
        private string mTIPO = "";
        private string mTIPOITEM = "";
        private string mTIPO_EMPA = "";
        private double mTIPO_LICOR = 0.0;
        private double mTIVA = 0.0;
        private double mTIVA2 = 0.0;
        private double mTOTAL = 0.0;
        private string mTPAGO = "";
        private double mTPRECIO = 0.0;
        private double mTPROMO = 0.0;
        private string mUIDFAC = "";
        private string mUNIDAD = "";
        private double mUNIDADE = 0.0;
        private string mVENDEDOR = "";
        private string mZONA = "";
        private double mSysserial = 0.0;

        public Double ANULADOS
        {
            get
            {
                return mANULADOS;
            }
            set
            {
                mANULADOS = value;
            }
        }

        public Double ANULA_TEMP
        {
            get
            {
                return mANULA_TEMP;
            }
            set
            {
                mANULA_TEMP = value;
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

        public string CANTT
        {
            get
            {
                return mCANTT;
            }
            set
            {
                mCANTT = value;
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

        public Double CLASE
        {
            get
            {
                return mCLASE;
            }
            set
            {
                mCLASE = value;
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

        public string CODIGOCOM
        {
            get
            {
                return mCODIGOCOM;
            }
            set
            {
                mCODIGOCOM = value;
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

        public string CODIGOPRO
        {
            get
            {
                return mCODIGOPRO;
            }
            set
            {
                mCODIGOPRO = value;
            }
        }

        public Double COMANDA
        {
            get
            {
                return mCOMANDA;
            }
            set
            {
                mCOMANDA = value;
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

        public string CONTENIDO
        {
            get
            {
                return mCONTENIDO;
            }
            set
            {
                mCONTENIDO = value;
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

        public string EMPAQUE
        {
            get
            {
                return mEMPAQUE;
            }
            set
            {
                mEMPAQUE = value;
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

        public Double ESPERA
        {
            get
            {
                return mESPERA;
            }
            set
            {
                mESPERA = value;
            }
        }

        public string EXTRAS
        {
            get
            {
                return mEXTRAS;
            }
            set
            {
                mEXTRAS = value;
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

        public Double GARANTIA
        {
            get
            {
                return mGARANTIA;
            }
            set
            {
                mGARANTIA = value;
            }
        }

        public string GDENVASE
        {
            get
            {
                return mGDENVASE;
            }
            set
            {
                mGDENVASE = value;
            }
        }

        public string GDESPECI
        {
            get
            {
                return mGDESPECI;
            }
            set
            {
                mGDESPECI = value;
            }
        }

        public Double GRADOS
        {
            get
            {
                return mGRADOS;
            }
            set
            {
                mGRADOS = value;
            }
        }

        public string GRUPO
        {
            get
            {
                return mGRUPO;
            }
            set
            {
                mGRUPO = value;
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

        public string IDDATOSBAL
        {
            get
            {
                return mIDDATOSBAL;
            }
            set
            {
                mIDDATOSBAL = value;
            }
        }

        public Double IDGUIA
        {
            get
            {
                return mIDGUIA;
            }
            set
            {
                mIDGUIA = value;
            }
        }

        public Double IDGUIAC
        {
            get
            {
                return mIDGUIAC;
            }
            set
            {
                mIDGUIAC = value;
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

        public int ID_TABP
        {
            get
            {
                return mID_TABP;
            }
            set
            {
                mID_TABP = value;
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

        public string IMPRESO
        {
            get
            {
                return mIMPRESO;
            }
            set
            {
                mIMPRESO = value;
            }
        }

        public string INVEN
        {
            get
            {
                return mINVEN;
            }
            set
            {
                mINVEN = value;
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

        public Double IVACOM
        {
            get
            {
                return mIVACOM;
            }
            set
            {
                mIVACOM = value;
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

        public Double JETAVGAS
        {
            get
            {
                return mJETAVGAS;
            }
            set
            {
                mJETAVGAS = value;
            }
        }

        public Double KILOS
        {
            get
            {
                return mKILOS;
            }
            set
            {
                mKILOS = value;
            }
        }

        public string KP
        {
            get
            {
                return mKP;
            }
            set
            {
                mKP = value;
            }
        }

        public Double LICOR
        {
            get
            {
                return mLICOR;
            }
            set
            {
                mLICOR = value;
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

        public Double MAXMONTO
        {
            get
            {
                return mMAXMONTO;
            }
            set
            {
                mMAXMONTO = value;
            }
        }

        public string MESA
        {
            get
            {
                return mMESA;
            }
            set
            {
                mMESA = value;
            }
        }

        public string MESO
        {
            get
            {
                return mMESO;
            }
            set
            {
                mMESO = value;
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

        public string MONTOD
        {
            get
            {
                return mMONTOD;
            }
            set
            {
                mMONTOD = value;
            }
        }

        public Double MONTOM
        {
            get
            {
                return mMONTOM;
            }
            set
            {
                mMONTOM = value;
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

        public Double MONTOT
        {
            get
            {
                return mMONTOT;
            }
            set
            {
                mMONTOT = value;
            }
        }

        public string NMESA
        {
            get
            {
                return mNMESA;
            }
            set
            {
                mNMESA = value;
            }
        }

        public string NOMEMP
        {
            get
            {
                return mNOMEMP;
            }
            set
            {
                mNOMEMP = value;
            }
        }

        public string NOMEMPC
        {
            get
            {
                return mNOMEMPC;
            }
            set
            {
                mNOMEMPC = value;
            }
        }

        public string NOMVEN
        {
            get
            {
                return mNOMVEN;
            }
            set
            {
                mNOMVEN = value;
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

        public int NROID
        {
            get
            {
                return mNROID;
            }
            set
            {
                mNROID = value;
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

        public string OBSERVA
        {
            get
            {
                return mOBSERVA;
            }
            set
            {
                mOBSERVA = value;
            }
        }

        public string OPERADOR
        {
            get
            {
                return mOPERADOR;
            }
            set
            {
                mOPERADOR = value;
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

        public string PLLEVAR
        {
            get
            {
                return mPLLEVAR;
            }
            set
            {
                mPLLEVAR = value;
            }
        }

        public Double PRECIOCOM
        {
            get
            {
                return mPRECIOCOM;
            }
            set
            {
                mPRECIOCOM = value;
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

        public string PROVEE
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

        public string SECCION
        {
            get
            {
                return mSECCION;
            }
            set
            {
                mSECCION = value;
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

        public Double SNROITEM
        {
            get
            {
                return mSNROITEM;
            }
            set
            {
                mSNROITEM = value;
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

        public string TIEMPO
        {
            get
            {
                return mTIEMPO;
            }
            set
            {
                mTIEMPO = value;
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

        public string TIPO_EMPA
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

        public Double TIPO_LICOR
        {
            get
            {
                return mTIPO_LICOR;
            }
            set
            {
                mTIPO_LICOR = value;
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

        public string ZONA
        {
            get
            {
                return mZONA;
            }
            set
            {
                mZONA = value;
            }
        }

        public Double Sysserial
        {
            get
            {
                return mSysserial;
            }
            set
            {
                mSysserial = value;
            }
        }

        PRESU_ITEMS()
        {
        }

        PRESU_ITEMS(double ANULADOS, double ANULA_TEMP, string CAJA, string CANCEL, double CANTI, double CANTIE, double CANTIELIM, double CANTIEP, double CANTIPROMO, double CANTI_DES, string CANTT, string CATEGORIA, string CDESCU, double CLASE, int CLIENTE, int CODCLI, string CODIGO, string CODIGOCOM, string CODIGOE, string CODIGOI, string CODIGOPRO, double COMANDA, double COMIVENTA, string CONCEPTO, string CONTENIDO, double COSTOP, double COSTOU, string DDESCU, string DESCR, double DESCU, double DESC_TAR, string DPTO, string EMPAQUE, string EMPLE, string EMPLEC, double ESPERA, string EXTRAS, DateTime FECHA, string FECHAC, DateTime FECHAV, double GARANTIA, string GDENVASE, string GDESPECI, double GRADOS, string GRUPO, double GUIA_DESPA, string GUID, string HORA, string HORAA, string HORAC, int ID, string IDDATOSBAL, double IDGUIA, double IDGUIAC, int ID_DEST, int ID_DOCU, int ID_TABP, int ID_TRANS, string IMPRESO, string INVEN, double IVA, double IVACOM, double IVASD, double IVA_TIVA1, double IVA_TIVA2, double JETAVGAS, double KILOS, string KP, double LICOR, int LINENUM, string LOTE, double MARCA, double MAXMONTO, string MESA, string MESO, string MODULO, double MONCARGA, double MONTO, string MONTOD, double MONTOM, double MONTOPROMO, double MONTOSD, double MONTOT, string NMESA, string NOMEMP, string NOMEMPC, string NOMVEN, double NRO, double NRODEV, int NROID, double NROITEM, double N_PUN, string OBSERVA, string OPERADOR, double PDESCU, double PDESCUB, double PIDEOBSE, double PIMP, string PLLEVAR, double PRECIOCOM, string PROMO, string PROVEE, double PSERVI, double RECARGO, string RIF, string SECCION, string SERIAL, double SERVI, double SERVIBP, double SESION, double SNROITEM, double TAX, double TAX_TIVA1, double TAX_TIVA2, double TDESCU, string TIEMPO, string TIPO, string TIPOITEM, string TIPO_EMPA, double TIPO_LICOR, double TIVA, double TIVA2, double TOTAL, string TPAGO, double TPRECIO, double TPROMO, string UIDFAC, string UNIDAD, double UNIDADE, string VENDEDOR, string ZONA, double sysserial)
        {
            mANULADOS = ANULADOS;
            mANULA_TEMP = ANULA_TEMP;
            mCAJA = CAJA;
            mCANCEL = CANCEL;
            mCANTI = CANTI;
            mCANTIE = CANTIE;
            mCANTIELIM = CANTIELIM;
            mCANTIEP = CANTIEP;
            mCANTIPROMO = CANTIPROMO;
            mCANTI_DES = CANTI_DES;
            mCANTT = CANTT;
            mCATEGORIA = CATEGORIA;
            mCDESCU = CDESCU;
            mCLASE = CLASE;
            mCLIENTE = CLIENTE;
            mCODCLI = CODCLI;
            mCODIGO = CODIGO;
            mCODIGOCOM = CODIGOCOM;
            mCODIGOE = CODIGOE;
            mCODIGOI = CODIGOI;
            mCODIGOPRO = CODIGOPRO;
            mCOMANDA = COMANDA;
            mCOMIVENTA = COMIVENTA;
            mCONCEPTO = CONCEPTO;
            mCONTENIDO = CONTENIDO;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mDDESCU = DDESCU;
            mDESCR = DESCR;
            mDESCU = DESCU;
            mDESC_TAR = DESC_TAR;
            mDPTO = DPTO;
            mEMPAQUE = EMPAQUE;
            mEMPLE = EMPLE;
            mEMPLEC = EMPLEC;
            mESPERA = ESPERA;
            mEXTRAS = EXTRAS;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAV = FECHAV;
            mGARANTIA = GARANTIA;
            mGDENVASE = GDENVASE;
            mGDESPECI = GDESPECI;
            mGRADOS = GRADOS;
            mGRUPO = GRUPO;
            mGUIA_DESPA = GUIA_DESPA;
            mGUID = GUID;
            mHORA = HORA;
            mHORAA = HORAA;
            mHORAC = HORAC;
            mID = ID;
            mIDDATOSBAL = IDDATOSBAL;
            mIDGUIA = IDGUIA;
            mIDGUIAC = IDGUIAC;
            mID_DEST = ID_DEST;
            mID_DOCU = ID_DOCU;
            mID_TABP = ID_TABP;
            mID_TRANS = ID_TRANS;
            mIMPRESO = IMPRESO;
            mINVEN = INVEN;
            mIVA = IVA;
            mIVACOM = IVACOM;
            mIVASD = IVASD;
            mIVA_TIVA1 = IVA_TIVA1;
            mIVA_TIVA2 = IVA_TIVA2;
            mJETAVGAS = JETAVGAS;
            mKILOS = KILOS;
            mKP = KP;
            mLICOR = LICOR;
            mLINENUM = LINENUM;
            mLOTE = LOTE;
            mMARCA = MARCA;
            mMAXMONTO = MAXMONTO;
            mMESA = MESA;
            mMESO = MESO;
            mMODULO = MODULO;
            mMONCARGA = MONCARGA;
            mMONTO = MONTO;
            mMONTOD = MONTOD;
            mMONTOM = MONTOM;
            mMONTOPROMO = MONTOPROMO;
            mMONTOSD = MONTOSD;
            mMONTOT = MONTOT;
            mNMESA = NMESA;
            mNOMEMP = NOMEMP;
            mNOMEMPC = NOMEMPC;
            mNOMVEN = NOMVEN;
            mNRO = NRO;
            mNRODEV = NRODEV;
            mNROID = NROID;
            mNROITEM = NROITEM;
            mN_PUN = N_PUN;
            mOBSERVA = OBSERVA;
            mOPERADOR = OPERADOR;
            mPDESCU = PDESCU;
            mPDESCUB = PDESCUB;
            mPIDEOBSE = PIDEOBSE;
            mPIMP = PIMP;
            mPLLEVAR = PLLEVAR;
            mPRECIOCOM = PRECIOCOM;
            mPROMO = PROMO;
            mPROVEE = PROVEE;
            mPSERVI = PSERVI;
            mRECARGO = RECARGO;
            mRIF = RIF;
            mSECCION = SECCION;
            mSERIAL = SERIAL;
            mSERVI = SERVI;
            mSERVIBP = SERVIBP;
            mSESION = SESION;
            mSNROITEM = SNROITEM;
            mTAX = TAX;
            mTAX_TIVA1 = TAX_TIVA1;
            mTAX_TIVA2 = TAX_TIVA2;
            mTDESCU = TDESCU;
            mTIEMPO = TIEMPO;
            mTIPO = TIPO;
            mTIPOITEM = TIPOITEM;
            mTIPO_EMPA = TIPO_EMPA;
            mTIPO_LICOR = TIPO_LICOR;
            mTIVA = TIVA;
            mTIVA2 = TIVA2;
            mTOTAL = TOTAL;
            mTPAGO = TPAGO;
            mTPRECIO = TPRECIO;
            mTPROMO = TPROMO;
            mUIDFAC = UIDFAC;
            mUNIDAD = UNIDAD;
            mUNIDADE = UNIDADE;
            mVENDEDOR = VENDEDOR;
            mZONA = ZONA;
            mSysserial = Sysserial;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
