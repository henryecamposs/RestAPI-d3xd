using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Dispositivos : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private string mBus = "";
        private string mBusType = "";
        private string mClassName = "";
        private string mDevice = "";
        private string mSubSystemDeviceName = "";
        private string mSubSystemVendor = "";
        private string mVendor = "";
        private string mWindowsName = "";
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

        public int Id_Estacion
        {
            get
            {
                return mId_Estacion;
            }
            set
            {
                mId_Estacion = value;
            }
        }

        public string Bus
        {
            get
            {
                return mBus;
            }
            set
            {
                mBus = value;
            }
        }

        public string BusType
        {
            get
            {
                return mBusType;
            }
            set
            {
                mBusType = value;
            }
        }

        public string ClassName
        {
            get
            {
                return mClassName;
            }
            set
            {
                mClassName = value;
            }
        }

        public string Device
        {
            get
            {
                return mDevice;
            }
            set
            {
                mDevice = value;
            }
        }

        public string SubSystemDeviceName
        {
            get
            {
                return mSubSystemDeviceName;
            }
            set
            {
                mSubSystemDeviceName = value;
            }
        }

        public string SubSystemVendor
        {
            get
            {
                return mSubSystemVendor;
            }
            set
            {
                mSubSystemVendor = value;
            }
        }

        public string Vendor
        {
            get
            {
                return mVendor;
            }
            set
            {
                mVendor = value;
            }
        }

        public string WindowsName
        {
            get
            {
                return mWindowsName;
            }
            set
            {
                mWindowsName = value;
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

        Estaciones_Dispositivos()
        {
        }

        Estaciones_Dispositivos(int ID, int id_Estacion, string Bus, string BusType, string ClassName, string Device, string SubSystemDeviceName, string SubSystemVendor, string Vendor, string WindowsName, bool esActivo)
        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mBus = Bus;
            mBusType = BusType;
            mClassName = ClassName;
            mDevice = Device;
            mSubSystemDeviceName = SubSystemDeviceName;
            mSubSystemVendor = SubSystemVendor;
            mVendor = Vendor;
            mWindowsName = WindowsName;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
