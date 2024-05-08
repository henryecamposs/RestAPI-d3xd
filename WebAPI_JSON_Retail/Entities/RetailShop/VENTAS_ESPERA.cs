using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VENTAS_ESPERA : ICloneable
    {

        private double mBONOD = 0.0;
        private string mCAJA = "";
        private double mCANTI = 0.0;
        private int mCLIENTE = 0;
        private int mCODCLI = 0;
        private double mCONTRI = 0.0;
        private double mDESCU = 0.0;
        private string mDIRECCION = "";
        private string mEMPLE = "";
        private double mEXENTO = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private DateTime mFLIMITE = new DateTime(2000, 01, 01);
        private string mHORA = "";
        private string mHORAA = "";
        private int mID = 0;
        private int mIDCIUDAD = 0;
        private int mIDESTADO = 0;
        private int mIDPAIS = 0;
        private double mIVA = 0.0;
        private double mIVA1 = 0.0;
        private double mIVA2 = 0.0;
        private double mIVA3 = 0.0;
        private string mLICENCIA = "";
        private double mLIMITE = 0.0;
        private double mMONTO = 0.0;
        private string mNIT = "";
        private string mNOMCLI = "";
        private string mNOMEMP = "";
        private double mNRO = 0.0;
        private double mPDESCU = 0.0;
        private string mREFERENCIA = "";
        private string mRIF = "";
        private double mSALDO = 0.0;
        private double mSERVICIO = 0.0;
        private double mTDESCU = 0.0;
        private string mTELEFONO = "";
        private double mTOTAL = 0.0;
        private double mTPRECIO = 0.0;

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

        public DateTime FLIMITE
        {
            get
            {
                return mFLIMITE;
            }
            set
            {
                mFLIMITE = value;
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

        public Double LIMITE
        {
            get
            {
                return mLIMITE;
            }
            set
            {
                mLIMITE = value;
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

        public Double SALDO
        {
            get
            {
                return mSALDO;
            }
            set
            {
                mSALDO = value;
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

        VENTAS_ESPERA()
        {
        }

        VENTAS_ESPERA(double BONOD, string CAJA, double CANTI, int CLIENTE, int CODCLI, double CONTRI, double DESCU, string DIRECCION, string EMPLE, double EXENTO, DateTime FECHA, string FECHAC, DateTime FLIMITE, string HORA, string HORAA, int ID, int IDCIUDAD, int IDESTADO, int IDPAIS, double IVA, double IVA1, double IVA2, double IVA3, string LICENCIA, double LIMITE, double MONTO, string NIT, string NOMCLI, string NOMEMP, double NRO, double PDESCU, string REFERENCIA, string RIF, double SALDO, double SERVICIO, double TDESCU, string TELEFONO, double TOTAL, double TPRECIO)
        {
            mBONOD = BONOD;
            mCAJA = CAJA;
            mCANTI = CANTI;
            mCLIENTE = CLIENTE;
            mCODCLI = CODCLI;
            mCONTRI = CONTRI;
            mDESCU = DESCU;
            mDIRECCION = DIRECCION;
            mEMPLE = EMPLE;
            mEXENTO = EXENTO;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mFLIMITE = FLIMITE;
            mHORA = HORA;
            mHORAA = HORAA;
            mID = ID;
            mIDCIUDAD = IDCIUDAD;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
            mIVA = IVA;
            mIVA1 = IVA1;
            mIVA2 = IVA2;
            mIVA3 = IVA3;
            mLICENCIA = LICENCIA;
            mLIMITE = LIMITE;
            mMONTO = MONTO;
            mNIT = NIT;
            mNOMCLI = NOMCLI;
            mNOMEMP = NOMEMP;
            mNRO = NRO;
            mPDESCU = PDESCU;
            mREFERENCIA = REFERENCIA;
            mRIF = RIF;
            mSALDO = SALDO;
            mSERVICIO = SERVICIO;
            mTDESCU = TDESCU;
            mTELEFONO = TELEFONO;
            mTOTAL = TOTAL;
            mTPRECIO = TPRECIO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
