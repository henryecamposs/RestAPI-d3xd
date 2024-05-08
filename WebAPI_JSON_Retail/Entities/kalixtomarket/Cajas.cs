using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Cajas : ICloneable
    {

        private int mID = 0;
        private int mId_ClientePredet = 0;
        private int mId_TipoPagoPredet = 0;
        private int mId_Estacion = 0;
        private int mId_defTipoPrecioPredet = 0;
        private string mDescirpcion = "";
        private double mCantidadUnidadVentaPred = 0.0;
        private DateTime mFechaAnterior = new DateTime(2000, 01, 01);
        private DateTime mFechaApertura = new DateTime(2000, 01, 01);
        private double mMontoApertura = 0.0;
        private int mNroFacturaAnteriorIF = 0;
        private int mNroFacturaAnterior = 0;
        private string mSerialIF = "";
        private bool mEsAbierta =false;
        private bool mEsActivo =false;
        private bool mEsAgruparItemsIdenticos =false;
        private bool mEsNroFactura_Person =false;
        private bool mEsRemoto =false;
        private int mId_Sucursal = 0;

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

        public int Id_ClientePredet
        {
            get
            {
                return mId_ClientePredet;
            }
            set
            {
                mId_ClientePredet = value;
            }
        }

        public int Id_TipoPagoPredet
        {
            get
            {
                return mId_TipoPagoPredet;
            }
            set
            {
                mId_TipoPagoPredet = value;
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

        public int Id_defTipoPrecioPredet
        {
            get
            {
                return mId_defTipoPrecioPredet;
            }
            set
            {
                mId_defTipoPrecioPredet = value;
            }
        }

        public string Descirpcion
        {
            get
            {
                return mDescirpcion;
            }
            set
            {
                mDescirpcion = value;
            }
        }

        public Double CantidadUnidadVentaPred
        {
            get
            {
                return mCantidadUnidadVentaPred;
            }
            set
            {
                mCantidadUnidadVentaPred = value;
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

        public int NroFacturaAnteriorIF
        {
            get
            {
                return mNroFacturaAnteriorIF;
            }
            set
            {
                mNroFacturaAnteriorIF = value;
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

        public Boolean EsAgruparItemsIdenticos
        {
            get
            {
                return mEsAgruparItemsIdenticos;
            }
            set
            {
                mEsAgruparItemsIdenticos = value;
            }
        }

        public Boolean EsNroFactura_Person
        {
            get
            {
                return mEsNroFactura_Person;
            }
            set
            {
                mEsNroFactura_Person = value;
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

        Cajas()
        {
        }

        Cajas(int ID, int Id_ClientePredet, int Id_TipoPagoPredet, int id_Estacion, int id_defTipoPrecioPredet, string Descirpcion, double CantidadUnidadVentaPred, DateTime FechaAnterior, DateTime FechaApertura, double MontoApertura, int NroFacturaAnteriorIF, int NroFacturaAnterior, string SerialIF, bool esAbierta, bool esActivo, bool esAgruparItemsIdenticos, bool esNroFactura_Person, bool esRemoto, int id_Sucursal)
        {
            mID = ID;
            mId_ClientePredet = Id_ClientePredet;
            mId_TipoPagoPredet = Id_TipoPagoPredet;
            mId_Estacion = Id_Estacion;
            mId_defTipoPrecioPredet = Id_defTipoPrecioPredet;
            mDescirpcion = Descirpcion;
            mCantidadUnidadVentaPred = CantidadUnidadVentaPred;
            mFechaAnterior = FechaAnterior;
            mFechaApertura = FechaApertura;
            mMontoApertura = MontoApertura;
            mNroFacturaAnteriorIF = NroFacturaAnteriorIF;
            mNroFacturaAnterior = NroFacturaAnterior;
            mSerialIF = SerialIF;
            mEsAbierta = EsAbierta;
            mEsActivo = EsActivo;
            mEsAgruparItemsIdenticos = EsAgruparItemsIdenticos;
            mEsNroFactura_Person = EsNroFactura_Person;
            mEsRemoto = EsRemoto;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
