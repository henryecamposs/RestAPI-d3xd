using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ITEMS : ICloneable
    {

        private double mABONO = 0.0;
        private double mACTUAL = 0.0;
        private double mANULADO = 0.0;
        private string mBANCO1 = "";
        private string mBANCO2 = "";
        private string mBANCO3 = "";
        private string mBANCO4 = "";
        private string mBANCO5 = "";
        private string mBANCO6 = "";
        private string mBANCO7 = "";
        private string mBANCO8 = "";
        private double mBASE1 = 0.0;
        private double mBASE2 = 0.0;
        private double mBASE3 = 0.0;
        private double mBONOD = 0.0;
        private string mCAJA = "";
        private string mCAJAD = "";
        private string mCAJADEV = "";
        private string mCALLE = "";
        private double mCANCELADO = 0.0;
        private double mCANTI = 0.0;
        private double mCANTIELIM = 0.0;
        private string mCASA = "";
        private string mCBANCO1 = "";
        private string mCBANCO2 = "";
        private string mCBANCO3 = "";
        private string mCBANCO4 = "";
        private string mCBANCO5 = "";
        private string mCBANCO6 = "";
        private string mCBANCO7 = "";
        private string mCBANCO8 = "";
        private string mCCONTABLE = "";
        private string mCDESCU = "";
        private string mCEDU1 = "";
        private string mCEDU2 = "";
        private string mCEDU3 = "";
        private string mCEDU4 = "";
        private string mCEDU5 = "";
        private string mCEDU6 = "";
        private string mCEDU7 = "";
        private string mCEDU8 = "";
        private double mCFISCAL = 0.0;
        private double mCFISCALD = 0.0;
        private double mCHEQUE1 = 0.0;
        private double mCHEQUE2 = 0.0;
        private double mCHEQUE3 = 0.0;
        private double mCHEQUE4 = 0.0;
        private double mCHEQUE5 = 0.0;
        private double mCHEQUE6 = 0.0;
        private double mCHEQUE7 = 0.0;
        private double mCHEQUE8 = 0.0;
        private string mCISTER = "";
        private string mCIUDAD = "";
        private int mCLIENTE = 0;
        private string mCMATRICU = "";
        private int mCODCLI = 0;
        private string mCODENC = "";
        private string mCODE_BAR = "";
        private string mCODIGOBP = "";
        private double mCODMON1 = 0.0;
        private double mCODMON2 = 0.0;
        private double mCODMON3 = 0.0;
        private double mCODMON4 = 0.0;
        private double mCODMON5 = 0.0;
        private double mCODMON6 = 0.0;
        private double mCODMON7 = 0.0;
        private double mCODMON8 = 0.0;
        private string mCODPEDIDO = "";
        private double mCOD_VAL1 = 0.0;
        private double mCOD_VAL2 = 0.0;
        private double mCOD_VAL3 = 0.0;
        private double mCOD_VAL4 = 0.0;
        private double mCOD_VAL5 = 0.0;
        private double mCOD_VAL6 = 0.0;
        private double mCOD_VAL7 = 0.0;
        private double mCOD_VAL8 = 0.0;
        private double mCOMICOB = 0.0;
        private double mCOMIVEN = 0.0;
        private double mCOMIVENTA = 0.0;
        private double mCONTRI = 0.0;
        private double mCOSTOP = 0.0;
        private double mCOSTOU = 0.0;
        private string mCSECCION = "";
        private string mCTP1 = "";
        private string mCTP2 = "";
        private string mCTP3 = "";
        private string mCTP4 = "";
        private string mCTP5 = "";
        private string mCTP6 = "";
        private string mCTP7 = "";
        private string mCTP8 = "";
        private string mDDESCU = "";
        private double mDESCU = 0.0;
        private double mDESCUT = 0.0;
        private double mDESC_TAR = 0.0;
        private double mDIASCRE = 0.0;
        private string mDIRECCION = "";
        private string mEMAIL = "";
        private string mEMISOR1 = "";
        private string mEMISOR2 = "";
        private string mEMISOR3 = "";
        private string mEMISOR4 = "";
        private string mEMISOR5 = "";
        private string mEMISOR6 = "";
        private string mEMISOR7 = "";
        private string mEMISOR8 = "";
        private string mEMPLE = "";
        private string mEMPLEC = "";
        private string mESTADO = "";
        private double mESTATUS = 0.0;
        private double mESTATUSR = 0.0;
        private double mEXENTO = 0.0;
        private string mEXPIRA1 = "";
        private string mEXPIRA2 = "";
        private string mEXPIRA3 = "";
        private string mEXPIRA4 = "";
        private string mEXPIRA5 = "";
        private string mEXPIRA6 = "";
        private string mEXPIRA7 = "";
        private string mEXPIRA8 = "";
        private double mFDESCU = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private double mGUIA_DESPA = 0.0;
        private string mHORA = "";
        private string mHORAA = "";
        private string mHORAC = "";
        private int mID = 0;
        private string mID1 = "";
        private string mID2 = "";
        private string mID3 = "";
        private string mID4 = "";
        private string mID5 = "";
        private string mID6 = "";
        private string mID7 = "";
        private string mID8 = "";
        private int mIDCIUDAD = 0;
        private int mIDCLIASO = 0;
        private int mIDDIRCENT = 0;
        private int mIDESTADO = 0;
        private int mIDPAIS = 0;
        private int mIDSUC = 0;
        private int mIDTERPAG = 0;
        private int mID_REFE = 0;
        private string mISLA = "";
        private double mIVA = 0.0;
        private double mIVA1 = 0.0;
        private double mIVA2 = 0.0;
        private double mIVA3 = 0.0;
        private string mLICENCIA = "";
        private double mM1 = 0.0;
        private double mM2 = 0.0;
        private double mM3 = 0.0;
        private double mM4 = 0.0;
        private double mM5 = 0.0;
        private double mM6 = 0.0;
        private double mM7 = 0.0;
        private double mM8 = 0.0;
        private string mMAQFIS = "";
        private string mMAQFISDE = "";
        private string mMESA = "";
        private string mMODULO = "";
        private double mMONTO = 0.0;
        private double mMONTOD = 0.0;
        private double mMON_CONV1 = 0.0;
        private double mMON_CONV2 = 0.0;
        private double mMON_CONV3 = 0.0;
        private double mMON_CONV4 = 0.0;
        private double mMON_CONV5 = 0.0;
        private double mMON_CONV6 = 0.0;
        private double mMON_CONV7 = 0.0;
        private double mMON_CONV8 = 0.0;
        private string mNIT = "";
        private string mNMESA = "";
        private string mNOMCLI = "";
        private string mNOMEMP = "";
        private string mNOMEMPC = "";
        private double mNRO = 0.0;
        private string mNROCASA = "";
        private double mNRODEV = 0.0;
        private double mN_PUN = 0.0;
        private double mPBONOD = 0.0;
        private double mPDESCU = 0.0;
        private double mPDESCUB = 0.0;
        private double mPEDIDO = 0.0;
        private double mPORCD = 0.0;
        private double mPROPI1 = 0.0;
        private double mPROPI2 = 0.0;
        private double mPROPI3 = 0.0;
        private double mPROPI4 = 0.0;
        private double mPROPI5 = 0.0;
        private double mPROPI6 = 0.0;
        private double mPROPI7 = 0.0;
        private double mPROPI8 = 0.0;
        private double mPROPINA = 0.0;
        private double mPT1 = 0.0;
        private double mPT2 = 0.0;
        private double mPT3 = 0.0;
        private double mPT4 = 0.0;
        private double mPT5 = 0.0;
        private double mPT6 = 0.0;
        private double mPT7 = 0.0;
        private double mPT8 = 0.0;
        private double mRECARGO = 0.0;
        private double mRECIBIDO = 0.0;
        private string mREFERENCIA = "";
        private string mRIF = "";
        private string mSECCION = "";
        private double mSERVICIO = 0.0;
        private double mSESION = 0.0;
        private double mT1 = 0.0;
        private double mTAX1 = 0.0;
        private double mTAX2 = 0.0;
        private double mTAX3 = 0.0;
        private double mTDESCU = 0.0;
        private double mTDESTINO = 0.0;
        private string mTELE1 = "";
        private string mTELE2 = "";
        private string mTELE3 = "";
        private string mTELE4 = "";
        private string mTELE5 = "";
        private string mTELE6 = "";
        private string mTELE7 = "";
        private string mTELE8 = "";
        private string mTELEFONO = "";
        private string mTIPO = "";
        private double mTIPOD = 0.0;
        private double mTOTAL = 0.0;
        private string mTP1 = "";
        private string mTP2 = "";
        private string mTP3 = "";
        private string mTP4 = "";
        private string mTP5 = "";
        private string mTP6 = "";
        private string mTP7 = "";
        private string mTP8 = "";
        private string mTPAGO = "";
        private double mTPRECIO = 0.0;
        private string mUID = "";
        private string mUIDCLIMOV = "";
        private string mURB = "";
        private double mVAUCHE1 = 0.0;
        private double mVAUCHE2 = 0.0;
        private double mVAUCHE3 = 0.0;
        private double mVAUCHE4 = 0.0;
        private double mVAUCHE5 = 0.0;
        private double mVAUCHE6 = 0.0;
        private double mVAUCHE7 = 0.0;
        private double mVAUCHE8 = 0.0;
        private string mVENDEDOR = "";
        private double mVERIFI = 0.0;
        private string mZONA = "";
        private double mModonc = 0.0;
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

        public Double ACTUAL
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

        public Double ANULADO
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

        public string BANCO1
        {
            get
            {
                return mBANCO1;
            }
            set
            {
                mBANCO1 = value;
            }
        }

        public string BANCO2
        {
            get
            {
                return mBANCO2;
            }
            set
            {
                mBANCO2 = value;
            }
        }

        public string BANCO3
        {
            get
            {
                return mBANCO3;
            }
            set
            {
                mBANCO3 = value;
            }
        }

        public string BANCO4
        {
            get
            {
                return mBANCO4;
            }
            set
            {
                mBANCO4 = value;
            }
        }

        public string BANCO5
        {
            get
            {
                return mBANCO5;
            }
            set
            {
                mBANCO5 = value;
            }
        }

        public string BANCO6
        {
            get
            {
                return mBANCO6;
            }
            set
            {
                mBANCO6 = value;
            }
        }

        public string BANCO7
        {
            get
            {
                return mBANCO7;
            }
            set
            {
                mBANCO7 = value;
            }
        }

        public string BANCO8
        {
            get
            {
                return mBANCO8;
            }
            set
            {
                mBANCO8 = value;
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

        public string CAJAD
        {
            get
            {
                return mCAJAD;
            }
            set
            {
                mCAJAD = value;
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

        public string CALLE
        {
            get
            {
                return mCALLE;
            }
            set
            {
                mCALLE = value;
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

        public string CASA
        {
            get
            {
                return mCASA;
            }
            set
            {
                mCASA = value;
            }
        }

        public string CBANCO1
        {
            get
            {
                return mCBANCO1;
            }
            set
            {
                mCBANCO1 = value;
            }
        }

        public string CBANCO2
        {
            get
            {
                return mCBANCO2;
            }
            set
            {
                mCBANCO2 = value;
            }
        }

        public string CBANCO3
        {
            get
            {
                return mCBANCO3;
            }
            set
            {
                mCBANCO3 = value;
            }
        }

        public string CBANCO4
        {
            get
            {
                return mCBANCO4;
            }
            set
            {
                mCBANCO4 = value;
            }
        }

        public string CBANCO5
        {
            get
            {
                return mCBANCO5;
            }
            set
            {
                mCBANCO5 = value;
            }
        }

        public string CBANCO6
        {
            get
            {
                return mCBANCO6;
            }
            set
            {
                mCBANCO6 = value;
            }
        }

        public string CBANCO7
        {
            get
            {
                return mCBANCO7;
            }
            set
            {
                mCBANCO7 = value;
            }
        }

        public string CBANCO8
        {
            get
            {
                return mCBANCO8;
            }
            set
            {
                mCBANCO8 = value;
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

        public string CEDU1
        {
            get
            {
                return mCEDU1;
            }
            set
            {
                mCEDU1 = value;
            }
        }

        public string CEDU2
        {
            get
            {
                return mCEDU2;
            }
            set
            {
                mCEDU2 = value;
            }
        }

        public string CEDU3
        {
            get
            {
                return mCEDU3;
            }
            set
            {
                mCEDU3 = value;
            }
        }

        public string CEDU4
        {
            get
            {
                return mCEDU4;
            }
            set
            {
                mCEDU4 = value;
            }
        }

        public string CEDU5
        {
            get
            {
                return mCEDU5;
            }
            set
            {
                mCEDU5 = value;
            }
        }

        public string CEDU6
        {
            get
            {
                return mCEDU6;
            }
            set
            {
                mCEDU6 = value;
            }
        }

        public string CEDU7
        {
            get
            {
                return mCEDU7;
            }
            set
            {
                mCEDU7 = value;
            }
        }

        public string CEDU8
        {
            get
            {
                return mCEDU8;
            }
            set
            {
                mCEDU8 = value;
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

        public Double CHEQUE1
        {
            get
            {
                return mCHEQUE1;
            }
            set
            {
                mCHEQUE1 = value;
            }
        }

        public Double CHEQUE2
        {
            get
            {
                return mCHEQUE2;
            }
            set
            {
                mCHEQUE2 = value;
            }
        }

        public Double CHEQUE3
        {
            get
            {
                return mCHEQUE3;
            }
            set
            {
                mCHEQUE3 = value;
            }
        }

        public Double CHEQUE4
        {
            get
            {
                return mCHEQUE4;
            }
            set
            {
                mCHEQUE4 = value;
            }
        }

        public Double CHEQUE5
        {
            get
            {
                return mCHEQUE5;
            }
            set
            {
                mCHEQUE5 = value;
            }
        }

        public Double CHEQUE6
        {
            get
            {
                return mCHEQUE6;
            }
            set
            {
                mCHEQUE6 = value;
            }
        }

        public Double CHEQUE7
        {
            get
            {
                return mCHEQUE7;
            }
            set
            {
                mCHEQUE7 = value;
            }
        }

        public Double CHEQUE8
        {
            get
            {
                return mCHEQUE8;
            }
            set
            {
                mCHEQUE8 = value;
            }
        }

        public string CISTER
        {
            get
            {
                return mCISTER;
            }
            set
            {
                mCISTER = value;
            }
        }

        public string CIUDAD
        {
            get
            {
                return mCIUDAD;
            }
            set
            {
                mCIUDAD = value;
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

        public string CODE_BAR
        {
            get
            {
                return mCODE_BAR;
            }
            set
            {
                mCODE_BAR = value;
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

        public Double CODMON1
        {
            get
            {
                return mCODMON1;
            }
            set
            {
                mCODMON1 = value;
            }
        }

        public Double CODMON2
        {
            get
            {
                return mCODMON2;
            }
            set
            {
                mCODMON2 = value;
            }
        }

        public Double CODMON3
        {
            get
            {
                return mCODMON3;
            }
            set
            {
                mCODMON3 = value;
            }
        }

        public Double CODMON4
        {
            get
            {
                return mCODMON4;
            }
            set
            {
                mCODMON4 = value;
            }
        }

        public Double CODMON5
        {
            get
            {
                return mCODMON5;
            }
            set
            {
                mCODMON5 = value;
            }
        }

        public Double CODMON6
        {
            get
            {
                return mCODMON6;
            }
            set
            {
                mCODMON6 = value;
            }
        }

        public Double CODMON7
        {
            get
            {
                return mCODMON7;
            }
            set
            {
                mCODMON7 = value;
            }
        }

        public Double CODMON8
        {
            get
            {
                return mCODMON8;
            }
            set
            {
                mCODMON8 = value;
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

        public Double COD_VAL1
        {
            get
            {
                return mCOD_VAL1;
            }
            set
            {
                mCOD_VAL1 = value;
            }
        }

        public Double COD_VAL2
        {
            get
            {
                return mCOD_VAL2;
            }
            set
            {
                mCOD_VAL2 = value;
            }
        }

        public Double COD_VAL3
        {
            get
            {
                return mCOD_VAL3;
            }
            set
            {
                mCOD_VAL3 = value;
            }
        }

        public Double COD_VAL4
        {
            get
            {
                return mCOD_VAL4;
            }
            set
            {
                mCOD_VAL4 = value;
            }
        }

        public Double COD_VAL5
        {
            get
            {
                return mCOD_VAL5;
            }
            set
            {
                mCOD_VAL5 = value;
            }
        }

        public Double COD_VAL6
        {
            get
            {
                return mCOD_VAL6;
            }
            set
            {
                mCOD_VAL6 = value;
            }
        }

        public Double COD_VAL7
        {
            get
            {
                return mCOD_VAL7;
            }
            set
            {
                mCOD_VAL7 = value;
            }
        }

        public Double COD_VAL8
        {
            get
            {
                return mCOD_VAL8;
            }
            set
            {
                mCOD_VAL8 = value;
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

        public string CSECCION
        {
            get
            {
                return mCSECCION;
            }
            set
            {
                mCSECCION = value;
            }
        }

        public string CTP1
        {
            get
            {
                return mCTP1;
            }
            set
            {
                mCTP1 = value;
            }
        }

        public string CTP2
        {
            get
            {
                return mCTP2;
            }
            set
            {
                mCTP2 = value;
            }
        }

        public string CTP3
        {
            get
            {
                return mCTP3;
            }
            set
            {
                mCTP3 = value;
            }
        }

        public string CTP4
        {
            get
            {
                return mCTP4;
            }
            set
            {
                mCTP4 = value;
            }
        }

        public string CTP5
        {
            get
            {
                return mCTP5;
            }
            set
            {
                mCTP5 = value;
            }
        }

        public string CTP6
        {
            get
            {
                return mCTP6;
            }
            set
            {
                mCTP6 = value;
            }
        }

        public string CTP7
        {
            get
            {
                return mCTP7;
            }
            set
            {
                mCTP7 = value;
            }
        }

        public string CTP8
        {
            get
            {
                return mCTP8;
            }
            set
            {
                mCTP8 = value;
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

        public string EMAIL
        {
            get
            {
                return mEMAIL;
            }
            set
            {
                mEMAIL = value;
            }
        }

        public string EMISOR1
        {
            get
            {
                return mEMISOR1;
            }
            set
            {
                mEMISOR1 = value;
            }
        }

        public string EMISOR2
        {
            get
            {
                return mEMISOR2;
            }
            set
            {
                mEMISOR2 = value;
            }
        }

        public string EMISOR3
        {
            get
            {
                return mEMISOR3;
            }
            set
            {
                mEMISOR3 = value;
            }
        }

        public string EMISOR4
        {
            get
            {
                return mEMISOR4;
            }
            set
            {
                mEMISOR4 = value;
            }
        }

        public string EMISOR5
        {
            get
            {
                return mEMISOR5;
            }
            set
            {
                mEMISOR5 = value;
            }
        }

        public string EMISOR6
        {
            get
            {
                return mEMISOR6;
            }
            set
            {
                mEMISOR6 = value;
            }
        }

        public string EMISOR7
        {
            get
            {
                return mEMISOR7;
            }
            set
            {
                mEMISOR7 = value;
            }
        }

        public string EMISOR8
        {
            get
            {
                return mEMISOR8;
            }
            set
            {
                mEMISOR8 = value;
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

        public string ESTADO
        {
            get
            {
                return mESTADO;
            }
            set
            {
                mESTADO = value;
            }
        }

        public Double ESTATUS
        {
            get
            {
                return mESTATUS;
            }
            set
            {
                mESTATUS = value;
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

        public string EXPIRA1
        {
            get
            {
                return mEXPIRA1;
            }
            set
            {
                mEXPIRA1 = value;
            }
        }

        public string EXPIRA2
        {
            get
            {
                return mEXPIRA2;
            }
            set
            {
                mEXPIRA2 = value;
            }
        }

        public string EXPIRA3
        {
            get
            {
                return mEXPIRA3;
            }
            set
            {
                mEXPIRA3 = value;
            }
        }

        public string EXPIRA4
        {
            get
            {
                return mEXPIRA4;
            }
            set
            {
                mEXPIRA4 = value;
            }
        }

        public string EXPIRA5
        {
            get
            {
                return mEXPIRA5;
            }
            set
            {
                mEXPIRA5 = value;
            }
        }

        public string EXPIRA6
        {
            get
            {
                return mEXPIRA6;
            }
            set
            {
                mEXPIRA6 = value;
            }
        }

        public string EXPIRA7
        {
            get
            {
                return mEXPIRA7;
            }
            set
            {
                mEXPIRA7 = value;
            }
        }

        public string EXPIRA8
        {
            get
            {
                return mEXPIRA8;
            }
            set
            {
                mEXPIRA8 = value;
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

        public string ID1
        {
            get
            {
                return mID1;
            }
            set
            {
                mID1 = value;
            }
        }

        public string ID2
        {
            get
            {
                return mID2;
            }
            set
            {
                mID2 = value;
            }
        }

        public string ID3
        {
            get
            {
                return mID3;
            }
            set
            {
                mID3 = value;
            }
        }

        public string ID4
        {
            get
            {
                return mID4;
            }
            set
            {
                mID4 = value;
            }
        }

        public string ID5
        {
            get
            {
                return mID5;
            }
            set
            {
                mID5 = value;
            }
        }

        public string ID6
        {
            get
            {
                return mID6;
            }
            set
            {
                mID6 = value;
            }
        }

        public string ID7
        {
            get
            {
                return mID7;
            }
            set
            {
                mID7 = value;
            }
        }

        public string ID8
        {
            get
            {
                return mID8;
            }
            set
            {
                mID8 = value;
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

        public string ISLA
        {
            get
            {
                return mISLA;
            }
            set
            {
                mISLA = value;
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

        public Double M1
        {
            get
            {
                return mM1;
            }
            set
            {
                mM1 = value;
            }
        }

        public Double M2
        {
            get
            {
                return mM2;
            }
            set
            {
                mM2 = value;
            }
        }

        public Double M3
        {
            get
            {
                return mM3;
            }
            set
            {
                mM3 = value;
            }
        }

        public Double M4
        {
            get
            {
                return mM4;
            }
            set
            {
                mM4 = value;
            }
        }

        public Double M5
        {
            get
            {
                return mM5;
            }
            set
            {
                mM5 = value;
            }
        }

        public Double M6
        {
            get
            {
                return mM6;
            }
            set
            {
                mM6 = value;
            }
        }

        public Double M7
        {
            get
            {
                return mM7;
            }
            set
            {
                mM7 = value;
            }
        }

        public Double M8
        {
            get
            {
                return mM8;
            }
            set
            {
                mM8 = value;
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

        public Double MONTOD
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

        public Double MON_CONV1
        {
            get
            {
                return mMON_CONV1;
            }
            set
            {
                mMON_CONV1 = value;
            }
        }

        public Double MON_CONV2
        {
            get
            {
                return mMON_CONV2;
            }
            set
            {
                mMON_CONV2 = value;
            }
        }

        public Double MON_CONV3
        {
            get
            {
                return mMON_CONV3;
            }
            set
            {
                mMON_CONV3 = value;
            }
        }

        public Double MON_CONV4
        {
            get
            {
                return mMON_CONV4;
            }
            set
            {
                mMON_CONV4 = value;
            }
        }

        public Double MON_CONV5
        {
            get
            {
                return mMON_CONV5;
            }
            set
            {
                mMON_CONV5 = value;
            }
        }

        public Double MON_CONV6
        {
            get
            {
                return mMON_CONV6;
            }
            set
            {
                mMON_CONV6 = value;
            }
        }

        public Double MON_CONV7
        {
            get
            {
                return mMON_CONV7;
            }
            set
            {
                mMON_CONV7 = value;
            }
        }

        public Double MON_CONV8
        {
            get
            {
                return mMON_CONV8;
            }
            set
            {
                mMON_CONV8 = value;
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

        public string NROCASA
        {
            get
            {
                return mNROCASA;
            }
            set
            {
                mNROCASA = value;
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

        public Double PBONOD
        {
            get
            {
                return mPBONOD;
            }
            set
            {
                mPBONOD = value;
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

        public Double PEDIDO
        {
            get
            {
                return mPEDIDO;
            }
            set
            {
                mPEDIDO = value;
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

        public Double PROPI1
        {
            get
            {
                return mPROPI1;
            }
            set
            {
                mPROPI1 = value;
            }
        }

        public Double PROPI2
        {
            get
            {
                return mPROPI2;
            }
            set
            {
                mPROPI2 = value;
            }
        }

        public Double PROPI3
        {
            get
            {
                return mPROPI3;
            }
            set
            {
                mPROPI3 = value;
            }
        }

        public Double PROPI4
        {
            get
            {
                return mPROPI4;
            }
            set
            {
                mPROPI4 = value;
            }
        }

        public Double PROPI5
        {
            get
            {
                return mPROPI5;
            }
            set
            {
                mPROPI5 = value;
            }
        }

        public Double PROPI6
        {
            get
            {
                return mPROPI6;
            }
            set
            {
                mPROPI6 = value;
            }
        }

        public Double PROPI7
        {
            get
            {
                return mPROPI7;
            }
            set
            {
                mPROPI7 = value;
            }
        }

        public Double PROPI8
        {
            get
            {
                return mPROPI8;
            }
            set
            {
                mPROPI8 = value;
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

        public Double PT1
        {
            get
            {
                return mPT1;
            }
            set
            {
                mPT1 = value;
            }
        }

        public Double PT2
        {
            get
            {
                return mPT2;
            }
            set
            {
                mPT2 = value;
            }
        }

        public Double PT3
        {
            get
            {
                return mPT3;
            }
            set
            {
                mPT3 = value;
            }
        }

        public Double PT4
        {
            get
            {
                return mPT4;
            }
            set
            {
                mPT4 = value;
            }
        }

        public Double PT5
        {
            get
            {
                return mPT5;
            }
            set
            {
                mPT5 = value;
            }
        }

        public Double PT6
        {
            get
            {
                return mPT6;
            }
            set
            {
                mPT6 = value;
            }
        }

        public Double PT7
        {
            get
            {
                return mPT7;
            }
            set
            {
                mPT7 = value;
            }
        }

        public Double PT8
        {
            get
            {
                return mPT8;
            }
            set
            {
                mPT8 = value;
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

        public string REFERENCIA
        {
            get
            {
                return mREFERENCIA;
            }
            set
            {
                mREFERENCIA = value;
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

        public string TELE1
        {
            get
            {
                return mTELE1;
            }
            set
            {
                mTELE1 = value;
            }
        }

        public string TELE2
        {
            get
            {
                return mTELE2;
            }
            set
            {
                mTELE2 = value;
            }
        }

        public string TELE3
        {
            get
            {
                return mTELE3;
            }
            set
            {
                mTELE3 = value;
            }
        }

        public string TELE4
        {
            get
            {
                return mTELE4;
            }
            set
            {
                mTELE4 = value;
            }
        }

        public string TELE5
        {
            get
            {
                return mTELE5;
            }
            set
            {
                mTELE5 = value;
            }
        }

        public string TELE6
        {
            get
            {
                return mTELE6;
            }
            set
            {
                mTELE6 = value;
            }
        }

        public string TELE7
        {
            get
            {
                return mTELE7;
            }
            set
            {
                mTELE7 = value;
            }
        }

        public string TELE8
        {
            get
            {
                return mTELE8;
            }
            set
            {
                mTELE8 = value;
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

        public string TP1
        {
            get
            {
                return mTP1;
            }
            set
            {
                mTP1 = value;
            }
        }

        public string TP2
        {
            get
            {
                return mTP2;
            }
            set
            {
                mTP2 = value;
            }
        }

        public string TP3
        {
            get
            {
                return mTP3;
            }
            set
            {
                mTP3 = value;
            }
        }

        public string TP4
        {
            get
            {
                return mTP4;
            }
            set
            {
                mTP4 = value;
            }
        }

        public string TP5
        {
            get
            {
                return mTP5;
            }
            set
            {
                mTP5 = value;
            }
        }

        public string TP6
        {
            get
            {
                return mTP6;
            }
            set
            {
                mTP6 = value;
            }
        }

        public string TP7
        {
            get
            {
                return mTP7;
            }
            set
            {
                mTP7 = value;
            }
        }

        public string TP8
        {
            get
            {
                return mTP8;
            }
            set
            {
                mTP8 = value;
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

        public string URB
        {
            get
            {
                return mURB;
            }
            set
            {
                mURB = value;
            }
        }

        public Double VAUCHE1
        {
            get
            {
                return mVAUCHE1;
            }
            set
            {
                mVAUCHE1 = value;
            }
        }

        public Double VAUCHE2
        {
            get
            {
                return mVAUCHE2;
            }
            set
            {
                mVAUCHE2 = value;
            }
        }

        public Double VAUCHE3
        {
            get
            {
                return mVAUCHE3;
            }
            set
            {
                mVAUCHE3 = value;
            }
        }

        public Double VAUCHE4
        {
            get
            {
                return mVAUCHE4;
            }
            set
            {
                mVAUCHE4 = value;
            }
        }

        public Double VAUCHE5
        {
            get
            {
                return mVAUCHE5;
            }
            set
            {
                mVAUCHE5 = value;
            }
        }

        public Double VAUCHE6
        {
            get
            {
                return mVAUCHE6;
            }
            set
            {
                mVAUCHE6 = value;
            }
        }

        public Double VAUCHE7
        {
            get
            {
                return mVAUCHE7;
            }
            set
            {
                mVAUCHE7 = value;
            }
        }

        public Double VAUCHE8
        {
            get
            {
                return mVAUCHE8;
            }
            set
            {
                mVAUCHE8 = value;
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

        ITEMS()
        {
        }

        ITEMS(double ABONO, double ACTUAL, double ANULADO, string BANCO1, string BANCO2, string BANCO3, string BANCO4, string BANCO5, string BANCO6, string BANCO7, string BANCO8, double BASE1, double BASE2, double BASE3, double BONOD, string CAJA, string CAJAD, string CAJADEV, string CALLE, double CANCELADO, double CANTI, double CANTIELIM, string CASA, string CBANCO1, string CBANCO2, string CBANCO3, string CBANCO4, string CBANCO5, string CBANCO6, string CBANCO7, string CBANCO8, string CCONTABLE, string CDESCU, string CEDU1, string CEDU2, string CEDU3, string CEDU4, string CEDU5, string CEDU6, string CEDU7, string CEDU8, double CFISCAL, double CFISCALD, double CHEQUE1, double CHEQUE2, double CHEQUE3, double CHEQUE4, double CHEQUE5, double CHEQUE6, double CHEQUE7, double CHEQUE8, string CISTER, string CIUDAD, int CLIENTE, string CMATRICU, int CODCLI, string CODENC, string CODE_BAR, string CODIGOBP, double CODMON1, double CODMON2, double CODMON3, double CODMON4, double CODMON5, double CODMON6, double CODMON7, double CODMON8, string CODPEDIDO, double COD_VAL1, double COD_VAL2, double COD_VAL3, double COD_VAL4, double COD_VAL5, double COD_VAL6, double COD_VAL7, double COD_VAL8, double COMICOB, double COMIVEN, double COMIVENTA, double CONTRI, double COSTOP, double COSTOU, string CSECCION, string CTP1, string CTP2, string CTP3, string CTP4, string CTP5, string CTP6, string CTP7, string CTP8, string DDESCU, double DESCU, double DESCUT, double DESC_TAR, double DIASCRE, string DIRECCION, string EMAIL, string EMISOR1, string EMISOR2, string EMISOR3, string EMISOR4, string EMISOR5, string EMISOR6, string EMISOR7, string EMISOR8, string EMPLE, string EMPLEC, string ESTADO, double ESTATUS, double ESTATUSR, double EXENTO, string EXPIRA1, string EXPIRA2, string EXPIRA3, string EXPIRA4, string EXPIRA5, string EXPIRA6, string EXPIRA7, string EXPIRA8, double FDESCU, DateTime FECHA, string FECHAC, double GUIA_DESPA, string HORA, string HORAA, string HORAC, int ID, string ID1, string ID2, string ID3, string ID4, string ID5, string ID6, string ID7, string ID8, int IDCIUDAD, int IDCLIASO, int IDDIRCENT, int IDESTADO, int IDPAIS, int IDSUC, int IDTERPAG, int ID_REFE, string ISLA, double IVA, double IVA1, double IVA2, double IVA3, string LICENCIA, double M1, double M2, double M3, double M4, double M5, double M6, double M7, double M8, string MAQFIS, string MAQFISDE, string MESA, string MODULO, double MONTO, double MONTOD, double MON_CONV1, double MON_CONV2, double MON_CONV3, double MON_CONV4, double MON_CONV5, double MON_CONV6, double MON_CONV7, double MON_CONV8, string NIT, string NMESA, string NOMCLI, string NOMEMP, string NOMEMPC, double NRO, string NROCASA, double NRODEV, double N_PUN, double PBONOD, double PDESCU, double PDESCUB, double PEDIDO, double PORCD, double PROPI1, double PROPI2, double PROPI3, double PROPI4, double PROPI5, double PROPI6, double PROPI7, double PROPI8, double PROPINA, double PT1, double PT2, double PT3, double PT4, double PT5, double PT6, double PT7, double PT8, double RECARGO, double RECIBIDO, string REFERENCIA, string RIF, string SECCION, double SERVICIO, double SESION, double T1, double TAX1, double TAX2, double TAX3, double TDESCU, double TDESTINO, string TELE1, string TELE2, string TELE3, string TELE4, string TELE5, string TELE6, string TELE7, string TELE8, string TELEFONO, string TIPO, double TIPOD, double TOTAL, string TP1, string TP2, string TP3, string TP4, string TP5, string TP6, string TP7, string TP8, string TPAGO, double TPRECIO, string UID, string UIDCLIMOV, string URB, double VAUCHE1, double VAUCHE2, double VAUCHE3, double VAUCHE4, double VAUCHE5, double VAUCHE6, double VAUCHE7, double VAUCHE8, string VENDEDOR, double VERIFI, string ZONA, double modonc, double tiponc)
        {
            mABONO = ABONO;
            mACTUAL = ACTUAL;
            mANULADO = ANULADO;
            mBANCO1 = BANCO1;
            mBANCO2 = BANCO2;
            mBANCO3 = BANCO3;
            mBANCO4 = BANCO4;
            mBANCO5 = BANCO5;
            mBANCO6 = BANCO6;
            mBANCO7 = BANCO7;
            mBANCO8 = BANCO8;
            mBASE1 = BASE1;
            mBASE2 = BASE2;
            mBASE3 = BASE3;
            mBONOD = BONOD;
            mCAJA = CAJA;
            mCAJAD = CAJAD;
            mCAJADEV = CAJADEV;
            mCALLE = CALLE;
            mCANCELADO = CANCELADO;
            mCANTI = CANTI;
            mCANTIELIM = CANTIELIM;
            mCASA = CASA;
            mCBANCO1 = CBANCO1;
            mCBANCO2 = CBANCO2;
            mCBANCO3 = CBANCO3;
            mCBANCO4 = CBANCO4;
            mCBANCO5 = CBANCO5;
            mCBANCO6 = CBANCO6;
            mCBANCO7 = CBANCO7;
            mCBANCO8 = CBANCO8;
            mCCONTABLE = CCONTABLE;
            mCDESCU = CDESCU;
            mCEDU1 = CEDU1;
            mCEDU2 = CEDU2;
            mCEDU3 = CEDU3;
            mCEDU4 = CEDU4;
            mCEDU5 = CEDU5;
            mCEDU6 = CEDU6;
            mCEDU7 = CEDU7;
            mCEDU8 = CEDU8;
            mCFISCAL = CFISCAL;
            mCFISCALD = CFISCALD;
            mCHEQUE1 = CHEQUE1;
            mCHEQUE2 = CHEQUE2;
            mCHEQUE3 = CHEQUE3;
            mCHEQUE4 = CHEQUE4;
            mCHEQUE5 = CHEQUE5;
            mCHEQUE6 = CHEQUE6;
            mCHEQUE7 = CHEQUE7;
            mCHEQUE8 = CHEQUE8;
            mCISTER = CISTER;
            mCIUDAD = CIUDAD;
            mCLIENTE = CLIENTE;
            mCMATRICU = CMATRICU;
            mCODCLI = CODCLI;
            mCODENC = CODENC;
            mCODE_BAR = CODE_BAR;
            mCODIGOBP = CODIGOBP;
            mCODMON1 = CODMON1;
            mCODMON2 = CODMON2;
            mCODMON3 = CODMON3;
            mCODMON4 = CODMON4;
            mCODMON5 = CODMON5;
            mCODMON6 = CODMON6;
            mCODMON7 = CODMON7;
            mCODMON8 = CODMON8;
            mCODPEDIDO = CODPEDIDO;
            mCOD_VAL1 = COD_VAL1;
            mCOD_VAL2 = COD_VAL2;
            mCOD_VAL3 = COD_VAL3;
            mCOD_VAL4 = COD_VAL4;
            mCOD_VAL5 = COD_VAL5;
            mCOD_VAL6 = COD_VAL6;
            mCOD_VAL7 = COD_VAL7;
            mCOD_VAL8 = COD_VAL8;
            mCOMICOB = COMICOB;
            mCOMIVEN = COMIVEN;
            mCOMIVENTA = COMIVENTA;
            mCONTRI = CONTRI;
            mCOSTOP = COSTOP;
            mCOSTOU = COSTOU;
            mCSECCION = CSECCION;
            mCTP1 = CTP1;
            mCTP2 = CTP2;
            mCTP3 = CTP3;
            mCTP4 = CTP4;
            mCTP5 = CTP5;
            mCTP6 = CTP6;
            mCTP7 = CTP7;
            mCTP8 = CTP8;
            mDDESCU = DDESCU;
            mDESCU = DESCU;
            mDESCUT = DESCUT;
            mDESC_TAR = DESC_TAR;
            mDIASCRE = DIASCRE;
            mDIRECCION = DIRECCION;
            mEMAIL = EMAIL;
            mEMISOR1 = EMISOR1;
            mEMISOR2 = EMISOR2;
            mEMISOR3 = EMISOR3;
            mEMISOR4 = EMISOR4;
            mEMISOR5 = EMISOR5;
            mEMISOR6 = EMISOR6;
            mEMISOR7 = EMISOR7;
            mEMISOR8 = EMISOR8;
            mEMPLE = EMPLE;
            mEMPLEC = EMPLEC;
            mESTADO = ESTADO;
            mESTATUS = ESTATUS;
            mESTATUSR = ESTATUSR;
            mEXENTO = EXENTO;
            mEXPIRA1 = EXPIRA1;
            mEXPIRA2 = EXPIRA2;
            mEXPIRA3 = EXPIRA3;
            mEXPIRA4 = EXPIRA4;
            mEXPIRA5 = EXPIRA5;
            mEXPIRA6 = EXPIRA6;
            mEXPIRA7 = EXPIRA7;
            mEXPIRA8 = EXPIRA8;
            mFDESCU = FDESCU;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mGUIA_DESPA = GUIA_DESPA;
            mHORA = HORA;
            mHORAA = HORAA;
            mHORAC = HORAC;
            mID = ID;
            mID1 = ID1;
            mID2 = ID2;
            mID3 = ID3;
            mID4 = ID4;
            mID5 = ID5;
            mID6 = ID6;
            mID7 = ID7;
            mID8 = ID8;
            mIDCIUDAD = IDCIUDAD;
            mIDCLIASO = IDCLIASO;
            mIDDIRCENT = IDDIRCENT;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
            mIDSUC = IDSUC;
            mIDTERPAG = IDTERPAG;
            mID_REFE = ID_REFE;
            mISLA = ISLA;
            mIVA = IVA;
            mIVA1 = IVA1;
            mIVA2 = IVA2;
            mIVA3 = IVA3;
            mLICENCIA = LICENCIA;
            mM1 = M1;
            mM2 = M2;
            mM3 = M3;
            mM4 = M4;
            mM5 = M5;
            mM6 = M6;
            mM7 = M7;
            mM8 = M8;
            mMAQFIS = MAQFIS;
            mMAQFISDE = MAQFISDE;
            mMESA = MESA;
            mMODULO = MODULO;
            mMONTO = MONTO;
            mMONTOD = MONTOD;
            mMON_CONV1 = MON_CONV1;
            mMON_CONV2 = MON_CONV2;
            mMON_CONV3 = MON_CONV3;
            mMON_CONV4 = MON_CONV4;
            mMON_CONV5 = MON_CONV5;
            mMON_CONV6 = MON_CONV6;
            mMON_CONV7 = MON_CONV7;
            mMON_CONV8 = MON_CONV8;
            mNIT = NIT;
            mNMESA = NMESA;
            mNOMCLI = NOMCLI;
            mNOMEMP = NOMEMP;
            mNOMEMPC = NOMEMPC;
            mNRO = NRO;
            mNROCASA = NROCASA;
            mNRODEV = NRODEV;
            mN_PUN = N_PUN;
            mPBONOD = PBONOD;
            mPDESCU = PDESCU;
            mPDESCUB = PDESCUB;
            mPEDIDO = PEDIDO;
            mPORCD = PORCD;
            mPROPI1 = PROPI1;
            mPROPI2 = PROPI2;
            mPROPI3 = PROPI3;
            mPROPI4 = PROPI4;
            mPROPI5 = PROPI5;
            mPROPI6 = PROPI6;
            mPROPI7 = PROPI7;
            mPROPI8 = PROPI8;
            mPROPINA = PROPINA;
            mPT1 = PT1;
            mPT2 = PT2;
            mPT3 = PT3;
            mPT4 = PT4;
            mPT5 = PT5;
            mPT6 = PT6;
            mPT7 = PT7;
            mPT8 = PT8;
            mRECARGO = RECARGO;
            mRECIBIDO = RECIBIDO;
            mREFERENCIA = REFERENCIA;
            mRIF = RIF;
            mSECCION = SECCION;
            mSERVICIO = SERVICIO;
            mSESION = SESION;
            mT1 = T1;
            mTAX1 = TAX1;
            mTAX2 = TAX2;
            mTAX3 = TAX3;
            mTDESCU = TDESCU;
            mTDESTINO = TDESTINO;
            mTELE1 = TELE1;
            mTELE2 = TELE2;
            mTELE3 = TELE3;
            mTELE4 = TELE4;
            mTELE5 = TELE5;
            mTELE6 = TELE6;
            mTELE7 = TELE7;
            mTELE8 = TELE8;
            mTELEFONO = TELEFONO;
            mTIPO = TIPO;
            mTIPOD = TIPOD;
            mTOTAL = TOTAL;
            mTP1 = TP1;
            mTP2 = TP2;
            mTP3 = TP3;
            mTP4 = TP4;
            mTP5 = TP5;
            mTP6 = TP6;
            mTP7 = TP7;
            mTP8 = TP8;
            mTPAGO = TPAGO;
            mTPRECIO = TPRECIO;
            mUID = UID;
            mUIDCLIMOV = UIDCLIMOV;
            mURB = URB;
            mVAUCHE1 = VAUCHE1;
            mVAUCHE2 = VAUCHE2;
            mVAUCHE3 = VAUCHE3;
            mVAUCHE4 = VAUCHE4;
            mVAUCHE5 = VAUCHE5;
            mVAUCHE6 = VAUCHE6;
            mVAUCHE7 = VAUCHE7;
            mVAUCHE8 = VAUCHE8;
            mVENDEDOR = VENDEDOR;
            mVERIFI = VERIFI;
            mZONA = ZONA;
            mModonc = Modonc;
            mTiponc = Tiponc;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
