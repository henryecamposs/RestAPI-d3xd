using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes_Saldo : ICloneable
    {

        private int mID = 0;
        private int mId_Cliente = 0;
        private string mPeriodoMensualCobro = "";
        private double mSaldoInicial = 0.0;
        private double mMontoDebitos = 0.0;
        private double mMontoCreditos = 0.0;
        private double mMontoSaldoActual = 0.0;
        private double mMontoAnticipos = 0.0;
        private double mMontoSaldoAnticipos = 0.0;
        private double mMontoSaldoNotasCredito = 0.0;

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

        public string PeriodoMensualCobro
        {
            get
            {
                return mPeriodoMensualCobro;
            }
            set
            {
                mPeriodoMensualCobro = value;
            }
        }

        public Double SaldoInicial
        {
            get
            {
                return mSaldoInicial;
            }
            set
            {
                mSaldoInicial = value;
            }
        }

        public Double MontoDebitos
        {
            get
            {
                return mMontoDebitos;
            }
            set
            {
                mMontoDebitos = value;
            }
        }

        public Double MontoCreditos
        {
            get
            {
                return mMontoCreditos;
            }
            set
            {
                mMontoCreditos = value;
            }
        }

        public Double MontoSaldoActual
        {
            get
            {
                return mMontoSaldoActual;
            }
            set
            {
                mMontoSaldoActual = value;
            }
        }

        public Double MontoAnticipos
        {
            get
            {
                return mMontoAnticipos;
            }
            set
            {
                mMontoAnticipos = value;
            }
        }

        public Double MontoSaldoAnticipos
        {
            get
            {
                return mMontoSaldoAnticipos;
            }
            set
            {
                mMontoSaldoAnticipos = value;
            }
        }

        public Double MontoSaldoNotasCredito
        {
            get
            {
                return mMontoSaldoNotasCredito;
            }
            set
            {
                mMontoSaldoNotasCredito = value;
            }
        }

        Clientes_Saldo()
        {
        }

        Clientes_Saldo(int ID, int id_Cliente, string PeriodoMensualCobro, double SaldoInicial, double MontoDebitos, double MontoCreditos, double MontoSaldoActual, double MontoAnticipos, double MontoSaldoAnticipos, double MontoSaldoNotasCredito)
        {
            mID = ID;
            mId_Cliente = Id_Cliente;
            mPeriodoMensualCobro = PeriodoMensualCobro;
            mSaldoInicial = SaldoInicial;
            mMontoDebitos = MontoDebitos;
            mMontoCreditos = MontoCreditos;
            mMontoSaldoActual = MontoSaldoActual;
            mMontoAnticipos = MontoAnticipos;
            mMontoSaldoAnticipos = MontoSaldoAnticipos;
            mMontoSaldoNotasCredito = MontoSaldoNotasCredito;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
