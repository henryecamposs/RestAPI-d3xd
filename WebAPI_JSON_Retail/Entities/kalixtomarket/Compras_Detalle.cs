using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Compras_Detalle : ICloneable
    {

        private int mID = 0;
        private int mID_COMPRA = 0;
        private int mID_PRODUCTO = 0;
        private int mID_IMPUESTO = 0;
        private int mID_ALMACEN = 0;
        private int mID_TIPO_UNIDAD = 0;
        private int mID_TIPO_UNIDAD_APLICADA = 0;
        private int mID_MARCA = 0;
        private int mNRO_ITEM = 0;
        private string mREFERENCIA = "";
        private int mCODIGO_PRODUCTO_BUSQUEDA = 0;
        private double mFACTOR_CAMBIO = 0.0;
        private bool mPRODUCTO_IMPORTADO = false;
        private string mMODELO = "";
        private bool mPRODUCTO_EXENTO_IMPUESTO = false;
        private double mFACTOR_UNIDAD = 0.0;
        private string mTIPO_UNIDAD = "";
        private int mDIAS_DE_ENTREGA = 0;
        private double mCANTIDAD = 0.0;
        private double mCANTIDAD_2 = 0.0;
        private double mCANTIDAD_BONIFICADA = 0.0;
        private double mCANTIDAD_BONIFICADA_2 = 0.0;
        private double mTOTAL_CANTIDAD = 0.0;
        private double mCANTIDAD_PENDIENTE = 0.0;
        private double mCOSTO_UNITARIO_BRUTO = 0.0;
        private double mTOTAL_BRUTO = 0.0;
        private double mDESCUENTO_UNITARIO_1 = 0.0;
        private double mPORC_DESCUENTO_UNITARIO_1 = 0.0;
        private double mTOTAL_DESCUENTO_1 = 0.0;
        private double mDESCUENTO_UNITARIO_2 = 0.0;
        private double mPORC_DESCUENTO_UNITARIO_2 = 0.0;
        private double mTOTAL_DESCUENTO_2 = 0.0;
        private double mDESCUENTO_UNITARIO_3 = 0.0;
        private double mPORC_DESCUENTO_UNITARIO_3 = 0.0;
        private double mTOTAL_DESCUENTO_3 = 0.0;
        private double mDESCUENTO_UNITARIO_4 = 0.0;
        private double mPORC_DESCUENTO_UNITARIO_4 = 0.0;
        private double mTOTAL_DESCUENTO_4 = 0.0;
        private double mDESCUENTO_UNITARIO_BONIF = 0.0;
        private double mPORC_DESCUENTO_BONIF = 0.0;
        private double mTOTAL_DESCUENTO_BONIF = 0.0;
        private double mTOTAL_DESCUENTOS = 0.0;
        private double mCOSTO_UNITARIO = 0.0;
        private double mCOSTOS_DESPERDICIO = 0.0;
        private double mPORC_COSTOS_DESPERDICIO = 0.0;
        private double mCOSTOS_MANEJO = 0.0;
        private double mPORC_COSTOS_MANEJO = 0.0;
        private double mCOSTOS_OPERATIVOS = 0.0;
        private double mPORC_COSTOS_OPERATIVOS = 0.0;
        private double mTOTAL_COSTOS_AGREGADOS = 0.0;
        private double mCOSTOS_ADICIONALES = 0.0;
        private double mCOSTO_CALCULADO = 0.0;
        private double mTOTAL_NETO = 0.0;
        private double mTOTAL_IMPUESTO = 0.0;
        private double mPORC_IMPUESTO = 0.0;
        private double mMONTO_IMPUESTO_MUNICIPAL = 0.0;
        private double mMONTO_IMPUESTO_ADICIONAL = 0.0;
        private double mTOTAL = 0.0;
        private double mTOTAL_BASE_IMPONIBLE = 0.0;
        private double mTOTAL_IMPUESTO_FISCAL = 0.0;
        private double mTOTAL_SDCF = 0.0;
        private int mDIAS_GARANTIA = 0;
        private double mFACTOR_CAMBIO_PRECIO = 0.0;
        private double mEXISTENCIA_ACTUAL = 0.0;
        private double mEXISTENCIA_ACTUAL_2 = 0.0;
        private double mCANTIDAD_LIBERADA = 0.0;
        private double mCANTIDAD_2_LIBERADA = 0.0;
        private double mRETENCION_ISRL = 0.0;
        private double mPORC_RETENCION_ISRL = 0.0;
        private double mPORC_COSTOS_ADICIONALES = 0.0;
        private double mCANTIDAD_BONIFICADA_PENDIENTE = 0.0;

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

        public int ID_COMPRA
        {
            get
            {
                return mID_COMPRA;
            }
            set
            {
                mID_COMPRA = value;
            }
        }

        public int ID_PRODUCTO
        {
            get
            {
                return mID_PRODUCTO;
            }
            set
            {
                mID_PRODUCTO = value;
            }
        }

        public int ID_IMPUESTO
        {
            get
            {
                return mID_IMPUESTO;
            }
            set
            {
                mID_IMPUESTO = value;
            }
        }

        public int ID_ALMACEN
        {
            get
            {
                return mID_ALMACEN;
            }
            set
            {
                mID_ALMACEN = value;
            }
        }

        public int ID_TIPO_UNIDAD
        {
            get
            {
                return mID_TIPO_UNIDAD;
            }
            set
            {
                mID_TIPO_UNIDAD = value;
            }
        }

        public int ID_TIPO_UNIDAD_APLICADA
        {
            get
            {
                return mID_TIPO_UNIDAD_APLICADA;
            }
            set
            {
                mID_TIPO_UNIDAD_APLICADA = value;
            }
        }

        public int ID_MARCA
        {
            get
            {
                return mID_MARCA;
            }
            set
            {
                mID_MARCA = value;
            }
        }

        public int NRO_ITEM
        {
            get
            {
                return mNRO_ITEM;
            }
            set
            {
                mNRO_ITEM = value;
            }
        }

        public string REFERENCIA
        {
            get
            {
                return mREFERENCIA;
            }
            set
            {
                mREFERENCIA = value;
            }
        }

        public int CODIGO_PRODUCTO_BUSQUEDA
        {
            get
            {
                return mCODIGO_PRODUCTO_BUSQUEDA;
            }
            set
            {
                mCODIGO_PRODUCTO_BUSQUEDA = value;
            }
        }

        public Double FACTOR_CAMBIO
        {
            get
            {
                return mFACTOR_CAMBIO;
            }
            set
            {
                mFACTOR_CAMBIO = value;
            }
        }

        public Boolean PRODUCTO_IMPORTADO
        {
            get
            {
                return mPRODUCTO_IMPORTADO;
            }
            set
            {
                mPRODUCTO_IMPORTADO = value;
            }
        }

        public string MODELO
        {
            get
            {
                return mMODELO;
            }
            set
            {
                mMODELO = value;
            }
        }

        public Boolean PRODUCTO_EXENTO_IMPUESTO
        {
            get
            {
                return mPRODUCTO_EXENTO_IMPUESTO;
            }
            set
            {
                mPRODUCTO_EXENTO_IMPUESTO = value;
            }
        }

        public Double FACTOR_UNIDAD
        {
            get
            {
                return mFACTOR_UNIDAD;
            }
            set
            {
                mFACTOR_UNIDAD = value;
            }
        }

        public string TIPO_UNIDAD
        {
            get
            {
                return mTIPO_UNIDAD;
            }
            set
            {
                mTIPO_UNIDAD = value;
            }
        }

        public int DIAS_DE_ENTREGA
        {
            get
            {
                return mDIAS_DE_ENTREGA;
            }
            set
            {
                mDIAS_DE_ENTREGA = value;
            }
        }

        public Double CANTIDAD
        {
            get
            {
                return mCANTIDAD;
            }
            set
            {
                mCANTIDAD = value;
            }
        }

        public Double CANTIDAD_2
        {
            get
            {
                return mCANTIDAD_2;
            }
            set
            {
                mCANTIDAD_2 = value;
            }
        }

        public Double CANTIDAD_BONIFICADA
        {
            get
            {
                return mCANTIDAD_BONIFICADA;
            }
            set
            {
                mCANTIDAD_BONIFICADA = value;
            }
        }

        public Double CANTIDAD_BONIFICADA_2
        {
            get
            {
                return mCANTIDAD_BONIFICADA_2;
            }
            set
            {
                mCANTIDAD_BONIFICADA_2 = value;
            }
        }

        public Double TOTAL_CANTIDAD
        {
            get
            {
                return mTOTAL_CANTIDAD;
            }
            set
            {
                mTOTAL_CANTIDAD = value;
            }
        }

        public Double CANTIDAD_PENDIENTE
        {
            get
            {
                return mCANTIDAD_PENDIENTE;
            }
            set
            {
                mCANTIDAD_PENDIENTE = value;
            }
        }

        public Double COSTO_UNITARIO_BRUTO
        {
            get
            {
                return mCOSTO_UNITARIO_BRUTO;
            }
            set
            {
                mCOSTO_UNITARIO_BRUTO = value;
            }
        }

        public Double TOTAL_BRUTO
        {
            get
            {
                return mTOTAL_BRUTO;
            }
            set
            {
                mTOTAL_BRUTO = value;
            }
        }

        public Double DESCUENTO_UNITARIO_1
        {
            get
            {
                return mDESCUENTO_UNITARIO_1;
            }
            set
            {
                mDESCUENTO_UNITARIO_1 = value;
            }
        }

        public Double PORC_DESCUENTO_UNITARIO_1
        {
            get
            {
                return mPORC_DESCUENTO_UNITARIO_1;
            }
            set
            {
                mPORC_DESCUENTO_UNITARIO_1 = value;
            }
        }

        public Double TOTAL_DESCUENTO_1
        {
            get
            {
                return mTOTAL_DESCUENTO_1;
            }
            set
            {
                mTOTAL_DESCUENTO_1 = value;
            }
        }

        public Double DESCUENTO_UNITARIO_2
        {
            get
            {
                return mDESCUENTO_UNITARIO_2;
            }
            set
            {
                mDESCUENTO_UNITARIO_2 = value;
            }
        }

        public Double PORC_DESCUENTO_UNITARIO_2
        {
            get
            {
                return mPORC_DESCUENTO_UNITARIO_2;
            }
            set
            {
                mPORC_DESCUENTO_UNITARIO_2 = value;
            }
        }

        public Double TOTAL_DESCUENTO_2
        {
            get
            {
                return mTOTAL_DESCUENTO_2;
            }
            set
            {
                mTOTAL_DESCUENTO_2 = value;
            }
        }

        public Double DESCUENTO_UNITARIO_3
        {
            get
            {
                return mDESCUENTO_UNITARIO_3;
            }
            set
            {
                mDESCUENTO_UNITARIO_3 = value;
            }
        }

        public Double PORC_DESCUENTO_UNITARIO_3
        {
            get
            {
                return mPORC_DESCUENTO_UNITARIO_3;
            }
            set
            {
                mPORC_DESCUENTO_UNITARIO_3 = value;
            }
        }

        public Double TOTAL_DESCUENTO_3
        {
            get
            {
                return mTOTAL_DESCUENTO_3;
            }
            set
            {
                mTOTAL_DESCUENTO_3 = value;
            }
        }

        public Double DESCUENTO_UNITARIO_4
        {
            get
            {
                return mDESCUENTO_UNITARIO_4;
            }
            set
            {
                mDESCUENTO_UNITARIO_4 = value;
            }
        }

        public Double PORC_DESCUENTO_UNITARIO_4
        {
            get
            {
                return mPORC_DESCUENTO_UNITARIO_4;
            }
            set
            {
                mPORC_DESCUENTO_UNITARIO_4 = value;
            }
        }

        public Double TOTAL_DESCUENTO_4
        {
            get
            {
                return mTOTAL_DESCUENTO_4;
            }
            set
            {
                mTOTAL_DESCUENTO_4 = value;
            }
        }

        public Double DESCUENTO_UNITARIO_BONIF
        {
            get
            {
                return mDESCUENTO_UNITARIO_BONIF;
            }
            set
            {
                mDESCUENTO_UNITARIO_BONIF = value;
            }
        }

        public Double PORC_DESCUENTO_BONIF
        {
            get
            {
                return mPORC_DESCUENTO_BONIF;
            }
            set
            {
                mPORC_DESCUENTO_BONIF = value;
            }
        }

        public Double TOTAL_DESCUENTO_BONIF
        {
            get
            {
                return mTOTAL_DESCUENTO_BONIF;
            }
            set
            {
                mTOTAL_DESCUENTO_BONIF = value;
            }
        }

        public Double TOTAL_DESCUENTOS
        {
            get
            {
                return mTOTAL_DESCUENTOS;
            }
            set
            {
                mTOTAL_DESCUENTOS = value;
            }
        }

        public Double COSTO_UNITARIO
        {
            get
            {
                return mCOSTO_UNITARIO;
            }
            set
            {
                mCOSTO_UNITARIO = value;
            }
        }

        public Double COSTOS_DESPERDICIO
        {
            get
            {
                return mCOSTOS_DESPERDICIO;
            }
            set
            {
                mCOSTOS_DESPERDICIO = value;
            }
        }

        public Double PORC_COSTOS_DESPERDICIO
        {
            get
            {
                return mPORC_COSTOS_DESPERDICIO;
            }
            set
            {
                mPORC_COSTOS_DESPERDICIO = value;
            }
        }

        public Double COSTOS_MANEJO
        {
            get
            {
                return mCOSTOS_MANEJO;
            }
            set
            {
                mCOSTOS_MANEJO = value;
            }
        }

        public Double PORC_COSTOS_MANEJO
        {
            get
            {
                return mPORC_COSTOS_MANEJO;
            }
            set
            {
                mPORC_COSTOS_MANEJO = value;
            }
        }

        public Double COSTOS_OPERATIVOS
        {
            get
            {
                return mCOSTOS_OPERATIVOS;
            }
            set
            {
                mCOSTOS_OPERATIVOS = value;
            }
        }

        public Double PORC_COSTOS_OPERATIVOS
        {
            get
            {
                return mPORC_COSTOS_OPERATIVOS;
            }
            set
            {
                mPORC_COSTOS_OPERATIVOS = value;
            }
        }

        public Double TOTAL_COSTOS_AGREGADOS
        {
            get
            {
                return mTOTAL_COSTOS_AGREGADOS;
            }
            set
            {
                mTOTAL_COSTOS_AGREGADOS = value;
            }
        }

        public Double COSTOS_ADICIONALES
        {
            get
            {
                return mCOSTOS_ADICIONALES;
            }
            set
            {
                mCOSTOS_ADICIONALES = value;
            }
        }

        public Double COSTO_CALCULADO
        {
            get
            {
                return mCOSTO_CALCULADO;
            }
            set
            {
                mCOSTO_CALCULADO = value;
            }
        }

        public Double TOTAL_NETO
        {
            get
            {
                return mTOTAL_NETO;
            }
            set
            {
                mTOTAL_NETO = value;
            }
        }

        public Double TOTAL_IMPUESTO
        {
            get
            {
                return mTOTAL_IMPUESTO;
            }
            set
            {
                mTOTAL_IMPUESTO = value;
            }
        }

        public Double PORC_IMPUESTO
        {
            get
            {
                return mPORC_IMPUESTO;
            }
            set
            {
                mPORC_IMPUESTO = value;
            }
        }

        public Double MONTO_IMPUESTO_MUNICIPAL
        {
            get
            {
                return mMONTO_IMPUESTO_MUNICIPAL;
            }
            set
            {
                mMONTO_IMPUESTO_MUNICIPAL = value;
            }
        }

        public Double MONTO_IMPUESTO_ADICIONAL
        {
            get
            {
                return mMONTO_IMPUESTO_ADICIONAL;
            }
            set
            {
                mMONTO_IMPUESTO_ADICIONAL = value;
            }
        }

        public Double TOTAL
        {
            get
            {
                return mTOTAL;
            }
            set
            {
                mTOTAL = value;
            }
        }

        public Double TOTAL_BASE_IMPONIBLE
        {
            get
            {
                return mTOTAL_BASE_IMPONIBLE;
            }
            set
            {
                mTOTAL_BASE_IMPONIBLE = value;
            }
        }

        public Double TOTAL_IMPUESTO_FISCAL
        {
            get
            {
                return mTOTAL_IMPUESTO_FISCAL;
            }
            set
            {
                mTOTAL_IMPUESTO_FISCAL = value;
            }
        }

        public Double TOTAL_SDCF
        {
            get
            {
                return mTOTAL_SDCF;
            }
            set
            {
                mTOTAL_SDCF = value;
            }
        }

        public int DIAS_GARANTIA
        {
            get
            {
                return mDIAS_GARANTIA;
            }
            set
            {
                mDIAS_GARANTIA = value;
            }
        }

        public Double FACTOR_CAMBIO_PRECIO
        {
            get
            {
                return mFACTOR_CAMBIO_PRECIO;
            }
            set
            {
                mFACTOR_CAMBIO_PRECIO = value;
            }
        }

        public Double EXISTENCIA_ACTUAL
        {
            get
            {
                return mEXISTENCIA_ACTUAL;
            }
            set
            {
                mEXISTENCIA_ACTUAL = value;
            }
        }

        public Double EXISTENCIA_ACTUAL_2
        {
            get
            {
                return mEXISTENCIA_ACTUAL_2;
            }
            set
            {
                mEXISTENCIA_ACTUAL_2 = value;
            }
        }

        public Double CANTIDAD_LIBERADA
        {
            get
            {
                return mCANTIDAD_LIBERADA;
            }
            set
            {
                mCANTIDAD_LIBERADA = value;
            }
        }

        public Double CANTIDAD_2_LIBERADA
        {
            get
            {
                return mCANTIDAD_2_LIBERADA;
            }
            set
            {
                mCANTIDAD_2_LIBERADA = value;
            }
        }

        public Double RETENCION_ISRL
        {
            get
            {
                return mRETENCION_ISRL;
            }
            set
            {
                mRETENCION_ISRL = value;
            }
        }

        public Double PORC_RETENCION_ISRL
        {
            get
            {
                return mPORC_RETENCION_ISRL;
            }
            set
            {
                mPORC_RETENCION_ISRL = value;
            }
        }

        public Double PORC_COSTOS_ADICIONALES
        {
            get
            {
                return mPORC_COSTOS_ADICIONALES;
            }
            set
            {
                mPORC_COSTOS_ADICIONALES = value;
            }
        }

        public Double CANTIDAD_BONIFICADA_PENDIENTE
        {
            get
            {
                return mCANTIDAD_BONIFICADA_PENDIENTE;
            }
            set
            {
                mCANTIDAD_BONIFICADA_PENDIENTE = value;
            }
        }

        Compras_Detalle()
        {
        }

        Compras_Detalle(int ID, int ID_COMPRA, int ID_PRODUCTO, int ID_IMPUESTO, int ID_ALMACEN, int ID_TIPO_UNIDAD, int ID_TIPO_UNIDAD_APLICADA, int ID_MARCA, int NRO_ITEM, string REFERENCIA, int CODIGO_PRODUCTO_BUSQUEDA, double FACTOR_CAMBIO, bool PRODUCTO_IMPORTADO, string MODELO, bool PRODUCTO_EXENTO_IMPUESTO, double FACTOR_UNIDAD, string TIPO_UNIDAD, int DIAS_DE_ENTREGA, double CANTIDAD, double CANTIDAD_2, double CANTIDAD_BONIFICADA, double CANTIDAD_BONIFICADA_2, double TOTAL_CANTIDAD, double CANTIDAD_PENDIENTE, double COSTO_UNITARIO_BRUTO, double TOTAL_BRUTO, double DESCUENTO_UNITARIO_1, double PORC_DESCUENTO_UNITARIO_1, double TOTAL_DESCUENTO_1, double DESCUENTO_UNITARIO_2, double PORC_DESCUENTO_UNITARIO_2, double TOTAL_DESCUENTO_2, double DESCUENTO_UNITARIO_3, double PORC_DESCUENTO_UNITARIO_3, double TOTAL_DESCUENTO_3, double DESCUENTO_UNITARIO_4, double PORC_DESCUENTO_UNITARIO_4, double TOTAL_DESCUENTO_4, double DESCUENTO_UNITARIO_BONIF, double PORC_DESCUENTO_BONIF, double TOTAL_DESCUENTO_BONIF, double TOTAL_DESCUENTOS, double COSTO_UNITARIO, double COSTOS_DESPERDICIO, double PORC_COSTOS_DESPERDICIO, double COSTOS_MANEJO, double PORC_COSTOS_MANEJO, double COSTOS_OPERATIVOS, double PORC_COSTOS_OPERATIVOS, double TOTAL_COSTOS_AGREGADOS, double COSTOS_ADICIONALES, double COSTO_CALCULADO, double TOTAL_NETO, double TOTAL_IMPUESTO, double PORC_IMPUESTO, double MONTO_IMPUESTO_MUNICIPAL, double MONTO_IMPUESTO_ADICIONAL, double TOTAL, double TOTAL_BASE_IMPONIBLE, double TOTAL_IMPUESTO_FISCAL, double TOTAL_SDCF, int DIAS_GARANTIA, double FACTOR_CAMBIO_PRECIO, double EXISTENCIA_ACTUAL, double EXISTENCIA_ACTUAL_2, double CANTIDAD_LIBERADA, double CANTIDAD_2_LIBERADA, double RETENCION_ISRL, double PORC_RETENCION_ISRL, double PORC_COSTOS_ADICIONALES, double CANTIDAD_BONIFICADA_PENDIENTE)
        {
            mID = ID;
            mID_COMPRA = ID_COMPRA;
            mID_PRODUCTO = ID_PRODUCTO;
            mID_IMPUESTO = ID_IMPUESTO;
            mID_ALMACEN = ID_ALMACEN;
            mID_TIPO_UNIDAD = ID_TIPO_UNIDAD;
            mID_TIPO_UNIDAD_APLICADA = ID_TIPO_UNIDAD_APLICADA;
            mID_MARCA = ID_MARCA;
            mNRO_ITEM = NRO_ITEM;
            mREFERENCIA = REFERENCIA;
            mCODIGO_PRODUCTO_BUSQUEDA = CODIGO_PRODUCTO_BUSQUEDA;
            mFACTOR_CAMBIO = FACTOR_CAMBIO;
            mPRODUCTO_IMPORTADO = PRODUCTO_IMPORTADO;
            mMODELO = MODELO;
            mPRODUCTO_EXENTO_IMPUESTO = PRODUCTO_EXENTO_IMPUESTO;
            mFACTOR_UNIDAD = FACTOR_UNIDAD;
            mTIPO_UNIDAD = TIPO_UNIDAD;
            mDIAS_DE_ENTREGA = DIAS_DE_ENTREGA;
            mCANTIDAD = CANTIDAD;
            mCANTIDAD_2 = CANTIDAD_2;
            mCANTIDAD_BONIFICADA = CANTIDAD_BONIFICADA;
            mCANTIDAD_BONIFICADA_2 = CANTIDAD_BONIFICADA_2;
            mTOTAL_CANTIDAD = TOTAL_CANTIDAD;
            mCANTIDAD_PENDIENTE = CANTIDAD_PENDIENTE;
            mCOSTO_UNITARIO_BRUTO = COSTO_UNITARIO_BRUTO;
            mTOTAL_BRUTO = TOTAL_BRUTO;
            mDESCUENTO_UNITARIO_1 = DESCUENTO_UNITARIO_1;
            mPORC_DESCUENTO_UNITARIO_1 = PORC_DESCUENTO_UNITARIO_1;
            mTOTAL_DESCUENTO_1 = TOTAL_DESCUENTO_1;
            mDESCUENTO_UNITARIO_2 = DESCUENTO_UNITARIO_2;
            mPORC_DESCUENTO_UNITARIO_2 = PORC_DESCUENTO_UNITARIO_2;
            mTOTAL_DESCUENTO_2 = TOTAL_DESCUENTO_2;
            mDESCUENTO_UNITARIO_3 = DESCUENTO_UNITARIO_3;
            mPORC_DESCUENTO_UNITARIO_3 = PORC_DESCUENTO_UNITARIO_3;
            mTOTAL_DESCUENTO_3 = TOTAL_DESCUENTO_3;
            mDESCUENTO_UNITARIO_4 = DESCUENTO_UNITARIO_4;
            mPORC_DESCUENTO_UNITARIO_4 = PORC_DESCUENTO_UNITARIO_4;
            mTOTAL_DESCUENTO_4 = TOTAL_DESCUENTO_4;
            mDESCUENTO_UNITARIO_BONIF = DESCUENTO_UNITARIO_BONIF;
            mPORC_DESCUENTO_BONIF = PORC_DESCUENTO_BONIF;
            mTOTAL_DESCUENTO_BONIF = TOTAL_DESCUENTO_BONIF;
            mTOTAL_DESCUENTOS = TOTAL_DESCUENTOS;
            mCOSTO_UNITARIO = COSTO_UNITARIO;
            mCOSTOS_DESPERDICIO = COSTOS_DESPERDICIO;
            mPORC_COSTOS_DESPERDICIO = PORC_COSTOS_DESPERDICIO;
            mCOSTOS_MANEJO = COSTOS_MANEJO;
            mPORC_COSTOS_MANEJO = PORC_COSTOS_MANEJO;
            mCOSTOS_OPERATIVOS = COSTOS_OPERATIVOS;
            mPORC_COSTOS_OPERATIVOS = PORC_COSTOS_OPERATIVOS;
            mTOTAL_COSTOS_AGREGADOS = TOTAL_COSTOS_AGREGADOS;
            mCOSTOS_ADICIONALES = COSTOS_ADICIONALES;
            mCOSTO_CALCULADO = COSTO_CALCULADO;
            mTOTAL_NETO = TOTAL_NETO;
            mTOTAL_IMPUESTO = TOTAL_IMPUESTO;
            mPORC_IMPUESTO = PORC_IMPUESTO;
            mMONTO_IMPUESTO_MUNICIPAL = MONTO_IMPUESTO_MUNICIPAL;
            mMONTO_IMPUESTO_ADICIONAL = MONTO_IMPUESTO_ADICIONAL;
            mTOTAL = TOTAL;
            mTOTAL_BASE_IMPONIBLE = TOTAL_BASE_IMPONIBLE;
            mTOTAL_IMPUESTO_FISCAL = TOTAL_IMPUESTO_FISCAL;
            mTOTAL_SDCF = TOTAL_SDCF;
            mDIAS_GARANTIA = DIAS_GARANTIA;
            mFACTOR_CAMBIO_PRECIO = FACTOR_CAMBIO_PRECIO;
            mEXISTENCIA_ACTUAL = EXISTENCIA_ACTUAL;
            mEXISTENCIA_ACTUAL_2 = EXISTENCIA_ACTUAL_2;
            mCANTIDAD_LIBERADA = CANTIDAD_LIBERADA;
            mCANTIDAD_2_LIBERADA = CANTIDAD_2_LIBERADA;
            mRETENCION_ISRL = RETENCION_ISRL;
            mPORC_RETENCION_ISRL = PORC_RETENCION_ISRL;
            mPORC_COSTOS_ADICIONALES = PORC_COSTOS_ADICIONALES;
            mCANTIDAD_BONIFICADA_PENDIENTE = CANTIDAD_BONIFICADA_PENDIENTE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
