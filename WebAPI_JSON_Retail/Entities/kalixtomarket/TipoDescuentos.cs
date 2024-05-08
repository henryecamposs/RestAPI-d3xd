using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoDescuentos : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private double mMontoTasa = 0.0;
        private DateTime mFechaIni = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaModificado = new DateTime(2000, 01, 01);
        private bool mEsMontoTasaPorcentual = false;
        private bool mEsDescuento = false;
        private bool mEsPorItem = false;
        private bool mEsActivo = false;

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

        public Double MontoTasa
        {
            get
            {
                return mMontoTasa;
            }
            set
            {
                mMontoTasa = value;
            }
        }

        public DateTime FechaIni
        {
            get
            {
                return mFechaIni;
            }
            set
            {
                mFechaIni = value;
            }
        }

        public DateTime FechaFin
        {
            get
            {
                return mFechaFin;
            }
            set
            {
                mFechaFin = value;
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

        public DateTime FechaModificado
        {
            get
            {
                return mFechaModificado;
            }
            set
            {
                mFechaModificado = value;
            }
        }

        public Boolean EsMontoTasaPorcentual
        {
            get
            {
                return mEsMontoTasaPorcentual;
            }
            set
            {
                mEsMontoTasaPorcentual = value;
            }
        }

        public Boolean EsDescuento
        {
            get
            {
                return mEsDescuento;
            }
            set
            {
                mEsDescuento = value;
            }
        }

        public Boolean EsPorItem
        {
            get
            {
                return mEsPorItem;
            }
            set
            {
                mEsPorItem = value;
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

        TipoDescuentos()
        {
        }

        TipoDescuentos(int ID, string Descripcion, double MontoTasa, DateTime FechaIni, DateTime FechaFin, DateTime FechaActual, DateTime FechaModificado, bool esMontoTasaPorcentual, bool esDescuento, bool esPorItem, bool esActivo)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mMontoTasa = MontoTasa;
            mFechaIni = FechaIni;
            mFechaFin = FechaFin;
            mFechaActual = FechaActual;
            mFechaModificado = FechaModificado;
            mEsMontoTasaPorcentual = EsMontoTasaPorcentual;
            mEsDescuento = EsDescuento;
            mEsPorItem = EsPorItem;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
