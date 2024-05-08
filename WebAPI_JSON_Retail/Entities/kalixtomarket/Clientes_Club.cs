using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes_Club : ICloneable
    {

        private int mID = 0;
        private int mId_Cliente = 0;
        private int mId_TipoAreaComun = 0;
        private int mId_TipoBanco = 0;
        private int mId_defTipoPersonal = 0;
        private string mCodigoBarras = "";
        private string mCondicionMedica = "";
        private string mContactoEmerg1 = "";
        private string mContactoEmerg2 = "";
        private string mDireccionEmerg1 = "";
        private string mDireccionEmerg2 = "";
        private DateTime mFechaIngreso = new DateTime(2000, 01, 01);
        private DateTime mFechaNacimiento = new DateTime(2000, 01, 01);
        private string mImagenArchivo = "";
        private string mNombreMedico = "";
        private string mNota = "";
        private string mNroTarjetaCredito = "";
        private string mTelefonoEmerg1 = "";
        private string mTelefonoEmerg2 = "";
        private string mTelefonoMedico = "";
        private string mTelefonoTrabajoEmerg1 = "";
        private string mTelefonoTrabajoEmerg2 = "";
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

        public int Id_Cliente
        {
            get
            {
                return mId_Cliente;
            }
            set
            {
                mId_Cliente = value;
            }
        }

        public int Id_TipoAreaComun
        {
            get
            {
                return mId_TipoAreaComun;
            }
            set
            {
                mId_TipoAreaComun = value;
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

        public string CondicionMedica
        {
            get
            {
                return mCondicionMedica;
            }
            set
            {
                mCondicionMedica = value;
            }
        }

        public string ContactoEmerg1
        {
            get
            {
                return mContactoEmerg1;
            }
            set
            {
                mContactoEmerg1 = value;
            }
        }

        public string ContactoEmerg2
        {
            get
            {
                return mContactoEmerg2;
            }
            set
            {
                mContactoEmerg2 = value;
            }
        }

        public string DireccionEmerg1
        {
            get
            {
                return mDireccionEmerg1;
            }
            set
            {
                mDireccionEmerg1 = value;
            }
        }

        public string DireccionEmerg2
        {
            get
            {
                return mDireccionEmerg2;
            }
            set
            {
                mDireccionEmerg2 = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return mFechaIngreso;
            }
            set
            {
                mFechaIngreso = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return mFechaNacimiento;
            }
            set
            {
                mFechaNacimiento = value;
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

        public string NombreMedico
        {
            get
            {
                return mNombreMedico;
            }
            set
            {
                mNombreMedico = value;
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

        public string TelefonoEmerg1
        {
            get
            {
                return mTelefonoEmerg1;
            }
            set
            {
                mTelefonoEmerg1 = value;
            }
        }

        public string TelefonoEmerg2
        {
            get
            {
                return mTelefonoEmerg2;
            }
            set
            {
                mTelefonoEmerg2 = value;
            }
        }

        public string TelefonoMedico
        {
            get
            {
                return mTelefonoMedico;
            }
            set
            {
                mTelefonoMedico = value;
            }
        }

        public string TelefonoTrabajoEmerg1
        {
            get
            {
                return mTelefonoTrabajoEmerg1;
            }
            set
            {
                mTelefonoTrabajoEmerg1 = value;
            }
        }

        public string TelefonoTrabajoEmerg2
        {
            get
            {
                return mTelefonoTrabajoEmerg2;
            }
            set
            {
                mTelefonoTrabajoEmerg2 = value;
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

        Clientes_Club()
        {
        }

        Clientes_Club(int ID, int id_Cliente, int id_TipoAreaComun, int id_TipoBanco, int id_defTipoPersonal, string CodigoBarras, string CondicionMedica, string ContactoEmerg1, string ContactoEmerg2, string DireccionEmerg1, string DireccionEmerg2, DateTime FechaIngreso, DateTime FechaNacimiento, string ImagenArchivo, string NombreMedico, string Nota, string NroTarjetaCredito, string TelefonoEmerg1, string TelefonoEmerg2, string TelefonoMedico, string TelefonoTrabajoEmerg1, string TelefonoTrabajoEmerg2, bool esActivo)
        {
            mID = ID;
            mId_Cliente = Id_Cliente;
            mId_TipoAreaComun = Id_TipoAreaComun;
            mId_TipoBanco = Id_TipoBanco;
            mId_defTipoPersonal = Id_defTipoPersonal;
            mCodigoBarras = CodigoBarras;
            mCondicionMedica = CondicionMedica;
            mContactoEmerg1 = ContactoEmerg1;
            mContactoEmerg2 = ContactoEmerg2;
            mDireccionEmerg1 = DireccionEmerg1;
            mDireccionEmerg2 = DireccionEmerg2;
            mFechaIngreso = FechaIngreso;
            mFechaNacimiento = FechaNacimiento;
            mImagenArchivo = ImagenArchivo;
            mNombreMedico = NombreMedico;
            mNota = Nota;
            mNroTarjetaCredito = NroTarjetaCredito;
            mTelefonoEmerg1 = TelefonoEmerg1;
            mTelefonoEmerg2 = TelefonoEmerg2;
            mTelefonoMedico = TelefonoMedico;
            mTelefonoTrabajoEmerg1 = TelefonoTrabajoEmerg1;
            mTelefonoTrabajoEmerg2 = TelefonoTrabajoEmerg2;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
