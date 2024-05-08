using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Usuarios : ICloneable
    {

        private int mID = 0;
        private int mId_TipoGrupoUsuario = 0;
        private int mId_Empleado = 0;
        private int mId_defTipoNivelAcceso = 0;
        private string mNombre = "";
        private string mPassword = "";
        private DateTime mFechaCaduca = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);
        private DateTime mFechaInicio = new DateTime(2000, 01, 01);
        private bool mEsCaduca = false;
        private bool mEsActivo = false;
        private bool mEsLogged = false;

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

        public int Id_TipoGrupoUsuario
        {
            get
            {
                return mId_TipoGrupoUsuario;
            }
            set
            {
                mId_TipoGrupoUsuario = value;
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

        public int Id_defTipoNivelAcceso
        {
            get
            {
                return mId_defTipoNivelAcceso;
            }
            set
            {
                mId_defTipoNivelAcceso = value;
            }
        }

        public string Nombre
        {
            get
            {
                return mNombre;
            }
            set
            {
                mNombre = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public DateTime FechaCaduca
        {
            get
            {
                return mFechaCaduca;
            }
            set
            {
                mFechaCaduca = value;
            }
        }

        public DateTime FechaFin
        {
            get
            {
                return mFechaFin;
            }
            set
            {
                mFechaFin = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return mFechaInicio;
            }
            set
            {
                mFechaInicio = value;
            }
        }

        public Boolean EsCaduca
        {
            get
            {
                return mEsCaduca;
            }
            set
            {
                mEsCaduca = value;
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

        public Boolean EsLogged
        {
            get
            {
                return mEsLogged;
            }
            set
            {
                mEsLogged = value;
            }
        }

        Usuarios()
        {
        }

        Usuarios(int ID, int id_TipoGrupoUsuario, int id_Empleado, int id_defTipoNivelAcceso, string Nombre, string Password, DateTime FechaCaduca, DateTime FechaFin, DateTime FechaInicio, bool esCaduca, bool esActivo, bool esLogged)
        {
            mID = ID;
            mId_TipoGrupoUsuario = Id_TipoGrupoUsuario;
            mId_Empleado = Id_Empleado;
            mId_defTipoNivelAcceso = Id_defTipoNivelAcceso;
            mNombre = Nombre;
            mPassword = Password;
            mFechaCaduca = FechaCaduca;
            mFechaFin = FechaFin;
            mFechaInicio = FechaInicio;
            mEsCaduca = EsCaduca;
            mEsActivo = EsActivo;
            mEsLogged = EsLogged;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
