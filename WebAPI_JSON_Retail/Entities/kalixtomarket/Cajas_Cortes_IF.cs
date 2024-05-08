using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Cajas_Cortes_IF : ICloneable
    {

        private int mID = 0;
        private int mId_Cajas_Cortes = 0;
        private string mNroSerialIF = "";
        private string mRIF_IF = "";
        private DateTime mFechaFinal_IF = new DateTime(2000, 01, 01);
        private DateTime mFechaInicial_IF = new DateTime(2000, 01, 01);
        private double mMontoTotalBaseIVA0 = 0.0;
        private double mMontoTotalBaseIVA1 = 0.0;
        private double mMontoTotalBaseIVA2 = 0.0;
        private double mMontoTotalBaseIVA3 = 0.0;
        private double mMontoTasaIVA0 = 0.0;
        private double mMontoTasaIVA1 = 0.0;
        private double mMontoTasaIVA2 = 0.0;
        private double mMontoTasaIVA3 = 0.0;
        private int mNroCorteZIF = 0;
        private int mNrofacturaFinalIF = 0;
        private int mNroFacturaInicialIF = 0;

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

        public int Id_Cajas_Cortes
        {
            get
            {
                return mId_Cajas_Cortes;
            }
            set
            {
                mId_Cajas_Cortes = value;
            }
        }

        public string NroSerialIF
        {
            get
            {
                return mNroSerialIF;
            }
            set
            {
                mNroSerialIF = value;
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

        public DateTime FechaFinal_IF
        {
            get
            {
                return mFechaFinal_IF;
            }
            set
            {
                mFechaFinal_IF = value;
            }
        }

        public DateTime FechaInicial_IF
        {
            get
            {
                return mFechaInicial_IF;
            }
            set
            {
                mFechaInicial_IF = value;
            }
        }

        public Double MontoTotalBaseIVA0
        {
            get
            {
                return mMontoTotalBaseIVA0;
            }
            set
            {
                mMontoTotalBaseIVA0 = value;
            }
        }

        public Double MontoTotalBaseIVA1
        {
            get
            {
                return mMontoTotalBaseIVA1;
            }
            set
            {
                mMontoTotalBaseIVA1 = value;
            }
        }

        public Double MontoTotalBaseIVA2
        {
            get
            {
                return mMontoTotalBaseIVA2;
            }
            set
            {
                mMontoTotalBaseIVA2 = value;
            }
        }

        public Double MontoTotalBaseIVA3
        {
            get
            {
                return mMontoTotalBaseIVA3;
            }
            set
            {
                mMontoTotalBaseIVA3 = value;
            }
        }

        public Double MontoTasaIVA0
        {
            get
            {
                return mMontoTasaIVA0;
            }
            set
            {
                mMontoTasaIVA0 = value;
            }
        }

        public Double MontoTasaIVA1
        {
            get
            {
                return mMontoTasaIVA1;
            }
            set
            {
                mMontoTasaIVA1 = value;
            }
        }

        public Double MontoTasaIVA2
        {
            get
            {
                return mMontoTasaIVA2;
            }
            set
            {
                mMontoTasaIVA2 = value;
            }
        }

        public Double MontoTasaIVA3
        {
            get
            {
                return mMontoTasaIVA3;
            }
            set
            {
                mMontoTasaIVA3 = value;
            }
        }

        public int NroCorteZIF
        {
            get
            {
                return mNroCorteZIF;
            }
            set
            {
                mNroCorteZIF = value;
            }
        }

        public int NrofacturaFinalIF
        {
            get
            {
                return mNrofacturaFinalIF;
            }
            set
            {
                mNrofacturaFinalIF = value;
            }
        }

        public int NroFacturaInicialIF
        {
            get
            {
                return mNroFacturaInicialIF;
            }
            set
            {
                mNroFacturaInicialIF = value;
            }
        }

        Cajas_Cortes_IF()
        {
        }

        Cajas_Cortes_IF(int ID, int id_Cajas_Cortes, string NroSerialIF, string RIF_IF, DateTime FechaFinal_IF, DateTime FechaInicial_IF, double MontoTotalBaseIVA0, double MontoTotalBaseIVA1, double MontoTotalBaseIVA2, double MontoTotalBaseIVA3, double MontoTasaIVA0, double MontoTasaIVA1, double MontoTasaIVA2, double MontoTasaIVA3, int NroCorteZIF, int NrofacturaFinalIF, int NroFacturaInicialIF)
        {
            mID = ID;
            mId_Cajas_Cortes = Id_Cajas_Cortes;
            mNroSerialIF = NroSerialIF;
            mRIF_IF = RIF_IF;
            mFechaFinal_IF = FechaFinal_IF;
            mFechaInicial_IF = FechaInicial_IF;
            mMontoTotalBaseIVA0 = MontoTotalBaseIVA0;
            mMontoTotalBaseIVA1 = MontoTotalBaseIVA1;
            mMontoTotalBaseIVA2 = MontoTotalBaseIVA2;
            mMontoTotalBaseIVA3 = MontoTotalBaseIVA3;
            mMontoTasaIVA0 = MontoTasaIVA0;
            mMontoTasaIVA1 = MontoTasaIVA1;
            mMontoTasaIVA2 = MontoTasaIVA2;
            mMontoTasaIVA3 = MontoTasaIVA3;
            mNroCorteZIF = NroCorteZIF;
            mNrofacturaFinalIF = NrofacturaFinalIF;
            mNroFacturaInicialIF = NroFacturaInicialIF;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
