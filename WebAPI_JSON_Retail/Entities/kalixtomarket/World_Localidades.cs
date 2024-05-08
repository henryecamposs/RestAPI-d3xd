using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class World_Localidades : ICloneable
    {

        private int mID = 0;
        private int mId_pais = 0;
        private int mId_idioma = 0;
        private int mId_region = 0;
        private string mDescripcion = "";
        private double mX = 0.0;
        private double mY = 0.0;
        private bool mExacto = false;

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

        public int Id_pais
        {
            get
            {
                return mId_pais;
            }
            set
            {
                mId_pais = value;
            }
        }

        public int Id_idioma
        {
            get
            {
                return mId_idioma;
            }
            set
            {
                mId_idioma = value;
            }
        }

        public int Id_region
        {
            get
            {
                return mId_region;
            }
            set
            {
                mId_region = value;
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

        public Double X
        {
            get
            {
                return mX;
            }
            set
            {
                mX = value;
            }
        }

        public Double Y
        {
            get
            {
                return mY;
            }
            set
            {
                mY = value;
            }
        }

        public Boolean Exacto
        {
            get
            {
                return mExacto;
            }
            set
            {
                mExacto = value;
            }
        }

        World_Localidades()
        {
        }

        World_Localidades(int ID, int id_pais, int id_idioma, int id_region, string Descripcion, double x, double y, bool exacto)
        {
            mID = ID;
            mId_pais = Id_pais;
            mId_idioma = Id_idioma;
            mId_region = Id_region;
            mDescripcion = Descripcion;
            mX = X;
            mY = Y;
            mExacto = Exacto;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
