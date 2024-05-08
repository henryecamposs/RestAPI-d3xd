using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RECOMENDACION_TIPO_VEHICULO : ICloneable
    {

        private int mID_GRUPO_VEHI = 0;
        private int mID_RECO_TIPO_VEHI = 0;
        private int mID_TIPO_VEHI = 0;
        private double mKILOMETRAJE_DESDE = 0.0;
        private double mKILOMETRAJE_HASTA = 0.0;
        private string mOBSERVACION = "";

        public int ID_GRUPO_VEHI
        {
            get
            {
                return mID_GRUPO_VEHI;
            }
            set
            {
                mID_GRUPO_VEHI = value;
            }
        }

        public int ID_RECO_TIPO_VEHI
        {
            get
            {
                return mID_RECO_TIPO_VEHI;
            }
            set
            {
                mID_RECO_TIPO_VEHI = value;
            }
        }

        public int ID_TIPO_VEHI
        {
            get
            {
                return mID_TIPO_VEHI;
            }
            set
            {
                mID_TIPO_VEHI = value;
            }
        }

        public Double KILOMETRAJE_DESDE
        {
            get
            {
                return mKILOMETRAJE_DESDE;
            }
            set
            {
                mKILOMETRAJE_DESDE = value;
            }
        }

        public Double KILOMETRAJE_HASTA
        {
            get
            {
                return mKILOMETRAJE_HASTA;
            }
            set
            {
                mKILOMETRAJE_HASTA = value;
            }
        }

        public string OBSERVACION
        {
            get
            {
                return mOBSERVACION;
            }
            set
            {
                mOBSERVACION = value;
            }
        }

        RECOMENDACION_TIPO_VEHICULO()
        {
        }

        RECOMENDACION_TIPO_VEHICULO(int ID_GRUPO_VEHI, int ID_RECO_TIPO_VEHI, int ID_TIPO_VEHI, double KILOMETRAJE_DESDE, double KILOMETRAJE_HASTA, string OBSERVACION)
        {
            mID_GRUPO_VEHI = ID_GRUPO_VEHI;
            mID_RECO_TIPO_VEHI = ID_RECO_TIPO_VEHI;
            mID_TIPO_VEHI = ID_TIPO_VEHI;
            mKILOMETRAJE_DESDE = KILOMETRAJE_DESDE;
            mKILOMETRAJE_HASTA = KILOMETRAJE_HASTA;
            mOBSERVACION = OBSERVACION;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
