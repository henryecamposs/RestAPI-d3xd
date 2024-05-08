using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes : ICloneable
    {

        private int mID = 0;
        private int mId_TipoImpuesto = 0;
        private int mId_TipoGrupoCLiente = 0;
        private int mId_TipoPago = 0;
        private int mId_Estado = 0;
        private int mId_Municipio = 0;
        private int mId_Parroquia = 0;
        private int mId_Profesion = 0;
        private int mId_defTipoNacionalidad = 0;
        private int mId_defTipoSexo = 0;
        private string mNombres = "";
        private string mApellidos = "";
        private string mDireccion = "";
        private string mCI = "";
        private int mCodigoPostal = 0;
        private string mEmail = "";
        private string mPasaporte = "";
        private string mTelefono = "";
        private string mTelefonoMovil = "";
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaNac = new DateTime(2000, 01, 01);
        private string mComentario = "";
        private bool mEsEmpresa = false;
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

        public int Id_TipoImpuesto
        {
            get
            {
                return mId_TipoImpuesto;
            }
            set
            {
                mId_TipoImpuesto = value;
            }
        }

        public int Id_TipoGrupoCLiente
        {
            get
            {
                return mId_TipoGrupoCLiente;
            }
            set
            {
                mId_TipoGrupoCLiente = value;
            }
        }

        public int Id_TipoPago
        {
            get
            {
                return mId_TipoPago;
            }
            set
            {
                mId_TipoPago = value;
            }
        }

        public int Id_Estado
        {
            get
            {
                return mId_Estado;
            }
            set
            {
                mId_Estado = value;
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

        public int Id_Profesion
        {
            get
            {
                return mId_Profesion;
            }
            set
            {
                mId_Profesion = value;
            }
        }

        public int Id_defTipoNacionalidad
        {
            get
            {
                return mId_defTipoNacionalidad;
            }
            set
            {
                mId_defTipoNacionalidad = value;
            }
        }

        public int Id_defTipoSexo
        {
            get
            {
                return mId_defTipoSexo;
            }
            set
            {
                mId_defTipoSexo = value;
            }
        }

        public string Nombres
        {
            get
            {
                return mNombres;
            }
            set
            {
                mNombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return mApellidos;
            }
            set
            {
                mApellidos = value;
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

        public string CI
        {
            get
            {
                return mCI;
            }
            set
            {
                mCI = value;
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

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Pasaporte
        {
            get
            {
                return mPasaporte;
            }
            set
            {
                mPasaporte = value;
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

        public string TelefonoMovil
        {
            get
            {
                return mTelefonoMovil;
            }
            set
            {
                mTelefonoMovil = value;
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return mFechaActual;
            }
            set
            {
                mFechaActual = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return mFechaNac;
            }
            set
            {
                mFechaNac = value;
            }
        }

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public Boolean EsEmpresa
        {
            get
            {
                return mEsEmpresa;
            }
            set
            {
                mEsEmpresa = value;
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

        Clientes()
        {
        }

        Clientes(int ID, int id_TipoImpuesto, int id_TipoGrupoCLiente, int id_TipoPago, int id_Estado, int id_Municipio, int id_Parroquia, int id_Profesion, int id_defTipoNacionalidad, int id_defTipoSexo, string Nombres, string Apellidos, string Direccion, string CI, int CodigoPostal, string Email, string Pasaporte, string Telefono, string TelefonoMovil, DateTime FechaActual, DateTime FechaNac, string Comentario, bool esEmpresa, bool esActivo)
        {
            mID = ID;
            mId_TipoImpuesto = Id_TipoImpuesto;
            mId_TipoGrupoCLiente = Id_TipoGrupoCLiente;
            mId_TipoPago = Id_TipoPago;
            mId_Estado = Id_Estado;
            mId_Municipio = Id_Municipio;
            mId_Parroquia = Id_Parroquia;
            mId_Profesion = Id_Profesion;
            mId_defTipoNacionalidad = Id_defTipoNacionalidad;
            mId_defTipoSexo = Id_defTipoSexo;
            mNombres = Nombres;
            mApellidos = Apellidos;
            mDireccion = Direccion;
            mCI = CI;
            mCodigoPostal = CodigoPostal;
            mEmail = Email;
            mPasaporte = Pasaporte;
            mTelefono = Telefono;
            mTelefonoMovil = TelefonoMovil;
            mFechaActual = FechaActual;
            mFechaNac = FechaNac;
            mComentario = Comentario;
            mEsEmpresa = EsEmpresa;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
