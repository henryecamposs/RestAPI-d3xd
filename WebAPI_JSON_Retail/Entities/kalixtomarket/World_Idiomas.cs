using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class World_Idiomas : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private string mCodigo = "";
        private bool mEstado = false;

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

        public string Codigo
        {
            get
            {
                return mCodigo;
            }
            set
            {
                mCodigo = value;
            }
        }

        public Boolean Estado
        {
            get
            {
                return mEstado;
            }
            set
            {
                mEstado = value;
            }
        }

        World_Idiomas()
        {
        }

        World_Idiomas(int ID, string Descripcion, string Codigo, bool Estado)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mCodigo = Codigo;
            mEstado = Estado;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
