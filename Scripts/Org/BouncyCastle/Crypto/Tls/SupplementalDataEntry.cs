using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class SupplementalDataEntry
    {
        // Fields
        protected readonly int mDataType;
        protected readonly byte[] mData;
        
        // Properties
        public virtual int DataType { get; }
        public virtual byte[] Data { get; }
        
        // Methods
        public SupplementalDataEntry(int dataType, byte[] data)
        {
            this.mDataType = dataType;
            this.mData = data;
        }
        public virtual int get_DataType()
        {
            return (int)this.mDataType;
        }
        public virtual byte[] get_Data()
        {
            return (System.Byte[])this.mData;
        }
    
    }

}
