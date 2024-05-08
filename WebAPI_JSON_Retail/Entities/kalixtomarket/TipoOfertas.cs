using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoOfertas : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private DateTime mFechaIni = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);
        private double mMontoTasa = 0.0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaModificado = new DateTime(2000, 01, 01);
        private bool mEsAplicaFactura = false;
        private bool mEsMontoTasaPorcentual = false;
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

        public Boolean EsAplicaFactura
        {
            get
            {
                return mEsAplicaFactura;
            }
            set
            {
                mEsAplicaFactura = value;
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

        TipoOfertas()
        {
        }

        TipoOfertas(int ID, string Descripcion, DateTime FechaIni, DateTime FechaFin, double MontoTasa, DateTime FechaActual, DateTime FechaModificado, bool esAplicaFactura, bool esMontoTasaPorcentual, bool esActivo)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mFechaIni = FechaIni;
            mFechaFin = FechaFin;
            mMontoTasa = MontoTasa;
            mFechaActual = FechaActual;
            mFechaModificado = FechaModificado;
            mEsAplicaFactura = EsAplicaFactura;
            mEsMontoTasaPorcentual = EsMontoTasaPorcentual;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
