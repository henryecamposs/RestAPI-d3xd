using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DIST_EFECTIVO_X : ICloneable
    {

        private string mCaja = "";
        private double mCantidad = 0.0;
        private string mCod_moneda = "";
        private string mEmple = "";
        private DateTime mFecha_hora = new DateTime(2000, 01, 01);
        private int mId = 0;
        private double mTipo = 0.0;
        private double mValor = 0.0;

        public string Caja
        {
            get
            {
                return mCaja;
            }
            set
            {
                mCaja = value;
            }
        }

        public Double Cantidad
        {
            get
            {
                return mCantidad;
            }
            set
            {
                mCantidad = value;
            }
        }

        public string Cod_moneda
        {
            get
            {
                return mCod_moneda;
            }
            set
            {
                mCod_moneda = value;
            }
        }

        public string Emple
        {
            get
            {
                return mEmple;
            }
            set
            {
                mEmple = value;
            }
        }

        public DateTime Fecha_hora
        {
            get
            {
                return mFecha_hora;
            }
            set
            {
                mFecha_hora = value;
            }
        }

        public int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }

        public Double Tipo
        {
            get
            {
                return mTipo;
            }
            set
            {
                mTipo = value;
            }
        }

        public Double Valor
        {
            get
            {
                return mValor;
            }
            set
            {
                mValor = value;
            }
        }

        DIST_EFECTIVO_X()
        {
        }

        DIST_EFECTIVO_X(string caja, double cantidad, string cod_moneda, string emple, DateTime fecha_hora, int id, double tipo, double valor)
        {
            mCaja = Caja;
            mCantidad = Cantidad;
            mCod_moneda = Cod_moneda;
            mEmple = Emple;
            mFecha_hora = Fecha_hora;
            mId = Id;
            mTipo = Tipo;
            mValor = Valor;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
