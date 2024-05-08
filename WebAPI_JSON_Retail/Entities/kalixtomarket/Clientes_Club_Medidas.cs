using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes_Club_Medidas : ICloneable
    {

        private int mID = 0;
        private int mId_Cliente = 0;
        private int mId_Estaciones_Sesion = 0;
        private double mEspalda = 0.0;
        private double mBusto = 0.0;
        private double mBrazo = 0.0;
        private double mPecho = 0.0;
        private double mCintura = 0.0;
        private double mCaderas = 0.0;
        private double mGluteos = 0.0;
        private double mMusloSuperior = 0.0;
        private double mMusloMedio = 0.0;
        private double mPantorrilla = 0.0;
        private double mBiceps = 0.0;
        private double mTriceps = 0.0;
        private double mSubescapular = 0.0;
        private double mCrestaIliaca = 0.0;
        private double mCuerpoRapido = 0.0;
        private double mMasaGrasa = 0.0;
        private double mMasaMagra = 0.0;
        private double mIndiceMasaCorporal = 0.0;
        private double mConsumoMaximoOxigeno = 0.0;
        private bool mEsEspalda = false;
        private bool mEsBusto = false;
        private bool mEsBrazo = false;
        private bool mEsPecho = false;
        private bool mEsCintura = false;
        private bool mEsCaderas = false;
        private bool mEsGluteos = false;
        private bool mEsMusloSuperior = false;
        private bool mEsMusloMedio = false;
        private bool mEsPantorrila = false;
        private bool mEsBiceps = false;
        private bool mEsTriceps = false;
        private bool mEsSubescapular = false;
        private bool mEsCrestailiaca = false;
        private bool mEsCuerpoRapido = false;
        private bool mMasa_grasa_check = false;
        private bool mEsMasaMagra = false;
        private bool mEsIndiceMasaCorporal = false;
        private bool mEsConsumoMaximoOxigeno = false;
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private string mNota = "";
        private string mImagenArchivo = "";
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

        public Double Espalda
        {
            get
            {
                return mEspalda;
            }
            set
            {
                mEspalda = value;
            }
        }

        public Double Busto
        {
            get
            {
                return mBusto;
            }
            set
            {
                mBusto = value;
            }
        }

        public Double Brazo
        {
            get
            {
                return mBrazo;
            }
            set
            {
                mBrazo = value;
            }
        }

        public Double Pecho
        {
            get
            {
                return mPecho;
            }
            set
            {
                mPecho = value;
            }
        }

        public Double Cintura
        {
            get
            {
                return mCintura;
            }
            set
            {
                mCintura = value;
            }
        }

        public Double Caderas
        {
            get
            {
                return mCaderas;
            }
            set
            {
                mCaderas = value;
            }
        }

        public Double Gluteos
        {
            get
            {
                return mGluteos;
            }
            set
            {
                mGluteos = value;
            }
        }

        public Double MusloSuperior
        {
            get
            {
                return mMusloSuperior;
            }
            set
            {
                mMusloSuperior = value;
            }
        }

        public Double MusloMedio
        {
            get
            {
                return mMusloMedio;
            }
            set
            {
                mMusloMedio = value;
            }
        }

        public Double Pantorrilla
        {
            get
            {
                return mPantorrilla;
            }
            set
            {
                mPantorrilla = value;
            }
        }

        public Double Biceps
        {
            get
            {
                return mBiceps;
            }
            set
            {
                mBiceps = value;
            }
        }

        public Double Triceps
        {
            get
            {
                return mTriceps;
            }
            set
            {
                mTriceps = value;
            }
        }

        public Double Subescapular
        {
            get
            {
                return mSubescapular;
            }
            set
            {
                mSubescapular = value;
            }
        }

        public Double CrestaIliaca
        {
            get
            {
                return mCrestaIliaca;
            }
            set
            {
                mCrestaIliaca = value;
            }
        }

        public Double CuerpoRapido
        {
            get
            {
                return mCuerpoRapido;
            }
            set
            {
                mCuerpoRapido = value;
            }
        }

        public Double MasaGrasa
        {
            get
            {
                return mMasaGrasa;
            }
            set
            {
                mMasaGrasa = value;
            }
        }

        public Double MasaMagra
        {
            get
            {
                return mMasaMagra;
            }
            set
            {
                mMasaMagra = value;
            }
        }

        public Double IndiceMasaCorporal
        {
            get
            {
                return mIndiceMasaCorporal;
            }
            set
            {
                mIndiceMasaCorporal = value;
            }
        }

        public Double ConsumoMaximoOxigeno
        {
            get
            {
                return mConsumoMaximoOxigeno;
            }
            set
            {
                mConsumoMaximoOxigeno = value;
            }
        }

        public Boolean EsEspalda
        {
            get
            {
                return mEsEspalda;
            }
            set
            {
                mEsEspalda = value;
            }
        }

        public Boolean EsBusto
        {
            get
            {
                return mEsBusto;
            }
            set
            {
                mEsBusto = value;
            }
        }

        public Boolean EsBrazo
        {
            get
            {
                return mEsBrazo;
            }
            set
            {
                mEsBrazo = value;
            }
        }

        public Boolean EsPecho
        {
            get
            {
                return mEsPecho;
            }
            set
            {
                mEsPecho = value;
            }
        }

        public Boolean EsCintura
        {
            get
            {
                return mEsCintura;
            }
            set
            {
                mEsCintura = value;
            }
        }

        public Boolean EsCaderas
        {
            get
            {
                return mEsCaderas;
            }
            set
            {
                mEsCaderas = value;
            }
        }

        public Boolean EsGluteos
        {
            get
            {
                return mEsGluteos;
            }
            set
            {
                mEsGluteos = value;
            }
        }

        public Boolean EsMusloSuperior
        {
            get
            {
                return mEsMusloSuperior;
            }
            set
            {
                mEsMusloSuperior = value;
            }
        }

        public Boolean EsMusloMedio
        {
            get
            {
                return mEsMusloMedio;
            }
            set
            {
                mEsMusloMedio = value;
            }
        }

        public Boolean EsPantorrila
        {
            get
            {
                return mEsPantorrila;
            }
            set
            {
                mEsPantorrila = value;
            }
        }

        public Boolean EsBiceps
        {
            get
            {
                return mEsBiceps;
            }
            set
            {
                mEsBiceps = value;
            }
        }

        public Boolean EsTriceps
        {
            get
            {
                return mEsTriceps;
            }
            set
            {
                mEsTriceps = value;
            }
        }

        public Boolean EsSubescapular
        {
            get
            {
                return mEsSubescapular;
            }
            set
            {
                mEsSubescapular = value;
            }
        }

        public Boolean EsCrestailiaca
        {
            get
            {
                return mEsCrestailiaca;
            }
            set
            {
                mEsCrestailiaca = value;
            }
        }

        public Boolean EsCuerpoRapido
        {
            get
            {
                return mEsCuerpoRapido;
            }
            set
            {
                mEsCuerpoRapido = value;
            }
        }

        public Boolean Masa_grasa_check
        {
            get
            {
                return mMasa_grasa_check;
            }
            set
            {
                mMasa_grasa_check = value;
            }
        }

        public Boolean EsMasaMagra
        {
            get
            {
                return mEsMasaMagra;
            }
            set
            {
                mEsMasaMagra = value;
            }
        }

        public Boolean EsIndiceMasaCorporal
        {
            get
            {
                return mEsIndiceMasaCorporal;
            }
            set
            {
                mEsIndiceMasaCorporal = value;
            }
        }

        public Boolean EsConsumoMaximoOxigeno
        {
            get
            {
                return mEsConsumoMaximoOxigeno;
            }
            set
            {
                mEsConsumoMaximoOxigeno = value;
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

        public string ImagenArchivo
        {
            get
            {
                return mImagenArchivo;
            }
            set
            {
                mImagenArchivo = value;
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

        Clientes_Club_Medidas()
        {
        }

        Clientes_Club_Medidas(int ID, int Id_Cliente, int id_Estaciones_Sesion, double Espalda, double Busto, double Brazo, double Pecho, double Cintura, double Caderas, double Gluteos, double MusloSuperior, double MusloMedio, double Pantorrilla, double Biceps, double Triceps, double Subescapular, double CrestaIliaca, double CuerpoRapido, double MasaGrasa, double MasaMagra, double IndiceMasaCorporal, double ConsumoMaximoOxigeno, bool esEspalda, bool esBusto, bool esBrazo, bool esPecho, bool esCintura, bool esCaderas, bool esGluteos, bool esMusloSuperior, bool esMusloMedio, bool esPantorrila, bool esBiceps, bool esTriceps, bool esSubescapular, bool esCrestailiaca, bool esCuerpoRapido, bool masa_grasa_check, bool esMasaMagra, bool esIndiceMasaCorporal, bool esConsumoMaximoOxigeno, DateTime FechaActual, string Nota, string ImagenArchivo, bool esActivo)
        {
            mID = ID;
            mId_Cliente = Id_Cliente;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mEspalda = Espalda;
            mBusto = Busto;
            mBrazo = Brazo;
            mPecho = Pecho;
            mCintura = Cintura;
            mCaderas = Caderas;
            mGluteos = Gluteos;
            mMusloSuperior = MusloSuperior;
            mMusloMedio = MusloMedio;
            mPantorrilla = Pantorrilla;
            mBiceps = Biceps;
            mTriceps = Triceps;
            mSubescapular = Subescapular;
            mCrestaIliaca = CrestaIliaca;
            mCuerpoRapido = CuerpoRapido;
            mMasaGrasa = MasaGrasa;
            mMasaMagra = MasaMagra;
            mIndiceMasaCorporal = IndiceMasaCorporal;
            mConsumoMaximoOxigeno = ConsumoMaximoOxigeno;
            mEsEspalda = EsEspalda;
            mEsBusto = EsBusto;
            mEsBrazo = EsBrazo;
            mEsPecho = EsPecho;
            mEsCintura = EsCintura;
            mEsCaderas = EsCaderas;
            mEsGluteos = EsGluteos;
            mEsMusloSuperior = EsMusloSuperior;
            mEsMusloMedio = EsMusloMedio;
            mEsPantorrila = EsPantorrila;
            mEsBiceps = EsBiceps;
            mEsTriceps = EsTriceps;
            mEsSubescapular = EsSubescapular;
            mEsCrestailiaca = EsCrestailiaca;
            mEsCuerpoRapido = EsCuerpoRapido;
            mMasa_grasa_check = Masa_grasa_check;
            mEsMasaMagra = EsMasaMagra;
            mEsIndiceMasaCorporal = EsIndiceMasaCorporal;
            mEsConsumoMaximoOxigeno = EsConsumoMaximoOxigeno;
            mFechaActual = FechaActual;
            mNota = Nota;
            mImagenArchivo = ImagenArchivo;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
