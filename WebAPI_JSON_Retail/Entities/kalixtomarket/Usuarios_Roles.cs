using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Usuarios_Roles : ICloneable
    {

        private int mID = 0;
        private int mId_Usuario = 0;
        private int mId_Modulo = 0;
        private bool mEsAccesoRemoto = false;
        private bool mEsAgregar = false;
        private bool mEsEliminar = false;
        private bool mEsModificar = false;

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

        public int Id_Modulo
        {
            get
            {
                return mId_Modulo;
            }
            set
            {
                mId_Modulo = value;
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

        Usuarios_Roles()
        {
        }

        Usuarios_Roles(int ID, int id_Usuario, int id_Modulo, bool esAccesoRemoto, bool esAgregar, bool esEliminar, bool esModificar)
        {
            mID = ID;
            mId_Usuario = Id_Usuario;
            mId_Modulo = Id_Modulo;
            mEsAccesoRemoto = EsAccesoRemoto;
            mEsAgregar = EsAgregar;
            mEsEliminar = EsEliminar;
            mEsModificar = EsModificar;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
