using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones : ICloneable
    {

        private int mID = 0;
        private int mID_Licencia = 0;
        private int mID_defTipoDescargaInventario = 0;
        private int mID_defTipoEstacion = 0;
        private int mID_defTipoPedirDatosCliente = 0;
        private int mID_defTipoPrecioPredet = 0;
        private string mDescirpcion = "";
        private string mNombreEquipo = "";
        private string mIPEstacion = "";
        private DateTime mFechaUltimaConfiguracion = new DateTime(2000, 01, 01);
        private bool mEsCliente_SolicitarEmail = false;
        private bool mEsCliente_SolicitarRIF = false;
        private bool mEsCliente_SolicitarTelefono = false;
        private bool mEsimprimirEgreso = false;
        private bool mEsImprimirFiscal = false;
        private bool mEsImprimirNConsumo = false;
        private bool mEsOffline = false;
        private bool mEsPedirCantidadPredet = false;
        private bool mEsPoseeCaptaHuella = false;
        private bool mEsPoseeGaveta = false;
        private bool mEsPoseeLectorPOSBanca = false;
        private bool mEsPoseeMouse = false;
        private bool mEsPoseePantallaTactil = false;
        private bool mEsPoseeTeclado = false;
        private bool mEsPoseeVisorPrecio = false;
        private bool mEsPoseeVisorPreciosMonitorExtra = false;
        private bool mEsPreguntarCerrarApp = false;
        private bool mEsRemoto = false;
        private bool mEsRequierePassword = false;
        private bool mEsSolicitarEmpleado = false;
        private bool mEsActivo = false;
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

        public int ID_Licencia
        {
            get
            {
                return mID_Licencia;
            }
            set
            {
                mID_Licencia = value;
            }
        }

        public int ID_defTipoDescargaInventario
        {
            get
            {
                return mID_defTipoDescargaInventario;
            }
            set
            {
                mID_defTipoDescargaInventario = value;
            }
        }

        public int ID_defTipoEstacion
        {
            get
            {
                return mID_defTipoEstacion;
            }
            set
            {
                mID_defTipoEstacion = value;
            }
        }

        public int ID_defTipoPedirDatosCliente
        {
            get
            {
                return mID_defTipoPedirDatosCliente;
            }
            set
            {
                mID_defTipoPedirDatosCliente = value;
            }
        }

        public int ID_defTipoPrecioPredet
        {
            get
            {
                return mID_defTipoPrecioPredet;
            }
            set
            {
                mID_defTipoPrecioPredet = value;
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

        public DateTime FechaUltimaConfiguracion
        {
            get
            {
                return mFechaUltimaConfiguracion;
            }
            set
            {
                mFechaUltimaConfiguracion = value;
            }
        }

        public Boolean EsCliente_SolicitarEmail
        {
            get
            {
                return mEsCliente_SolicitarEmail;
            }
            set
            {
                mEsCliente_SolicitarEmail = value;
            }
        }

        public Boolean EsCliente_SolicitarRIF
        {
            get
            {
                return mEsCliente_SolicitarRIF;
            }
            set
            {
                mEsCliente_SolicitarRIF = value;
            }
        }

        public Boolean EsCliente_SolicitarTelefono
        {
            get
            {
                return mEsCliente_SolicitarTelefono;
            }
            set
            {
                mEsCliente_SolicitarTelefono = value;
            }
        }

        public Boolean EsimprimirEgreso
        {
            get
            {
                return mEsimprimirEgreso;
            }
            set
            {
                mEsimprimirEgreso = value;
            }
        }

        public Boolean EsImprimirFiscal
        {
            get
            {
                return mEsImprimirFiscal;
            }
            set
            {
                mEsImprimirFiscal = value;
            }
        }

        public Boolean EsImprimirNConsumo
        {
            get
            {
                return mEsImprimirNConsumo;
            }
            set
            {
                mEsImprimirNConsumo = value;
            }
        }

        public Boolean EsOffline
        {
            get
            {
                return mEsOffline;
            }
            set
            {
                mEsOffline = value;
            }
        }

        public Boolean EsPedirCantidadPredet
        {
            get
            {
                return mEsPedirCantidadPredet;
            }
            set
            {
                mEsPedirCantidadPredet = value;
            }
        }

        public Boolean EsPoseeCaptaHuella
        {
            get
            {
                return mEsPoseeCaptaHuella;
            }
            set
            {
                mEsPoseeCaptaHuella = value;
            }
        }

        public Boolean EsPoseeGaveta
        {
            get
            {
                return mEsPoseeGaveta;
            }
            set
            {
                mEsPoseeGaveta = value;
            }
        }

        public Boolean EsPoseeLectorPOSBanca
        {
            get
            {
                return mEsPoseeLectorPOSBanca;
            }
            set
            {
                mEsPoseeLectorPOSBanca = value;
            }
        }

        public Boolean EsPoseeMouse
        {
            get
            {
                return mEsPoseeMouse;
            }
            set
            {
                mEsPoseeMouse = value;
            }
        }

        public Boolean EsPoseePantallaTactil
        {
            get
            {
                return mEsPoseePantallaTactil;
            }
            set
            {
                mEsPoseePantallaTactil = value;
            }
        }

        public Boolean EsPoseeTeclado
        {
            get
            {
                return mEsPoseeTeclado;
            }
            set
            {
                mEsPoseeTeclado = value;
            }
        }

        public Boolean EsPoseeVisorPrecio
        {
            get
            {
                return mEsPoseeVisorPrecio;
            }
            set
            {
                mEsPoseeVisorPrecio = value;
            }
        }

        public Boolean EsPoseeVisorPreciosMonitorExtra
        {
            get
            {
                return mEsPoseeVisorPreciosMonitorExtra;
            }
            set
            {
                mEsPoseeVisorPreciosMonitorExtra = value;
            }
        }

        public Boolean EsPreguntarCerrarApp
        {
            get
            {
                return mEsPreguntarCerrarApp;
            }
            set
            {
                mEsPreguntarCerrarApp = value;
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

        public Boolean EsRequierePassword
        {
            get
            {
                return mEsRequierePassword;
            }
            set
            {
                mEsRequierePassword = value;
            }
        }

        public Boolean EsSolicitarEmpleado
        {
            get
            {
                return mEsSolicitarEmpleado;
            }
            set
            {
                mEsSolicitarEmpleado = value;
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

        Estaciones()
        {
        }

        Estaciones(int ID, int ID_Licencia, int ID_defTipoDescargaInventario, int ID_defTipoEstacion, int ID_defTipoPedirDatosCliente, int ID_defTipoPrecioPredet, string Descirpcion, string NombreEquipo, string IPEstacion, DateTime FechaUltimaConfiguracion, bool esCliente_SolicitarEmail, bool esCliente_SolicitarRIF, bool esCliente_SolicitarTelefono, bool esimprimirEgreso, bool esImprimirFiscal, bool esImprimirNConsumo, bool esOffline, bool esPedirCantidadPredet, bool esPoseeCaptaHuella, bool esPoseeGaveta, bool esPoseeLectorPOSBanca, bool esPoseeMouse, bool esPoseePantallaTactil, bool esPoseeTeclado, bool esPoseeVisorPrecio, bool esPoseeVisorPreciosMonitorExtra, bool esPreguntarCerrarApp, bool esRemoto, bool esRequierePassword, bool esSolicitarEmpleado, bool esActivo, int id_Sucursal)
        {
            mID = ID;
            mID_Licencia = ID_Licencia;
            mID_defTipoDescargaInventario = ID_defTipoDescargaInventario;
            mID_defTipoEstacion = ID_defTipoEstacion;
            mID_defTipoPedirDatosCliente = ID_defTipoPedirDatosCliente;
            mID_defTipoPrecioPredet = ID_defTipoPrecioPredet;
            mDescirpcion = Descirpcion;
            mNombreEquipo = NombreEquipo;
            mIPEstacion = IPEstacion;
            mFechaUltimaConfiguracion = FechaUltimaConfiguracion;
            mEsCliente_SolicitarEmail = EsCliente_SolicitarEmail;
            mEsCliente_SolicitarRIF = EsCliente_SolicitarRIF;
            mEsCliente_SolicitarTelefono = EsCliente_SolicitarTelefono;
            mEsimprimirEgreso = EsimprimirEgreso;
            mEsImprimirFiscal = EsImprimirFiscal;
            mEsImprimirNConsumo = EsImprimirNConsumo;
            mEsOffline = EsOffline;
            mEsPedirCantidadPredet = EsPedirCantidadPredet;
            mEsPoseeCaptaHuella = EsPoseeCaptaHuella;
            mEsPoseeGaveta = EsPoseeGaveta;
            mEsPoseeLectorPOSBanca = EsPoseeLectorPOSBanca;
            mEsPoseeMouse = EsPoseeMouse;
            mEsPoseePantallaTactil = EsPoseePantallaTactil;
            mEsPoseeTeclado = EsPoseeTeclado;
            mEsPoseeVisorPrecio = EsPoseeVisorPrecio;
            mEsPoseeVisorPreciosMonitorExtra = EsPoseeVisorPreciosMonitorExtra;
            mEsPreguntarCerrarApp = EsPreguntarCerrarApp;
            mEsRemoto = EsRemoto;
            mEsRequierePassword = EsRequierePassword;
            mEsSolicitarEmpleado = EsSolicitarEmpleado;
            mEsActivo = EsActivo;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
