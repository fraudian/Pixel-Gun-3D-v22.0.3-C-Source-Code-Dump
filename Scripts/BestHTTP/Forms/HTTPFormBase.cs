using UnityEngine;

namespace BestHTTP.Forms
{
    public class HTTPFormBase
    {
        // Fields
        private const int LongLength = 256;
        private System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> <Fields>k__BackingField;
        private bool <IsChanged>k__BackingField;
        private bool <HasBinary>k__BackingField;
        private bool <HasLongValue>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> Fields { get; set; }
        public bool IsEmpty { get; }
        public bool IsChanged { get; set; }
        public bool HasBinary { get; set; }
        public bool HasLongValue { get; set; }
        
        // Methods
        public System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> get_Fields()
        {
            return (System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>)this.<Fields>k__BackingField;
        }
        public void set_Fields(System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> value)
        {
            this.<Fields>k__BackingField = value;
        }
        public bool get_IsEmpty()
        {
            var val_3;
            if((this.<Fields>k__BackingField) != null)
            {
                    var val_2 = ((this.<Fields>k__BackingField.Count) == 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool get_IsChanged()
        {
            return (bool)this.<IsChanged>k__BackingField;
        }
        protected void set_IsChanged(bool value)
        {
            this.<IsChanged>k__BackingField = value;
        }
        public bool get_HasBinary()
        {
            return (bool)this.<HasBinary>k__BackingField;
        }
        protected void set_HasBinary(bool value)
        {
            this.<HasBinary>k__BackingField = value;
        }
        public bool get_HasLongValue()
        {
            return (bool)this.<HasLongValue>k__BackingField;
        }
        protected void set_HasLongValue(bool value)
        {
            this.<HasLongValue>k__BackingField = value;
        }
        public void AddBinaryData(string fieldName, byte[] content)
        {
            this.AddBinaryData(fieldName:  fieldName, content:  content, fileName:  0, mimeType:  0);
        }
        public void AddBinaryData(string fieldName, byte[] content, string fileName)
        {
            this.AddBinaryData(fieldName:  fieldName, content:  content, fileName:  fileName, mimeType:  0);
        }
        public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
        {
            string val_5 = fileName;
            if((this.<Fields>k__BackingField) == null)
            {
                    this.<Fields>k__BackingField = new System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>();
            }
            
            .<Name>k__BackingField = fieldName;
            if(val_5 == null)
            {
                    val_5 = fieldName + ".dat";
            }
            
            .<FileName>k__BackingField = val_5;
            .<Binary>k__BackingField = content;
            .<MimeType>k__BackingField = (mimeType == null) ? "application/octet-stream" : mimeType;
            this.<Fields>k__BackingField.Add(item:  new BestHTTP.Forms.HTTPFieldData());
            this.<IsChanged>k__BackingField = true;
            this.<HasBinary>k__BackingField = true;
        }
        public void AddField(string fieldName, string value)
        {
            this.AddField(fieldName:  fieldName, value:  value, e:  System.Text.Encoding.UTF8);
        }
        public void AddField(string fieldName, string value, System.Text.Encoding e)
        {
            if((this.<Fields>k__BackingField) == null)
            {
                    this.<Fields>k__BackingField = new System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>();
            }
            
            BestHTTP.Forms.HTTPFieldData val_2 = new BestHTTP.Forms.HTTPFieldData();
            if(val_2 != null)
            {
                    .<Name>k__BackingField = fieldName;
            }
            else
            {
                    mem[16] = fieldName;
            }
            
            .<FileName>k__BackingField = 0;
            if(e != null)
            {
                    .<MimeType>k__BackingField = "text/plain; charset="("text/plain; charset=") + e;
            }
            
            .<Encoding>k__BackingField = e;
            .<Text>k__BackingField = value;
            this.<Fields>k__BackingField.Add(item:  val_2);
            this.<IsChanged>k__BackingField = true;
            bool val_5 = (value.Length > 256) ? 1 : 0;
            val_5 = (this.<HasLongValue>k__BackingField) | val_5;
            this.<HasLongValue>k__BackingField = val_5;
        }
        public virtual void CopyFrom(BestHTTP.Forms.HTTPFormBase fields)
        {
            this.<Fields>k__BackingField = new System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>(collection:  fields.<Fields>k__BackingField);
            this.<IsChanged>k__BackingField = true;
            if(fields != null)
            {
                    this.<HasBinary>k__BackingField = fields.<HasBinary>k__BackingField;
            }
            else
            {
                    this.<HasBinary>k__BackingField = false;
            }
            
            this.<HasLongValue>k__BackingField = fields.<HasLongValue>k__BackingField;
        }
        public virtual void PrepareRequest(BestHTTP.HTTPRequest request)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public virtual byte[] GetData()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public HTTPFormBase()
        {
        
        }
    
    }

}
