using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Usuarios_Grupo : ICloneable
    {

        private int mID = 0;
        private int mId_Usuario = 0;
        private int mId_defTipoUsuarioNivel = 0;
        private string mDescripcion = "";
        private bool mEsAccesoremoto = false;
        private bool mEsAgregar = false;
        private bool mEsEliminar = false;
        private bool mEsListar = false;
        private bool mEsModificar = false;
        private bool mEsroot = false;
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

        public int Id_Usuario
        {
            get
            {
                return mId_Usuario;
            }
            set
            {
                mId_Usuario = value;
            }
        }

        public int Id_defTipoUsuarioNivel
        {
            get
            {
                return mId_defTipoUsuarioNivel;
            }
            set
            {
                mId_defTipoUsuarioNivel = value;
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

        public Boolean EsAccesoremoto
        {
            get
            {
                return mEsAccesoremoto;
            }
            set
            {
                mEsAccesoremoto = value;
            }
        }

        public Boolean EsAgregar
        {
            get
            {
                return mEsAgregar;
            }
            set
            {
                mEsAgregar = value;
            }
        }

        public Boolean EsEliminar
        {
            get
            {
                return mEsEliminar;
            }
            set
            {
                mEsEliminar = value;
            }
        }

        public Boolean EsListar
        {
            get
            {
                return mEsListar;
            }
            set
            {
                mEsListar = value;
            }
        }

        public Boolean EsModificar
        {
            get
            {
                return mEsModificar;
            }
            set
            {
                mEsModificar = value;
            }
        }

        public Boolean Esroot
        {
            get
            {
                return mEsroot;
            }
            set
            {
                mEsroot = value;
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

        Usuarios_Grupo()
        {
        }

        Usuarios_Grupo(int ID, int id_Usuario, int id_defTipoUsuarioNivel, string Descripcion, bool esAccesoremoto, bool esAgregar, bool esEliminar, bool esListar, bool esModificar, bool esroot, bool esActivo)
        {
            mID = ID;
            mId_Usuario = Id_Usuario;
            mId_defTipoUsuarioNivel = Id_defTipoUsuarioNivel;
            mDescripcion = Descripcion;
            mEsAccesoremoto = EsAccesoremoto;
            mEsAgregar = EsAgregar;
            mEsEliminar = EsEliminar;
            mEsListar = EsListar;
            mEsModificar = EsModificar;
            mEsroot = Esroot;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
