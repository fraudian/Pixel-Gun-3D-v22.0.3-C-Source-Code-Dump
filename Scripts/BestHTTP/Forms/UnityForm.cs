using UnityEngine;

namespace BestHTTP.Forms
{
    public sealed class UnityForm : HTTPFormBase
    {
        // Fields
        private UnityEngine.WWWForm <Form>k__BackingField;
        
        // Properties
        public UnityEngine.WWWForm Form { get; set; }
        
        // Methods
        public UnityEngine.WWWForm get_Form()
        {
            return (UnityEngine.WWWForm)this.<Form>k__BackingField;
        }
        public void set_Form(UnityEngine.WWWForm value)
        {
            this.<Form>k__BackingField = value;
        }
        public UnityForm()
        {
            val_1 = new System.Object();
        }
        public UnityForm(UnityEngine.WWWForm form)
        {
            val_1 = new System.Object();
            this.<Form>k__BackingField = form;
        }
        public override void CopyFrom(BestHTTP.Forms.HTTPFormBase fields)
        {
            var val_6;
            UnityEngine.WWWForm val_7;
            mem[1152921553766679016] = 1;
            mem[1152921553766679008] = fields.<Fields>k__BackingField;
            if((this.<Form>k__BackingField) != null)
            {
                    return;
            }
            
            this.<Form>k__BackingField = new UnityEngine.WWWForm();
            if(==0)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_4;
            label_13:
            BestHTTP.Forms.HTTPFieldData val_2 = Item[0];
            if(((System.String.IsNullOrEmpty(value:  val_2.<Text>k__BackingField)) != false) && ((val_2.<Binary>k__BackingField) != null))
            {
                    val_7 = this.<Form>k__BackingField;
                val_7.AddBinaryData(fieldName:  val_2.<Name>k__BackingField, contents:  val_2.<Binary>k__BackingField, fileName:  val_2.<FileName>k__BackingField, mimeType:  val_2.<MimeType>k__BackingField);
            }
            else
            {
                    val_7 = val_2.<Name>k__BackingField;
                this.<Form>k__BackingField.AddField(fieldName:  val_7, value:  val_2.<Text>k__BackingField, e:  val_2.<Encoding>k__BackingField);
            }
            
            val_6 = 1;
            label_4:
            if(val_6 < (val_2.<Text>k__BackingField.Count))
            {
                goto label_13;
            }
        
        }
        public override void PrepareRequest(BestHTTP.HTTPRequest request)
        {
            string val_5;
            string val_6;
            if((this.<Form>k__BackingField.headers.ContainsKey(key:  "Content-Type")) != false)
            {
                    val_5 = "Content-Type";
                val_6 = this.<Form>k__BackingField.headers.Item["Content-Type"];
            }
            else
            {
                    val_5 = "Content-Type";
                val_6 = "application/x-www-form-urlencoded";
            }
            
            request.SetHeader(name:  val_5, value:  val_6);
        }
        public override byte[] GetData()
        {
            if((this.<Form>k__BackingField) != null)
            {
                    return this.<Form>k__BackingField.data;
            }
            
            return this.<Form>k__BackingField.data;
        }
    
    }

}
