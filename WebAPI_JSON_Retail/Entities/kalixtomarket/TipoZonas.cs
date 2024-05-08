using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoZonas : ICloneable
    {

        private int mID = 0;
        private int mId_Localidad = 0;
        private string mDescripcion = "";

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

        public int Id_Localidad
        {
            get
            {
                return mId_Localidad;
            }
            set
            {
                mId_Localidad = value;
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

        TipoZonas()
        {
        }

        TipoZonas(int ID, int id_Localidad, string Descripcion)
        {
            mID = ID;
            mId_Localidad = Id_Localidad;
            mDescripcion = Descripcion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
