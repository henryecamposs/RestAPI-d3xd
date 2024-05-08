using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Estaciones_Reportes : ICloneable
    {

        private int mID = 0;
        private int mId_Estacion = 0;
        private string mArch_CheckIn = "";
        private string mArch_CheckOut = "";
        private string mArch_Clientes = "";
        private string mArch_Facturas = "";
        private string mArch_Habitaciones = "";
        private string mArch_Movimientos = "";
        private string mArch_PlanesTarifas = "";
        private string mArch_Reservas = "";
        private string mArch_Servicios = "";
        private string mImpReporte_CheckIn = "";
        private string mImpReporte_CheckOut = "";
        private string mImpReporte_Clientes = "";
        private string mImpReporte_Facturas = "";
        private string mImpReporte_Habitaciones = "";
        private string mImpReporte_Movimientos = "";
        private string mImpReporte_PlanesTarifas = "";
        private string mImpReporte_Reservas = "";
        private string mImpReporte_Servicios = "";
        private int mNCopias_CheckIn = 0;
        private int mNCopias_Checkout = 0;
        private int mNCopias_Clientes = 0;
        private int mNCopias_Facturas = 0;
        private int mNCopias_Habitaciones = 0;
        private int mNCopias_Movimientos = 0;
        private int mNCopias_PlanesTarifas = 0;
        private int mNCopias_Reservas = 0;
        private int mNCopias_Servicios = 0;

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

        public string Arch_CheckIn
        {
            get
            {
                return mArch_CheckIn;
            }
            set
            {
                mArch_CheckIn = value;
            }
        }

        public string Arch_CheckOut
        {
            get
            {
                return mArch_CheckOut;
            }
            set
            {
                mArch_CheckOut = value;
            }
        }

        public string Arch_Clientes
        {
            get
            {
                return mArch_Clientes;
            }
            set
            {
                mArch_Clientes = value;
            }
        }

        public string Arch_Facturas
        {
            get
            {
                return mArch_Facturas;
            }
            set
            {
                mArch_Facturas = value;
            }
        }

        public string Arch_Habitaciones
        {
            get
            {
                return mArch_Habitaciones;
            }
            set
            {
                mArch_Habitaciones = value;
            }
        }

        public string Arch_Movimientos
        {
            get
            {
                return mArch_Movimientos;
            }
            set
            {
                mArch_Movimientos = value;
            }
        }

        public string Arch_PlanesTarifas
        {
            get
            {
                return mArch_PlanesTarifas;
            }
            set
            {
                mArch_PlanesTarifas = value;
            }
        }

        public string Arch_Reservas
        {
            get
            {
                return mArch_Reservas;
            }
            set
            {
                mArch_Reservas = value;
            }
        }

        public string Arch_Servicios
        {
            get
            {
                return mArch_Servicios;
            }
            set
            {
                mArch_Servicios = value;
            }
        }

        public string ImpReporte_CheckIn
        {
            get
            {
                return mImpReporte_CheckIn;
            }
            set
            {
                mImpReporte_CheckIn = value;
            }
        }

        public string ImpReporte_CheckOut
        {
            get
            {
                return mImpReporte_CheckOut;
            }
            set
            {
                mImpReporte_CheckOut = value;
            }
        }

        public string ImpReporte_Clientes
        {
            get
            {
                return mImpReporte_Clientes;
            }
            set
            {
                mImpReporte_Clientes = value;
            }
        }

        public string ImpReporte_Facturas
        {
            get
            {
                return mImpReporte_Facturas;
            }
            set
            {
                mImpReporte_Facturas = value;
            }
        }

        public string ImpReporte_Habitaciones
        {
            get
            {
                return mImpReporte_Habitaciones;
            }
            set
            {
                mImpReporte_Habitaciones = value;
            }
        }

        public string ImpReporte_Movimientos
        {
            get
            {
                return mImpReporte_Movimientos;
            }
            set
            {
                mImpReporte_Movimientos = value;
            }
        }

        public string ImpReporte_PlanesTarifas
        {
            get
            {
                return mImpReporte_PlanesTarifas;
            }
            set
            {
                mImpReporte_PlanesTarifas = value;
            }
        }

        public string ImpReporte_Reservas
        {
            get
            {
                return mImpReporte_Reservas;
            }
            set
            {
                mImpReporte_Reservas = value;
            }
        }

        public string ImpReporte_Servicios
        {
            get
            {
                return mImpReporte_Servicios;
            }
            set
            {
                mImpReporte_Servicios = value;
            }
        }

        public int NCopias_CheckIn
        {
            get
            {
                return mNCopias_CheckIn;
            }
            set
            {
                mNCopias_CheckIn = value;
            }
        }

        public int NCopias_Checkout
        {
            get
            {
                return mNCopias_Checkout;
            }
            set
            {
                mNCopias_Checkout = value;
            }
        }

        public int NCopias_Clientes
        {
            get
            {
                return mNCopias_Clientes;
            }
            set
            {
                mNCopias_Clientes = value;
            }
        }

        public int NCopias_Facturas
        {
            get
            {
                return mNCopias_Facturas;
            }
            set
            {
                mNCopias_Facturas = value;
            }
        }

        public int NCopias_Habitaciones
        {
            get
            {
                return mNCopias_Habitaciones;
            }
            set
            {
                mNCopias_Habitaciones = value;
            }
        }

        public int NCopias_Movimientos
        {
            get
            {
                return mNCopias_Movimientos;
            }
            set
            {
                mNCopias_Movimientos = value;
            }
        }

        public int NCopias_PlanesTarifas
        {
            get
            {
                return mNCopias_PlanesTarifas;
            }
            set
            {
                mNCopias_PlanesTarifas = value;
            }
        }

        public int NCopias_Reservas
        {
            get
            {
                return mNCopias_Reservas;
            }
            set
            {
                mNCopias_Reservas = value;
            }
        }

        public int NCopias_Servicios
        {
            get
            {
                return mNCopias_Servicios;
            }
            set
            {
                mNCopias_Servicios = value;
            }
        }

        Estaciones_Reportes()
        {
        }

        Estaciones_Reportes(int ID, int id_Estacion, string arch_CheckIn, string arch_CheckOut, string arch_Clientes, string arch_Facturas, string arch_Habitaciones, string arch_Movimientos, string arch_PlanesTarifas, string arch_Reservas, string arch_Servicios, string ImpReporte_CheckIn, string ImpReporte_CheckOut, string ImpReporte_Clientes, string ImpReporte_Facturas, string ImpReporte_Habitaciones, string ImpReporte_Movimientos, string ImpReporte_PlanesTarifas, string ImpReporte_Reservas, string ImpReporte_Servicios, int nCopias_CheckIn, int nCopias_Checkout, int nCopias_Clientes, int nCopias_Facturas, int nCopias_Habitaciones, int nCopias_Movimientos, int nCopias_PlanesTarifas, int nCopias_Reservas, int nCopias_Servicios)
        {
            mID = ID;
            mId_Estacion = Id_Estacion;
            mArch_CheckIn = Arch_CheckIn;
            mArch_CheckOut = Arch_CheckOut;
            mArch_Clientes = Arch_Clientes;
            mArch_Facturas = Arch_Facturas;
            mArch_Habitaciones = Arch_Habitaciones;
            mArch_Movimientos = Arch_Movimientos;
            mArch_PlanesTarifas = Arch_PlanesTarifas;
            mArch_Reservas = Arch_Reservas;
            mArch_Servicios = Arch_Servicios;
            mImpReporte_CheckIn = ImpReporte_CheckIn;
            mImpReporte_CheckOut = ImpReporte_CheckOut;
            mImpReporte_Clientes = ImpReporte_Clientes;
            mImpReporte_Facturas = ImpReporte_Facturas;
            mImpReporte_Habitaciones = ImpReporte_Habitaciones;
            mImpReporte_Movimientos = ImpReporte_Movimientos;
            mImpReporte_PlanesTarifas = ImpReporte_PlanesTarifas;
            mImpReporte_Reservas = ImpReporte_Reservas;
            mImpReporte_Servicios = ImpReporte_Servicios;
            mNCopias_CheckIn = NCopias_CheckIn;
            mNCopias_Checkout = NCopias_Checkout;
            mNCopias_Clientes = NCopias_Clientes;
            mNCopias_Facturas = NCopias_Facturas;
            mNCopias_Habitaciones = NCopias_Habitaciones;
            mNCopias_Movimientos = NCopias_Movimientos;
            mNCopias_PlanesTarifas = NCopias_PlanesTarifas;
            mNCopias_Reservas = NCopias_Reservas;
            mNCopias_Servicios = NCopias_Servicios;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
