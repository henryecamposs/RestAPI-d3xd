using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class World_Paises : ICloneable
    {

        private int mID = 0;
        private int mId_idioma = 0;
        private string mDescripcion = "";
        private double mX = 0.0;
        private double mY = 0.0;

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

        World_Paises()
        {
        }

        World_Paises(int ID, int id_idioma, string Descripcion, double x, double y)
        {
            mID = ID;
            mId_idioma = Id_idioma;
            mDescripcion = Descripcion;
            mX = X;
            mY = Y;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
