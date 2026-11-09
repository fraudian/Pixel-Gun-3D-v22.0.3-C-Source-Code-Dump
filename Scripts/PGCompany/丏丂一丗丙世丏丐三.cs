using UnityEngine;

namespace PGCompany
{
    internal sealed class 丏丂一丗丙世丏丐三 : 业丞且丞丁丅丏丏丐, 业世丑丑丞丑丂丘东, 七专丙与东丘丌丘丈
    {
        // Fields
        private static System.Action 丕东丕丂且丏丆丝万;
        private System.Lazy<PGCompany.ModuleData> 丁丘丄丕下专东七不;
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> 世与丝七专业丟丝东;
        private UnityEngine.Texture 三与丕丘丌丈一丆七;
        private string 丛丙丐万丑上且丒丛;
        private string 且丞世丘丞一不不三;
        private string 丏丆丒丕丛丄七丘丄;
        private string 丑丕丆与丘丘世丛东;
        private Rilisoft.且丈丞一丞丟与上七 丕丑丘丙丟且与丕丈;
        
        // Properties
        internal PGCompany.ModuleData 丞丑且东丌与丏丏丁 { get; }
        internal PGCompany.ModuleData.ModuleType 丗丑不丁丐丄丑丑东 { get; }
        internal PGCompany.ModuleData.ModuleCategory 一上世与丅丕丅丞丏 { get; }
        internal int 丌且丐下不丂丒与丘 { get; }
        internal 丈丞丕丘丕丗与上一 专丙七丑丑丈不世丝 { get; }
        internal float 丆丈丂丟丈丙丕世丝 { get; }
        internal int 丈丒丞丙丒丛丌丞且 { get; }
        internal int 业丒上一丞丆丞丈丐 { get; }
        internal int 丏业丌丂且丗七上丂 { get; }
        internal PGCompany.ModuleData.丁丄丅三丞丁万丟丟 专丈丏丁与丐丝丂丏 { get; }
        internal PGCompany.ModuleData.丁丄丅三丞丁万丟丟 一且丄丌丏丁丝丈丂 { get; }
        internal bool 丏专丆丘丂丁专丛东 { get; set; }
        internal string 不丄丆丕丒七业与丂 { get; }
        
