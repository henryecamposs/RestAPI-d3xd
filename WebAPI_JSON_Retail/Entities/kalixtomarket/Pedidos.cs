using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Pedidos : ICloneable
    {

        private int mID = 0;
        private int mId_Caja = 0;
        private int mId_Cliente = 0;
        private int mId_corteZ = 0;
        private int mId_Empleado = 0;
        private int mId_Estaciones_Sesiones = 0;
        private int mId_defTipoSatusFactura = 0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaPedido = new DateTime(2000, 01, 01);
        private double mMontoTotal = 0.0;
        private double mMontoTotalBase = 0.0;
        private double mMontoTotalIVA = 0.0;
        private double mMontoTotalDescuento = 0.0;
        private int mNroItems = 0;
        private int mNroPedido = 0;
        private string mNroPedidoIF = "";
        private string mComentarios = "";
        private bool mEsDevolucion = false;
        private int mId_Sucursal = 0;

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

        public int Id_Caja
        {
            get
            {
                return mId_Caja;
            }
            set
            {
                mId_Caja = value;
            }
        }

        public int Id_Cliente
        {
            get
            {
                return mId_Cliente;
            }
            set
            {
                mId_Cliente = value;
            }
        }

        public int Id_corteZ
        {
            get
            {
                return mId_corteZ;
            }
            set
            {
                mId_corteZ = value;
            }
        }

        public int Id_Empleado
        {
            get
            {
                return mId_Empleado;
            }
            set
            {
                mId_Empleado = value;
            }
        }

        public int Id_Estaciones_Sesiones
        {
            get
            {
                return mId_Estaciones_Sesiones;
            }
            set
            {
                mId_Estaciones_Sesiones = value;
            }
        }

        public int Id_defTipoSatusFactura
        {
            get
            {
                return mId_defTipoSatusFactura;
            }
            set
            {
                mId_defTipoSatusFactura = value;
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

        public DateTime FechaPedido
        {
            get
            {
                return mFechaPedido;
            }
            set
            {
                mFechaPedido = value;
            }
        }

        public Double MontoTotal
        {
            get
            {
                return mMontoTotal;
            }
            set
            {
                mMontoTotal = value;
            }
        }

        public Double MontoTotalBase
        {
            get
            {
                return mMontoTotalBase;
            }
            set
            {
                mMontoTotalBase = value;
            }
        }

        public Double MontoTotalIVA
        {
            get
            {
                return mMontoTotalIVA;
            }
            set
            {
                mMontoTotalIVA = value;
            }
        }

        public Double MontoTotalDescuento
        {
            get
            {
                return mMontoTotalDescuento;
            }
            set
            {
                mMontoTotalDescuento = value;
            }
        }

        public int NroItems
        {
            get
            {
                return mNroItems;
            }
            set
            {
                mNroItems = value;
            }
        }

        public int NroPedido
        {
            get
            {
                return mNroPedido;
            }
            set
            {
                mNroPedido = value;
            }
        }

        public string NroPedidoIF
        {
            get
            {
                return mNroPedidoIF;
            }
            set
            {
                mNroPedidoIF = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return mComentarios;
            }
            set
            {
                mComentarios = value;
            }
        }

        public Boolean EsDevolucion
        {
            get
            {
                return mEsDevolucion;
            }
            set
            {
                mEsDevolucion = value;
            }
        }

        public int Id_Sucursal
        {
            get
            {
                return mId_Sucursal;
            }
            set
            {
                mId_Sucursal = value;
            }
        }

        Pedidos()
        {
        }

        Pedidos(int ID, int Id_Caja, int Id_Cliente, int id_corteZ, int Id_Empleado, int Id_Estaciones_Sesiones, int id_defTipoSatusFactura, DateTime FechaActual, DateTime FechaPedido, double MontoTotal, double MontoTotalBase, double MontoTotalIVA, double MontoTotalDescuento, int NroItems, int NroPedido, string NroPedidoIF, string Comentarios, bool esDevolucion, int id_Sucursal)
        {
            mID = ID;
            mId_Caja = Id_Caja;
            mId_Cliente = Id_Cliente;
            mId_corteZ = Id_corteZ;
            mId_Empleado = Id_Empleado;
            mId_Estaciones_Sesiones = Id_Estaciones_Sesiones;
            mId_defTipoSatusFactura = Id_defTipoSatusFactura;
            mFechaActual = FechaActual;
            mFechaPedido = FechaPedido;
            mMontoTotal = MontoTotal;
            mMontoTotalBase = MontoTotalBase;
            mMontoTotalIVA = MontoTotalIVA;
            mMontoTotalDescuento = MontoTotalDescuento;
            mNroItems = NroItems;
            mNroPedido = NroPedido;
            mNroPedidoIF = NroPedidoIF;
            mComentarios = Comentarios;
            mEsDevolucion = EsDevolucion;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
