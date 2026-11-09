using UnityEngine;

namespace Rilisoft
{
    public sealed class 世丞丏丁丐丑三万丛 : IDisposable
    {
        // Fields
        private bool 丄上丈丝丒七丂下东;
        private readonly System.Security.Cryptography.HMAC 丄丟丒与丙丆丁与丒;
        private readonly string 上丌丒丐七七东万与;
        
        // Methods
        public bool 丄丄丛东丌丙丗丌丛()
        {
            return true;
        }
        public void Dispose()
        {
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            this.丄丟丒与丙丆丁与丒.Clear();
            this.丄上丈丝丒七丂下东 = true;
        }
        internal 世丞丏丁丐丑三万丛()
        {
            var val_21;
            var val_22;
            System.Security.Cryptography.SHA256Managed val_1 = null;
            val_21 = val_1;
            val_1 = new System.Security.Cryptography.SHA256Managed();
            string val_5 = System.BitConverter.ToString(value:  val_1.ComputeHash(buffer:  System.Text.Encoding.UTF8)).Replace(oldValue:  "-", newValue:  System.String.alignConst);
            this.上丌丒丐七七东万与 = val_5;
            this.上丌丒丐七七东万与 = val_5.Substring(startIndex:  0, length:  System.Math.Min(val1:  32, val2:  val_5.Length)).ToLower();
            new System.Security.Cryptography.HMACSHA256() = new System.Security.Cryptography.HMACSHA256(key:  val_1.ComputeHash(buffer:  System.Text.Encoding.UTF8));
            val_22 = 0;
            this.丄丟丒与丙丆丁与丒 = new System.Security.Cryptography.HMACSHA256();
            if(val_21 != null)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(val_22 == 0)
            {
                    return;
            }
            
            val_21 = ???;
            val_22 = ???;
        }
    
    }

}
