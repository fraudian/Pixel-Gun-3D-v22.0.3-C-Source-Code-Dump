using UnityEngine;

namespace PGCompany
{
    internal class ModulesController : Singleton<PGCompany.ModulesController>
    {
        // Fields
        private static System.Action 丄丐丛万丐丏且丝不;
        private static readonly string 丛丑世丐丐且丅与东;
        private static readonly string 且丝丌且丕万丛专丄;
        private PGCompany.ModulesContainer 世丂上丌丞且丁七丏;
        private System.Collections.Generic.Dictionary<string, PGCompany.ModuleData> 丗丐与世七丐丂丏三;
        private System.Collections.Generic.Dictionary<string, PGCompany.ModulePointData> 丒丒专丅丄丏且业丈;
        private System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丝东丄上丒专与丈丐;
        private System.Collections.Generic.List<PGCompany.丝丟丅丏丟丞不丌七> 业下丂与丑丌丑七丑;
        internal System.Collections.Generic.Dictionary<string, PGCompany.丗丟丅七东丄丙丟上> 丌丏三专丟下丈万三;
        internal PGCompany.且丟一七万东丁三上<PGCompany.丗丟丅七东丄丙丟上> 丐丅东丕与丆业丒丌;
        private PGCompany.丁丞丐丈丒七丟丛七 与丙丈丅丆丆丌丁丄;
        private UnityEngine.Coroutine 丂丐丐世丑一与丑丌;
        private const int 丒不上一丞与丌业丐 = 1;
        
        // Properties
        internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丕且且丘丈丏丁丈专 { get; }
        internal System.Collections.Generic.List<PGCompany.丝丟丅丏丟丞不丌七> 东丑专丘丘丐万丛丝 { get; }
        
