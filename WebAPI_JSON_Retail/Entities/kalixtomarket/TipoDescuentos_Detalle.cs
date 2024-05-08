using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoDescuentos_Detalle : ICloneable
    {

        private int mID = 0;
        private int mId_TipoDescuento = 0;
        private int mId_Producto = 0;
        private string mComentario = "";
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

        public int Id_TipoDescuento
        {
            get
            {
                return mId_TipoDescuento;
            }
            set
            {
                mId_TipoDescuento = value;
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

        TipoDescuentos_Detalle()
        {
        }

        TipoDescuentos_Detalle(int ID, int id_TipoDescuento, int id_Producto, string Comentario, bool esActivo)
        {
            mID = ID;
            mId_TipoDescuento = Id_TipoDescuento;
            mId_Producto = Id_Producto;
            mComentario = Comentario;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
