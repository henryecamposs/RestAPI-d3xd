using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoProductos_Marcas : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private string mFabricante = "";
        private string mDireccionWebFabricante = "";

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

        public string Fabricante
        {
            get
            {
                return mFabricante;
            }
            set
            {
                mFabricante = value;
            }
        }

        public string DireccionWebFabricante
        {
            get
            {
                return mDireccionWebFabricante;
            }
            set
            {
                mDireccionWebFabricante = value;
            }
        }

        TipoProductos_Marcas()
        {
        }

        TipoProductos_Marcas(int ID, string Descripcion, string Fabricante, string DireccionWebFabricante)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mFabricante = Fabricante;
            mDireccionWebFabricante = DireccionWebFabricante;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
