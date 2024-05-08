using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class World_UnidadesMedida : ICloneable
    {

        private int mID = 0;
        private string mAbreviatura = "";
        private string mDescripcion = "";
        private double mCantidadPredeterminada = 0.0;

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

        public string Abreviatura
        {
            get
            {
                return mAbreviatura;
            }
            set
            {
                mAbreviatura = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
            }
        }

        public Double CantidadPredeterminada
        {
            get
            {
                return mCantidadPredeterminada;
            }
            set
            {
                mCantidadPredeterminada = value;
            }
        }

        World_UnidadesMedida()
        {
        }

        World_UnidadesMedida(int ID, string Abreviatura, string Descripcion, double cantidadPredeterminada)
        {
            mID = ID;
            mAbreviatura = Abreviatura;
            mDescripcion = Descripcion;
            mCantidadPredeterminada = CantidadPredeterminada;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
