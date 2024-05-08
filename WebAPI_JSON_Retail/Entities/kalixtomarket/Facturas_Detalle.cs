using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_Factura = 0;
        private int mId_Producto = 0;
        private int mId_TipoImpuesto = 0;
        private int mId_TipoDescuento = 0;
        private int mId_TipoPromocion = 0;
        private int mId_TipoOferta = 0;
        private int mId_defTipoPrecio = 0;
        private string mDescripcion = "";
        private int mNroItem = 0;
        private double mCantidad = 0.0;
        private double mMontoPrecio = 0.0;
        private double mMontoTotalImpuesto = 0.0;
        private double mMontoTotalBase = 0.0;
        private string mComentario = "";
        private double mEsDevolucion = 0.0;

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

        public int Id_Factura
        {
            get
            {
                return mId_Factura;
            }
            set
            {
                mId_Factura = value;
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

        public int Id_TipoImpuesto
        {
            get
            {
                return mId_TipoImpuesto;
            }
            set
            {
                mId_TipoImpuesto = value;
            }
        }

        public int Id_TipoDescuento
        {
            get
            {
                return mId_TipoDescuento;
            }
            set
            {
                mId_TipoDescuento = value;
            }
        }

        public int Id_TipoPromocion
        {
            get
            {
                return mId_TipoPromocion;
            }
            set
            {
                mId_TipoPromocion = value;
            }
        }

        public int Id_TipoOferta
        {
            get
            {
                return mId_TipoOferta;
            }
            set
            {
                mId_TipoOferta = value;
            }
        }

        public int Id_defTipoPrecio
        {
            get
            {
                return mId_defTipoPrecio;
            }
            set
            {
                mId_defTipoPrecio = value;
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

        public int NroItem
        {
            get
            {
                return mNroItem;
            }
            set
            {
                mNroItem = value;
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

        public Double MontoPrecio
        {
            get
            {
                return mMontoPrecio;
            }
            set
            {
                mMontoPrecio = value;
            }
        }

        public Double MontoTotalImpuesto
        {
            get
            {
                return mMontoTotalImpuesto;
            }
            set
            {
                mMontoTotalImpuesto = value;
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

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public Double EsDevolucion
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

        Facturas_Detalle()
        {
        }

        Facturas_Detalle(int ID, int Id_Factura, int Id_Producto, int Id_TipoImpuesto, int id_TipoDescuento, int id_TipoPromocion, int id_TipoOferta, int id_defTipoPrecio, string Descripcion, int NroItem, double Cantidad, double MontoPrecio, double MontoTotalImpuesto, double MontoTotalBase, string Comentario, double esDevolucion)
        {
            mID = ID;
            mId_Factura = Id_Factura;
            mId_Producto = Id_Producto;
            mId_TipoImpuesto = Id_TipoImpuesto;
            mId_TipoDescuento = Id_TipoDescuento;
            mId_TipoPromocion = Id_TipoPromocion;
            mId_TipoOferta = Id_TipoOferta;
            mId_defTipoPrecio = Id_defTipoPrecio;
            mDescripcion = Descripcion;
            mNroItem = NroItem;
            mCantidad = Cantidad;
            mMontoPrecio = MontoPrecio;
            mMontoTotalImpuesto = MontoTotalImpuesto;
            mMontoTotalBase = MontoTotalBase;
            mComentario = Comentario;
            mEsDevolucion = EsDevolucion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
