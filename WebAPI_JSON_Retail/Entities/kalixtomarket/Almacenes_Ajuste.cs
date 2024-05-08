using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Almacenes_Ajuste : ICloneable
    {

        private int mID = 0;
        private int mId_Almacen = 0;
        private int mId_Proveedor = 0;
        private int mId_Usuario = 0;
        private int mId_defTipoAjuste = 0;
        private string mComentario = "";
        private string mResponsable = "";
        private string mNroDocumento = "";
        private int mNroControl = 0;
        private DateTime mFechaAjuste = new DateTime(2000, 01, 01);
        private DateTime mFechaActual = new DateTime(2000, 01, 01);
        private int mNroItems = 0;
        private bool mEsEnEspera =false;
        private bool mEsActivo =false;

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

        public int Id_Almacen
        {
            get
            {
                return mId_Almacen;
            }
            set
            {
                mId_Almacen = value;
            }
        }

        public int Id_Proveedor
        {
            get
            {
                return mId_Proveedor;
            }
            set
            {
                mId_Proveedor = value;
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

        public int Id_defTipoAjuste
        {
            get
            {
                return mId_defTipoAjuste;
            }
            set
            {
                mId_defTipoAjuste = value;
            }
        }

        public string Comentario
        {
            get
            {
                return mComentario;
            }
            set
            {
                mComentario = value;
            }
        }

        public string Responsable
        {
            get
            {
                return mResponsable;
            }
            set
            {
                mResponsable = value;
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

        public int NroControl
        {
            get
            {
                return mNroControl;
            }
            set
            {
                mNroControl = value;
            }
        }

        public DateTime FechaAjuste
        {
            get
            {
                return mFechaAjuste;
            }
            set
            {
                mFechaAjuste = value;
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

        Almacenes_Ajuste()
        {
        }

        Almacenes_Ajuste(int ID, int id_Almacen, int id_Proveedor, int id_Usuario, int id_defTipoAjuste, string Comentario, string Responsable, string NroDocumento, int NroControl, DateTime FechaAjuste, DateTime FechaActual, int NroItems, bool esEnEspera, bool esActivo)
        {
            mID = ID;
            mId_Almacen = Id_Almacen;
            mId_Proveedor = Id_Proveedor;
            mId_Usuario = Id_Usuario;
            mId_defTipoAjuste = Id_defTipoAjuste;
            mComentario = Comentario;
            mResponsable = Responsable;
            mNroDocumento = NroDocumento;
            mNroControl = NroControl;
            mFechaAjuste = FechaAjuste;
            mFechaActual = FechaActual;
            mNroItems = NroItems;
            mEsEnEspera = EsEnEspera;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
