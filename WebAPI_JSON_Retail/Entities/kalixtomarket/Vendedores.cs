using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Vendedores : ICloneable
    {

        private int mID = 0;
        private int mId_Empleado = 0;
        private string mNombre = "";
        private string mCodigo = "";
        private string mDireccion = "";
        private string mTelefono = "";
        private string mEmail = "";
        private string mFax = "";
        private double mPComisionVentasPrecio1 = 0.0;
        private double mPComisionVentasPrecio2 = 0.0;
        private double mPComisionVentasPrecio3 = 0.0;
        private double mPComisionVentasPrecioMayor = 0.0;
        private double mPComisionVentasMinimo = 0.0;
        private double mPComisionCobroPrecio1 = 0.0;
        private double mPComisionCobroPrecio2 = 0.0;
        private double mPComisionCobroPrecio3 = 0.0;
        private double mPComisionCobroPrecioMayor = 0.0;
        private double mPComisionCobroMinimo = 0.0;
        private double mPComisionServicioPrecio1 = 0.0;
        private double mPComisionServicioPrecio2 = 0.0;
        private double mPComisionServicioPrecio3 = 0.0;
        private double mPComisionServicioMayor = 0.0;
        private double mPComisionServicioPrecioMinimo = 0.0;
        private double mPComisionUtilidad = 0.0;
        private double mPComisionCobroGral = 0.0;
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

        public int Id_Empleado
        {
            get
            {
                return mId_Empleado;
            }
            set
            {
                mId_Empleado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return mNombre;
            }
            set
            {
                mNombre = value;
            }
        }

        public string Codigo
        {
            get
            {
                return mCodigo;
            }
            set
            {
                mCodigo = value;
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

        public string Telefono
        {
            get
            {
                return mTelefono;
            }
            set
            {
                mTelefono = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Fax
        {
            get
            {
                return mFax;
            }
            set
            {
                mFax = value;
            }
        }

        public Double PComisionVentasPrecio1
        {
            get
            {
                return mPComisionVentasPrecio1;
            }
            set
            {
                mPComisionVentasPrecio1 = value;
            }
        }

        public Double PComisionVentasPrecio2
        {
            get
            {
                return mPComisionVentasPrecio2;
            }
            set
            {
                mPComisionVentasPrecio2 = value;
            }
        }

        public Double PComisionVentasPrecio3
        {
            get
            {
                return mPComisionVentasPrecio3;
            }
            set
            {
                mPComisionVentasPrecio3 = value;
            }
        }

        public Double PComisionVentasPrecioMayor
        {
            get
            {
                return mPComisionVentasPrecioMayor;
            }
            set
            {
                mPComisionVentasPrecioMayor = value;
            }
        }

        public Double PComisionVentasMinimo
        {
            get
            {
                return mPComisionVentasMinimo;
            }
            set
            {
                mPComisionVentasMinimo = value;
            }
        }

        public Double PComisionCobroPrecio1
        {
            get
            {
                return mPComisionCobroPrecio1;
            }
            set
            {
                mPComisionCobroPrecio1 = value;
            }
        }

        public Double PComisionCobroPrecio2
        {
            get
            {
                return mPComisionCobroPrecio2;
            }
            set
            {
                mPComisionCobroPrecio2 = value;
            }
        }

        public Double PComisionCobroPrecio3
        {
            get
            {
                return mPComisionCobroPrecio3;
            }
            set
            {
                mPComisionCobroPrecio3 = value;
            }
        }

        public Double PComisionCobroPrecioMayor
        {
            get
            {
                return mPComisionCobroPrecioMayor;
            }
            set
            {
                mPComisionCobroPrecioMayor = value;
            }
        }

        public Double PComisionCobroMinimo
        {
            get
            {
                return mPComisionCobroMinimo;
            }
            set
            {
                mPComisionCobroMinimo = value;
            }
        }

        public Double PComisionServicioPrecio1
        {
            get
            {
                return mPComisionServicioPrecio1;
            }
            set
            {
                mPComisionServicioPrecio1 = value;
            }
        }

        public Double PComisionServicioPrecio2
        {
            get
            {
                return mPComisionServicioPrecio2;
            }
            set
            {
                mPComisionServicioPrecio2 = value;
            }
        }

        public Double PComisionServicioPrecio3
        {
            get
            {
                return mPComisionServicioPrecio3;
            }
            set
            {
                mPComisionServicioPrecio3 = value;
            }
        }

        public Double PComisionServicioMayor
        {
            get
            {
                return mPComisionServicioMayor;
            }
            set
            {
                mPComisionServicioMayor = value;
            }
        }

        public Double PComisionServicioPrecioMinimo
        {
            get
            {
                return mPComisionServicioPrecioMinimo;
            }
            set
            {
                mPComisionServicioPrecioMinimo = value;
            }
        }

        public Double PComisionUtilidad
        {
            get
            {
                return mPComisionUtilidad;
            }
            set
            {
                mPComisionUtilidad = value;
            }
        }

        public Double PComisionCobroGral
        {
            get
            {
                return mPComisionCobroGral;
            }
            set
            {
                mPComisionCobroGral = value;
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

        Vendedores()
        {
        }

        Vendedores(int ID, int id_Empleado, string Nombre, string Codigo, string Direccion, string Telefono, string Email, string Fax, double PComisionVentasPrecio1, double PComisionVentasPrecio2, double PComisionVentasPrecio3, double PComisionVentasPrecioMayor, double PComisionVentasMinimo, double PComisionCobroPrecio1, double PComisionCobroPrecio2, double PComisionCobroPrecio3, double PComisionCobroPrecioMayor, double PComisionCobroMinimo, double PComisionServicioPrecio1, double PComisionServicioPrecio2, double PComisionServicioPrecio3, double PComisionServicioMayor, double PComisionServicioPrecioMinimo, double PComisionUtilidad, double PComisionCobroGral, bool esActivo)
        {
            mID = ID;
            mId_Empleado = Id_Empleado;
            mNombre = Nombre;
            mCodigo = Codigo;
            mDireccion = Direccion;
            mTelefono = Telefono;
            mEmail = Email;
            mFax = Fax;
            mPComisionVentasPrecio1 = PComisionVentasPrecio1;
            mPComisionVentasPrecio2 = PComisionVentasPrecio2;
            mPComisionVentasPrecio3 = PComisionVentasPrecio3;
            mPComisionVentasPrecioMayor = PComisionVentasPrecioMayor;
            mPComisionVentasMinimo = PComisionVentasMinimo;
            mPComisionCobroPrecio1 = PComisionCobroPrecio1;
            mPComisionCobroPrecio2 = PComisionCobroPrecio2;
            mPComisionCobroPrecio3 = PComisionCobroPrecio3;
            mPComisionCobroPrecioMayor = PComisionCobroPrecioMayor;
            mPComisionCobroMinimo = PComisionCobroMinimo;
            mPComisionServicioPrecio1 = PComisionServicioPrecio1;
            mPComisionServicioPrecio2 = PComisionServicioPrecio2;
            mPComisionServicioPrecio3 = PComisionServicioPrecio3;
            mPComisionServicioMayor = PComisionServicioMayor;
            mPComisionServicioPrecioMinimo = PComisionServicioPrecioMinimo;
            mPComisionUtilidad = PComisionUtilidad;
            mPComisionCobroGral = PComisionCobroGral;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
