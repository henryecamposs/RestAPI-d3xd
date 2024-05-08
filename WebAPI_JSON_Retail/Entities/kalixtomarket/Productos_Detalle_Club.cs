using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Detalle_Club : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_EmpleadoClub = 0;
        private int mId_defTipoPrograma = 0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaInicio = new DateTime(2000, 01, 01);
        private DateTime mFechaVencimiento = new DateTime(2000, 01, 01);
        private int mNroDiasPreVencimiento = 0;
        private int mNroDiasPostvencimiento = 0;
        private int mNroVisitas = 0;
        private int mMinVisitantes = 0;
        private int mMaxVisitantes = 0;
        private string mComentario = "";
        private DateTime mHoraInicio_PrimerTurno = new DateTime(2000, 01, 01);
        private DateTime mHoraFin_PrimerTurno = new DateTime(2000, 01, 01);
        private DateTime mHoraInico_SegundoTurno = new DateTime(2000, 01, 01);
        private DateTime mHoraFin_SegundoTurno = new DateTime(2000, 01, 01);
        private DateTime mHoraInicio_TercerTurno = new DateTime(2000, 01, 01);
        private DateTime mHoraFin_TercerTurno = new DateTime(2000, 01, 01);
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

        public int Id_Producto
        {
            get
            {
                return mId_Producto;
            }
            set
            {
                mId_Producto = value;
            }
        }

        public int Id_EmpleadoClub
        {
            get
            {
                return mId_EmpleadoClub;
            }
            set
            {
                mId_EmpleadoClub = value;
            }
        }

        public int Id_defTipoPrograma
        {
            get
            {
                return mId_defTipoPrograma;
            }
            set
            {
                mId_defTipoPrograma = value;
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

        public DateTime FechaVencimiento
        {
            get
            {
                return mFechaVencimiento;
            }
            set
            {
                mFechaVencimiento = value;
            }
        }

        public int NroDiasPreVencimiento
        {
            get
            {
                return mNroDiasPreVencimiento;
            }
            set
            {
                mNroDiasPreVencimiento = value;
            }
        }

        public int NroDiasPostvencimiento
        {
            get
            {
                return mNroDiasPostvencimiento;
            }
            set
            {
                mNroDiasPostvencimiento = value;
            }
        }

        public int NroVisitas
        {
            get
            {
                return mNroVisitas;
            }
            set
            {
                mNroVisitas = value;
            }
        }

        public int MinVisitantes
        {
            get
            {
                return mMinVisitantes;
            }
            set
            {
                mMinVisitantes = value;
            }
        }

        public int MaxVisitantes
        {
            get
            {
                return mMaxVisitantes;
            }
            set
            {
                mMaxVisitantes = value;
            }
        }

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public DateTime HoraInicio_PrimerTurno
        {
            get
            {
                return mHoraInicio_PrimerTurno;
            }
            set
            {
                mHoraInicio_PrimerTurno = value;
            }
        }

        public DateTime HoraFin_PrimerTurno
        {
            get
            {
                return mHoraFin_PrimerTurno;
            }
            set
            {
                mHoraFin_PrimerTurno = value;
            }
        }

        public DateTime HoraInico_SegundoTurno
        {
            get
            {
                return mHoraInico_SegundoTurno;
            }
            set
            {
                mHoraInico_SegundoTurno = value;
            }
        }

        public DateTime HoraFin_SegundoTurno
        {
            get
            {
                return mHoraFin_SegundoTurno;
            }
            set
            {
                mHoraFin_SegundoTurno = value;
            }
        }

        public DateTime HoraInicio_TercerTurno
        {
            get
            {
                return mHoraInicio_TercerTurno;
            }
            set
            {
                mHoraInicio_TercerTurno = value;
            }
        }

        public DateTime HoraFin_TercerTurno
        {
            get
            {
                return mHoraFin_TercerTurno;
            }
            set
            {
                mHoraFin_TercerTurno = value;
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

        Productos_Detalle_Club()
        {
        }

        Productos_Detalle_Club(int ID, int Id_Producto, int id_EmpleadoClub, int id_defTipoPrograma, DateTime FechaActual, DateTime FechaInicio, DateTime FechaVencimiento, int NroDiasPreVencimiento, int NroDiasPostvencimiento, int NroVisitas, int MinVisitantes, int MaxVisitantes, string Comentario, DateTime HoraInicio_PrimerTurno, DateTime HoraFin_PrimerTurno, DateTime HoraInico_SegundoTurno, DateTime HoraFin_SegundoTurno, DateTime HoraInicio_TercerTurno, DateTime HoraFin_TercerTurno, bool esActivo)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_EmpleadoClub = Id_EmpleadoClub;
            mId_defTipoPrograma = Id_defTipoPrograma;
            mFechaActual = FechaActual;
            mFechaInicio = FechaInicio;
            mFechaVencimiento = FechaVencimiento;
            mNroDiasPreVencimiento = NroDiasPreVencimiento;
            mNroDiasPostvencimiento = NroDiasPostvencimiento;
            mNroVisitas = NroVisitas;
            mMinVisitantes = MinVisitantes;
            mMaxVisitantes = MaxVisitantes;
            mComentario = Comentario;
            mHoraInicio_PrimerTurno = HoraInicio_PrimerTurno;
            mHoraFin_PrimerTurno = HoraFin_PrimerTurno;
            mHoraInico_SegundoTurno = HoraInico_SegundoTurno;
            mHoraFin_SegundoTurno = HoraFin_SegundoTurno;
            mHoraInicio_TercerTurno = HoraInicio_TercerTurno;
            mHoraFin_TercerTurno = HoraFin_TercerTurno;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
