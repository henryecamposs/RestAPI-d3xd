using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class INVEN : ICloneable
    {

        private string mBARRA = "";
        private double mBASE_MARGE = 0.0;
        private double mBLOQUEO = 0.0;
        private double mBLOQUEOR = 0.0;
        private double mCAL_UTI = 0.0;
        private string mCAMBIO = "";
        private double mCANTIDAD_ = 0.0;
        private double mCARGOS = 0.0;
        private string mCATEGORIA = "";
        private string mCCAJA = "";
        private string mCCANTI = "";
        private string mCCONTABLE = "";
        private string mCCOSTO = "";
        private double mCIFRA = 0.0;
        private string mCINVEN = "";
        private double mCLASE = 0.0;
        private string mCODIGO = "";
        private string mCODIGOC = "";
        private string mCODIGOP = "";
        private string mCOMPACT = "";
        private string mCOMPUESTO = "";
        private string mCONTENIDO = "";
        private string mCONTENIDOU = "";
        private int mCON_SANI = 0;
        private string mCVENTA = "";
        private string mDESCR = "";
        private DateTime mDESDE_O = new DateTime(2000, 01, 01);
        private string mDGRUPO = "";
        private double mDIASV = 0.0;
        private string mDPTO_CAJAS = "";
        private double mFACTOR = 0.0;
        private double mFACTOR1 = 0.0;
        private double mFACTOR2 = 0.0;
        private double mFACTOR3 = 0.0;
        private DateTime mFECHA_M = new DateTime(2000, 01, 01);
        private DateTime mFECHA_R = new DateTime(2000, 01, 01);
        private DateTime mFECHA_V1 = new DateTime(2000, 01, 01);
        private DateTime mFECHA_V2 = new DateTime(2000, 01, 01);
        private string mGDENVASE = "";
        private string mGDESPECI = "";
        private double mGRADOS = 0.0;
        private string mGRUPO = "";
        private double mGUIAS = 0.0;
        private DateTime mHASTA_O = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDSUC = 0;
        private double mIMPR_NOTACONS = 0.0;
        private double mJETAVGAS = 0.0;
        private string mKP = "";
        private double mLICOR = 0.0;
        private double mLOTES = 0.0;
        private double mMARCA = 0.0;
        private string mMARCAP = "";
        private double mMARGEN1 = 0.0;
        private double mMARGEN1M = 0.0;
        private double mMARGEN2 = 0.0;
        private double mMARGEN2M = 0.0;
        private double mMARGEN3 = 0.0;
        private double mMARGEN3M = 0.0;
        private double mMARGEN4 = 0.0;
        private double mMARGEN4M = 0.0;
        private double mMAX = 0.0;
        private double mMAXMONTO = 0.0;
        private double mMIN = 0.0;
        private double mMODO_PRE = 0.0;
        private double mMONCARGA = 0.0;
        private double mNCON_EXIS = 0.0;
        private string mNOMBRE = "";
        private double mNVENNEGA = 0.0;
        private string mOBSERVA = "";
        private string mOPERADOR = "";
        private double mPBALANZA = 0.0;
        private double mPESO = 0.0;
        private double mPESO_UND = 0.0;
        private double mPIDECANTI = 0.0;
        private double mPIDEOBSE = 0.0;
        private double mPIDEPRE = 0.0;
        private double mPRECIO = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO1M = 0.0;
        private double mPRECIO1_E = 0.0;
        private double mPRECIO1_O = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO2M = 0.0;
        private double mPRECIO2_E = 0.0;
        private double mPRECIO2_O = 0.0;
        private double mPRECIO3 = 0.0;
        private double mPRECIO3M = 0.0;
        private double mPRECIO3_O = 0.0;
        private double mPRECIOM = 0.0;
        private double mPRECIO_CAN = 0.0;
        private double mPRECIO_E = 0.0;
        private double mPRECIO_O = 0.0;
        private double mPRE_CANT = 0.0;
        private double mPROMEDIO = 0.0;
        private string mPROMO = "";
        private string mPROMO2 = "";
        private string mPROMO3 = "";
        private string mPROVEE = "";
        private double mPUNTOS = 0.0;
        private string mREFE = "";
        private double mREGULADO = 0.0;
        private double mSERIAL = 0.0;
        private double mSERVI = 0.0;
        private double mSERVIBP = 0.0;
        private double mSOLOENT = 0.0;
        private string mTCOS1 = "";
        private string mTCOS2 = "";
        private string mTIPO = "";
        private double mTIPOFAR = 0.0;
        private double mTIPOO = 0.0;
        private double mTIPOP = 0.0;
        private double mTIPO_LICOR = 0.0;
        private double mTIVA = 0.0;
        private double mTIVA2 = 0.0;
        private double mTOPERA = 0.0;
        private double mTPESO = 0.0;
        private double mTROQUELA = 0.0;
        private string mULTIMAU = "";
        private double mULTIMO = 0.0;
        private DateTime mULT_ACTU = new DateTime(2000, 01, 01);
        private DateTime mULT_COMPRA = new DateTime(2000, 01, 01);
        private DateTime mULT_VENTA = new DateTime(2000, 01, 01);
        private string mUND_MEDIDA = "";
        private double mUNIDAD = 0.0;
        private string mUNIDADC = "";
        private double mUNIDADE = 0.0;
        private string mUNIDADV = "";
        private double mUNIDADVC = 0.0;

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

        public Double BLOQUEO
        {
            get
            {
                return mBLOQUEO;
            }
            set
            {
                mBLOQUEO = value;
            }
        }

        public Double BLOQUEOR
        {
            get
            {
                return mBLOQUEOR;
            }
            set
            {
                mBLOQUEOR = value;
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

        public string CAMBIO
        {
            get
            {
                return mCAMBIO;
            }
            set
            {
                mCAMBIO = value;
            }
        }

        public Double CANTIDAD_
        {
            get
            {
                return mCANTIDAD_;
            }
            set
            {
                mCANTIDAD_ = value;
            }
        }

        public Double CARGOS
        {
            get
            {
                return mCARGOS;
            }
            set
            {
                mCARGOS = value;
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

        public string CCAJA
        {
            get
            {
                return mCCAJA;
            }
            set
            {
                mCCAJA = value;
            }
        }

        public string CCANTI
        {
            get
            {
                return mCCANTI;
            }
            set
            {
                mCCANTI = value;
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

        public string CCOSTO
        {
            get
            {
                return mCCOSTO;
            }
            set
            {
                mCCOSTO = value;
            }
        }

        public Double CIFRA
        {
            get
            {
                return mCIFRA;
            }
            set
            {
                mCIFRA = value;
            }
        }

        public string CINVEN
        {
            get
            {
                return mCINVEN;
            }
            set
            {
                mCINVEN = value;
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

        public string CODIGOC
        {
            get
            {
                return mCODIGOC;
            }
            set
            {
                mCODIGOC = value;
            }
        }

        public string CODIGOP
        {
            get
            {
                return mCODIGOP;
            }
            set
            {
                mCODIGOP = value;
            }
        }

        public string COMPACT
        {
            get
            {
                return mCOMPACT;
            }
            set
            {
                mCOMPACT = value;
            }
        }

        public string COMPUESTO
        {
            get
            {
                return mCOMPUESTO;
            }
            set
            {
                mCOMPUESTO = value;
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

        public string CONTENIDOU
        {
            get
            {
                return mCONTENIDOU;
            }
            set
            {
                mCONTENIDOU = value;
            }
        }

        public int CON_SANI
        {
            get
            {
                return mCON_SANI;
            }
            set
            {
                mCON_SANI = value;
            }
        }

        public string CVENTA
        {
            get
            {
                return mCVENTA;
            }
            set
            {
                mCVENTA = value;
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

        public DateTime DESDE_O
        {
            get
            {
                return mDESDE_O;
            }
            set
            {
                mDESDE_O = value;
            }
        }

        public string DGRUPO
        {
            get
            {
                return mDGRUPO;
            }
            set
            {
                mDGRUPO = value;
            }
        }

        public Double DIASV
        {
            get
            {
                return mDIASV;
            }
            set
            {
                mDIASV = value;
            }
        }

        public string DPTO_CAJAS
        {
            get
            {
                return mDPTO_CAJAS;
            }
            set
            {
                mDPTO_CAJAS = value;
            }
        }

        public Double FACTOR
        {
            get
            {
                return mFACTOR;
            }
            set
            {
                mFACTOR = value;
            }
        }

        public Double FACTOR1
        {
            get
            {
                return mFACTOR1;
            }
            set
            {
                mFACTOR1 = value;
            }
        }

        public Double FACTOR2
        {
            get
            {
                return mFACTOR2;
            }
            set
            {
                mFACTOR2 = value;
            }
        }

        public Double FACTOR3
        {
            get
            {
                return mFACTOR3;
            }
            set
            {
                mFACTOR3 = value;
            }
        }

        public DateTime FECHA_M
        {
            get
            {
                return mFECHA_M;
            }
            set
            {
                mFECHA_M = value;
            }
        }

        public DateTime FECHA_R
        {
            get
            {
                return mFECHA_R;
            }
            set
            {
                mFECHA_R = value;
            }
        }

        public DateTime FECHA_V1
        {
            get
            {
                return mFECHA_V1;
            }
            set
            {
                mFECHA_V1 = value;
            }
        }

        public DateTime FECHA_V2
        {
            get
            {
                return mFECHA_V2;
            }
            set
            {
                mFECHA_V2 = value;
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

        public Double GUIAS
        {
            get
            {
                return mGUIAS;
            }
            set
            {
                mGUIAS = value;
            }
        }

        public DateTime HASTA_O
        {
            get
            {
                return mHASTA_O;
            }
            set
            {
                mHASTA_O = value;
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

        public Double IMPR_NOTACONS
        {
            get
            {
                return mIMPR_NOTACONS;
            }
            set
            {
                mIMPR_NOTACONS = value;
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

        public Double LOTES
        {
            get
            {
                return mLOTES;
            }
            set
            {
                mLOTES = value;
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

        public string MARCAP
        {
            get
            {
                return mMARCAP;
            }
            set
            {
                mMARCAP = value;
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

        public Double MAX
        {
            get
            {
                return mMAX;
            }
            set
            {
                mMAX = value;
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

        public Double MIN
        {
            get
            {
                return mMIN;
            }
            set
            {
                mMIN = value;
            }
        }

        public Double MODO_PRE
        {
            get
            {
                return mMODO_PRE;
            }
            set
            {
                mMODO_PRE = value;
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

        public Double NCON_EXIS
        {
            get
            {
                return mNCON_EXIS;
            }
            set
            {
                mNCON_EXIS = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double NVENNEGA
        {
            get
            {
                return mNVENNEGA;
            }
            set
            {
                mNVENNEGA = value;
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

        public Double PBALANZA
        {
            get
            {
                return mPBALANZA;
            }
            set
            {
                mPBALANZA = value;
            }
        }

        public Double PESO
        {
            get
            {
                return mPESO;
            }
            set
            {
                mPESO = value;
            }
        }

        public Double PESO_UND
        {
            get
            {
                return mPESO_UND;
            }
            set
            {
                mPESO_UND = value;
            }
        }

        public Double PIDECANTI
        {
            get
            {
                return mPIDECANTI;
            }
            set
            {
                mPIDECANTI = value;
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

        public Double PIDEPRE
        {
            get
            {
                return mPIDEPRE;
            }
            set
            {
                mPIDEPRE = value;
            }
        }

        public Double PRECIO
        {
            get
            {
                return mPRECIO;
            }
            set
            {
                mPRECIO = value;
            }
        }

        public Double PRECIO1
        {
            get
            {
                return mPRECIO1;
            }
            set
            {
                mPRECIO1 = value;
            }
        }

        public Double PRECIO1M
        {
            get
            {
                return mPRECIO1M;
            }
            set
            {
                mPRECIO1M = value;
            }
        }

        public Double PRECIO1_E
        {
            get
            {
                return mPRECIO1_E;
            }
            set
            {
                mPRECIO1_E = value;
            }
        }

        public Double PRECIO1_O
        {
            get
            {
                return mPRECIO1_O;
            }
            set
            {
                mPRECIO1_O = value;
            }
        }

        public Double PRECIO2
        {
            get
            {
                return mPRECIO2;
            }
            set
            {
                mPRECIO2 = value;
            }
        }

        public Double PRECIO2M
        {
            get
            {
                return mPRECIO2M;
            }
            set
            {
                mPRECIO2M = value;
            }
        }

        public Double PRECIO2_E
        {
            get
            {
                return mPRECIO2_E;
            }
            set
            {
                mPRECIO2_E = value;
            }
        }

        public Double PRECIO2_O
        {
            get
            {
                return mPRECIO2_O;
            }
            set
            {
                mPRECIO2_O = value;
            }
        }

        public Double PRECIO3
        {
            get
            {
                return mPRECIO3;
            }
            set
            {
                mPRECIO3 = value;
            }
        }

        public Double PRECIO3M
        {
            get
            {
                return mPRECIO3M;
            }
            set
            {
                mPRECIO3M = value;
            }
        }

        public Double PRECIO3_O
        {
            get
            {
                return mPRECIO3_O;
            }
            set
            {
                mPRECIO3_O = value;
            }
        }

        public Double PRECIOM
        {
            get
            {
                return mPRECIOM;
            }
            set
            {
                mPRECIOM = value;
            }
        }

        public Double PRECIO_CAN
        {
            get
            {
                return mPRECIO_CAN;
            }
            set
            {
                mPRECIO_CAN = value;
            }
        }

        public Double PRECIO_E
        {
            get
            {
                return mPRECIO_E;
            }
            set
            {
                mPRECIO_E = value;
            }
        }

        public Double PRECIO_O
        {
            get
            {
                return mPRECIO_O;
            }
            set
            {
                mPRECIO_O = value;
            }
        }

        public Double PRE_CANT
        {
            get
            {
                return mPRE_CANT;
            }
            set
            {
                mPRE_CANT = value;
            }
        }

        public Double PROMEDIO
        {
            get
            {
                return mPROMEDIO;
            }
            set
            {
                mPROMEDIO = value;
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

        public string PROMO2
        {
            get
            {
                return mPROMO2;
            }
            set
            {
                mPROMO2 = value;
            }
        }

        public string PROMO3
        {
            get
            {
                return mPROMO3;
            }
            set
            {
                mPROMO3 = value;
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

        public Double PUNTOS
        {
            get
            {
                return mPUNTOS;
            }
            set
            {
                mPUNTOS = value;
            }
        }

        public string REFE
        {
            get
            {
                return mREFE;
            }
            set
            {
                mREFE = value;
            }
        }

        public Double REGULADO
        {
            get
            {
                return mREGULADO;
            }
            set
            {
                mREGULADO = value;
            }
        }

        public Double SERIAL
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

        public Double SOLOENT
        {
            get
            {
                return mSOLOENT;
            }
            set
            {
                mSOLOENT = value;
            }
        }

        public string TCOS1
        {
            get
            {
                return mTCOS1;
            }
            set
            {
                mTCOS1 = value;
            }
        }

        public string TCOS2
        {
            get
            {
                return mTCOS2;
            }
            set
            {
                mTCOS2 = value;
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

        public Double TIPOFAR
        {
            get
            {
                return mTIPOFAR;
            }
            set
            {
                mTIPOFAR = value;
            }
        }

        public Double TIPOO
        {
            get
            {
                return mTIPOO;
            }
            set
            {
                mTIPOO = value;
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

        public Double TOPERA
        {
            get
            {
                return mTOPERA;
            }
            set
            {
                mTOPERA = value;
            }
        }

        public Double TPESO
        {
            get
            {
                return mTPESO;
            }
            set
            {
                mTPESO = value;
            }
        }

        public Double TROQUELA
        {
            get
            {
                return mTROQUELA;
            }
            set
            {
                mTROQUELA = value;
            }
        }

        public string ULTIMAU
        {
            get
            {
                return mULTIMAU;
            }
            set
            {
                mULTIMAU = value;
            }
        }

        public Double ULTIMO
        {
            get
            {
                return mULTIMO;
            }
            set
            {
                mULTIMO = value;
            }
        }

        public DateTime ULT_ACTU
        {
            get
            {
                return mULT_ACTU;
            }
            set
            {
                mULT_ACTU = value;
            }
        }

        public DateTime ULT_COMPRA
        {
            get
            {
                return mULT_COMPRA;
            }
            set
            {
                mULT_COMPRA = value;
            }
        }

        public DateTime ULT_VENTA
        {
            get
            {
                return mULT_VENTA;
            }
            set
            {
                mULT_VENTA = value;
            }
        }

        public string UND_MEDIDA
        {
            get
            {
                return mUND_MEDIDA;
            }
            set
            {
                mUND_MEDIDA = value;
            }
        }

        public Double UNIDAD
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

        public string UNIDADC
        {
            get
            {
                return mUNIDADC;
            }
            set
            {
                mUNIDADC = value;
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

        public string UNIDADV
        {
            get
            {
                return mUNIDADV;
            }
            set
            {
                mUNIDADV = value;
            }
        }

        public Double UNIDADVC
        {
            get
            {
                return mUNIDADVC;
            }
            set
            {
                mUNIDADVC = value;
            }
        }

        public INVEN()
        {
        }

        INVEN(string BARRA, double BASE_MARGE, double BLOQUEO, double BLOQUEOR, double CAL_UTI, string CAMBIO, double CANTIDAD_, double CARGOS, string CATEGORIA, string CCAJA, string CCANTI, string CCONTABLE, string CCOSTO, double CIFRA, string CINVEN, double CLASE, string CODIGO, string CODIGOC, string CODIGOP, string COMPACT, string COMPUESTO, string CONTENIDO, string CONTENIDOU, int CON_SANI, string CVENTA, string DESCR, DateTime DESDE_O, string DGRUPO, double DIASV, string DPTO_CAJAS, double FACTOR, double FACTOR1, double FACTOR2, double FACTOR3, DateTime FECHA_M, DateTime FECHA_R, DateTime FECHA_V1, DateTime FECHA_V2, string GDENVASE, string GDESPECI, double GRADOS, string GRUPO, double GUIAS, DateTime HASTA_O, int ID, int IDSUC, double IMPR_NOTACONS, double JETAVGAS, string KP, double LICOR, double LOTES, double MARCA, string MARCAP, double MARGEN1, double MARGEN1M, double MARGEN2, double MARGEN2M, double MARGEN3, double MARGEN3M, double MARGEN4, double MARGEN4M, double MAX, double MAXMONTO, double MIN, double MODO_PRE, double MONCARGA, double NCON_EXIS, string NOMBRE, double NVENNEGA, string OBSERVA, string OPERADOR, double PBALANZA, double PESO, double PESO_UND, double PIDECANTI, double PIDEOBSE, double PIDEPRE, double PRECIO, double PRECIO1, double PRECIO1M, double PRECIO1_E, double PRECIO1_O, double PRECIO2, double PRECIO2M, double PRECIO2_E, double PRECIO2_O, double PRECIO3, double PRECIO3M, double PRECIO3_O, double PRECIOM, double PRECIO_CAN, double PRECIO_E, double PRECIO_O, double PRE_CANT, double PROMEDIO, string PROMO, string PROMO2, string PROMO3, string PROVEE, double PUNTOS, string REFE, double REGULADO, double SERIAL, double SERVI, double SERVIBP, double SOLOENT, string TCOS1, string TCOS2, string TIPO, double TIPOFAR, double TIPOO, double TIPOP, double TIPO_LICOR, double TIVA, double TIVA2, double TOPERA, double TPESO, double TROQUELA, string ULTIMAU, double ULTIMO, DateTime ULT_ACTU, DateTime ULT_COMPRA, DateTime ULT_VENTA, string UND_MEDIDA, double UNIDAD, string UNIDADC, double UNIDADE, string UNIDADV, double UNIDADVC)
        {
            mBARRA = BARRA;
            mBASE_MARGE = BASE_MARGE;
            mBLOQUEO = BLOQUEO;
            mBLOQUEOR = BLOQUEOR;
            mCAL_UTI = CAL_UTI;
            mCAMBIO = CAMBIO;
            mCANTIDAD_ = CANTIDAD_;
            mCARGOS = CARGOS;
            mCATEGORIA = CATEGORIA;
            mCCAJA = CCAJA;
            mCCANTI = CCANTI;
            mCCONTABLE = CCONTABLE;
            mCCOSTO = CCOSTO;
            mCIFRA = CIFRA;
            mCINVEN = CINVEN;
            mCLASE = CLASE;
            mCODIGO = CODIGO;
            mCODIGOC = CODIGOC;
            mCODIGOP = CODIGOP;
            mCOMPACT = COMPACT;
            mCOMPUESTO = COMPUESTO;
            mCONTENIDO = CONTENIDO;
            mCONTENIDOU = CONTENIDOU;
            mCON_SANI = CON_SANI;
            mCVENTA = CVENTA;
            mDESCR = DESCR;
            mDESDE_O = DESDE_O;
            mDGRUPO = DGRUPO;
            mDIASV = DIASV;
            mDPTO_CAJAS = DPTO_CAJAS;
            mFACTOR = FACTOR;
            mFACTOR1 = FACTOR1;
            mFACTOR2 = FACTOR2;
            mFACTOR3 = FACTOR3;
            mFECHA_M = FECHA_M;
            mFECHA_R = FECHA_R;
            mFECHA_V1 = FECHA_V1;
            mFECHA_V2 = FECHA_V2;
            mGDENVASE = GDENVASE;
            mGDESPECI = GDESPECI;
            mGRADOS = GRADOS;
            mGRUPO = GRUPO;
            mGUIAS = GUIAS;
            mHASTA_O = HASTA_O;
            mID = ID;
            mIDSUC = IDSUC;
            mIMPR_NOTACONS = IMPR_NOTACONS;
            mJETAVGAS = JETAVGAS;
            mKP = KP;
            mLICOR = LICOR;
            mLOTES = LOTES;
            mMARCA = MARCA;
            mMARCAP = MARCAP;
            mMARGEN1 = MARGEN1;
            mMARGEN1M = MARGEN1M;
            mMARGEN2 = MARGEN2;
            mMARGEN2M = MARGEN2M;
            mMARGEN3 = MARGEN3;
            mMARGEN3M = MARGEN3M;
            mMARGEN4 = MARGEN4;
            mMARGEN4M = MARGEN4M;
            mMAX = MAX;
            mMAXMONTO = MAXMONTO;
            mMIN = MIN;
            mMODO_PRE = MODO_PRE;
            mMONCARGA = MONCARGA;
            mNCON_EXIS = NCON_EXIS;
            mNOMBRE = NOMBRE;
            mNVENNEGA = NVENNEGA;
            mOBSERVA = OBSERVA;
            mOPERADOR = OPERADOR;
            mPBALANZA = PBALANZA;
            mPESO = PESO;
            mPESO_UND = PESO_UND;
            mPIDECANTI = PIDECANTI;
            mPIDEOBSE = PIDEOBSE;
            mPIDEPRE = PIDEPRE;
            mPRECIO = PRECIO;
            mPRECIO1 = PRECIO1;
            mPRECIO1M = PRECIO1M;
            mPRECIO1_E = PRECIO1_E;
            mPRECIO1_O = PRECIO1_O;
            mPRECIO2 = PRECIO2;
            mPRECIO2M = PRECIO2M;
            mPRECIO2_E = PRECIO2_E;
            mPRECIO2_O = PRECIO2_O;
            mPRECIO3 = PRECIO3;
            mPRECIO3M = PRECIO3M;
            mPRECIO3_O = PRECIO3_O;
            mPRECIOM = PRECIOM;
            mPRECIO_CAN = PRECIO_CAN;
            mPRECIO_E = PRECIO_E;
            mPRECIO_O = PRECIO_O;
            mPRE_CANT = PRE_CANT;
            mPROMEDIO = PROMEDIO;
            mPROMO = PROMO;
            mPROMO2 = PROMO2;
            mPROMO3 = PROMO3;
            mPROVEE = PROVEE;
            mPUNTOS = PUNTOS;
            mREFE = REFE;
            mREGULADO = REGULADO;
            mSERIAL = SERIAL;
            mSERVI = SERVI;
            mSERVIBP = SERVIBP;
            mSOLOENT = SOLOENT;
            mTCOS1 = TCOS1;
            mTCOS2 = TCOS2;
            mTIPO = TIPO;
            mTIPOFAR = TIPOFAR;
            mTIPOO = TIPOO;
            mTIPOP = TIPOP;
            mTIPO_LICOR = TIPO_LICOR;
            mTIVA = TIVA;
            mTIVA2 = TIVA2;
            mTOPERA = TOPERA;
            mTPESO = TPESO;
            mTROQUELA = TROQUELA;
            mULTIMAU = ULTIMAU;
            mULTIMO = ULTIMO;
            mULT_ACTU = ULT_ACTU;
            mULT_COMPRA = ULT_COMPRA;
            mULT_VENTA = ULT_VENTA;
            mUND_MEDIDA = UND_MEDIDA;
            mUNIDAD = UNIDAD;
            mUNIDADC = UNIDADC;
            mUNIDADE = UNIDADE;
            mUNIDADV = UNIDADV;
            mUNIDADVC = UNIDADVC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
