using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Dispositivos_GavetaDinero : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private string mComando = "";
        private string mPuertoComunicaciones = "";
        private bool mEsGavetaDineroFiscal = false;

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

        public string Comando
        {
            get
            {
                return mComando;
            }
            set
            {
                mComando = value;
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

        public Boolean EsGavetaDineroFiscal
        {
            get
            {
                return mEsGavetaDineroFiscal;
            }
            set
            {
                mEsGavetaDineroFiscal = value;
            }
        }

        Estaciones_Dispositivos_GavetaDinero()
        {
        }

        Estaciones_Dispositivos_GavetaDinero(int ID, int id_Estacion, string Comando, string PuertoComunicaciones, bool esGavetaDineroFiscal)
        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mComando = Comando;
            mPuertoComunicaciones = PuertoComunicaciones;
            mEsGavetaDineroFiscal = EsGavetaDineroFiscal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
