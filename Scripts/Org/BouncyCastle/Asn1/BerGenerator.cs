using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerGenerator : Asn1Generator
    {
        // Fields
        private bool _tagged;
        private bool _isExplicit;
        private int _tagNo;
        
        // Methods
        protected BerGenerator(System.IO.Stream outStream)
        {
            val_1 = new System.Object();
            mem[1152921553408531360] = outStream;
        }
        public BerGenerator(System.IO.Stream outStream, int tagNo, bool isExplicit)
        {
            val_1 = new System.Object();
            mem[1152921553408651552] = outStream;
            this._tagged = true;
            this._isExplicit = isExplicit;
            this._tagNo = tagNo;
        }
        public override void AddObject(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            if((new Org.BouncyCastle.Asn1.BerOutputStream(s:  static_value_082C8000)) == null)
            {
                
            }
        
        }
        public override System.IO.Stream GetRawOutputStream()
        {
            return (System.IO.Stream)this;
        }
        public override void Close()
        {
            this.WriteBerEnd();
        }
        private void WriteHdr(int tag)
        {
            if(this == null)
            {
                
            }
        
        }
        protected void WriteBerHeader(int tag)
        {
            int val_4;
            if(this._tagged == false)
            {
                goto label_0;
            }
            
            if(this._isExplicit == false)
            {
                goto label_1;
            }
            
            this.WriteHdr(tag:  this._tagNo | 160);
            label_0:
            val_4 = tag;
            goto label_2;
            label_1:
            if((tag & 32) == 0)
            {
                    val_4 = this._tagNo | 128;
            }
            else
            {
                    val_4 = this._tagNo | 160;
            }
            
            label_2:
            this.WriteHdr(tag:  val_4);
        }
        protected void WriteBerBody(System.IO.Stream contentStream)
        {
            Org.BouncyCastle.Utilities.IO.Streams.PipeAll(inStr:  contentStream, outStr:  X8);
        }
        protected void WriteBerEnd()
        {
            if(this._tagged == false)
            {
                    return;
            }
            
            if(this._isExplicit == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Org.BouncyCastle.Asn1.BerGenerator).__il2cppRuntimeField_338;
        }
    
    }

}
