using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public struct CapeMemento : IEquatable<Rilisoft.CapeMemento>
    {
        // Fields
        private long id;
        private string cape;
        private System.Nullable<int> _capeHashCode;
        
        // Properties
        public long Id { get; }
        public string Cape { get; }
        
        // Methods
        public CapeMemento(long 丞丅上丏丂且下丅与, string 丈丐丕业下丟业丛一)
        {
            string val_1 = 丈丐丕业下丟业丛一;
            this._capeHashCode = 丞丅上丏丂且下丅与;
            if(val_1 == null)
            {
                    val_1 = System.String.alignConst;
            }
            
            mem[1152921543636591848] = val_1;
            mem[1152921543636591856] = 0;
        }
        public long get_Id()
        {
            return (long)this._capeHashCode;
        }
        public string get_Cape()
        {
            int val_1;
            if(14716 != 0)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public bool Equals(Rilisoft.CapeMemento 丘丛丏丘丝七世七丅)
        {
            System.Nullable<System.Int32> val_1 = this._capeHashCode;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            return false;
        }
        public override int GetHashCode()
        {
            var val_2 = 1152921543637180384;
            val_2 = val_2 ^ this._capeHashCode.GetHashCode();
            return (int)val_2;
        }
        public override string ToString()
        {
        
        }
        internal static string 丄丁丏三且专万丄不(string 丁世一与丝丐丏丒丁, string 与丄丙丐业丗丗丑三)
        {
            string val_3;
            var val_4;
            var val_5;
            val_3 = 丁世一与丝丐丏丒丁;
            val_4 = null;
            val_4 = null;
            if((System.String.op_Inequality(a:  val_3, b:  Progress.丕与丛三丗丒丈丕七.七丌专丌业业丆丅丂)) == true)
            {
                    return val_3;
            }
            
            val_3 = 与丄丙丐业丗丗丑三;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  与丄丙丐业丗丗丑三)) == false)
            {
                    return val_3;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = Progress.丕与丛三丗丒丈丕七.七丌专丌业业丆丅丂;
            return val_3;
        }
        internal static Rilisoft.CapeMemento 丐下丙丄丌丒三丐专(Rilisoft.CapeMemento 丈丂丕下丏丈丞丗业, Rilisoft.CapeMemento 丂丌丌丛丆丆丙丌丈)
        {
            var val_6;
            string val_7;
            string val_8;
            string val_9;
            string val_10;
            string val_11;
            bool val_12;
            Rilisoft.CapeMemento val_0;
            val_6 = 1152921543637589168;
            val_7 = 丈丂丕下丏丈丞丗业.cape;
            if(丈丂丕下丏丈丞丗业.cape == null)
            {
                    val_7 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                goto label_2;
            }
            
            val_8 = 丂丌丌丛丆丆丙丌丈.cape;
            if(丂丌丌丛丆丆丙丌丈.cape == null)
            {
                    val_8 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_8)) == true)
            {
                goto label_11;
            }
            
            label_2:
            val_9 = 丈丂丕下丏丈丞丗业.cape;
            if(丈丂丕下丏丈丞丗业.cape == null)
            {
                    val_9 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                goto label_8;
            }
            
            val_10 = 丂丌丌丛丆丆丙丌丈.cape;
            if(丂丌丌丛丆丆丙丌丈.cape == null)
            {
                    val_10 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_10)) == false)
            {
                goto label_11;
            }
            
            label_8:
            val_11 = 丈丂丕下丏丈丞丗业.cape;
            if(丈丂丕下丏丈丞丗业.cape == null)
            {
                    val_11 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_11)) == false)
            {
                goto label_14;
            }
            
            label_16:
            val_12 = 丂丌丌丛丆丆丙丌丈._capeHashCode.HasValue;
            val_0._capeHashCode.HasValue = val_12;
            goto label_15;
            label_11:
            if(丈丂丕下丏丈丞丗业.id <= 丂丌丌丛丆丆丙丌丈.id)
            {
                goto label_16;
            }
            
            label_14:
            val_12 = 丈丂丕下丏丈丞丗业._capeHashCode.HasValue;
            val_0._capeHashCode.HasValue = val_12;
            label_15:
            val_0.id = 丈丂丕下丏丈丞丗业.id;
            return val_0;
        }
        private int 丄丐丕三丂丆丗七丐()
        {
            return 106040796;
        }
    
    }

}
