using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_FormasPago : ICloneable
    {

        private int mID = 0;
        private int mId_Factura = 0;
        private int mId_TipoPago = 0;
        private int mId_TipoBanco = 0;
        private string mDescripicionDocumento = "";
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private double mMontoTotal = 0.0;
        private string mNroAprobacion = "";
        private string mNroDocumento = "";
        private string mNroRecibo = "";

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

        public int Id_TipoPago
        {
            get
            {
                return mId_TipoPago;
            }
            set
            {
                mId_TipoPago = value;
            }
        }

        public int Id_TipoBanco
        {
            get
            {
                return mId_TipoBanco;
            }
            set
            {
                mId_TipoBanco = value;
            }
        }

        public string DescripicionDocumento
        {
            get
            {
                return mDescripicionDocumento;
            }
            set
            {
                mDescripicionDocumento = value;
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

        public string NroAprobacion
        {
            get
            {
                return mNroAprobacion;
            }
            set
            {
                mNroAprobacion = value;
            }
        }

        public string NroDocumento
        {
            get
            {
                return mNroDocumento;
            }
            set
            {
                mNroDocumento = value;
            }
        }

        public string NroRecibo
        {
            get
            {
                return mNroRecibo;
            }
            set
            {
                mNroRecibo = value;
            }
        }

        Facturas_FormasPago()
        {
        }

        Facturas_FormasPago(int ID, int Id_Factura, int Id_TipoPago, int Id_TipoBanco, string DescripicionDocumento, DateTime FechaActual, double MontoTotal, string nroAprobacion, string nroDocumento, string nroRecibo)
        {
            mID = ID;
            mId_Factura = Id_Factura;
            mId_TipoPago = Id_TipoPago;
            mId_TipoBanco = Id_TipoBanco;
            mDescripicionDocumento = DescripicionDocumento;
            mFechaActual = FechaActual;
            mMontoTotal = MontoTotal;
            mNroAprobacion = NroAprobacion;
            mNroDocumento = NroDocumento;
            mNroRecibo = NroRecibo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
