using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Modificadas_IF : ICloneable
    {

        private int mID = 0;
        private int mId_Facturas_Modificadas = 0;
        private int mNroFacturaIF = 0;
        private string mNroRegistrolF = "";
        private string mRIF_IF = "";
        private DateTime mFechaFacturaIF = new DateTime(2000, 01, 01);
        private double mMontoTotalBase_IVA1 = 0.0;
        private double mMontoTotalBase_IVA2 = 0.0;
        private double mMontoTotalBase_IVA3 = 0.0;
        private double mMontoTotalTasa_IVA1 = 0.0;
        private double mMontoTotalTasa_IVA2 = 0.0;
        private double mMontoTotalTasa_IVA3 = 0.0;

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

        public int Id_Facturas_Modificadas
        {
            get
            {
                return mId_Facturas_Modificadas;
            }
            set
            {
                mId_Facturas_Modificadas = value;
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

        public string NroRegistrolF
        {
            get
            {
                return mNroRegistrolF;
            }
            set
            {
                mNroRegistrolF = value;
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

        public Double MontoTotalBase_IVA1
        {
            get
            {
                return mMontoTotalBase_IVA1;
            }
            set
            {
                mMontoTotalBase_IVA1 = value;
            }
        }

        public Double MontoTotalBase_IVA2
        {
            get
            {
                return mMontoTotalBase_IVA2;
            }
            set
            {
                mMontoTotalBase_IVA2 = value;
            }
        }

        public Double MontoTotalBase_IVA3
        {
            get
            {
                return mMontoTotalBase_IVA3;
            }
            set
            {
                mMontoTotalBase_IVA3 = value;
            }
        }

        public Double MontoTotalTasa_IVA1
        {
            get
            {
                return mMontoTotalTasa_IVA1;
            }
            set
            {
                mMontoTotalTasa_IVA1 = value;
            }
        }

        public Double MontoTotalTasa_IVA2
        {
            get
            {
                return mMontoTotalTasa_IVA2;
            }
            set
            {
                mMontoTotalTasa_IVA2 = value;
            }
        }

        public Double MontoTotalTasa_IVA3
        {
            get
            {
                return mMontoTotalTasa_IVA3;
            }
            set
            {
                mMontoTotalTasa_IVA3 = value;
            }
        }

        Facturas_Modificadas_IF()
        {
        }

        Facturas_Modificadas_IF(int ID, int id_Facturas_Modificadas, int NroFacturaIF, string NroRegistrolF, string RIF_IF, DateTime FechaFacturaIF, double MontoTotalBase_IVA1, double MontoTotalBase_IVA2, double MontoTotalBase_IVA3, double MontoTotalTasa_IVA1, double MontoTotalTasa_IVA2, double MontoTotalTasa_IVA3)
        {
            mID = ID;
            mId_Facturas_Modificadas = Id_Facturas_Modificadas;
            mNroFacturaIF = NroFacturaIF;
            mNroRegistrolF = NroRegistrolF;
            mRIF_IF = RIF_IF;
            mFechaFacturaIF = FechaFacturaIF;
            mMontoTotalBase_IVA1 = MontoTotalBase_IVA1;
            mMontoTotalBase_IVA2 = MontoTotalBase_IVA2;
            mMontoTotalBase_IVA3 = MontoTotalBase_IVA3;
            mMontoTotalTasa_IVA1 = MontoTotalTasa_IVA1;
            mMontoTotalTasa_IVA2 = MontoTotalTasa_IVA2;
            mMontoTotalTasa_IVA3 = MontoTotalTasa_IVA3;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
