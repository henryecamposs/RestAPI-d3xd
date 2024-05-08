using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Cajas_Cortes : ICloneable
    {

        private int mID = 0;
        private int mId_Caja = 0;
        private int mId_Estaciones_Sesion = 0;
        private int mId_Usuario = 0;
        private int mId_FacturaFinal = 0;
        private int mId_FacturaInicial = 0;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private DateTime mFechaApertura = new DateTime(2000, 01, 01);
        private DateTime mFechaCierre = new DateTime(2000, 01, 01);
        private double mMontoApetura = 0.0;
        private double mMontoCuadreCaja = 0.0;
        private int mNroCorte = 0;
        private double mMontoTotalBaseIVA0 = 0.0;
        private double mMontoTotalBaseIVA1 = 0.0;
        private double mMontoTotalBaseIVA2 = 0.0;
        private double mMontoTotalBaseIVA3 = 0.0;
        private double mMontoTasaIVA0 = 0.0;
        private double mMontoTasaIVA1 = 0.0;
        private double mMontoTasaIVA2 = 0.0;
        private double mMontoTasaIVA3 = 0.0;

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

        public int Id_Caja
        {
            get
            {
                return mId_Caja;
            }
            set
            {
                mId_Caja = value;
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

        public int Id_Usuario
        {
            get
            {
                return mId_Usuario;
            }
            set
            {
                mId_Usuario = value;
            }
        }

        public int Id_FacturaFinal
        {
            get
            {
                return mId_FacturaFinal;
            }
            set
            {
                mId_FacturaFinal = value;
            }
        }

        public int Id_FacturaInicial
        {
            get
            {
                return mId_FacturaInicial;
            }
            set
            {
                mId_FacturaInicial = value;
            }
        }

        public DateTime FechaActual
        {
            get
            {
                return mFechaActual;
            }
            set
            {
                mFechaActual = value;
            }
        }

        public DateTime FechaApertura
        {
            get
            {
                return mFechaApertura;
            }
            set
            {
                mFechaApertura = value;
            }
        }

        public DateTime FechaCierre
        {
            get
            {
                return mFechaCierre;
            }
            set
            {
                mFechaCierre = value;
            }
        }

        public Double MontoApetura
        {
            get
            {
                return mMontoApetura;
            }
            set
            {
                mMontoApetura = value;
            }
        }

        public Double MontoCuadreCaja
        {
            get
            {
                return mMontoCuadreCaja;
            }
            set
            {
                mMontoCuadreCaja = value;
            }
        }

        public int NroCorte
        {
            get
            {
                return mNroCorte;
            }
            set
            {
                mNroCorte = value;
            }
        }

        public Double MontoTotalBaseIVA0
        {
            get
            {
                return mMontoTotalBaseIVA0;
            }
            set
            {
                mMontoTotalBaseIVA0 = value;
            }
        }

        public Double MontoTotalBaseIVA1
        {
            get
            {
                return mMontoTotalBaseIVA1;
            }
            set
            {
                mMontoTotalBaseIVA1 = value;
            }
        }

        public Double MontoTotalBaseIVA2
        {
            get
            {
                return mMontoTotalBaseIVA2;
            }
            set
            {
                mMontoTotalBaseIVA2 = value;
            }
        }

        public Double MontoTotalBaseIVA3
        {
            get
            {
                return mMontoTotalBaseIVA3;
            }
            set
            {
                mMontoTotalBaseIVA3 = value;
            }
        }

        public Double MontoTasaIVA0
        {
            get
            {
                return mMontoTasaIVA0;
            }
            set
            {
                mMontoTasaIVA0 = value;
            }
        }

        public Double MontoTasaIVA1
        {
            get
            {
                return mMontoTasaIVA1;
            }
            set
            {
                mMontoTasaIVA1 = value;
            }
        }

        public Double MontoTasaIVA2
        {
            get
            {
                return mMontoTasaIVA2;
            }
            set
            {
                mMontoTasaIVA2 = value;
            }
        }

        public Double MontoTasaIVA3
        {
            get
            {
                return mMontoTasaIVA3;
            }
            set
            {
                mMontoTasaIVA3 = value;
            }
        }

        Cajas_Cortes()
        {
        }

        Cajas_Cortes(int ID, int id_Caja, int id_Estaciones_Sesion, int id_Usuario, int id_FacturaFinal, int id_FacturaInicial, DateTime FechaActual, DateTime FechaApertura, DateTime FechaCierre, double MontoApetura, double MontoCuadreCaja, int NroCorte, double MontoTotalBaseIVA0, double MontoTotalBaseIVA1, double MontoTotalBaseIVA2, double MontoTotalBaseIVA3, double MontoTasaIVA0, double MontoTasaIVA1, double MontoTasaIVA2, double MontoTasaIVA3)
        {
            mID = ID;
            mId_Caja = Id_Caja;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mId_Usuario = Id_Usuario;
            mId_FacturaFinal = Id_FacturaFinal;
            mId_FacturaInicial = Id_FacturaInicial;
            mFechaActual = FechaActual;
            mFechaApertura = FechaApertura;
            mFechaCierre = FechaCierre;
            mMontoApetura = MontoApetura;
            mMontoCuadreCaja = MontoCuadreCaja;
            mNroCorte = NroCorte;
            mMontoTotalBaseIVA0 = MontoTotalBaseIVA0;
            mMontoTotalBaseIVA1 = MontoTotalBaseIVA1;
            mMontoTotalBaseIVA2 = MontoTotalBaseIVA2;
            mMontoTotalBaseIVA3 = MontoTotalBaseIVA3;
            mMontoTasaIVA0 = MontoTasaIVA0;
            mMontoTasaIVA1 = MontoTasaIVA1;
            mMontoTasaIVA2 = MontoTasaIVA2;
            mMontoTasaIVA3 = MontoTasaIVA3;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
