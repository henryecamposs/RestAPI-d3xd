using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Sysdiagrams : ICloneable
    {

        private string mName = "";
        private int mPrincipal_id = 0;
        private int mDiagram_id = 0;
        private int mVersion = 0;
        private string mDefinition = "";

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public int Principal_id
        {
            get
            {
                return mPrincipal_id;
            }
            set
            {
                mPrincipal_id = value;
            }
        }

        public int Diagram_id
        {
            get
            {
                return mDiagram_id;
            }
            set
            {
                mDiagram_id = value;
            }
        }

        public int Version
        {
            get
            {
                return mVersion;
            }
            set
            {
                mVersion = value;
            }
        }

        public string Definition
        {
            get
            {
                return mDefinition;
            }
            set
            {
                mDefinition = value;
            }
        }

        Sysdiagrams()
        {
        }

        Sysdiagrams(string name, int principal_id, int diagram_id, int version, string definition)
        {
            mName = Name;
            mPrincipal_id = Principal_id;
            mDiagram_id = Diagram_id;
            mVersion = Version;
            mDefinition = Definition;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
