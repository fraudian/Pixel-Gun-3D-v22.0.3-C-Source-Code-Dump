using UnityEngine;

namespace PGCompany
{
    internal sealed class 丈三丁三丂一丅丆丆
    {
        // Fields
        private static PGCompany.丈三丁三丂一丅丆丆 丝业丆丁业三丈丟东;
        private System.Collections.Generic.List<PGCompany.ArmorSkinSettings> 七上丅专下丄丆丆丆;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.ArmorSkinSettings>> 丐丆丆丝不上丗且丐;
        internal const string 与丆丞世与上丏丂丒 = "Armor";
        
        // Properties
        internal static PGCompany.丈三丁三丂一丅丆丆 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal 丈三丁三丂一丅丆丆()
        {
            System.Collections.Generic.List<PGCompany.ArmorSkinSettings> val_1 = this.丟丂世丒不世丑丘丁();
            this.七上丅专下丄丆丆丆 = val_1;
            this.丐丆丆丝不上丗且丐 = val_1.丕丑丙万专丝丄且专(业丑下丌丟业丕丕丝:  val_1);
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丈三丁三丂一丅丆丆::丟下丘与东业丞不专()));
        }
        internal static PGCompany.丈三丁三丂一丅丆丆 丑七不且上丗丁一世()
        {
            PGCompany.丈三丁三丂一丅丆丆.丙丌专东丌丏东丗丕();
            return (PGCompany.丈三丁三丂一丅丆丆)PGCompany.丈三丁三丂一丅丆丆.与丆丞世与上丏丂丒;
        }
        internal static void 丙丌专东丌丏东丗丕()
        {
            PGCompany.丈三丁三丂一丅丆丆 val_2;
            if(PGCompany.丈三丁三丂一丅丆丆.与丆丞世与上丏丂丒 != null)
            {
                    return;
            }
            
            PGCompany.丈三丁三丂一丅丆丆 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丈三丁三丂一丅丆丆();
            PGCompany.丈三丁三丂一丅丆丆.与丆丞世与上丏丂丒 = val_2;
        }
        internal System.Collections.Generic.List<PGCompany.ArmorSkinSettings> 不上丛丛丞万丒丝丈()
        {
            return (System.Collections.Generic.List<PGCompany.ArmorSkinSettings>)this.七上丅专下丄丆丆丆;
        }
        internal System.Collections.Generic.List<PGCompany.ArmorSkinSettings> 三丟丐东丗上东下万(int 且丂丟丈丈丑东丈丙)
        {
            var val_4;
            System.Collections.Generic.List<PGCompany.ArmorSkinSettings> val_1 = 0;
            bool val_2 = this.丐丆丆丝不上丗且丐.TryGetValue(key:  且丂丟丈丈丑东丈丙, value: out  val_1);
            val_4 = val_1;
            if(val_4 != 0)
            {
                    return (System.Collections.Generic.List<PGCompany.ArmorSkinSettings>)val_4;
            }
            
            System.Collections.Generic.List<PGCompany.ArmorSkinSettings> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.List<PGCompany.ArmorSkinSettings>();
            return (System.Collections.Generic.List<PGCompany.ArmorSkinSettings>)val_4;
        }
        internal PGCompany.ArmorSkinSettings 东一丐且东丙专丘丝(int 且丂丟丈丈丑东丈丙)
        {
            var val_6;
            System.Func<PGCompany.ArmorSkinSettings, System.Boolean> val_8;
            var val_9;
            System.Collections.Generic.List<PGCompany.ArmorSkinSettings> val_1 = 0;
            bool val_2 = this.丐丆丆丝不上丗且丐.TryGetValue(key:  且丂丟丈丈丑东丈丙, value: out  val_1);
            if(val_1 != 0)
            {
                    val_6 = null;
                val_6 = null;
                val_8 = 丈三丁三丂一丅丆丆.<>c.<>9__10_0;
                if(val_8 == null)
            {
                    System.Func<PGCompany.ArmorSkinSettings, System.Boolean> val_3 = null;
                val_8 = val_3;
                val_3 = new System.Func<PGCompany.ArmorSkinSettings, System.Boolean>(object:  丈三丁三丂一丅丆丆.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丈三丁三丂一丅丆丆.<>c::丝丌下丟一丅丟丗丑(PGCompany.ArmorSkinSettings 三丟东丕丄丄下下丑));
                丈三丁三丂一丅丆丆.<>c.<>9__10_0 = val_8;
            }
            
                PGCompany.ArmorSkinSettings val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.ArmorSkinSettings>(source:  val_1, predicate:  val_3);
                return (PGCompany.ArmorSkinSettings)val_9;
            }
            
            val_9 = 0;
            return (PGCompany.ArmorSkinSettings)val_9;
        }
        internal string 丒万丟世与专世丐东(int 丞世不丒下上上丝丑)
        {
            PGCompany.丙万丙下三下丄丌丄 val_2 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            if(val_2 != null)
            {
                    return val_2.业上丙丞丐丄丆丅七();
            }
            
            return val_2.业上丙丞丐丄丆丅七();
        }
        internal int 东丆下丞上丕丑丄丟(string 丞丅上丏丂且下丅与)
        {
            PGCompany.丂且专丕丞一上与一 val_1 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  70, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与);
            }
            
            return val_1.丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  70, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与);
        }
        internal PGCompany.ArmorSkinSettings 丒丗丁丞不上业万且(string 且丘世丏丛丛万丟万)
        {
            .且丘世丏丛丛万丟万 = 且丘世丏丛丛万丟万;
            return System.Linq.Enumerable.FirstOrDefault<PGCompany.ArmorSkinSettings>(source:  this.七上丅专下丄丆丆丆, predicate:  new System.Func<PGCompany.ArmorSkinSettings, System.Boolean>(object:  new 丈三丁三丂一丅丆丆.世东丒与丞七不不东(), method:  System.Boolean 丈三丁三丂一丅丆丆.世东丒与丞七不不东::丂一丝丅丟丐丈不丑(PGCompany.ArmorSkinSettings 三丟东丕丄丄下下丑)));
        }
        internal void 丝且丑业丅世丛丅七()
        {
            var val_4;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_20 = 1152921505290498048;
            List.Enumerator<T> val_2 = 七丌丞万七万丁丐丙.丈丅丄不丅七七丒专(七丆丒与丗丌丄且丂:  7).GetEnumerator();
            val_21 = 0;
            val_22 = 0;
            var val_19 = 0;
            label_36:
            if((2108296368 & 1) == 0)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_8 = this.三丟丐东丗上东下万(且丂丟丈丈丑东丈丙:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_4.丐丏七丌丕丗业且上())).GetEnumerator();
            goto label_16;
            label_20:
            string val_9 = val_4.丐丏七丌丕丗业且上();
            if((val_9.IsFree != false) && (val_9.IsFromAvatarSet != true))
            {
                    if(val_9.LevelOpen <= ExperienceController.丞丞丘业东丙丏七丌())
            {
                    new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_9.SkinIndex);
                val_19 = ;
                int val_17 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                .丒丙七专丒东业丘世 = 0;
                mem[1152921553959848280] = 0;
                PGCompany.丗丟丄丈东丝丕丄世 val_18 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            }
            
            }
            
            label_16:
            if((2108296336 & 1) != 0)
            {
                goto label_20;
            }
            
            val_19 = val_19 + 1;
            mem2[0] = 147;
            val_23 = val_22;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_19 == 1) || (null != 147))
            {
                goto label_33;
            }
            
            var val_20 = 0;
            val_20 = val_20 ^ (val_19 >> 31);
            val_19 = val_19 + val_20;
            goto label_36;
            label_33:
            if( == 0)
            {
                goto label_36;
            }
            
            goto label_36;
            label_4:
            val_19 = val_19 + 1;
            mem2[0] = 175;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_19 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(null == 175)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private System.Collections.Generic.List<PGCompany.ArmorSkinSettings> 丟丂世丒不世丑丘丁()
        {
            var val_4;
            T[] val_1 = UnityEngine.Resources.LoadAll<PGCompany.ArmorSkinSettings>(path:  "ArmorSkins");
            if(val_1 != null)
            {
                    val_4 = System.Linq.Enumerable.ToList<PGCompany.ArmorSkinSettings>(source:  val_1);
                if(val_4 != null)
            {
                    return (System.Collections.Generic.List<PGCompany.ArmorSkinSettings>)val_4;
            }
            
            }
            
            System.Collections.Generic.List<PGCompany.ArmorSkinSettings> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.List<PGCompany.ArmorSkinSettings>();
            return (System.Collections.Generic.List<PGCompany.ArmorSkinSettings>)val_4;
        }
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.ArmorSkinSettings>> 丕丑丙万专丝丄且专(System.Collections.Generic.List<PGCompany.ArmorSkinSettings> 业丑下丌丟业丕丕丝)
        {
            var val_13;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.ArmorSkinSettings>> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.ArmorSkinSettings>>();
            val_13 = 0;
            goto label_1;
            label_15:
            if((val_1.ContainsKey(key:  业丑下丌丟业丕丕丝.Item[0].ArmorIndex)) != true)
            {
                    val_1.set_Item(key:  业丑下丌丟业丕丕丝.Item[0].ArmorIndex, value:  new System.Collections.Generic.List<PGCompany.ArmorSkinSettings>());
            }
            
            val_1.Item[业丑下丌丟业丕丕丝.Item[0].ArmorIndex].Add(item:  业丑下丌丟业丕丕丝.Item[0]);
            val_13 = 1;
            label_1:
            if(val_13 < 业丑下丌丟业丕丕丝.Count)
            {
                goto label_15;
            }
            
            return val_1;
        }
        private void 丟下丘与东业丞不专()
        {
            this.丝且丑业丅世丛丅七();
            this.且世七丑东丒丙丐世();
        }
        private void 且世七丑东丒丙丐世()
        {
            var val_4;
            var val_21;
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            int val_26;
            val_21 = 1152921505290498048;
            val_22 = 七丌丞万七万丁丐丙.丈丅丄不丅七七丒专(七丆丒与丗丌丄且丂:  7);
            List.Enumerator<T> val_2 = val_22.GetEnumerator();
            val_23 = 1152921519126358176;
            val_24 = 1152921519126359200;
            val_25 = 1152921504848912384;
            goto label_16;
            label_26:
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_5)) == null)
            {
                    val_26 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_5);
                PGCompany.ArmorSkinSettings val_9 = PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世().东一丐且东丙专丘丝(且丂丟丈丈丑东丈丙:  val_26);
                if(val_9 == 0)
            {
                    val_22 = "No default skin settings for armor " + val_5 + ". Add setting with \'default\' checked and regenerate armor skins";
                UnityEngine.Debug.LogErrorFormat(format:  val_22, args:  System.Array.Empty<System.Object>());
            }
            else
            {
                    val_26 = new PGCompany.三东丏不丗世丅丌丄();
                val_26 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_9.SkinIndex);
                PGCompany.丗丟丄丈东丝丕丄世 val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_9.SkinIndex);
                val_22 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
                val_25 = val_25;
                val_21 = val_21;
                val_24 = val_24;
                val_23 = val_23;
                if((val_22 != null) && (null != null))
            {
                    val_22 = 0;
            }
            
                丆丟七丌丞东丆丕丌.万丂下七与三丘丈丈(丛丆世丂丒丁不世不:  val_22);
            }
            
            }
            
            label_16:
            if((2109019264 & 1) != 0)
            {
                goto label_26;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
    
    }

}
