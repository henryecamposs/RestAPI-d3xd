using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoBanco : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private string mTelefono = "";
        private string mNroPrefijo = "";
        private string mDireccionSede = "";
        private string mNombreContacto = "";
        private string mTelefonoContacto = "";
        private string mFechaNacContacto = "";
        private string mNombreGerente = "";
        private string mTelefonoGerente = "";
        private string mFechaNacGerente = "";
        private string mURLWeb = "";

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

        public string NroPrefijo
        {
            get
            {
                return mNroPrefijo;
            }
            set
            {
                mNroPrefijo = value;
            }
        }

        public string DireccionSede
        {
            get
            {
                return mDireccionSede;
            }
            set
            {
                mDireccionSede = value;
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

        public string URLWeb
        {
            get
            {
                return mURLWeb;
            }
            set
            {
                mURLWeb = value;
            }
        }

        TipoBanco()
        {
        }

        TipoBanco(int ID, string Descripcion, string Telefono, string nroPrefijo, string DireccionSede, string NombreContacto, string TelefonoContacto, string FechaNacContacto, string NombreGerente, string TelefonoGerente, string FechaNacGerente, string URLWeb)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mTelefono = Telefono;
            mNroPrefijo = NroPrefijo;
            mDireccionSede = DireccionSede;
            mNombreContacto = NombreContacto;
            mTelefonoContacto = TelefonoContacto;
            mFechaNacContacto = FechaNacContacto;
            mNombreGerente = NombreGerente;
            mTelefonoGerente = TelefonoGerente;
            mFechaNacGerente = FechaNacGerente;
            mURLWeb = URLWeb;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
