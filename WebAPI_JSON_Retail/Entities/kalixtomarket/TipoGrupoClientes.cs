using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoGrupoClientes : ICloneable
    {

        private int mID = 0;
        private int mId_TipoZona = 0;
        private string mDescirpcion = "";

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

        public int Id_TipoZona
        {
            get
            {
                return mId_TipoZona;
            }
            set
            {
                mId_TipoZona = value;
            }
        }

        public string Descirpcion
        {
            get
            {
                return mDescirpcion;
            }
            set
            {
                mDescirpcion = value;
            }
        }

        TipoGrupoClientes()
        {
        }

        TipoGrupoClientes(int ID, int id_TipoZona, string Descirpcion)
        {
            mID = ID;
            mId_TipoZona = Id_TipoZona;
            mDescirpcion = Descirpcion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
