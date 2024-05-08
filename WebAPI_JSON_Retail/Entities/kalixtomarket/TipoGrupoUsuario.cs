using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoGrupoUsuario : ICloneable
    {

        private int mID = 0;
        private int mId_defTipoNivelAcceso = 0;
        private string mDescripcion = "";
        private bool mEsAgregar = false;
        private bool mEsModificar = false;
        private bool mEsEliminar = false;
        private bool mEsAccesoRemoto = false;
        private bool mEsAccesoAdmin = false;
        private bool mEsActualizar = false;
        private bool mEsListar = false;
        private bool mEsRoot = false;

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

        public Boolean EsAccesoRemoto
        {
            get
            {
                return mEsAccesoRemoto;
            }
            set
            {
                mEsAccesoRemoto = value;
            }
        }

        public Boolean EsAccesoAdmin
        {
            get
            {
                return mEsAccesoAdmin;
            }
            set
            {
                mEsAccesoAdmin = value;
            }
        }

        public Boolean EsActualizar
        {
            get
            {
                return mEsActualizar;
            }
            set
            {
                mEsActualizar = value;
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

        public Boolean EsRoot
        {
            get
            {
                return mEsRoot;
            }
            set
            {
                mEsRoot = value;
            }
        }

        TipoGrupoUsuario()
        {
        }

        TipoGrupoUsuario(int ID, int id_defTipoNivelAcceso, string Descripcion, bool esAgregar, bool esModificar, bool esEliminar, bool esAccesoRemoto, bool esAccesoAdmin, bool esActualizar, bool esListar, bool esRoot)
        {
            mID = ID;
            mId_defTipoNivelAcceso = Id_defTipoNivelAcceso;
            mDescripcion = Descripcion;
            mEsAgregar = EsAgregar;
            mEsModificar = EsModificar;
            mEsEliminar = EsEliminar;
            mEsAccesoRemoto = EsAccesoRemoto;
            mEsAccesoAdmin = EsAccesoAdmin;
            mEsActualizar = EsActualizar;
            mEsListar = EsListar;
            mEsRoot = EsRoot;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
