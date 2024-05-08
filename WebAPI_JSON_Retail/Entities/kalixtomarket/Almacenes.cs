using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Almacenes : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private string mDireccion = "";
        private string mResponsable = "";
        private int mId_Sucursal = 0;

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

        public string Direccion
        {
            get
            {
                return mDireccion;
            }
            set
            {
                mDireccion = value;
            }
        }

        public string Responsable
        {
            get
            {
                return mResponsable;
            }
            set
            {
                mResponsable = value;
            }
        }

        public int Id_Sucursal
        {
            get
            {
                return mId_Sucursal;
            }
            set
            {
                mId_Sucursal = value;
            }
        }

        public Almacenes()
        {
        }

        public Almacenes(int ID, string Descripcion, string Direccion, string Responsable, int id_Sucursal)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mDireccion = Direccion;
            mResponsable = Responsable;
            mId_Sucursal = Id_Sucursal;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
