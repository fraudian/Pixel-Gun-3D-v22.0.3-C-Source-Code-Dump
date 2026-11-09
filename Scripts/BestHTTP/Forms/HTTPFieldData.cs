using UnityEngine;

namespace BestHTTP.Forms
{
    public class HTTPFieldData
    {
        // Fields
        private string <Name>k__BackingField;
        private string <FileName>k__BackingField;
        private string <MimeType>k__BackingField;
        private System.Text.Encoding <Encoding>k__BackingField;
        private string <Text>k__BackingField;
        private byte[] <Binary>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public System.Text.Encoding Encoding { get; set; }
        public string Text { get; set; }
        public byte[] Binary { get; set; }
        public byte[] Payload { get; }
        
        // Methods
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        public void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public string get_FileName()
        {
            return (string)this.<FileName>k__BackingField;
        }
        public void set_FileName(string value)
        {
            this.<FileName>k__BackingField = value;
        }
        public string get_MimeType()
        {
            return (string)this.<MimeType>k__BackingField;
        }
        public void set_MimeType(string value)
        {
            this.<MimeType>k__BackingField = value;
        }
        public System.Text.Encoding get_Encoding()
        {
            return (System.Text.Encoding)this.<Encoding>k__BackingField;
        }
        public void set_Encoding(System.Text.Encoding value)
        {
            this.<Encoding>k__BackingField = value;
        }
        public string get_Text()
        {
            return (string)this.<Text>k__BackingField;
        }
        public void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        public byte[] get_Binary()
        {
            return (System.Byte[])this.<Binary>k__BackingField;
        }
        public void set_Binary(byte[] value)
        {
            this.<Binary>k__BackingField = value;
        }
        public byte[] get_Payload()
        {
            System.Byte[] val_2 = this.<Binary>k__BackingField;
            if(val_2 != null)
            {
                    return (System.Byte[])val_1;
            }
            
            val_2 = this.<Encoding>k__BackingField;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            this.<Encoding>k__BackingField = val_1;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            label_1:
            this.<Binary>k__BackingField = val_1;
            return (System.Byte[])val_1;
            label_2:
        }
        public HTTPFieldData()
        {
        
        }
    
    }

}
