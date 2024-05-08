using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Modulos : ICloneable
    {

        private int mID = 0;
        private int mId_defTema_modulo = 0;
        private string mDescripcion = "";
        private string mNombreArchivo = "";
        private int m_height = 0;
        private int m_left = 0;
        private bool m_modal = false;
        private int m_startposition = 0;
        private int m_top = 0;
        private int m_top_most = 0;
        private int m_width = 0;
        private int m_windowstate = 0;
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

        public int Id_defTema_modulo
        {
            get
            {
                return mId_defTema_modulo;
            }
            set
            {
                mId_defTema_modulo = value;
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

        public string NombreArchivo
        {
            get
            {
                return mNombreArchivo;
            }
            set
            {
                mNombreArchivo = value;
            }
        }

        public int _height
        {
            get
            {
                return m_height;
            }
            set
            {
                m_height = value;
            }
        }

        public int _left
        {
            get
            {
                return m_left;
            }
            set
            {
                m_left = value;
            }
        }

        public Boolean _modal
        {
            get
            {
                return m_modal;
            }
            set
            {
                m_modal = value;
            }
        }

        public int _startposition
        {
            get
            {
                return m_startposition;
            }
            set
            {
                m_startposition = value;
            }
        }

        public int _top
        {
            get
            {
                return m_top;
            }
            set
            {
                m_top = value;
            }
        }

        public int _top_most
        {
            get
            {
                return m_top_most;
            }
            set
            {
                m_top_most = value;
            }
        }

        public int _width
        {
            get
            {
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        public int _windowstate
        {
            get
            {
                return m_windowstate;
            }
            set
            {
                m_windowstate = value;
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

        Modulos()
        {
        }

        Modulos(int ID, int id_defTema_modulo, string Descripcion, string NombreArchivo, int _height, int _left, bool _modal, int _startposition, int _top, int _top_most, int _width, int _windowstate, bool esActivo)
        {
            mID = ID;
            mId_defTema_modulo = Id_defTema_modulo;
            mDescripcion = Descripcion;
            mNombreArchivo = NombreArchivo;
            m_height = _height;
            m_left = _left;
            m_modal = _modal;
            m_startposition = _startposition;
            m_top = _top;
            m_top_most = _top_most;
            m_width = _width;
            m_windowstate = _windowstate;
            mEsActivo = EsActivo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
