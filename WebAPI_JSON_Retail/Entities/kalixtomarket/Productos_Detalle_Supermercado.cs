using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Detalle_Supermercado : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private DateTime mFechaVencimiento = new DateTime(2000, 01, 01);
        private bool mEsAlimento = false;
        private bool mEsPerecedero = false;
        private bool mEsControlado = false;

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

        public int Id_Producto
        {
            get
            {
                return mId_Producto;
            }
            set
            {
                mId_Producto = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return mFechaVencimiento;
            }
            set
            {
                mFechaVencimiento = value;
            }
        }

        public Boolean EsAlimento
        {
            get
            {
                return mEsAlimento;
            }
            set
            {
                mEsAlimento = value;
            }
        }

        public Boolean EsPerecedero
        {
            get
            {
                return mEsPerecedero;
            }
            set
            {
                mEsPerecedero = value;
            }
        }

        public Boolean EsControlado
        {
            get
            {
                return mEsControlado;
            }
            set
            {
                mEsControlado = value;
            }
        }

        Productos_Detalle_Supermercado()
        {
        }

        Productos_Detalle_Supermercado(int ID, int Id_Producto, DateTime FechaVencimiento, bool esAlimento, bool esPerecedero, bool esControlado)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mFechaVencimiento = FechaVencimiento;
            mEsAlimento = EsAlimento;
            mEsPerecedero = EsPerecedero;
            mEsControlado = EsControlado;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
