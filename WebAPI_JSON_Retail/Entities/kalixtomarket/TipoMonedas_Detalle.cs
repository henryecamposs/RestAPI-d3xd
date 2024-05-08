using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoMonedas_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_TipoMoneda = 0;
        private int mId_Estaciones_Sesion = 0;
        private string mComentario = "";
        private double mFactorAnterior = 0.0;
        private double mFactorNuevo = 0.0;
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

        public int Id_TipoMoneda
        {
            get
            {
                return mId_TipoMoneda;
            }
            set
            {
                mId_TipoMoneda = value;
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

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public Double FactorAnterior
        {
            get
            {
                return mFactorAnterior;
            }
            set
            {
                mFactorAnterior = value;
            }
        }

        public Double FactorNuevo
        {
            get
            {
                return mFactorNuevo;
            }
            set
            {
                mFactorNuevo = value;
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

        TipoMonedas_Detalle()
        {
        }

        TipoMonedas_Detalle(int ID, int id_TipoMoneda, int id_Estaciones_Sesion, string Comentario, double FactorAnterior, double FactorNuevo, DateTime FechaActual)
        {
            mID = ID;
            mId_TipoMoneda = Id_TipoMoneda;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mComentario = Comentario;
            mFactorAnterior = FactorAnterior;
            mFactorNuevo = FactorNuevo;
            mFechaActual = FechaActual;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
