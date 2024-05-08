using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Cajas_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_Caja = 0;
        private int mId_Usuario = 0;
        private int mId_Estaciones_Sesion = 0;
        private string mSerialIF = "";
        private DateTime mFechaAnterior = new DateTime(2000, 01, 01);
        private DateTime mFechaApertura = new DateTime(2000, 01, 01);
        private double mMontoApertura = 0.0;
        private int mNroFacturaAnteiorIF = 0;
        private int mNroFacturaAnterior = 0;
        private bool mEsAbierta = false;
        private bool mEsRemoto = false;
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

        public int Id_Caja
        {
            get
            {
                return mId_Caja;
            }
            set
            {
                mId_Caja = value;
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

        public string SerialIF
        {
            get
            {
                return mSerialIF;
            }
            set
            {
                mSerialIF = value;
            }
        }

        public DateTime FechaAnterior
        {
            get
            {
                return mFechaAnterior;
            }
            set
            {
                mFechaAnterior = value;
            }
        }

        public DateTime FechaApertura
        {
            get
            {
                return mFechaApertura;
            }
            set
            {
                mFechaApertura = value;
            }
        }

        public Double MontoApertura
        {
            get
            {
                return mMontoApertura;
            }
            set
            {
                mMontoApertura = value;
            }
        }

        public int NroFacturaAnteiorIF
        {
            get
            {
                return mNroFacturaAnteiorIF;
            }
            set
            {
                mNroFacturaAnteiorIF = value;
            }
        }

        public int NroFacturaAnterior
        {
            get
            {
                return mNroFacturaAnterior;
            }
            set
            {
                mNroFacturaAnterior = value;
            }
        }

        public Boolean EsAbierta
        {
            get
            {
                return mEsAbierta;
            }
            set
            {
                mEsAbierta = value;
            }
        }

        public Boolean EsRemoto
        {
            get
            {
                return mEsRemoto;
            }
            set
            {
                mEsRemoto = value;
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

        Cajas_Detalle()
        {
        }

        Cajas_Detalle(int ID, int Id_Caja, int id_Usuario, int id_Estaciones_Sesion, string SerialIF, DateTime FechaAnterior, DateTime FechaApertura, double MontoApertura, int NroFacturaAnteiorIF, int NroFacturaAnterior, bool esAbierta, bool esRemoto, bool esActivo)
        {
            mID = ID;
            mId_Caja = Id_Caja;
            mId_Usuario = Id_Usuario;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mSerialIF = SerialIF;
            mFechaAnterior = FechaAnterior;
            mFechaApertura = FechaApertura;
            mMontoApertura = MontoApertura;
            mNroFacturaAnteiorIF = NroFacturaAnteiorIF;
            mNroFacturaAnterior = NroFacturaAnterior;
            mEsAbierta = EsAbierta;
            mEsRemoto = EsRemoto;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