        // Methods
        internal static void 丌上业丟下丒丙丄世(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.丏丂一丗丙世丏丐三.丕东丕丂且丏丆丝万, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 上丌丝上丁一丁世丙(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.丏丂一丗丙世丏丐三.丕东丕丂且丏丆丝万, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal PGCompany.ModuleData 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return this.丁丘丄丕下专东七不.Value;
            }
            
            return this.丁丘丄丕下专东七不.Value;
        }
        internal PGCompany.ModuleData.ModuleType 与丝丅丘且丐上丅世()
        {
            ModuleType val_2;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.Type;
            return val_2;
        }
        internal PGCompany.ModuleData.ModuleCategory 万丕丅下上丄丗万丞()
        {
            ModuleCategory val_2;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.Category;
            return val_2;
        }
        internal int 丑业世丞上丂丄丟丞()
        {
            if(this.丗不丞三丄丞下丏且() < 1)
            {
                    return 0;
            }
            
            Progress.万丅丆丌丂丛专业丅 val_2 = Progress.七七世万专丕丁上业.万丝下专不专万三丈();
            if(val_2 != null)
            {
                    return val_2.丏丌专万丙丝丝丈一(丕上业丕丘上丘七一:  this);
            }
            
            return val_2.丏丌专万丙丝丝丈一(丕上业丕丘上丘七一:  this);
        }
        internal 丈丞丕丘丕丗与上一 且与丏三不丟丂丙丏()
        {
            if((this.丏丌专万丙丝丝丈一(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞() + 1)) != null)
            {
                    return (丈丞丕丘丕丗与上一)val_3.UpgradePrice;
            }
            
            return (丈丞丕丘丕丗与上一)val_3.UpgradePrice;
        }
        internal float 丞万丆丑且丟丑专丟()
        {
            if((this.丏丌专万丙丝丝丈一(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞())) != null)
            {
                    return (float)val_2.Modificator;
            }
            
            return (float)val_2.Modificator;
        }
        internal int 丆丏一丞丘丆丕丛丅()
        {
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            return System.Linq.Enumerable.Min(source:  val_1.Ups.Keys);
        }
        internal int 丙丑丈七丞下丈丞与()
        {
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            return System.Linq.Enumerable.Max(source:  val_1.Ups.Keys);
        }
        internal int 丆丒丕下丝丂三丘丑()
        {
            if(this.世与丝七专业丟丝东.HasValue == true)
            {
                    return -494215904;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = this.丟丂一丘丛与丝上七();
            mem2[0] = 0;
            mem2[0] = 0;
            return -494215904;
        }
        internal 丏丂一丗丙世丏丐三(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.三东丏不丗世丅丌丄 val_4 = 丈丄不七三万丄丁不;
            丏丂一丗丙世丏丐三.丐丐七丈丅丐三且丆 val_1 = new 丏丂一丗丙世丏丐三.丐丐七丈丅丐三且丆();
            if(val_1 != null)
            {
                    .丈丄不七三万丄丁不 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            this.丁丘丄丕下专东七不 = new System.Lazy<PGCompany.ModuleData>(valueFactory:  new System.Func<PGCompany.ModuleData>(object:  val_1, method:  PGCompany.ModuleData 丏丂一丗丙世丏丐三.丐丐七丈丅丐三且丆::下不丕丈万丑不丛下()));
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/module");
        }
        internal PGCompany.ModuleData.丁丄丅三丞丁万丟丟 丟万下丙丞丑下东丛()
        {
            return this.丏丌专万丙丝丝丈一(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞());
        }
        internal PGCompany.ModuleData.丁丄丅三丞丁万丟丟 七丂丅丗丂丏三丂三()
        {
            return this.丏丌专万丙丝丝丈一(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞() + 1);
        }
        private PGCompany.ModuleData.丁丄丅三丞丁万丟丟 丏丌专万丙丝丝丈一(int 丞丌东丟且丒丐丑丂)
        {
            int val_7;
            System.Collections.Generic.Dictionary<System.Int32, 丁丄丅三丞丁万丟丟> val_8;
            val_7 = 丞丌东丟且丒丐丑丂;
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            val_8 = val_1.Ups;
            if((val_8.ContainsKey(key:  val_7)) != true)
            {
                    val_8 = this.丆丏一丞丘丆丕丛丅();
                val_7 = UnityEngine.Mathf.Clamp(value:  val_7, min:  val_8, max:  this.丙丑丈七丞下丈丞与());
            }
            
            PGCompany.ModuleData val_6 = this.丁专丗万三上丟三丆();
            if(val_6.Ups != null)
            {
                    return val_6.Ups.Item[val_7];
            }
            
            return val_6.Ups.Item[val_7];
        }
        public int 丏丈丁专专丘丒丂丂()
        {
            int val_5 = this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞());
            val_5 = (this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞() + 1)) - val_5;
            return (int)val_5;
        }
        internal int 丌与一丏丏丌不不丒()
        {
            return UnityEngine.Mathf.Max(a:  this.丏丈丁专专丘丒丂丂() - this.且丆丟业丞丕丑上且(), b:  0);
        }
        internal int 专专丛丞丌丞丒丁丟()
        {
            var val_3;
            if(this.丟丟丁丐万万业丕与() != false)
            {
                    val_3 = 0;
                return (int)val_3;
            }
            
            val_3 = this - this.丗不丞三丄丞下丏且();
            return (int)val_3;
        }
        public int 且丆丟业丞丕丑上且()
        {
            return UnityEngine.Mathf.Max(a:  this.丗不丞三丄丞下丏且() - (this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  this.丑业世丞上丂丄丟丞())), b:  0);
        }
        internal int 丗不丞三丄丞下丏且()
        {
            var val_6;
            var val_7;
            val_6 = this;
            if(this != null)
            {
                    val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                PGCompany.丝丟丅丏丟丞不丌七 val_3 = val_6.上丟丘下世七与丁世<PGCompany.丝丟丅丏丟丞不丌七>(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
                if(val_3 == null)
            {
                    return (int)val_7;
            }
            
                int val_4 = val_3.丂丁丏一丙丛业且丌();
                return (int)val_7;
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        internal int 且七万业丄丌丕丏三(int 丞丌东丟且丒丐丑丂)
        {
            var val_2;
            int val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = Progress.万丅丆丌丂丛专业丅.丘丆万丄丛丗丆丙专;
            if(val_3 > 丞丌东丟且丒丐丑丂)
            {
                    val_4 = 0;
                return (int)val_1.CountForUp.七丄不丐丗三丝丑一;
            }
            
            do
            {
                丁丄丅三丞丁万丟丟 val_1 = this.丏丌专万丙丝丝丈一(丞丌东丟且丒丐丑丂:  val_3);
                val_3 = val_3 + 1;
            }
            while(val_3 <= 丞丌东丟且丒丐丑丂);
            
            return (int)val_1.CountForUp.七丄不丐丗三丝丑一;
        }
        internal int 丟丝业世丞三世丛丑(int 丛丛丆丛丏丟业万上)
        {
            var val_7;
            int val_8;
            int val_6 = 丛丛丆丛丏丟业万上;
            val_7 = this.丑业世丞上丂丄丟丞();
            val_8 = val_7 + 1;
            if(val_8 > this.丙丑丈七丞下丈丞与())
            {
                    return (int)val_7;
            }
            
            val_6 = this.丗不丞三丄丞下丏且() + val_6;
            do
            {
                val_7 = ((this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  val_8)) > val_6) ? (val_7) : (val_8);
                val_8 = val_8 + 1;
            }
            while(val_8 <= this.丙丑丈七丞下丈丞与());
            
            return (int)val_7;
        }
        internal bool 丙丅丗丏丆丆世世丙()
        {
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            return val_1.Ups.ContainsKey(key:  this.丑业世丞上丂丄丟丞() + 1);
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            ModuleType val_5;
            string val_6;
            if((System.String.IsNullOrEmpty(value:  this.且丞世丘丞一不不三)) == false)
            {
                goto label_1;
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_2;
            }
            
            val_5 = val_3.Type;
            goto label_3;
            label_1:
            val_6 = this.且丞世丘丞一不不三;
            return val_4;
            label_2:
            val_5 = 0;
            label_3:
            string val_4 = System.String.Format(format:  "{0}_{1}_{2}", arg0:  "Module_Name", arg1:  this.与丐丑丄专丑丕丌丘(), arg2:  val_5);
            this.且丞世丘丞一不不三 = val_4;
            return val_4;
        }
        internal override string 东且丏丆万与东丙万()
        {
            ModuleType val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  this.丏丆丒丕丛丄七丘丄)) == false)
            {
                goto label_1;
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_2;
            }
            
