using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Clientes_Ret_ISRL : ICloneable
    {

        private int mID = 0;
        private int mId_Cliente = 0;
        private int mId_Estaciones_Sesion = 0;
        private int mId_defTipoDocumento = 0;
        private int mId_defTipoImpresion = 0;
        private string mNroDocumento = "";
        private double mMontoBase = 0.0;
        private double mMontoIVA = 0.0;
        private double mMontoExento = 0.0;
        private double mMontoBaseRetencion = 0.0;
        private double mMontoRetencionAplicada = 0.0;
        private int mNroItems = 0;
        private DateTime mFechaEmision = new DateTime(2000, 01, 01);
        private bool mEsEnEspera = false;

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

        public int Id_defTipoDocumento
        {
            get
            {
                return mId_defTipoDocumento;
            }
            set
            {
                mId_defTipoDocumento = value;
            }
        }

        public int Id_defTipoImpresion
        {
            get
            {
                return mId_defTipoImpresion;
            }
            set
            {
                mId_defTipoImpresion = value;
            }
        }

        public string NroDocumento
        {
            get
            {
                return mNroDocumento;
            }
            set
            {
                mNroDocumento = value;
            }
        }

        public Double MontoBase
        {
            get
            {
                return mMontoBase;
            }
            set
            {
                mMontoBase = value;
            }
        }

        public Double MontoIVA
        {
            get
            {
                return mMontoIVA;
            }
            set
            {
                mMontoIVA = value;
            }
        }

        public Double MontoExento
        {
            get
            {
                return mMontoExento;
            }
            set
            {
                mMontoExento = value;
            }
        }

        public Double MontoBaseRetencion
        {
            get
            {
                return mMontoBaseRetencion;
            }
            set
            {
                mMontoBaseRetencion = value;
            }
        }

        public Double MontoRetencionAplicada
        {
            get
            {
                return mMontoRetencionAplicada;
            }
            set
            {
                mMontoRetencionAplicada = value;
            }
        }

        public int NroItems
        {
            get
            {
                return mNroItems;
            }
            set
            {
                mNroItems = value;
            }
        }

        public DateTime FechaEmision
        {
            get
            {
                return mFechaEmision;
            }
            set
            {
                mFechaEmision = value;
            }
        }

        public Boolean EsEnEspera
        {
            get
            {
                return mEsEnEspera;
            }
            set
            {
                mEsEnEspera = value;
            }
        }

        Clientes_Ret_ISRL()
        {
        }

        Clientes_Ret_ISRL(int ID, int id_Cliente, int id_Estaciones_Sesion, int id_defTipoDocumento, int id_defTipoImpresion, string NroDocumento, double MontoBase, double MontoIVA, double MontoExento, double MontoBaseRetencion, double MontoRetencionAplicada, int nroItems, DateTime FechaEmision, bool esEnEspera)
        {
            mID = ID;
            mId_Cliente = Id_Cliente;
            mId_Estaciones_Sesion = Id_Estaciones_Sesion;
            mId_defTipoDocumento = Id_defTipoDocumento;
            mId_defTipoImpresion = Id_defTipoImpresion;
            mNroDocumento = NroDocumento;
            mMontoBase = MontoBase;
            mMontoIVA = MontoIVA;
            mMontoExento = MontoExento;
            mMontoBaseRetencion = MontoBaseRetencion;
            mMontoRetencionAplicada = MontoRetencionAplicada;
            mNroItems = NroItems;
            mFechaEmision = FechaEmision;
            mEsEnEspera = EsEnEspera;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
