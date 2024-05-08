using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Empleados : ICloneable
    {

        private int mID = 0;
        private int mId_Ciudad = 0;
        private int mId_Municipio = 0;
        private int mId_Parroquia = 0;
        private int mId_Profesion = 0;
        private int mId_TipoCargo = 0;
        private int mId_TipoContrato = 0;
        private int mId_defTipoNacionalidad = 0;
        private string mNombres = "";
        private string mApellidos = "";
        private string mCI = "";
        private string mDireccion = "";
        private string mTelefono = "";
        private string mRIF = "";
        private int mCodigoPostal = 0;
        private string mEmail = "";
        private string mTelefono_movil = "";
        private string mOcupacion = "";
        private string mNota = "";
        private string mFoto_Archivo = "";
        private DateTime mFecha_Ingreso = new DateTime(2000, 01, 01);
        private DateTime mFecha_Egreso = new DateTime(2000, 01, 01);
        private double mMontoSueldoIngreso = 0.0;
        private double mMontoSueldoActual = 0.0;
        private bool mEsActivo = false;
        private int mId_Sucursal = 0;

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

        public int Id_TipoCargo
        {
            get
            {
                return mId_TipoCargo;
            }
            set
            {
                mId_TipoCargo = value;
            }
        }

        public int Id_TipoContrato
        {
            get
            {
                return mId_TipoContrato;
            }
            set
            {
                mId_TipoContrato = value;
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

        public string Telefono_movil
        {
            get
            {
                return mTelefono_movil;
            }
            set
            {
                mTelefono_movil = value;
            }
        }

        public string Ocupacion
        {
            get
            {
                return mOcupacion;
            }
            set
            {
                mOcupacion = value;
            }
        }

        public string Nota
        {
            get
            {
                return mNota;
            }
            set
            {
                mNota = value;
            }
        }

        public string Foto_Archivo
        {
            get
            {
                return mFoto_Archivo;
            }
            set
            {
                mFoto_Archivo = value;
            }
        }

        public DateTime Fecha_Ingreso
        {
            get
            {
                return mFecha_Ingreso;
            }
            set
            {
                mFecha_Ingreso = value;
            }
        }

        public DateTime Fecha_Egreso
        {
            get
            {
                return mFecha_Egreso;
            }
            set
            {
                mFecha_Egreso = value;
            }
        }

        public Double MontoSueldoIngreso
        {
            get
            {
                return mMontoSueldoIngreso;
            }
            set
            {
                mMontoSueldoIngreso = value;
            }
        }

        public Double MontoSueldoActual
        {
            get
            {
                return mMontoSueldoActual;
            }
            set
            {
                mMontoSueldoActual = value;
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

        Empleados()
        {
        }

        Empleados(int ID, int id_Ciudad, int id_Municipio, int id_Parroquia, int id_Profesion, int id_TipoCargo, int id_TipoContrato, int id_defTipoNacionalidad, string Nombres, string Apellidos, string CI, string Direccion, string Telefono, string RIF, int CodigoPostal, string Email, string Telefono_movil, string Ocupacion, string Nota, string Foto_Archivo, DateTime Fecha_Ingreso, DateTime Fecha_Egreso, double MontoSueldoIngreso, double MontoSueldoActual, bool esActivo, int id_Sucursal)
        {
            mID = ID;
            mId_Ciudad = Id_Ciudad;
            mId_Municipio = Id_Municipio;
            mId_Parroquia = Id_Parroquia;
            mId_Profesion = Id_Profesion;
            mId_TipoCargo = Id_TipoCargo;
            mId_TipoContrato = Id_TipoContrato;
            mId_defTipoNacionalidad = Id_defTipoNacionalidad;
            mNombres = Nombres;
            mApellidos = Apellidos;
            mCI = CI;
            mDireccion = Direccion;
            mTelefono = Telefono;
            mRIF = RIF;
            mCodigoPostal = CodigoPostal;
            mEmail = Email;
            mTelefono_movil = Telefono_movil;
            mOcupacion = Ocupacion;
            mNota = Nota;
            mFoto_Archivo = Foto_Archivo;
            mFecha_Ingreso = Fecha_Ingreso;
            mFecha_Egreso = Fecha_Egreso;
            mMontoSueldoIngreso = MontoSueldoIngreso;
            mMontoSueldoActual = MontoSueldoActual;
            mEsActivo = EsActivo;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
