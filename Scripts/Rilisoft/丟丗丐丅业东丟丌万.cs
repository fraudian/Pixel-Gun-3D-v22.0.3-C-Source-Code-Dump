using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丟丗丐丅业东丟丌万 : 一世丄丆专丕丙上丙
    {
        // Fields
        private readonly System.Security.Cryptography.HashAlgorithm 不丕丙丑丅三专不一;
        private readonly System.Security.Cryptography.RSACryptoServiceProvider 丛丛三丆丑丕丆世上;
        private readonly System.Security.Cryptography.RSACryptoServiceProvider 业丗丆丐丙丕世三丌;
        private readonly string 丑丒丄下丁丐专丄丞;
        private readonly byte[] 丛东丆丒上丌丞丞丗;
        private const string 上三下东丆丏丏丒丗 = "{0}__{1}__{2}";
        private const string 三世万三七上丈丑下 = "com.Rilisoft";
        
        // Methods
        public 丟丗丐丅业东丟丌万(Rilisoft.丆丑丙丈世万丛丈丝 丆丞且三丟东丕东丂, System.Security.Cryptography.RSACryptoServiceProvider 东丝丛业与丛丞丘丅, string 一不丑七万万丁不丌)
        {
            this.不丕丙丑丅三专不一 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            this.丛东丆丒上丌丞丞丗 = System.Text.Encoding.UTF8;
            this.丛丛三丆丑丕丆世上 = 东丝丛业与丛丞丘丅;
            this.业丗丆丐丙丕世三丌 = new System.Security.Cryptography.RSACryptoServiceProvider();
            this.丑丒丄下丁丐专丄丞 = 一不丑七万万丁不丌;
        }
        protected override void 丞东世三丂丁丒三东(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            if((下上丐丆丝丟丝丒不.StartsWith(value:  "com.Rilisoft")) != true)
            {
                    this.丝且丏万丒丏世丏丂().Add(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
                this.丝且丏万丒丏世丏丂().Add(下上丐丆丝丟丝丒不:  this.丝世丒丂上丛丟丕丐(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不), 丙业与丙丗丝不丈东:  this.丗下丒东丁丏三丙业(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东));
                return;
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "Key starts with reserved prefix.", paramName:  "key");
        }
        protected override bool 业不丗上万丞专上丅(string 下上丐丆丝丟丝丒不)
        {
            if((下上丐丆丝丟丝丒不.StartsWith(value:  "com.Rilisoft")) != true)
            {
                    bool val_4 = this.丝且丏万丒丏世丏丂().Remove(下上丐丆丝丟丝丒不:  this.丝世丒丂上丛丟丕丐(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
                Rilisoft.丆丑丙丈世万丛丈丝 val_5 = this.丝且丏万丒丏世丏丂();
                if(val_5 != null)
            {
                    return val_5.Remove(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
                return val_5.Remove(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "Key starts with reserved prefix.", paramName:  "key");
        }
        protected override bool 丑丟丘丆丌丄且上上(string 下上丐丆丝丟丝丒不)
        {
            System.Byte[] val_8;
            System.Security.Cryptography.HashAlgorithm val_9;
            var val_10;
            var val_11;
            val_9 = this;
            if((val_9 & 1) == 0)
            {
                goto label_10;
            }
            
            val_8 = System.String.Format(format:  "{0}__{1}__{2}", arg0:  this.丑丒丄下丁丐专丄丞, arg1:  下上丐丆丝丟丝丒不, arg2:  0);
            string val_2 = this.丝世丒丂上丛丟丕丐(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            if((val_9 & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = System.Convert.FromBase64String(s:  0);
            val_9 = this.不丕丙丑丅三专不一;
            val_10 = this.业丗丆丐丙丕世三丌;
            bool val_5 = val_10.VerifyData(buffer:  System.Text.Encoding.UTF8, halg:  val_9, signature:  val_8);
            goto label_7;
            label_10:
            val_11 = new System.Collections.Generic.KeyNotFoundException(message:  System.String.Format(format:  "The given key was not present in the dictionary: {0}", arg0:  下上丐丆丝丟丝丒不));
            if(0 != 1)
            {
                goto label_11;
            }
            
            val_9 = val_11;
            if((null & 1) == 0)
            {
                goto label_12;
            }
            
            label_2:
            val_10 = 0;
            label_7:
            val_10 = val_10 & 1;
            return (bool)val_10;
            label_12:
            mem[8] = null;
            val_11 = 8;
            label_11:
        }
        private string 丝世丒丂上丛丟丕丐(string 下上丐丆丝丟丝丒不)
        {
            return System.String.Format(format:  "{0}_{1}", arg0:  "com.Rilisoft", arg1:  System.Convert.ToBase64String(inArray:  this.不丕丙丑丅三专不一.ComputeHash(buffer:  System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Concat<System.Byte>(first:  System.Linq.Enumerable.Concat<System.Byte>(first:  System.Text.Encoding.UTF8, second:  this.丛东丆丒上丌丞丞丗), second:  System.Text.Encoding.UTF8)))));
        }
        private string 丗下丒东丁丏三丙业(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            string val_1 = System.String.Format(format:  "{0}__{1}__{2}", arg0:  this.丑丒丄下丁丐专丄丞, arg1:  下上丐丆丝丟丝丒不, arg2:  丙业与丙丗丝不丈东);
            return System.Convert.ToBase64String(inArray:  this.丛丛三丆丑丕丆世上.SignData(buffer:  System.Text.Encoding.UTF8, halg:  this.不丕丙丑丅三专不一));
        }
    
    }

}
