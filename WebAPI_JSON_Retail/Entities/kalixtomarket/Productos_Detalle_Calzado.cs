using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Detalle_Calzado : ICloneable
    {

        private int mID = 0;
        private int mId_producto = 0;
        private int mId_Lote = 0;
        private bool mEsCalzado = false;
        private bool mEsUsaColores = false;
        private bool mEsUsaTallas = false;

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

        public int Id_producto
        {
            get
            {
                return mId_producto;
            }
            set
            {
                mId_producto = value;
            }
        }

        public int Id_Lote
        {
            get
            {
                return mId_Lote;
            }
            set
            {
                mId_Lote = value;
            }
        }

        public Boolean EsCalzado
        {
            get
            {
                return mEsCalzado;
            }
            set
            {
                mEsCalzado = value;
            }
        }

        public Boolean EsUsaColores
        {
            get
            {
                return mEsUsaColores;
            }
            set
            {
                mEsUsaColores = value;
            }
        }

        public Boolean EsUsaTallas
        {
            get
            {
                return mEsUsaTallas;
            }
            set
            {
                mEsUsaTallas = value;
            }
        }

        Productos_Detalle_Calzado()
        {
        }

        Productos_Detalle_Calzado(int ID, int Id_producto, int Id_Lote, bool esCalzado, bool esUsaColores, bool esUsaTallas)
        {
            mID = ID;
            mId_producto = Id_producto;
            mId_Lote = Id_Lote;
            mEsCalzado = EsCalzado;
            mEsUsaColores = EsUsaColores;
            mEsUsaTallas = EsUsaTallas;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
