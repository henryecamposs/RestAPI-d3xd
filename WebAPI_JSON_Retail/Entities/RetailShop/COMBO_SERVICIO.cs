using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class COMBO_SERVICIO : ICloneable
    {

        private string mDescr = "";
        private int mId_combo_ser = 0;

        public string Descr
        {
            get
            {
                return mDescr;
            }
            set
            {
                mDescr = value;
            }
        }

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

        COMBO_SERVICIO()
        {
        }

        COMBO_SERVICIO(string descr, int id_combo_ser)
        {
            mDescr = Descr;
            mId_combo_ser = Id_combo_ser;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
