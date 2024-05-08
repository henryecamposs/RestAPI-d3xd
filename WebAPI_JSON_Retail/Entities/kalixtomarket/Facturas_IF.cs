using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_IF : ICloneable
    {

        private int mID = 0;
        private int mId_Factura = 0;
        private int mNroFacturaIF = 0;
        private string mRIF_IF = "";
        private string mNroRegistroIF = "";
        private DateTime mFechaFacturaIF = new DateTime(2000, 01, 01);

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

        public int NroFacturaIF
        {
            get
            {
                return mNroFacturaIF;
            }
            set
            {
                mNroFacturaIF = value;
            }
        }

        public string RIF_IF
        {
            get
            {
                return mRIF_IF;
            }
            set
            {
                mRIF_IF = value;
            }
        }

        public string NroRegistroIF
        {
            get
            {
                return mNroRegistroIF;
            }
            set
            {
                mNroRegistroIF = value;
            }
        }

        public DateTime FechaFacturaIF
        {
            get
            {
                return mFechaFacturaIF;
            }
            set
            {
                mFechaFacturaIF = value;
            }
        }

        Facturas_IF()
        {
        }

        Facturas_IF(int ID, int Id_Factura, int NroFacturaIF, string RIF_IF, string NroRegistroIF, DateTime FechaFacturaIF)
        {
            mID = ID;
            mId_Factura = Id_Factura;
            mNroFacturaIF = NroFacturaIF;
            mRIF_IF = RIF_IF;
            mNroRegistroIF = NroRegistroIF;
            mFechaFacturaIF = FechaFacturaIF;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
