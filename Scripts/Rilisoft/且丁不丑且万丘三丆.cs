using UnityEngine;

namespace Rilisoft
{
    public class 且丁不丑且万丘三丆
    {
        // Fields
        private static Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.且丁不丑且万丘三丆> 丝业丆丁业三丈丟东;
        private System.Collections.Generic.List<Rilisoft.EggDrop> <东丈丌不一丈丗丐丘>k__BackingField;
        
        // Properties
        internal static Rilisoft.且丁不丑且万丘三丆 丆丕丝丒不丙且丐丗 { get; }
        public System.Collections.Generic.List<Rilisoft.EggDrop> 业丑丗丂丙万一丆丐 { get; set; }
        
        // Methods
        private 且丁不丑且万丘三丆()
        {
            UnityEngine.TextAsset val_1 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "EggsAndPetsConfig_V2");
            if(val_1 == 0)
            {
                    return;
            }
            
            if(val_1.text == null)
            {
                    return;
            }
            
            bool val_5 = this.丛不丄与丅丘丙丁与(丞丕丒专一下丙业上:  val_1.text);
        }
        internal static Rilisoft.且丁不丑且万丘三丆 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.且丁不丑且万丘三丆.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.且丁不丑且万丘三丆.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.且丁不丑且万丘三丆.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        public System.Collections.Generic.List<Rilisoft.EggDrop> 世一丈丄万丁一上三()
        {
            return (System.Collections.Generic.List<Rilisoft.EggDrop>)this.<东丈丌不一丈丗丐丘>k__BackingField;
        }
        private void 丑一丘世丅丟丂下东(System.Collections.Generic.List<Rilisoft.EggDrop> 丙业与丙丗丝不丈东)
        {
            this.<东丈丌不一丈丗丐丘>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private bool 丛不丄与丅丘丙丁与(string 丞丕丒专一下丙业上)
        {
            var val_3;
            System.Collections.Generic.List<Rilisoft.EggDrop> val_1 = 0;
            if((Rilisoft.且丁不丑且万丘三丆.丟丈上丛丙丕业丁丐(一丄业丄丑且七丌东:  丞丕丒专一下丙业上, 七万七业丘丄不丘丑: out  val_1)) != false)
            {
                    val_3 = 1;
                this.<东丈丌不一丈丗丐丘>k__BackingField = val_1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        internal static bool 丟丈上丛丙丕业丁丐(string 一丄业丄丑且七丌东, out System.Collections.Generic.List<Rilisoft.EggDrop> 七万七业丘丄不丘丑)
        {
            var val_7;
            System.Object[] val_31;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32;
            float val_33;
            val_31 = 1152921542555515936;
            System.Collections.Generic.List<Rilisoft.EggDrop> val_1 = new System.Collections.Generic.List<Rilisoft.EggDrop>();
            七万七业丘丄不丘丑 = val_1;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  一丄业丄丑且七丌东)) != true)
            {
                    object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  一丄业丄丑且七丌东);
                object[] val_4 = new object[1];
                val_31 = val_4;
                val_31[0] = 七万七业丘丄不丘丑;
                UnityEngine.Debug.LogErrorFormat(format:  "parse eggs and pets config fail: \'{0}\'", args:  val_4);
            }
            
            return false;
            label_62:
            if(((-706084944) & 1) == 0)
            {
                goto label_13;
            }
            
            val_32 = val_7.丐丏七丌丕丗业且上();
            new 且丁不丑且万丘三丆.丌万一一业丝丁丈丝() = new System.Object();
            if(val_32 != null)
            {
                    val_32 = 0;
            }
            
            .丒丘丈丗丁丐丟丁丟 = ;
            if(new 且丁不丑且万丘三丆.丌万一一业丝丁丈丝() == null)
            {
                goto label_18;
            }
            
