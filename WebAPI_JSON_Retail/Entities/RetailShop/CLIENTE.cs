using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE : ICloneable
    {

        private bool mACTIVO = false;
        private string mCALLE = "";
        private string mCASA = "";
        private string mCCONTABLE = "";
        private string mCIUDAD = "";
        private string mCODESTA = "";
        private string mCODEXT = "";
        private string mCODEZIP = "";
        private string mCODIGO = "";
        private string mCODIGOBP = "";
        private double mCODJDE = 0.0;
        private double mCONTRI = 0.0;
        private double mCREDITOBP = 0.0;
        private double mCREDITOS = 0.0;
        private double mCRE_PUNTOS = 0.0;
        private double mDEBITOS = 0.0;
        private double mDEB_PUNTOS = 0.0;
        private string mDESTINO = "";
        private DateTime mDIAS = new DateTime(2000, 01, 01);
        private double mDIASC = 0.0;
        private double mDIASCRE = 0.0;
        private string mDIRECCION = "";
        private string mDZONA = "";
        private string mEMAIL = "";
        private string mESTADO = "";
        private DateTime mFECHAU = new DateTime(2000, 01, 01);
        private DateTime mFECHA_AFI = new DateTime(2000, 01, 01);
        private string mGRUPO = "";
        private int mID = 0;
        private int mIDCIUDAD = 0;
        private int mIDESTADO = 0;
        private int mIDPAIS = 0;
        private int mID_MASTER = 0;
        private int mID_RUTA = 0;
        private int mID_SECTOR = 0;
        private double mINCLUIR = 0.0;
        private string mLICENCIA = "";
        private double mMONTO = 0.0;
        private double mMOSTRAR = 0.0;
        private string mNIT = "";
        private double mNIVELCRE = 0.0;
        private double mNIVELPRE = 0.0;
        private string mNOMBRE = "";
        private string mNRO = "";
        private string mOBSERVA = "";
        private string mPASAPOR = "";
        private string mPLACA = "";
        private string mREFERENCIA = "";
        private string mRIF = "";
        private string mTELEFONO = "";
        private double mTIPOCLI = 0.0;
        private int mTIPO_AFI = 0;
        private double mTNIVELC = 0.0;
        private string mTPRECIO = "";
        private string mURB = "";
        private string mVEHICULO = "";
        private string mVENDEDOR = "";
        private string mZONA = "";

        public Boolean ACTIVO
        {
            get
            {
                return mACTIVO;
            }
            set
            {
                mACTIVO = value;
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

        public string CODESTA
        {
            get
            {
                return mCODESTA;
            }
            set
            {
                mCODESTA = value;
            }
        }

        public string CODEXT
        {
            get
            {
                return mCODEXT;
            }
            set
            {
                mCODEXT = value;
            }
        }

        public string CODEZIP
        {
            get
            {
                return mCODEZIP;
            }
            set
            {
                mCODEZIP = value;
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

        public Double CODJDE
        {
            get
            {
                return mCODJDE;
            }
            set
            {
                mCODJDE = value;
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

        public Double CREDITOBP
        {
            get
            {
                return mCREDITOBP;
            }
            set
            {
                mCREDITOBP = value;
            }
        }

        public Double CREDITOS
        {
            get
            {
                return mCREDITOS;
            }
            set
            {
                mCREDITOS = value;
            }
        }

        public Double CRE_PUNTOS
        {
            get
            {
                return mCRE_PUNTOS;
            }
            set
            {
                mCRE_PUNTOS = value;
            }
        }

        public Double DEBITOS
        {
            get
            {
                return mDEBITOS;
            }
            set
            {
                mDEBITOS = value;
            }
        }

        public Double DEB_PUNTOS
        {
            get
            {
                return mDEB_PUNTOS;
            }
            set
            {
                mDEB_PUNTOS = value;
            }
        }

        public string DESTINO
        {
            get
            {
                return mDESTINO;
            }
            set
            {
                mDESTINO = value;
            }
        }

        public DateTime DIAS
        {
            get
            {
                return mDIAS;
            }
            set
            {
                mDIAS = value;
            }
        }

        public Double DIASC
        {
            get
            {
                return mDIASC;
            }
            set
            {
                mDIASC = value;
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

        public string DZONA
        {
            get
            {
                return mDZONA;
            }
            set
            {
                mDZONA = value;
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

        public DateTime FECHAU
        {
            get
            {
                return mFECHAU;
            }
            set
            {
                mFECHAU = value;
            }
        }

        public DateTime FECHA_AFI
        {
            get
            {
                return mFECHA_AFI;
            }
            set
            {
                mFECHA_AFI = value;
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

        public int ID_MASTER
        {
            get
            {
                return mID_MASTER;
            }
            set
            {
                mID_MASTER = value;
            }
        }

        public int ID_RUTA
        {
            get
            {
                return mID_RUTA;
            }
            set
            {
                mID_RUTA = value;
            }
        }

        public int ID_SECTOR
        {
            get
            {
                return mID_SECTOR;
            }
            set
            {
                mID_SECTOR = value;
            }
        }

        public Double INCLUIR
        {
            get
            {
                return mINCLUIR;
            }
            set
            {
                mINCLUIR = value;
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

        public Double MOSTRAR
        {
            get
            {
                return mMOSTRAR;
            }
            set
            {
                mMOSTRAR = value;
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

        public Double NIVELCRE
        {
            get
            {
                return mNIVELCRE;
            }
            set
            {
                mNIVELCRE = value;
            }
        }

        public Double NIVELPRE
        {
            get
            {
                return mNIVELPRE;
            }
            set
            {
                mNIVELPRE = value;
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

        public string NRO
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

        public string PASAPOR
        {
            get
            {
                return mPASAPOR;
            }
            set
            {
                mPASAPOR = value;
            }
        }

        public string PLACA
        {
            get
            {
                return mPLACA;
            }
            set
            {
                mPLACA = value;
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

        public Double TIPOCLI
        {
            get
            {
                return mTIPOCLI;
            }
            set
            {
                mTIPOCLI = value;
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

        public Double TNIVELC
        {
            get
            {
                return mTNIVELC;
            }
            set
            {
                mTNIVELC = value;
            }
        }

        public string TPRECIO
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

        public string VEHICULO
        {
            get
            {
                return mVEHICULO;
            }
            set
            {
                mVEHICULO = value;
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

        CLIENTE()
        {
        }

        CLIENTE(bool ACTIVO, string CALLE, string CASA, string CCONTABLE, string CIUDAD, string CODESTA, string CODEXT, string CODEZIP, string CODIGO, string CODIGOBP, double CODJDE, double CONTRI, double CREDITOBP, double CREDITOS, double CRE_PUNTOS, double DEBITOS, double DEB_PUNTOS, string DESTINO, DateTime DIAS, double DIASC, double DIASCRE, string DIRECCION, string DZONA, string EMAIL, string ESTADO, DateTime FECHAU, DateTime FECHA_AFI, string GRUPO, int ID, int IDCIUDAD, int IDESTADO, int IDPAIS, int ID_MASTER, int ID_RUTA, int ID_SECTOR, double INCLUIR, string LICENCIA, double MONTO, double MOSTRAR, string NIT, double NIVELCRE, double NIVELPRE, string NOMBRE, string NRO, string OBSERVA, string PASAPOR, string PLACA, string REFERENCIA, string RIF, string TELEFONO, double TIPOCLI, int TIPO_AFI, double TNIVELC, string TPRECIO, string URB, string VEHICULO, string VENDEDOR, string ZONA)
        {
            mACTIVO = ACTIVO;
            mCALLE = CALLE;
            mCASA = CASA;
            mCCONTABLE = CCONTABLE;
            mCIUDAD = CIUDAD;
            mCODESTA = CODESTA;
            mCODEXT = CODEXT;
            mCODEZIP = CODEZIP;
            mCODIGO = CODIGO;
            mCODIGOBP = CODIGOBP;
            mCODJDE = CODJDE;
            mCONTRI = CONTRI;
            mCREDITOBP = CREDITOBP;
            mCREDITOS = CREDITOS;
            mCRE_PUNTOS = CRE_PUNTOS;
            mDEBITOS = DEBITOS;
            mDEB_PUNTOS = DEB_PUNTOS;
            mDESTINO = DESTINO;
            mDIAS = DIAS;
            mDIASC = DIASC;
            mDIASCRE = DIASCRE;
            mDIRECCION = DIRECCION;
            mDZONA = DZONA;
            mEMAIL = EMAIL;
            mESTADO = ESTADO;
            mFECHAU = FECHAU;
            mFECHA_AFI = FECHA_AFI;
            mGRUPO = GRUPO;
            mID = ID;
            mIDCIUDAD = IDCIUDAD;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
            mID_MASTER = ID_MASTER;
            mID_RUTA = ID_RUTA;
            mID_SECTOR = ID_SECTOR;
            mINCLUIR = INCLUIR;
            mLICENCIA = LICENCIA;
            mMONTO = MONTO;
            mMOSTRAR = MOSTRAR;
            mNIT = NIT;
            mNIVELCRE = NIVELCRE;
            mNIVELPRE = NIVELPRE;
            mNOMBRE = NOMBRE;
            mNRO = NRO;
            mOBSERVA = OBSERVA;
            mPASAPOR = PASAPOR;
            mPLACA = PLACA;
            mREFERENCIA = REFERENCIA;
            mRIF = RIF;
            mTELEFONO = TELEFONO;
            mTIPOCLI = TIPOCLI;
            mTIPO_AFI = TIPO_AFI;
            mTNIVELC = TNIVELC;
            mTPRECIO = TPRECIO;
            mURB = URB;
            mVEHICULO = VEHICULO;
            mVENDEDOR = VENDEDOR;
            mZONA = ZONA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
