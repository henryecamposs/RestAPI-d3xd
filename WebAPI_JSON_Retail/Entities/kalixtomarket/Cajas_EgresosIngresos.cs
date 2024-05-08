using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Cajas_EgresosIngresos : ICloneable
    {

        private int mID = 0;
        private int mId_Estaciones_Sesion = 0;
        private int mId_Caja_Cortes = 0;
        private int mId_TipoEgresoIngreso = 0;
        private int mId_ArchivoAsociado = 0;
        private int mNroRecibo = 0;
        private string mNombreEntrega = "";
        private string mNombreAsociado = "";
        private string mNombreRecibe = "";
        private double mMontoTotal = 0.0;
        private int mNroDocAsociado = 0;
        private DateTime mFechaActural = new DateTime(2000, 01, 01);
        private DateTime mFechaRecibo = new DateTime(2000, 01, 01);

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

        public int Id_Caja_Cortes
        {
            get
            {
                return mId_Caja_Cortes;
            }
            set
            {
                mId_Caja_Cortes = value;
            }
        }

        public int Id_TipoEgresoIngreso
        {
            get
            {
                return mId_TipoEgresoIngreso;
            }
            set
            {
                mId_TipoEgresoIngreso = value;
            }
        }

        public int Id_ArchivoAsociado
        {
            get
            {
                return mId_ArchivoAsociado;
            }
            set
            {
                mId_ArchivoAsociado = value;
            }
        }

        public int NroRecibo
        {
            get
            {
                return mNroRecibo;
            }
            set
            {
                mNroRecibo = value;
            }
        }

        public string NombreEntrega
        {
            get
            {
                return mNombreEntrega;
            }
            set
            {
                mNombreEntrega = value;
            }
        }

        public string NombreAsociado
        {
            get
            {
                return mNombreAsociado;
            }
            set
            {
                mNombreAsociado = value;
            }
        }

        public string NombreRecibe
        {
            get
            {
                return mNombreRecibe;
            }
            set
            {
                mNombreRecibe = value;
            }
        }

        public Double MontoTotal
        {
            get
            {
                return mMontoTotal;
            }
            set
            {
                mMontoTotal = value;
            }
        }

        public int NroDocAsociado
        {
            get
            {
                return mNroDocAsociado;
            }
            set
            {
                mNroDocAsociado = value;
            }
        }

        public DateTime FechaActural
        {
            get
            {
                return mFechaActural;
            }
            set
            {
                mFechaActural = value;
            }
        }

        public DateTime FechaRecibo
        {
            get
            {
                return mFechaRecibo;
            }
            set
            {
                mFechaRecibo = value;
            }
        }

        Cajas_EgresosIngresos()
        {
        }

        Cajas_EgresosIngresos(int ID, int id_Estaciones_Sesion, int id_Caja_Cortes, int id_TipoEgresoIngreso, int id_ArchivoAsociado, int NroRecibo, string NombreEntrega, string NombreAsociado, string NombreRecibe, double MontoTotal, int NroDocAsociado, DateTime FechaActural, DateTime FechaRecibo)
        {
            mID = ID;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mId_Caja_Cortes = Id_Caja_Cortes;
            mId_TipoEgresoIngreso = Id_TipoEgresoIngreso;
            mId_ArchivoAsociado = Id_ArchivoAsociado;
            mNroRecibo = NroRecibo;
            mNombreEntrega = NombreEntrega;
            mNombreAsociado = NombreAsociado;
            mNombreRecibe = NombreRecibe;
            mMontoTotal = MontoTotal;
            mNroDocAsociado = NroDocAsociado;
            mFechaActural = FechaActural;
            mFechaRecibo = FechaRecibo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
