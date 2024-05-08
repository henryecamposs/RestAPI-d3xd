using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Modificadas : ICloneable
    {

        private int mID = 0;
        private int mId_factura = 0;
        private int mId_Estaciones_Sesiones = 0;
        private int mId_defTipoModificacion = 0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private string mComentario = "";

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

        public int Id_factura
        {
            get
            {
                return mId_factura;
            }
            set
            {
                mId_factura = value;
            }
        }

        public int Id_Estaciones_Sesiones
        {
            get
            {
                return mId_Estaciones_Sesiones;
            }
            set
            {
                mId_Estaciones_Sesiones = value;
            }
        }

        public int Id_defTipoModificacion
        {
            get
            {
                return mId_defTipoModificacion;
            }
            set
            {
                mId_defTipoModificacion = value;
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

        Facturas_Modificadas()
        {
        }

        Facturas_Modificadas(int ID, int id_factura, int id_Estaciones_Sesiones, int id_defTipoModificacion, DateTime FechaActual, string Comentario)
        {
            mID = ID;
            mId_factura = Id_factura;
            mId_Estaciones_Sesiones = Id_Estaciones_Sesiones;
            mId_defTipoModificacion = Id_defTipoModificacion;
            mFechaActual = FechaActual;
            mComentario = Comentario;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