            val_6 = val_3.Type;
            goto label_3;
            label_1:
            val_7 = this.丏丆丒丕丛丄七丘丄;
            return (string)I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  string val_4 = System.String.Format(format:  "{0}_{1}_{2}", arg0:  "Module_Description", arg1:  this.与丐丑丄专丑丕丌丘(), arg2:  val_6 = 0));
            label_2:
            label_3:
            this.丏丆丒丕丛丄七丘丄 = val_4;
            return (string)I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            ModuleType val_24;
            ModuleType val_25;
            ModuleType val_26;
            ModuleCategory val_28;
            ModuleType val_29;
            ModuleType val_30;
            ModuleType val_31;
            ModuleCategory val_33;
            if(this.三与丕丘丌丈一丆七 != 0)
            {
                    return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
            }
            
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_24 = val_2.Type;
            }
            
            if((PGCompany.丄丅丕下丙丈丏三一.丟丒万东东丂下七丘(丁丅丈丌丟世丗丗丟:  val_24)) != false)
            {
                    if((this.丁专丗万三上丟三丆() == null) || (val_4.Category != 7))
            {
                goto label_7;
            }
            
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_8;
            }
            
            val_25 = val_5.Type;
            goto label_9;
            label_7:
            object[] val_6 = new object[4];
            val_6[0] = "OfferIcons/Mods/";
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_14;
            }
            
            val_26 = val_7.Type;
            goto label_15;
            label_8:
            val_25 = 0;
            label_9:
            string val_9 = System.String.Format(format:  "{0}Module_{1}_UP{2}", arg0:  "OfferIcons/Mods/", arg1:  val_25, arg2:  this.丑业世丞上丂丄丟丞());
            goto label_16;
            label_14:
            val_26 = 0;
            label_15:
            val_6[1] = val_26;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_28 = val_10.Category;
            }
            else
            {
                    val_28 = 0;
            }
            
            val_6[2] = val_28;
            val_6[3] = this.丑业世丞上丂丄丟丞();
            label_16:
            UnityEngine.Texture val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "{0}Module_{1}_{2}_UP{3}", args:  val_6));
            this.三与丕丘丌丈一丆七 = val_13;
            if(val_13 != 0)
            {
                    return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
            }
            
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_29 = val_15.Type;
            }
            
            if((PGCompany.丄丅丕下丙丈丏三一.丟丒万东东丂下七丘(丁丅丈丌丟世丗丗丟:  val_29)) != false)
            {
                    if((this.丁专丗万三上丟三丆() == null) || (val_17.Category != 7))
            {
                goto label_34;
            }
            
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_35;
            }
            
            val_30 = val_18.Type;
            goto label_36;
            label_34:
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_37;
            }
            
            val_31 = val_19.Type;
            goto label_38;
            label_35:
            val_30 = 0;
            label_36:
            string val_20 = System.String.Format(format:  "{0}Module_{1}_UP1", arg0:  "OfferIcons/Mods/", arg1:  val_30);
            goto label_39;
            label_37:
            val_31 = 0;
            label_38:
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_33 = val_21.Category;
            }
            else
            {
                    val_33 = 0;
            }
            
            label_39:
            this.三与丕丘丌丈一丆七 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "{0}Module_{1}_{2}_UP1", arg0:  "OfferIcons/Mods/", arg1:  val_31, arg2:  val_33));
            return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7131");
        }
        internal bool 丆丒七丈丅且丂丒丑()
        {
            ModuleType val_12;
            ModuleCategory val_13;
            ModuleType val_14;
            ModuleCategory val_15;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_12 = val_1.Type;
            }
            else
            {
                    val_12 = 0;
            }
            
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_13 = val_2.Category;
            }
            else
            {
                    val_13 = 0;
            }
            
            string val_3 = System.String.Format(format:  "Module_ShownInShop_{0}_{1}", arg0:  val_12, arg1:  val_13);
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_14 = val_4.Type;
            }
            else
            {
                    val_14 = 0;
            }
            
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_15 = val_5.Category;
            }
            else
            {
                    val_15 = 0;
            }
            
            string val_7 = System.String.Format(format:  "Module_ShownInShop_{0}_{1}_for_{2}", arg0:  val_14, arg1:  val_15, arg2:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            int val_8 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_3, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            if(((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_7)) == true) || ((val_8 & 2147483648) != 0))
            {
                    return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_7, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_7, 下下丏一丙不丘丌丞:  val_8, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_7, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
        }
        internal void 且且丛世丟丈世丄丄(bool 丙业与丙丗丝不丈东)
        {
            ModuleType val_5;
            ModuleCategory val_6;
            var val_7;
            string val_8;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_5 = val_1.Type;
            }
            else
            {
                    val_5 = 0;
            }
            
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_6 = val_2.Category;
            }
            else
            {
                    val_6 = 0;
            }
            
            string val_4 = System.String.Format(format:  "Module_ShownInShop_{0}_{1}_for_{2}", arg0:  val_5, arg1:  val_6, arg2:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            if(丙业与丙丗丝不丈东 != false)
            {
                    val_7 = 1;
                val_8 = val_4;
            }
            else
            {
                    val_8 = val_4;
                val_7 = 0;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_8, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            if(PGCompany.丏丂一丗丙世丏丐三.丕东丕丂且丏丆丝万 == null)
            {
                    return;
            }
            
            PGCompany.丏丂一丗丙世丏丐三.丕东丕丂且丏丆丝万.Invoke();
        }
        internal string 丕业丆丑丝丗丞且上()
        {
            ModuleCategory val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  this.丛丙丐万丑上且丒丛)) == false)
            {
                goto label_1;
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_2;
            }
            
            val_6 = val_2.Category;
            goto label_3;
            label_1:
            val_7 = this.丛丙丐万丑上且丒丛;
            return val_5;
            label_2:
            val_6 = 0;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            string val_5 = "shop_icons_" + val_6.ToString().ToLower();
            this.丛丙丐万丑上且丒丛 = val_5;
            return val_5;
        }
        internal string 丅七丑与丆丞丝且丟()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (string)System.String.alignConst;
            }
            
            if(val_1.Type > 24)
            {
                    return (string)System.String.alignConst;
            }
            
            var val_2 = 1;
            val_2 = val_2 << val_1.Type;
            val_2 = val_2 & 33554318;
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            label_6:
            System.String.alignConst = "%";
            return (string)System.String.alignConst;
            label_3:
            if(val_1.Type == 5)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7280");
            }
            
            if(val_1.Type != 6)
            {
                    return (string)System.String.alignConst;
            }
            
            goto label_6;
        }
        internal string 业丙与世东丑丈丐万()
        {
            ModuleType val_5;
            string val_6;
            if((System.String.IsNullOrEmpty(value:  this.丑丕丆与丘丘世丛东)) == false)
            {
                goto label_1;
            }
            
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_2;
            }
            
            val_5 = val_3.Type;
            goto label_3;
            label_1:
            val_6 = this.丑丕丆与丘丘世丛东;
            return val_4;
            label_2:
            val_5 = 0;
            label_3:
            string val_4 = System.String.Format(format:  "{0}_{1}_{2}", arg0:  "Module_Property", arg1:  this.与丐丑丄专丑丕丌丘(), arg2:  val_5);
            this.丑丕丆与丘丘世丛东 = val_4;
            return val_4;
        }
        internal string 丅业专丏不丒丄丐一()
        {
            return (string)System.String.Format(format:  "{0}{1}", arg0:  this.丞万丆丑且丟丑专丟(), arg1:  this.丅七丑与丆丞丝且丟());
        }
        internal UnityEngine.Color 丝一丙丝上丛三丄丈()
        {
            string val_2;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    ModuleType val_2 = val_1.Type;
                val_2 = val_2 - 1;
                if(val_2 <= 2)
            {
                    val_2 = mem[130690992 + ((val_1.Type - 1)) << 3];
                val_2 = 130690992 + ((val_1.Type - 1)) << 3;
                return PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_2 = "ModuleOthers");
            }
            
            }
            
            return PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_2);
        }
        internal bool 丟丒万东东丂下七丘()
        {
            ModuleType val_2;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return PGCompany.丄丅丕下丙丈丏三一.丟丒万东东丂下七丘(丁丅丈丌丟世丗丗丟:  val_2 = val_1.Type);
            }
            
            return PGCompany.丄丅丕下丙丈丏三一.丟丒万东东丂下七丘(丁丅丈丌丟世丗丗丟:  val_2);
        }
        private string 与丐丑丄专丑丕丌丘()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (string)(val_1.Category != 7) ? ("Weapon") : "Armor";
            }
            
            return (string)(val_1.Category != 7) ? ("Weapon") : "Armor";
        }
        private Rilisoft.丝丑丂丛万丐丈丘且 丟丂一丘丛与丝上七()
        {
            object val_5;
            var val_9;
            var val_10;
            var val_11;
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            Dictionary.Enumerator<TKey, TValue> val_2 = val_1.Ups.GetEnumerator();
            val_9 = 0;
            goto label_3;
            label_5:
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            label_3:
            if(((-490230016) & 1) != 0)
            {
                goto label_5;
            }
            
            val_10 = 0;
            val_11 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if( == 1)
            {
                goto label_13;
            }
            
            if(( == 0) || (74 != 74))
            {
                goto label_18;
            }
            
            goto label_18;
            label_13:
            label_18:
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_7.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_7.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_7.上万三丆专丏丒丗业};
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            var val_5;
            var val_6;
            PGCompany.ModuleData val_1 = this.丁专丗万三上丟三丆();
            if(val_1 != null)
            {
                    val_5 = val_1.Price;
            }
            else
            {
                    val_5 = 0;
            }
            
            val_6 = null;
            val_6 = null;
            return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  (val_5 > 0) ? (val_5) : 10, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        internal override PGCompany.丐三丛丑丛丟七丕丛 丝丆丂丆不丟丌丕丝()
        {
            PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.ModuleData val_2 = this.丁专丗万三上丟三丆();
            if(val_1 != null)
            {
                    return val_1.一丌世丑丄东丞丘三<PGCompany.丐三丛丑丛丟七丕丛>(丞世不丒下上上丝丑:  val_2.PointData.Index);
            }
            
            return val_1.一丌世丑丄东丞丘三<PGCompany.丐三丛丑丛丟七丕丛>(丞世不丒下上上丝丑:  val_2.PointData.Index);
        }
        internal override int 丁丝丞与丟与丟丌三()
        {
            return this.丆丒丕下丝丂三丘丑();
        }
        public int 丁丕丁三丁丗不三丟()
        {
            return this.丑业世丞上丂丄丟丞();
        }
        public int 万丙东丙丐丕专丈丕()
        {
            return this.丙丑丈七丞下丈丞与();
        }
        internal override string 丟七万东万七丙丘丌()
        {
            return this.世世上丕不丑丅七丆();
        }
        internal string 世世上丕不丑丅七丆()
        {
            int val_2 = System.String.alignConst;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            }
            
            ModuleCategory val_2 = val_1.Category;
            val_2 = val_2 - 1;
            if(val_2 > 6)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            }
            
            var val_3 = 106039580 + ((val_1.Category - 1)) << 2;
            val_3 = val_3 + 106039580;
            goto (106039580 + ((val_1.Category - 1)) << 2 + 106039580);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丏丂一丗丙世丏丐三(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
