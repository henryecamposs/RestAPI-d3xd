using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVICIO_TIPO_COMBO : ICloneable
    {

        private int mId_combo_ser = 0;
        private int mId_serv_tipo_combo = 0;
        private int mId_servicio = 0;

        public int Id_combo_ser
        {
            get
            {
                return mId_combo_ser;
            }
            set
            {
                mId_combo_ser = value;
            }
        }

        public int Id_serv_tipo_combo
        {
            get
            {
                return mId_serv_tipo_combo;
            }
            set
            {
                mId_serv_tipo_combo = value;
            }
        }

        public int Id_servicio
        {
            get
            {
                return mId_servicio;
            }
            set
            {
                mId_servicio = value;
            }
        }

        SERVICIO_TIPO_COMBO()
        {
        }

        SERVICIO_TIPO_COMBO(int id_combo_ser, int id_serv_tipo_combo, int id_servicio)
        {
            mId_combo_ser = Id_combo_ser;
            mId_serv_tipo_combo = Id_serv_tipo_combo;
            mId_servicio = Id_servicio;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