        // Methods
        internal static void 丆丏专丘丌且丅三一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  PGCompany.ModulesController.丒不上一丞与丌业丐, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 下丕与一业丌且丝丗(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  PGCompany.ModulesController.丒不上一丞与丌业丐, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丂东专一万丅专东专()
        {
            return System.Linq.Enumerable.ToList<PGCompany.丏丂一丗丙世丏丐三>(source:  this.丝东丄上丒专与丈丐);
        }
        internal System.Collections.Generic.List<PGCompany.丝丟丅丏丟丞不丌七> 不三丗丈丁东不丝丅()
        {
            return System.Linq.Enumerable.ToList<PGCompany.丝丟丅丏丟丞不丌七>(source:  this.业下丂与丑丌丑七丑);
        }
        internal bool 与丁上丌丝丟丑一丏()
        {
            return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.modules");
        }
        private void OnInstanceCreated()
        {
            this.与丙丈丅丆丆丌丁丄 = PGCompany.丁丞丐丈丒七丟丛七.丑七不且上丗丁一世();
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.ModulesController::丗与丙上丂丗丂丄万(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.ModulesController::丗与丙上丂丗丂丄万(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModulesController::且丛一三业丈丝丞丅()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModulesController::且丛一三业丈丝丞丅()));
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModulesController::丁与丄下业万七东七()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModulesController::丁与丄下业万七东七()));
            this.且丛一三业丈丝丞丅();
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModulesController::丏上丛丐且丒世丆丕()));
            this.丁与丄下业万七东七();
        }
        internal void 丁万丟丕东丅丕丌丗()
        {
            this.丟丐丅下丂东丞丆丐();
            this.世丁丒丅丝丂七专丏();
        }
        internal void 世丁丒丅丝丂七专丏()
        {
            if(ExperienceController.丞丞丘业东丙丏七丌() < 6)
            {
                    return;
            }
            
            this.丆丆丗下丆丄丁丛下(一与三丑下专专丐东:  7);
            this.丆丆丗下丆丄丁丛下(一与三丑下专专丐东:  PGCompany.七丆丆丕丂丙丕丐丂.丌丐丐丑丈一丛丗丕(七丆丒与丗丌丄且丂:  0));
        }
        private void 丟丐丅下丂东丞丆丐()
        {
            List.Enumerator<T> val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂<PGCompany.三丘丌上丁万丏丛丟>(丁丅丈丌丟世丗丗丟:  136, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}).GetEnumerator();
            label_6:
            if(((-340089352) & 1) == 0)
            {
                goto label_3;
            }
            
            丐东不丅丂丂丅丙不.丌丟丆不丄专丐不丂(上丁丗丐丝丛丝世丂:  0.丐丏七丌丕丗业且上());
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丁与丄下业万七东七()
        {
            if(this.丂丐丐世丑一与丑丌 != null)
            {
                    this.StopCoroutine(routine:  this.丂丐丐世丑一与丑丌);
            }
            
            this.丂丐丐世丑一与丑丌 = this.StartCoroutine(routine:  this.与丅丒世丅丑与三丂());
        }
        private System.Collections.IEnumerator 与丅丒世丅丑与三丂()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ModulesController.丘丆下丛丙丒丕东丅();
        }
        internal bool 丙丝丞一下上丅下与()
        {
            System.Collections.Generic.List<PGCompany.ModuleData> val_7;
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  36)) != false)
            {
                    if(((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  37)) != true) && (this.世丂上丌丞且丁七丏 != null))
            {
                    val_7 = this.世丂上丌丞且丁七丏.Modules_v2;
                if(val_7 == null)
            {
                    return (bool)val_7;
            }
            
                var val_6 = (val_7.Count > 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        private void 丏上丛丐且丒世丆丕()
        {
            if(this.丌丏三专丟下丈万三 != null)
            {
                    this.丌丏三专丟下丈万三.Clear();
            }
            
            if(this.丐丅东丕与丆业丒丌 == null)
            {
                    return;
            }
            
            this.丐丅东丕与丆业丒丌.Clear();
        }
        private void 丗与丙上丂丗丂丄万(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 14)
            {
                    return;
            }
            
            this.且丛一三业丈丝丞丅();
        }
        private PGCompany.不丑一丕丑业七下三 丐上万丈不丄丟丂丞(三丅丁丗丗丝丂万且 三丐三丞丘丕不丒专)
        {
            System.Collections.Generic.List<PGCompany.不丑一丕丑业七下三> val_5;
            PGCompany.ModulesContainer val_6;
            var val_7;
            var val_8;
            val_5 = this;
            val_6 = this.世丂上丌丞且丁七丏;
            if(this.世丂上丌丞且丁七丏.Storages == null)
            {
                goto label_2;
            }
            
            val_6 = PGCompany.七丆丆丕丂丙丕丐丂.丁丄丝业丘且下业丌(丛丞丈丞丂三丐丂丐:  三丐三丞丘丕不丒专);
            val_7 = 0;
            goto label_4;
            label_11:
            PGCompany.不丑一丕丑业七下三 val_2 = this.世丂上丌丞且丁七丏.Storages.Item[0];
            if(val_2.Rarity == val_6)
            {
                goto label_8;
            }
            
            val_7 = 1;
            label_4:
            if(val_7 < this.世丂上丌丞且丁七丏.Storages.Count)
            {
                goto label_11;
            }
            
            label_2:
            val_8 = 0;
            return (PGCompany.不丑一丕丑业七下三)val_5.Item[0];
            label_8:
            val_5 = this.世丂上丌丞且丁七丏.Storages;
            return (PGCompany.不丑一丕丑业七下三)val_5.Item[0];
        }
        private PGCompany.不丑一丕丑业七下三 世业丞上且丟不一丈()
        {
            System.Collections.Generic.List<PGCompany.不丑一丕丑业七下三> val_3;
            var val_4;
            System.Func<PGCompany.不丑一丕丑业七下三, System.Boolean> val_6;
            var val_7;
            val_3 = this;
            if(this.世丂上丌丞且丁七丏.Storages != null)
            {
                    val_3 = this.世丂上丌丞且丁七丏.Storages;
                val_4 = null;
                val_4 = null;
                val_6 = ModulesController.<>c.<>9__29_0;
                if(val_6 == null)
            {
                    System.Func<PGCompany.不丑一丕丑业七下三, System.Boolean> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Func<PGCompany.不丑一丕丑业七下三, System.Boolean>(object:  ModulesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModulesController.<>c::下丕专丌一丁丂不丞(PGCompany.不丑一丕丑业七下三 丁丂专业丁丅丅丈丙));
                ModulesController.<>c.<>9__29_0 = val_6;
            }
            
                PGCompany.不丑一丕丑业七下三 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.不丑一丕丑业七下三>(source:  val_3, predicate:  val_1);
                return (PGCompany.不丑一丕丑业七下三)val_7;
            }
            
            val_7 = 0;
            return (PGCompany.不丑一丕丑业七下三)val_7;
        }
        internal PGCompany.丗丟丅七东丄丙丟上 下丗且丆七丛丕与丕()
        {
            PGCompany.且丟一七万东丁三上<PGCompany.丗丟丅七东丄丙丟上> val_6;
            PGCompany.丗丟丅七东丄丙丟上 val_8;
            val_6 = this;
            val_8 = this.世业丞上且丟不一丈();
            if(val_8 == null)
            {
                    return (PGCompany.丗丟丅七东丄丙丟上)val_6.Item[val_2];
            }
            
            int val_2 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  "Armor_Army_1");
            if((this.丐丅东丕与丆业丒丌.ContainsKey(下上丐丆丝丟丝丒不:  val_2)) != true)
            {
                    PGCompany.丗丟丅七东丄丙丟上 val_4 = null;
                val_8 = val_4;
                val_4 = new PGCompany.丗丟丅七东丄丙丟上(下丞丝丂东东丛丗世:  val_2, 丄且与下丂丗丙丗丂:  val_1.Rarity, 丁丝丟东上专丑丗丆:  7);
                this.丐丅东丕与丆业丒丌.Add(下上丐丆丝丟丝丒不:  val_2, 丙业与丙丗丝不丈东:  val_4);
            }
            
            val_6 = this.丐丅东丕与丆业丒丌;
            return (PGCompany.丗丟丅七东丄丙丟上)val_6.Item[val_2];
        }
        private PGCompany.丗丟丅七东丄丙丟上 丅不丌上东丌丑丞丑(string 丞一丁业丄一一业且, System.Nullable<int> 丅丞一专丑业与东丒)
        {
            ModuleCategory val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            System.Collections.Generic.List<丘丛丝丘丐丄丑三丐> val_23;
            val_19 = 丞一丁业丄一一业且;
            三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_19);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_18 = this.丐上万丈不丄丟丂丞(三丐三丞丘丕不丒专:  val_1);
            if(val_18 == null)
            {
                goto label_4;
            }
            
            if(((-338636936) & 1) == 0)
            {
                goto label_5;
            }
            
            goto label_12;
            label_4:
            val_21 = 0;
            return (PGCompany.丗丟丅七东丄丙丟上)val_21;
            label_5:
            丕丑丙丑丙东丌丘丕 val_4 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_19);
            if(val_4 != null)
            {
                    int val_5 = val_4.丈一下下丞世三丑丄();
            }
            else
            {
                    val_20 = val_1;
            }
            
            label_12:
            val_22 = 0;
            goto label_13;
            label_20:
            val_23 = this.世丂上丌丞且丁七丏.Energyes.Item[0];
            if(val_7.Level == val_20.七丙丛与万且专三三())
            {
                goto label_17;
            }
            
            val_22 = 1;
            label_13:
            val_23 = this.世丂上丌丞且丁七丏.Energyes;
            if(val_22 < val_23.Count)
            {
                goto label_20;
            }
            
            goto label_24;
            label_17:
            丘丛丝丘丐丄丑三丐 val_9 = this.世丂上丌丞且丁七丏.Energyes.Item[0];
            label_24:
            ModuleCategory val_11 = PGCompany.七丆丆丕丂丙丕丐丂.丌丐丐丑丈一丛丗丕(七丆丒与丗丌丄且丂:  val_1.丒万丕七专不丏丞丌());
            val_21 = 0;
            if(( & 1) == 0)
            {
                    return (PGCompany.丗丟丅七东丄丙丟上)val_21;
            }
            
            if(((-338636936) & 1) != 0)
            {
                    val_19 = val_2.Rarity;
                val_18 = ;
                PGCompany.丗丟丅七东丄丙丟上 val_13 = null;
                val_21 = val_13;
                val_13 = new PGCompany.丗丟丅七东丄丙丟上(下丞丝丂东东丛丗世:  val_1.业东丅东丌上丗丑不(), 丄且与下丂丗丙丗丂:  val_19, 丁丝丟东上专丑丗丆:  0);
                return (PGCompany.丗丟丅七东丄丙丟上)val_21;
            }
            
            if((this.丌丏三专丟下丈万三.ContainsKey(key:  val_19)) != true)
            {
                    PGCompany.丗丟丅七东丄丙丟上 val_16 = null;
                val_18 = val_16;
                val_16 = new PGCompany.丗丟丅七东丄丙丟上(下丞丝丂东东丛丗世:  val_1.业东丅东丌上丗丑不(), 丄且与下丂丗丙丗丂:  val_2.Rarity, 丁丝丟东上专丑丗丆:  0);
                this.丌丏三专丟下丈万三.Add(key:  val_19, value:  val_16);
            }
            
            val_21 = this.丌丏三专丟下丈万三.Item[val_19];
            return (PGCompany.丗丟丅七东丄丙丟上)val_21;
        }
        internal PGCompany.丗丟丅七东丄丙丟上 七丗丒丆一丛丞丁丌(int 丞世不丒下上上丝丑)
        {
            PGCompany.丙万丙下三下丄丌丄 val_2 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            if(val_2 != null)
            {
                    if(this != null)
            {
                    return this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_2.业上丙丞丐丄丆丅七(), 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
                return this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_2.业上丙丞丐丄丆丅七(), 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            if(this != null)
            {
                    return this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_2.业上丙丞丐丄丆丅七(), 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            return this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_2.业上丙丞丐丄丆丅七(), 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        internal PGCompany.丗丟丅七东丄丙丟上 七丗丒丆一丛丞丁丌(string 丈丁丄丘丛世七丙丝)
        {
            return this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  丈丁丄丘丛世七丙丝, 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        internal PGCompany.ModuleData 丒丛一丗丕丆一与一(string 丕且丏丞业业一上丕)
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.ModuleData> val_3 = this.丗丐与世七丐丂丏三;
            if(val_3 == null)
            {
                    return (PGCompany.ModuleData)val_3;
            }
            
            if((val_3.ContainsKey(key:  丕且丏丞业业一上丕)) != false)
            {
                    PGCompany.ModuleData val_2 = this.丗丐与世七丐丂丏三.Item[丕且丏丞业业一上丕];
                return (PGCompany.ModuleData)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.ModuleData)val_3;
        }
        internal PGCompany.ModulePointData 丒丕不世丈七丏丛丌(string 丟业丏丐下丙下丏万)
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.ModulePointData> val_3 = this.丒丒专丅丄丏且业丈;
            if(val_3 == null)
            {
                    return (PGCompany.ModulePointData)val_3;
            }
            
            if((val_3.ContainsKey(key:  丟业丏丐下丙下丏万)) != false)
            {
                    PGCompany.ModulePointData val_2 = this.丒丒专丅丄丏且业丈.Item[丟业丏丐下丙下丏万];
                return (PGCompany.ModulePointData)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.ModulePointData)val_3;
        }
        internal bool 丒丘世丄丟丌且且专(string 丕且丏丞业业一上丕)
        {
            if(this.丗丐与世七丐丂丏三 == null)
            {
                    return (bool)this.丗丐与世七丐丂丏三;
            }
            
            return this.丗丐与世七丐丂丏三.ContainsKey(key:  丕且丏丞业业一上丕);
        }
        internal PGCompany.丏丂一丗丙世丏丐三 万丑丗丗万丕丏丝与(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_4;
            var val_5;
            val_4 = this;
            ModulesController.丟丑不七不丆业丐丛 val_1 = new ModulesController.丟丑不七不丆业丐丛();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丕上业丕丘上丘七一 = 丕上业丕丘上丘七一;
            if(丕上业丕丘上丘七一 == null)
            {
                goto label_2;
            }
            
            label_4:
            val_4 = this.丝东丄上丒专与丈丐;
            PGCompany.丏丂一丗丙世丏丐三 val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丏丂一丗丙世丏丐三>(source:  val_4, predicate:  new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.丟丑不七不丆业丐丛::丒丐丄专丛下丅业丞(PGCompany.丏丂一丗丙世丏丐三 东丝丄丝丙专丘三丏)));
            return (PGCompany.丏丂一丗丙世丏丐三)val_5;
            label_1:
            mem[16] = 丕上业丕丘上丘七一;
            if(mem[16] != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_5 = 0;
            return (PGCompany.丏丂一丗丙世丏丐三)val_5;
        }
        private void 且丛一三业丈丝丞丅()
        {
            System.Exception val_9;
            System.Collections.Generic.List<PGCompany.丝丟丅丏丟丞不丌七> val_40;
            var val_42;
            var val_43;
            var val_44;
            PGCompany.ModulePointData val_49;
            var val_50;
            var val_51;
            int val_52;
            this.丗丐与世七丐丂丏三.Clear();
            this.丒丒专丅丄丏且业丈.Clear();
            this.丝东丄上丒专与丈丐.Clear();
            val_40 = this.业下丂与丑丌丑七丑;
            val_40.Clear();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  14))) == true)
            {
                goto label_119;
            }
            
            val_40 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_39 = 0;
            val_39 = val_39 + 1;
            this.世丂上丌丞且丁七丏 = val_40;
            if((val_40 == null) || (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_4, typeof(public PGCompany.ModulesContainer DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<PGCompany.ModulesContainer>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8.Count) == 0))
            {
                goto label_119;
            }
            
            List.Enumerator<T> val_7 = this.世丂上丌丞且丁七丏.Modules_v2.GetEnumerator();
            val_42 = 0;
            val_43 = 0;
            label_69:
            if(((-337436192) & 1) == 0)
            {
                goto label_22;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            PGCompany.丙万丙下三下丄丌丄 val_13 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  val_10.Index);
            if(((val_13 == null) || (PGCompany.万且世丏丅丞丈上丝.丌下丅三与世丛业东() == null)) || ((PGCompany.万且世丏丅丞丈上丝.丌下丅三与世丛业东().ContainsKey(key:  val_13.业上丙丞丐丄丆丅七())) == false))
            {
                goto label_69;
            }
            
            PGCompany.ModuleData val_20 = PGCompany.万且世丏丅丞丈上丝.丌下丅三与世丛业东().Item[val_13.业上丙丞丐丄丆丅七()];
            val_20.Price = val_10.Price;
            System.Collections.Generic.Dictionary<System.Int32, 丁丄丅三丞丁万丟丟> val_22 = new System.Collections.Generic.Dictionary<System.Int32, 丁丄丅三丞丁万丟丟>();
            val_20.Ups = null;
            Dictionary.Enumerator<TKey, TValue> val_23 = val_10.GetEnumerator();
            label_45:
            if(((-337436240) & 1) == 0)
            {
                goto label_43;
            }
            
            ConfiguredValueTaskAwaiter val_25 = val_9.GetAwaiter();
            val_20.Ups.Add(key:  val_25._value._obj.丙东专丂世丈丏丁丂(), value:  val_25._value._obj);
            goto label_45;
            label_43:
            val_44 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_44 != 1) && (402 == 402))
            {
                    var val_40 = 0;
                val_40 = val_40 ^ 0;
                val_44 = val_44 + val_40;
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            this.丗丐与世七丐丂丏三.set_Item(key:  val_20.Id, value:  val_20);
            val_49 = val_20.PointData;
            if(val_20.PointData == null)
            {
                    val_49 = val_20.PointData;
            }
            
            this.丒丒专丅丄丏且业丈.set_Item(key:  val_20.PointData.Id, value:  val_49);
            if(((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  val_20.Index)) == false) || ((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  val_20.PointData.Index)) == false))
            {
                goto label_69;
            }
            
            this.丝东丄上丒专与丈丐.Add(item:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丂一丗丙世丏丐三>(丞世不丒下上上丝丑:  val_20.Index));
            this.业下丂与丑丌丑七丑.Add(item:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丝丟丅丏丟丞不丌七>(丞世不丒下上上丝丑:  val_20.PointData.Index));
            goto label_69;
            label_22:
            val_50 = 0 + 1;
            mem2[0] = 584;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_50 == 1)
            {
                goto label_109;
            }
            
            if(( == 0) || ((1152921555809018208 + ((0 + 1)) << 2) == 584))
            {
                goto label_119;
            }
            
            label_118:
            label_119:
            val_51 = null;
            val_51 = null;
            val_52 = PGCompany.ModulesController.丒不上一丞与丌业丐;
            if(val_52 == 0)
            {
                    return;
            }
            
            val_52 = PGCompany.ModulesController.丒不上一丞与丌业丐;
            if(val_52 == 0)
            {
                    val_52 = 0;
            }
            
            val_52.Invoke();
            return;
            label_109:
            if( != 0)
            {
                goto label_118;
            }
            
            goto label_119;
        }
        internal int 丗丝丄丐丗专丘业世(int 丈丘丝一丗下丈丐不)
        {
            object val_9;
            ModulesController.丄丁丒丄与丁七丆一 val_1 = null;
            val_9 = val_1;
            val_1 = new ModulesController.丄丁丒丄与丁七丆一();
            .丈丘丝一丗下丈丐不 = 丈丘丝一丗下丈丐不;
            if((System.Linq.Enumerable.FirstOrDefault<丘丛丝丘丐丄丑三丐>(source:  this.世丂上丌丞且丁七丏.Energyes, predicate:  new System.Func<丘丛丝丘丐丄丑三丐, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.丄丁丒丄与丁七丆一::丄世丟丌丌且丝丑与(PGCompany.ModulesContainer.丘丛丝丘丐丄丑三丐 丗丛不丁丑专专丂且)))) == null)
            {
                    return 0;
            }
            
            val_9 = ???;
            return 0;
        }
        internal int 业丛丕万丞丅丞丌下(int 丈丘丝一丗下丈丐不)
        {
            object val_9;
            ModulesController.且上且专丗一丛专丑 val_1 = null;
            val_9 = val_1;
            val_1 = new ModulesController.且上且专丗一丛专丑();
            .丈丘丝一丗下丈丐不 = 丈丘丝一丗下丈丐不;
            if((System.Linq.Enumerable.FirstOrDefault<丘丛丝丘丐丄丑三丐>(source:  this.世丂上丌丞且丁七丏.Energyes, predicate:  new System.Func<丘丛丝丘丐丄丑三丐, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.且上且专丗一丛专丑::业丆丆丌丗丟且上丄(PGCompany.ModulesContainer.丘丛丝丘丐丄丑三丐 丗丛不丁丑专专丂且)))) == null)
            {
                    return 0;
            }
            
            val_9 = ???;
            return 0;
        }
        internal float 丌丁丁丗丙不不丄一()
        {
            var val_5;
            System.Func<丘丛丝丘丐丄丑三丐, Rilisoft.丝丑丂丛万丐丈丘且> val_7;
            var val_9;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Int32> val_11;
            val_5 = null;
            val_5 = null;
            val_7 = ModulesController.<>c.<>9__42_0;
            if(val_7 == null)
            {
                    System.Func<丘丛丝丘丐丄丑三丐, Rilisoft.丝丑丂丛万丐丈丘且> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Func<丘丛丝丘丐丄丑三丐, Rilisoft.丝丑丂丛万丐丈丘且>(object:  ModulesController.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丝丑丂丛万丐丈丘且 ModulesController.<>c::丑丒丏且万不丆丄丗(PGCompany.ModulesContainer.丘丛丝丘丐丄丑三丐 丗丛不丁丑专专丂且));
                ModulesController.<>c.<>9__42_0 = val_7;
            }
            
            val_9 = null;
            val_9 = null;
            val_11 = ModulesController.<>c.<>9__42_1;
            if(val_11 != null)
            {
                    return (float)(float)System.Linq.Enumerable.Max<Rilisoft.丝丑丂丛万丐丈丘且>(source:  System.Linq.Enumerable.Select<丘丛丝丘丐丄丑三丐, Rilisoft.丝丑丂丛万丐丈丘且>(source:  this.世丂上丌丞且丁七丏.Energyes, selector:  val_1), selector:  System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Int32> val_3 = null);
            }
            
            val_11 = val_3;
            val_3 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Int32>(object:  ModulesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ModulesController.<>c::业丘丝丄上丝丐且不(Rilisoft.丝丑丂丛万丐丈丘且 七丞丙丒三丕且丌丟));
            ModulesController.<>c.<>9__42_1 = val_11;
            return (float)(float)System.Linq.Enumerable.Max<Rilisoft.丝丑丂丛万丐丈丘且>(source:  System.Linq.Enumerable.Select<丘丛丝丘丐丄丑三丐, Rilisoft.丝丑丂丛万丐丈丘且>(source:  this.世丂上丌丞且丁七丏.Energyes, selector:  val_1), selector:  val_3);
        }
        internal string 丗东丈世一世丘丛下(string 三不三丟专丘东东丂, out ModulesSetGadgetsStorage.ModuleGadgetRecord 丕万丄丙世上与世丞)
        {
            string val_6 = 三不三丟专丘东东丂;
            丕万丄丙世上与世丞 = 0;
            PGCompany.丗丟丅七东丄丙丟上 val_1 = this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_6 = 三不三丟专丘东东丂, 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_1 == null)
            {
                    return 0;
            }
            
            val_6 = val_1.丆丟且丗丒不丄七丌();
            if(val_6 == null)
            {
                    return 0;
            }
            
            if(val_1.丆丟且丗丒不丄七丌().Count < 2)
            {
                    return 0;
            }
            
            return this.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_6, 丗丏丛丌丅东丟上丌: out  ModulesSetGadgetsStorage.ModuleGadgetRecord val_5 = 丕万丄丙世上与世丞);
        }
        internal string 丈一一丒丑丘丒丏丝(System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丐丆丄丆东丕丞丆下, out ModulesSetGadgetsStorage.ModuleGadgetRecord 丗丏丛丌丅东丟上丌)
        {
            int val_15;
            string val_17;
            val_15 = 1152921555810017488;
            ModulesController.丅三丈世丝丑专丂世 val_1 = new ModulesController.丅三丈世丝丑专丂世();
            .丐丆丄丆东丕丞丆下 = 丐丆丄丆东丕丞丆下;
            丗丏丛丌丅东丟上丌 = 0;
            val_17 = System.Linq.Enumerable.FirstOrDefault<丛东三丄丞上丑上专>(source:  this.世丂上丌丞且丁七丏.Sets, predicate:  new System.Func<丛东三丄丞上丑上专, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.丅三丈世丝丑专丂世::万丒与丕三与世上丆(PGCompany.ModulesContainer.丛东三丄丞上丑上专 丏丛与丅丛丌万专丌)));
            if(val_17 == null)
            {
                    return (string)val_8.gadgetUps.Item[val_15];
            }
            
            .与丒七与东不丈丅且 = val_3.Modules.Item[0];
            val_17 = val_3.Gadget;
            ModuleGadgetRecord val_8 = ModulesSetGadgetsStorage.Instance.丄丝丒与丆丛丙专丅(丗丄万丄丌丕丈丈三:  val_17);
            丗丏丛丌丅东丟上丌 = val_8;
            if(val_8 == null)
            {
                    return (string)val_8.gadgetUps.Item[val_15];
            }
            
            val_17 = val_8.gadgetUps.Count;
            val_15 = UnityEngine.Mathf.Clamp(value:  (System.Linq.Enumerable.First<PGCompany.丏丂一丗丙世丏丐三>(source:  (ModulesController.丅三丈世丝丑专丂世)[1152921555810021504].丐丆丄丆东丕丞丆下, predicate:  new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.丅三丈世丝丑专丂世::下丒七丄丞丑下丈丈(PGCompany.丏丂一丗丙世丏丐三 东丝丄丝丙专丘三丏))).丑业世丞上丂丄丟丞()) - 1, min:  0, max:  val_17 - 1);
            return (string)val_8.gadgetUps.Item[val_15];
        }
        internal System.Collections.Generic.List<PGCompany.ModulesContainer.丛东三丄丞上丑上专> 丙丄不专丐丑丘七丂()
        {
            if(this.世丂上丌丞且丁七丏 != null)
            {
                    return (System.Collections.Generic.List<丛东三丄丞上丑上专>)this.世丂上丌丞且丁七丏.Sets;
            }
            
            return (System.Collections.Generic.List<丛东三丄丞上丑上专>)this.世丂上丌丞且丁七丏.Sets;
        }
        internal System.Collections.Generic.List<Rilisoft.OfferItem> 丒丄丝丒丕丂丏丟丙()
        {
            if(this.世丂上丌丞且丁七丏.MigrateProperties == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<GenerationRule>(丈丆丕与丒丌丘丕且:  this.世丂上丌丞且丁七丏.MigrateProperties.Rules)) == false)
            {
                    return PGCompany.业丛丈丙丂且丌丑丙.东丂丝丘业丂丛丁丁(丑下丞上丈丌下丄下:  this.世丂上丌丞且丁七丏.MigrateProperties, 不丏下万下下万下世:  System.Linq.Enumerable.ToList<PGCompany.ModuleData>(source:  this.丗丐与世七丐丂丏三.Values));
            }
            
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)new System.Collections.Generic.List<Rilisoft.OfferItem>();
        }
        internal void 丆丝七业丗世丛丐下(string 三不三丟专丘东东丂)
        {
            string val_11 = 三不三丟专丘东东丂;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11 = 三不三丟专丘东东丂)) == true)
            {
                    return;
            }
            
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_11);
            if(val_2 == null)
            {
                    return;
            }
            
            this.丆丆丗下丆丄丁丛下(一与三丑下专专丐东:  PGCompany.七丆丆丕丂丙丕丐丂.丌丐丐丑丈一丛丗丕(七丆丒与丗丌丄且丂:  val_2.丒万丕七专不丏丞丌()));
            val_11 = this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_11, 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_11 == null)
            {
                    return;
            }
            
            if(val_11.丆丟且丗丒不丄七丌().Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_9 = val_11.丆丟且丗丒不丄七丌().GetEnumerator();
            label_12:
            if(((-335942440) & 1) == 0)
            {
                goto label_11;
            }
            
            val_11.丆专丆世专丐丈七专(丕上业丕丘上丘七一:  0.丐丏七丌丕丗业且上());
            goto label_12;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丁丐丆丟丈下丆丈世()
        {
            var val_7;
            this.丆丆丗下丆丄丁丛下(一与三丑下专专丐东:  7);
            val_7 = this.下丗且丆七丛丕与丕();
            if(val_7 == null)
            {
                    return;
            }
            
            if(val_7.丆丟且丗丒不丄七丌().Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_5 = val_7.丆丟且丗丒不丄七丌().GetEnumerator();
            label_6:
            if(((-335781288) & 1) == 0)
            {
                goto label_5;
            }
            
            val_7.丆专丆世专丐丈七专(丕上业丕丘上丘七一:  0.丐丏七丌丕丗业且上());
            goto label_6;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丆丆丗下丆丄丁丛下(PGCompany.ModuleData.ModuleCategory 一与三丑下专专丐东)
        {
            object val_14;
            System.Collections.Generic.IEnumerable<TSource> val_15;
            ModulesController.三丂丝丆丆丈丅丟且 val_1 = null;
            val_14 = val_1;
            val_1 = new ModulesController.三丂丝丆丆丈丅丟且();
            .一与三丑下专专丐东 = 一与三丑下专专丐东;
            val_15 = System.Linq.Enumerable.Cast<PGCompany.丏丂一丗丙世丏丐三>(source:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
            if((System.Linq.Enumerable.Any<PGCompany.丏丂一丗丙世丏丐三>(source:  val_15, predicate:  new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.三丂丝丆丆丈丅丟且::丟丗万七且与丑丏上(PGCompany.丏丂一丗丙世丏丐三 东丝丄丝丙专丘三丏)))) == true)
            {
                    return;
            }
            
            System.Func<PGCompany.ModuleData, System.Boolean> val_8 = null;
            val_15 = val_8;
            val_8 = new System.Func<PGCompany.ModuleData, System.Boolean>(object:  val_1, method:  System.Boolean ModulesController.三丂丝丆丆丈丅丟且::世丐业七丄业丆丛丏(PGCompany.ModuleData 丐丆丂丒丁万丈丛丅));
            PGCompany.ModuleData val_9 = System.Linq.Enumerable.FirstOrDefault<PGCompany.ModuleData>(source:  this.丗丐与世七丐丂丏三.Values, predicate:  val_8);
            if(val_9 == null)
            {
                    return;
            }
            
            val_14 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_15 = val_9.Index;
            PGCompany.三东丏不丗世丅丌丄 val_12 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_15);
            val_12.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
            PGCompany.丗丟丄丈东丝丕丄世 val_13 = val_14.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_12, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        internal void 丝下丐丏丁丂万丟且()
        {
            var val_7;
            string val_20;
            var val_21;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_23;
            val_20 = this;
            val_21 = null;
            val_21 = null;
            val_23 = ModulesController.<>c.<>9__50_0;
            if(val_23 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_2 = null;
                val_23 = val_2;
                val_2 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  ModulesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModulesController.<>c::不下丈丅丛与丗丘丅(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
                ModulesController.<>c.<>9__50_0 = val_23;
            }
            
            List.Enumerator<T> val_5 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三(), predicate:  val_2)).GetEnumerator();
            label_16:
            if(((-335370960) & 1) == 0)
            {
                goto label_9;
            }
            
            PGCompany.丗丟丅七东丄丙丟上 val_10 = this.丅不丌上东丌丑丞丑(丞一丁业丄一一业且:  val_7.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛(), 丅丞一专丑业与东丒:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_10 == null)
            {
                goto label_16;
            }
            
            ModulesSetGadgetsStorage.ModuleGadgetRecord val_13 = 0;
            string val_14 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_10.丆丟且丗丒不丄七丌(), 丗丏丛丌丅东丟上丌: out  val_13);
            if(val_13 == 0)
            {
                goto label_16;
            }
            
            ModulesSetGadgetsStorage.业丘丁丅业七丘丁丆(丗丑丐丕丟丝且下丕:  11993091);
            goto label_16;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.丗丟丅七东丄丙丟上 val_15 = this.下丗且丆七丛丕与丕();
            if(val_15 == null)
            {
                    return;
            }
            
            ModulesSetGadgetsStorage.ModuleGadgetRecord val_18 = 0;
            val_20 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            string val_19 = val_20.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_15.丆丟且丗丒不丄七丌(), 丗丏丛丌丅东丟上丌: out  val_18);
            if(val_18 == 0)
            {
                    return;
            }
            
            val_20 = 11993091;
            ModulesSetGadgetsStorage.业丘丁丅业七丘丁丆(丗丑丐丕丟丝且下丕:  val_20);
        }
        public static void AddAllModulesDEV()
        {
        
        }
        public static void AddAllMaxModulesDEV()
        {
        
        }
        public ModulesController()
        {
            this.世丂上丌丞且丁七丏 = new PGCompany.ModulesContainer();
            this.丗丐与世七丐丂丏三 = new System.Collections.Generic.Dictionary<System.String, PGCompany.ModuleData>();
            this.丒丒专丅丄丏且业丈 = new System.Collections.Generic.Dictionary<System.String, PGCompany.ModulePointData>();
            this.丝东丄上丒专与丈丐 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>();
            this.业下丂与丑丌丑七丑 = new System.Collections.Generic.List<PGCompany.丝丟丅丏丟丞不丌七>();
            this.丌丏三专丟下丈万三 = new System.Collections.Generic.Dictionary<System.String, PGCompany.丗丟丅七东丄丙丟上>();
            this.丐丅东丕与丆业丒丌 = new PGCompany.且丟一七万东丁三上<PGCompany.丗丟丅七东丄丙丟上>();
        }
        private static ModulesController()
        {
            PGCompany.ModulesController.丛丑世丐丐且丅与东 = "_";
            PGCompany.ModulesController.且丝丌且丕万丛专丄 = "weapon";
        }
    
    }

}
