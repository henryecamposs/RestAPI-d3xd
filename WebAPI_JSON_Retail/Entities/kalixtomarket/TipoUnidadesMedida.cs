using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoUnidadesMedida : ICloneable
    {

        private int mID = 0;
        private int mId_UnidadMedidaUniversal = 0;
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

        public int Id_UnidadMedidaUniversal
        {
            get
            {
                return mId_UnidadMedidaUniversal;
            }
            set
            {
                mId_UnidadMedidaUniversal = value;
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

        TipoUnidadesMedida()
        {
        }

        TipoUnidadesMedida(int ID, int id_UnidadMedidaUniversal, string Abreviatura, string Descripcion, double CantidadPredeterminada)
        {
            mID = ID;
            mId_UnidadMedidaUniversal = Id_UnidadMedidaUniversal;
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
