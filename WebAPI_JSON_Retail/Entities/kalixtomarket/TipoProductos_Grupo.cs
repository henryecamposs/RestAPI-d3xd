using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoProductos_Grupo : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private string mCodigoRef = "";

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

        public string CodigoRef
        {
            get
            {
                return mCodigoRef;
            }
            set
            {
                mCodigoRef = value;
            }
        }

        TipoProductos_Grupo()
        {
        }

        TipoProductos_Grupo(int ID, string Descripcion, string CodigoRef)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mCodigoRef = CodigoRef;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
