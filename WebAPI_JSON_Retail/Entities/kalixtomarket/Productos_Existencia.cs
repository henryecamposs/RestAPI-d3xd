using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Existencia : ICloneable
    {

        private int mID = 0;
        private int mID_Producto = 0;
        private int mID_Almacen = 0;
        private int mID_UbicacionStock = 0;
        private double mStockFisico = 0.0;
        private double mStockPedidoCompra = 0.0;
        private double mStockPedidoVenta = 0.0;
        private double mStockProcesoVenta = 0.0;
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

        public int ID_Producto
        {
            get
            {
                return mID_Producto;
            }
            set
            {
                mID_Producto = value;
            }
        }

        public int ID_Almacen
        {
            get
            {
                return mID_Almacen;
            }
            set
            {
                mID_Almacen = value;
            }
        }

        public int ID_UbicacionStock
        {
            get
            {
                return mID_UbicacionStock;
            }
            set
            {
                mID_UbicacionStock = value;
            }
        }

        public Double StockFisico
        {
            get
            {
                return mStockFisico;
            }
            set
            {
                mStockFisico = value;
            }
        }

        public Double StockPedidoCompra
        {
            get
            {
                return mStockPedidoCompra;
            }
            set
            {
                mStockPedidoCompra = value;
            }
        }

        public Double StockPedidoVenta
        {
            get
            {
                return mStockPedidoVenta;
            }
            set
            {
                mStockPedidoVenta = value;
            }
        }

        public Double StockProcesoVenta
        {
            get
            {
                return mStockProcesoVenta;
            }
            set
            {
                mStockProcesoVenta = value;
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

        Productos_Existencia()
        {
        }

        Productos_Existencia(int ID, int ID_Producto, int ID_Almacen, int ID_UbicacionStock, double StockFisico, double StockPedidoCompra, double StockPedidoVenta, double StockProcesoVenta, DateTime FechaActual)
        {
            mID = ID;
            mID_Producto = ID_Producto;
            mID_Almacen = ID_Almacen;
            mID_UbicacionStock = ID_UbicacionStock;
            mStockFisico = StockFisico;
            mStockPedidoCompra = StockPedidoCompra;
            mStockPedidoVenta = StockPedidoVenta;
            mStockProcesoVenta = StockProcesoVenta;
            mFechaActual = FechaActual;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
