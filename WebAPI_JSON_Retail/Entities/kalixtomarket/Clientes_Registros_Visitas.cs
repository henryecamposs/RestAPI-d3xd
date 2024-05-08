using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes_Registros_Visitas : ICloneable
    {

        private int mID = 0;
        private int mId_Cliente = 0;
        private int mId_Estaciones_Sesion = 0;
        private DateTime mFechaIngreso = new DateTime(2000, 01, 01);
        private DateTime mFechaSalida = new DateTime(2000, 01, 01);
        private string mNota = "";
        private string mFotoArchivo = "";
        private bool mEsEntrada = false;
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

        public int Id_Cliente
        {
            get
            {
                return mId_Cliente;
            }
            set
            {
                mId_Cliente = value;
            }
        }

        public int Id_Estaciones_Sesion
        {
            get
            {
                return mId_Estaciones_Sesion;
            }
            set
            {
                mId_Estaciones_Sesion = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return mFechaIngreso;
            }
            set
            {
                mFechaIngreso = value;
            }
        }

        public DateTime FechaSalida
        {
            get
            {
                return mFechaSalida;
            }
            set
            {
                mFechaSalida = value;
            }
        }

        public string Nota
        {
            get
            {
                return mNota;
            }
            set
            {
                mNota = value;
            }
        }

        public string FotoArchivo
        {
            get
            {
                return mFotoArchivo;
            }
            set
            {
                mFotoArchivo = value;
            }
        }

        public Boolean EsEntrada
        {
            get
            {
                return mEsEntrada;
            }
            set
            {
                mEsEntrada = value;
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

        Clientes_Registros_Visitas()
        {
        }

        Clientes_Registros_Visitas(int ID, int Id_Cliente, int id_Estaciones_Sesion, DateTime FechaIngreso, DateTime FechaSalida, string Nota, string FotoArchivo, bool esEntrada, bool esActivo)
        {
            mID = ID;
            mId_Cliente = Id_Cliente;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mFechaIngreso = FechaIngreso;
            mFechaSalida = FechaSalida;
            mNota = Nota;
            mFotoArchivo = FotoArchivo;
            mEsEntrada = EsEntrada;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
