using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DATOS : ICloneable
    {

        private bool mACCESO_USU = false;
        private double mADVCOST = 0.0;
        private double mAEREOP = 0.0;
        private double mALTERNOS = 0.0;
        private double mANUSALCLI = 0.0;
        private double mATIPOCLI = 0.0;
        private bool mAUTOINV = false;
        private double mBASE_MARGE = 0.0;
        private double mBLOFECAC = 0.0;
        private string mBSF = "";
        private double mCAJAPROM = 0.0;
        private double mCAJARIFA = 0.0;
        private double mCAL_UTI = 0.0;
        private double mCAMMON = 0.0;
        private double mCANTIDES = 0.0;
        private string mCEXENTO = "";
        private string mCIVA1 = "";
        private string mCIVA2 = "";
        private string mCIVA3 = "";
        private double mCLAVE1 = 0.0;
        private double mCLAVE2 = 0.0;
        private double mCLAVE3 = 0.0;
        private double mCLIADUA = 0.0;
        private double mCLIASO = 0.0;
        private double mCLICRECE = 0.0;
        private double mCLIMATRI = 0.0;
        private string mCODAEREO = "";
        private string mCODFORMATO = "";
        private string mCOD_CARGA = "";
        private string mCOLAF = "";
        private string mCOMCOD = "";
        private string mCOMDES = "";
        private double mCONTROLME = 0.0;
        private double mCONTROLPER = 0.0;
        private double mCOPIAS = 0.0;
        private double mCORTE_USU = 0.0;
        private double mDEC = 0.0;
        private double mDECIMALES = 0.0;
        private double mDELFILE = 0.0;
        private double mDEPVENFO = 0.0;
        private double mDET_PAGOS = 0.0;
        private string mDIR1 = "";
        private string mDIR2 = "";
        private string mDIRFILE = "";
        private double mDIVCALUTI = 0.0;
        private double mDONAVUEL = 0.0;
        private double mENVIO = 0.0;
        private string mEXTFILE = "";
        private double mFAC_ANU = 0.0;
        private double mFCODCLI = 0.0;
        private double mFRANQ = 0.0;
        private double mFTICKET = 0.0;
        private double mHABLADORES = 0.0;
        private int mID = 0;
        private bool mIDATOS = false;
        private string mIDBAL = "";
        private double mIDIOMA = 0.0;
        private int mIDSUC = 0;
        private double mID_CLI = 0.0;
        private double mIMP = 0.0;
        private double mIMP1 = 0.0;
        private double mIMP2 = 0.0;
        private double mIMP3 = 0.0;
        private double mIMP4 = 0.0;
        private double mIMP5 = 0.0;
        private string mIMPNOTA = "";
        private double mINTEGRA = 0.0;
        private double mISMASTER = 0.0;
        private bool mLEEFILE = false;
        private double mLEYECLAP = 0.0;
        private string mLIC_LICOR = "";
        private double mLINEAFF = 0.0;
        private double mLINEAPF = 0.0;
        private double mLOYALTY = 0.0;
        private double mMARGEN1 = 0.0;
        private double mMARGEN1M = 0.0;
        private double mMARGEN2 = 0.0;
        private double mMARGEN2M = 0.0;
        private double mMARGEN3 = 0.0;
        private double mMARGEN3M = 0.0;
        private double mMARGEN4 = 0.0;
        private double mMARGEN4M = 0.0;
        private string mMENSAJEF = "";
        private bool mMESAS = false;
        private bool mMESONEROS = false;
        private double mMISDATOS = 0.0;
        private double mMODO_CORTE = 0.0;
        private double mMODO_PREM = 0.0;
        private double mMOD_ID = 0.0;
        private string mMONEDA = "";
        private double mMONEDAE = 0.0;
        private string mMRLOGO = "";
        private double mMULTI_TAX = 0.0;
        private double mMVLOGO = 0.0;
        private double mNCHECKOF = 0.0;
        private string mNFILEB = "";
        private string mNIMP = "";
        private string mNIMP1 = "";
        private string mNIMP2 = "";
        private string mNIMP3 = "";
        private string mNIMP4 = "";
        private string mNIMP5 = "";
        private string mNIT = "";
        private string mNOMALI = "";
        private string mNOMBEBI = "";
        private double mNOMIDENT = 0.0;
        private double mNOPRORRA = 0.0;
        private double mNREFLEIMPF = 0.0;
        private double mNREFLEIMPN = 0.0;
        private string mNROFRAN = "";
        private double mNUMFAUNI = 0.0;
        private string mN_SUC = "";
        private double mOMITE_CERO = 0.0;
        private double mON_LINE = 0.0;
        private double mOPC_VENTAS = 0.0;
        private string mOTROAP = "";
        private double mPAMERICAN = 0.0;
        private double mPDEBITO = 0.0;
        private double mPDINERS = 0.0;
        private double mPDISCOVER = 0.0;
        private double mPEDIR_FEC = 0.0;
        private bool mPIDECLA = false;
        private bool mPIDEMONTO = false;
        private double mPMASTER = 0.0;
        private double mPORCCOM = 0.0;
        private double mPOTROS = 0.0;
        private double mPRECIOUL = 0.0;
        private double mPRECIOUM = 0.0;
        private double mPRODINT1 = 0.0;
        private double mPRODINT2 = 0.0;
        private double mPRODNAC1 = 0.0;
        private double mPRODNAC2 = 0.0;
        private double mPVISA = 0.0;
        private bool mRED = false;
        private bool mREFLENRO = false;
        private double mRETEN = 0.0;
        private double mREVER_PAG = 0.0;
        private string mRIF = "";
        private double mSAP_B1 = 0.0;
        private bool mSERBARRA = false;
        private string mSERIAL = "";
        private string mSERIAL1 = "";
        private string mSERIAL2 = "";
        private double mSERIALES = 0.0;
        private double mSERVEHI = 0.0;
        private double mSERVI = 0.0;
        private double mSERVITOTAL = 0.0;
        private bool mSLIP = false;
        private double mSOBCOS = 0.0;
        private string mTELEFONO = "";
        private double mTIMP = 0.0;
        private double mTIMPV = 0.0;
        private double mTIMP_DPTO = 0.0;
        private double mTIPO_CORTE = 0.0;
        private double mTPREAJUSTE = 0.0;
        private string mUID = "";
        private double mVAL_PUN = 0.0;
        private double mVENNEGA = 0.0;
        private double mVEN_EMPLE = 0.0;
        private double mVERICREDI = 0.0;
        private string mVER_SIS = "";
        private double mVTA_DPTO = 0.0;
        private double mVTA_GRU = 0.0;
        private double mVTA_PRO = 0.0;
        private double mWIZARD_PT = 0.0;
        private double mActpreitem = 0.0;
        private double mDisaplsal = 0.0;
        private double mNcortesal = 0.0;
        private double mPrecio1 = 0.0;
        private double mPrecio2 = 0.0;
        private double mPrecio3 = 0.0;
        private double mPrecio4 = 0.0;
        private double mPrecio5 = 0.0;
        private double mPrecio6 = 0.0;
        private double mReintentoqbloq = 0.0;
        private double mStatusansw = 0.0;
        private double mSufijo_cod = 0.0;
        private string mValdatoscli = "";

        public Boolean ACCESO_USU
        {
            get
            {
                return mACCESO_USU;
            }
            set
            {
                mACCESO_USU = value;
            }
        }

        public Double ADVCOST
        {
            get
            {
                return mADVCOST;
            }
            set
            {
                mADVCOST = value;
            }
        }

        public Double AEREOP
        {
            get
            {
                return mAEREOP;
            }
            set
            {
                mAEREOP = value;
            }
        }

        public Double ALTERNOS
        {
            get
            {
                return mALTERNOS;
            }
            set
            {
                mALTERNOS = value;
            }
        }

        public Double ANUSALCLI
        {
            get
            {
                return mANUSALCLI;
            }
            set
            {
                mANUSALCLI = value;
            }
        }

        public Double ATIPOCLI
        {
            get
            {
                return mATIPOCLI;
            }
            set
            {
                mATIPOCLI = value;
            }
        }

        public Boolean AUTOINV
        {
            get
            {
                return mAUTOINV;
            }
            set
            {
                mAUTOINV = value;
            }
        }

        public Double BASE_MARGE
        {
            get
            {
                return mBASE_MARGE;
            }
            set
            {
                mBASE_MARGE = value;
            }
        }

        public Double BLOFECAC
        {
            get
            {
                return mBLOFECAC;
            }
            set
            {
                mBLOFECAC = value;
            }
        }

        public string BSF
        {
            get
            {
                return mBSF;
            }
            set
            {
                mBSF = value;
            }
        }

        public Double CAJAPROM
        {
            get
            {
                return mCAJAPROM;
            }
            set
            {
                mCAJAPROM = value;
            }
        }

        public Double CAJARIFA
        {
            get
            {
                return mCAJARIFA;
            }
            set
            {
                mCAJARIFA = value;
            }
        }

        public Double CAL_UTI
        {
            get
            {
                return mCAL_UTI;
            }
            set
            {
                mCAL_UTI = value;
            }
        }

        public Double CAMMON
        {
            get
            {
                return mCAMMON;
            }
            set
            {
                mCAMMON = value;
            }
        }

        public Double CANTIDES
        {
            get
            {
                return mCANTIDES;
            }
            set
            {
                mCANTIDES = value;
            }
        }

        public string CEXENTO
        {
            get
            {
                return mCEXENTO;
            }
            set
            {
                mCEXENTO = value;
            }
        }

        public string CIVA1
        {
            get
            {
                return mCIVA1;
            }
            set
            {
                mCIVA1 = value;
            }
        }

        public string CIVA2
        {
            get
            {
                return mCIVA2;
            }
            set
            {
                mCIVA2 = value;
            }
        }

        public string CIVA3
        {
            get
            {
                return mCIVA3;
            }
            set
            {
                mCIVA3 = value;
            }
        }

        public Double CLAVE1
        {
            get
            {
                return mCLAVE1;
            }
            set
            {
                mCLAVE1 = value;
            }
        }

        public Double CLAVE2
        {
            get
            {
                return mCLAVE2;
            }
            set
            {
                mCLAVE2 = value;
            }
        }

        public Double CLAVE3
        {
            get
            {
                return mCLAVE3;
            }
            set
            {
                mCLAVE3 = value;
            }
        }

        public Double CLIADUA
        {
            get
            {
                return mCLIADUA;
            }
            set
            {
                mCLIADUA = value;
            }
        }

        public Double CLIASO
        {
            get
            {
                return mCLIASO;
            }
            set
            {
                mCLIASO = value;
            }
        }

        public Double CLICRECE
        {
            get
            {
                return mCLICRECE;
            }
            set
            {
                mCLICRECE = value;
            }
        }

        public Double CLIMATRI
        {
            get
            {
                return mCLIMATRI;
            }
            set
            {
                mCLIMATRI = value;
            }
        }

        public string CODAEREO
        {
            get
            {
                return mCODAEREO;
            }
            set
            {
                mCODAEREO = value;
            }
        }

        public string CODFORMATO
        {
            get
            {
                return mCODFORMATO;
            }
            set
            {
                mCODFORMATO = value;
            }
        }

        public string COD_CARGA
        {
            get
            {
                return mCOD_CARGA;
            }
            set
            {
                mCOD_CARGA = value;
            }
        }

        public string COLAF
        {
            get
            {
                return mCOLAF;
            }
            set
            {
                mCOLAF = value;
            }
        }

        public string COMCOD
        {
            get
            {
                return mCOMCOD;
            }
            set
            {
                mCOMCOD = value;
            }
        }

        public string COMDES
        {
            get
            {
                return mCOMDES;
            }
            set
            {
                mCOMDES = value;
            }
        }

        public Double CONTROLME
        {
            get
            {
                return mCONTROLME;
            }
            set
            {
                mCONTROLME = value;
            }
        }

        public Double CONTROLPER
        {
            get
            {
                return mCONTROLPER;
            }
            set
            {
                mCONTROLPER = value;
            }
        }

        public Double COPIAS
        {
            get
            {
                return mCOPIAS;
            }
            set
            {
                mCOPIAS = value;
            }
        }

        public Double CORTE_USU
        {
            get
            {
                return mCORTE_USU;
            }
            set
            {
                mCORTE_USU = value;
            }
        }

        public Double DEC
        {
            get
            {
                return mDEC;
            }
            set
            {
                mDEC = value;
            }
        }

        public Double DECIMALES
        {
            get
            {
                return mDECIMALES;
            }
            set
            {
                mDECIMALES = value;
            }
        }

        public Double DELFILE
        {
            get
            {
                return mDELFILE;
            }
            set
            {
                mDELFILE = value;
            }
        }

        public Double DEPVENFO
        {
            get
            {
                return mDEPVENFO;
            }
            set
            {
                mDEPVENFO = value;
            }
        }

        public Double DET_PAGOS
        {
            get
            {
                return mDET_PAGOS;
            }
            set
            {
                mDET_PAGOS = value;
            }
        }

        public string DIR1
        {
            get
            {
                return mDIR1;
            }
            set
            {
                mDIR1 = value;
            }
        }

        public string DIR2
        {
            get
            {
                return mDIR2;
            }
            set
            {
                mDIR2 = value;
            }
        }

        public string DIRFILE
        {
            get
            {
                return mDIRFILE;
            }
            set
            {
                mDIRFILE = value;
            }
        }

        public Double DIVCALUTI
        {
            get
            {
                return mDIVCALUTI;
            }
            set
            {
                mDIVCALUTI = value;
            }
        }

        public Double DONAVUEL
        {
            get
            {
                return mDONAVUEL;
            }
            set
            {
                mDONAVUEL = value;
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

        public string EXTFILE
        {
            get
            {
                return mEXTFILE;
            }
            set
            {
                mEXTFILE = value;
            }
        }

        public Double FAC_ANU
        {
            get
            {
                return mFAC_ANU;
            }
            set
            {
                mFAC_ANU = value;
            }
        }

        public Double FCODCLI
        {
            get
            {
                return mFCODCLI;
            }
            set
            {
                mFCODCLI = value;
            }
        }

        public Double FRANQ
        {
            get
            {
                return mFRANQ;
            }
            set
            {
                mFRANQ = value;
            }
        }

        public Double FTICKET
        {
            get
            {
                return mFTICKET;
            }
            set
            {
                mFTICKET = value;
            }
        }

        public Double HABLADORES
        {
            get
            {
                return mHABLADORES;
            }
            set
            {
                mHABLADORES = value;
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

        public Boolean IDATOS
        {
            get
            {
                return mIDATOS;
            }
            set
            {
                mIDATOS = value;
            }
        }

        public string IDBAL
        {
            get
            {
                return mIDBAL;
            }
            set
            {
                mIDBAL = value;
            }
        }

        public Double IDIOMA
        {
            get
            {
                return mIDIOMA;
            }
            set
            {
                mIDIOMA = value;
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

        public Double ID_CLI
        {
            get
            {
                return mID_CLI;
            }
            set
            {
                mID_CLI = value;
            }
        }

        public Double IMP
        {
            get
            {
                return mIMP;
            }
            set
            {
                mIMP = value;
            }
        }

        public Double IMP1
        {
            get
            {
                return mIMP1;
            }
            set
            {
                mIMP1 = value;
            }
        }

        public Double IMP2
        {
            get
            {
                return mIMP2;
            }
            set
            {
                mIMP2 = value;
            }
        }

        public Double IMP3
        {
            get
            {
                return mIMP3;
            }
            set
            {
                mIMP3 = value;
            }
        }

        public Double IMP4
        {
            get
            {
                return mIMP4;
            }
            set
            {
                mIMP4 = value;
            }
        }

        public Double IMP5
        {
            get
            {
                return mIMP5;
            }
            set
            {
                mIMP5 = value;
            }
        }

        public string IMPNOTA
        {
            get
            {
                return mIMPNOTA;
            }
            set
            {
                mIMPNOTA = value;
            }
        }

        public Double INTEGRA
        {
            get
            {
                return mINTEGRA;
            }
            set
            {
                mINTEGRA = value;
            }
        }

        public Double ISMASTER
        {
            get
            {
                return mISMASTER;
            }
            set
            {
                mISMASTER = value;
            }
        }

        public Boolean LEEFILE
        {
            get
            {
                return mLEEFILE;
            }
            set
            {
                mLEEFILE = value;
            }
        }

        public Double LEYECLAP
        {
            get
            {
                return mLEYECLAP;
            }
            set
            {
                mLEYECLAP = value;
            }
        }

        public string LIC_LICOR
        {
            get
            {
                return mLIC_LICOR;
            }
            set
            {
                mLIC_LICOR = value;
            }
        }

        public Double LINEAFF
        {
            get
            {
                return mLINEAFF;
            }
            set
            {
                mLINEAFF = value;
            }
        }

        public Double LINEAPF
        {
            get
            {
                return mLINEAPF;
            }
            set
            {
                mLINEAPF = value;
            }
        }

        public Double LOYALTY
        {
            get
            {
                return mLOYALTY;
            }
            set
            {
                mLOYALTY = value;
            }
        }

        public Double MARGEN1
        {
            get
            {
                return mMARGEN1;
            }
            set
            {
                mMARGEN1 = value;
            }
        }

        public Double MARGEN1M
        {
            get
            {
                return mMARGEN1M;
            }
            set
            {
                mMARGEN1M = value;
            }
        }

        public Double MARGEN2
        {
            get
            {
                return mMARGEN2;
            }
            set
            {
                mMARGEN2 = value;
            }
        }

        public Double MARGEN2M
        {
            get
            {
                return mMARGEN2M;
            }
            set
            {
                mMARGEN2M = value;
            }
        }

        public Double MARGEN3
        {
            get
            {
                return mMARGEN3;
            }
            set
            {
                mMARGEN3 = value;
            }
        }

        public Double MARGEN3M
        {
            get
            {
                return mMARGEN3M;
            }
            set
            {
                mMARGEN3M = value;
            }
        }

        public Double MARGEN4
        {
            get
            {
                return mMARGEN4;
            }
            set
            {
                mMARGEN4 = value;
            }
        }

        public Double MARGEN4M
        {
            get
            {
                return mMARGEN4M;
            }
            set
            {
                mMARGEN4M = value;
            }
        }

        public string MENSAJEF
        {
            get
            {
                return mMENSAJEF;
            }
            set
            {
                mMENSAJEF = value;
            }
        }

        public Boolean MESAS
        {
            get
            {
                return mMESAS;
            }
            set
            {
                mMESAS = value;
            }
        }

        public Boolean MESONEROS
        {
            get
            {
                return mMESONEROS;
            }
            set
            {
                mMESONEROS = value;
            }
        }

        public Double MISDATOS
        {
            get
            {
                return mMISDATOS;
            }
            set
            {
                mMISDATOS = value;
            }
        }

        public Double MODO_CORTE
        {
            get
            {
                return mMODO_CORTE;
            }
            set
            {
                mMODO_CORTE = value;
            }
        }

        public Double MODO_PREM
        {
            get
            {
                return mMODO_PREM;
            }
            set
            {
                mMODO_PREM = value;
            }
        }

        public Double MOD_ID
        {
            get
            {
                return mMOD_ID;
            }
            set
            {
                mMOD_ID = value;
            }
        }

        public string MONEDA
        {
            get
            {
                return mMONEDA;
            }
            set
            {
                mMONEDA = value;
            }
        }

        public Double MONEDAE
        {
            get
            {
                return mMONEDAE;
            }
            set
            {
                mMONEDAE = value;
            }
        }

        public string MRLOGO
        {
            get
            {
                return mMRLOGO;
            }
            set
            {
                mMRLOGO = value;
            }
        }

        public Double MULTI_TAX
        {
            get
            {
                return mMULTI_TAX;
            }
            set
            {
                mMULTI_TAX = value;
            }
        }

        public Double MVLOGO
        {
            get
            {
                return mMVLOGO;
            }
            set
            {
                mMVLOGO = value;
            }
        }

        public Double NCHECKOF
        {
            get
            {
                return mNCHECKOF;
            }
            set
            {
                mNCHECKOF = value;
            }
        }

        public string NFILEB
        {
            get
            {
                return mNFILEB;
            }
            set
            {
                mNFILEB = value;
            }
        }

        public string NIMP
        {
            get
            {
                return mNIMP;
            }
            set
            {
                mNIMP = value;
            }
        }

        public string NIMP1
        {
            get
            {
                return mNIMP1;
            }
            set
            {
                mNIMP1 = value;
            }
        }

        public string NIMP2
        {
            get
            {
                return mNIMP2;
            }
            set
            {
                mNIMP2 = value;
            }
        }

        public string NIMP3
        {
            get
            {
                return mNIMP3;
            }
            set
            {
                mNIMP3 = value;
            }
        }

        public string NIMP4
        {
            get
            {
                return mNIMP4;
            }
            set
            {
                mNIMP4 = value;
            }
        }

        public string NIMP5
        {
            get
            {
                return mNIMP5;
            }
            set
            {
                mNIMP5 = value;
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

        public string NOMALI
        {
            get
            {
                return mNOMALI;
            }
            set
            {
                mNOMALI = value;
            }
        }

        public string NOMBEBI
        {
            get
            {
                return mNOMBEBI;
            }
            set
            {
                mNOMBEBI = value;
            }
        }

        public Double NOMIDENT
        {
            get
            {
                return mNOMIDENT;
            }
            set
            {
                mNOMIDENT = value;
            }
        }

        public Double NOPRORRA
        {
            get
            {
                return mNOPRORRA;
            }
            set
            {
                mNOPRORRA = value;
            }
        }

        public Double NREFLEIMPF
        {
            get
            {
                return mNREFLEIMPF;
            }
            set
            {
                mNREFLEIMPF = value;
            }
        }

        public Double NREFLEIMPN
        {
            get
            {
                return mNREFLEIMPN;
            }
            set
            {
                mNREFLEIMPN = value;
            }
        }

        public string NROFRAN
        {
            get
            {
                return mNROFRAN;
            }
            set
            {
                mNROFRAN = value;
            }
        }

        public Double NUMFAUNI
        {
            get
            {
                return mNUMFAUNI;
            }
            set
            {
                mNUMFAUNI = value;
            }
        }

        public string N_SUC
        {
            get
            {
                return mN_SUC;
            }
            set
            {
                mN_SUC = value;
            }
        }

        public Double OMITE_CERO
        {
            get
            {
                return mOMITE_CERO;
            }
            set
            {
                mOMITE_CERO = value;
            }
        }

        public Double ON_LINE
        {
            get
            {
                return mON_LINE;
            }
            set
            {
                mON_LINE = value;
            }
        }

        public Double OPC_VENTAS
        {
            get
            {
                return mOPC_VENTAS;
            }
            set
            {
                mOPC_VENTAS = value;
            }
        }

        public string OTROAP
        {
            get
            {
                return mOTROAP;
            }
            set
            {
                mOTROAP = value;
            }
        }

        public Double PAMERICAN
        {
            get
            {
                return mPAMERICAN;
            }
            set
            {
                mPAMERICAN = value;
            }
        }

        public Double PDEBITO
        {
            get
            {
                return mPDEBITO;
            }
            set
            {
                mPDEBITO = value;
            }
        }

        public Double PDINERS
        {
            get
            {
                return mPDINERS;
            }
            set
            {
                mPDINERS = value;
            }
        }

        public Double PDISCOVER
        {
            get
            {
                return mPDISCOVER;
            }
            set
            {
                mPDISCOVER = value;
            }
        }

        public Double PEDIR_FEC
        {
            get
            {
                return mPEDIR_FEC;
            }
            set
            {
                mPEDIR_FEC = value;
            }
        }

        public Boolean PIDECLA
        {
            get
            {
                return mPIDECLA;
            }
            set
            {
                mPIDECLA = value;
            }
        }

        public Boolean PIDEMONTO
        {
            get
            {
                return mPIDEMONTO;
            }
            set
            {
                mPIDEMONTO = value;
            }
        }

        public Double PMASTER
        {
            get
            {
                return mPMASTER;
            }
            set
            {
                mPMASTER = value;
            }
        }

        public Double PORCCOM
        {
            get
            {
                return mPORCCOM;
            }
            set
            {
                mPORCCOM = value;
            }
        }

        public Double POTROS
        {
            get
            {
                return mPOTROS;
            }
            set
            {
                mPOTROS = value;
            }
        }

        public Double PRECIOUL
        {
            get
            {
                return mPRECIOUL;
            }
            set
            {
                mPRECIOUL = value;
            }
        }

        public Double PRECIOUM
        {
            get
            {
                return mPRECIOUM;
            }
            set
            {
                mPRECIOUM = value;
            }
        }

        public Double PRODINT1
        {
            get
            {
                return mPRODINT1;
            }
            set
            {
                mPRODINT1 = value;
            }
        }

        public Double PRODINT2
        {
            get
            {
                return mPRODINT2;
            }
            set
            {
                mPRODINT2 = value;
            }
        }

        public Double PRODNAC1
        {
            get
            {
                return mPRODNAC1;
            }
            set
            {
                mPRODNAC1 = value;
            }
        }

        public Double PRODNAC2
        {
            get
            {
                return mPRODNAC2;
            }
            set
            {
                mPRODNAC2 = value;
            }
        }

        public Double PVISA
        {
            get
            {
                return mPVISA;
            }
            set
            {
                mPVISA = value;
            }
        }

        public Boolean RED
        {
            get
            {
                return mRED;
            }
            set
            {
                mRED = value;
            }
        }

        public Boolean REFLENRO
        {
            get
            {
                return mREFLENRO;
            }
            set
            {
                mREFLENRO = value;
            }
        }

        public Double RETEN
        {
            get
            {
                return mRETEN;
            }
            set
            {
                mRETEN = value;
            }
        }

        public Double REVER_PAG
        {
            get
            {
                return mREVER_PAG;
            }
            set
            {
                mREVER_PAG = value;
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

        public Double SAP_B1
        {
            get
            {
                return mSAP_B1;
            }
            set
            {
                mSAP_B1 = value;
            }
        }

        public Boolean SERBARRA
        {
            get
            {
                return mSERBARRA;
            }
            set
            {
                mSERBARRA = value;
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

        public string SERIAL1
        {
            get
            {
                return mSERIAL1;
            }
            set
            {
                mSERIAL1 = value;
            }
        }

        public string SERIAL2
        {
            get
            {
                return mSERIAL2;
            }
            set
            {
                mSERIAL2 = value;
            }
        }

        public Double SERIALES
        {
            get
            {
                return mSERIALES;
            }
            set
            {
                mSERIALES = value;
            }
        }

        public Double SERVEHI
        {
            get
            {
                return mSERVEHI;
            }
            set
            {
                mSERVEHI = value;
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

        public Double SERVITOTAL
        {
            get
            {
                return mSERVITOTAL;
            }
            set
            {
                mSERVITOTAL = value;
            }
        }

        public Boolean SLIP
        {
            get
            {
                return mSLIP;
            }
            set
            {
                mSLIP = value;
            }
        }

        public Double SOBCOS
        {
            get
            {
                return mSOBCOS;
            }
            set
            {
                mSOBCOS = value;
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

        public Double TIMP
        {
            get
            {
                return mTIMP;
            }
            set
            {
                mTIMP = value;
            }
        }

        public Double TIMPV
        {
            get
            {
                return mTIMPV;
            }
            set
            {
                mTIMPV = value;
            }
        }

        public Double TIMP_DPTO
        {
            get
            {
                return mTIMP_DPTO;
            }
            set
            {
                mTIMP_DPTO = value;
            }
        }

        public Double TIPO_CORTE
        {
            get
            {
                return mTIPO_CORTE;
            }
            set
            {
                mTIPO_CORTE = value;
            }
        }

        public Double TPREAJUSTE
        {
            get
            {
                return mTPREAJUSTE;
            }
            set
            {
                mTPREAJUSTE = value;
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

        public Double VENNEGA
        {
            get
            {
                return mVENNEGA;
            }
            set
            {
                mVENNEGA = value;
            }
        }

        public Double VEN_EMPLE
        {
            get
            {
                return mVEN_EMPLE;
            }
            set
            {
                mVEN_EMPLE = value;
            }
        }

        public Double VERICREDI
        {
            get
            {
                return mVERICREDI;
            }
            set
            {
                mVERICREDI = value;
            }
        }

        public string VER_SIS
        {
            get
            {
                return mVER_SIS;
            }
            set
            {
                mVER_SIS = value;
            }
        }

        public Double VTA_DPTO
        {
            get
            {
                return mVTA_DPTO;
            }
            set
            {
                mVTA_DPTO = value;
            }
        }

        public Double VTA_GRU
        {
            get
            {
                return mVTA_GRU;
            }
            set
            {
                mVTA_GRU = value;
            }
        }

        public Double VTA_PRO
        {
            get
            {
                return mVTA_PRO;
            }
            set
            {
                mVTA_PRO = value;
            }
        }

        public Double WIZARD_PT
        {
            get
            {
                return mWIZARD_PT;
            }
            set
            {
                mWIZARD_PT = value;
            }
        }

        public Double Actpreitem
        {
            get
            {
                return mActpreitem;
            }
            set
            {
                mActpreitem = value;
            }
        }

        public Double Disaplsal
        {
            get
            {
                return mDisaplsal;
            }
            set
            {
                mDisaplsal = value;
            }
        }

        public Double Ncortesal
        {
            get
            {
                return mNcortesal;
            }
            set
            {
                mNcortesal = value;
            }
        }

        public Double Precio1
        {
            get
            {
                return mPrecio1;
            }
            set
            {
                mPrecio1 = value;
            }
        }

        public Double Precio2
        {
            get
            {
                return mPrecio2;
            }
            set
            {
                mPrecio2 = value;
            }
        }

        public Double Precio3
        {
            get
            {
                return mPrecio3;
            }
            set
            {
                mPrecio3 = value;
            }
        }

        public Double Precio4
        {
            get
            {
                return mPrecio4;
            }
            set
            {
                mPrecio4 = value;
            }
        }

        public Double Precio5
        {
            get
            {
                return mPrecio5;
            }
            set
            {
                mPrecio5 = value;
            }
        }

        public Double Precio6
        {
            get
            {
                return mPrecio6;
            }
            set
            {
                mPrecio6 = value;
            }
        }

        public Double Reintentoqbloq
        {
            get
            {
                return mReintentoqbloq;
            }
            set
            {
                mReintentoqbloq = value;
            }
        }

        public Double Statusansw
        {
            get
            {
                return mStatusansw;
            }
            set
            {
                mStatusansw = value;
            }
        }

        public Double Sufijo_cod
        {
            get
            {
                return mSufijo_cod;
            }
            set
            {
                mSufijo_cod = value;
            }
        }

        public string Valdatoscli
        {
            get
            {
                return mValdatoscli;
            }
            set
            {
                mValdatoscli = value;
            }
        }

        DATOS()
        {
        }

        DATOS(bool ACCESO_USU, double ADVCOST, double AEREOP, double ALTERNOS, double ANUSALCLI, double ATIPOCLI, bool AUTOINV, double BASE_MARGE, double BLOFECAC, string BSF, double CAJAPROM, double CAJARIFA, double CAL_UTI, double CAMMON, double CANTIDES, string CEXENTO, string CIVA1, string CIVA2, string CIVA3, double CLAVE1, double CLAVE2, double CLAVE3, double CLIADUA, double CLIASO, double CLICRECE, double CLIMATRI, string CODAEREO, string CODFORMATO, string COD_CARGA, string COLAF, string COMCOD, string COMDES, double CONTROLME, double CONTROLPER, double COPIAS, double CORTE_USU, double DEC, double DECIMALES, double DELFILE, double DEPVENFO, double DET_PAGOS, string DIR1, string DIR2, string DIRFILE, double DIVCALUTI, double DONAVUEL, double ENVIO, string EXTFILE, double FAC_ANU, double FCODCLI, double FRANQ, double FTICKET, double HABLADORES, int ID, bool IDATOS, string IDBAL, double IDIOMA, int IDSUC, double ID_CLI, double IMP, double IMP1, double IMP2, double IMP3, double IMP4, double IMP5, string IMPNOTA, double INTEGRA, double ISMASTER, bool LEEFILE, double LEYECLAP, string LIC_LICOR, double LINEAFF, double LINEAPF, double LOYALTY, double MARGEN1, double MARGEN1M, double MARGEN2, double MARGEN2M, double MARGEN3, double MARGEN3M, double MARGEN4, double MARGEN4M, string MENSAJEF, bool MESAS, bool MESONEROS, double MISDATOS, double MODO_CORTE, double MODO_PREM, double MOD_ID, string MONEDA, double MONEDAE, string MRLOGO, double MULTI_TAX, double MVLOGO, double NCHECKOF, string NFILEB, string NIMP, string NIMP1, string NIMP2, string NIMP3, string NIMP4, string NIMP5, string NIT, string NOMALI, string NOMBEBI, double NOMIDENT, double NOPRORRA, double NREFLEIMPF, double NREFLEIMPN, string NROFRAN, double NUMFAUNI, string N_SUC, double OMITE_CERO, double ON_LINE, double OPC_VENTAS, string OTROAP, double PAMERICAN, double PDEBITO, double PDINERS, double PDISCOVER, double PEDIR_FEC, bool PIDECLA, bool PIDEMONTO, double PMASTER, double PORCCOM, double POTROS, double PRECIOUL, double PRECIOUM, double PRODINT1, double PRODINT2, double PRODNAC1, double PRODNAC2, double PVISA, bool RED, bool REFLENRO, double RETEN, double REVER_PAG, string RIF, double SAP_B1, bool SERBARRA, string SERIAL, string SERIAL1, string SERIAL2, double SERIALES, double SERVEHI, double SERVI, double SERVITOTAL, bool SLIP, double SOBCOS, string TELEFONO, double TIMP, double TIMPV, double TIMP_DPTO, double TIPO_CORTE, double TPREAJUSTE, string UID, double VAL_PUN, double VENNEGA, double VEN_EMPLE, double VERICREDI, string VER_SIS, double VTA_DPTO, double VTA_GRU, double VTA_PRO, double WIZARD_PT, double actpreitem, double disaplsal, double ncortesal, double precio1, double precio2, double precio3, double precio4, double precio5, double precio6, double reintentoqbloq, double statusansw, double sufijo_cod, string valdatoscli)
        {
            mACCESO_USU = ACCESO_USU;
            mADVCOST = ADVCOST;
            mAEREOP = AEREOP;
            mALTERNOS = ALTERNOS;
            mANUSALCLI = ANUSALCLI;
            mATIPOCLI = ATIPOCLI;
            mAUTOINV = AUTOINV;
            mBASE_MARGE = BASE_MARGE;
            mBLOFECAC = BLOFECAC;
            mBSF = BSF;
            mCAJAPROM = CAJAPROM;
            mCAJARIFA = CAJARIFA;
            mCAL_UTI = CAL_UTI;
            mCAMMON = CAMMON;
            mCANTIDES = CANTIDES;
            mCEXENTO = CEXENTO;
            mCIVA1 = CIVA1;
            mCIVA2 = CIVA2;
            mCIVA3 = CIVA3;
            mCLAVE1 = CLAVE1;
            mCLAVE2 = CLAVE2;
            mCLAVE3 = CLAVE3;
            mCLIADUA = CLIADUA;
            mCLIASO = CLIASO;
            mCLICRECE = CLICRECE;
            mCLIMATRI = CLIMATRI;
            mCODAEREO = CODAEREO;
            mCODFORMATO = CODFORMATO;
            mCOD_CARGA = COD_CARGA;
            mCOLAF = COLAF;
            mCOMCOD = COMCOD;
            mCOMDES = COMDES;
            mCONTROLME = CONTROLME;
            mCONTROLPER = CONTROLPER;
            mCOPIAS = COPIAS;
            mCORTE_USU = CORTE_USU;
            mDEC = DEC;
            mDECIMALES = DECIMALES;
            mDELFILE = DELFILE;
            mDEPVENFO = DEPVENFO;
            mDET_PAGOS = DET_PAGOS;
            mDIR1 = DIR1;
            mDIR2 = DIR2;
            mDIRFILE = DIRFILE;
            mDIVCALUTI = DIVCALUTI;
            mDONAVUEL = DONAVUEL;
            mENVIO = ENVIO;
            mEXTFILE = EXTFILE;
            mFAC_ANU = FAC_ANU;
            mFCODCLI = FCODCLI;
            mFRANQ = FRANQ;
            mFTICKET = FTICKET;
            mHABLADORES = HABLADORES;
            mID = ID;
            mIDATOS = IDATOS;
            mIDBAL = IDBAL;
            mIDIOMA = IDIOMA;
            mIDSUC = IDSUC;
            mID_CLI = ID_CLI;
            mIMP = IMP;
            mIMP1 = IMP1;
            mIMP2 = IMP2;
            mIMP3 = IMP3;
            mIMP4 = IMP4;
            mIMP5 = IMP5;
            mIMPNOTA = IMPNOTA;
            mINTEGRA = INTEGRA;
            mISMASTER = ISMASTER;
            mLEEFILE = LEEFILE;
            mLEYECLAP = LEYECLAP;
            mLIC_LICOR = LIC_LICOR;
            mLINEAFF = LINEAFF;
            mLINEAPF = LINEAPF;
            mLOYALTY = LOYALTY;
            mMARGEN1 = MARGEN1;
            mMARGEN1M = MARGEN1M;
            mMARGEN2 = MARGEN2;
            mMARGEN2M = MARGEN2M;
            mMARGEN3 = MARGEN3;
            mMARGEN3M = MARGEN3M;
            mMARGEN4 = MARGEN4;
            mMARGEN4M = MARGEN4M;
            mMENSAJEF = MENSAJEF;
            mMESAS = MESAS;
            mMESONEROS = MESONEROS;
            mMISDATOS = MISDATOS;
            mMODO_CORTE = MODO_CORTE;
            mMODO_PREM = MODO_PREM;
            mMOD_ID = MOD_ID;
            mMONEDA = MONEDA;
            mMONEDAE = MONEDAE;
            mMRLOGO = MRLOGO;
            mMULTI_TAX = MULTI_TAX;
            mMVLOGO = MVLOGO;
            mNCHECKOF = NCHECKOF;
            mNFILEB = NFILEB;
            mNIMP = NIMP;
            mNIMP1 = NIMP1;
            mNIMP2 = NIMP2;
            mNIMP3 = NIMP3;
            mNIMP4 = NIMP4;
            mNIMP5 = NIMP5;
            mNIT = NIT;
            mNOMALI = NOMALI;
            mNOMBEBI = NOMBEBI;
            mNOMIDENT = NOMIDENT;
            mNOPRORRA = NOPRORRA;
            mNREFLEIMPF = NREFLEIMPF;
            mNREFLEIMPN = NREFLEIMPN;
            mNROFRAN = NROFRAN;
            mNUMFAUNI = NUMFAUNI;
            mN_SUC = N_SUC;
            mOMITE_CERO = OMITE_CERO;
            mON_LINE = ON_LINE;
            mOPC_VENTAS = OPC_VENTAS;
            mOTROAP = OTROAP;
            mPAMERICAN = PAMERICAN;
            mPDEBITO = PDEBITO;
            mPDINERS = PDINERS;
            mPDISCOVER = PDISCOVER;
            mPEDIR_FEC = PEDIR_FEC;
            mPIDECLA = PIDECLA;
            mPIDEMONTO = PIDEMONTO;
            mPMASTER = PMASTER;
            mPORCCOM = PORCCOM;
            mPOTROS = POTROS;
            mPRECIOUL = PRECIOUL;
            mPRECIOUM = PRECIOUM;
            mPRODINT1 = PRODINT1;
            mPRODINT2 = PRODINT2;
            mPRODNAC1 = PRODNAC1;
            mPRODNAC2 = PRODNAC2;
            mPVISA = PVISA;
            mRED = RED;
            mREFLENRO = REFLENRO;
            mRETEN = RETEN;
            mREVER_PAG = REVER_PAG;
            mRIF = RIF;
            mSAP_B1 = SAP_B1;
            mSERBARRA = SERBARRA;
            mSERIAL = SERIAL;
            mSERIAL1 = SERIAL1;
            mSERIAL2 = SERIAL2;
            mSERIALES = SERIALES;
            mSERVEHI = SERVEHI;
            mSERVI = SERVI;
            mSERVITOTAL = SERVITOTAL;
            mSLIP = SLIP;
            mSOBCOS = SOBCOS;
            mTELEFONO = TELEFONO;
            mTIMP = TIMP;
            mTIMPV = TIMPV;
            mTIMP_DPTO = TIMP_DPTO;
            mTIPO_CORTE = TIPO_CORTE;
            mTPREAJUSTE = TPREAJUSTE;
            mUID = UID;
            mVAL_PUN = VAL_PUN;
            mVENNEGA = VENNEGA;
            mVEN_EMPLE = VEN_EMPLE;
            mVERICREDI = VERICREDI;
            mVER_SIS = VER_SIS;
            mVTA_DPTO = VTA_DPTO;
            mVTA_GRU = VTA_GRU;
            mVTA_PRO = VTA_PRO;
            mWIZARD_PT = WIZARD_PT;
            mActpreitem = Actpreitem;
            mDisaplsal = Disaplsal;
            mNcortesal = Ncortesal;
            mPrecio1 = Precio1;
            mPrecio2 = Precio2;
            mPrecio3 = Precio3;
            mPrecio4 = Precio4;
            mPrecio5 = Precio5;
            mPrecio6 = Precio6;
            mReintentoqbloq = Reintentoqbloq;
            mStatusansw = Statusansw;
            mSufijo_cod = Sufijo_cod;
            mValdatoscli = Valdatoscli;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
