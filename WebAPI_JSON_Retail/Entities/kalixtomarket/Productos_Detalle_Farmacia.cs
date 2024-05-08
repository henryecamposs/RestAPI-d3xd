using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Productos_Detalle_Farmacia : ICloneable
    {

        private int mID = 0;
        private int mId_Producto = 0;
        private int mId_Lote = 0;
        private int mId_defTipoRecipeMedico = 0;
        private DateTime mFechaVencimiento = new DateTime(2000, 01, 01);
        private bool mEsPideRecipeMedico = false;

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

        public int Id_Producto
        {
            get
            {
                return mId_Producto;
            }
            set
            {
                mId_Producto = value;
            }
        }

        public int Id_Lote
        {
            get
            {
                return mId_Lote;
            }
            set
            {
                mId_Lote = value;
            }
        }

        public int Id_defTipoRecipeMedico
        {
            get
            {
                return mId_defTipoRecipeMedico;
            }
            set
            {
                mId_defTipoRecipeMedico = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return mFechaVencimiento;
            }
            set
            {
                mFechaVencimiento = value;
            }
        }

        public Boolean EsPideRecipeMedico
        {
            get
            {
                return mEsPideRecipeMedico;
            }
            set
            {
                mEsPideRecipeMedico = value;
            }
        }

        Productos_Detalle_Farmacia()
        {
        }

        Productos_Detalle_Farmacia(int ID, int Id_Producto, int Id_Lote, int Id_defTipoRecipeMedico, DateTime FechaVencimiento, bool esPideRecipeMedico)
        {
            mID = ID;
            mId_Producto = Id_Producto;
            mId_Lote = Id_Lote;
            mId_defTipoRecipeMedico = Id_defTipoRecipeMedico;
            mFechaVencimiento = FechaVencimiento;
            mEsPideRecipeMedico = EsPideRecipeMedico;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
