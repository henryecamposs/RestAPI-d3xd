using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoEgresoIngreso : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";
        private double mMontoMaximo = 0.0;
        private double mMontoMinimo = 0.0;
        private string mArchivoAsociado = "";
        private bool mEsFiscal = false;
        private bool mEsImprimeRecibo = false;
        private bool mEsPideAutorizacion = false;
        private bool mEsPideComentario = false;
        private bool mEsPideID_asociado = false;
        private bool mEsPideNombreEntrega = false;
        private bool mEsPideNombreRecibe = false;
        private bool mEsPideNroDoc_Asociado = false;
        private bool mEsEgreso = false;
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

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
            }
        }

        public Double MontoMaximo
        {
            get
            {
                return mMontoMaximo;
            }
            set
            {
                mMontoMaximo = value;
            }
        }

        public Double MontoMinimo
        {
            get
            {
                return mMontoMinimo;
            }
            set
            {
                mMontoMinimo = value;
            }
        }

        public string ArchivoAsociado
        {
            get
            {
                return mArchivoAsociado;
            }
            set
            {
                mArchivoAsociado = value;
            }
        }

        public Boolean EsFiscal
        {
            get
            {
                return mEsFiscal;
            }
            set
            {
                mEsFiscal = value;
            }
        }

        public Boolean EsImprimeRecibo
        {
            get
            {
                return mEsImprimeRecibo;
            }
            set
            {
                mEsImprimeRecibo = value;
            }
        }

        public Boolean EsPideAutorizacion
        {
            get
            {
                return mEsPideAutorizacion;
            }
            set
            {
                mEsPideAutorizacion = value;
            }
        }

        public Boolean EsPideComentario
        {
            get
            {
                return mEsPideComentario;
            }
            set
            {
                mEsPideComentario = value;
            }
        }

        public Boolean EsPideID_asociado
        {
            get
            {
                return mEsPideID_asociado;
            }
            set
            {
                mEsPideID_asociado = value;
            }
        }

        public Boolean EsPideNombreEntrega
        {
            get
            {
                return mEsPideNombreEntrega;
            }
            set
            {
                mEsPideNombreEntrega = value;
            }
        }

        public Boolean EsPideNombreRecibe
        {
            get
            {
                return mEsPideNombreRecibe;
            }
            set
            {
                mEsPideNombreRecibe = value;
            }
        }

        public Boolean EsPideNroDoc_Asociado
        {
            get
            {
                return mEsPideNroDoc_Asociado;
            }
            set
            {
                mEsPideNroDoc_Asociado = value;
            }
        }

        public Boolean EsEgreso
        {
            get
            {
                return mEsEgreso;
            }
            set
            {
                mEsEgreso = value;
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

        TipoEgresoIngreso()
        {
        }

        TipoEgresoIngreso(int ID, string Descripcion, double MontoMaximo, double MontoMinimo, string ArchivoAsociado, bool esFiscal, bool esImprimeRecibo, bool esPideAutorizacion, bool esPideComentario, bool esPideID_asociado, bool esPideNombreEntrega, bool esPideNombreRecibe, bool esPideNroDoc_Asociado, bool esEgreso, bool esActivo)
        {
            mID = ID;
            mDescripcion = Descripcion;
            mMontoMaximo = MontoMaximo;
            mMontoMinimo = MontoMinimo;
            mArchivoAsociado = ArchivoAsociado;
            mEsFiscal = EsFiscal;
            mEsImprimeRecibo = EsImprimeRecibo;
            mEsPideAutorizacion = EsPideAutorizacion;
            mEsPideComentario = EsPideComentario;
            mEsPideID_asociado = EsPideID_asociado;
            mEsPideNombreEntrega = EsPideNombreEntrega;
            mEsPideNombreRecibe = EsPideNombreRecibe;
            mEsPideNroDoc_Asociado = EsPideNroDoc_Asociado;
            mEsEgreso = EsEgreso;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
