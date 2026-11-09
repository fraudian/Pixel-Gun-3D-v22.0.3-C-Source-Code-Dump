using UnityEngine;

namespace Rilisoft
{
    internal sealed class 上不丏丙丐三三丄且
    {
        // Fields
        private readonly bool 七丁丐丗丆丑丄丟丘;
        private readonly System.Security.Cryptography.HashAlgorithm 丄丟丒与丙丆丁与丒;
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.上不丏丙丐三三丄且> 丝业丆丁业三丈丟东;
        
        // Properties
        internal static Rilisoft.上不丏丙丐三三丄且 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        public 上不丏丙丐三三丄且()
        {
            this.丄丟丒与丙丆丁与丒 = new System.Security.Cryptography.HMACSHA1(key:  new byte[64] {62, 59, 146, 50, 196, 43, 151, 12, 34, 157, 74, 34, 25, 226, 239, 167, 46, 226, 151, 253, 149, 85, 40, 56, 107, 254, 198, 111, 152, 34, 73, 206, 184, 145, 51, 23, 161, 197, 53, 9, 59, 16, 106, 151, 54, 115, 158, 48, 176, 147, 174, 119, 233, 88, 253, 94, 20, 2, 164, 67, 205, 142, 150, 2}, useManagedSha1:  true);
        }
        internal static Rilisoft.上不丏丙丐三三丄且 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.上不丏丙丐三三丄且.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.上不丏丙丐三三丄且.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.上不丏丙丐三三丄且.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        public void 世业丒万丘丆专丘丐()
        {
        
        }
        public bool 丑丈丗丛丅丙丗丂丌(string 下上丐丆丝丟丝丒不)
        {
            string val_1 = this.丌丒丏丞丕丘丑丌且(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            if(this.七丁丐丗丆丑丄丟丘 == false)
            {
                    return UnityEngine.PlayerPrefs.HasKey(key:  val_1);
            }
            
            return Rilisoft.三丄丄与且与丂万与.丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  val_1);
        }
        public void Remove(string 下上丐丆丝丟丝丒不)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                    string val_1 = this.丌丒丏丞丕丘丑丌且(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
                if(this.七丁丐丗丆丑丄丟丘 != false)
            {
                    Rilisoft.三丄丄与且与丂万与.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  val_1);
                return;
            }
            