            label_49:
            if(new 且丁不丑且万丘三丆.丌万一一业丝丁丈丝() == null)
            {
                    val_32 = (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟;
            }
            
            if((val_32.ContainsKey(key:  "T")) == false)
            {
                goto label_62;
            }
            
            object val_12 = (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.Item["T"];
            if(val_12 == null)
            {
                goto label_62;
            }
            
            System.Nullable<T> val_13 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<PGCompany.EggRarity>(下业七不丑丂丏丟东:  val_12, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-706084904) & 1) == 0)
            {
                goto label_62;
            }
            
            int val_16 = 0;
            if(((且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.ContainsKey(key:  "HATCHING_TIME")) != false)
            {
                    bool val_17 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.Item["HATCHING_TIME"], 丙业与丙丗丝不丈东: out  val_16);
            }
            
            int val_20 = 0;
            if(((且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.ContainsKey(key:  "HATCHING_SPEED_UP")) != false)
            {
                    bool val_21 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.Item["HATCHING_SPEED_UP"], 丙业与丙丗丝不丈东: out  val_20);
            }
            
            if(((且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.ContainsKey(key:  "PCH")) != false)
            {
                    bool val_25 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟.Item["PCH"], 丙业与丙丗丝不丈东: out  float val_24 = -3.216052E+13f);
            }
            
            new Rilisoft.EggDrop() = new Rilisoft.EggDrop();
            if(new Rilisoft.EggDrop() == null)
            {
                goto label_47;
            }
            
            .HatchingTime = 0;
            .Rarity = ;
            .SpeedUpPrice = 0;
            val_33 = 0f;
            goto label_48;
            label_18:
            if((且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟 != null)
            {
                goto label_49;
            }
            
            object[] val_27 = new object[1];
            val_27[0] = (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丒丘丈丗丁丐丟丁丟;
            UnityEngine.Debug.LogErrorFormat(format:  "parse eggs and pets config fail: unknown row format : \'{0}\'", args:  val_27);
            goto label_62;
            label_47:
            .Rarity = ;
            mem[16] = val_16;
            mem[40] = val_20;
            val_33 = 0f;
            label_48:
            .ProcChance = val_33;
            .丈不业下丌七丆丒丙 = new Rilisoft.EggDrop();
            val_1.Add(item:  new Rilisoft.EggDrop());
            System.Func<ItemRarity, Rilisoft.PetDrop> val_28 = new System.Func<ItemRarity, Rilisoft.PetDrop>(object:  new 且丁不丑且万丘三丆.丌万一一业丝丁丈丝(), method:  Rilisoft.PetDrop 且丁不丑且万丘三丆.丌万一一业丝丁丈丝::丆且丞丟丆丙且丁七(ItemRarity 丈下丑丆上丏丗丈专));
            .丂丒且丒丂丟丙丏东 = null;
            System.Collections.Generic.List<Rilisoft.PetDrop> val_29 = new System.Collections.Generic.List<Rilisoft.PetDrop>();
            (且丁不丑且万丘三丆.丌万一一业丝丁丈丝)[1152921542555536352].丈不业下丌七丆丒丙.PetDrops = null;
            System.Action<ItemRarity> val_30 = new System.Action<ItemRarity>(object:  new 且丁不丑且万丘三丆.丌万一一业丝丁丈丝(), method:  System.Void 且丁不丑且万丘三丆.丌万一一业丝丁丈丝::丕不丂丈丌丌丌丙丏(ItemRarity 丈下丑丆上丏丗丈专));
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<ItemRarity>(七丐丅专且专七三丆:  null);
            goto label_62;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return false;
        }
        private static 且丁不丑且万丘三丆()
        {
            null = null;
            Rilisoft.且丁不丑且万丘三丆.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.且丁不丑且万丘三丆>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.且丁不丑且万丘三丆>(object:  且丁不丑且万丘三丆.<>c.<>9, method:  Rilisoft.且丁不丑且万丘三丆 且丁不丑且万丘三丆.<>c::丗丅七与不丂东丆东()));
        }
    
    }

}
