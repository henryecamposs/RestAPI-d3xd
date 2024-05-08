using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Sucursales_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_Sucursal = 0;
        private int mId_Usuario = 0;
        private DateTime mFechaAcceso = new DateTime(2000, 01, 01);
        private string mLogConexion = "";
        private string mLogDispositivo = "";
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

        public int Id_Sucursal
        {
            get
            {
                return mId_Sucursal;
            }
            set
            {
                mId_Sucursal = value;
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

        public DateTime FechaAcceso
        {
            get
            {
                return mFechaAcceso;
            }
            set
            {
                mFechaAcceso = value;
            }
        }

        public string LogConexion
        {
            get
            {
                return mLogConexion;
            }
            set
            {
                mLogConexion = value;
            }
        }

        public string LogDispositivo
        {
            get
            {
                return mLogDispositivo;
            }
            set
            {
                mLogDispositivo = value;
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

        Sucursales_Detalle()
        {
        }

        Sucursales_Detalle(int ID, int id_Sucursal, int id_Usuario, DateTime FechaAcceso, string LogConexion, string LogDispositivo, bool esActivo)
        {
            mID = ID;
            mId_Sucursal = Id_Sucursal;
            mId_Usuario = Id_Usuario;
            mFechaAcceso = FechaAcceso;
            mLogConexion = LogConexion;
            mLogDispositivo = LogDispositivo;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
