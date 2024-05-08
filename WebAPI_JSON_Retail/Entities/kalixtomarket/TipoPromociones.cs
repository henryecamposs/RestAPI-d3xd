using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoPromociones : ICloneable
    {

        private int mID = 0;
        private int mId_defTipoPromociones = 0;
        private string mDescripcion = "";
        private DateTime mFechaIni = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaModificado = new DateTime(2000, 01, 01);
        private double mMontoTasa = 0.0;
        private int mHoraIni = 0;
        private int mHoraFin = 0;
        private string mIdEstacionesPermitidas = "";
        private string mIdTipoPagoPermitidas = "";
        private string mParametro1 = "";
        private string mParametro2 = "";
        private string mParametro3 = "";
        private string mDiasSemana = "";
        private string mDiasPromocion = "";
        private bool mEsAplicaSoloFactura = false;
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

        public int Id_defTipoPromociones
        {
            get
            {
                return mId_defTipoPromociones;
            }
            set
            {
                mId_defTipoPromociones = value;
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

        public int HoraIni
        {
            get
            {
                return mHoraIni;
            }
            set
            {
                mHoraIni = value;
            }
        }

        public int HoraFin
        {
            get
            {
                return mHoraFin;
            }
            set
            {
                mHoraFin = value;
            }
        }

        public string IdEstacionesPermitidas
        {
            get
            {
                return mIdEstacionesPermitidas;
            }
            set
            {
                mIdEstacionesPermitidas = value;
            }
        }

        public string IdTipoPagoPermitidas
        {
            get
            {
                return mIdTipoPagoPermitidas;
            }
            set
            {
                mIdTipoPagoPermitidas = value;
            }
        }

        public string Parametro1
        {
            get
            {
                return mParametro1;
            }
            set
            {
                mParametro1 = value;
            }
        }

        public string Parametro2
        {
            get
            {
                return mParametro2;
            }
            set
            {
                mParametro2 = value;
            }
        }

        public string Parametro3
        {
            get
            {
                return mParametro3;
            }
            set
            {
                mParametro3 = value;
            }
        }

        public string DiasSemana
        {
            get
            {
                return mDiasSemana;
            }
            set
            {
                mDiasSemana = value;
            }
        }

        public string DiasPromocion
        {
            get
            {
                return mDiasPromocion;
            }
            set
            {
                mDiasPromocion = value;
            }
        }

        public Boolean EsAplicaSoloFactura
        {
            get
            {
                return mEsAplicaSoloFactura;
            }
            set
            {
                mEsAplicaSoloFactura = value;
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

        TipoPromociones()
        {
        }

        TipoPromociones(int ID, int id_defTipoPromociones, string Descripcion, DateTime FechaIni, DateTime FechaFin, DateTime FechaActual, DateTime FechaModificado, double MontoTasa, int HoraIni, int HoraFin, string idEstacionesPermitidas, string idTipoPagoPermitidas, string parametro1, string parametro2, string parametro3, string DiasSemana, string DiasPromocion, bool esAplicaSoloFactura, bool esMontoTasaPorcentual, bool esActivo)
        {
            mID = ID;
            mId_defTipoPromociones = Id_defTipoPromociones;
            mDescripcion = Descripcion;
            mFechaIni = FechaIni;
            mFechaFin = FechaFin;
            mFechaActual = FechaActual;
            mFechaModificado = FechaModificado;
            mMontoTasa = MontoTasa;
            mHoraIni = HoraIni;
            mHoraFin = HoraFin;
            mIdEstacionesPermitidas = IdEstacionesPermitidas;
            mIdTipoPagoPermitidas = IdTipoPagoPermitidas;
            mParametro1 = Parametro1;
            mParametro2 = Parametro2;
            mParametro3 = Parametro3;
            mDiasSemana = DiasSemana;
            mDiasPromocion = DiasPromocion;
            mEsAplicaSoloFactura = EsAplicaSoloFactura;
            mEsMontoTasaPorcentual = EsMontoTasaPorcentual;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
