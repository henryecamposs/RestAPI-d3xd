using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Pedidos_Descuentos : ICloneable
    {

        private int mID = 0;
        private int mId_Descuento = 0;
        private int mId_Pedido = 0;
        private double mTasaValor = 0.0;

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

        public int Id_Descuento
        {
            get
            {
                return mId_Descuento;
            }
            set
            {
                mId_Descuento = value;
            }
        }

        public int Id_Pedido
        {
            get
            {
                return mId_Pedido;
            }
            set
            {
                mId_Pedido = value;
            }
        }

        public Double TasaValor
        {
            get
            {
                return mTasaValor;
            }
            set
            {
                mTasaValor = value;
            }
        }

        Pedidos_Descuentos()
        {
        }

        Pedidos_Descuentos(int ID, int Id_Descuento, int Id_Pedido, double TasaValor)
        {
            mID = ID;
            mId_Descuento = Id_Descuento;
            mId_Pedido = Id_Pedido;
            mTasaValor = TasaValor;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
