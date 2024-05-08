using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Dipositivo_VisorPrecios : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private int mId_defTipoVisorPreciosModelo = 0;
        private int mId_defTipoVisorPreciosVendor = 0;
        private string mLinea1 = "";
        private string mLinea2 = "";
        private string mLinea3 = "";
        private string mLinea4 = "";
        private string mPuertoComunicaciones = "";
        private bool mEsVisorPreciosMonitor = false;

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

        public int Id_Estacion
        {
            get
            {
                return mId_Estacion;
            }
            set
            {
                mId_Estacion = value;
            }
        }

        public int Id_defTipoVisorPreciosModelo
        {
            get
            {
                return mId_defTipoVisorPreciosModelo;
            }
            set
            {
                mId_defTipoVisorPreciosModelo = value;
            }
        }

        public int Id_defTipoVisorPreciosVendor
        {
            get
            {
                return mId_defTipoVisorPreciosVendor;
            }
            set
            {
                mId_defTipoVisorPreciosVendor = value;
            }
        }

        public string Linea1
        {
            get
            {
                return mLinea1;
            }
            set
            {
                mLinea1 = value;
            }
        }

        public string Linea2
        {
            get
            {
                return mLinea2;
            }
            set
            {
                mLinea2 = value;
            }
        }

        public string Linea3
        {
            get
            {
                return mLinea3;
            }
            set
            {
                mLinea3 = value;
            }
        }

        public string Linea4
        {
            get
            {
                return mLinea4;
            }
            set
            {
                mLinea4 = value;
            }
        }

        public string PuertoComunicaciones
        {
            get
            {
                return mPuertoComunicaciones;
            }
            set
            {
                mPuertoComunicaciones = value;
            }
        }

        public Boolean EsVisorPreciosMonitor
        {
            get
            {
                return mEsVisorPreciosMonitor;
            }
            set
            {
                mEsVisorPreciosMonitor = value;
            }
        }

        Estaciones_Dipositivo_VisorPrecios()
        {
        }

        Estaciones_Dipositivo_VisorPrecios(int ID, int id_Estacion, int Id_defTipoVisorPreciosModelo, int id_defTipoVisorPreciosVendor, string Linea1, string Linea2, string Linea3, string Linea4, string PuertoComunicaciones, bool esVisorPreciosMonitor)
        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mId_defTipoVisorPreciosModelo = Id_defTipoVisorPreciosModelo;
            mId_defTipoVisorPreciosVendor = Id_defTipoVisorPreciosVendor;
            mLinea1 = Linea1;
            mLinea2 = Linea2;
            mLinea3 = Linea3;
            mLinea4 = Linea4;
            mPuertoComunicaciones = PuertoComunicaciones;
            mEsVisorPreciosMonitor = EsVisorPreciosMonitor;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