                UnityEngine.PlayerPrefs.DeleteKey(key:  val_1);
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "key");
        }
        public void 丂且不业丂专丛丆东()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public void 丅专下万丕丑丆丅丝(string 下上丐丆丝丟丝丒不, int 丙业与丙丗丝不丈东)
        {
            this.丌丕丑专丞丙与丅丁(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  System.BitConverter.GetBytes(value:  丙业与丙丗丝不丈东));
        }
        public void 丅专下万丕丑丆丅丝(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            label_4:
            this.丌丕丑专丞丙与丅丁(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
            return;
            label_1:
            if(val_1 != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public void 丅专下万丕丑丆丅丝(string 下上丐丆丝丟丝丒不, byte[] 丙业与丙丗丝不丈东)
        {
            System.Byte[] val_2 = 丙业与丙丗丝不丈东;
            if(val_2 == null)
            {
                    byte[] val_1 = new byte[0];
                val_2 = val_1;
            }
            
            this.丌丕丑专丞丙与丅丁(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
        }
        public bool 丄丄丛东丌丙丗丌丛(string 下上丐丆丝丟丝丒不, int 丙业与丙丗丝不丈东)
        {
            return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  System.BitConverter.GetBytes(value:  丙业与丙丗丝不丈东));
        }
        public bool 丄丄丛东丌丙丗丌丛(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            if(丙业与丙丗丝不丈东 != null)
            {
                    if(val_1 == null)
            {
                    return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
            }
            
                return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
            }
            
            if(val_1 != null)
            {
                    return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
            }
            
            return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
        }
        public bool 丄丄丛东丌丙丗丌丛(string 下上丐丆丝丟丝丒不, byte[] 丙业与丙丗丝不丈东)
        {
            System.Byte[] val_2 = 丙业与丙丗丝不丈东;
            if(val_2 != null)
            {
                    return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  byte[] val_1 = new byte[0]);
            }
            
            val_2 = val_1;
            return this.丑丟丘丆丌丄且上上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  val_1);
        }
        public bool 丑丟丘丆丌丄且上上(string 下上丐丆丝丟丝丒不, byte[] 丅丈业丗万丑丞世一)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                    if((this.丑丈丗丛丅丙丗丂丌(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) == false)
            {
                    return false;
            }
            
                System.Byte[] val_2 = this.丌丘丝丂丕丛丘丐丕(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  丅丈业丗万丑丞世一);
                string val_3 = val_2.丌丒丏丞丕丘丑丌且(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
                if(this.七丁丐丗丆丑丄丟丘 != false)
            {
                    string val_4 = Rilisoft.三丄丄与且与丂万与.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  val_3);
                return System.Linq.Enumerable.SequenceEqual<System.Byte>(first:  System.Convert.FromBase64String(s:  UnityEngine.PlayerPrefs.GetString(key:  val_3)), second:  val_2);
            }
            
                return System.Linq.Enumerable.SequenceEqual<System.Byte>(first:  System.Convert.FromBase64String(s:  UnityEngine.PlayerPrefs.GetString(key:  val_3)), second:  val_2);
            }
            
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  "key");
        }
        private byte[] 丌丘丝丂丕丛丘丐丕(string 下上丐丆丝丟丝丒不, byte[] 丅丈业丗万丑丞世一)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  下上丐丆丝丟丝丒不);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_9:
            int val_2 = 丅丈业丗万丑丞世一.Length + val_1.Length;
            byte[] val_3 = new byte[0];
            if(val_1 == null)
            {
                goto label_6;
            }
            
            val_1.CopyTo(array:  val_3, index:  0);
            goto label_7;
            label_4:
            if(丅丈业丗万丑丞世一 != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            val_1.CopyTo(array:  val_3, index:  0);
            label_7:
            丅丈业丗万丑丞世一.CopyTo(array:  val_3, index:  val_1.Length);
            if(this.丄丟丒与丙丆丁与丒 != null)
            {
                    return this.丄丟丒与丙丆丁与丒.ComputeHash(buffer:  val_3);
            }
            
            return this.丄丟丒与丙丆丁与丒.ComputeHash(buffer:  val_3);
        }
        private void 丌丕丑专丞丙与丅丁(string 下上丐丆丝丟丝丒不, byte[] 丅丈业丗万丑丞世一)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                    string val_2 = System.Convert.ToBase64String(inArray:  this.丌丘丝丂丕丛丘丐丕(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丅丈业丗万丑丞世一:  丅丈业丗万丑丞世一));
                string val_3 = val_2.丌丒丏丞丕丘丑丌且(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
                if(this.七丁丐丗丆丑丄丟丘 != false)
            {
                    Rilisoft.三丄丄与且与丂万与.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  val_2);
                return;
            }
            
                UnityEngine.PlayerPrefs.SetString(key:  val_3, value:  val_2);
                return;
            }
            
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  "key");
        }
        public string 丌丒丏丞丕丘丑丌且(string 下上丐丆丝丟丝丒不)
        {
            string val_8 = 下上丐丆丝丟丝丒不;
            if(val_8 != null)
            {
                    if(UnityEngine.Application.isEditor == true)
            {
                    return (string)System.String.Format(format:  "Digest-9.4.1-{0:d}.", arg0:  Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂())(System.String.Format(format:  "Digest-9.4.1-{0:d}.", arg0:  Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂())) + val_8;
            }
            
                val_8 = System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8);
                return (string)System.String.Format(format:  "Digest-9.4.1-{0:d}.", arg0:  Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂())(System.String.Format(format:  "Digest-9.4.1-{0:d}.", arg0:  Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂())) + val_8;
            }
            
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  "key");
        }
        private static 上不丏丙丐三三丄且()
        {
            null = null;
            Rilisoft.上不丏丙丐三三丄且.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.上不丏丙丐三三丄且>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.上不丏丙丐三三丄且>(object:  上不丏丙丐三三丄且.<>c.<>9, method:  Rilisoft.上不丏丙丐三三丄且 上不丏丙丐三三丄且.<>c::丛下不丕丏丑一丌丄()));
        }
    
    }

}
