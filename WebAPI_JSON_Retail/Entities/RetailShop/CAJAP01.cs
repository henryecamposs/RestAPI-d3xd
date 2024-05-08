using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAJAP01 : ICloneable
    {

        private string mCODIGO = "";
        private string mDESCR = "";
        private double mCANTI = 0.0;
        private double mMONTO = 0.0;
        private double mIVA = 0.0;
        private double mTOTAL = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private string mTPAGO = "";
        private double mNRO = 0.0;
        private string mGRUPO = "";
        private string mUNIDAD = "";
        private double mMONTOT = 0.0;
        private string mMESA = "";
        private string mMESO = "";
        private string mIMPRESO = "";
        private string mHORAA = "";
        private string mKP = "";
        private string mEXTRAS = "";
        private double mPSERVI = 0.0;
        private double mSERVI = 0.0;
        private string mCANCEL = "";
        private string mSECCION = "";
        private string mNMESA = "";
        private string mEMPLE = "";
        private string mNOMEMP = "";
        private string mEMPLEC = "";
        private string mNOMEMPC = "";
        private double mESPERA = 0.0;
        private string mTIEMPO = "";
        private string mTIPOITEM = "";
        private double mNROITEM = 0.0;
        private string mCANTT = "";
        private string mMONTOD = "";
        private string mCODIGOE = "";
        private double mCANTIE = 0.0;
        private double mCANTIEP = 0.0;
        private double mCANTIELIM = 0.0;
        private double mMONTOM = 0.0;
        private string mHORA = "";
        private string mHORAC = "";
        private string mCATEGORIA = "";
        private string mCAJA = "";
        private string mRIF = "";
        private string mTIPO = "";
        private double mDESCU = 0.0;
        private double mTDESCU = 0.0;
        private string mDDESCU = "";
        private string mCDESCU = "";
        private double mPDESCU = 0.0;
        private double mPDESCUB = 0.0;
        private double mNRODEV = 0.0;
        private int mCLIENTE = 0;
        private double mTIVA = 0.0;
        private double mCOMANDA = 0.0;
        private double mMARCA = 0.0;
        private string mPROMO = "";
        private double mTPROMO = 0.0;
        private string mDPTO = "";
        private string mCODIGOPRO = "";
        private string mPLLEVAR = "";
        private string mINVEN = "";
        private string mMODULO = "";
        private double mSNROITEM = 0.0;
        private int mCODCLI = 0;
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mCODIGOCOM = "";
        private double mPRECIOCOM = 0.0;
        private double mIVACOM = 0.0;
        private double mMONTOPROMO = 0.0;
        private double mCANTIPROMO = 0.0;
        private double mPIMP = 0.0;
        private string mVENDEDOR = "";
        private double mCOMIVENTA = 0.0;
        private double mGUIA_DESPA = 0.0;
        private string mTIPO_EMPA = "";
        private string mEMPAQUE = "";
        private double mUNIDADE = 0.0;
        private string mCODIGOI = "";
        private double mSESION = 0.0;
        private double mTAX = 0.0;
        private double mANULADOS = 0.0;
        private double mANULA_TEMP = 0.0;
        private string mLOTE = "";
        private double mDESC_TAR = 0.0;
        private double mIDGUIA = 0.0;
        private double mIDGUIAC = 0.0;
        private string mOPERADOR = "";
        private string mZONA = "";
        private double mKILOS = 0.0;
        private string mIDDATOSBAL = "";
        private string mSERIAL = "";
        private double mGARANTIA = 0.0;
        private double mSERVIBP = 0.0;
        private double mMAXMONTO = 0.0;
        private double mJETAVGAS = 0.0;
        private double mLICOR = 0.0;
        private string mCONTENIDO = "";
        private double mGRADOS = 0.0;
        private double mTIPO_LICOR = 0.0;
        private string mGDENVASE = "";
        private string mGDESPECI = "";
        private string mPROVEE = "";
        private string mOBSERVA = "";
        private double mPIDEOBSE = 0.0;
        private double mRECARGO = 0.0;
        private int mID_TABP = 0;
        private int mID = 0;
        private int mID_DOCU = 0;
        private double mTIVA2 = 0.0;
        private double mIVA_TIVA1 = 0.0;
        private double mIVA_TIVA2 = 0.0;
        private double mTAX_TIVA2 = 0.0;
        private double mTAX_TIVA1 = 0.0;
        private double mCLASE = 0.0;
        private double mTPRECIO = 0.0;
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private int mNROID = 0;
        private double mSysserial = 0.0;
        private int mLINENUM = 0;
        private string mNOMVEN = "";
        private double mCANTI_DES = 0.0;
        private int mID_TRANS = 0;
        private int mID_DEST = 0;
        private string mUIDFAC = "";
        private string mGUID = "";
        private double mMONCARGA = 0.0;
        private double mMONTOSD = 0.0;
        private double mIVASD = 0.0;
        private double mN_PUN = 0.0;
        private string mCONCEPTO = "";

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

        CAJAP01()
        {
        }

        CAJAP01(string CODIGO, string DESCR, double CANTI, double MONTO, double IVA, double TOTAL, DateTime FECHA, string FECHAC, string TPAGO, double NRO, string GRUPO, string UNIDAD, double MONTOT, string MESA, string MESO, string IMPRESO, string HORAA, string KP, string EXTRAS, double PSERVI, double SERVI, string CANCEL, string SECCION, string NMESA, string EMPLE, string NOMEMP, string EMPLEC, string NOMEMPC, double ESPERA, string TIEMPO, string TIPOITEM, double NROITEM, string CANTT, string MONTOD, string CODIGOE, double CANTIE, double CANTIEP, double CANTIELIM, double MONTOM, string HORA, string HORAC, string CATEGORIA, string CAJA, string RIF, string TIPO, double DESCU, double TDESCU, string DDESCU, string CDESCU, double PDESCU, double PDESCUB, double NRODEV, int CLIENTE, double TIVA, double COMANDA, double MARCA, string PROMO, double TPROMO, string DPTO, string CODIGOPRO, string PLLEVAR, string INVEN, string MODULO, double SNROITEM, int CODCLI, double COSTOP, double COSTOU, string CODIGOCOM, double PRECIOCOM, double IVACOM, double MONTOPROMO, double CANTIPROMO, double PIMP, string VENDEDOR, double COMIVENTA, double GUIA_DESPA, string TIPO_EMPA, string EMPAQUE, double UNIDADE, string CODIGOI, double SESION, double TAX, double ANULADOS, double ANULA_TEMP, string LOTE, double DESC_TAR, double IDGUIA, double IDGUIAC, string OPERADOR, string ZONA, double KILOS, string IDDATOSBAL, string SERIAL, double GARANTIA, double SERVIBP, double MAXMONTO, double JETAVGAS, double LICOR, string CONTENIDO, double GRADOS, double TIPO_LICOR, string GDENVASE, string GDESPECI, string PROVEE, string OBSERVA, double PIDEOBSE, double RECARGO, int ID_TABP, int ID, int ID_DOCU, double TIVA2, double IVA_TIVA1, double IVA_TIVA2, double TAX_TIVA2, double TAX_TIVA1, double CLASE, double TPRECIO, DateTime FECHAV, int NROID, double sysserial, int LINENUM, string NOMVEN, double CANTI_DES, int ID_TRANS, int ID_DEST, string UIDFAC, string GUID, double MONCARGA, double MONTOSD, double IVASD, double N_PUN, string CONCEPTO)
        {
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mCANTI = CANTI;
            mMONTO = MONTO;
            mIVA = IVA;
            mTOTAL = TOTAL;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mTPAGO = TPAGO;
            mNRO = NRO;
            mGRUPO = GRUPO;
            mUNIDAD = UNIDAD;
            mMONTOT = MONTOT;
            mMESA = MESA;
            mMESO = MESO;
            mIMPRESO = IMPRESO;
            mHORAA = HORAA;
            mKP = KP;
            mEXTRAS = EXTRAS;
            mPSERVI = PSERVI;
            mSERVI = SERVI;
            mCANCEL = CANCEL;
            mSECCION = SECCION;
            mNMESA = NMESA;
            mEMPLE = EMPLE;
            mNOMEMP = NOMEMP;
            mEMPLEC = EMPLEC;
            mNOMEMPC = NOMEMPC;
            mESPERA = ESPERA;
            mTIEMPO = TIEMPO;
            mTIPOITEM = TIPOITEM;
            mNROITEM = NROITEM;
            mCANTT = CANTT;
            mMONTOD = MONTOD;
            mCODIGOE = CODIGOE;
            mCANTIE = CANTIE;
            mCANTIEP = CANTIEP;
            mCANTIELIM = CANTIELIM;
            mMONTOM = MONTOM;
            mHORA = HORA;
            mHORAC = HORAC;
            mCATEGORIA = CATEGORIA;
            mCAJA = CAJA;
            mRIF = RIF;
            mTIPO = TIPO;
            mDESCU = DESCU;
            mTDESCU = TDESCU;
            mDDESCU = DDESCU;
            mCDESCU = CDESCU;
            mPDESCU = PDESCU;
            mPDESCUB = PDESCUB;
            mNRODEV = NRODEV;
            mCLIENTE = CLIENTE;
            mTIVA = TIVA;
            mCOMANDA = COMANDA;
            mMARCA = MARCA;
            mPROMO = PROMO;
            mTPROMO = TPROMO;
            mDPTO = DPTO;
            mCODIGOPRO = CODIGOPRO;
            mPLLEVAR = PLLEVAR;
            mINVEN = INVEN;
            mMODULO = MODULO;
            mSNROITEM = SNROITEM;
            mCODCLI = CODCLI;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mCODIGOCOM = CODIGOCOM;
            mPRECIOCOM = PRECIOCOM;
            mIVACOM = IVACOM;
            mMONTOPROMO = MONTOPROMO;
            mCANTIPROMO = CANTIPROMO;
            mPIMP = PIMP;
            mVENDEDOR = VENDEDOR;
            mCOMIVENTA = COMIVENTA;
            mGUIA_DESPA = GUIA_DESPA;
            mTIPO_EMPA = TIPO_EMPA;
            mEMPAQUE = EMPAQUE;
            mUNIDADE = UNIDADE;
            mCODIGOI = CODIGOI;
            mSESION = SESION;
            mTAX = TAX;
            mANULADOS = ANULADOS;
            mANULA_TEMP = ANULA_TEMP;
            mLOTE = LOTE;
            mDESC_TAR = DESC_TAR;
            mIDGUIA = IDGUIA;
            mIDGUIAC = IDGUIAC;
            mOPERADOR = OPERADOR;
            mZONA = ZONA;
            mKILOS = KILOS;
            mIDDATOSBAL = IDDATOSBAL;
            mSERIAL = SERIAL;
            mGARANTIA = GARANTIA;
            mSERVIBP = SERVIBP;
            mMAXMONTO = MAXMONTO;
            mJETAVGAS = JETAVGAS;
            mLICOR = LICOR;
            mCONTENIDO = CONTENIDO;
            mGRADOS = GRADOS;
            mTIPO_LICOR = TIPO_LICOR;
            mGDENVASE = GDENVASE;
            mGDESPECI = GDESPECI;
            mPROVEE = PROVEE;
            mOBSERVA = OBSERVA;
            mPIDEOBSE = PIDEOBSE;
            mRECARGO = RECARGO;
            mID_TABP = ID_TABP;
            mID = ID;
            mID_DOCU = ID_DOCU;
            mTIVA2 = TIVA2;
            mIVA_TIVA1 = IVA_TIVA1;
            mIVA_TIVA2 = IVA_TIVA2;
            mTAX_TIVA2 = TAX_TIVA2;
            mTAX_TIVA1 = TAX_TIVA1;
            mCLASE = CLASE;
            mTPRECIO = TPRECIO;
            mFECHAV = FECHAV;
            mNROID = NROID;
            mSysserial = Sysserial;
            mLINENUM = LINENUM;
            mNOMVEN = NOMVEN;
            mCANTI_DES = CANTI_DES;
            mID_TRANS = ID_TRANS;
            mID_DEST = ID_DEST;
            mUIDFAC = UIDFAC;
            mGUID = GUID;
            mMONCARGA = MONCARGA;
            mMONTOSD = MONTOSD;
            mIVASD = IVASD;
            mN_PUN = N_PUN;
            mCONCEPTO = CONCEPTO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
