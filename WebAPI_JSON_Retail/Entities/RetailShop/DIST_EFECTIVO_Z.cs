using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DIST_EFECTIVO_Z : ICloneable
    {

        private double mCantidad = 0.0;
        private string mCod_moneda = "";
        private string mEmple = "";
        private int mId = 0;
        private double mTipo = 0.0;
        private string mUid_corte = "";
        private double mValor = 0.0;

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

        public string Uid_corte
        {
            get
            {
                return mUid_corte;
            }
            set
            {
                mUid_corte = value;
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

        DIST_EFECTIVO_Z()
        {
        }

        DIST_EFECTIVO_Z(double cantidad, string cod_moneda, string emple, int id, double tipo, string uid_corte, double valor)
        {
            mCantidad = Cantidad;
            mCod_moneda = Cod_moneda;
            mEmple = Emple;
            mId = Id;
            mTipo = Tipo;
            mUid_corte = Uid_corte;
            mValor = Valor;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
