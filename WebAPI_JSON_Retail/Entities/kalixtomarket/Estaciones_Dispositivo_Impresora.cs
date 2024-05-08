using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Dispositivo_Impresora : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private int mId_defTipoImpresoraModelo = 0;
        private int mId_defTipoImpresoraVendor = 0;
        private int mId_defTipoTipoImpresora = 0;
        private string mEncabezado1 = "";
        private string mEncabezado2 = "";
        private string mEncabezado3 = "";
        private string mEncabezado4 = "";
        private string mEncabezado5 = "";
        private string mEncabezado6 = "";
        private int mNColumnas = 0;
        private string mNConsumo_PuertoComunicaciones = "";
        private string mNombrePuerto = "";
        private string mPiePagina1 = "";
        private string mPiePagina2 = "";
        private string mPiePagina3 = "";
        private string mPiePagina4 = "";
        private string mPiePagina5 = "";
        private string mPiePagina6 = "";
        private bool mEsCommPort = false;
        private bool mEsIFiscal = false;
        private bool mEsImprimirDatosEmpresa = false;
        private bool mEsImprimirEmpleado = false;
        private bool mEsImprimirNropedido = false;
        private bool mEsMsjPiePagina = false;
        private bool mEsNConsumo = false;
        private bool mEsRemoto = false;
        private bool mEsUsaSpooler = false;
        private bool mEsNconsumoMsjPiePagina = false;
        private bool mEsNconsumoForzarImpresion = false;
        private bool mEsNconsumoImpEncabezado = false;
        private bool mEsNconsumoImpNombreEmpleado = false;
        private bool mEsNconsumoImpOpcionPropina = false;
        private bool mEsNconsumoImpPieCliente = false;
        private bool mEsNconsumoImpPrecios = false;
        private bool mEsNconsumoImpPreciosConIVA = false;
        private bool mEsNconsumoImpTotalConIVA = false;

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

        public int Id_defTipoImpresoraModelo
        {
            get
            {
                return mId_defTipoImpresoraModelo;
            }
            set
            {
                mId_defTipoImpresoraModelo = value;
            }
        }

        public int Id_defTipoImpresoraVendor
        {
            get
            {
                return mId_defTipoImpresoraVendor;
            }
            set
            {
                mId_defTipoImpresoraVendor = value;
            }
        }

        public int Id_defTipoTipoImpresora
        {
            get
            {
                return mId_defTipoTipoImpresora;
            }
            set
            {
                mId_defTipoTipoImpresora = value;
            }
        }

        public string Encabezado1
        {
            get
            {
                return mEncabezado1;
            }
            set
            {
                mEncabezado1 = value;
            }
        }

        public string Encabezado2
        {
            get
            {
                return mEncabezado2;
            }
            set
            {
                mEncabezado2 = value;
            }
        }

        public string Encabezado3
        {
            get
            {
                return mEncabezado3;
            }
            set
            {
                mEncabezado3 = value;
            }
        }

        public string Encabezado4
        {
            get
            {
                return mEncabezado4;
            }
            set
            {
                mEncabezado4 = value;
            }
        }

        public string Encabezado5
        {
            get
            {
                return mEncabezado5;
            }
            set
            {
                mEncabezado5 = value;
            }
        }

        public string Encabezado6
        {
            get
            {
                return mEncabezado6;
            }
            set
            {
                mEncabezado6 = value;
            }
        }

        public int NColumnas
        {
            get
            {
                return mNColumnas;
            }
            set
            {
                mNColumnas = value;
            }
        }

        public string NConsumo_PuertoComunicaciones
        {
            get
            {
                return mNConsumo_PuertoComunicaciones;
            }
            set
            {
                mNConsumo_PuertoComunicaciones = value;
            }
        }

        public string NombrePuerto
        {
            get
            {
                return mNombrePuerto;
            }
            set
            {
                mNombrePuerto = value;
            }
        }

        public string PiePagina1
        {
            get
            {
                return mPiePagina1;
            }
            set
            {
                mPiePagina1 = value;
            }
        }

        public string PiePagina2
        {
            get
            {
                return mPiePagina2;
            }
            set
            {
                mPiePagina2 = value;
            }
        }

        public string PiePagina3
        {
            get
            {
                return mPiePagina3;
            }
            set
            {
                mPiePagina3 = value;
            }
        }

        public string PiePagina4
        {
            get
            {
                return mPiePagina4;
            }
            set
            {
                mPiePagina4 = value;
            }
        }

        public string PiePagina5
        {
            get
            {
                return mPiePagina5;
            }
            set
            {
                mPiePagina5 = value;
            }
        }

        public string PiePagina6
        {
            get
            {
                return mPiePagina6;
            }
            set
            {
                mPiePagina6 = value;
            }
        }

        public Boolean EsCommPort
        {
            get
            {
                return mEsCommPort;
            }
            set
            {
                mEsCommPort = value;
            }
        }

        public Boolean EsIFiscal
        {
            get
            {
                return mEsIFiscal;
            }
            set
            {
                mEsIFiscal = value;
            }
        }

        public Boolean EsImprimirDatosEmpresa
        {
            get
            {
                return mEsImprimirDatosEmpresa;
            }
            set
            {
                mEsImprimirDatosEmpresa = value;
            }
        }

        public Boolean EsImprimirEmpleado
        {
            get
            {
                return mEsImprimirEmpleado;
            }
            set
            {
                mEsImprimirEmpleado = value;
            }
        }

        public Boolean EsImprimirNropedido
        {
            get
            {
                return mEsImprimirNropedido;
            }
            set
            {
                mEsImprimirNropedido = value;
            }
        }

        public Boolean EsMsjPiePagina
        {
            get
            {
                return mEsMsjPiePagina;
            }
            set
            {
                mEsMsjPiePagina = value;
            }
        }

        public Boolean EsNConsumo
        {
            get
            {
                return mEsNConsumo;
            }
            set
            {
                mEsNConsumo = value;
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

        public Boolean EsUsaSpooler
        {
            get
            {
                return mEsUsaSpooler;
            }
            set
            {
                mEsUsaSpooler = value;
            }
        }

        public Boolean EsNconsumoMsjPiePagina
        {
            get
            {
                return mEsNconsumoMsjPiePagina;
            }
            set
            {
                mEsNconsumoMsjPiePagina = value;
            }
        }

        public Boolean EsNconsumoForzarImpresion
        {
            get
            {
                return mEsNconsumoForzarImpresion;
            }
            set
            {
                mEsNconsumoForzarImpresion = value;
            }
        }

        public Boolean EsNconsumoImpEncabezado
        {
            get
            {
                return mEsNconsumoImpEncabezado;
            }
            set
            {
                mEsNconsumoImpEncabezado = value;
            }
        }

        public Boolean EsNconsumoImpNombreEmpleado
        {
            get
            {
                return mEsNconsumoImpNombreEmpleado;
            }
            set
            {
                mEsNconsumoImpNombreEmpleado = value;
            }
        }

        public Boolean EsNconsumoImpOpcionPropina
        {
            get
            {
                return mEsNconsumoImpOpcionPropina;
            }
            set
            {
                mEsNconsumoImpOpcionPropina = value;
            }
        }

        public Boolean EsNconsumoImpPieCliente
        {
            get
            {
                return mEsNconsumoImpPieCliente;
            }
            set
            {
                mEsNconsumoImpPieCliente = value;
            }
        }

        public Boolean EsNconsumoImpPrecios
        {
            get
            {
                return mEsNconsumoImpPrecios;
            }
            set
            {
                mEsNconsumoImpPrecios = value;
            }
        }

        public Boolean EsNconsumoImpPreciosConIVA
        {
            get
            {
                return mEsNconsumoImpPreciosConIVA;
            }
            set
            {
                mEsNconsumoImpPreciosConIVA = value;
            }
        }

        public Boolean EsNconsumoImpTotalConIVA
        {
            get
            {
                return mEsNconsumoImpTotalConIVA;
            }
            set
            {
                mEsNconsumoImpTotalConIVA = value;
            }
        }

        Estaciones_Dispositivo_Impresora()
        {
        }

        Estaciones_Dispositivo_Impresora(int ID, int id_Estacion, int id_defTipoImpresoraModelo, int id_defTipoImpresoraVendor, int id_defTipoTipoImpresora, string Encabezado1, string Encabezado2, string Encabezado3, string Encabezado4, string Encabezado5, string Encabezado6, int nColumnas, string NConsumo_PuertoComunicaciones, string NombrePuerto, string PiePagina1, string PiePagina2, string PiePagina3, string PiePagina4, string PiePagina5, string PiePagina6, bool esCommPort, bool esIFiscal, bool esImprimirDatosEmpresa, bool esImprimirEmpleado, bool esImprimirNropedido, bool esMsjPiePagina, bool esNConsumo, bool esRemoto, bool esUsaSpooler, bool esNconsumoMsjPiePagina, bool esNconsumoForzarImpresion, bool esNconsumoImpEncabezado, bool esNconsumoImpNombreEmpleado, bool esNconsumoImpOpcionPropina, bool esNconsumoImpPieCliente, bool esNconsumoImpPrecios, bool esNconsumoImpPreciosConIVA, bool esNconsumoImpTotalConIVA)

        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mId_defTipoImpresoraModelo = Id_defTipoImpresoraModelo;
            mId_defTipoImpresoraVendor = Id_defTipoImpresoraVendor;
            mId_defTipoTipoImpresora = Id_defTipoTipoImpresora;
            mEncabezado1 = Encabezado1;
            mEncabezado2 = Encabezado2;
            mEncabezado3 = Encabezado3;
            mEncabezado4 = Encabezado4;
            mEncabezado5 = Encabezado5;
            mEncabezado6 = Encabezado6;
            mNColumnas = NColumnas;
            mNConsumo_PuertoComunicaciones = NConsumo_PuertoComunicaciones;
            mNombrePuerto = NombrePuerto;
            mPiePagina1 = PiePagina1;
            mPiePagina2 = PiePagina2;
            mPiePagina3 = PiePagina3;
            mPiePagina4 = PiePagina4;
            mPiePagina5 = PiePagina5;
            mPiePagina6 = PiePagina6;
            mEsCommPort = EsCommPort;
            mEsIFiscal = EsIFiscal;
            mEsImprimirDatosEmpresa = EsImprimirDatosEmpresa;
            mEsImprimirEmpleado = EsImprimirEmpleado;
            mEsImprimirNropedido = EsImprimirNropedido;
            mEsMsjPiePagina = EsMsjPiePagina;
            mEsNConsumo = EsNConsumo;
            mEsRemoto = EsRemoto;
            mEsUsaSpooler = EsUsaSpooler;
            mEsNconsumoMsjPiePagina = EsNconsumoMsjPiePagina;
            mEsNconsumoForzarImpresion = EsNconsumoForzarImpresion;
            mEsNconsumoImpEncabezado = EsNconsumoImpEncabezado;
            mEsNconsumoImpNombreEmpleado = EsNconsumoImpNombreEmpleado;
            mEsNconsumoImpOpcionPropina = EsNconsumoImpOpcionPropina;
            mEsNconsumoImpPieCliente = EsNconsumoImpPieCliente;
            mEsNconsumoImpPrecios = EsNconsumoImpPrecios;
            mEsNconsumoImpPreciosConIVA = EsNconsumoImpPreciosConIVA;
            mEsNconsumoImpTotalConIVA = EsNconsumoImpTotalConIVA;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
