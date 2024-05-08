using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_DIRECCION : ICloneable
    {

        private double mCODJDE = 0.0;
        private string mDIRECCION = "";
        private int mID = 0;
        private int mIDCIUDAD = 0;
        private int mIDCLI = 0;
        private int mIDESTADO = 0;
        private int mIDPAIS = 0;
        private int mID_RUTA = 0;
        private int mID_SECTOR = 0;
        private string mTELEFONO = "";
        private DateTime mFecha_act = new DateTime(2000, 01, 01);

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

        public int IDCLI
        {
            get
            {
                return mIDCLI;
            }
            set
            {
                mIDCLI = value;
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

        public DateTime Fecha_act
        {
            get
            {
                return mFecha_act;
            }
            set
            {
                mFecha_act = value;
            }
        }

        CLIENTE_DIRECCION()
        {
        }

        CLIENTE_DIRECCION(double CODJDE, string DIRECCION, int ID, int IDCIUDAD, int IDCLI, int IDESTADO, int IDPAIS, int ID_RUTA, int ID_SECTOR, string TELEFONO, DateTime fecha_act)
        {
            mCODJDE = CODJDE;
            mDIRECCION = DIRECCION;
            mID = ID;
            mIDCIUDAD = IDCIUDAD;
            mIDCLI = IDCLI;
            mIDESTADO = IDESTADO;
            mIDPAIS = IDPAIS;
            mID_RUTA = ID_RUTA;
            mID_SECTOR = ID_SECTOR;
            mTELEFONO = TELEFONO;
            mFecha_act = Fecha_act;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
