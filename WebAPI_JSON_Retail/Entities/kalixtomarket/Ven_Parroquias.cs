using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Ven_Parroquias : ICloneable
    {

        private int mID = 0;
        private int mId_municipio = 0;
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

        public int Id_municipio
        {
            get
            {
                return mId_municipio;
            }
            set
            {
                mId_municipio = value;
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

        Ven_Parroquias()
        {
        }

        Ven_Parroquias(int ID, int id_municipio, string Descripcion)
        {
            mID = ID;
            mId_municipio = Id_municipio;
            mDescripcion = Descripcion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
