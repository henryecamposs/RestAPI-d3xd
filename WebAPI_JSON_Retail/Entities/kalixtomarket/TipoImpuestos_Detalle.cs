using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoImpuestos_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_TipoImpuesto = 0;
        private int mId_Estaciones_Sesion = 0;
        private string mNomenclaturaAnterior = "";
        private string mNomenclaturaNueva = "";
        private double mMontoTasaAnterior = 0.0;
        private double mMontoTasaNueva = 0.0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);

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

        public int Id_TipoImpuesto
        {
            get
            {
                return mId_TipoImpuesto;
            }
            set
            {
                mId_TipoImpuesto = value;
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

        public string NomenclaturaAnterior
        {
            get
            {
                return mNomenclaturaAnterior;
            }
            set
            {
                mNomenclaturaAnterior = value;
            }
        }

        public string NomenclaturaNueva
        {
            get
            {
                return mNomenclaturaNueva;
            }
            set
            {
                mNomenclaturaNueva = value;
            }
        }

        public Double MontoTasaAnterior
        {
            get
            {
                return mMontoTasaAnterior;
            }
            set
            {
                mMontoTasaAnterior = value;
            }
        }

        public Double MontoTasaNueva
        {
            get
            {
                return mMontoTasaNueva;
            }
            set
            {
                mMontoTasaNueva = value;
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return mFechaActual;
            }
            set
            {
                mFechaActual = value;
            }
        }

        TipoImpuestos_Detalle()
        {
        }

        TipoImpuestos_Detalle(int ID, int id_TipoImpuesto, int id_Estaciones_Sesion, string NomenclaturaAnterior, string NomenclaturaNueva, double MontoTasaAnterior, double MontoTasaNueva, DateTime FechaActual)
        {
            mID = ID;
            mId_TipoImpuesto = Id_TipoImpuesto;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mNomenclaturaAnterior = NomenclaturaAnterior;
            mNomenclaturaNueva = NomenclaturaNueva;
            mMontoTasaAnterior = MontoTasaAnterior;
            mMontoTasaNueva = MontoTasaNueva;
            mFechaActual = FechaActual;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
