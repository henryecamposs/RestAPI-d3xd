using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Dispositivo_Balanza : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private int mId_defTipoBalanzaModelo = 0;
        private int mId_defTipoBalanzaVendor = 0;
        private int mAnchoCodigoArticulo = 0;
        private int mAnchoValorPeso = 0;
        private string mCodigo = "";
        private string mNombrePuerto = "";
        private string mParametros = "";
        private int mPosicionFinCodigoArticulo = 0;
        private int mPosicionFinPesoDecimal = 0;
        private int mPosicionFinPesoEntero = 0;
        private int mPosicionIniCodigoArticulo = 0;
        private int mPosicionIniPesoDecimal = 0;
        private int mPosicionIniPesoEntero = 0;
        private bool mEsLeerCodigo = false;
        private bool mEsPuertoCOM = false;

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

        public int Id_defTipoBalanzaModelo
        {
            get
            {
                return mId_defTipoBalanzaModelo;
            }
            set
            {
                mId_defTipoBalanzaModelo = value;
            }
        }

        public int Id_defTipoBalanzaVendor
        {
            get
            {
                return mId_defTipoBalanzaVendor;
            }
            set
            {
                mId_defTipoBalanzaVendor = value;
            }
        }

        public int AnchoCodigoArticulo
        {
            get
            {
                return mAnchoCodigoArticulo;
            }
            set
            {
                mAnchoCodigoArticulo = value;
            }
        }

        public int AnchoValorPeso
        {
            get
            {
                return mAnchoValorPeso;
            }
            set
            {
                mAnchoValorPeso = value;
            }
        }

        public string Codigo
        {
            get
            {
                return mCodigo;
            }
            set
            {
                mCodigo = value;
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

        public string Parametros
        {
            get
            {
                return mParametros;
            }
            set
            {
                mParametros = value;
            }
        }

        public int PosicionFinCodigoArticulo
        {
            get
            {
                return mPosicionFinCodigoArticulo;
            }
            set
            {
                mPosicionFinCodigoArticulo = value;
            }
        }

        public int PosicionFinPesoDecimal
        {
            get
            {
                return mPosicionFinPesoDecimal;
            }
            set
            {
                mPosicionFinPesoDecimal = value;
            }
        }

        public int PosicionFinPesoEntero
        {
            get
            {
                return mPosicionFinPesoEntero;
            }
            set
            {
                mPosicionFinPesoEntero = value;
            }
        }

        public int PosicionIniCodigoArticulo
        {
            get
            {
                return mPosicionIniCodigoArticulo;
            }
            set
            {
                mPosicionIniCodigoArticulo = value;
            }
        }

        public int PosicionIniPesoDecimal
        {
            get
            {
                return mPosicionIniPesoDecimal;
            }
            set
            {
                mPosicionIniPesoDecimal = value;
            }
        }

        public int PosicionIniPesoEntero
        {
            get
            {
                return mPosicionIniPesoEntero;
            }
            set
            {
                mPosicionIniPesoEntero = value;
            }
        }

        public Boolean EsLeerCodigo
        {
            get
            {
                return mEsLeerCodigo;
            }
            set
            {
                mEsLeerCodigo = value;
            }
        }

        public Boolean EsPuertoCOM
        {
            get
            {
                return mEsPuertoCOM;
            }
            set
            {
                mEsPuertoCOM = value;
            }
        }

        Estaciones_Dispositivo_Balanza()
        {
        }

        Estaciones_Dispositivo_Balanza(int ID, int id_Estacion, int id_defTipoBalanzaModelo, int id_defTipoBalanzaVendor, int AnchoCodigoArticulo, int AnchoValorPeso, string Codigo, string NombrePuerto, string Parametros, int PosicionFinCodigoArticulo, int PosicionFinPesoDecimal, int PosicionFinPesoEntero, int PosicionIniCodigoArticulo, int PosicionIniPesoDecimal, int PosicionIniPesoEntero, bool esLeerCodigo, bool esPuertoCOM)
        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mId_defTipoBalanzaModelo = Id_defTipoBalanzaModelo;
            mId_defTipoBalanzaVendor = Id_defTipoBalanzaVendor;
            mAnchoCodigoArticulo = AnchoCodigoArticulo;
            mAnchoValorPeso = AnchoValorPeso;
            mCodigo = Codigo;
            mNombrePuerto = NombrePuerto;
            mParametros = Parametros;
            mPosicionFinCodigoArticulo = PosicionFinCodigoArticulo;
            mPosicionFinPesoDecimal = PosicionFinPesoDecimal;
            mPosicionFinPesoEntero = PosicionFinPesoEntero;
            mPosicionIniCodigoArticulo = PosicionIniCodigoArticulo;
            mPosicionIniPesoDecimal = PosicionIniPesoDecimal;
            mPosicionIniPesoEntero = PosicionIniPesoEntero;
            mEsLeerCodigo = EsLeerCodigo;
            mEsPuertoCOM = EsPuertoCOM;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
