using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Sucursales : ICloneable
    {

        private int mID = 0;
        private int mID_SucursalMaster = 0;
        private string mSucursal = "";
        private int mId_Empresa = 0;
        private string mIdentificador = "";
        private string mDireccion1 = "";
        private string mDireccion2 = "";
        private string mDireccionWeb = "";
        private int mId_WorldLocalidades = 0;
        private int mId_WorldRegiones = 0;
        private int mId_WorldParises = 0;
        private int mId_VenMunicipios = 0;
        private int mId_VenParroquias = 0;
        private string mContacto = "";
        private string mTelefonoContacto = "";
        private string mTelefonoSucursal = "";
        private string mRIF = "";
        private string mRIFMaster = "";
        private bool mEsActivo = false;

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

        public int ID_SucursalMaster
        {
            get
            {
                return mID_SucursalMaster;
            }
            set
            {
                mID_SucursalMaster = value;
            }
        }

        public string Sucursal
        {
            get
            {
                return mSucursal;
            }
            set
            {
                mSucursal = value;
            }
        }

        public int Id_Empresa
        {
            get
            {
                return mId_Empresa;
            }
            set
            {
                mId_Empresa = value;
            }
        }

        public string Identificador
        {
            get
            {
                return mIdentificador;
            }
            set
            {
                mIdentificador = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return mDireccion1;
            }
            set
            {
                mDireccion1 = value;
            }
        }

        public string Direccion2
        {
            get
            {
                return mDireccion2;
            }
            set
            {
                mDireccion2 = value;
            }
        }

        public string DireccionWeb
        {
            get
            {
                return mDireccionWeb;
            }
            set
            {
                mDireccionWeb = value;
            }
        }

        public int Id_WorldLocalidades
        {
            get
            {
                return mId_WorldLocalidades;
            }
            set
            {
                mId_WorldLocalidades = value;
            }
        }

        public int Id_WorldRegiones
        {
            get
            {
                return mId_WorldRegiones;
            }
            set
            {
                mId_WorldRegiones = value;
            }
        }

        public int Id_WorldParises
        {
            get
            {
                return mId_WorldParises;
            }
            set
            {
                mId_WorldParises = value;
            }
        }

        public int Id_VenMunicipios
        {
            get
            {
                return mId_VenMunicipios;
            }
            set
            {
                mId_VenMunicipios = value;
            }
        }

        public int Id_VenParroquias
        {
            get
            {
                return mId_VenParroquias;
            }
            set
            {
                mId_VenParroquias = value;
            }
        }

        public string Contacto
        {
            get
            {
                return mContacto;
            }
            set
            {
                mContacto = value;
            }
        }

        public string TelefonoContacto
        {
            get
            {
                return mTelefonoContacto;
            }
            set
            {
                mTelefonoContacto = value;
            }
        }

        public string TelefonoSucursal
        {
            get
            {
                return mTelefonoSucursal;
            }
            set
            {
                mTelefonoSucursal = value;
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

        public string RIFMaster
        {
            get
            {
                return mRIFMaster;
            }
            set
            {
                mRIFMaster = value;
            }
        }

        public Boolean EsActivo
        {
            get
            {
                return mEsActivo;
            }
            set
            {
                mEsActivo = value;
            }
        }

        Sucursales()
        {
        }

        Sucursales(int ID, int ID_SucursalMaster, string Sucursal, int id_Empresa, string Identificador, string Direccion1, string Direccion2, string DireccionWeb, int id_WorldLocalidades, int id_WorldRegiones, int id_WorldParises, int id_VenMunicipios, int id_VenParroquias, string Contacto, string TelefonoContacto, string TelefonoSucursal, string RIF, string RIFMaster, bool esActivo)
        {
            mID = ID;
            mID_SucursalMaster = ID_SucursalMaster;
            mSucursal = Sucursal;
            mId_Empresa = Id_Empresa;
            mIdentificador = Identificador;
            mDireccion1 = Direccion1;
            mDireccion2 = Direccion2;
            mDireccionWeb = DireccionWeb;
            mId_WorldLocalidades = Id_WorldLocalidades;
            mId_WorldRegiones = Id_WorldRegiones;
            mId_WorldParises = Id_WorldParises;
            mId_VenMunicipios = Id_VenMunicipios;
            mId_VenParroquias = Id_VenParroquias;
            mContacto = Contacto;
            mTelefonoContacto = TelefonoContacto;
            mTelefonoSucursal = TelefonoSucursal;
            mRIF = RIF;
            mRIFMaster = RIFMaster;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
