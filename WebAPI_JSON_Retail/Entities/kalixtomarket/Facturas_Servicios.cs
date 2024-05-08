using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Servicios : ICloneable
    {

        private int mID = 0;
        private int mId_Empleado = 0;
        private int mId_Factura = 0;
        private int mId_defTipoStatusServicio = 0;
        private DateTime mFechaInicio = new DateTime(2000, 01, 01);
        private DateTime mFechaInicioTentativo = new DateTime(2000, 01, 01);
        private DateTime mFechaFin = new DateTime(2000, 01, 01);
        private DateTime mFechaFinTentativo = new DateTime(2000, 01, 01);
        private string mNombreRecibe = "";
        private string mNombreSolicita = "";
        private int mNroDiasGarantia = 0;
        private int mNroRecibo = 0;
        private int mNroHorasTentativo = 0;
        private int mNroHorasEjecucion = 0;
        private string mComentarios = "";

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

        public int Id_Empleado
        {
            get
            {
                return mId_Empleado;
            }
            set
            {
                mId_Empleado = value;
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

        public int Id_defTipoStatusServicio
        {
            get
            {
                return mId_defTipoStatusServicio;
            }
            set
            {
                mId_defTipoStatusServicio = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return mFechaInicio;
            }
            set
            {
                mFechaInicio = value;
            }
        }

        public DateTime FechaInicioTentativo
        {
            get
            {
                return mFechaInicioTentativo;
            }
            set
            {
                mFechaInicioTentativo = value;
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

        public DateTime FechaFinTentativo
        {
            get
            {
                return mFechaFinTentativo;
            }
            set
            {
                mFechaFinTentativo = value;
            }
        }

        public string NombreRecibe
        {
            get
            {
                return mNombreRecibe;
            }
            set
            {
                mNombreRecibe = value;
            }
        }

        public string NombreSolicita
        {
            get
            {
                return mNombreSolicita;
            }
            set
            {
                mNombreSolicita = value;
            }
        }

        public int NroDiasGarantia
        {
            get
            {
                return mNroDiasGarantia;
            }
            set
            {
                mNroDiasGarantia = value;
            }
        }

        public int NroRecibo
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

        public int NroHorasTentativo
        {
            get
            {
                return mNroHorasTentativo;
            }
            set
            {
                mNroHorasTentativo = value;
            }
        }

        public int NroHorasEjecucion
        {
            get
            {
                return mNroHorasEjecucion;
            }
            set
            {
                mNroHorasEjecucion = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return mComentarios;
            }
            set
            {
                mComentarios = value;
            }
        }

        Facturas_Servicios()
        {
        }

        Facturas_Servicios(int ID, int id_Empleado, int Id_Factura, int id_defTipoStatusServicio, DateTime FechaInicio, DateTime FechaInicioTentativo, DateTime FechaFin, DateTime FechaFinTentativo, string NombreRecibe, string NombreSolicita, int NroDiasGarantia, int NroRecibo, int NroHorasTentativo, int NroHorasEjecucion, string Comentarios)
        {
            mID = ID;
            mId_Empleado = Id_Empleado;
            mId_Factura = Id_Factura;
            mId_defTipoStatusServicio = Id_defTipoStatusServicio;
            mFechaInicio = FechaInicio;
            mFechaInicioTentativo = FechaInicioTentativo;
            mFechaFin = FechaFin;
            mFechaFinTentativo = FechaFinTentativo;
            mNombreRecibe = NombreRecibe;
            mNombreSolicita = NombreSolicita;
            mNroDiasGarantia = NroDiasGarantia;
            mNroRecibo = NroRecibo;
            mNroHorasTentativo = NroHorasTentativo;
            mNroHorasEjecucion = NroHorasEjecucion;
            mComentarios = Comentarios;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
