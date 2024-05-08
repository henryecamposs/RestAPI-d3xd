using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DCOMPRAS : ICloneable
    {

        private double mBASE1 = 0.0;
        private double mBASE2 = 0.0;
        private double mBASE3 = 0.0;
        private double mDES1 = 0.0;
        private double mDES2 = 0.0;
        private double mDES3 = 0.0;
        private double mDES4 = 0.0;
        private double mDES5 = 0.0;
        private double mDES6 = 0.0;
        private double mDESCU = 0.0;
        private double mDESCU1 = 0.0;
        private double mDESCU2 = 0.0;
        private double mDESCU3 = 0.0;
        private double mDESCU4 = 0.0;
        private double mDESCU5 = 0.0;
        private double mDESCU6 = 0.0;
        private string mDIRECCION = "";
        private string mESTADO = "";
        private double mEXENTO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFECHAV = new DateTime(2000, 01, 01);
        private DateTime mF_RETEN = new DateTime(2000, 01, 01);
        private double mGASTO1 = 0.0;
        private double mGASTO2 = 0.0;
        private double mGASTO3 = 0.0;
        private double mGASTOF1 = 0.0;
        private double mGASTOF2 = 0.0;
        private double mGASTOF3 = 0.0;
        private double mGASTOF_EXE = 0.0;
        private double mGASTO_EXE = 0.0;
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_RETEN = 0;
        private double mIMP1 = 0.0;
        private double mIMP2 = 0.0;
        private double mIMP3 = 0.0;
        private double mIMPUESTOA = 0.0;
        private double mIMP_GAS1 = 0.0;
        private double mIMP_GAS2 = 0.0;
        private double mIMP_GAS3 = 0.0;
        private double mIMP_GASF1 = 0.0;
        private double mIMP_GASF2 = 0.0;
        private double mIMP_GASF3 = 0.0;
        private double mIVA = 0.0;
        private double mMONTO = 0.0;
        private string mNIT = "";
        private string mNOMBRE = "";
        private double mNRO = 0.0;
        private string mNROC = "";
        private string mNRORETEN = "";
        private double mPDESCU = 0.0;
        private double mPOR_DESG = 0.0;
        private string mPROVEE = "";
        private int mPROVEEID = 0;
        private string mRIF = "";
        private double mTAX1 = 0.0;
        private double mTAX2 = 0.0;
        private double mTAX3 = 0.0;
        private double mTDES1 = 0.0;
        private double mTDES2 = 0.0;
        private double mTDES3 = 0.0;
        private double mTDES4 = 0.0;
        private double mTDES5 = 0.0;
        private double mTDES6 = 0.0;
        private string mTELE = "";
        private double mTOTAL = 0.0;
        private string mUID = "";

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

        public Double DES1
        {
            get
            {
                return mDES1;
            }
            set
            {
                mDES1 = value;
            }
        }

        public Double DES2
        {
            get
            {
                return mDES2;
            }
            set
            {
                mDES2 = value;
            }
        }

        public Double DES3
        {
            get
            {
                return mDES3;
            }
            set
            {
                mDES3 = value;
            }
        }

        public Double DES4
        {
            get
            {
                return mDES4;
            }
            set
            {
                mDES4 = value;
            }
        }

        public Double DES5
        {
            get
            {
                return mDES5;
            }
            set
            {
                mDES5 = value;
            }
        }

        public Double DES6
        {
            get
            {
                return mDES6;
            }
            set
            {
                mDES6 = value;
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

        public Double DESCU1
        {
            get
            {
                return mDESCU1;
            }
            set
            {
                mDESCU1 = value;
            }
        }

        public Double DESCU2
        {
            get
            {
                return mDESCU2;
            }
            set
            {
                mDESCU2 = value;
            }
        }

        public Double DESCU3
        {
            get
            {
                return mDESCU3;
            }
            set
            {
                mDESCU3 = value;
            }
        }

        public Double DESCU4
        {
            get
            {
                return mDESCU4;
            }
            set
            {
                mDESCU4 = value;
            }
        }

        public Double DESCU5
        {
            get
            {
                return mDESCU5;
            }
            set
            {
                mDESCU5 = value;
            }
        }

        public Double DESCU6
        {
            get
            {
                return mDESCU6;
            }
            set
            {
                mDESCU6 = value;
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

        public DateTime F_RETEN
        {
            get
            {
                return mF_RETEN;
            }
            set
            {
                mF_RETEN = value;
            }
        }

        public Double GASTO1
        {
            get
            {
                return mGASTO1;
            }
            set
            {
                mGASTO1 = value;
            }
        }

        public Double GASTO2
        {
            get
            {
                return mGASTO2;
            }
            set
            {
                mGASTO2 = value;
            }
        }

        public Double GASTO3
        {
            get
            {
                return mGASTO3;
            }
            set
            {
                mGASTO3 = value;
            }
        }

        public Double GASTOF1
        {
            get
            {
                return mGASTOF1;
            }
            set
            {
                mGASTOF1 = value;
            }
        }

        public Double GASTOF2
        {
            get
            {
                return mGASTOF2;
            }
            set
            {
                mGASTOF2 = value;
            }
        }

        public Double GASTOF3
        {
            get
            {
                return mGASTOF3;
            }
            set
            {
                mGASTOF3 = value;
            }
        }

        public Double GASTOF_EXE
        {
            get
            {
                return mGASTOF_EXE;
            }
            set
            {
                mGASTOF_EXE = value;
            }
        }

        public Double GASTO_EXE
        {
            get
            {
                return mGASTO_EXE;
            }
            set
            {
                mGASTO_EXE = value;
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

        public int ID_RETEN
        {
            get
            {
                return mID_RETEN;
            }
            set
            {
                mID_RETEN = value;
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

        public Double IMP_GAS1
        {
            get
            {
                return mIMP_GAS1;
            }
            set
            {
                mIMP_GAS1 = value;
            }
        }

        public Double IMP_GAS2
        {
            get
            {
                return mIMP_GAS2;
            }
            set
            {
                mIMP_GAS2 = value;
            }
        }

        public Double IMP_GAS3
        {
            get
            {
                return mIMP_GAS3;
            }
            set
            {
                mIMP_GAS3 = value;
            }
        }

        public Double IMP_GASF1
        {
            get
            {
                return mIMP_GASF1;
            }
            set
            {
                mIMP_GASF1 = value;
            }
        }

        public Double IMP_GASF2
        {
            get
            {
                return mIMP_GASF2;
            }
            set
            {
                mIMP_GASF2 = value;
            }
        }

        public Double IMP_GASF3
        {
            get
            {
                return mIMP_GASF3;
            }
            set
            {
                mIMP_GASF3 = value;
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

        public string NRORETEN
        {
            get
            {
                return mNRORETEN;
            }
            set
            {
                mNRORETEN = value;
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

        public Double POR_DESG
        {
            get
            {
                return mPOR_DESG;
            }
            set
            {
                mPOR_DESG = value;
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

        public int PROVEEID
        {
            get
            {
                return mPROVEEID;
            }
            set
            {
                mPROVEEID = value;
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

        public Double TDES1
        {
            get
            {
                return mTDES1;
            }
            set
            {
                mTDES1 = value;
            }
        }

        public Double TDES2
        {
            get
            {
                return mTDES2;
            }
            set
            {
                mTDES2 = value;
            }
        }

        public Double TDES3
        {
            get
            {
                return mTDES3;
            }
            set
            {
                mTDES3 = value;
            }
        }

        public Double TDES4
        {
            get
            {
                return mTDES4;
            }
            set
            {
                mTDES4 = value;
            }
        }

        public Double TDES5
        {
            get
            {
                return mTDES5;
            }
            set
            {
                mTDES5 = value;
            }
        }

        public Double TDES6
        {
            get
            {
                return mTDES6;
            }
            set
            {
                mTDES6 = value;
            }
        }

        public string TELE
        {
            get
            {
                return mTELE;
            }
            set
            {
                mTELE = value;
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

        DCOMPRAS()
        {
        }

        DCOMPRAS(double BASE1, double BASE2, double BASE3, double DES1, double DES2, double DES3, double DES4, double DES5, double DES6, double DESCU, double DESCU1, double DESCU2, double DESCU3, double DESCU4, double DESCU5, double DESCU6, string DIRECCION, string ESTADO, double EXENTO, DateTime FECHA, string FECHAC, DateTime FECHAV, DateTime F_RETEN, double GASTO1, double GASTO2, double GASTO3, double GASTOF1, double GASTOF2, double GASTOF3, double GASTOF_EXE, double GASTO_EXE, int ID, int IDSUC, int ID_RETEN, double IMP1, double IMP2, double IMP3, double IMPUESTOA, double IMP_GAS1, double IMP_GAS2, double IMP_GAS3, double IMP_GASF1, double IMP_GASF2, double IMP_GASF3, double IVA, double MONTO, string NIT, string NOMBRE, double NRO, string NROC, string NRORETEN, double PDESCU, double POR_DESG, string PROVEE, int PROVEEID, string RIF, double TAX1, double TAX2, double TAX3, double TDES1, double TDES2, double TDES3, double TDES4, double TDES5, double TDES6, string TELE, double TOTAL, string UID)
        {
            mBASE1 = BASE1;
            mBASE2 = BASE2;
            mBASE3 = BASE3;
            mDES1 = DES1;
            mDES2 = DES2;
            mDES3 = DES3;
            mDES4 = DES4;
            mDES5 = DES5;
            mDES6 = DES6;
            mDESCU = DESCU;
            mDESCU1 = DESCU1;
            mDESCU2 = DESCU2;
            mDESCU3 = DESCU3;
            mDESCU4 = DESCU4;
            mDESCU5 = DESCU5;
            mDESCU6 = DESCU6;
            mDIRECCION = DIRECCION;
            mESTADO = ESTADO;
            mEXENTO = EXENTO;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFECHAV = FECHAV;
            mF_RETEN = F_RETEN;
            mGASTO1 = GASTO1;
            mGASTO2 = GASTO2;
            mGASTO3 = GASTO3;
            mGASTOF1 = GASTOF1;
            mGASTOF2 = GASTOF2;
            mGASTOF3 = GASTOF3;
            mGASTOF_EXE = GASTOF_EXE;
            mGASTO_EXE = GASTO_EXE;
            mID = ID;
            mIDSUC = IDSUC;
            mID_RETEN = ID_RETEN;
            mIMP1 = IMP1;
            mIMP2 = IMP2;
            mIMP3 = IMP3;
            mIMPUESTOA = IMPUESTOA;
            mIMP_GAS1 = IMP_GAS1;
            mIMP_GAS2 = IMP_GAS2;
            mIMP_GAS3 = IMP_GAS3;
            mIMP_GASF1 = IMP_GASF1;
            mIMP_GASF2 = IMP_GASF2;
            mIMP_GASF3 = IMP_GASF3;
            mIVA = IVA;
            mMONTO = MONTO;
            mNIT = NIT;
            mNOMBRE = NOMBRE;
            mNRO = NRO;
            mNROC = NROC;
            mNRORETEN = NRORETEN;
            mPDESCU = PDESCU;
            mPOR_DESG = POR_DESG;
            mPROVEE = PROVEE;
            mPROVEEID = PROVEEID;
            mRIF = RIF;
            mTAX1 = TAX1;
            mTAX2 = TAX2;
            mTAX3 = TAX3;
            mTDES1 = TDES1;
            mTDES2 = TDES2;
            mTDES3 = TDES3;
            mTDES4 = TDES4;
            mTDES5 = TDES5;
            mTDES6 = TDES6;
            mTELE = TELE;
            mTOTAL = TOTAL;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
