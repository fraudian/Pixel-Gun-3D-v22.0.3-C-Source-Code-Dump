using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丛丞丛丑丑万世丛万
    {
        // Fields
        private static readonly System.Text.UTF8Encoding 丝丛且不丗丏丞七丟;
        private readonly Rilisoft.丟三业丏东丂且专上 丞丅丁丈丕丞丂丑丈;
        private readonly Rilisoft.丂世丈丅丝丙丘丌丟 丅丂万世专万丒丁丘;
        private readonly System.Collections.Generic.Dictionary<byte[], string> 且丏丆世丅丑三丞丛;
        private System.WeakReference 丅丈万丞丑不丘丁丝;
        
        // Methods
        public 丛丞丛丑丑万世丛万(byte[] 丅丄三丅丑丑丞且万)
        {
            this.且丏丆世丅丑三丞丛 = new System.Collections.Generic.Dictionary<System.Byte[], System.String>(comparer:  new Rilisoft.Details.世丒丝丛丐丝且且丆());
            if(丅丄三丅丑丑丞且万 != null)
            {
                    this.丅丂万世专万丒丁丘 = new Rilisoft.丂世丈丅丝丙丘丌丟(丅丄三丅丑丑丞且万:  丅丄三丅丑丑丞且万);
                this.丞丅丁丈丕丞丂丑丈 = new Rilisoft.丟三业丏东丂且专上(丅丄三丅丑丑丞且万:  丅丄三丅丑丑丞且万);
                return;
            }
            
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "masterKey");
        }
        public void 丂下丕一丒业上下一()
        {
            this.丅丈万丞丑不丘丁丝 = 0;
            this.且丏丆世丅丑三丞丛.Clear();
        }
        public void 丟下三不一丌三三丟(string 下上丐丆丝丟丝丒不)
        {
            if(下上丐丆丝丟丝丒不 == null)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  this.一上丅丐丆丈丏丈丑(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
        }
        public bool 丌丟三丘世下与丆丘(string 下上丐丆丝丟丝丒不)
        {
            var val_4;
            if(下上丐丆丝丟丝丒不 != null)
            {
                    bool val_2 = UnityEngine.PlayerPrefs.HasKey(key:  this.一上丅丐丆丈丏丈丑(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
            }
            else
            {
                    val_4 = 0;
            }
            
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public string 丒丙丝丆丄丆丄且专(string 下上丐丆丝丟丝丒不)
        {
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            int val_19;
            System.Exception val_20;
            val_14 = 下上丐丆丝丟丝丒不;
            val_15 = this;
            if(val_14 != null)
            {
                    val_16 = null;
                val_16 = null;
                System.Byte[] val_1 = Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟.GetBytes(s:  val_14);
                string val_3 = UnityEngine.PlayerPrefs.GetString(key:  this.一上丅丐丆丈丏丈丑(下专丞丗世不业丅不:  val_1));
                if((System.String.IsNullOrEmpty(value:  val_3)) != true)
            {
                    val_17 = System.Convert.FromBase64String(s:  val_3);
                int val_14 = val_5.Length;
                val_14 = val_14 - this.丞丅丁丈丕丞丂丑丈.下万丒丗下丐丛丅丛();
                if((val_14 & 2147483648) == 0)
            {
                    System.ArraySegment<System.Byte> val_10 = this.丞丅丁丈丕丞丂丑丈.丘丞丕丏一丌三丟丅(丏专世丐万丑万三不:  new System.ArraySegment<System.Byte>(), 一不丑七万万丁不丌:  0, 丏东丑丘丂与万丕丑:  val_1);
                if(val_10._count.丐丏七丌丕丗业且上() != null)
            {
                    val_18 = null;
                val_18 = null;
                string val_12 = val_10._count.丐丏七丌丕丗业且上();
                val_19 = Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟;
                val_17 = 0;
                val_15 = 0;
            }
            else
            {
                    val_17 = 0;
                val_15 = 0;
                val_19 = System.String.alignConst;
            }
            
                System.Array.Clear(array:  this.丌丂一不丟不丗丂丙(丏上万丅丏一不不丕:  val_5.Length - this.丞丅丁丈丕丞丂丑丈.下万丒丗下丐丛丅丛()), index:  0, length:  val_9.Length);
                if(val_17 != 1)
            {
                    if(228 == 228)
            {
                    return (string)val_19;
            }
            
            }
            
                if(val_15 != 0)
            {
                    val_20 = 0;
            }
            else
            {
                    val_20 = 0;
            }
            
                val_14 = "[GetString] An exception occurred while reading the value of property: "("[GetString] An exception occurred while reading the value of property: ") + val_14;
                UnityEngine.Debug.LogError(message:  val_14);
                UnityEngine.Debug.LogException(exception:  val_20);
            }
            
            }
            
            }
            
            val_19 = System.String.alignConst;
            return (string)val_19;
        }
        public void 丞丅丁与丞丒丗下丟(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            var val_10;
            var val_11;
            var val_12;
            if(下上丐丆丝丟丝丒不 == null)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            System.Byte[] val_1 = Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟.GetBytes(s:  下上丐丆丝丟丝丒不);
            val_12 = null;
            val_12 = null;
            System.Byte[] val_3 = Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟.GetBytes(s:  丙业与丙丗丝不丈东);
            System.ArraySegment<System.Byte> val_7 = this.丞丅丁丈丕丞丂丑丈.三丙业业世丙丏丝丝(下丟丗丛丅丗丒与丙:  new System.ArraySegment<System.Byte>(), 一不丑七万万丁不丌:  0, 丏东丑丘丂与万丕丑:  val_1);
            UnityEngine.PlayerPrefs.SetString(key:  this.一上丅丐丆丈丏丈丑(下专丞丗世不业丅不:  val_1), value:  System.Convert.ToBase64String(inArray:  val_7._count.丐丏七丌丕丗业且上(), offset:  -721958608, length:  -721958608));
            val_10 = 0;
            System.Array.Clear(array:  this.丌丂一不丟不丗丂丙(丏上万丅丏一不不丕:  this.丞丅丁丈丕丞丂丑丈.丈万一业且丈下丞丑() + val_3.Length), index:  0, length:  val_6.Length);
            if(0 != 1)
            {
                    if(val_10 == 0)
            {
                    return;
            }
            
                if(128 != 128)
            {
                    return;
            }
            
                return;
            }
            
            if(val_10 == 0)
            {
                    return;
            }
        
        }
        private string 一上丅丐丆丈丏丈丑(string 下上丐丆丝丟丝丒不)
        {
            null = null;
            return this.一上丅丐丆丈丏丈丑(下专丞丗世不业丅不:  Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟.GetBytes(s:  下上丐丆丝丟丝丒不));
        }
        private string 一上丅丐丆丈丏丈丑(byte[] 下专丞丗世不业丅不)
        {
            string val_6;
            string val_1 = 0;
            if((this.且丏丆世丅丑三丞丛.TryGetValue(key:  下专丞丗世不业丅不, value: out  val_1)) != false)
            {
                    val_6 = val_1;
                return val_6;
            }
            
            val_6 = "AEAD:"("AEAD:") + System.Convert.ToBase64String(inArray:  this.丅丂万世专万丒丁丘.三丙业业世丙丏丝丝(下丟丗丛丅丗丒与丙:  下专丞丗世不业丅不))(System.Convert.ToBase64String(inArray:  this.丅丂万世专万丒丁丘.三丙业业世丙丏丝丝(下丟丗丛丅丗丒与丙:  下专丞丗世不业丅不)));
            this.且丏丆世丅丑三丞丛.set_Item(key:  下专丞丗世不业丅不, value:  val_6);
            return val_6;
        }
        private byte[] 丌丂一不丟不丗丂丙(int 丏上万丅丏一不不丕)
        {
            var val_5;
            object val_6;
            if((丏上万丅丏一不不丕 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if((this.丅丈万丞丑不丘丁丝 == null) || ((this.丅丈万丞丑不丘丁丝 & 1) == 0))
            {
                goto label_3;
            }
            
            if(this.丅丈万丞丑不丘丁丝 == null)
            {
                goto label_8;
            }
            
            val_6 = this.丅丈万丞丑不丘丁丝;
            if(val_6 == null)
            {
                goto label_6;
            }
            
            if(1152921505721910208 >= 丏上万丅丏一不不丕)
            {
                    return (System.Byte[])val_6;
            }
            
            label_3:
            byte[] val_1 = new byte[0];
            val_6 = val_1;
            this.丅丈万丞丑不丘丁丝 = new System.WeakReference(target:  val_1, trackResurrection:  false);
            return (System.Byte[])val_6;
            label_1:
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException(paramName:  "length", actualValue:  丏上万丅丏一不不丕, message:  "Must be non-negative.");
            label_6:
            val_5 = 0;
            label_8:
        }
        private static 丛丞丛丑丑万世丛万()
        {
            Rilisoft.丛丞丛丑丑万世丛万.丝丛且不丗丏丞七丟 = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false, throwOnInvalidBytes:  false);
        }
    
    }

}
