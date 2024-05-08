using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoAreasComunes : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private bool mEsActivo = false;

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

        public Boolean EsActivo
        {
            get
            {
                return mEsActivo;
            }
            set
            {
                mEsActivo = value;
            }
        }

        TipoAreasComunes()
        {
        }

        TipoAreasComunes(int ID, string Descripcion, bool esActivo)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
