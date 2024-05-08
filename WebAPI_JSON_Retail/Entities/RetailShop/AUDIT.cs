using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class AUDIT : ICloneable
    {

        private int mAuditID = 0;
        private string mFieldName = "";
        private string mNewValue = "";
        private string mOldValue = "";
        private string mPrimaryKeyField = "";
        private string mPrimaryKeyValue = "";
        private string mTableName = "";
        private string mType = "";
        private DateTime mUpdateDateTime = new DateTime(2000, 01, 01);
        private string mUserName = "";

        public int AuditID
        {
            get
            {
                return mAuditID;
            }
            set
            {
                mAuditID = value;
            }
        }

        public string FieldName
        {
            get
            {
                return mFieldName;
            }
            set
            {
                mFieldName = value;
            }
        }

        public string NewValue
        {
            get
            {
                return mNewValue;
            }
            set
            {
                mNewValue = value;
            }
        }

        public string OldValue
        {
            get
            {
                return mOldValue;
            }
            set
            {
                mOldValue = value;
            }
        }

        public string PrimaryKeyField
        {
            get
            {
                return mPrimaryKeyField;
            }
            set
            {
                mPrimaryKeyField = value;
            }
        }

        public string PrimaryKeyValue
        {
            get
            {
                return mPrimaryKeyValue;
            }
            set
            {
                mPrimaryKeyValue = value;
            }
        }

        public string TableName
        {
            get
            {
                return mTableName;
            }
            set
            {
                mTableName = value;
            }
        }

        public string Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }

        public DateTime UpdateDateTime
        {
            get
            {
                return mUpdateDateTime;
            }
            set
            {
                mUpdateDateTime = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        AUDIT()
        {
        }

        AUDIT(int AuditID, string FieldName, string NewValue, string OldValue, string PrimaryKeyField, string PrimaryKeyValue, string TableName, string Type, DateTime UpdateDateTime, string UserName)
        {
            mAuditID = AuditID;
            mFieldName = FieldName;
            mNewValue = NewValue;
            mOldValue = OldValue;
            mPrimaryKeyField = PrimaryKeyField;
            mPrimaryKeyValue = PrimaryKeyValue;
            mTableName = TableName;
            mType = Type;
            mUpdateDateTime = UpdateDateTime;
            mUserName = UserName;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
