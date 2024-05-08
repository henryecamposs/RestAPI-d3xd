using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Proveedores : ICloneable
    {

        private int mID = 0;
        private int mId_Municipio = 0;
        private int mId_Parroquia = 0;
        private int mId_TipoComercio = 0;
        private int mId_defTipoOrigenProveedor = 0;
        private int mId_defTipoProveedor = 0;
        private string mDescripcion = "";
        private string mRIF = "";
        private string mDireccion = "";
        private string mTelefono = "";
        private int mCodigoPostal = 0;
        private string mContacto = "";
        private string mImagenArchivo = "";
        private string mNIT = "";
        private string mFax = "";
        private string mNombreContacto = "";
        private string mNombreGerente = "";
        private string mEmailContacto = "";
        private string mEmailGerente = "";
        private string mTelefonoContacto = "";
        private string mTelefonoGerente = "";
        private string mFechaNacGerente = "";
        private string mFechaNacContacto = "";
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

        public int Id_Municipio
        {
            get
            {
                return mId_Municipio;
            }
            set
            {
                mId_Municipio = value;
            }
        }

        public int Id_Parroquia
        {
            get
            {
                return mId_Parroquia;
            }
            set
            {
                mId_Parroquia = value;
            }
        }

        public int Id_TipoComercio
        {
            get
            {
                return mId_TipoComercio;
            }
            set
            {
                mId_TipoComercio = value;
            }
        }

        public int Id_defTipoOrigenProveedor
        {
            get
            {
                return mId_defTipoOrigenProveedor;
            }
            set
            {
                mId_defTipoOrigenProveedor = value;
            }
        }

        public int Id_defTipoProveedor
        {
            get
            {
                return mId_defTipoProveedor;
            }
            set
            {
                mId_defTipoProveedor = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
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

        public string Direccion
        {
            get
            {
                return mDireccion;
            }
            set
            {
                mDireccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return mTelefono;
            }
            set
            {
                mTelefono = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return mCodigoPostal;
            }
            set
            {
                mCodigoPostal = value;
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

        public string ImagenArchivo
        {
            get
            {
                return mImagenArchivo;
            }
            set
            {
                mImagenArchivo = value;
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

        public string Fax
        {
            get
            {
                return mFax;
            }
            set
            {
                mFax = value;
            }
        }

        public string NombreContacto
        {
            get
            {
                return mNombreContacto;
            }
            set
            {
                mNombreContacto = value;
            }
        }

        public string NombreGerente
        {
            get
            {
                return mNombreGerente;
            }
            set
            {
                mNombreGerente = value;
            }
        }

        public string EmailContacto
        {
            get
            {
                return mEmailContacto;
            }
            set
            {
                mEmailContacto = value;
            }
        }

        public string EmailGerente
        {
            get
            {
                return mEmailGerente;
            }
            set
            {
                mEmailGerente = value;
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

        public string TelefonoGerente
        {
            get
            {
                return mTelefonoGerente;
            }
            set
            {
                mTelefonoGerente = value;
            }
        }

        public string FechaNacGerente
        {
            get
            {
                return mFechaNacGerente;
            }
            set
            {
                mFechaNacGerente = value;
            }
        }

        public string FechaNacContacto
        {
            get
            {
                return mFechaNacContacto;
            }
            set
            {
                mFechaNacContacto = value;
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

        Proveedores()
        {
        }

        Proveedores(int ID, int id_Municipio, int Id_Parroquia, int id_TipoComercio, int id_defTipoOrigenProveedor, int id_defTipoProveedor, string Descripcion, string RIF, string Direccion, string Telefono, int CodigoPostal, string Contacto, string ImagenArchivo, string NIT, string Fax, string NombreContacto, string NombreGerente, string EmailContacto, string EmailGerente, string TelefonoContacto, string TelefonoGerente, string FechaNacGerente, string FechaNacContacto, bool esActivo)
        {
            mID = ID;
            mId_Municipio = Id_Municipio;
            mId_Parroquia = Id_Parroquia;
            mId_TipoComercio = Id_TipoComercio;
            mId_defTipoOrigenProveedor = Id_defTipoOrigenProveedor;
            mId_defTipoProveedor = Id_defTipoProveedor;
            mDescripcion = Descripcion;
            mRIF = RIF;
            mDireccion = Direccion;
            mTelefono = Telefono;
            mCodigoPostal = CodigoPostal;
            mContacto = Contacto;
            mImagenArchivo = ImagenArchivo;
            mNIT = NIT;
            mFax = Fax;
            mNombreContacto = NombreContacto;
            mNombreGerente = NombreGerente;
            mEmailContacto = EmailContacto;
            mEmailGerente = EmailGerente;
            mTelefonoContacto = TelefonoContacto;
            mTelefonoGerente = TelefonoGerente;
            mFechaNacGerente = FechaNacGerente;
            mFechaNacContacto = FechaNacContacto;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
