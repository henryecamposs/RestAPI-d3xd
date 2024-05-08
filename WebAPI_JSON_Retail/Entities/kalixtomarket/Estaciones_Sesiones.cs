using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Sesiones : ICloneable
    {

        private int mID = 0;
        private int mId_estacion = 0;
        private int mId_Usuario_Inicio = 0;
        private int mId_Usuario_Fin = 0;
        private string mIPEstacion = "";
        private string mRutaModulo_App = "";
        private string mNombreEquipo = "";
        private bool mEsEstacionActiva = false;
        private DateTime mFechaInicio = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);

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

        public int Id_estacion
        {
            get
            {
                return mId_estacion;
            }
            set
            {
                mId_estacion = value;
            }
        }

        public int Id_Usuario_Inicio
        {
            get
            {
                return mId_Usuario_Inicio;
            }
            set
            {
                mId_Usuario_Inicio = value;
            }
        }

        public int Id_Usuario_Fin
        {
            get
            {
                return mId_Usuario_Fin;
            }
            set
            {
                mId_Usuario_Fin = value;
            }
        }

        public string IPEstacion
        {
            get
            {
                return mIPEstacion;
            }
            set
            {
                mIPEstacion = value;
            }
        }

        public string RutaModulo_App
        {
            get
            {
                return mRutaModulo_App;
            }
            set
            {
                mRutaModulo_App = value;
            }
        }

        public string NombreEquipo
        {
            get
            {
                return mNombreEquipo;
            }
            set
            {
                mNombreEquipo = value;
            }
        }

        public Boolean EsEstacionActiva
        {
            get
            {
                return mEsEstacionActiva;
            }
            set
            {
                mEsEstacionActiva = value;
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

        Estaciones_Sesiones()
        {
        }

        Estaciones_Sesiones(int ID, int id_estacion, int id_Usuario_Inicio, int id_Usuario_Fin, string IPEstacion, string RutaModulo_App, string NombreEquipo, bool esEstacionActiva, DateTime FechaInicio, DateTime FechaFin)
        {
            mID = ID;
            mId_estacion = Id_estacion;
            mId_Usuario_Inicio = Id_Usuario_Inicio;
            mId_Usuario_Fin = Id_Usuario_Fin;
            mIPEstacion = IPEstacion;
            mRutaModulo_App = RutaModulo_App;
            mNombreEquipo = NombreEquipo;
            mEsEstacionActiva = EsEstacionActiva;
            mFechaInicio = FechaInicio;
            mFechaFin = FechaFin;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
