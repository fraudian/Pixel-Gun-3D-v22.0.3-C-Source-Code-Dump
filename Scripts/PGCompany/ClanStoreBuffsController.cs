using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreBuffsController : PGBehaviour
    {
        // Fields
        internal static readonly string 丌丛丈丏丞且丐丐不;
        internal static readonly string 三丝专丗丑业丏七与;
        internal static readonly System.Collections.Generic.List<string> 下丘东下丕丒丑丟丅;
        internal static readonly System.Collections.Generic.Dictionary<string, 上七丑业丙丒丙东丏> 世丆丕丒下丝丝丗七;
        private static System.Action 东一丁丙丅丙世丏东;
        private static System.Action<PGCompany.三东丏不丗世丅丌丄> 丞丅丂丁丟东丟丝七;
        private static PGCompany.ClanStoreBuffsController 丝业丆丁业三丈丟东;
        private System.Collections.Generic.Dictionary<int, PGCompany.ClanStoreBuffsController.BuffTimeExtendParams> _buffTimeExtend;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.东丑丆丗丏丐丟下丄> 丂丟丕三丝丅专万丝;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.东丑丆丗丏丐丟下丄> 丂丂东一一丆万丄丛;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.东丑丆丗丏丐丟下丄> 丑丑万丛丆世且丙三;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.ClanStoreBuffSetting> 丂丑丙不万与丁丗丑;
        private PGCompany.ClanStoreBuffsConfig <一丘一丐丝丘且丞丅>k__BackingField;
        
        // Properties
        internal static PGCompany.ClanStoreBuffsController 丆丕丝丒不丙且丐丗 { get; }
        private System.Collections.Generic.Dictionary<int, PGCompany.ClanStoreBuffsController.BuffTimeExtendParams> 七世丘丝丑七丕丛业 { get; }
        internal PGCompany.ClanStoreBuffsConfig 一七且丗不丑丝且三 { get; set; }
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 万与丝世丈丆丅万丗 { get; }
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丌丏下丐丗丝丆专不 { get; }
        
        // Methods
        internal static void 上一七与东丘丘丕上(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东 != 1152921505570799648);
        
        }
        internal static void 世丐丘七丄一一一丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东 != 1152921505570799648);
        
        }
        internal static void 丛丟丌东三丆丆与丕(System.Action<PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanStoreBuffsController.丞丅丂丁丟东丟丝七, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreBuffsController.丞丅丂丁丟东丟丝七 != 1152921505570799656);
        
        }
        internal static void 且三丌丛丛丘丞丏丕(System.Action<PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanStoreBuffsController.丞丅丂丁丟东丟丝七, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreBuffsController.丞丅丂丁丟东丟丝七 != 1152921505570799656);
        
        }
        internal static PGCompany.ClanStoreBuffsController 丑七不且上丗丁一世()
        {
            var val_4;
            PGCompany.ClanStoreBuffsController val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.ClanStoreBuffsController.丝业丆丁业三丈丟东;
            if(val_5 == 0)
            {
                    val_6 = null;
                val_5 = new UnityEngine.GameObject(name:  "ClanStoreBuffsController [Singleton]").AddComponent<PGCompany.ClanStoreBuffsController>();
                val_6 = null;
                PGCompany.ClanStoreBuffsController.丝业丆丁业三丈丟东 = val_5;
            }
            else
            {
                    val_6 = null;
            }
            
            val_6 = null;
            return (PGCompany.ClanStoreBuffsController)PGCompany.ClanStoreBuffsController.丝业丆丁业三丈丟东;
        }
        private System.Collections.Generic.Dictionary<int, PGCompany.ClanStoreBuffsController.BuffTimeExtendParams> 万丌三丗丕丆下丐丛()
        {
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_1 = this._buffTimeExtend;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.下不三丏丄丈丅丛丟();
            val_1 = this._buffTimeExtend;
            return val_1;
        }
        internal PGCompany.ClanStoreBuffsConfig 世丈丁业丛上丘丗丐()
        {
            return (PGCompany.ClanStoreBuffsConfig)this.<一丘一丐丝丘且丞丅>k__BackingField;
        }
        private void 与丟与丂丞丒下七丐(PGCompany.ClanStoreBuffsConfig 丙业与丙丗丝不丈东)
        {
            this.<一丘一丐丝丘且丞丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.BuffData> 业丞丌丐丙东丁上不()
        {
            System.Collections.Generic.List<PGCompany.BuffData> val_2;
            if((this.<一丘一丐丝丘且丞丅>k__BackingField) != null)
            {
                    val_2 = this.<一丘一丐丝丘且丞丅>k__BackingField.Buffs;
                return (System.Collections.Generic.List<PGCompany.BuffData>)val_2;
            }
            
            System.Collections.Generic.List<PGCompany.BuffData> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<PGCompany.BuffData>();
            return (System.Collections.Generic.List<PGCompany.BuffData>)val_2;
        }
        internal PGCompany.ClanStoreBuffSetting 业丆丐丘丞上丅丕丛(int 丞世不丒下上上丝丑)
        {
            PGCompany.ClanStoreBuffSetting val_0;
            if((this.丂丑丙不万与丁丗丑.ContainsKey(key:  丞世不丒下上上丝丑)) == false)
            {
                    return val_0;
            }
            
            if(this.丂丑丙不万与丁丗丑 != null)
            {
                    return this.丂丑丙不万与丁丗丑.Item[丞世不丒下上上丝丑];
            }
            
            return this.丂丑丙不万与丁丗丑.Item[丞世不丒下上上丝丑];
        }
        private void Awake()
        {
            null = null;
            PGCompany.ClanStoreBuffsController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.丅与丌专丟一丝业三());
            this.丛且丐下世与丘丆丗();
            this.且丛一三业丈丝丞丅();
        }
        private void OnDestroy()
        {
            this.万与七三丄丁丏世丘();
        }
        private void 丛且丐下世与丘丆丗()
        {
            System.Action val_10;
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            StorePromotionExtendUIAbstract.丏东丌丌丗丙丆世丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丅丕与丄丘丗一三丘(int 丞世不丒下上上丝丑)));
            val_10 = System.Delegate.Combine(a:  val_5.不丝七丕丐与与上丕, b:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::三世丏三世丁丒上丁()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_3;
            }
            
            if(val_10 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_10 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_7:
            val_5.不丝七丕丐与与上丕 = val_10;
            PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丗与丘与上业丞一丟(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)));
        }
        private void 万与七三丄丁丏世丘()
        {
            System.Action val_10;
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            StorePromotionExtendUIAbstract.东丝业丄丛丅东丌丅(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丅丕与丄丘丗一三丘(int 丞世不丒下上上丝丑)));
            val_10 = System.Delegate.Remove(source:  val_5.不丝七丕丐与与上丕, value:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::三世丏三世丁丒上丁()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_3;
            }
            
            if(val_10 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_10 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_7:
            val_5.不丝七丕丐与与上丕 = val_10;
            PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.ClanStoreBuffsController::丗与丘与上业丞一丟(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)));
        }
        private void 丗与丘与上业丞一丟(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)
        {
            var val_6;
            PGCompany.三东丏不丗世丅丌丄 val_13;
            var val_14;
            val_13 = 丐丆丝业丙丈下世丁;
            if(val_13 == null)
            {
                    return;
            }
            
            if(val_13.Count == 0)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁七丒丞下丟一丅丅(丁丅丈丌丟世丗丗丟:  val_13.丟丄丐丙万丛丂丆三())) == true)
            {
                    return;
            }
            
            List.Enumerator<T> val_4 = val_13.GetEnumerator();
            label_17:
            if(((-2141627344) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            val_14 = 0;
            if(val_7.不业丙丒丂丞下丆丙() == 1320)
            {
                goto label_10;
            }
            
            val_14 = 0;
            if(val_7.不业丙丒丂丞下丆丙() != 1330)
            {
                goto label_17;
            }
            
            label_10:
            PGCompany.Analytics.一业丗丆世世上丁且.下丛丑不丈业丗丏丕(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丈丄不七三万丄丁不:  val_7, 三丅丈丛下丛丆丏丂:  val_13, 三丆丝丏丏下下丐不:  false, 不丆丝与丗丏下丏丌:  (StorePromotionExtendUIAbstract.丘丄丒丟丗丄丑丟与 == true) ? 1 : 0, 丏丝丌不丆上世丒七:  1);
            goto label_17;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            StorePromotionExtendUIAbstract.丘丄丒丟丗丄丑丟与 = false;
        }
        internal void 丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且 == null)
            {
                    return;
            }
            
            if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1330)
            {
                    if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1320)
            {
                    return;
            }
            
            }
            
            UnityEngine.Coroutine val_5 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丑丘丝丂且丌东丅丁(不且丐一丆丛丙丙丒:  丅一丘丙上东丏丅不.一且丟丁上丑业丕且));
        }
        private System.Collections.IEnumerator 丑丘丝丂且丌东丅丁(PGCompany.三东丏不丗世丅丌丄 不且丐一丆丛丙丙丒)
        {
            ClanStoreBuffsController.与万三丒业七三下丅 val_1 = new ClanStoreBuffsController.与万三丒业七三下丅();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .不且丐一丆丛丙丙丒 = 不且丐一丆丛丙丙丒;
            return (System.Collections.IEnumerator)val_1;
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 丒世丒一不丝丑且业(int 丞世不丒下上上丝丑)
        {
            var val_3;
            if((this.丂丟丕三丝丅专万丝.ContainsKey(key:  丞世不丒下上上丝丑)) != false)
            {
                    PGCompany.东丑丆丗丏丐丟下丄 val_2 = this.丂丟丕三丝丅专万丝.Item[丞世不丒下上上丝丑];
                return (PGCompany.东丑丆丗丏丐丟下丄)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.东丑丆丗丏丐丟下丄)val_3;
        }
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丙三丟丕丕专与丟丑()
        {
            var val_4;
            var val_5;
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_22;
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_1 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丂丟丕三丝丅专万丝.GetEnumerator();
            label_20:
            if(((-2140949008) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            if((this.丂丑丙不万与丁丗丑.ContainsKey(key:  val_6._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_20;
            }
            
            PGCompany.ClanStoreBuffSetting val_10 = this.丂丑丙不万与丁丗丑.Item[val_6._value._obj.丙东专丂世丈丏丁丂()];
            if(((-2140949144) & 1) == 0)
            {
                goto label_6;
            }
            
            val_22 = this._buffTimeExtend;
            if(val_22 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_22 = this._buffTimeExtend;
            }
            
            if((val_22.ContainsKey(key:  val_6._value._obj.丙东专丂世丈丏丁丂())) == true)
            {
                goto label_20;
            }
            
            val_4 = 0;
            val_5 = 0;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_6._value._obj.丙东专丂世丈丏丁丂()), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
            {
                goto label_20;
            }
            
            label_6:
            PGCompany.三东丏不丗世丅丌丄 val_17 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff");
            if(val_17 == null)
            {
                goto label_20;
            }
            
            if(val_6._value._obj.三丘丆丅丝丙一丑与().业东丅东丌上丗丑不() == val_17.业东丅东丌上丗丑不())
            {
                    if(PGCompany.上三世丝丕专丂丟丌.丏丞丕不且七丌万丙() == false)
            {
                goto label_20;
            }
            
            }
            
            val_1.Add(item:  val_6._value._obj);
            goto label_20;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 业不上丗下丄丏业万()
        {
            return System.Linq.Enumerable.ToList<PGCompany.东丑丆丗丏丐丟下丄>(source:  this.丑丑万丛丆世且丙三.Values);
        }
        private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 73)
            {
                    return;
            }
            
            this.且丛一三业丈丝丞丅();
        }
        private void 且丛一三业丈丝丞丅()
        {
            this.丛不丄与丅丘丙丁与(丛七丅东丒丅丘不业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  73));
        }
        private void 丛不丄与丅丘丙丁与(string 丛七丅东丒丅丘不业)
        {
            this.<一丘一丐丝丘且丞丅>k__BackingField = 0;
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.<一丘一丐丝丘且丞丅>k__BackingField = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            this.丛不丄与丅丘丙丁与();
        }
        private void 丛不丄与丅丘丙丁与()
        {
            var val_3;
            PGCompany.三东丏不丗世丅丌丄 val_4;
            PGCompany.三东丏不丗世丅丌丄 val_40;
            var val_58;
            var val_59;
            var val_60;
            PGCompany.丑丘丂丝丐上丆丆世 val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            val_58 = this;
            if((this.<一丘一丐丝丘且丞丅>k__BackingField) == null)
            {
                    return;
            }
            
            this.世丝丐七丕世丈丒丌();
            if((this.<一丘一丐丝丘且丞丅>k__BackingField.ClanStoreBuffSettings) == null)
            {
                goto label_149;
            }
            
            List.Enumerator<T> val_1 = this.<一丘一丐丝丘且丞丅>k__BackingField.ClanStoreBuffSettings.GetEnumerator();
            val_59 = 1152921505645821952;
            val_60 = 1152921505565310976;
            label_62:
            if(((-2140051272) & 1) == 0)
            {
                goto label_6;
            }
            
            this.丂丑丙不万与丁丗丑.set_Item(key:  -2140051392, value:  new PGCompany.ClanStoreBuffSetting() {_indexContainer = new Rilisoft.丝丑丂丛万丐丈丘且(), SecondsBuy = new Rilisoft.丝丑丂丛万丐丈丘且(), SecondsGift = new Rilisoft.丝丑丂丛万丐丈丘且(), SecondsFree = new Rilisoft.丝丑丂丛万丐丈丘且(), _availabilityDependent = new Rilisoft.丝丑丂丛万丐丈丘且(), _notifyOnEnd = new Rilisoft.丝丑丂丛万丐丈丘且()});
            val_61 = val_3;
            if(((-2140051408) >= 1) && ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_4)) != false))
            {
                    new PGCompany.StorePromotionSettings() = new PGCompany.StorePromotionSettings();
                new PGCompany.StorePromotionPurchaseSettings() = new PGCompany.StorePromotionPurchaseSettings();
                if(new PGCompany.StorePromotionSettings() != null)
            {
                    val_62 = new PGCompany.StorePromotionSettings();
                .PurchaseSettings = new PGCompany.StorePromotionPurchaseSettings();
            }
            else
            {
                    mem[96] = new PGCompany.StorePromotionPurchaseSettings();
                val_62 = 96;
            }
            
                mem[1152921554006476176] = (val_4.业东丅东丌上丗丑不() == 10015) ? (1 + 1) : 1;
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_10 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
                null.Add(item:  val_4.与下不与丐丈丁丈万());
                new PGCompany.StorePromotionPurchaseSettings().Price = null;
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
                new PGCompany.三东丏不丗世丅丌丄().丅丁业不且上业丘且(丙业与丙丗丝不丈东:  -2140051408);
                (PGCompany.StorePromotionSettings)[1152921554006472064].ItemsParams.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
                bool val_15 = new PGCompany.三东丏不丗世丅丌丄().业上丙丞丐丄丆丅七().Equals(value:  "cw_tribute_auto");
                .MainPrefabName = (val_15 != true) ? "StorePromotion/SPGoblinAutoCollectorView" : "StorePromotion/SPClanBuffView";
                .InfoPrefabName = (val_15 != true) ? "StorePromotion/SPGoblinAutoCollectorInfo" : "StorePromotion/SPClanBuffInfo";
                .DescriptionHandlerType = 1;
                new PGCompany.世丏丘丛丗丑专丈下() = new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  0);
                new PGCompany.StorePromotionConfig() = new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  5, 与不丕丆丈不丙丟丛:  new PGCompany.StorePromotionSettings(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下());
                new PGCompany.东丑丆丗丏丐丟下丄() = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig());
                this.丂丟丕三丝丅专万丝.set_Item(key:  -2140051392, value:  new PGCompany.东丑丆丗丏丐丟下丄());
            }
            
            if((((-2140051392) & 1) != 0) && ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_4)) != false))
            {
                    new PGCompany.StorePromotionSettings() = new PGCompany.StorePromotionSettings();
                new PGCompany.StorePromotionPurchaseSettings() = new PGCompany.StorePromotionPurchaseSettings();
                if(new PGCompany.StorePromotionSettings() != null)
            {
                    val_63 = new PGCompany.StorePromotionSettings();
                .PurchaseSettings = new PGCompany.StorePromotionPurchaseSettings();
            }
            else
            {
                    mem[96] = new PGCompany.StorePromotionPurchaseSettings();
                val_63 = 96;
            }
            
                mem[1152921554006525328] = (val_4.业东丅东丌上丗丑不() == 10015) ? (1 + 1) : 1;
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_26 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
                null.Add(item:  val_4.与下不与丐丈丁丈万());
                new PGCompany.StorePromotionPurchaseSettings().Price = null;
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
                new PGCompany.三东丏不丗世丅丌丄().丅丁业不且上业丘且(丙业与丙丗丝不丈东:  14864480);
                (PGCompany.StorePromotionSettings)[1152921554006521216].ItemsParams.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
                val_61 = 1;
                .DescriptionHandlerType = val_61;
                .ExtendPrefabName = ((new PGCompany.三东丏不丗世丅丌丄().业上丙丞丐丄丆丅七().Equals(value:  "cw_tribute_auto")) != true) ? "ClanBuffs/GoblinAutoCollector" : "StorePromotion/SPClanBuffExtend";
                new PGCompany.世丏丘丛丗丑专丈下() = new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  1);
                new PGCompany.StorePromotionConfig() = new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  5, 与不丕丆丈不丙丟丛:  new PGCompany.StorePromotionSettings(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下());
                new PGCompany.东丑丆丗丏丐丟下丄() = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig());
                this.丂丂东一一丆万丄丛.set_Item(key:  -2140051392, value:  new PGCompany.东丑丆丗丏丐丟下丄());
                val_59 = val_59;
                val_60 = 1152921505565310976;
            }
            
            if(((-2140051408) < 1) || ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_40)) == false))
            {
                goto label_62;
            }
            
            new PGCompany.StorePromotionSettings() = new PGCompany.StorePromotionSettings();
            new PGCompany.StorePromotionPurchaseSettings() = new PGCompany.StorePromotionPurchaseSettings();
            if(new PGCompany.StorePromotionSettings() != null)
            {
                    val_64 = new PGCompany.StorePromotionSettings();
                .PurchaseSettings = new PGCompany.StorePromotionPurchaseSettings();
            }
            else
            {
                    mem[96] = new PGCompany.StorePromotionPurchaseSettings();
                val_64 = 96;
            }
            
            mem[1152921554006574480] = (val_40.业东丅东丌上丗丑不() == 10015) ? 6 : 3;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_46 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            null.Add(item:  val_40.与下不与丐丈丁丈万());
            new PGCompany.StorePromotionPurchaseSettings().Price = null;
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
            new PGCompany.三东丏不丗世丅丌丄().丅丁业不且上业丘且(丙业与丙丗丝不丈东:  -2140051408);
            (PGCompany.StorePromotionSettings)[1152921554006570368].ItemsParams.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  -2140051392);
            bool val_51 = new PGCompany.三东丏不丗世丅丌丄().业上丙丞丐丄丆丅七().Equals(value:  "cw_tribute_auto");
            .MainPrefabName = (val_51 != true) ? "StorePromotion/SPGoblinAutoCollectorView" : "StorePromotion/SPClanBuffView";
            .InfoPrefabName = (val_51 != true) ? "StorePromotion/SPGoblinAutoCollectorInfo" : "StorePromotion/SPClanBuffInfo";
            .DescriptionHandlerType = 1;
            new PGCompany.世丏丘丛丗丑专丈下() = new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  2);
            new PGCompany.StorePromotionConfig() = new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  5, 与不丕丆丈不丙丟丛:  new PGCompany.StorePromotionSettings(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下());
            new PGCompany.东丑丆丗丏丐丟下丄() = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig());
            this.丑丑万丛丆世且丙三.set_Item(key:  -2140051392, value:  new PGCompany.东丑丆丗丏丐丟下丄());
            goto label_62;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_149:
            val_58 = 1152921505570795520;
            val_65 = null;
            val_65 = null;
            if(PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东 == null)
            {
                    return;
            }
            
            PGCompany.ClanStoreBuffsController.东一丁丙丅丙世丏东.Invoke();
        }
        private void 世丝丐七丕世丈丒丌()
        {
            this.丂丟丕三丝丅专万丝.Clear();
            this.丂丂东一一丆万丄丛.Clear();
            this.丑丑万丛丆世且丙三.Clear();
            this.丂丑丙不万与丁丗丑.Clear();
        }
        internal bool 东丈丏丕且一与世丕()
        {
            var val_5;
            var val_12;
            var val_16;
            var val_23;
            var val_44;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_58;
            var val_59;
            val_48;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-2139427568) & 1) == 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<System.Int32> val_2 = null;
            val_50 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            if(this._buffTimeExtend == null)
            {
                    this.下不三丏丄丈丅丛丟();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = 0.GetEnumerator();
            val_51 = 1152921554006839744;
            label_44:
            label_27:
            if(((-2139427600) & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3Int val_7 = val_5.position;
            if((this.丂丑丙不万与丁丗丑.ContainsKey(key:  val_7.m_X.GetHashCode())) == false)
            {
                goto label_27;
            }
            
            PGCompany.ClanStoreBuffSetting val_11 = this.丂丑丙不万与丁丗丑.Item[val_7.m_X.GetHashCode()];
            if(val_12.Count == 0)
            {
                goto label_11;
            }
            
            var val_48 = 0;
            label_21:
            PGCompany.ClanStoreBuffSetting val_15 = this.丂丑丙不万与丁丗丑.Item[val_7.m_X.GetHashCode()];
            if(val_48 > (System.Math.Min(val1:  268435467, val2:  val_16.Count - 1)))
            {
                goto label_27;
            }
            
            val_49 = val_50;
            PGCompany.ClanStoreBuffSetting val_22 = this.丂丑丙不万与丁丗丑.Item[val_7.m_X.GetHashCode()];
            Rilisoft.丝丑丂丛万丐丈丘且 val_24 = val_23.Item[0];
            val_52 = val_49;
            val_48 = val_48 + 1;
            if(16 > (丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {})))
            {
                goto label_21;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                goto label_23;
            }
            
            val_2.Add(item:  val_7.m_X.GetHashCode());
            goto label_27;
            label_11:
            val_3.Add(item:  val_7.m_X.GetHashCode());
            goto label_27;
            label_23:
            BannerWindowController val_29 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_29 == null)
            {
                goto label_48;
            }
            
            BannerWindow val_31 = (val_29 == 0) ? 0 : (val_29).CurrentBanner;
            if(val_31 != null)
            {
                    BannerWindowType val_33 = (val_31 == 0) ? 0 : (val_31).type;
                val_5 = 0;
                val_53 = val_5;
            }
            else
            {
                    val_53 = 0;
            }
            
            var val_35 = (val_53.丙东专丂世丈丏丁丂() == 62) ? 1 : 0;
            val_35 = val_35 & 1152921554007026888;
            if((val_35 & 1) == 0)
            {
                goto label_48;
            }
            
            BannerWindow val_37 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
            if(val_37 == null)
            {
                goto label_39;
            }
            
            if(null == null)
            {
                goto label_40;
            }
            
            val_52 = val_49;
            label_39:
            label_40:
            if(null != null)
            {
                goto label_49;
            }
            
            if(val_37 != val_7.m_X.GetHashCode())
            {
                goto label_48;
            }
            
            val_2.Add(item:  val_7.m_X.GetHashCode());
            goto label_44;
            label_3:
            val_54 = 0;
            return (bool)val_54;
            label_6:
            val_54 = 0;
            label_48:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3 != null)
            {
                goto label_86;
            }
            
            goto label_47;
            label_49:
            val_55 = 0;
            val_56 = X0;
            val_50 = val_49;
            if( != 1)
            {
                goto label_99;
            }
            
            val_51 = mem[X0];
            val_51 = ;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_54 = 0;
            if(val_3 != null)
            {
                goto label_86;
            }
            
            label_47:
            label_86:
            List.Enumerator<T> val_42 = val_3.GetEnumerator();
            label_88:
            if(((-2139427664) & 1) == 0)
            {
                goto label_87;
            }
            
            this.丕丂丌三专业丌丛不(丞世不丒下上上丝丑:  val_44.丙东专丂世丈丏丁丂());
            goto label_88;
            label_87:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_46 = val_2.GetEnumerator();
            label_96:
            if(((-2139427664) & 1) == 0)
            {
                goto label_95;
            }
            
            this.丅丕与丄丘丗一三丘(丞世不丒下上上丝丑:  val_44.丙东专丂世丈丏丁丂());
            goto label_96;
            label_95:
            val_58 = 0;
            val_59 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return (bool)val_54;
            }
            
                if(552 == 552)
            {
                    return (bool)val_54;
            }
            
                return (bool)val_54;
            }
            
            if( != 0)
            {
                    return (bool)val_54;
            }
            
            return (bool)val_54;
            label_99:
        }
        internal int 丑丂上丟丒丞丞丏丞()
        {
            var val_4;
            var val_11;
            var val_15;
            var val_16;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-2139073424) & 1) == 0)
            {
                goto label_3;
            }
            
            if(this._buffTimeExtend == null)
            {
                    this.下不三丏丄丈丅丛丟();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
            label_9:
            if(((-2139073456) & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3Int val_5 = val_4.position;
            if((this.丂丑丙不万与丁丗丑.ContainsKey(key:  val_5.m_X.GetHashCode())) == false)
            {
                goto label_9;
            }
            
            var val_14 = 0;
            label_14:
            if(val_14 > 0)
            {
                goto label_9;
            }
            
            val_15 = 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {});
            PGCompany.ClanStoreBuffSetting val_10 = this.丂丑丙不万与丁丗丑.Item[val_5.m_X.GetHashCode()];
            Rilisoft.丝丑丂丛万丐丈丘且 val_12 = val_11.Item[0];
            val_14 = val_14 + 1;
            if(16 > val_15)
            {
                goto label_14;
            }
            
            val_16 = val_5.m_X.GetHashCode();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (int)val_16;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Debug.LogError(message:  "----- Not found Extend Promotion");
            label_3:
            val_16 = 9998;
            return (int)val_16;
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 丐丆专七不万丆与丛(int 丞世不丒下上上丝丑)
        {
            var val_5;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丂丂东一一丆万丄丛.GetEnumerator();
            label_3:
            if(((-2138899880) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
            if((val_2._value._obj.丙东专丂世丈丏丁丂().Equals(obj:  丞世不丒下上上丝丑)) == false)
            {
                goto label_3;
            }
            
            val_5;
            goto label_4;
            label_2:
            val_5 = 0;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.东丑丆丗丏丐丟下丄)val_5;
        }
        private void 丅丕与丄丘丗一三丘(int 丞世不丒下上上丝丑)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.ClanStoreBuffSetting> val_14;
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_17;
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_18;
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_19;
            val_14 = this.丂丑丙不万与丁丗丑;
            if((val_14.ContainsKey(key:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            val_15 = this._buffTimeExtend;
            if(val_15 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_15 = this._buffTimeExtend;
                if(val_15 == null)
            {
                    val_15 = 0;
            }
            
            }
            
            if((val_15.ContainsKey(key:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-2138700656) & 1) == 0)
            {
                goto label_8;
            }
            
            val_16 = 0;
            val_14 = 9998;
            goto label_9;
            label_18:
            val_17 = this._buffTimeExtend;
            if(val_17 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_17 = this._buffTimeExtend;
                if(val_17 == null)
            {
                    val_17 = 0;
            }
            
            }
            
            BuffTimeExtendParams val_5 = val_17.Item[丞世不丒下上上丝丑];
            PGCompany.ClanStoreBuffSetting val_6 = this.丂丑丙不万与丁丗丑.Item[丞世不丒下上上丝丑];
            Rilisoft.丝丑丂丛万丐丈丘且 val_8 = val_7.Item[0];
            int val_10 = ((val_5.ExpireTime - 1152921554007753856) > (丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {}))) ? (val_16) : (val_14);
            val_16 = 1;
            label_9:
            val_18 = this._buffTimeExtend;
            if(val_18 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_18 = this._buffTimeExtend;
                if(val_18 == null)
            {
                    val_18 = 0;
            }
            
            }
            
            BuffTimeExtendParams val_11 = val_18.Item[丞世不丒下上上丝丑];
            if(val_16 < (val_11.ExpireTime >> 32))
            {
                goto label_18;
            }
            
            if(val_10 != 9998)
            {
                goto label_19;
            }
            
            this.丕丂丌三专业丌丛不(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            return;
            label_8:
            UnityEngine.Debug.LogError(message:  "------ Server time invalid!");
            return;
            label_19:
            val_19 = this._buffTimeExtend;
            if(val_19 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_19 = this._buffTimeExtend;
                if(val_19 == null)
            {
                    val_19 = 0;
            }
            
            }
            
            BuffTimeExtendParams val_13 = val_19.Item[丞世不丒下上上丝丑];
            this.且丅丕东下丁丐且三(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 专丌万丑三丙丕丙丝:  val_13.ExpireTime, 丆丂七丈丝丅丟丕丌:  val_10);
        }
        private void 下不三丏丄丈丅丛丟()
        {
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_8;
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  99);
            if(val_2 == null)
            {
                goto label_4;
            }
            
            string val_3 = System.Convert.ToString(value:  val_2);
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_13;
            label_4:
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_5 = null;
            val_8 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams>();
            goto label_14;
            label_13:
            val_8 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            label_14:
            this._buffTimeExtend = val_8;
        }
        internal void 丕丂丌三专业丌丛不(int 丞世不丒下上上丝丑)
        {
            System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams> val_6;
            var val_7;
            val_6 = this._buffTimeExtend;
            if(val_6 == null)
            {
                    this.下不三丏丄丈丅丛丟();
                val_6 = this._buffTimeExtend;
                if(val_6 == null)
            {
                    val_6 = 0;
            }
            
            }
            
            if((val_6.ContainsKey(key:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            if(this._buffTimeExtend == null)
            {
                    this.下不三丏丄丈丅丛丟();
            }
            
            val_7 = public System.Boolean System.Collections.Generic.Dictionary<System.Int32, BuffTimeExtendParams>::Remove(System.Int32 key);
            bool val_2 = 0.Remove(key:  丞世不丒下上上丝丑);
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            if(this._buffTimeExtend == null)
            {
                goto label_8;
            }
            
            if(val_3 != null)
            {
                goto label_14;
            }
            
            label_15:
            label_14:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 0;
            goto label_13;
            label_8:
            this.下不三丏丄丈丅丛丟();
            if(val_3 != null)
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  99, 丙业与丙丗丝不丈东:  val_3.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this._buffTimeExtend));
        }
        private void 且丅丕东下丁丐且三(int 丞世不丒下上上丝丑, int 专丌万丑三丙丕丙丝, int 丆丂七丈丝丅丟丕丌)
        {
            var val_4;
            if(this._buffTimeExtend == null)
            {
                    this.下不三丏丄丈丅丛丟();
            }
            
            0.set_Item(key:  丞世不丒下上上丝丑, value:  new BuffTimeExtendParams() {ExpireTime = 专丌万丑三丙丕丙丝, IndexTimeToEnd = 丆丂七丈丝丅丟丕丌});
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            if(this._buffTimeExtend == null)
            {
                goto label_5;
            }
            
            if(val_1 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 0;
            goto label_10;
            label_5:
            this.下不三丏丄丈丅丛丟();
            if(val_1 != null)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  99, 丙业与丙丗丝不丈东:  val_1.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this._buffTimeExtend));
        }
        private void 三世丏三世丁丒上丁()
        {
            this._buffTimeExtend = 0;
        }
        internal static PGCompany.丌丐下丌丘下丝丞业 丆丛七丆万丕丘业丂()
        {
            var val_4 = null;
            return (PGCompany.丌丐下丌丘下丝丞业)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丌丐下丌丘下丝丞业>(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  PGCompany.ClanStoreBuffsController.丌丛丈丏丞且丐丐不), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        internal static PGCompany.丌丐下丌丘下丝丞业 与世东丈不丟丌丙丙()
        {
            var val_4 = null;
            return (PGCompany.丌丐下丌丘下丝丞业)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丌丐下丌丘下丝丞业>(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  PGCompany.ClanStoreBuffsController.三丝专丗丑业丏七与), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        public ClanStoreBuffsController()
        {
            this.丂丟丕三丝丅专万丝 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.东丑丆丗丏丐丟下丄>();
            this.丂丂东一一丆万丄丛 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.东丑丆丗丏丐丟下丄>();
            this.丑丑万丛丆世且丙三 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.东丑丆丗丏丐丟下丄>();
            this.丂丑丙不万与丁丗丑 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.ClanStoreBuffSetting>();
        }
        private static ClanStoreBuffsController()
        {
            PGCompany.ClanStoreBuffsController.丌丛丈丏丞且丐丐不 = "clan_silver_buff";
            PGCompany.ClanStoreBuffsController.三丝专丗丑业丏七与 = "clan_lootbox_point_buff";
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_1.Add(item:  PGCompany.ClanStoreBuffsController.丌丛丈丏丞且丐丐不);
            val_1.Add(item:  PGCompany.ClanStoreBuffsController.三丝专丗丑业丏七与);
            PGCompany.ClanStoreBuffsController.下丘东下丕丒丑丟丅 = val_1;
            System.Collections.Generic.Dictionary<System.String, 上七丑业丙丒丙东丏> val_2 = new System.Collections.Generic.Dictionary<System.String, 上七丑业丙丒丙东丏>();
            val_2.Add(key:  PGCompany.ClanStoreBuffsController.丌丛丈丏丞且丐丐不, value:  1);
            val_2.Add(key:  PGCompany.ClanStoreBuffsController.三丝专丗丑业丏七与, value:  2);
            PGCompany.ClanStoreBuffsController.世丆丕丒下丝丝丗七 = val_2;
        }
    
    }

}
