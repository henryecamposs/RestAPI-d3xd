using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Ven_Municipios : ICloneable
    {

        private int mID = 0;
        private int mId_estado = 0;
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

        public int Id_estado
        {
            get
            {
                return mId_estado;
            }
            set
            {
                mId_estado = value;
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

        Ven_Municipios()
        {
        }

        Ven_Municipios(int ID, int id_estado, string Descripcion)
        {
            mID = ID;
            mId_estado = Id_estado;
            mDescripcion = Descripcion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
