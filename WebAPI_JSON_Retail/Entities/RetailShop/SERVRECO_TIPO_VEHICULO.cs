using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVRECO_TIPO_VEHICULO : ICloneable
    {

        private int mID_RECO_TIPO_VEHI = 0;
        private int mID_SERVICIO = 0;
        private int mID_SERVREC_TIPO_VEHI = 0;

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

        public int ID_SERVICIO
        {
            get
            {
                return mID_SERVICIO;
            }
            set
            {
                mID_SERVICIO = value;
            }
        }

        public int ID_SERVREC_TIPO_VEHI
        {
            get
            {
                return mID_SERVREC_TIPO_VEHI;
            }
            set
            {
                mID_SERVREC_TIPO_VEHI = value;
            }
        }

        SERVRECO_TIPO_VEHICULO()
        {
        }

        SERVRECO_TIPO_VEHICULO(int ID_RECO_TIPO_VEHI, int ID_SERVICIO, int ID_SERVREC_TIPO_VEHI)
        {
            mID_RECO_TIPO_VEHI = ID_RECO_TIPO_VEHI;
            mID_SERVICIO = ID_SERVICIO;
            mID_SERVREC_TIPO_VEHI = ID_SERVREC_TIPO_VEHI;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
