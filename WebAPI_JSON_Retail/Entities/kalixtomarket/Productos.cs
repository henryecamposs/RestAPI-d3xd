using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos : ICloneable
    {

        private int mID = 0;
        private int mId_TipoProductoGrupo = 0;
        private int mId_Marca = 0;
        private int mId_UnidadMedida = 0;
        private int mId_UnidadEmpaque = 0;
        private int mId_TipoProducto = 0;
        private string mDescripcion = "";
        private string mProducto_DescripcionLarga = "";
        private string mProducto_LinkWeb = "";
        private string mCodigoAdicional = "";
        private string mCodigoBarras = "";
        private string mCodigoInterno = "";
        private double mCantidadUnidad = 0.0;
        private double mCantidadEmpaque = 0.0;
        private DateTime mFechaCreacion = new DateTime(2000, 01, 01);
        private DateTime mFechaUltimaCompra = new DateTime(2000, 01, 01);
        private DateTime mFechaUltimaModificacion = new DateTime(2000, 01, 01);
        private DateTime mFechaUltimaVenta = new DateTime(2000, 01, 01);
        private double mMargenGananciaPrecio1 = 0.0;
        private double mMargenGananciaPrecio2 = 0.0;
        private double mMargenGananciaPrecio3 = 0.0;
        private double mMontoCostoPromedio = 0.0;
        private double mMontoPrecio1 = 0.0;
        private double mMontoPrecio2 = 0.0;
        private double mMontoPrecio3 = 0.0;
        private double mMontoUltimoCosto = 0.0;
        private double mMontoPrecioDivisa = 0.0;
        private double mMontoCostoDivisa = 0.0;
        private double mMedidaAlto = 0.0;
        private double mMedidaAncho = 0.0;
        private double mMedidaLargo = 0.0;
        private int mNDiasGarantia = 0;
        private int mMinStock = 0;
        private int mMaxStock = 0;
        private string mImagenArchivo = "";
        private bool mEsCodigoAlterno = false;
        private bool mEsCompuesto = false;
        private bool mEsVenderSinStock = false;
        private bool mEsMultiplesImpuestos = false;
        private bool mEsFavorito = false;
        private bool mEsGarantia = false;
        private bool mEsImportado = false;
        private bool mEsRegulado = false;
        private bool mEsInventario = false;
        private bool mEsPideComentario = false;
        private bool mEsPidePeso = false;
        private bool mEsPidePrecio = false;
        private bool mEsPideTipoProducto = false;
        private bool mEsUsoInterno = false;
        private bool mEsActivo = false;
        private bool mEsTroquelado = false;
        private bool mEsPideBalanza = false;

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

        public int Id_TipoProductoGrupo
        {
            get
            {
                return mId_TipoProductoGrupo;
            }
            set
            {
                mId_TipoProductoGrupo = value;
            }
        }

        public int Id_Marca
        {
            get
            {
                return mId_Marca;
            }
            set
            {
                mId_Marca = value;
            }
        }

        public int Id_UnidadMedida
        {
            get
            {
                return mId_UnidadMedida;
            }
            set
            {
                mId_UnidadMedida = value;
            }
        }

        public int Id_UnidadEmpaque
        {
            get
            {
                return mId_UnidadEmpaque;
            }
            set
            {
                mId_UnidadEmpaque = value;
            }
        }

        public int Id_TipoProducto
        {
            get
            {
                return mId_TipoProducto;
            }
            set
            {
                mId_TipoProducto = value;
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

        public string Producto_DescripcionLarga
        {
            get
            {
                return mProducto_DescripcionLarga;
            }
            set
            {
                mProducto_DescripcionLarga = value;
            }
        }

        public string Producto_LinkWeb
        {
            get
            {
                return mProducto_LinkWeb;
            }
            set
            {
                mProducto_LinkWeb = value;
            }
        }

        public string CodigoAdicional
        {
            get
            {
                return mCodigoAdicional;
            }
            set
            {
                mCodigoAdicional = value;
            }
        }

        public string CodigoBarras
        {
            get
            {
                return mCodigoBarras;
            }
            set
            {
                mCodigoBarras = value;
            }
        }

        public string CodigoInterno
        {
            get
            {
                return mCodigoInterno;
            }
            set
            {
                mCodigoInterno = value;
            }
        }

        public Double CantidadUnidad
        {
            get
            {
                return mCantidadUnidad;
            }
            set
            {
                mCantidadUnidad = value;
            }
        }

        public Double CantidadEmpaque
        {
            get
            {
                return mCantidadEmpaque;
            }
            set
            {
                mCantidadEmpaque = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return mFechaCreacion;
            }
            set
            {
                mFechaCreacion = value;
            }
        }

        public DateTime FechaUltimaCompra
        {
            get
            {
                return mFechaUltimaCompra;
            }
            set
            {
                mFechaUltimaCompra = value;
            }
        }

        public DateTime FechaUltimaModificacion
        {
            get
            {
                return mFechaUltimaModificacion;
            }
            set
            {
                mFechaUltimaModificacion = value;
            }
        }

        public DateTime FechaUltimaVenta
        {
            get
            {
                return mFechaUltimaVenta;
            }
            set
            {
                mFechaUltimaVenta = value;
            }
        }

        public Double MargenGananciaPrecio1
        {
            get
            {
                return mMargenGananciaPrecio1;
            }
            set
            {
                mMargenGananciaPrecio1 = value;
            }
        }

        public Double MargenGananciaPrecio2
        {
            get
            {
                return mMargenGananciaPrecio2;
            }
            set
            {
                mMargenGananciaPrecio2 = value;
            }
        }

        public Double MargenGananciaPrecio3
        {
            get
            {
                return mMargenGananciaPrecio3;
            }
            set
            {
                mMargenGananciaPrecio3 = value;
            }
        }

        public Double MontoCostoPromedio
        {
            get
            {
                return mMontoCostoPromedio;
            }
            set
            {
                mMontoCostoPromedio = value;
            }
        }

        public Double MontoPrecio1
        {
            get
            {
                return mMontoPrecio1;
            }
            set
            {
                mMontoPrecio1 = value;
            }
        }

        public Double MontoPrecio2
        {
            get
            {
                return mMontoPrecio2;
            }
            set
            {
                mMontoPrecio2 = value;
            }
        }

        public Double MontoPrecio3
        {
            get
            {
                return mMontoPrecio3;
            }
            set
            {
                mMontoPrecio3 = value;
            }
        }

        public Double MontoUltimoCosto
        {
            get
            {
                return mMontoUltimoCosto;
            }
            set
            {
                mMontoUltimoCosto = value;
            }
        }

        public Double MontoPrecioDivisa
        {
            get
            {
                return mMontoPrecioDivisa;
            }
            set
            {
                mMontoPrecioDivisa = value;
            }
        }

        public Double MontoCostoDivisa
        {
            get
            {
                return mMontoCostoDivisa;
            }
            set
            {
                mMontoCostoDivisa = value;
            }
        }

        public Double MedidaAlto
        {
            get
            {
                return mMedidaAlto;
            }
            set
            {
                mMedidaAlto = value;
            }
        }

        public Double MedidaAncho
        {
            get
            {
                return mMedidaAncho;
            }
            set
            {
                mMedidaAncho = value;
            }
        }

        public Double MedidaLargo
        {
            get
            {
                return mMedidaLargo;
            }
            set
            {
                mMedidaLargo = value;
            }
        }

        public int NDiasGarantia
        {
            get
            {
                return mNDiasGarantia;
            }
            set
            {
                mNDiasGarantia = value;
            }
        }

        public int MinStock
        {
            get
            {
                return mMinStock;
            }
            set
            {
                mMinStock = value;
            }
        }

        public int MaxStock
        {
            get
            {
                return mMaxStock;
            }
            set
            {
                mMaxStock = value;
            }
        }

        public string ImagenArchivo
        {
            get
            {
                return mImagenArchivo;
            }
            set
            {
                mImagenArchivo = value;
            }
        }

        public Boolean EsCodigoAlterno
        {
            get
            {
                return mEsCodigoAlterno;
            }
            set
            {
                mEsCodigoAlterno = value;
            }
        }

        public Boolean EsCompuesto
        {
            get
            {
                return mEsCompuesto;
            }
            set
            {
                mEsCompuesto = value;
            }
        }

        public Boolean EsVenderSinStock
        {
            get
            {
                return mEsVenderSinStock;
            }
            set
            {
                mEsVenderSinStock = value;
            }
        }

        public Boolean EsMultiplesImpuestos
        {
            get
            {
                return mEsMultiplesImpuestos;
            }
            set
            {
                mEsMultiplesImpuestos = value;
            }
        }

        public Boolean EsFavorito
        {
            get
            {
                return mEsFavorito;
            }
            set
            {
                mEsFavorito = value;
            }
        }

        public Boolean EsGarantia
        {
            get
            {
                return mEsGarantia;
            }
            set
            {
                mEsGarantia = value;
            }
        }

        public Boolean EsImportado
        {
            get
            {
                return mEsImportado;
            }
            set
            {
                mEsImportado = value;
            }
        }

        public Boolean EsRegulado
        {
            get
            {
                return mEsRegulado;
            }
            set
            {
                mEsRegulado = value;
            }
        }

        public Boolean EsInventario
        {
            get
            {
                return mEsInventario;
            }
            set
            {
                mEsInventario = value;
            }
        }

        public Boolean EsPideComentario
        {
            get
            {
                return mEsPideComentario;
            }
            set
            {
                mEsPideComentario = value;
            }
        }

        public Boolean EsPidePeso
        {
            get
            {
                return mEsPidePeso;
            }
            set
            {
                mEsPidePeso = value;
            }
        }

        public Boolean EsPidePrecio
        {
            get
            {
                return mEsPidePrecio;
            }
            set
            {
                mEsPidePrecio = value;
            }
        }

        public Boolean EsPideTipoProducto
        {
            get
            {
                return mEsPideTipoProducto;
            }
            set
            {
                mEsPideTipoProducto = value;
            }
        }

        public Boolean EsUsoInterno
        {
            get
            {
                return mEsUsoInterno;
            }
            set
            {
                mEsUsoInterno = value;
            }
        }

        public Boolean EsActivo
        {
            get
            {
                return mEsActivo;
            }
            set
            {
                mEsActivo = value;
            }
        }

        public Boolean EsTroquelado
        {
            get
            {
                return mEsTroquelado;
            }
            set
            {
                mEsTroquelado = value;
            }
        }

        public Boolean EsPideBalanza
        {
            get
            {
                return mEsPideBalanza;
            }
            set
            {
                mEsPideBalanza = value;
            }
        }

        Productos()
        {
        }

        Productos(int ID, int id_TipoProductoGrupo, int id_Marca, int id_UnidadMedida, int id_UnidadEmpaque, int id_TipoProducto, string Descripcion, string Producto_DescripcionLarga, string Producto_LinkWeb, string CodigoAdicional, string CodigoBarras, string CodigoInterno, double CantidadUnidad, double CantidadEmpaque, DateTime FechaCreacion, DateTime FechaUltimaCompra, DateTime FechaUltimaModificacion, DateTime FechaUltimaVenta, double MargenGananciaPrecio1, double MargenGananciaPrecio2, double MargenGananciaPrecio3, double MontoCostoPromedio, double MontoPrecio1, double MontoPrecio2, double MontoPrecio3, double MontoUltimoCosto, double MontoPrecioDivisa, double MontoCostoDivisa, double MedidaAlto, double MedidaAncho, double MedidaLargo, int nDiasGarantia, int MinStock, int MaxStock, string ImagenArchivo, bool esCodigoAlterno, bool esCompuesto, bool esVenderSinStock, bool esMultiplesImpuestos, bool esFavorito, bool esGarantia, bool esImportado, bool esRegulado, bool esInventario, bool esPideComentario, bool esPidePeso, bool esPidePrecio, bool esPideTipoProducto, bool esUsoInterno, bool esActivo, bool esTroquelado, bool esPideBalanza)
        {
            mID = ID;
            mId_TipoProductoGrupo = Id_TipoProductoGrupo;
            mId_Marca = Id_Marca;
            mId_UnidadMedida = Id_UnidadMedida;
            mId_UnidadEmpaque = Id_UnidadEmpaque;
            mId_TipoProducto = Id_TipoProducto;
            mDescripcion = Descripcion;
            mProducto_DescripcionLarga = Producto_DescripcionLarga;
            mProducto_LinkWeb = Producto_LinkWeb;
            mCodigoAdicional = CodigoAdicional;
            mCodigoBarras = CodigoBarras;
            mCodigoInterno = CodigoInterno;
            mCantidadUnidad = CantidadUnidad;
            mCantidadEmpaque = CantidadEmpaque;
            mFechaCreacion = FechaCreacion;
            mFechaUltimaCompra = FechaUltimaCompra;
            mFechaUltimaModificacion = FechaUltimaModificacion;
            mFechaUltimaVenta = FechaUltimaVenta;
            mMargenGananciaPrecio1 = MargenGananciaPrecio1;
            mMargenGananciaPrecio2 = MargenGananciaPrecio2;
            mMargenGananciaPrecio3 = MargenGananciaPrecio3;
            mMontoCostoPromedio = MontoCostoPromedio;
            mMontoPrecio1 = MontoPrecio1;
            mMontoPrecio2 = MontoPrecio2;
            mMontoPrecio3 = MontoPrecio3;
            mMontoUltimoCosto = MontoUltimoCosto;
            mMontoPrecioDivisa = MontoPrecioDivisa;
            mMontoCostoDivisa = MontoCostoDivisa;
            mMedidaAlto = MedidaAlto;
            mMedidaAncho = MedidaAncho;
            mMedidaLargo = MedidaLargo;
            mNDiasGarantia = NDiasGarantia;
            mMinStock = MinStock;
            mMaxStock = MaxStock;
            mImagenArchivo = ImagenArchivo;
            mEsCodigoAlterno = EsCodigoAlterno;
            mEsCompuesto = EsCompuesto;
            mEsVenderSinStock = EsVenderSinStock;
            mEsMultiplesImpuestos = EsMultiplesImpuestos;
            mEsFavorito = EsFavorito;
            mEsGarantia = EsGarantia;
            mEsImportado = EsImportado;
            mEsRegulado = EsRegulado;
            mEsInventario = EsInventario;
            mEsPideComentario = EsPideComentario;
            mEsPidePeso = EsPidePeso;
            mEsPidePrecio = EsPidePrecio;
            mEsPideTipoProducto = EsPideTipoProducto;
            mEsUsoInterno = EsUsoInterno;
            mEsActivo = EsActivo;
            mEsTroquelado = EsTroquelado;
            mEsPideBalanza = EsPideBalanza;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
