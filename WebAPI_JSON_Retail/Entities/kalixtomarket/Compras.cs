using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Compras : ICloneable
    {

        private int mID = 0;
        private int mID_PROVEEDOR = 0;
        private int mID_TIPOMONEDA = 0;
        private int mID_ALMACEN = 0;
        private int mID_USUARIO = 0;
        private int mID_ESTACIONES_SESION = 0;
        private string mDOCUMENTO_REF_OTROS_CARGOS = "";
        private string mDOCUMENTO_REFERENCIA_ADUANA = "";
        private string mDOCUMENTO = "";
        private int mTIPO_DOCUMENTO = 0;
        private string mNUMERO_CONTROL_FISCAL = "";
        private string mSERIAL_IMPRESORA_FISCAL = "";
        private string mNOMBRE_COMPRADOR = "";
        private string mDENOMINACION_FISCAL = "";
        private double mFACTOR_CAMBIO = 0.0;
        private string mREFERENCIA_DOCUMENTO = "";
        private string mHORA_EMISION = "";
        private int mDIAS_VENCIMIENTO = 0;
        private double mDESCUENTO_1 = 0.0;
        private double mDESCUENTO_2 = 0.0;
        private double mPORC_DESCUENTO_1 = 0.0;
        private double mPORC_DESCUENTO_2 = 0.0;
        private double mFLETE = 0.0;
        private double mPORC_FLETE = 0.0;
        private double mCARGOS_ADICIONALES = 0.0;
        private double mTOTAL_DESCUENTOS_LINEAS = 0.0;
        private double mTOTAL_OTROS_COSTOS_LINEAS = 0.0;
        private double mTOTAL_SDCF_LINEAS = 0.0;
        private double mTOTAL_NETO_LINEAS = 0.0;
        private double mTOTAL_IMPUESTO_LINEAS = 0.0;
        private double mTOTAL_DESCUENTOS = 0.0;
        private double mTOTAL_CARGOS = 0.0;
        private double mTOTAL_SDCF = 0.0;
        private double mTOTAL_BASE_IMPONIBLE = 0.0;
        private double mTOTAL_IMPUESTO = 0.0;
        private double mTOTAL_OPERACION = 0.0;
        private double mTOTAL_IMPUESTO_MUNICIPAL = 0.0;
        private double mTOTAL_IMPUESTO_ADICIONAL = 0.0;
        private double mTOTAL_RETENCION_ISLR = 0.0;
        private double mTOTAL_RETENCION_IVA = 0.0;
        private double mTOTAL_CANCELADO = 0.0;
        private double mTOTAL_COSTOS_ASOCIADOS = 0.0;
        private double mTOTAL_NETO = 0.0;
        private double mTOTAL_BASE_IMPONIBLE_LINEAS = 0.0;
        private double mTOTAL_BRUTO_LINEAS = 0.0;
        private double mTOTAL_LINEAS = 0.0;
        private double mTOTAL_IMPUESTO_AL_LICOR = 0.0;
        private double mTOTAL_MONTO_SUJETO_PRORRATEO = 0.0;
        private int mRENGLONES_PRODUCTOS_IMPORTADOS = 0;
        private int mRENGLONES_PRODUCTOS_NACIONALES = 0;
        private double mPORC_RETENCION_IVA = 0.0;
        private double mANTICIPO_APLICADO = 0.0;
        private double mNOTA_CREDITO_APLICADA = 0.0;
        private double mCONTADO = 0.0;
        private double mCREDITO = 0.0;
        private int mCORRELATIVO_CXP = 0;
        private int mCONDICIONES_PAGO = 0;
        private double mSALDO_ABONADO = 0.0;
        private int mCLASIFICACION_CODIGO = 0;
        private bool mPENDIENTE = false;
        private bool mTEMPORAL = false;
        private DateTime mFECHA_VENCIMIENTO = new DateTime(2000, 01, 01);
        private DateTime mFECHA_ENTREGA = new DateTime(2000, 01, 01);
        private DateTime mFECHA_REGISTRO = new DateTime(2000, 01, 01);
        private DateTime mFECHA_EMISION = new DateTime(2000, 01, 01);
        private DateTime mFECHA_HORA_REGISTRO = new DateTime(2000, 01, 01);
        private string mMOTIVO_DEVOLUCION = "";
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

        public int ID_PROVEEDOR
        {
            get
            {
                return mID_PROVEEDOR;
            }
            set
            {
                mID_PROVEEDOR = value;
            }
        }

        public int ID_TIPOMONEDA
        {
            get
            {
                return mID_TIPOMONEDA;
            }
            set
            {
                mID_TIPOMONEDA = value;
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

        public int ID_USUARIO
        {
            get
            {
                return mID_USUARIO;
            }
            set
            {
                mID_USUARIO = value;
            }
        }

        public int ID_ESTACIONES_SESION
        {
            get
            {
                return mID_ESTACIONES_SESION;
            }
            set
            {
                mID_ESTACIONES_SESION = value;
            }
        }

        public string DOCUMENTO_REF_OTROS_CARGOS
        {
            get
            {
                return mDOCUMENTO_REF_OTROS_CARGOS;
            }
            set
            {
                mDOCUMENTO_REF_OTROS_CARGOS = value;
            }
        }

        public string DOCUMENTO_REFERENCIA_ADUANA
        {
            get
            {
                return mDOCUMENTO_REFERENCIA_ADUANA;
            }
            set
            {
                mDOCUMENTO_REFERENCIA_ADUANA = value;
            }
        }

        public string DOCUMENTO
        {
            get
            {
                return mDOCUMENTO;
            }
            set
            {
                mDOCUMENTO = value;
            }
        }

        public int TIPO_DOCUMENTO
        {
            get
            {
                return mTIPO_DOCUMENTO;
            }
            set
            {
                mTIPO_DOCUMENTO = value;
            }
        }

        public string NUMERO_CONTROL_FISCAL
        {
            get
            {
                return mNUMERO_CONTROL_FISCAL;
            }
            set
            {
                mNUMERO_CONTROL_FISCAL = value;
            }
        }

        public string SERIAL_IMPRESORA_FISCAL
        {
            get
            {
                return mSERIAL_IMPRESORA_FISCAL;
            }
            set
            {
                mSERIAL_IMPRESORA_FISCAL = value;
            }
        }

        public string NOMBRE_COMPRADOR
        {
            get
            {
                return mNOMBRE_COMPRADOR;
            }
            set
            {
                mNOMBRE_COMPRADOR = value;
            }
        }

        public string DENOMINACION_FISCAL
        {
            get
            {
                return mDENOMINACION_FISCAL;
            }
            set
            {
                mDENOMINACION_FISCAL = value;
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

        public string REFERENCIA_DOCUMENTO
        {
            get
            {
                return mREFERENCIA_DOCUMENTO;
            }
            set
            {
                mREFERENCIA_DOCUMENTO = value;
            }
        }

        public string HORA_EMISION
        {
            get
            {
                return mHORA_EMISION;
            }
            set
            {
                mHORA_EMISION = value;
            }
        }

        public int DIAS_VENCIMIENTO
        {
            get
            {
                return mDIAS_VENCIMIENTO;
            }
            set
            {
                mDIAS_VENCIMIENTO = value;
            }
        }

        public Double DESCUENTO_1
        {
            get
            {
                return mDESCUENTO_1;
            }
            set
            {
                mDESCUENTO_1 = value;
            }
        }

        public Double DESCUENTO_2
        {
            get
            {
                return mDESCUENTO_2;
            }
            set
            {
                mDESCUENTO_2 = value;
            }
        }

        public Double PORC_DESCUENTO_1
        {
            get
            {
                return mPORC_DESCUENTO_1;
            }
            set
            {
                mPORC_DESCUENTO_1 = value;
            }
        }

        public Double PORC_DESCUENTO_2
        {
            get
            {
                return mPORC_DESCUENTO_2;
            }
            set
            {
                mPORC_DESCUENTO_2 = value;
            }
        }

        public Double FLETE
        {
            get
            {
                return mFLETE;
            }
            set
            {
                mFLETE = value;
            }
        }

        public Double PORC_FLETE
        {
            get
            {
                return mPORC_FLETE;
            }
            set
            {
                mPORC_FLETE = value;
            }
        }

        public Double CARGOS_ADICIONALES
        {
            get
            {
                return mCARGOS_ADICIONALES;
            }
            set
            {
                mCARGOS_ADICIONALES = value;
            }
        }

        public Double TOTAL_DESCUENTOS_LINEAS
        {
            get
            {
                return mTOTAL_DESCUENTOS_LINEAS;
            }
            set
            {
                mTOTAL_DESCUENTOS_LINEAS = value;
            }
        }

        public Double TOTAL_OTROS_COSTOS_LINEAS
        {
            get
            {
                return mTOTAL_OTROS_COSTOS_LINEAS;
            }
            set
            {
                mTOTAL_OTROS_COSTOS_LINEAS = value;
            }
        }

        public Double TOTAL_SDCF_LINEAS
        {
            get
            {
                return mTOTAL_SDCF_LINEAS;
            }
            set
            {
                mTOTAL_SDCF_LINEAS = value;
            }
        }

        public Double TOTAL_NETO_LINEAS
        {
            get
            {
                return mTOTAL_NETO_LINEAS;
            }
            set
            {
                mTOTAL_NETO_LINEAS = value;
            }
        }

        public Double TOTAL_IMPUESTO_LINEAS
        {
            get
            {
                return mTOTAL_IMPUESTO_LINEAS;
            }
            set
            {
                mTOTAL_IMPUESTO_LINEAS = value;
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

        public Double TOTAL_CARGOS
        {
            get
            {
                return mTOTAL_CARGOS;
            }
            set
            {
                mTOTAL_CARGOS = value;
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

        public Double TOTAL_OPERACION
        {
            get
            {
                return mTOTAL_OPERACION;
            }
            set
            {
                mTOTAL_OPERACION = value;
            }
        }

        public Double TOTAL_IMPUESTO_MUNICIPAL
        {
            get
            {
                return mTOTAL_IMPUESTO_MUNICIPAL;
            }
            set
            {
                mTOTAL_IMPUESTO_MUNICIPAL = value;
            }
        }

        public Double TOTAL_IMPUESTO_ADICIONAL
        {
            get
            {
                return mTOTAL_IMPUESTO_ADICIONAL;
            }
            set
            {
                mTOTAL_IMPUESTO_ADICIONAL = value;
            }
        }

        public Double TOTAL_RETENCION_ISLR
        {
            get
            {
                return mTOTAL_RETENCION_ISLR;
            }
            set
            {
                mTOTAL_RETENCION_ISLR = value;
            }
        }

        public Double TOTAL_RETENCION_IVA
        {
            get
            {
                return mTOTAL_RETENCION_IVA;
            }
            set
            {
                mTOTAL_RETENCION_IVA = value;
            }
        }

        public Double TOTAL_CANCELADO
        {
            get
            {
                return mTOTAL_CANCELADO;
            }
            set
            {
                mTOTAL_CANCELADO = value;
            }
        }

        public Double TOTAL_COSTOS_ASOCIADOS
        {
            get
            {
                return mTOTAL_COSTOS_ASOCIADOS;
            }
            set
            {
                mTOTAL_COSTOS_ASOCIADOS = value;
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

        public Double TOTAL_BASE_IMPONIBLE_LINEAS
        {
            get
            {
                return mTOTAL_BASE_IMPONIBLE_LINEAS;
            }
            set
            {
                mTOTAL_BASE_IMPONIBLE_LINEAS = value;
            }
        }

        public Double TOTAL_BRUTO_LINEAS
        {
            get
            {
                return mTOTAL_BRUTO_LINEAS;
            }
            set
            {
                mTOTAL_BRUTO_LINEAS = value;
            }
        }

        public Double TOTAL_LINEAS
        {
            get
            {
                return mTOTAL_LINEAS;
            }
            set
            {
                mTOTAL_LINEAS = value;
            }
        }

        public Double TOTAL_IMPUESTO_AL_LICOR
        {
            get
            {
                return mTOTAL_IMPUESTO_AL_LICOR;
            }
            set
            {
                mTOTAL_IMPUESTO_AL_LICOR = value;
            }
        }

        public Double TOTAL_MONTO_SUJETO_PRORRATEO
        {
            get
            {
                return mTOTAL_MONTO_SUJETO_PRORRATEO;
            }
            set
            {
                mTOTAL_MONTO_SUJETO_PRORRATEO = value;
            }
        }

        public int RENGLONES_PRODUCTOS_IMPORTADOS
        {
            get
            {
                return mRENGLONES_PRODUCTOS_IMPORTADOS;
            }
            set
            {
                mRENGLONES_PRODUCTOS_IMPORTADOS = value;
            }
        }

        public int RENGLONES_PRODUCTOS_NACIONALES
        {
            get
            {
                return mRENGLONES_PRODUCTOS_NACIONALES;
            }
            set
            {
                mRENGLONES_PRODUCTOS_NACIONALES = value;
            }
        }

        public Double PORC_RETENCION_IVA
        {
            get
            {
                return mPORC_RETENCION_IVA;
            }
            set
            {
                mPORC_RETENCION_IVA = value;
            }
        }

        public Double ANTICIPO_APLICADO
        {
            get
            {
                return mANTICIPO_APLICADO;
            }
            set
            {
                mANTICIPO_APLICADO = value;
            }
        }

        public Double NOTA_CREDITO_APLICADA
        {
            get
            {
                return mNOTA_CREDITO_APLICADA;
            }
            set
            {
                mNOTA_CREDITO_APLICADA = value;
            }
        }

        public Double CONTADO
        {
            get
            {
                return mCONTADO;
            }
            set
            {
                mCONTADO = value;
            }
        }

        public Double CREDITO
        {
            get
            {
                return mCREDITO;
            }
            set
            {
                mCREDITO = value;
            }
        }

        public int CORRELATIVO_CXP
        {
            get
            {
                return mCORRELATIVO_CXP;
            }
            set
            {
                mCORRELATIVO_CXP = value;
            }
        }

        public int CONDICIONES_PAGO
        {
            get
            {
                return mCONDICIONES_PAGO;
            }
            set
            {
                mCONDICIONES_PAGO = value;
            }
        }

        public Double SALDO_ABONADO
        {
            get
            {
                return mSALDO_ABONADO;
            }
            set
            {
                mSALDO_ABONADO = value;
            }
        }

        public int CLASIFICACION_CODIGO
        {
            get
            {
                return mCLASIFICACION_CODIGO;
            }
            set
            {
                mCLASIFICACION_CODIGO = value;
            }
        }

        public Boolean PENDIENTE
        {
            get
            {
                return mPENDIENTE;
            }
            set
            {
                mPENDIENTE = value;
            }
        }

        public Boolean TEMPORAL
        {
            get
            {
                return mTEMPORAL;
            }
            set
            {
                mTEMPORAL = value;
            }
        }

        public DateTime FECHA_VENCIMIENTO
        {
            get
            {
                return mFECHA_VENCIMIENTO;
            }
            set
            {
                mFECHA_VENCIMIENTO = value;
            }
        }

        public DateTime FECHA_ENTREGA
        {
            get
            {
                return mFECHA_ENTREGA;
            }
            set
            {
                mFECHA_ENTREGA = value;
            }
        }

        public DateTime FECHA_REGISTRO
        {
            get
            {
                return mFECHA_REGISTRO;
            }
            set
            {
                mFECHA_REGISTRO = value;
            }
        }

        public DateTime FECHA_EMISION
        {
            get
            {
                return mFECHA_EMISION;
            }
            set
            {
                mFECHA_EMISION = value;
            }
        }

        public DateTime FECHA_HORA_REGISTRO
        {
            get
            {
                return mFECHA_HORA_REGISTRO;
            }
            set
            {
                mFECHA_HORA_REGISTRO = value;
            }
        }

        public string MOTIVO_DEVOLUCION
        {
            get
            {
                return mMOTIVO_DEVOLUCION;
            }
            set
            {
                mMOTIVO_DEVOLUCION = value;
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

        Compras()
        {
        }

        Compras(int ID, int ID_PROVEEDOR, int ID_TIPOMONEDA, int ID_ALMACEN, int ID_USUARIO, int ID_ESTACIONES_SESION, string DOCUMENTO_REF_OTROS_CARGOS, string DOCUMENTO_REFERENCIA_ADUANA, string DOCUMENTO, int TIPO_DOCUMENTO, string NUMERO_CONTROL_FISCAL, string SERIAL_IMPRESORA_FISCAL, string NOMBRE_COMPRADOR, string DENOMINACION_FISCAL, double FACTOR_CAMBIO, string REFERENCIA_DOCUMENTO, string HORA_EMISION, int DIAS_VENCIMIENTO, double DESCUENTO_1, double DESCUENTO_2, double PORC_DESCUENTO_1, double PORC_DESCUENTO_2, double FLETE, double PORC_FLETE, double CARGOS_ADICIONALES, double TOTAL_DESCUENTOS_LINEAS, double TOTAL_OTROS_COSTOS_LINEAS, double TOTAL_SDCF_LINEAS, double TOTAL_NETO_LINEAS, double TOTAL_IMPUESTO_LINEAS, double TOTAL_DESCUENTOS, double TOTAL_CARGOS, double TOTAL_SDCF, double TOTAL_BASE_IMPONIBLE, double TOTAL_IMPUESTO, double TOTAL_OPERACION, double TOTAL_IMPUESTO_MUNICIPAL, double TOTAL_IMPUESTO_ADICIONAL, double TOTAL_RETENCION_ISLR, double TOTAL_RETENCION_IVA, double TOTAL_CANCELADO, double TOTAL_COSTOS_ASOCIADOS, double TOTAL_NETO, double TOTAL_BASE_IMPONIBLE_LINEAS, double TOTAL_BRUTO_LINEAS, double TOTAL_LINEAS, double TOTAL_IMPUESTO_AL_LICOR, double TOTAL_MONTO_SUJETO_PRORRATEO, int RENGLONES_PRODUCTOS_IMPORTADOS, int RENGLONES_PRODUCTOS_NACIONALES, double PORC_RETENCION_IVA, double ANTICIPO_APLICADO, double NOTA_CREDITO_APLICADA, double CONTADO, double CREDITO, int CORRELATIVO_CXP, int CONDICIONES_PAGO, double SALDO_ABONADO, int CLASIFICACION_CODIGO, bool PENDIENTE, bool TEMPORAL, DateTime FECHA_VENCIMIENTO, DateTime FECHA_ENTREGA, DateTime FECHA_REGISTRO, DateTime FECHA_EMISION, DateTime FECHA_HORA_REGISTRO, string MOTIVO_DEVOLUCION, int id_Sucursal)
        {
            mID = ID;
            mID_PROVEEDOR = ID_PROVEEDOR;
            mID_TIPOMONEDA = ID_TIPOMONEDA;
            mID_ALMACEN = ID_ALMACEN;
            mID_USUARIO = ID_USUARIO;
            mID_ESTACIONES_SESION = ID_ESTACIONES_SESION;
            mDOCUMENTO_REF_OTROS_CARGOS = DOCUMENTO_REF_OTROS_CARGOS;
            mDOCUMENTO_REFERENCIA_ADUANA = DOCUMENTO_REFERENCIA_ADUANA;
            mDOCUMENTO = DOCUMENTO;
            mTIPO_DOCUMENTO = TIPO_DOCUMENTO;
            mNUMERO_CONTROL_FISCAL = NUMERO_CONTROL_FISCAL;
            mSERIAL_IMPRESORA_FISCAL = SERIAL_IMPRESORA_FISCAL;
            mNOMBRE_COMPRADOR = NOMBRE_COMPRADOR;
            mDENOMINACION_FISCAL = DENOMINACION_FISCAL;
            mFACTOR_CAMBIO = FACTOR_CAMBIO;
            mREFERENCIA_DOCUMENTO = REFERENCIA_DOCUMENTO;
            mHORA_EMISION = HORA_EMISION;
            mDIAS_VENCIMIENTO = DIAS_VENCIMIENTO;
            mDESCUENTO_1 = DESCUENTO_1;
            mDESCUENTO_2 = DESCUENTO_2;
            mPORC_DESCUENTO_1 = PORC_DESCUENTO_1;
            mPORC_DESCUENTO_2 = PORC_DESCUENTO_2;
            mFLETE = FLETE;
            mPORC_FLETE = PORC_FLETE;
            mCARGOS_ADICIONALES = CARGOS_ADICIONALES;
            mTOTAL_DESCUENTOS_LINEAS = TOTAL_DESCUENTOS_LINEAS;
            mTOTAL_OTROS_COSTOS_LINEAS = TOTAL_OTROS_COSTOS_LINEAS;
            mTOTAL_SDCF_LINEAS = TOTAL_SDCF_LINEAS;
            mTOTAL_NETO_LINEAS = TOTAL_NETO_LINEAS;
            mTOTAL_IMPUESTO_LINEAS = TOTAL_IMPUESTO_LINEAS;
            mTOTAL_DESCUENTOS = TOTAL_DESCUENTOS;
            mTOTAL_CARGOS = TOTAL_CARGOS;
            mTOTAL_SDCF = TOTAL_SDCF;
            mTOTAL_BASE_IMPONIBLE = TOTAL_BASE_IMPONIBLE;
            mTOTAL_IMPUESTO = TOTAL_IMPUESTO;
            mTOTAL_OPERACION = TOTAL_OPERACION;
            mTOTAL_IMPUESTO_MUNICIPAL = TOTAL_IMPUESTO_MUNICIPAL;
            mTOTAL_IMPUESTO_ADICIONAL = TOTAL_IMPUESTO_ADICIONAL;
            mTOTAL_RETENCION_ISLR = TOTAL_RETENCION_ISLR;
            mTOTAL_RETENCION_IVA = TOTAL_RETENCION_IVA;
            mTOTAL_CANCELADO = TOTAL_CANCELADO;
            mTOTAL_COSTOS_ASOCIADOS = TOTAL_COSTOS_ASOCIADOS;
            mTOTAL_NETO = TOTAL_NETO;
            mTOTAL_BASE_IMPONIBLE_LINEAS = TOTAL_BASE_IMPONIBLE_LINEAS;
            mTOTAL_BRUTO_LINEAS = TOTAL_BRUTO_LINEAS;
            mTOTAL_LINEAS = TOTAL_LINEAS;
            mTOTAL_IMPUESTO_AL_LICOR = TOTAL_IMPUESTO_AL_LICOR;
            mTOTAL_MONTO_SUJETO_PRORRATEO = TOTAL_MONTO_SUJETO_PRORRATEO;
            mRENGLONES_PRODUCTOS_IMPORTADOS = RENGLONES_PRODUCTOS_IMPORTADOS;
            mRENGLONES_PRODUCTOS_NACIONALES = RENGLONES_PRODUCTOS_NACIONALES;
            mPORC_RETENCION_IVA = PORC_RETENCION_IVA;
            mANTICIPO_APLICADO = ANTICIPO_APLICADO;
            mNOTA_CREDITO_APLICADA = NOTA_CREDITO_APLICADA;
            mCONTADO = CONTADO;
            mCREDITO = CREDITO;
            mCORRELATIVO_CXP = CORRELATIVO_CXP;
            mCONDICIONES_PAGO = CONDICIONES_PAGO;
            mSALDO_ABONADO = SALDO_ABONADO;
            mCLASIFICACION_CODIGO = CLASIFICACION_CODIGO;
            mPENDIENTE = PENDIENTE;
            mTEMPORAL = TEMPORAL;
            mFECHA_VENCIMIENTO = FECHA_VENCIMIENTO;
            mFECHA_ENTREGA = FECHA_ENTREGA;
            mFECHA_REGISTRO = FECHA_REGISTRO;
            mFECHA_EMISION = FECHA_EMISION;
            mFECHA_HORA_REGISTRO = FECHA_HORA_REGISTRO;
            mMOTIVO_DEVOLUCION = MOTIVO_DEVOLUCION;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
