using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Empleados_Club : ICloneable
    {

        private int mID = 0;
        private int mId_Empleado = 0;
        private int mId_TipoBanco = 0;
        private int mId_defTipoPersonal = 0;
        private string mCodigoBarras = "";
        private string mTelefono_Emerg1 = "";
        private string mTelefonoTrabajo_Emerg1 = "";
        private string mDireccion_Emerg1 = "";
        private string mContacto_Emerg2 = "";
        private string mTelefono_Emerg2 = "";
        private string mTelefonoTrabajo_Emerg2 = "";
        private string mDireccion_Emerg2 = "";
        private string mContacto_Emerg1 = "";
        private string mNroTarjetaCredito = "";
        private string mCondicion_Medica = "";
        private string mNombre_Medico = "";
        private string mTelefono_Medico = "";
        private string mNota = "";
        private string mFoto_Archivo = "";
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

        public int Id_Empleado
        {
            get
            {
                return mId_Empleado;
            }
            set
            {
                mId_Empleado = value;
            }
        }

        public int Id_TipoBanco
        {
            get
            {
                return mId_TipoBanco;
            }
            set
            {
                mId_TipoBanco = value;
            }
        }

        public int Id_defTipoPersonal
        {
            get
            {
                return mId_defTipoPersonal;
            }
            set
            {
                mId_defTipoPersonal = value;
            }
        }

        public string CodigoBarras
        {
            get
            {
                return mCodigoBarras;
            }
            set
            {
                mCodigoBarras = value;
            }
        }

        public string Telefono_Emerg1
        {
            get
            {
                return mTelefono_Emerg1;
            }
            set
            {
                mTelefono_Emerg1 = value;
            }
        }

        public string TelefonoTrabajo_Emerg1
        {
            get
            {
                return mTelefonoTrabajo_Emerg1;
            }
            set
            {
                mTelefonoTrabajo_Emerg1 = value;
            }
        }

        public string Direccion_Emerg1
        {
            get
            {
                return mDireccion_Emerg1;
            }
            set
            {
                mDireccion_Emerg1 = value;
            }
        }

        public string Contacto_Emerg2
        {
            get
            {
                return mContacto_Emerg2;
            }
            set
            {
                mContacto_Emerg2 = value;
            }
        }

        public string Telefono_Emerg2
        {
            get
            {
                return mTelefono_Emerg2;
            }
            set
            {
                mTelefono_Emerg2 = value;
            }
        }

        public string TelefonoTrabajo_Emerg2
        {
            get
            {
                return mTelefonoTrabajo_Emerg2;
            }
            set
            {
                mTelefonoTrabajo_Emerg2 = value;
            }
        }

        public string Direccion_Emerg2
        {
            get
            {
                return mDireccion_Emerg2;
            }
            set
            {
                mDireccion_Emerg2 = value;
            }
        }

        public string Contacto_Emerg1
        {
            get
            {
                return mContacto_Emerg1;
            }
            set
            {
                mContacto_Emerg1 = value;
            }
        }

        public string NroTarjetaCredito
        {
            get
            {
                return mNroTarjetaCredito;
            }
            set
            {
                mNroTarjetaCredito = value;
            }
        }

        public string Condicion_Medica
        {
            get
            {
                return mCondicion_Medica;
            }
            set
            {
                mCondicion_Medica = value;
            }
        }

        public string Nombre_Medico
        {
            get
            {
                return mNombre_Medico;
            }
            set
            {
                mNombre_Medico = value;
            }
        }

        public string Telefono_Medico
        {
            get
            {
                return mTelefono_Medico;
            }
            set
            {
                mTelefono_Medico = value;
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

        Empleados_Club()
        {
        }

        Empleados_Club(int ID, int id_Empleado, int Id_TipoBanco, int id_defTipoPersonal, string CodigoBarras, string Telefono_Emerg1, string TelefonoTrabajo_Emerg1, string Direccion_Emerg1, string Contacto_Emerg2, string Telefono_Emerg2, string TelefonoTrabajo_Emerg2, string Direccion_Emerg2, string Contacto_Emerg1, string nroTarjetaCredito, string Condicion_Medica, string Nombre_Medico, string Telefono_Medico, string Nota, string Foto_Archivo, bool esActivo)
        {
            mID = ID;
            mId_Empleado = Id_Empleado;
            mId_TipoBanco = Id_TipoBanco;
            mId_defTipoPersonal = Id_defTipoPersonal;
            mCodigoBarras = CodigoBarras;
            mTelefono_Emerg1 = Telefono_Emerg1;
            mTelefonoTrabajo_Emerg1 = TelefonoTrabajo_Emerg1;
            mDireccion_Emerg1 = Direccion_Emerg1;
            mContacto_Emerg2 = Contacto_Emerg2;
            mTelefono_Emerg2 = Telefono_Emerg2;
            mTelefonoTrabajo_Emerg2 = TelefonoTrabajo_Emerg2;
            mDireccion_Emerg2 = Direccion_Emerg2;
            mContacto_Emerg1 = Contacto_Emerg1;
            mNroTarjetaCredito = NroTarjetaCredito;
            mCondicion_Medica = Condicion_Medica;
            mNombre_Medico = Nombre_Medico;
            mTelefono_Medico = Telefono_Medico;
            mNota = Nota;
            mFoto_Archivo = Foto_Archivo;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
