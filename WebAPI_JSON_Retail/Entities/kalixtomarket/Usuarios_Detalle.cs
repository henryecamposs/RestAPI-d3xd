using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Usuarios_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_modulo = 0;
        private int mId_usuario = 0;
        private int mId_defUsuarioOperacion = 0;
        private string mModuloRuta_App = "";
        private DateTime mFecha_login = new DateTime(2000, 01, 01);
        private DateTime mFecha_UltimoAcceso = new DateTime(2000, 01, 01);
        private bool mEsLogeado = false;

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

        public int Id_defUsuarioOperacion
        {
            get
            {
                return mId_defUsuarioOperacion;
            }
            set
            {
                mId_defUsuarioOperacion = value;
            }
        }

        public string ModuloRuta_App
        {
            get
            {
                return mModuloRuta_App;
            }
            set
            {
                mModuloRuta_App = value;
            }
        }

        public DateTime Fecha_login
        {
            get
            {
                return mFecha_login;
            }
            set
            {
                mFecha_login = value;
            }
        }

        public DateTime Fecha_UltimoAcceso
        {
            get
            {
                return mFecha_UltimoAcceso;
            }
            set
            {
                mFecha_UltimoAcceso = value;
            }
        }

        public Boolean EsLogeado
        {
            get
            {
                return mEsLogeado;
            }
            set
            {
                mEsLogeado = value;
            }
        }

        Usuarios_Detalle()
        {
        }

        Usuarios_Detalle(int ID, int id_modulo, int id_usuario, int id_defUsuarioOperacion, string ModuloRuta_App, DateTime Fecha_login, DateTime Fecha_UltimoAcceso, bool esLogeado)
        {
            mID = ID;
            mId_modulo = Id_modulo;
            mId_usuario = Id_usuario;
            mId_defUsuarioOperacion = Id_defUsuarioOperacion;
            mModuloRuta_App = ModuloRuta_App;
            mFecha_login = Fecha_login;
            mFecha_UltimoAcceso = Fecha_UltimoAcceso;
            mEsLogeado = EsLogeado;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
