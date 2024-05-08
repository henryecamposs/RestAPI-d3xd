using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Empresa : ICloneable
    {

        private int mID = 0;
        private int mId_Licencia = 0;
        private int mId_TipoComercio = 0;
        private int mId_Ciudad = 0;
        private int mId_Municipio = 0;
        private int mId_Parroquia = 0;
        private int mId_idioma = 0;
        private int mId_Sucursal = 0;
        private string mNIT = "";
        private string mRIF = "";
        private string mDescripcion = "";
        private string mDireccion = "";
        private string mTelefono = "";
        private int mCodigoPostal = 0;
        private string mContacto = "";
        private string mImagenArchivo = "";
        private string mTelefonoContacto = "";
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

        public int Id_Licencia
        {
            get
            {
                return mId_Licencia;
            }
            set
            {
                mId_Licencia = value;
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

        public int Id_Ciudad
        {
            get
            {
                return mId_Ciudad;
            }
            set
            {
                mId_Ciudad = value;
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

        public int Id_idioma
        {
            get
            {
                return mId_idioma;
            }
            set
            {
                mId_idioma = value;
            }
        }

        public int Id_Sucursal
        {
            get
            {
                return mId_Sucursal;
            }
            set
            {
                mId_Sucursal = value;
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

        Empresa()
        {
        }

        Empresa(int ID, int id_Licencia, int id_TipoComercio, int Id_Ciudad, int id_Municipio, int Id_Parroquia, int id_idioma, int id_Sucursal, string NIT, string RIF, string Descripcion, string Direccion, string Telefono, int CodigoPostal, string Contacto, string ImagenArchivo, string TelefonoContacto, bool esActivo)
        {
            mID = ID;
            mId_Licencia = Id_Licencia;
            mId_TipoComercio = Id_TipoComercio;
            mId_Ciudad = Id_Ciudad;
            mId_Municipio = Id_Municipio;
            mId_Parroquia = Id_Parroquia;
            mId_idioma = Id_idioma;
            mId_Sucursal = Id_Sucursal;
            mNIT = NIT;
            mRIF = RIF;
            mDescripcion = Descripcion;
            mDireccion = Direccion;
            mTelefono = Telefono;
            mCodigoPostal = CodigoPostal;
            mContacto = Contacto;
            mImagenArchivo = ImagenArchivo;
            mTelefonoContacto = TelefonoContacto;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
