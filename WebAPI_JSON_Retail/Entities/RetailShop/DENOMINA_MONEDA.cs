using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class DENOMINA_MONEDA : ICloneable
    {

        private string mCodigo = "";
        private int mId = 0;
        private double mTipo = 0.0;
        private double mValor = 0.0;

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

        DENOMINA_MONEDA()
        {
        }

        DENOMINA_MONEDA(string codigo, int id, double tipo, double valor)
        {
            mCodigo = Codigo;
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
