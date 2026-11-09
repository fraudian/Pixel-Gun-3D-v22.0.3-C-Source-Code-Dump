using UnityEngine;

namespace BestHTTP
{
    public sealed class HTTPRange
    {
        // Fields
        private int <FirstBytePos>k__BackingField;
        private int <LastBytePos>k__BackingField;
        private int <ContentLength>k__BackingField;
        private bool <IsValid>k__BackingField;
        
        // Properties
        public int FirstBytePos { get; set; }
        public int LastBytePos { get; set; }
        public int ContentLength { get; set; }
        public bool IsValid { get; set; }
        
        // Methods
        public int get_FirstBytePos()
        {
            return (int)this.<FirstBytePos>k__BackingField;
        }
        private void set_FirstBytePos(int value)
        {
            this.<FirstBytePos>k__BackingField = value;
        }
        public int get_LastBytePos()
        {
            return (int)this.<LastBytePos>k__BackingField;
        }
        private void set_LastBytePos(int value)
        {
            this.<LastBytePos>k__BackingField = value;
        }
        public int get_ContentLength()
        {
            return (int)this.<ContentLength>k__BackingField;
        }
        private void set_ContentLength(int value)
        {
            this.<ContentLength>k__BackingField = value;
        }
        public bool get_IsValid()
        {
            return (bool)this.<IsValid>k__BackingField;
        }
        private void set_IsValid(bool value)
        {
            this.<IsValid>k__BackingField = value;
        }
        internal HTTPRange()
        {
            this.<ContentLength>k__BackingField = 0;
            this.<IsValid>k__BackingField = false;
        }
        internal HTTPRange(int contentLength)
        {
            this.<ContentLength>k__BackingField = contentLength;
            this.<IsValid>k__BackingField = false;
        }
        internal HTTPRange(int firstBytePosition, int lastBytePosition, int contentLength)
        {
            int val_3 = contentLength;
            this.<ContentLength>k__BackingField = val_3;
            val_3 = ((firstBytePosition <= lastBytePosition) ? 1 : 0) & ((val_3 > lastBytePosition) ? 1 : 0);
            this.<FirstBytePos>k__BackingField = firstBytePosition;
            this.<LastBytePos>k__BackingField = lastBytePosition;
            this.<IsValid>k__BackingField = val_3;
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<FirstBytePos>k__BackingField) != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<FirstBytePos>k__BackingField) == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<FirstBytePos>k__BackingField;
            val_1[1] = this.<LastBytePos>k__BackingField;
            val_1[2] = this.<ContentLength>k__BackingField;
            val_1[3] = this.<IsValid>k__BackingField;
            return (string)System.String.Format(format:  "{0}-{1}/{2} (valid: {3})", args:  val_1);
        }
    
    }

}
