using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class World_Regiones : ICloneable
    {

        private int mID = 0;
        private int mId_pais = 0;
        private int mId_idioma = 0;
        private string mDescripcion = "";
        private double mX = 0.0;
        private double mY = 0.0;
        private int mExacto = 0;

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

        public int Exacto
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

        World_Regiones()
        {
        }

        World_Regiones(int ID, int id_pais, int id_idioma, string Descripcion, double x, double y, int exacto)
        {
            mID = ID;
            mId_pais = Id_pais;
            mId_idioma = Id_idioma;
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
