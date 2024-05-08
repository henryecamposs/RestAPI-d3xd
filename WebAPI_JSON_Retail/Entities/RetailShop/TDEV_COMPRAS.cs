using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TDEV_COMPRAS : ICloneable
    {

        private string mACTU_PRE = "";
        private double mBASE_MARGA = 0.0;
        private double mBASE_MARGE = 0.0;
        private double mCAL_UTI = 0.0;
        private double mCAL_UTIA = 0.0;
        private double mCANDEV = 0.0;
        private double mCANTIDAD = 0.0;
        private double mCANT_DEV = 0.0;
        private string mCD_CON = "";
        private string mCODIGO = "";
        private string mCODIGOI = "";
        private string mCODIGOP = "";
        private double mCOSANTP = 0.0;
        private double mCOSANTU = 0.0;
        private double mCOSPRO = 0.0;
        private double mCOSTO = 0.0;
        private double mCOSULT = 0.0;
        private double mDESC1 = 0.0;
        private double mDESC2 = 0.0;
        private double mDESC3 = 0.0;
        private double mDESCPP = 0.0;
        private string mDESCR = "";
        private double mDESCU = 0.0;
        private double mDIFF = 0.0;
        private int mDOCORI = 0;
        private string mDOCORIC = "";
        private string mDPTO = "";
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private int mID = 0;
        private int mIDREF = 0;
        private int mID_COMPRA = 0;
        private int mID_OC = 0;
        private double mIMPUESTO = 0.0;
        private double mIMPUESTOA = 0.0;
        private double mIMP_ETI = 0.0;
        private double mMARGEN1 = 0.0;
        private double mMARGEN1M = 0.0;
        private double mMARGEN2 = 0.0;
        private double mMARGEN2M = 0.0;
        private double mMARGEN3 = 0.0;
        private double mMARGEN3M = 0.0;
        private double mMARGEN4 = 0.0;
        private double mMARGEN4M = 0.0;
        private double mMARGENA1 = 0.0;
        private double mMARGENA2 = 0.0;
        private double mMARGENA3 = 0.0;
        private double mMDESCU = 0.0;
        private double mPAQUETE = 0.0;
        private double mPIMP = 0.0;
        private double mPIMPA = 0.0;
        private double mPRECIO1 = 0.0;
        private double mPRECIO1M = 0.0;
        private double mPRECIO2 = 0.0;
        private double mPRECIO2M = 0.0;
        private double mPRECIO3 = 0.0;
        private double mPRECIO3M = 0.0;
        private double mPRECIO4 = 0.0;
        private double mPRECIO4M = 0.0;
        private double mPRECIOA1 = 0.0;
        private double mPRECIOA2 = 0.0;
        private double mPRECIOA3 = 0.0;
        private double mPROMEDIO = 0.0;
        private double mPROMEDIOA = 0.0;
        private double mTDESCU = 0.0;
        private double mTGASTO = 0.0;
        private double mTIMP = 0.0;
        private double mTOTAL = 0.0;
        private string mUBICA = "";
        private string mUID = "";
        private double mULTIMO = 0.0;
        private double mULTIMOA = 0.0;
        private string mUNIDAD = "";
        private double mUNIDADE = 0.0;
        private double mUNIEMPA = 0.0;

        public string ACTU_PRE
        {
            get
            {
                return mACTU_PRE;
            }
            set
            {
                mACTU_PRE = value;
            }
        }

        public Double BASE_MARGA
        {
            get
            {
                return mBASE_MARGA;
            }
            set
            {
                mBASE_MARGA = value;
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

        public Double CAL_UTIA
        {
            get
            {
                return mCAL_UTIA;
            }
            set
            {
                mCAL_UTIA = value;
            }
        }

        public Double CANDEV
        {
            get
            {
                return mCANDEV;
            }
            set
            {
                mCANDEV = value;
            }
        }

        public Double CANTIDAD
        {
            get
            {
                return mCANTIDAD;
            }
            set
            {
                mCANTIDAD = value;
            }
        }

        public Double CANT_DEV
        {
            get
            {
                return mCANT_DEV;
            }
            set
            {
                mCANT_DEV = value;
            }
        }

        public string CD_CON
        {
            get
            {
                return mCD_CON;
            }
            set
            {
                mCD_CON = value;
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

        public Double COSANTP
        {
            get
            {
                return mCOSANTP;
            }
            set
            {
                mCOSANTP = value;
            }
        }

        public Double COSANTU
        {
            get
            {
                return mCOSANTU;
            }
            set
            {
                mCOSANTU = value;
            }
        }

        public Double COSPRO
        {
            get
            {
                return mCOSPRO;
            }
            set
            {
                mCOSPRO = value;
            }
        }

        public Double COSTO
        {
            get
            {
                return mCOSTO;
            }
            set
            {
                mCOSTO = value;
            }
        }

        public Double COSULT
        {
            get
            {
                return mCOSULT;
            }
            set
            {
                mCOSULT = value;
            }
        }

        public Double DESC1
        {
            get
            {
                return mDESC1;
            }
            set
            {
                mDESC1 = value;
            }
        }

        public Double DESC2
        {
            get
            {
                return mDESC2;
            }
            set
            {
                mDESC2 = value;
            }
        }

        public Double DESC3
        {
            get
            {
                return mDESC3;
            }
            set
            {
                mDESC3 = value;
            }
        }

        public Double DESCPP
        {
            get
            {
                return mDESCPP;
            }
            set
            {
                mDESCPP = value;
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

        public Double DIFF
        {
            get
            {
                return mDIFF;
            }
            set
            {
                mDIFF = value;
            }
        }

        public int DOCORI
        {
            get
            {
                return mDOCORI;
            }
            set
            {
                mDOCORI = value;
            }
        }

        public string DOCORIC
        {
            get
            {
                return mDOCORIC;
            }
            set
            {
                mDOCORIC = value;
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

        public int IDREF
        {
            get
            {
                return mIDREF;
            }
            set
            {
                mIDREF = value;
            }
        }

        public int ID_COMPRA
        {
            get
            {
                return mID_COMPRA;
            }
            set
            {
                mID_COMPRA = value;
            }
        }

        public int ID_OC
        {
            get
            {
                return mID_OC;
            }
            set
            {
                mID_OC = value;
            }
        }

        public Double IMPUESTO
        {
            get
            {
                return mIMPUESTO;
            }
            set
            {
                mIMPUESTO = value;
            }
        }

        public Double IMPUESTOA
        {
            get
            {
                return mIMPUESTOA;
            }
            set
            {
                mIMPUESTOA = value;
            }
        }

        public Double IMP_ETI
        {
            get
            {
                return mIMP_ETI;
            }
            set
            {
                mIMP_ETI = value;
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

        public Double MARGENA1
        {
            get
            {
                return mMARGENA1;
            }
            set
            {
                mMARGENA1 = value;
            }
        }

        public Double MARGENA2
        {
            get
            {
                return mMARGENA2;
            }
            set
            {
                mMARGENA2 = value;
            }
        }

        public Double MARGENA3
        {
            get
            {
                return mMARGENA3;
            }
            set
            {
                mMARGENA3 = value;
            }
        }

        public Double MDESCU
        {
            get
            {
                return mMDESCU;
            }
            set
            {
                mMDESCU = value;
            }
        }

        public Double PAQUETE
        {
            get
            {
                return mPAQUETE;
            }
            set
            {
                mPAQUETE = value;
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

        public Double PIMPA
        {
            get
            {
                return mPIMPA;
            }
            set
            {
                mPIMPA = value;
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

        public Double PRECIO4
        {
            get
            {
                return mPRECIO4;
            }
            set
            {
                mPRECIO4 = value;
            }
        }

        public Double PRECIO4M
        {
            get
            {
                return mPRECIO4M;
            }
            set
            {
                mPRECIO4M = value;
            }
        }

        public Double PRECIOA1
        {
            get
            {
                return mPRECIOA1;
            }
            set
            {
                mPRECIOA1 = value;
            }
        }

        public Double PRECIOA2
        {
            get
            {
                return mPRECIOA2;
            }
            set
            {
                mPRECIOA2 = value;
            }
        }

        public Double PRECIOA3
        {
            get
            {
                return mPRECIOA3;
            }
            set
            {
                mPRECIOA3 = value;
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

        public Double PROMEDIOA
        {
            get
            {
                return mPROMEDIOA;
            }
            set
            {
                mPROMEDIOA = value;
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

        public Double TGASTO
        {
            get
            {
                return mTGASTO;
            }
            set
            {
                mTGASTO = value;
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

        public string UBICA
        {
            get
            {
                return mUBICA;
            }
            set
            {
                mUBICA = value;
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

        public Double ULTIMOA
        {
            get
            {
                return mULTIMOA;
            }
            set
            {
                mULTIMOA = value;
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

        public Double UNIEMPA
        {
            get
            {
                return mUNIEMPA;
            }
            set
            {
                mUNIEMPA = value;
            }
        }

        TDEV_COMPRAS()
        {
        }

        TDEV_COMPRAS(string ACTU_PRE, double BASE_MARGA, double BASE_MARGE, double CAL_UTI, double CAL_UTIA, double CANDEV, double CANTIDAD, double CANT_DEV, string CD_CON, string CODIGO, string CODIGOI, string CODIGOP, double COSANTP, double COSANTU, double COSPRO, double COSTO, double COSULT, double DESC1, double DESC2, double DESC3, double DESCPP, string DESCR, double DESCU, double DIFF, int DOCORI, string DOCORIC, string DPTO, DateTime FECHAV, int ID, int IDREF, int ID_COMPRA, int ID_OC, double IMPUESTO, double IMPUESTOA, double IMP_ETI, double MARGEN1, double MARGEN1M, double MARGEN2, double MARGEN2M, double MARGEN3, double MARGEN3M, double MARGEN4, double MARGEN4M, double MARGENA1, double MARGENA2, double MARGENA3, double MDESCU, double PAQUETE, double PIMP, double PIMPA, double PRECIO1, double PRECIO1M, double PRECIO2, double PRECIO2M, double PRECIO3, double PRECIO3M, double PRECIO4, double PRECIO4M, double PRECIOA1, double PRECIOA2, double PRECIOA3, double PROMEDIO, double PROMEDIOA, double TDESCU, double TGASTO, double TIMP, double TOTAL, string UBICA, string UID, double ULTIMO, double ULTIMOA, string UNIDAD, double UNIDADE, double UNIEMPA)
        {
            mACTU_PRE = ACTU_PRE;
            mBASE_MARGA = BASE_MARGA;
            mBASE_MARGE = BASE_MARGE;
            mCAL_UTI = CAL_UTI;
            mCAL_UTIA = CAL_UTIA;
            mCANDEV = CANDEV;
            mCANTIDAD = CANTIDAD;
            mCANT_DEV = CANT_DEV;
            mCD_CON = CD_CON;
            mCODIGO = CODIGO;
            mCODIGOI = CODIGOI;
            mCODIGOP = CODIGOP;
            mCOSANTP = COSANTP;
            mCOSANTU = COSANTU;
            mCOSPRO = COSPRO;
            mCOSTO = COSTO;
            mCOSULT = COSULT;
            mDESC1 = DESC1;
            mDESC2 = DESC2;
            mDESC3 = DESC3;
            mDESCPP = DESCPP;
            mDESCR = DESCR;
            mDESCU = DESCU;
            mDIFF = DIFF;
            mDOCORI = DOCORI;
            mDOCORIC = DOCORIC;
            mDPTO = DPTO;
            mFECHAV = FECHAV;
            mID = ID;
            mIDREF = IDREF;
            mID_COMPRA = ID_COMPRA;
            mID_OC = ID_OC;
            mIMPUESTO = IMPUESTO;
            mIMPUESTOA = IMPUESTOA;
            mIMP_ETI = IMP_ETI;
            mMARGEN1 = MARGEN1;
            mMARGEN1M = MARGEN1M;
            mMARGEN2 = MARGEN2;
            mMARGEN2M = MARGEN2M;
            mMARGEN3 = MARGEN3;
            mMARGEN3M = MARGEN3M;
            mMARGEN4 = MARGEN4;
            mMARGEN4M = MARGEN4M;
            mMARGENA1 = MARGENA1;
            mMARGENA2 = MARGENA2;
            mMARGENA3 = MARGENA3;
            mMDESCU = MDESCU;
            mPAQUETE = PAQUETE;
            mPIMP = PIMP;
            mPIMPA = PIMPA;
            mPRECIO1 = PRECIO1;
            mPRECIO1M = PRECIO1M;
            mPRECIO2 = PRECIO2;
            mPRECIO2M = PRECIO2M;
            mPRECIO3 = PRECIO3;
            mPRECIO3M = PRECIO3M;
            mPRECIO4 = PRECIO4;
            mPRECIO4M = PRECIO4M;
            mPRECIOA1 = PRECIOA1;
            mPRECIOA2 = PRECIOA2;
            mPRECIOA3 = PRECIOA3;
            mPROMEDIO = PROMEDIO;
            mPROMEDIOA = PROMEDIOA;
            mTDESCU = TDESCU;
            mTGASTO = TGASTO;
            mTIMP = TIMP;
            mTOTAL = TOTAL;
            mUBICA = UBICA;
            mUID = UID;
            mULTIMO = ULTIMO;
            mULTIMOA = ULTIMOA;
            mUNIDAD = UNIDAD;
            mUNIDADE = UNIDADE;
            mUNIEMPA = UNIEMPA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
