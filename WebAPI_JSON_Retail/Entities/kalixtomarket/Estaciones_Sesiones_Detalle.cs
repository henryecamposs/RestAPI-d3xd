using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Sesiones_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_Estaciones_Sesion = 0;
        private int mId_Usuario = 0;
        private int mId_RegistroPpal = 0;
        private int mId_Modulo = 0;
        private string mArchivoDatosPpal = "";
        private DateTime mFechaInicial = new DateTime(2000, 01, 01);
        private DateTime mFechaFinal = new DateTime(2000, 01, 01);
        private string mModuloRuta_App = "";
        private string mLogDatosInitModulo = "";
        private string mLogDatosFinModulo = "";
        private string mLogRegistroFinal = "";
        private string mLogRegistroOriginal = "";
        private bool mEsActualizar = false;
        private bool mEsAgregar = false;
        private bool mEsEditar = false;
        private bool mEsEliminar = false;

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

        public int Id_Estaciones_Sesion
        {
            get
            {
                return mId_Estaciones_Sesion;
            }
            set
            {
                mId_Estaciones_Sesion = value;
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

        public int Id_RegistroPpal
        {
            get
            {
                return mId_RegistroPpal;
            }
            set
            {
                mId_RegistroPpal = value;
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

        public string ArchivoDatosPpal
        {
            get
            {
                return mArchivoDatosPpal;
            }
            set
            {
                mArchivoDatosPpal = value;
            }
        }

        public DateTime FechaInicial
        {
            get
            {
                return mFechaInicial;
            }
            set
            {
                mFechaInicial = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return mFechaFinal;
            }
            set
            {
                mFechaFinal = value;
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

        public string LogDatosInitModulo
        {
            get
            {
                return mLogDatosInitModulo;
            }
            set
            {
                mLogDatosInitModulo = value;
            }
        }

        public string LogDatosFinModulo
        {
            get
            {
                return mLogDatosFinModulo;
            }
            set
            {
                mLogDatosFinModulo = value;
            }
        }

        public string LogRegistroFinal
        {
            get
            {
                return mLogRegistroFinal;
            }
            set
            {
                mLogRegistroFinal = value;
            }
        }

        public string LogRegistroOriginal
        {
            get
            {
                return mLogRegistroOriginal;
            }
            set
            {
                mLogRegistroOriginal = value;
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

        public Boolean EsEditar
        {
            get
            {
                return mEsEditar;
            }
            set
            {
                mEsEditar = value;
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

        Estaciones_Sesiones_Detalle()
        {
        }

        Estaciones_Sesiones_Detalle(int ID, int id_Estaciones_Sesion, int id_Usuario, int id_RegistroPpal, int id_Modulo, string ArchivoDatosPpal, DateTime FechaInicial, DateTime FechaFinal, string ModuloRuta_App, string LogDatosInitModulo, string LogDatosFinModulo, string LogRegistroFinal, string LogRegistroOriginal, bool esActualizar, bool esAgregar, bool esEditar, bool esEliminar)
        {
            mID = ID;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mId_Usuario = Id_Usuario;
            mId_RegistroPpal = Id_RegistroPpal;
            mId_Modulo = Id_Modulo;
            mArchivoDatosPpal = ArchivoDatosPpal;
            mFechaInicial = FechaInicial;
            mFechaFinal = FechaFinal;
            mModuloRuta_App = ModuloRuta_App;
            mLogDatosInitModulo = LogDatosInitModulo;
            mLogDatosFinModulo = LogDatosFinModulo;
            mLogRegistroFinal = LogRegistroFinal;
            mLogRegistroOriginal = LogRegistroOriginal;
            mEsActualizar = EsActualizar;
            mEsAgregar = EsAgregar;
            mEsEditar = EsEditar;
            mEsEliminar = EsEliminar;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
