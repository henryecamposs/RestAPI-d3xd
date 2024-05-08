using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Usuarios_RolesModulos : ICloneable
    {

        private int mID = 0;
        private int mId_usuario = 0;
        private int mId_modulo = 0;
        private int mId_defControlTag = 0;
        private int mId_defAccionModulo = 0;
        private int mId_defAccionModulo_padre = 0;
        private string mAccionModulo = "";
        private string mParametro1 = "";
        private string mParametro2 = "";
        private string mParametro3 = "";
        private string mParametro4 = "";
        private string mAccionModulo_padre = "";
        private bool mEsAccion = false;
        private int mEsActivo = 0;

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

        public int Id_usuario
        {
            get
            {
                return mId_usuario;
            }
            set
            {
                mId_usuario = value;
            }
        }

        public int Id_modulo
        {
            get
            {
                return mId_modulo;
            }
            set
            {
                mId_modulo = value;
            }
        }

        public int Id_defControlTag
        {
            get
            {
                return mId_defControlTag;
            }
            set
            {
                mId_defControlTag = value;
            }
        }

        public int Id_defAccionModulo
        {
            get
            {
                return mId_defAccionModulo;
            }
            set
            {
                mId_defAccionModulo = value;
            }
        }

        public int Id_defAccionModulo_padre
        {
            get
            {
                return mId_defAccionModulo_padre;
            }
            set
            {
                mId_defAccionModulo_padre = value;
            }
        }

        public string AccionModulo
        {
            get
            {
                return mAccionModulo;
            }
            set
            {
                mAccionModulo = value;
            }
        }

        public string Parametro1
        {
            get
            {
                return mParametro1;
            }
            set
            {
                mParametro1 = value;
            }
        }

        public string Parametro2
        {
            get
            {
                return mParametro2;
            }
            set
            {
                mParametro2 = value;
            }
        }

        public string Parametro3
        {
            get
            {
                return mParametro3;
            }
            set
            {
                mParametro3 = value;
            }
        }

        public string Parametro4
        {
            get
            {
                return mParametro4;
            }
            set
            {
                mParametro4 = value;
            }
        }

        public string AccionModulo_padre
        {
            get
            {
                return mAccionModulo_padre;
            }
            set
            {
                mAccionModulo_padre = value;
            }
        }

        public Boolean EsAccion
        {
            get
            {
                return mEsAccion;
            }
            set
            {
                mEsAccion = value;
            }
        }

        public int EsActivo
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

        Usuarios_RolesModulos()
        {
        }

        Usuarios_RolesModulos(int ID, int id_usuario, int id_modulo, int id_defControlTag, int id_defAccionModulo, int id_defAccionModulo_padre, string AccionModulo, string Parametro1, string Parametro2, string Parametro3, string Parametro4, string AccionModulo_padre, bool esAccion, int esActivo)
        {
            mID = ID;
            mId_usuario = Id_usuario;
            mId_modulo = Id_modulo;
            mId_defControlTag = Id_defControlTag;
            mId_defAccionModulo = Id_defAccionModulo;
            mId_defAccionModulo_padre = Id_defAccionModulo_padre;
            mAccionModulo = AccionModulo;
            mParametro1 = Parametro1;
            mParametro2 = Parametro2;
            mParametro3 = Parametro3;
            mParametro4 = Parametro4;
            mAccionModulo_padre = AccionModulo_padre;
            mEsAccion = EsAccion;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
