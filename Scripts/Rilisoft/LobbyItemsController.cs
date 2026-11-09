using UnityEngine;

namespace Rilisoft
{
    public class LobbyItemsController : Singleton<Rilisoft.LobbyItemsController>
    {
        // Fields
        internal const string 丅丏丗下三丒万万丘 = "lobby_items";
        internal const string 丏丁世万专丈丑专丑 = "decor_big_military_1";
        private static Rilisoft.且丈丞一丞丟与上七 世丈丒丗不丅丐下丒;
        private static System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, bool> 三业七丛世下三丛世;
        internal static System.Collections.Generic.List<Rilisoft.LobbyItemGroupType> 一丑不丐丌丁一上丒;
        private static readonly System.Collections.Generic.List<Rilisoft.下丟丑丁且专且三丘> 丅业丟丝丝丘万上丄;
        private static readonly System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, string> 三丏丄丁丘丆不丈丐;
        private static readonly System.Collections.Generic.List<丕专丟上与丄丈三丏.LobbyItemSlot> 丘七一丘东与三世万;
        private System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丛不丞丂七丞世丁丏;
        private string[] 万丙丕三万且万丟丟;
        private bool 丆丘丒不上下一丙一;
        public System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> Bundles;
        private Rilisoft.丏丘七丞丄丙丌丞丁 <丛上丟丏与丕丒东丂>k__BackingField;
        private static System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丘丐丟丑丈丗丟专下;
        private static System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丝与丟丕且丈丙且上;
        private static System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丒下业丙与一丟丑三;
        private static System.Action<Rilisoft.丏丘七丞丄丙丌丞丁, int, bool> 丘丑专下丘世不丆丟;
        private static System.Action<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁> 世丐与下丂业上丗丛;
        private static System.Action<bool> 丛丄丅丄业丗丑专丑;
        private System.Action 丄丄丙丘丐一丌丁丄;
        private bool 不万丅丏丗丁丟业丄;
        private string 丟丆丐丛丈丛专上丄;
        private const string 丞丘且丏万一丏丐下 = "device_1_4";
        private UnityEngine.Coroutine 丅丏不下与下丄下丁;
        internal static bool 丂丏丁下七丌七丆丅;
        private static System.Action<丕专丟上与丄丈三丏.万东丙丛丅业丝世三, float> 丄丂丞丒丝业世不丕;
        private System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.万东丙丛丅业丝世三, float> 丛与丙东不三丏业上;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler>> 丘丝一丕丂七七七丂;
        
        // Properties
        internal bool 丒丆丁丘丈丏丆丌丘 { get; set; }
        internal static System.Nullable<long> 丏一丛丗丝丘丆丌专 { get; }
        internal static long 丈七业丛丐丗万七且 { get; set; }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丙万丗丑丐专且与丈 { get; }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丂专下丏丁七上丅丈 { get; }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丛下丂丅东丏丕丝丂 { get; }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 业与丕丂下不丁下与 { get; }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丌丑上丞与丆丏丌一 { get; }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丛七丐且下丅上丁丘 { get; set; }
        internal System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁> 丅丈丐丘丌不丌东东 { get; }
        internal static bool 丛丏且丗世七丞丝丐 { get; }
        internal bool 三且丁丞丙丈世业东 { get; set; }
        internal bool 丆七下丙丞丘东丟丛 { get; set; }
        
        // Methods
        internal bool 七丄业丅专上丌丅丙()
        {
            return (bool)this.丆丘丒不上下一丙一;
        }
        private void 丝专丞丈丂东丝丈丌(bool 丙业与丙丗丝不丈东)
        {
            var val_5;
            var val_1 = (this.丆丘丒不上下一丙一 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            this.丆丘丒不上下一丙一 = 丙业与丙丗丝不丈东;
            val_5 = null;
            val_5 = null;
            if(Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑 == null)
            {
                    return;
            }
            
            Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑.Invoke(obj:  (this.丆丘丒不上下一丙一 == true) ? 1 : 0);
        }
        internal static System.Nullable<long> 丅丘七世上丘且丗不()
        {
            var val_5 = null;
            if(Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝() != false)
            {
                    if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return 0;
            }
            
                long val_3 = FriendsController.丝丗专上三不丄丑丑();
            }
            else
            {
                    long val_4 = 专七专下且专三一且.上且一丈丐三丄一丆();
            }
            
            return 0;
        }
        internal static long 丐上丛世丌丘东与丗()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Rilisoft.LobbyItemsController.丞丘且丏万一丏丐下 == null)
            {
                    Rilisoft.且丈丞一丞丟与上七 val_1 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "LobbyItemsBundle-lastPurchaseTime");
                val_4 = null;
                val_4 = null;
                Rilisoft.LobbyItemsController.丞丘且丏万一丏丐下 = val_1;
                val_3 = null;
            }
            
            val_3 = null;
            return (long)(long)val_1.世三丞丅丑丌丈丈一();
        }
        internal static void 七七丌丌丁不下万三(long 丙业与丙丗丝不丈东)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.LobbyItemsController.丞丘且丏万一丏丐下 == null)
            {
                    Rilisoft.且丈丞一丞丟与上七 val_1 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "LobbyItemsBundle-lastPurchaseTime");
                val_3 = null;
                val_3 = null;
                Rilisoft.LobbyItemsController.丞丘且丏万一丏丐下 = val_1;
                val_2 = null;
            }
            
            val_2 = null;
            val_1.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 三下丙丛且丛丄丅丕()
        {
            return (System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>)this.丛不丞丂七丞世丁丏;
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丝世丝丌丞东丗专丂()
        {
            var val_3;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LobbyItemsController.<>c.<>9__23_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::丁丏丛丑丘丒专且丒(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__23_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_1));
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丑七丆丄一三不下丁()
        {
            var val_3;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LobbyItemsController.<>c.<>9__25_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::七丛丌丏丕丒下专丒(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__25_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_1));
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丈丝丗且丕丌世一东()
        {
            var val_4;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = LobbyItemsController.<>c.<>9__27_0;
            if(val_6 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::一丅丒丒丂一丂东丆(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__27_0 = val_6;
            }
            
            val_7 = null;
            val_7 = null;
            return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_1), predicate:  Rilisoft.LobbyItemsController.三业七丛世下三丛世));
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丄丐且丐业丙世丞与()
        {
            var val_2;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = LobbyItemsController.<>c.<>9__29_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::丘业丒丁丙丅丏丞丗(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__29_0 = val_4;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_1);
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丟丑丒丂万丟专丁万()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this.<丛上丟丏与丕丒东丂>k__BackingField;
        }
        private void 丌丘丘上三丅丆不丝(Rilisoft.丏丘七丞丄丙丌丞丁 丙业与丙丗丝不丈东)
        {
            this.<丛上丟丏与丕丒东丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁> 不丁万专不业不丗与()
        {
            System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁> val_1 = new System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁>();
            List.Enumerator<T> val_2 = this.丛不丞丂七丞世丁丏.GetEnumerator();
            label_9:
            if(((-162886712) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            if((val_3.不专丌丅且丝丗丞下() == false) || (val_3.丝丞世丕丒下东丌丄() == true))
            {
                goto label_9;
            }
            
            val_1.Add(key:  val_3.丘专上世与丟丝丟丛(), value:  val_3);
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static bool 丑丆丏丟丗丌丄丟丝()
        {
            var val_15;
            var val_16;
            var val_17;
            val_16 = null;
            if(Rilisoft.LobbyItemsController.不丈丘东丄丈三丄丘() == true)
            {
                goto label_19;
            }
            
            val_15 = 0;
            goto label_4;
            label_18:
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((Rilisoft.LobbyItemsController.万专丈且且丛丗下业(下丅丙一丂丗丅丝七:  val_2.丛不丞丂七丞世丁丏.Item[0])) == false)
            {
                goto label_9;
            }
            
            Rilisoft.LobbyItemsController val_5 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((val_5.丛不丞丂七丞世丁丏.Item[0].丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七().Equals(value:  "decor_big_military_1")) == true)
            {
                goto label_15;
            }
            
            label_9:
            val_15 = 1;
            label_4:
            Rilisoft.LobbyItemsController val_10 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if(val_15 < val_10.丛不丞丂七丞世丁丏.Count)
            {
                goto label_18;
            }
            
            goto label_19;
            label_15:
            val_15 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_15.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  2, 丙业与丙丗丝不丈东:  1);
            label_19:
            val_17 = null;
            return (bool)Rilisoft.LobbyItemsController.不丈丘东丄丈三丄丘();
        }
        private static bool 不丈丘东丄丈三丄丘()
        {
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  2);
            if(val_2 == null)
            {
                    return (bool)((System.Convert.ToInt32(value:  val_2)) > 0) ? 1 : 0;
            }
            
            return (bool)((System.Convert.ToInt32(value:  val_2)) > 0) ? 1 : 0;
        }
        internal static void 丏丏与一丁丄世世万(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下 != 1152921505469202480);
        
        }
        internal static void 与丌丌丒丘丅一丒上(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下 != 1152921505469202480);
        
        }
        internal static void 专丏业且丙丆丁且丈(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上 != 1152921505469202488);
        
        }
        internal static void 专七三丂下业丘丏丑(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上 != 1152921505469202488);
        
        }
        internal static void 三丘丒丞丕下丘万丂(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丒下业丙与一丟丑三, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丒下业丙与一丟丑三 != 1152921505469202496);
        
        }
        internal static void 万丂丐一世业世万丑(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丒下业丙与一丟丑三, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丒下业丙与一丟丑三 != 1152921505469202496);
        
        }
        internal static void 丂上下东丈东下丝世(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁, int, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟 != 1152921505469202504);
        
        }
        internal static void 丗一上丂丟业丝丈一(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁, int, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟 != 1152921505469202504);
        
        }
        internal static void 东与丐东下丈七不丒(System.Action<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.世丐与下丂业上丗丛, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.世丐与下丂业上丗丛 != 1152921505469202512);
        
        }
        internal static void 七万丐丟业业且丕丂(System.Action<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.世丐与下丂业上丗丛, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.世丐与下丂业上丗丛 != 1152921505469202512);
        
        }
        internal static void 丟丟且世丘丒丞丏丒(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑 != 1152921505469202520);
        
        }
        internal static void 丘一与丂专万万丘丄(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丛丄丅丄业丗丑专丑 != 1152921505469202520);
        
        }
        internal void 丛丁丞专七丛世三不(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丄丙丘丐一丌丁丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丄丙丘丐一丌丁丄 != 1152921543100700096);
        
        }
        internal void 丛上丐丑丙三万丒丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丄丙丘丐一丌丁丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丄丙丘丐一丌丁丄 != 1152921543100836672);
        
        }
        private static bool 万专丈且且丛丗下业(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_24;
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_25;
            var val_26;
            var val_27;
            var val_28;
            val_24 = 下丅丙一丂丗丅丝七.丒丙丙世丅且下丁丐();
            if(val_24 == null)
            {
                goto label_2;
            }
            
            if(val_24.IsMyBandle == true)
            {
                goto label_12;
            }
            
            if(下丅丙一丂丗丅丝七.丌七丌下丙三世丅一() == null)
            {
                goto label_5;
            }
            
            Rilisoft.LobbyItemPlayerInfo val_4 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
            if(val_4.IsCrafted == true)
            {
                goto label_12;
            }
            
            label_5:
            if(val_24.IsMyBandle == false)
            {
                goto label_9;
            }
            
            val_25 = 1152921524490355520;
            val_26 = 1152921543098783424;
            val_24 = 0;
            label_18:
            if(val_24 >= (Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丑七丆丄一三不下丁().Count))
            {
                goto label_12;
            }
            
            val_24 = val_24 + 1;
            if(((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丑七丆丄一三不下丁().Item[0]) & 1) != 0)
            {
                goto label_18;
            }
            
            return (bool)val_27;
            label_2:
            if(下丅丙一丂丗丅丝七.丌七丌下丙三世丅一() == null)
            {
                    return (bool)val_27;
            }
            
            val_24 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
            var val_14 = (val_13.IsCrafted == true) ? 1 : 0;
            return (bool)val_27;
            label_9:
            val_26 = 1152921524490355520;
            val_28 = 0;
            goto label_25;
            label_39:
            Rilisoft.LobbyItemsController val_16 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((val_24.ItemsIds.Contains(item:  val_16.丛不丞丂七丞世丁丏.Item[0].业上丙丞丐丄丆丅七())) != false)
            {
                    Rilisoft.LobbyItemsController val_20 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                if((val_20.丛不丞丂七丞世丁丏.Item[0] & 1) == 0)
            {
                    return (bool)val_27;
            }
            
            }
            
            val_28 = 1;
            label_25:
            Rilisoft.LobbyItemsController val_22 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            val_25 = val_22.丛不丞丂七丞世丁丏;
            if(val_28 < val_25.Count)
            {
                goto label_39;
            }
            
            label_12:
            val_27 = 1;
            return (bool)val_27;
        }
        internal bool 丒丟丝丑丏丒丅丞一(string 丞一丁业丄一一业且)
        {
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            return System.Linq.Enumerable.Any<Rilisoft.LobbyItemsBundle>(source:  this.Bundles, predicate:  new System.Func<Rilisoft.LobbyItemsBundle, System.Boolean>(object:  new LobbyItemsController.丙丏七丏丝丝丂下东(), method:  System.Boolean LobbyItemsController.丙丏七丏丝丝丂下东::丐东丂丁一七丙一世(Rilisoft.LobbyItemsBundle 丌丗丏丏丛东专丁且)));
        }
        internal int 丂丝丂丑丄丑丟丆专()
        {
            var val_4;
            System.Func<丐丁丑丑丈丁上丘丆, System.Int32> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = LobbyItemsController.<>c.<>9__62_0;
            if(val_6 != null)
            {
                    return 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<System.Int32, 丐丁丑丑丈丁上丘丆>(丞下万上三丘上与专:  与与一丆专丕丄丆丗.丑七不且上丗丁一世().丛东且丘丂专丐丈丛(), 丏丅丁丛一业丈专专:  System.Func<丐丁丑丑丈丁上丘丆, System.Int32> val_3 = null);
            }
            
            val_6 = val_3;
            val_3 = new System.Func<丐丁丑丑丈丁上丘丆, System.Int32>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LobbyItemsController.<>c::不丑丟世且不专丘丁(丐丁丑丑丈丁上丘丆 三丟东丕丄丄下下丑));
            LobbyItemsController.<>c.<>9__62_0 = val_6;
            return 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<System.Int32, 丐丁丑丑丈丁上丘丆>(丞下万上三丘上与专:  与与一丆专丕丄丆丗.丑七不且上丗丁一世().丛东且丘丂专丐丈丛(), 丏丅丁丛一业丈专专:  val_3);
        }
        internal static bool 丛且一与丑丅下丌丏(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_9;
            LobbyItemSlot val_10;
            var val_11;
            var val_12;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return false;
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = 下丅丙一丂丗丅丝七.丘专上世与丟丝丟丛();
            if((Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.ContainsKey(key:  val_10)) == false)
            {
                    return false;
            }
            
            val_11 = null;
            val_11 = null;
            val_10 = 下丅丙一丂丗丅丝七.丘专上世与丟丝丟丛();
            if(Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.Item[val_10] == null)
            {
                    return false;
            }
            
            val_12 = null;
            val_12 = null;
            return System.String.op_Equality(a:  Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.Item[下丅丙一丂丗丅丝七.丘专上世与丟丝丟丛()], b:  下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七());
        }
        internal static Rilisoft.丏丘七丞丄丙丌丞丁 丟丝丌丏一下丒丝丛(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            LobbyItemSlot val_8;
            var val_9;
            System.Collections.Generic.Dictionary<LobbyItemSlot, System.String> val_10;
            var val_11;
            var val_12;
            val_8 = 与丄不丌一世东丁丙;
            .与丄不丌一世东丁丙 = val_8;
            val_9 = null;
            val_9 = null;
            val_8 = (LobbyItemsController.丂丒丝上丐丟丄下世)[1152921543101783936].与丄不丌一世东丁丙;
            val_10 = Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐;
            if((val_10.ContainsKey(key:  val_8)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = (LobbyItemsController.丂丒丝上丐丟丄下世)[1152921543101783936].与丄不丌一世东丁丙;
                val_12 = 0;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.Item[val_10])) == true)
            {
                    return (Rilisoft.丏丘七丞丄丙丌丞丁)val_12;
            }
            
                Rilisoft.LobbyItemsController val_5 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6 = null;
                val_10 = val_6;
                val_6 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丂丒丝上丐丟丄下世(), method:  System.Boolean LobbyItemsController.丂丒丝上丐丟丄下世::丒万不三专丒上丌万(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七));
                Rilisoft.丏丘七丞丄丙丌丞丁 val_7 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_5.丛不丞丂七丞世丁丏, predicate:  val_6);
                return (Rilisoft.丏丘七丞丄丙丌丞丁)val_12;
            }
            
            val_12 = 0;
            return (Rilisoft.丏丘七丞丄丙丌丞丁)val_12;
        }
        internal static bool 丄专与丝上专下东专(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            null = null;
            bool val_1 = Rilisoft.LobbyItemsController.丘七一丘东与三世万.Contains(item:  与丄不丌一世东丁丙);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 万丂丙丒丒丞丏下下(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗, bool 丁丅丑下丝丆丄下丏 = False)
        {
            Rilisoft.LobbyItemGroupType val_11;
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_12;
            var val_13;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_15;
            var val_17;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32> val_19;
            val_11 = 一丐丅且丛不不丌丗;
            if(val_11 == 600)
            {
                    val_12 = this.丛不丞丂七丞世丁丏;
                val_13 = null;
                val_13 = null;
                val_15 = LobbyItemsController.<>c.<>9__66_0;
                if(val_15 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null;
                val_15 = val_1;
                val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::下丘丂丈丅丐丒一万(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__66_0 = val_15;
            }
            
                System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_12, predicate:  val_1);
                return (System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>)System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  val_12 = System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6 = null), keySelector:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32> val_8 = null));
            }
            
            LobbyItemsController.不丙丟丑丑与丒丒丒 val_3 = new LobbyItemsController.不丙丟丑丑与丒丒丒();
            System.Collections.Generic.List<LobbyItemSlot> val_5 = Rilisoft.LobbyItemsController.一丟丏丕丘丁丏丌七(一丐丅且丛不不丌丗:  val_11, 丁丅丑下丝丆丄下丏:  丁丅丑下丝丆丄下丏);
            if(val_3 == null)
            {
                goto label_10;
            }
            
            .丒丆丛上东丝三丟世 = val_5;
            if(val_5 == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>)System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  val_12, keySelector:  val_8));
            }
            
            label_17:
            val_11 = val_6;
            val_6 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_3, method:  System.Boolean LobbyItemsController.不丙丟丑丑与丒丒丒::世与下上丘且丐丌丈(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            val_17 = null;
            val_17 = null;
            val_19 = LobbyItemsController.<>c.<>9__66_2;
            if(val_19 == null)
            {
                    val_19 = val_8;
                val_8 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LobbyItemsController.<>c::丟一七丑万丏一业丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__66_2 = val_19;
            }
            
            return (System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>)System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  val_12, keySelector:  val_8));
            label_10:
            mem[16] = val_5;
            if(mem[16] != 0)
            {
                goto label_17;
            }
            
            return (System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>)System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  val_12, keySelector:  val_8));
        }
        internal static System.Collections.Generic.List<丕专丟上与丄丈三丏.LobbyItemSlot> 一丟丏丕丘丁丏丌七(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗, bool 丁丅丑下丝丆丄下丏)
        {
            object val_14;
            var val_15;
            var val_16;
            System.Collections.Generic.List<Rilisoft.下丟丑丁且专且三丘> val_17;
            System.Collections.Generic.List<LobbyItemSlot> val_18;
            var val_19;
            var val_20;
            System.Func<Rilisoft.下丟丑丁且专且三丘, System.Collections.Generic.IEnumerable<LobbyItemSlot>> val_22;
            LobbyItemsController.专丌业丝丈丘万丈专 val_1 = null;
            val_14 = val_1;
            val_1 = new LobbyItemsController.专丌业丝丈丘万丈专();
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_15 = 1152921505469198336;
            val_16 = null;
            val_16 = null;
            val_17 = Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄;
            Rilisoft.下丟丑丁且专且三丘 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.下丟丑丁且专且三丘>(source:  val_17, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.专丌业丝丈丘万丈专::业丐丕三业丈上丐丐(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈)));
            .不丝丄丒丌丐一一与 = val_3;
            if(val_3 == null)
            {
                    return val_18;
            }
            
            if((LobbyItemsController.专丌业丝丈丘万丈专)[1152921543102353408].一丐丅且丛不不丌丗 == 600)
            {
                    val_17 = val_14;
                .丒丆丛上东丝三丟世 = new System.Collections.Generic.List<LobbyItemSlot>();
                丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<LobbyItemSlot>(七丐丅专且专七三丆:  new System.Action<LobbyItemSlot>(object:  val_1, method:  System.Void LobbyItemsController.专丌业丝丈丘万丈专::万万丈一丟丒丈丆一(丕专丟上与丄丈三丏.LobbyItemSlot 丏丛与丅丛丌万专丌)));
            }
            else
            {
                    if(丁丅丑下丝丆丄下丏 != false)
            {
                    val_19 = null;
                val_19 = null;
                val_15 = 1152921505469251584;
                val_20 = null;
                val_20 = null;
                val_22 = LobbyItemsController.<>c.<>9__67_3;
                if(val_22 == null)
            {
                    System.Func<Rilisoft.下丟丑丁且专且三丘, System.Collections.Generic.IEnumerable<LobbyItemSlot>> val_8 = null;
                val_22 = val_8;
                val_8 = new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Collections.Generic.IEnumerable<LobbyItemSlot>>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<LobbyItemSlot> LobbyItemsController.<>c::上世丁丏丗丄丟与丙(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈));
                LobbyItemsController.<>c.<>9__67_3 = val_22;
            }
            
                val_17 = val_14;
                .丒丆丛上东丝三丟世 = System.Linq.Enumerable.ToList<LobbyItemSlot>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.下丟丑丁且专且三丘, LobbyItemSlot>(source:  System.Linq.Enumerable.Where<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.专丌业丝丈丘万丈专::上丟七业世世专丞丝(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈))), selector:  val_8));
            }
            else
            {
                    val_17 = val_14;
                .丒丆丛上东丝三丟世 = new System.Collections.Generic.List<LobbyItemSlot>();
            }
            
                if(.不丝丄丒丌丐一一与.丈三丒业丑丗丘不东() != null)
            {
                    val_14 = (LobbyItemsController.专丌业丝丈丘万丈专)[1152921543102353408].丒丆丛上东丝三丟世;
                val_14.AddRange(collection:  (LobbyItemsController.专丌业丝丈丘万丈专)[1152921543102353408].不丝丄丒丌丐一一与.丈三丒业丑丗丘不东());
            }
            
            }
            
            val_18 = .丒丆丛上东丝三丟世;
            return val_18;
        }
        internal static bool 业丙丘丟七丕东丞丟(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗, Rilisoft.LobbyItemGroupType 丁丈东世丗丙丅丌丂)
        {
            var val_6;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_6 = null;
            val_6 = null;
            Rilisoft.下丟丑丁且专且三丘 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  new LobbyItemsController.丑丆丟丈上与丁丕下(), method:  System.Boolean LobbyItemsController.丑丆丟丈上与丁丕下::丐万世与丈且业丌东(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈)));
            if(val_3 == null)
            {
                    return (bool)(val_3.与一万丆丙东东丏丄() == 丁丈东世丗丙丅丌丂) ? 1 : 0;
            }
            
            return (bool)(val_3.与一万丆丙东东丏丄() == 丁丈东世丗丙丅丌丂) ? 1 : 0;
        }
        internal static Rilisoft.LobbyItemGroupType 丌丐七丕丅丙不一丐(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗)
        {
            var val_4;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_4 = null;
            val_4 = null;
            Rilisoft.下丟丑丁且专且三丘 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  new LobbyItemsController.丞丙丛丂上一丆丛万(), method:  System.Boolean LobbyItemsController.丞丙丛丂上一丆丛万::丐世丒丌丞一丑丟丘(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈)));
            if(val_3 == null)
            {
                    return (Rilisoft.LobbyItemGroupType)val_3;
            }
            
            return val_3.与一万丆丙东东丏丄();
        }
        internal static System.Collections.Generic.List<Rilisoft.LobbyItemGroupType> 丞业丘东七丙万丕丂(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗)
        {
            var val_6;
            System.Func<TSource, System.Boolean> val_7;
            var val_8;
            System.Func<Rilisoft.下丟丑丁且专且三丘, Rilisoft.LobbyItemGroupType> val_10;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_6 = null;
            val_6 = null;
            System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  new LobbyItemsController.丆丟专丕东丗业丌丕(), method:  System.Boolean LobbyItemsController.丆丟专丕东丗业丌丕::东丛丏丘丁丝东丝丂(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈));
            val_8 = null;
            val_8 = null;
            val_10 = LobbyItemsController.<>c.<>9__70_1;
            if(val_10 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.LobbyItemGroupType>(source:  System.Linq.Enumerable.Select<Rilisoft.下丟丑丁且专且三丘, Rilisoft.LobbyItemGroupType>(source:  System.Linq.Enumerable.Where<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  val_2), selector:  System.Func<Rilisoft.下丟丑丁且专且三丘, Rilisoft.LobbyItemGroupType> val_4 = null));
            }
            
            val_10 = val_4;
            val_4 = new System.Func<Rilisoft.下丟丑丁且专且三丘, Rilisoft.LobbyItemGroupType>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.LobbyItemGroupType LobbyItemsController.<>c::专业丒丌丐七丏丛丄(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈));
            LobbyItemsController.<>c.<>9__70_1 = val_10;
            return System.Linq.Enumerable.ToList<Rilisoft.LobbyItemGroupType>(source:  System.Linq.Enumerable.Select<Rilisoft.下丟丑丁且专且三丘, Rilisoft.LobbyItemGroupType>(source:  System.Linq.Enumerable.Where<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  val_2), selector:  val_4));
        }
        internal static Rilisoft.LobbyItemGroupType 丕丙专丂丛丐与下上(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            var val_4;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_4 = null;
            val_4 = null;
            Rilisoft.下丟丑丁且专且三丘 val_3 = System.Linq.Enumerable.First<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  new LobbyItemsController.丅且丒丙丗不世丟与(), method:  System.Boolean LobbyItemsController.丅且丒丙丗不世丟与::丙丆丑丈丅一丐万丛(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈)));
            if(val_3 != null)
            {
                    return val_3.世丞丗丏丏丛世丌东();
            }
            
            return val_3.世丞丗丏丏丛世丌东();
        }
        internal static Rilisoft.LobbyItemGroupType 丗世丅丕丞丄万不丟(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            var val_7;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_7 = null;
            val_7 = null;
            Rilisoft.LobbyItemGroupType val_4 = System.Linq.Enumerable.First<Rilisoft.下丟丑丁且专且三丘>(source:  Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.下丟丑丁且专且三丘, System.Boolean>(object:  new LobbyItemsController.丅丆丛丄丘不丒丂丈(), method:  System.Boolean LobbyItemsController.丅丆丛丄丘不丒丂丈::丒丅万丆丐丅丕丐三(Rilisoft.下丟丑丁且专且三丘 业七丐世专丝丂丟丈))).世丞丗丏丏丛世丌东();
            Rilisoft.LobbyItemGroupType val_5 = Rilisoft.LobbyItemsController.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  val_4);
            return (Rilisoft.LobbyItemGroupType)(val_5 != 0) ? (val_5) : (val_4);
        }
        internal System.Collections.Generic.List<string> 丄不丘东丅三丂世丟()
        {
            var val_4;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = LobbyItemsController.<>c.<>9__73_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.丏丘七丞丄丙丌丞丁, System.String>(source:  this.丑七丆丄一三不下丁(), selector:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String> val_2 = null));
            }
            
            val_6 = val_2;
            val_2 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.String LobbyItemsController.<>c::丈与万与上丘丗专三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__73_0 = val_6;
            return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.丏丘七丞丄丙丌丞丁, System.String>(source:  this.丑七丆丄一三不下丁(), selector:  val_2));
        }
        internal bool 下丟丈不一上万不业()
        {
            return (bool)this.不万丅丏丗丁丟业丄;
        }
        internal void 丄丏丐三丌丒丝不不(bool 丙业与丙丗丝不丈东)
        {
            this.不万丅丏丗丁丟业丄 = 丙业与丙丗丝不丈东;
        }
        internal static bool 丞丑丙一与丐万且下(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙, Rilisoft.LobbyItemGroupType 不丝丄丒丌丐一一与, bool 丌七丅一丘与丅丅丏 = False)
        {
            System.Collections.Generic.List<LobbyItemSlot> val_2 = Rilisoft.LobbyItemsController.一丟丏丕丘丁丏丌七(一丐丅且丛不不丌丗:  不丝丄丒丌丐一一与, 丁丅丑下丝丆丄下丏:  丌七丅一丘与丅丅丏);
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            return val_2.Contains(item:  与丄不丌一世东丁丙);
        }
        internal System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> 丕丗专丟丕丒丛七丕(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            return System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丁丕万东专一三丘三(), method:  System.Boolean LobbyItemsController.丁丕万东专一三丘三::丌丁丗丄上七丙七丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))));
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丅丟丝丗丌丂且丗一(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.业丏丂业丂且丅丞丈(), method:  System.Boolean LobbyItemsController.业丏丂业丂且丅丞丈::丑丞一丏下丏上下丑(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
        }
        internal bool 丕丌丈丏丙丁丟东丘(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_3;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LobbyItemsController.<>c.<>9__81_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.Contains<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_1 = null), value:  下丅丙一丂丗丅丝七);
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::七丞上丙丛专三丐丏(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__81_0 = val_5;
            return System.Linq.Enumerable.Contains<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_1), value:  下丅丙一丂丗丅丝七);
        }
        internal bool 丕丌丈丏丙丁丟东丘(string 丞一丁业丄一一业且)
        {
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丆下丙不丌丂丈不一(), method:  System.Boolean LobbyItemsController.丆下丙不丌丂丈不一::丑丘上东不丄丟世丛(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            return val_3.且丅一一三七专丑丏();
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丞丏丆丙丁丒丕与丄(string 丞丅上丏丂且下丅与)
        {
            string val_5;
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_6;
            var val_7;
            val_5 = 丞丅上丏丂且下丅与;
            val_6 = this;
            LobbyItemsController.丂丁丏丞丅与丗一与 val_1 = new LobbyItemsController.丂丁丏丞丅与丗一与();
            if(val_1 != null)
            {
                    .丞丅上丏丂且下丅与 = val_5;
            }
            else
            {
                    mem[16] = val_5;
                val_5 = mem[16];
            }
            
            val_7 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
            {
                    return (Rilisoft.丏丘七丞丄丙丌丞丁)System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_6 = this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_3 = null);
            }
            
            val_5 = val_3;
            val_3 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.丂丁丏丞丅与丗一与::丏上丁丑七三丝丘丄(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            return (Rilisoft.丏丘七丞丄丙丌丞丁)System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_6, predicate:  val_3);
        }
        internal Rilisoft.LobbyItemsBundle 丝一丗丄与丛丏丘丛(string 丞丅上丏丂且下丅与)
        {
            string val_5;
            System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> val_6;
            var val_7;
            val_5 = 丞丅上丏丂且下丅与;
            val_6 = this;
            LobbyItemsController.丅一丑三一一丅丑丌 val_1 = new LobbyItemsController.丅一丑三一一丅丑丌();
            if(val_1 != null)
            {
                    .丞丅上丏丂且下丅与 = val_5;
            }
            else
            {
                    mem[16] = val_5;
                val_5 = mem[16];
            }
            
            val_7 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
            {
                    return (Rilisoft.LobbyItemsBundle)System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemsBundle>(source:  val_6 = this.Bundles, predicate:  System.Func<Rilisoft.LobbyItemsBundle, System.Boolean> val_3 = null);
            }
            
            val_5 = val_3;
            val_3 = new System.Func<Rilisoft.LobbyItemsBundle, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.丅一丑三一一丅丑丌::丄丌与与不丈丘丝七(Rilisoft.LobbyItemsBundle 七丞丙丒三丕且丌丟));
            return (Rilisoft.LobbyItemsBundle)System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemsBundle>(source:  val_6, predicate:  val_3);
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丌丆丙一丟丗丐丞与(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙, int 丏世丞丅丁丄丁万丑)
        {
            object val_6;
            var val_7;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32> val_9;
            LobbyItemsController.丏与丂丟世丙下专丆 val_1 = null;
            val_6 = val_1;
            val_1 = new LobbyItemsController.丏与丂丟世丙下专丆();
            if(val_6 != null)
            {
                    .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            }
            else
            {
                    mem[16] = 与丄不丌一世东丁丙;
            }
            
            .丏世丞丅丁丄丁万丑 = 丏世丞丅丁丄丁万丑;
            val_7 = null;
            val_7 = null;
            val_9 = LobbyItemsController.<>c.<>9__85_1;
            if(val_9 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.丏与丂丟世丙下专丆::世丄丞丄丞与丕七上(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))), keySelector:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32> val_4 = null));
            }
            
            val_9 = val_4;
            val_4 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LobbyItemsController.<>c::与丟业丟专东丑且丁(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyItemsController.<>c.<>9__85_1 = val_9;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean LobbyItemsController.丏与丂丟世丙下专丆::世丄丞丄丞与丕七上(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))), keySelector:  val_4));
        }
        internal System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁> 世下丂丅丒不丄三专(int 丏世丞丅丁丄丁万丑)
        {
            LobbyItemsController.丒与万丏万三丏一下 val_1 = new LobbyItemsController.丒与万丏万三丏一下();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丏世丞丅丁丄丁万丑 = 丏世丞丅丁丄丁万丑;
            .东且丁丆丛丁丏丘且 = new System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁>();
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<LobbyItemSlot>(七丐丅专且专七三丆:  new System.Action<LobbyItemSlot>(object:  val_1, method:  System.Void LobbyItemsController.丒与万丏万三丏一下::与七不与上丗丄与丑(丕专丟上与丄丈三丏.LobbyItemSlot 下下丏一丙不丘丌丞)));
            return (System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁>)(LobbyItemsController.丒与万丏万三丏一下)[1152921543104913792].东且丁丆丛丁丏丘且;
        }
        internal string 不丟与万丘上世丄万(System.Collections.Generic.ICollection<string> 与丝东万丙丞丝丟七)
        {
            var val_16;
            System.Collections.Generic.IEnumerable<T> val_17;
            var val_21;
            var val_22;
            var val_23;
            val_17 = 与丝东万丙丞丝丟七;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<System.String>(丑东与丅丐丅丂丞业:  val_17)) == true)
            {
                goto label_56;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_17 = val_17.GetEnumerator();
            label_28:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_17.MoveNext() == false)
            {
                goto label_14;
            }
            
            new LobbyItemsController.丝丞与丞不丝一丁丒() = new LobbyItemsController.丝丞与丞不丝一丁丒();
            var val_21 = 0;
            val_21 = val_21 + 1;
            .丞丅上丏丂且下丅与 = val_17.Current;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_9 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丝丞与丞不丝一丁丒(), method:  System.Boolean LobbyItemsController.丝丞与丞不丝一丁丒::丄丂世丙丒丟三业丘(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            Rilisoft.丏丘七丞丄丙丌丞丁 val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  null);
            if((((((val_10 == null) || (val_10.丐丙丛世丒丛丞丁万() == false)) || (val_10.丐万且七专丒七丛丞() == false)) || (val_10.且丅一一三七专丑丏() == true)) || (val_10.丑丆丑三且丛上且丟() == true)) || ((Rilisoft.LobbyItemsController.丟丝丌丏一下丒丝丛(与丄不丌一世东丁丙:  val_10.丘专上世与丟丝丟丛())) == val_10))
            {
                goto label_28;
            }
            
            val_21 = val_10.业上丙丞丐丄丆丅七();
            val_22 = 0;
            val_16 = 0;
            val_23 = 141;
            goto label_29;
            label_14:
            val_22 = 0;
            val_16 = 0;
            val_21 = 0;
            val_23 = 139;
            label_29:
            if(val_17 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_17.Dispose();
            }
            
            if( == 1)
            {
                goto label_51;
            }
            
            if(139 == 141)
            {
                    return (string)val_21;
            }
            
            val_21 = 0;
            if( == false)
            {
                    return (string)val_21;
            }
            
            if(139 != 139)
            {
                goto label_54;
            }
            
            return (string)val_21;
            label_51:
            if( == false)
            {
                goto label_56;
            }
            
            label_54:
            label_56:
            val_21 = 0;
            return (string)val_21;
        }
        internal string 下丆东丌东一丗丑一(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗)
        {
            var val_18;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_20;
            System.Collections.Generic.IEnumerable<T> val_21;
            var val_22;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_24;
            var val_25;
            var val_26;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_28;
            val_18 = null;
            val_18 = null;
            val_20 = LobbyItemsController.<>c.<>9__88_0;
            if(val_20 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_2 = null;
                val_20 = val_2;
                val_2 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::丄丒丝专丐丁丞丄且(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__88_0 = val_20;
            }
            
            val_21 = System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.万丂丙丒丒丞丏下下(一丐丅且丛不不丌丗:  一丐丅且丛不不丌丗, 丁丅丑下丝丆丄下丏:  true), predicate:  val_2));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Rilisoft.丏丘七丞丄丙丌丞丁>(丑东与丅丐丅丂丞业:  val_21)) == true)
            {
                    return 0;
            }
            
            val_22 = null;
            val_22 = null;
            val_24 = LobbyItemsController.<>c.<>9__88_1;
            if(val_24 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6 = null;
                val_24 = val_6;
                val_6 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::业丙世丝丘七丛丙万(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__88_1 = val_24;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_7 = System.Linq.Enumerable.LastOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_21, predicate:  val_6);
            if(val_7 != null)
            {
                    if(val_21 != null)
            {
                    val_25 = val_21.IndexOf(item:  val_7);
            }
            else
            {
                    val_25 = 0.IndexOf(item:  val_7);
            }
            
                if(val_25 == (val_21.Count - 1))
            {
                    return 0;
            }
            
                val_21 = System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Skip<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_21, count:  val_25 + 1));
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = LobbyItemsController.<>c.<>9__88_2;
            if(val_28 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_15 = null;
                val_28 = val_15;
                val_15 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::上万一丞丄下丌世丌(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__88_2 = val_28;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_16 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_21, predicate:  val_15);
            if(val_16 == null)
            {
                    return 0;
            }
            
            return val_16.业上丙丞丐丄丆丅七();
        }
        internal string 与丂丆丕丐三业下丐()
        {
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_24;
            var val_25;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_27;
            var val_28;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_24 = 0;
            val_24 = val_24 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Cast<LobbyItemSlot>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
            label_34:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_15;
            }
            
            new LobbyItemsController.不丙丗丙不丑丂丏丏() = new LobbyItemsController.不丙丗丙不丑丂丏丏();
            var val_26 = 0;
            val_26 = val_26 + 1;
            .与丄不丌一世东丁丙 = val_5.Current;
            val_24 = null;
            val_24 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.不丙丗丙不丑丂丏丏(), method:  System.Boolean LobbyItemsController.不丙丗丙不丑丂丏丏::一丂东七丙丟丂丏与(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  null);
            val_25 = null;
            val_25 = null;
            val_27 = LobbyItemsController.<>c.<>9__89_1;
            if(val_27 == null)
            {
                    val_27 = null;
                val_27 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::三丁丒丘万东一丆上(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__89_1 = val_27;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_12, predicate:  null)) == true)
            {
                goto label_34;
            }
            
            val_28 = null;
            val_28 = null;
            val_30 = LobbyItemsController.<>c.<>9__89_2;
            if(val_30 == null)
            {
                    val_30 = null;
                val_30 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::丄丝丈丄丟丛丄丝不(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__89_2 = val_30;
            }
            
            System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_12, predicate:  null));
            if(val_17.Count < 1)
            {
                goto label_34;
            }
            
            val_31 = val_17.Item[UnityEngine.Random.Range(min:  0, max:  val_17.Count)].业上丙丞丐丄丆丅七();
            val_32 = 0;
            val_33 = 0;
            val_34 = 220;
            goto label_38;
            label_15:
            val_32 = 0;
            val_33 = 0;
            val_31 = 0;
            val_34 = 218;
            label_38:
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_5.Dispose();
            }
            
            if( == 1)
            {
                goto label_65;
            }
            
            if(218 == 220)
            {
                    return (string)val_31;
            }
            
            val_31 = 0;
            if( == false)
            {
                    return (string)val_31;
            }
            
            if(218 != 218)
            {
                goto label_68;
            }
            
            return (string)val_31;
            label_65:
            if( == false)
            {
                goto label_70;
            }
            
            label_68:
            label_70:
            val_31 = 0;
            return (string)val_31;
        }
        internal bool 丆丑下丙专下丒丅丆(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七, bool 丑丝一丟丕上丆专下 = False, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
        {
            System.Object[] val_19;
            var val_20;
            object val_21;
            var val_24;
            val_19 = this;
            val_20 = null;
            System.Nullable<System.Int64> val_1 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            if(下丅丙一丂丗丅丝七 == null)
            {
                goto label_4;
            }
            
            if((下丅丙一丂丗丅丝七.丑丆丑三且丛上且丟() == false) || (丑丝一丟丕上丆专下 == true))
            {
                goto label_6;
            }
            
            object[] val_3 = new object[1];
            val_19 = val_3;
            val_19[0] = 下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "item \'{0}\' is crafting now", args:  val_3);
            return false;
            label_3:
            val_21 = "CurrentTime is null";
            goto label_17;
            label_4:
            val_21 = "item is null";
            label_17:
            UnityEngine.Debug.LogError(message:  val_21);
            return false;
            label_6:
            this.<丛上丟丏与丕丒东丂>k__BackingField = 下丅丙一丂丗丅丝七;
            if(下丅丙一丂丗丅丝七.丌七丌下丙三世丅一() == null)
            {
                    .InfoId = 下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
                下丅丙一丂丗丅丝七.丈东丈丁丕不丗丄丟(丙业与丙丗丝不丈东:  new Rilisoft.LobbyItemPlayerInfo());
            }
            
            Rilisoft.LobbyItemPlayerInfo val_10 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
            System.Nullable<System.Int64> val_11 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_10._craftStarted = 0;
            mem2[0] = 0;
            下丅丙一丂丗丅丝七.丌七丌下丙三世丅一().isNew = false;
            if(丑丝一丟丕上丆专下 != false)
            {
                    Rilisoft.LobbyItemPlayerInfo val_14 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
                Rilisoft.丝丑丂丛万丐丈丘且 val_19 = val_14._craftStarted;
                val_19 = val_19 + 下丅丙一丂丗丅丝七.丅丞上丘丆下上丘丅();
                int val_16 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                val_14._craftStarted = 0;
                mem2[0] = 0;
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_17 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            val_17.Add(item:  下丅丙一丂丗丅丝七.丌七丌下丙三世丅一());
            val_17.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_17, 万丐丏丐丒万不丟三:  万丐丏丐丒万不丟三, 丘专丑丕且且丄专丁:  true);
            val_24 = null;
            val_24 = null;
            if(Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下 != null)
            {
                    Rilisoft.LobbyItemsController.丘丐丟丑丈丗丟专下.Invoke(obj:  this.<丛上丟丏与丕丒东丂>k__BackingField);
            }
            
            BalanceController.丙丏丂下丂上七不一();
            return false;
        }
        internal bool 丂丗丕三丏丙丕丈一(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七, bool 一丕万业丗丑丒丈与 = True, bool 丒且万丏世上丟丏万 = True, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, bool 丘专丑丕且且丄专丁 = True)
        {
            丈丞丕丘丕丗与上一 val_51;
            bool val_52;
            object val_53;
            var val_54;
            int val_56;
            long val_57;
            Rilisoft.LobbyItemPlayerInfo val_61;
            var val_62;
            var val_63;
            var val_65;
            System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> val_66;
            System.Action<Rilisoft.丏丘七丞丄丙丌丞丁, System.Int32, System.Boolean> val_67;
            val_51 = 万丐丏丐丒万不丟三;
            val_52 = 丒且万丏世上丟丏万;
            val_53 = 下丅丙一丂丗丅丝七;
            if(val_53 == null)
            {
                goto label_1;
            }
            
            if(val_53.且丅一一三七专丑丏() == false)
            {
                goto label_2;
            }
            
            object[] val_2 = new object[1];
            val_53 = val_53.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            val_2[0] = val_53;
            UnityEngine.Debug.LogErrorFormat(format:  "item \'{0}\' allready exists", args:  val_2);
            val_54 = 0;
            return (bool)val_54;
            label_1:
            UnityEngine.Debug.LogError(message:  "item is null");
            val_54 = 0;
            return (bool)val_54;
            label_2:
            if(val_53.丌七丌下丙三世丅一() == null)
            {
                    .InfoId = val_53.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
                val_53.丈东丈丁丕不丗丄丟(丙业与丙丗丝不丈东:  new Rilisoft.LobbyItemPlayerInfo());
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_9 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            long val_54 = val_9.七丏专丟世丌一丌七();
            Rilisoft.LobbyItemPlayerInfo val_11 = val_53.丌七丌下丙三世丅一();
            if(val_53.丒丙丙世丅且下丁丐() == null)
            {
                goto label_17;
            }
            
            if(val_11 != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            int val_13 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_11._craftStarted = 0;
            mem2[0] = 0;
            Rilisoft.LobbyItemPlayerInfo val_14 = val_53.丌七丌下丙三世丅一();
            val_14.IsCrafted = true;
            val_53.丌七丌下丙三世丅一().isNew = false;
            if((this.<丛上丟丏与丕丒东丂>k__BackingField) == val_53)
            {
                    this.<丛上丟丏与丕丒东丂>k__BackingField = 0;
            }
            
            if((val_53.丝丞世丕丒下东丌丄() == false) || (val_53.丒丙丙世丅且下丁丐() == null))
            {
                goto label_23;
            }
            
            var val_53 = 0;
            val_53 = val_53 + 1;
            goto label_30;
            label_23:
            val_56 = 1;
            goto label_31;
            label_17:
            val_54 = val_54 - val_53.丅丞上丘丆下上丘丅();
            if(val_11 != null)
            {
                goto label_32;
            }
            
            goto label_33;
            label_30:
            System.Collections.Generic.IEnumerator<T> val_25 = val_53.丒丙丙世丅且下丁丐().Items.GetEnumerator();
            label_65:
            val_57 = val_54;
            label_46:
            var val_55 = 0;
            val_55 = val_55 + 1;
            if(val_25.MoveNext() == false)
            {
                goto label_39;
            }
            
            var val_56 = 0;
            val_56 = val_56 + 1;
            T val_29 = val_25.Current;
            if(val_29.且丅一一三七专丑丏() == true)
            {
                goto label_46;
            }
            
            if(val_29.丌七丌下丙三世丅一() == null)
            {
                    Rilisoft.LobbyItemPlayerInfo val_32 = new Rilisoft.LobbyItemPlayerInfo();
                val_61 = val_32;
                if(val_61 == 0)
            {
                    val_61 = val_32;
            }
            
                mem[1152921543106143960] = val_29.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
                if(val_29 == 0)
            {
                    val_61 = val_32;
            }
            
                val_29.丈东丈丁丕不丗丄丟(丙业与丙丗丝不丈东:  val_32);
            }
            
            Rilisoft.LobbyItemPlayerInfo val_35 = val_29.丌七丌下丙三世丅一();
            int val_37 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            long val_38 = val_54 - val_29.丅丞上丘丆下上丘丅();
            mem2[0] = 0;
            mem2[0] = 0;
            Rilisoft.LobbyItemPlayerInfo val_39 = val_29.丌七丌下丙三世丅一();
            val_39.IsCrafted = true;
            val_29.丌七丌下丙三世丅一().isNew = false;
            val_9.Add(item:  val_29.丌七丌下丙三世丅一());
            if((this.<丛上丟丏与丕丒东丂>k__BackingField) == val_29)
            {
                    this.<丛上丟丏与丕丒东丂>k__BackingField = 0;
            }
            
            int val_43 = val_29.丙丕丞且丕不丘丙丑().三丌专三东世丆东专();
            goto label_65;
            label_39:
            val_62 = 0;
            val_63 = 0;
            if(val_25 == null)
            {
                
            }
            else
            {
                    var val_57 = 0;
                val_57 = val_57 + 1;
                val_25.Dispose();
            }
            
            if(( == 1) || (420 != 420))
            {
                goto label_94;
            }
            
            val_51 = val_51;
            val_62 = 0;
            if(一丕万业丗丑丒丈与 == true)
            {
                goto label_95;
            }
            
            goto label_129;
            label_94:
            val_51 = val_51;
            if( != false)
            {
                    val_63 = 0;
            }
            
            if(一丕万业丗丑丒丈与 == false)
            {
                goto label_129;
            }
            
            label_95:
            List.Enumerator<T> val_46 = this.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_53, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  false).GetEnumerator();
            label_104:
            if(((-155543040) & 1) == 0)
            {
                goto label_100;
            }
            
            string val_48 = 0.丐丏七丌丕丗业且上();
            if((val_9.Contains(item:  val_48)) == true)
            {
                goto label_104;
            }
            
            val_9.Add(item:  val_48);
            goto label_104;
            label_100:
            val_51 = val_51;
            val_62 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(val_62 == 1)
            {
                goto label_109;
            }
            
            if(( == 0) || (500 == 500))
            {
                goto label_129;
            }
            
            label_128:
            label_129:
            BalanceController.丙丏丂下丂上七不一();
            val_56 = System.Linq.Enumerable.Count<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_53.丒丙丙世丅且下丁丐().NotExistsItems);
            val_52 = val_52;
            label_31:
            val_9.Add(item:  val_53.丌七丌下丙三世丅一());
            val_9.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_9, 万丐丏丐丒万不丟三:  null, 丘专丑丕且且丄专丁:  丘专丑丕且且丄专丁);
            if(丘专丑丕且且丄专丁 != false)
            {
                    val_65 = null;
                val_65 = null;
                val_66 = Rilisoft.LobbyItemsController.丒下业丙与一丟丑三;
                if(val_66 != null)
            {
                    val_66 = Rilisoft.LobbyItemsController.丒下业丙与一丟丑三;
                if(val_66 == null)
            {
                    val_66 = 0;
            }
            
                val_66.Invoke(obj:  val_53);
                val_65 = null;
            }
            
                val_65 = null;
                val_67 = Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟;
                if(val_67 != null)
            {
                    val_67 = Rilisoft.LobbyItemsController.丘丑专下丘世不丆丟;
                if(val_67 == null)
            {
                    val_67 = 0;
            }
            
                val_67.Invoke(arg1:  val_53, arg2:  val_56, arg3:  val_52);
            }
            
            }
            
            val_54 = 1;
            return (bool)val_54;
            label_109:
            if( != 0)
            {
                goto label_128;
            }
            
            goto label_129;
        }
        internal bool 丛下丛七上上上丛丐(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_13;
            object val_14;
            var val_15;
            System.Object[] val_16;
            string val_17;
            object val_18;
            var val_19;
            System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> val_20;
            var val_21;
            val_14 = 下丅丙一丂丗丅丝七;
            val_15 = null;
            System.Nullable<System.Int64> val_1 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            if(val_14 == null)
            {
                goto label_4;
            }
            
            if(val_14.且丅一一三七专丑丏() == false)
            {
                goto label_5;
            }
            
            val_16 = new object[1];
            val_14 = val_14.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            val_16[0] = val_14;
            val_17 = "item \'{0}\' is crafted";
            goto label_13;
            label_3:
            val_18 = "CurrentTime is null";
            goto label_16;
            label_4:
            val_18 = "item is null";
            label_16:
            UnityEngine.Debug.LogError(message:  val_18);
            goto label_19;
            label_5:
            if(val_14.丌七丌下丙三世丅一() != null)
            {
                    Rilisoft.LobbyItemPlayerInfo val_7 = val_14.丌七丌下丙三世丅一();
                val_7.IsCrafted = true;
                val_13 = val_14.丌七丌下丙三世丅一();
                val_8.IsCraftedAndNotShown = true;
                if((this.<丛上丟丏与丕丒东丂>k__BackingField) == val_14)
            {
                    this.<丛上丟丏与丕丒东丂>k__BackingField = 0;
            }
            
                System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_9 = this.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_14, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
                val_19 = null;
                val_19 = null;
                val_20 = Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上;
                if(val_20 != null)
            {
                    val_20 = Rilisoft.LobbyItemsController.丝与丟丕且丈丙且上;
                if(val_20 == null)
            {
                    val_20 = 0;
            }
            
                val_20.Invoke(obj:  val_14);
            }
            
                val_21 = 1;
                return (bool)val_21;
            }
            
            object[] val_10 = new object[1];
            val_16 = val_10;
            val_14 = val_14.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            val_16[0] = val_14;
            val_17 = "item \'{0}\' is not player item";
            label_13:
            UnityEngine.Debug.LogErrorFormat(format:  val_17, args:  val_10);
            label_19:
            val_21 = 0;
            return (bool)val_21;
        }
        private long 七丏专丟世丌一丌七()
        {
            var val_4;
            var val_5;
            if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    val_4 = null;
                System.Nullable<System.Int64> val_2 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
                val_5;
                return (long)专七专下且专三一且.上且一丈丐三丄一丆();
            }
            
            UnityEngine.Debug.LogWarning(message:  "add lobby item: server time is not synchronized, using system time");
            return (long)专七专下且专三一且.上且一丈丐三丄一丆();
        }
        internal System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> 丛上丑下丐丄丘丗七(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七, bool 与且专丏丅世丐丐丑 = False, System.Nullable<long> 丞一上万一丞丙七下, bool 丘丛与不专丅丑丒丛 = True, bool 丘专丑丕且且丄专丁 = True)
        {
            var val_25;
            bool val_26;
            var val_27;
            bool val_28;
            var val_29;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_30;
            var val_31;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_32;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_34;
            var val_38;
            var val_40;
            val_25 = W6;
            val_26 = 丘专丑丕且且丄专丁;
            val_27 = 丘丛与不专丅丑丒丛;
            val_28 = 丞一上万一丞丙七下.HasValue;
            val_29 = 与且专丏丅世丐丐丑;
            val_30 = 下丅丙一丂丗丅丝七;
            val_31 = 1152921505359773696;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  144);
            if((val_30 == null) || (val_30.且丅一一三七专丑丏() == false))
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_3 = null;
            val_32 = val_3;
            val_3 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            if(val_30.丝丞世丕丒下东丌丄() == false)
            {
                goto label_6;
            }
            
            val_34 = LobbyItemsController.<>c.<>9__94_0;
            if(val_34 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_5 = null;
                val_34 = val_5;
                val_5 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::业三丛丙丗丁丙丌与(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__94_0 = val_34;
                val_25 = val_25;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_5);
            val_31 = val_31;
            val_29 = val_29;
            val_26 = val_26;
            goto label_17;
            label_5:
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_7 = null;
            val_32 = val_7;
            val_7 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            return val_32;
            label_6:
            Rilisoft.丏丘七丞丄丙丌丞丁 val_9 = this.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  val_30.丘专上世与丟丝丟丛());
            if(val_9 != null)
            {
                    Rilisoft.LobbyItemPlayerInfo val_10 = val_9.丌七丌下丙三世丅一();
                val_10.IsEquiped = false;
                val_3.Add(item:  val_9.丌七丌下丙三世丅一());
                val_29 = val_29;
                val_27 = val_27;
                val_28 = val_28;
            }
            
            label_17:
            if(val_30.丝丞世丕丒下东丌丄() == false)
            {
                goto label_55;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            System.Collections.Generic.IEnumerator<T> val_16 = val_30.丒丙丙世丅且下丁丐().Items.GetEnumerator();
            label_38:
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_16.MoveNext() == false)
            {
                goto label_30;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            T val_20 = val_16.Current;
            val_3.AddRange(collection:  this);
            goto label_38;
            label_30:
            val_25 = val_25;
            val_38 = 0;
            val_27 = 0;
            if(val_16 == null)
            {
                
            }
            else
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_16.Dispose();
            }
            
            val_31 = 1152921505359773696;
            val_26 = val_26;
            if( == 1)
            {
                goto label_51;
            }
            
            if(val_26 == true)
            {
                goto label_52;
            }
            
            label_58:
            if(val_29 == false)
            {
                goto label_53;
            }
            
            goto label_62;
            label_51:
            label_55:
            Rilisoft.LobbyItemPlayerInfo val_22 = val_30.丌七丌下丙三世丅一();
            val_22.IsEquiped = true;
            val_3.Add(item:  val_30.丌七丌下丙三世丅一());
            if(val_26 == false)
            {
                goto label_58;
            }
            
            label_52:
            val_3.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_3, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:   & 1);
            if(val_29 == true)
            {
                goto label_62;
            }
            
            label_53:
            val_40 = null;
            val_40 = null;
            val_26 = Rilisoft.LobbyItemsController.世丐与下丂业上丗丛;
            if(val_26 != null)
            {
                    val_26.Invoke(arg1:  val_30.丘专上世与丟丝丟丛(), arg2:  0, arg3:  val_30);
            }
            
            label_62:
            val_30 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_30.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return val_32;
        }
        internal void 丂丂丘与与丂下丞丛(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_15;
            var val_16;
            System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁> val_17;
            LobbyItemSlot val_18;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_19;
            var val_20;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_21;
            var val_22;
            System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁> val_23;
            val_15 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_15.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  145);
            Rilisoft.丏丘七丞丄丙丌丞丁 val_2 = this.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
            if(val_2 == null)
            {
                goto label_29;
            }
            
            if((Rilisoft.LobbyItemsController.丄专与丝上专下东专(与丄不丌一世东丁丙:  与丄不丌一世东丁丙)) == false)
            {
                goto label_7;
            }
            
            Rilisoft.LobbyItemPlayerInfo val_4 = val_2.丌七丌下丙三世丅一();
            val_4.IsEquiped = false;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_5 = null;
            val_15 = val_5;
            val_5 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            val_5.Add(item:  val_2.丌七丌下丙三世丅一());
            val_5.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_5, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
            val_16 = null;
            val_16 = null;
            val_17 = Rilisoft.LobbyItemsController.世丐与下丂业上丗丛;
            if(val_17 == null)
            {
                goto label_29;
            }
            
            val_17 = Rilisoft.LobbyItemsController.世丐与下丂业上丗丛;
            if(val_17 == null)
            {
                    val_17 = 0;
            }
            
            val_18 = 与丄不丌一世东丁丙;
            val_19 = val_2;
            val_20 = public System.Void System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>::Invoke(LobbyItemSlot arg1, Rilisoft.丏丘七丞丄丙丌丞丁 arg2, Rilisoft.丏丘七丞丄丙丌丞丁 arg3);
            val_21 = 0;
            goto label_16;
            label_7:
            if((Rilisoft.LobbyItemsController.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  val_2)) == true)
            {
                goto label_29;
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_8 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            val_15 = Rilisoft.LobbyItemsController.丟丝丌丏一下丒丝丛(与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
            if(val_15 != null)
            {
                    Rilisoft.LobbyItemPlayerInfo val_10 = val_15.丌七丌下丙三世丅一();
                val_10.IsEquiped = true;
                val_8.Add(item:  val_15.丌七丌下丙三世丅一());
            }
            
            Rilisoft.LobbyItemPlayerInfo val_12 = val_2.丌七丌下丙三世丅一();
            val_12.IsEquiped = false;
            val_8.Add(item:  val_2.丌七丌下丙三世丅一());
            val_8.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_8, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
            val_22 = null;
            val_22 = null;
            val_23 = Rilisoft.LobbyItemsController.世丐与下丂业上丗丛;
            if(val_23 == null)
            {
                goto label_29;
            }
            
            val_23 = Rilisoft.LobbyItemsController.世丐与下丂业上丗丛;
            if(val_23 == null)
            {
                    val_23 = 0;
            }
            
            val_18 = 与丄不丌一世东丁丙;
            val_19 = val_2;
            val_20 = public System.Void System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>::Invoke(LobbyItemSlot arg1, Rilisoft.丏丘七丞丄丙丌丞丁 arg2, Rilisoft.丏丘七丞丄丙丌丞丁 arg3);
            val_21 = val_15;
            label_16:
            val_23.Invoke(arg1:  val_18, arg2:  val_19, arg3:  val_21);
            label_29:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void OnInstanceCreated()
        {
            var val_9;
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyItemsController::丕三丂丞丈不不丌专()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyItemsController::丕三丂丞丈不不丌专()));
            this.不世丘东丂丟丗下丙(丘专丑丕且且丄专丁:  true);
            this.世丗丏丂丅丘且上丏();
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
            {
                    return;
            }
            
            val_9 = null;
            if(Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝() == true)
            {
                    return;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_6 = this.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "decor_big_military_1");
            if(val_6.且丅一一三七专丑丏() != false)
            {
                    return;
            }
            
            bool val_8 = this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_6, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
        }
        private void 丕三丂丞丈不不丌专()
        {
            if(this.丆丘丒不上下一丙一 == false)
            {
                    return;
            }
            
            this.不世丘东丂丟丗下丙(丘专丑丕且且丄专丁:  true);
            this.世丗丏丂丅丘且上丏();
        }
        private void Update()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_6 = null;
            System.Nullable<System.Int64> val_2 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                    return;
            }
            
            if((this.<丛上丟丏与丕丒东丂>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丛上丟丏与丕丒东丂>k__BackingField.下丞丘丏丂丕丄丐丘()) > 0)
            {
                    return;
            }
            
            bool val_4 = this.丛下丛七上上上丛丐(下丅丙一丂丗丅丝七:  this.<丛上丟丏与丕丒东丂>k__BackingField);
        }
        internal void 不世丘东丂丟丗下丙(bool 丘专丑丕且且丄专丁 = True)
        {
            var val_12;
            Rilisoft.LobbyItemsController val_71;
            var val_73;
            object val_74;
            var val_75;
            var val_77;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_79;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_80;
            var val_81;
            bool val_83;
            bool val_84;
            var val_85;
            string val_86;
            int val_87;
            int val_88;
            object val_89;
            bool val_91;
            var val_96;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_98;
            var val_99;
            val_71 = this;
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  79)) != true)
            {
                    if(this.丅丏不下与下丄下丁 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丅丏不下与下丄下丁);
            }
            
                this.丅丏不下与下丄下丁 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丌丐与丐专东且丄丂());
            }
            
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_5 = new System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>();
            this.丛不丞丂七丞世丁丏 = val_5;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_6 = Rilisoft.LobbyItemsController.丙东丆专三三丗丛丅();
            if(丘专丑丕且且丄专丁 != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  8);
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_10 = 万丑丙丛不丑且且丄.一三专丞丒丅上业上().Values.GetEnumerator();
            label_35:
            if(((-153852288) & 1) == 0)
            {
                goto label_20;
            }
            
            new LobbyItemsController.东丈与丄丈万七且丏() = new LobbyItemsController.东丈与丄丈万七且丏();
            string val_14 = val_12.丐丏七丌丕丗业且上();
            if(new LobbyItemsController.东丈与丄丈万七且丏() != null)
            {
                    val_73 = new LobbyItemsController.东丈与丄丈万七且丏();
                .丂丑丙丏东丏东业丐 = val_14;
            }
            else
            {
                    mem[16] = val_14;
                val_73 = 16;
            }
            
            if((System.String.op_Equality(a:  val_73.业上丙丞丐丄丆丅七(), b:  "device_1_4")) == true)
            {
                goto label_35;
            }
            
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_17 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  new LobbyItemsController.东丈与丄丈万七且丏(), method:  System.Boolean LobbyItemsController.东丈与丄丈万七且丏::丞丂丝丝丕七丗丘丑(Rilisoft.LobbyItemPlayerInfo 七丞丙丒三丕且丌丟));
            val_74 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemPlayerInfo>(source:  val_6, predicate:  null);
            if(val_74 == null)
            {
                goto label_25;
            }
            
            if(new LobbyItemsController.东丈与丄丈万七且丏() != null)
            {
                goto label_33;
            }
            
            goto label_27;
            label_25:
            val_74 = new Rilisoft.LobbyItemPlayerInfo();
            val_74 = new System.Object();
            string val_20 = mem[16].业上丙丞丐丄丆丅七();
            if(val_74 != null)
            {
                    .InfoId = val_20;
            }
            else
            {
                    mem[40] = val_20;
            }
            
            ._isNew = true;
            if(new LobbyItemsController.东丈与丄丈万七且丏() != null)
            {
                goto label_33;
            }
            
            label_27:
            label_33:
            new Rilisoft.丏丘七丞丄丙丌丞丁() = new Rilisoft.丏丘七丞丄丙丌丞丁(东一丁世丑丞业丄丐:  mem[16], 东丛下丗且东丄业下:  new Rilisoft.LobbyItemPlayerInfo());
            this.丛不丞丂七丞世丁丏.Add(item:  new Rilisoft.丏丘七丞丄丙丌丞丁());
            goto label_35;
            label_20:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_75 = 1152921505469198336;
            val_77 = null;
            val_77 = null;
            val_79 = LobbyItemsController.<>c.<>9__99_0;
            if(val_79 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_22 = null;
                val_79 = val_22;
                val_22 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::专东丁下丕丘丗丌丟(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__99_0 = val_79;
            }
            
            this.<丛上丟丏与丕丒东丂>k__BackingField = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_22);
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_24 = null;
            val_80 = val_24;
            val_24 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            val_81 = null;
            Dictionary.Enumerator<TKey, TValue> val_25 = Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.GetEnumerator();
            label_87:
            if(((-153852336) & 1) == 0)
            {
                goto label_64;
            }
            
            new LobbyItemsController.东丒丛丛不业万丝丐() = new LobbyItemsController.东丒丛丛不业万丝丐();
            ConfiguredValueTaskAwaiter val_28 = val_12.GetAwaiter();
            .丅三丄丕丁丘丘业三 = val_28._value._obj;
            mem[1152921543107834616] = val_28._value._token;
            mem[1152921543107834618] = val_28._value._continueOnCapturedContext;
            new LobbyItemsController.丌丄丙不三七与丙丗() = new LobbyItemsController.丌丄丙不三七与丙丗();
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_30 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.东丒丛丛不业万丝丐(), method:  System.Boolean LobbyItemsController.东丒丛丛不业万丝丐::世丒丞丛上丒丟丙丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  null)) == false)
            {
                goto label_66;
            }
            
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_32 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  new LobbyItemsController.东丒丛丛不业万丝丐(), method:  System.Boolean LobbyItemsController.东丒丛丛不业万丝丐::上与丛专三与丄不下(Rilisoft.LobbyItemPlayerInfo 三东专丈丘丒东世七));
            if((System.Linq.Enumerable.Any<Rilisoft.LobbyItemPlayerInfo>(source:  val_6, predicate:  null)) == true)
            {
                goto label_87;
            }
            
            new Rilisoft.LobbyItemPlayerInfo() = new System.Object();
            if(new Rilisoft.LobbyItemPlayerInfo() == null)
            {
                goto label_68;
            }
            
            .InfoId = 1152921543107834608;
            .IsCrafted = true;
            .IsCraftedAndNotShown = false;
            goto label_69;
            label_66:
            object[] val_35 = new object[1];
            val_35[0] = 1152921543107834608;
            UnityEngine.Debug.LogErrorFormat(format:  "lobby item with id \'{0}\' not found", args:  val_35);
            goto label_87;
            label_68:
            mem[40] = 1152921543107834608;
            mem[48] = 1;
            .IsCraftedAndNotShown = false;
            label_69:
            new Rilisoft.LobbyItemPlayerInfo().isNew = false;
            .东丛下丗且东丄业下 = new Rilisoft.LobbyItemPlayerInfo();
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_36 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丌丄丙不三七与丙丗(), method:  System.Boolean LobbyItemsController.丌丄丙不三七与丙丗::丝丁丙丏丄东丞丞专(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            Rilisoft.丏丘七丞丄丙丌丞丁 val_37 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  null);
            val_37.丈东丈丁丕不丗丄丟(丙业与丙丗丝不丈东:  (LobbyItemsController.丌丄丙不三七与丙丗)[1152921543107838688].东丛下丗且东丄业下);
            if((this.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  val_37.丘专上世与丟丝丟丛())) == null)
            {
                goto label_80;
            }
            
            if(val_37 != null)
            {
                goto label_85;
            }
            
            goto label_82;
            label_80:
            Rilisoft.LobbyItemPlayerInfo val_40 = val_37.丌七丌下丙三世丅一();
            val_40.IsEquiped = true;
            if(val_37 != null)
            {
                goto label_85;
            }
            
            label_82:
            label_85:
            val_24.Add(item:  val_37.丌七丌下丙三世丅一());
            goto label_87;
            label_64:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_83 = 丘专丑丕且且丄专丁;
            val_84 = ;
            val_12.丁丞七丕丁丟东不丌(丅上丑丅与丄丏丑东:  val_24, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  val_84);
            this.丛丐万丄一丗专丕业(丘专丑丕且且丄专丁:  val_84);
            this.丙且丈丞丅业东丏万(丘专丑丕且且丄专丁:  val_84);
            System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> val_42 = Rilisoft.LobbyItemsBundlesHandler.一丁丝丂业丌丏下丕();
            if(val_42 == null)
            {
                goto label_117;
            }
            
            this.Bundles = val_42;
            List.Enumerator<T> val_43 = val_42.GetEnumerator();
            val_80 = 1152921504686346240;
            val_85 = 0;
            label_179:
            if(((-153852368) & 1) == 0)
            {
                goto label_118;
            }
            
            string val_44 = val_12.丐丏七丌丕丗业且上();
            new LobbyItemsController.丗三且七丈丕丌丁东() = new LobbyItemsController.丗三且七丈丕丌丁东();
            if(val_44 != null)
            {
                
            }
            else
            {
                    val_86 = 123372880;
            }
            
            if(0 == 0)
            {
                    val_87 = System.String.alignConst;
            }
            
            if((public System.Boolean List.Enumerator<Rilisoft.LobbyItemsBundle>::MoveNext()) == 0)
            {
                    val_88 = System.String.alignConst;
            }
            
            new 丕专丟上与丄丈三丏() = new 丕专丟上与丄丈三丏(与丄不丌一世东丁丙:  0, 丞丅上丏丂且下丅与:  val_86, 业东丘与与业丏丛丈:  val_87, 丑丆丙丐不七丙七下:  0, 丙万丘丗丅万丐一世:  1, 且不世丛丕业专丞下:  0, 专与七丏丐丝丄上丘:  val_88, 下丝丅丘丟三丝丆丞:  0, 丗三丑丐丄万东丐丙:  false, 丐丛世一七丒专一东:  null);
            .东一丁世丑丞业丄丐 = new 丕专丟上与丄丈三丏();
            var val_76 = 0;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_47 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  new LobbyItemsController.丗三且七丈丕丌丁东(), method:  System.Boolean LobbyItemsController.丗三且七丈丕丌丁东::丅丅丐不下丒丕丗丄(Rilisoft.LobbyItemPlayerInfo 三东专丈丘丒东世七));
            val_89 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemPlayerInfo>(source:  val_6, predicate:  null);
            if(val_89 == null)
            {
                    val_89 = new Rilisoft.LobbyItemPlayerInfo();
                val_89 = new System.Object();
                string val_50 = (LobbyItemsController.丗三且七丈丕丌丁东)[1152921543107904240].东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七();
                if(val_89 != null)
            {
                    .InfoId = val_50;
            }
            else
            {
                    mem[40] = val_50;
            }
            
                ._isNew = true;
            }
            
            new Rilisoft.丏丘七丞丄丙丌丞丁() = new Rilisoft.丏丘七丞丄丙丌丞丁(东一丁世丑丞业丄丐:  (LobbyItemsController.丗三且七丈丕丌丁东)[1152921543107904240].东一丁世丑丞业丄丐, 东丛下丗且东丄业下:  new Rilisoft.LobbyItemPlayerInfo());
            val_5.Add(item:  new Rilisoft.丏丘七丞丄丙丌丞丁());
            if(val_44.IsMyBandle != true)
            {
                    if(new Rilisoft.丏丘七丞丄丙丌丞丁().且丅一一三七专丑丏() == true)
            {
                goto label_132;
            }
            
            }
            
            Rilisoft.LobbyItemPlayerInfo val_54 = new Rilisoft.丏丘七丞丄丙丌丞丁().丌七丌下丙三世丅一();
            if(val_54.IsCrafted == false)
            {
                goto label_135;
            }
            
            label_132:
            var val_73 = 0;
            val_73 = val_73 + 1;
            goto label_140;
            label_135:
            val_91 = 0;
            goto label_171;
            label_140:
            System.Collections.Generic.IEnumerator<T> val_57 = val_44.Items.GetEnumerator();
            label_155:
            var val_74 = 0;
            val_74 = val_74 + 1;
            if(val_57.MoveNext() == false)
            {
                goto label_147;
            }
            
            var val_75 = 0;
            val_75 = val_75 + 1;
            T val_61 = val_57.Current;
            if(val_61.且丅一一三七专丑丏() == true)
            {
                goto label_155;
            }
            
            bool val_64 = this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_61, 一丕万业丗丑丒丈与:  false, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  丘专丑丕且且丄专丁);
            goto label_155;
            label_147:
            val_91 = 0;
            val_76 = val_76 + 1;
            mem2[0] = 949;
            if(val_57 == null)
            {
                
            }
            else
            {
                    var val_77 = 0;
                val_77 = val_77 + 1;
                val_57.Dispose();
            }
            
            if((val_76 != 1) && ((-153852480 + ((0 + 1)) << 2) == 949))
            {
                    var val_78 = 0;
                val_78 = val_78 ^ (val_76 >> 31);
                val_76 = val_76 + val_78;
            }
            else
            {
                    if( != false)
            {
                    val_91 = 0;
            }
            
            }
            
            label_171:
            val_96 = null;
            val_96 = null;
            val_98 = LobbyItemsController.<>c.<>9__99_6;
            if(val_98 == null)
            {
                    val_98 = null;
                val_98 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::万丗丁一丂下丛丅丒(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyItemsController.<>c.<>9__99_6 = val_98;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_67 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_5, predicate:  null);
            if((val_67 == null) || (val_67.且丅一一三七专丑丏() == true))
            {
                goto label_179;
            }
            
            bool val_70 = this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_67, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  丘专丑丕且且丄专丁);
            goto label_179;
            label_117:
            UnityEngine.Debug.LogError(message:  "nullable lobby items bundles");
            goto label_182;
            label_118:
            val_84 = ;
            val_99 = 0 + 1;
            mem2[0] = 1047;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_99 == 1)
            {
                goto label_213;
            }
            
            if(( == 0) || ((-153852480 + ((0 + 1)) << 2) == 1047))
            {
                goto label_221;
            }
            
            label_220:
            label_221:
            this.丝不业丘万丗与业丁(且丛丏丄丟丐丝三一:  "bundle_space", 丞一丁业丄一一业且:  "background_1_space_1", 丘专丑丕且且丄专丁:  null);
            label_182:
            this.丝专丞丈丂东丝丈丌(丙业与丙丗丝不丈东:  true);
            if( == false)
            {
                    return;
            }
            
            val_83 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_83.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_213:
            if( != 0)
            {
                goto label_220;
            }
            
            goto label_221;
        }
        internal bool 丄业丝丆丗世丈丏丒()
        {
            return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.丟丆丐丛丈丛专上丄, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
        }
        private void 丘丕丟丆丛丞丒下丞(bool 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丟丆丐丛丈丛专上丄, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private System.Collections.IEnumerator 丌丐与丐专东且丄丂()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyItemsController.丈丁丙且丑丄东丁丈(丗丏丅丕丆世丁专丟:  0);
        }
        private void 丌丛上丟专与世专一()
        {
            var val_14;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_15;
            var val_16;
            var val_18;
            val_14 = this;
            val_15 = 1152921505369411584;
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  79)) == true)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  162);
            val_16 = null;
            val_16 = null;
            val_15 = LobbyItemsController.<>c.<>9__108_0;
            if(val_15 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_6 = null;
                val_15 = val_6;
                val_6 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  LobbyItemsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemsController.<>c::丒万丗丘丐丌一七不(Rilisoft.LobbyItemPlayerInfo 丐丆丂丒丁万丈丛丅));
                LobbyItemsController.<>c.<>9__108_0 = val_15;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemPlayerInfo>(source:  Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂().东丌丁丅丞东七丂丗(), predicate:  val_6)) != null)
            {
                    val_18 = null;
                val_18 = null;
                if(Rilisoft.LobbyItemsController.丂丏丁下七丌七丆丅 != false)
            {
                    this.丘丕丟丆丛丞丒下丞(丙业与丙丗丝不丈东:  true);
                val_15 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
                PGCompany.丗丟丄丈东丝丕丄世 val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  223).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  125), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  79);
            val_14 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_14.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 丛丐万丄一丗专丕业(bool 丘专丑丕且且丄专丁 = True)
        {
            var val_3;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_18 = this;
            val_19 = null;
            val_19 = null;
            List.Enumerator<T> val_1 = Rilisoft.LobbyItemsController.丘七一丘东与三世万.GetEnumerator();
            bool val_4 = 丘专丑丕且且丄专丁;
            label_20:
            if(((-152896944) & 1) == 0)
            {
                goto label_4;
            }
            
            int val_5 = val_3.丙东专丂世丈丏丁丂();
            if((this.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  val_5)) != null)
            {
                goto label_20;
            }
            
            val_20 = null;
            val_20 = null;
            if((Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.ContainsKey(key:  val_5)) == false)
            {
                goto label_20;
            }
            
            new LobbyItemsController.丟一丛丑丘上丗下东() = new LobbyItemsController.丟一丛丑丘上丗下东();
            val_21 = null;
            val_21 = null;
            .丞一丁业丄一一业且 = Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐.Item[val_5];
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_10 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丟一丛丑丘上丗下东(), method:  System.Boolean LobbyItemsController.丟一丛丑丘上丗下东::世丁业不丂专丂丗不(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            Rilisoft.丏丘七丞丄丙丌丞丁 val_11 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  null);
            if(val_11 == null)
            {
                goto label_20;
            }
            
            Rilisoft.LobbyItemPlayerInfo val_12 = val_11.丌七丌下丙三世丅一();
            if(val_12.IsCrafted != true)
            {
                    Rilisoft.LobbyItemPlayerInfo val_13 = val_11.丌七丌下丙三世丅一();
                val_13.IsCrafted = true;
                Rilisoft.LobbyItemPlayerInfo val_14 = val_11.丌七丌下丙三世丅一();
                val_14.IsCraftedAndNotShown = false;
                Rilisoft.LobbyItemPlayerInfo val_15 = val_11.丌七丌下丙三世丅一();
                val_15.isNew = false;
            }
            
            long val_16 = val_15.七丏专丟世丌一丌七();
            val_3 = 0;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_17 = this.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_11, 与且专丏丅世丐丐丑:  true, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
            goto label_20;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丝不业丘万丗与业丁(string 且丛丏丄丟丐丝三一, string 丞一丁业丄一一业且, bool 丘专丑丕且且丄专丁 = True)
        {
            string val_15;
            var val_16;
            var val_17;
            val_15 = 且丛丏丄丟丐丝三一;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_1 = this.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  丞一丁业丄一一业且);
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.且丅一一三七专丑丏() == true)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  val_15)) == false)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            val_15 = BalanceController.丞且且丂丐丌丛丕与.Item[val_15];
            if(val_4.ItemsIds == null)
            {
                    return;
            }
            
            if((val_4.ItemsIds.Contains(item:  丞一丁业丄一一业且)) == false)
            {
                    return;
            }
            
            val_15 = val_4.ItemsIds;
            List.Enumerator<T> val_6 = val_15.GetEnumerator();
            label_15:
            if(((-152698904) & 1) == 0)
            {
                goto label_16;
            }
            
            val_15 = this.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  0.丐丏七丌丕丗业且上());
            if(val_15 == null)
            {
                goto label_15;
            }
            
            if((System.String.op_Inequality(a:  val_15.业上丙丞丐丄丆丅七(), b:  丞一丁业丄一一业且)) != false)
            {
                    if(val_15.且丅一一三七专丑丏() == false)
            {
                goto label_17;
            }
            
            }
            
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_25;
            label_17:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_25:
            if((this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_1, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  丘专丑丕且且丄专丁)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_14 = this.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_1, 与且专丏丅世丐丐丑:  true, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
        }
        internal void 东专丘丑上且丟丒一(System.Collections.Generic.List<string> 世丅丈东丘丐丕丟丐)
        {
            var val_3;
            Rilisoft.LobbyCraftController val_12;
            List.Enumerator<T> val_1 = 世丅丈东丘丐丕丟丐.GetEnumerator();
            label_8:
            if(((-152517264) & 1) == 0)
            {
                goto label_2;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_6 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_3.丐丏七丌丕丗业且上());
            if(val_6 == null)
            {
                goto label_8;
            }
            
            if(val_6.丌七丌下丙三世丅一() == null)
            {
                goto label_5;
            }
            
            Rilisoft.LobbyItemPlayerInfo val_8 = val_6.丌七丌下丙三世丅一();
            if(val_8.IsCrafted == true)
            {
                goto label_7;
            }
            
            label_5:
            bool val_9 = this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_6, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
            label_7:
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_10 = this.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_6, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_12 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            if(val_12 == 0)
            {
                    return;
            }
            
            val_12 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            val_12.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  true, 丝一专专丏丝丘丒东:  true);
        }
        private void 丙且丈丞丅业东丏万(bool 丘专丑丕且且丄专丁 = True)
        {
            bool val_7 = 丘专丑丕且且丄专丁;
            if(this.万丙丕三万且万丟丟 == null)
            {
                    return;
            }
            
            if(this.万丙丕三万且万丟丟.Length < 1)
            {
                    return;
            }
            
            do
            {
                .丞丅上丏丂且下丅与 = this.万丙丕三万且万丟丟[0];
                val_7 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyItemsController.丗不上丛丟丙与丘丆(), method:  System.Boolean LobbyItemsController.丗不上丛丟丙与丘丆::丆上丛丐丅丁世与且(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
                if(val_7 != null)
            {
                    if(val_7.且丅一一三七专丑丏() != true)
            {
                    bool val_6 = this.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_7, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  val_7 = 丘专丑丕且且丄专丁);
            }
            
            }
            
            }
            while((0 + 1) < this.万丙丕三万且万丟丟.Length);
        
        }
        internal static System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> 丙东丆专三三丗丛丅()
        {
            Progress.丐丌丞丐丆丗三下丅 val_1 = Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂();
            if(val_1 != null)
            {
                    return val_1.东丌丁丅丞东七丂丗();
            }
            
            return val_1.东丌丁丅丞东七丂丗();
        }
        internal void 丁丞七丕丁丟东不丌(System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> 丅上丑丅与丄丏丑东, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, bool 丘专丑丕且且丄专丁 = True)
        {
            var val_6;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_7;
            val_6 = 丘专丑丕且且丄专丁;
            val_7 = 丅上丑丅与丄丏丑东;
            if(val_7 == null)
            {
                    return;
            }
            
            if(val_7.Count == 0)
            {
                    return;
            }
            
            if(val_6 != false)
            {
                    val_6 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_6.丛丈丒万丙丗七丐丗(丅丈上丒丄专业丂不:  val_7, 万丐丏丐丒万不丟三:  万丐丏丐丒万不丟三);
                return;
            }
            
            List.Enumerator<T> val_3 = val_7.GetEnumerator();
            val_6 = 1152921541138507840;
            label_12:
            if(((-152008200) & 1) == 0)
            {
                goto label_8;
            }
            
            Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂().丞丗不丆丙丘一不丙(丒丝三业丄丞丘业丆:  0.丐丏七丌丕丗业且上(), 丞不丌丘三丐丘东东:  true);
            goto label_12;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丙丟下丏丄且万丞三()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  9);
            this.不世丘东丂丟丗下丙(丘专丑丕且且丄专丁:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(this.丄丄丙丘丐一丌丁丄 == null)
            {
                    return;
            }
            
            this.丄丄丙丘丐一丌丁丄.Invoke();
        }
        internal bool 丞一丐丞丟丂下丄丅()
        {
            var val_3;
            var val_10;
            List.Enumerator<T> val_1 = this.丛不丞丂七丞世丁丏.GetEnumerator();
            label_10:
            if(((-151690000) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((((val_4.丝丞世丕丒下东丌丄() == true) || (val_4.丙丄丝丕丏世丏丛丑() == true)) || ((System.Linq.Enumerable.Contains<System.String>(source:  this.万丙丕三万且万丟丟, value:  val_4.业上丙丞丐丄丆丅七())) == true)) || (val_4.且丅一一三七专丑丏() == false))
            {
                goto label_10;
            }
            
            val_10 = 1;
            goto label_11;
            label_2:
            val_10 = 0;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_10;
        }
        internal static void 丞下丟丅丅丅与七丕(System.Action<丕专丟上与丄丈三丏.万东丙丛丅业丝世三, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕 != 1152921505469202536);
        
        }
        internal static void 丝下世丐丏丌丁不丄(System.Action<丕专丟上与丄丈三丏.万东丙丛丅业丝世三, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕 != 1152921505469202536);
        
        }
        internal static float 丒丈东丟丁七丏万下(丕专丟上与丄丈三丏.万东丙丛丅业丝世三 丏丟丌丙丏丏丒三丆)
        {
            Rilisoft.LobbyItemsController val_1 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if(val_1.丛与丙东不三丏业上 == null)
            {
                    return 0f;
            }
            
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((val_2.丛与丙东不三丏业上.ContainsKey(key:  丏丟丌丙丏丏丒三丆)) == false)
            {
                    return 0f;
            }
            
            Rilisoft.LobbyItemsController val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if(val_4.丛与丙东不三丏业上 != null)
            {
                    return val_4.丛与丙东不三丏业上.Item[丏丟丌丙丏丏丒三丆];
            }
            
            return val_4.丛与丙东不三丏业上.Item[丏丟丌丙丏丏丒三丆];
        }
        internal void 世丗丏丂丅丘且上丏()
        {
            var val_6;
            var val_15;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            this.丛与丙东不三丏业上 = new System.Collections.Generic.Dictionary<万东丙丛丅业丝世三, System.Single>(comparer:  Rilisoft.丐世丝丄上丒与丆业.丑七不且上丗丁一世());
            if(this.丘丝一丕丂七七七丂 == null)
            {
                goto label_3;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丘丝一丕丂七七七丂.GetEnumerator();
            val_28 = 0;
            val_29 = 0;
            var val_27 = 0;
            label_23:
            if(((-150944064) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            List.Enumerator<T> val_8 = val_7._value._obj.GetEnumerator();
            label_14:
            if(((-150944112) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_9 = val_6.丐丏七丌丕丗业且上();
            if(this.丘丝一丕丂七七七丂 == null)
            {
                goto label_14;
            }
            
            if(val_9 != null)
            {
                    if(as. 
                
              
             
            
             
              != 0)
            {
                    val_9.StopCoroutine(routine:  public Rilisoft.LobbyItemEffectHandler List.Enumerator<Rilisoft.LobbyItemEffectHandler>::get_Current());
            }
            
                mem2[0] = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  val_9);
            goto label_14;
            label_6:
            val_27 = val_27 + 1;
            mem2[0] = 126;
            val_30 = val_29;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_27 == 1) || ((1152921543110608416 + ((0 + 1)) << 2) != 126))
            {
                goto label_20;
            }
            
            var val_28 = 0;
            val_28 = val_28 ^ (val_27 >> 31);
            val_27 = val_27 + val_28;
            goto label_23;
            label_20:
            if( == 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_3:
            val_29 = 0;
            val_31 = 0;
            goto label_33;
            label_4:
            val_31 = val_27 + 1;
            mem2[0] = 151;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_27 != 1) && ((1152921543110608416 + ((0 + 1)) << 2) == 151))
            {
                    var val_29 = 0;
                val_29 = val_29 ^ (val_27 >> 31);
                val_31 = val_27 + val_29;
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            label_33:
            this.丘丝一丕丂七七七丂 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler>>();
            List.Enumerator<T> val_13 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丑七丆丄一三不下丁().GetEnumerator();
            label_44:
            if(((-150944144) & 1) == 0)
            {
                goto label_36;
            }
            
            string val_16 = val_15.丐丏七丌丕丗业且上();
            if(val_16.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万() == null)
            {
                goto label_44;
            }
            
            LobbyItemBuff[] val_20 = val_16.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万();
            if(val_20.Length == 0)
            {
                goto label_44;
            }
            
            this.丁丕专且丄丘丄东万(丑丘丕且丆东丏丘丙:  val_16);
            goto label_44;
            label_36:
            val_27 = val_27 + 1;
            mem2[0] = 252;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_27 == 1)
            {
                goto label_53;
            }
            
            if(( == 0) || ((1152921543110608416 + (((0 + 1) + 1)) << 2) == 252))
            {
                goto label_61;
            }
            
            label_60:
            label_61:
            Rilisoft.LobbyItemsController.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyItemsController::丟丞业丌丞丒东丄业(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)));
            Rilisoft.LobbyItemsController.东与丐东下丈七不丒(丙业与丙丗丝不丈东:  new System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyItemsController::丟丞业丌丞丒东丄业(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)));
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丐丑丙三万丒丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyItemsController::世丗丏丂丅丘且上丏()));
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛丁丞专七丛世三不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyItemsController::世丗丏丂丅丘且上丏()));
            return;
            label_53:
            if( != 0)
            {
                goto label_60;
            }
            
            goto label_61;
        }
        private void 丟丞业丌丞丒东丄业(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)
        {
            this.丅丘不下丆丆丝丂不(丑丘丕且丆东丏丘丙:  丌丏丗与丕丈丄三丈);
            this.丁丕专且丄丘丄东万(丑丘丕且丆东丏丘丙:  丏一丕东丙丆与丒丄);
        }
        private void 丁丕专且丄丘丄东万(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler>> val_12;
            System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler> val_13;
            var val_14;
            float val_15;
            float val_16;
            var val_17;
            if(丑丘丕且丆东丏丘丙 == null)
            {
                    return;
            }
            
            val_12 = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑();
            if(val_12.丞一下丐丟丏下丅万() == null)
            {
                    return;
            }
            
            val_12 = this.丘丝一丕丂七七七丂;
            if((val_12.ContainsKey(key:  丑丘丕且丆东丏丘丙.业上丙丞丐丄丆丅七())) != true)
            {
                    val_12 = this.丘丝一丕丂七七七丂;
                val_13 = this.不丆丌丟丞且不丟丟(丑丘丕且丆东丏丘丙:  丑丘丕且丆东丏丘丙);
                val_12.Add(key:  丑丘丕且丆东丏丘丙.业上丙丞丐丄丆丅七(), value:  val_13);
            }
            
            val_14 = 0;
            goto label_8;
            label_25:
            LobbyItemBuff val_12 = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            if((this.丛与丙东不三丏业上.ContainsKey(key:  val_8[0x0][0].BuffType)) != false)
            {
                    val_15 = this.丛与丙东不三丏业上.Item[val_8[0x0][0].BuffType];
                val_16 = val_15 + val_8[0x0][0].Value;
                this.丛与丙东不三丏业上.set_Item(key:  val_8[0x0][0].BuffType, value:  val_16);
            }
            else
            {
                    val_15 = val_8[0x0][0].Value;
                val_16 = val_15;
                this.丛与丙东不三丏业上.Add(key:  val_8[0x0][0].BuffType, value:  val_16);
            }
            
            val_17 = null;
            val_17 = null;
            val_12 = Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕;
            if(val_12 != null)
            {
                    val_12 = Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕;
                val_13 = this.丛与丙东不三丏业上;
                val_15 = val_13.Item[val_8[0x0][0].BuffType];
                val_12.Invoke(arg1:  val_8[0x0][0].BuffType, arg2:  val_15);
            }
            
            val_14 = 1;
            label_8:
            if(val_14 < val_8.Length)
            {
                goto label_25;
            }
        
        }
        private void 丅丘不下丆丆丝丂不(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            var val_9;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler>> val_19;
            System.Collections.Generic.Dictionary<万东丙丛丅业丝世三, System.Single> val_20;
            var val_21;
            float val_22;
            var val_23;
            if(丑丘丕且丆东丏丘丙 == null)
            {
                    return;
            }
            
            val_19 = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑();
            if(val_19.丞一下丐丟丏下丅万() == null)
            {
                    return;
            }
            
            val_19 = this.丘丝一丕丂七七七丂;
            if((val_19.ContainsKey(key:  丑丘丕且丆东丏丘丙.业上丙丞丐丄丆丅七())) == false)
            {
                goto label_5;
            }
            
            List.Enumerator<T> val_7 = this.丘丝一丕丂七七七丂.Item[丑丘丕且丆东丏丘丙.业上丙丞丐丄丆丅七()].GetEnumerator();
            val_20 = 1152921543110455408;
            label_10:
            if(((-150015168) & 1) == 0)
            {
                goto label_8;
            }
            
            if(val_9.丐丏七丌丕丗业且上() != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_19 = this.丘丝一丕丂七七七丂;
            bool val_12 = val_19.Remove(key:  丑丘丕且丆东丏丘丙.业上丙丞丐丄丆丅七());
            label_5:
            val_21 = 0;
            goto label_17;
            label_32:
            LobbyItemBuff val_18 = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            val_19 = this.丛与丙东不三丏业上;
            if((val_19.ContainsKey(key:  val_14[0x0][0].BuffType)) != false)
            {
                    float val_16 = this.丛与丙东不三丏业上.Item[val_14[0x0][0].BuffType];
                val_22 = val_16;
                val_16 = val_22 - val_14[0x0][0].Value;
                this.丛与丙东不三丏业上.set_Item(key:  val_14[0x0][0].BuffType, value:  val_16);
                val_23 = null;
                val_23 = null;
                val_19 = Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕;
                if(val_19 != null)
            {
                    val_19 = Rilisoft.LobbyItemsController.丄丂丞丒丝业世不丕;
                val_20 = this.丛与丙东不三丏业上;
                val_22 = val_20.Item[val_14[0x0][0].BuffType];
                val_19.Invoke(arg1:  val_14[0x0][0].BuffType, arg2:  val_22);
            }
            
            }
            
            val_21 = 1;
            label_17:
            if(val_21 < val_14.Length)
            {
                goto label_32;
            }
        
        }
        private System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler> 不丆丌丟丞且不丟丟(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler> val_1 = new System.Collections.Generic.List<Rilisoft.LobbyItemEffectHandler>();
            if(丑丘丕且丆东丏丘丙 == null)
            {
                    return val_1;
            }
            
            if(丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万() == null)
            {
                    return val_1;
            }
            
            val_11 = 0;
            goto label_5;
            label_23:
            LobbyItemBuff val_11 = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            if(val_5[0x0][0].BuffType == 12)
            {
                goto label_8;
            }
            
            if(val_5[0x0][0].BuffType == 6)
            {
                goto label_9;
            }
            
            if(val_5[0x0][0].BuffType != 4)
            {
                goto label_10;
            }
            
            UnityEngine.GameObject val_6 = this.gameObject;
            val_12 = 1152921543111878256;
            goto label_14;
            label_8:
            UnityEngine.GameObject val_7 = this.gameObject;
            val_12 = 1152921543111895664;
            goto label_14;
            label_9:
            UnityEngine.GameObject val_8 = this.gameObject;
            val_12 = 1152921543111877232;
            label_14:
            val_13 = 0.AddComponent<Rilisoft.LobbyItemEffectFreeSpins>();
            goto label_16;
            label_10:
            val_13 = 0;
            label_16:
            if(val_13 != 0)
            {
                    val_13.Initialize(丑丘丕且丆东丏丘丙:  丑丘丕且丆东丏丘丙);
                val_1.Add(item:  val_13);
            }
            
            val_11 = 1;
            label_5:
            if(val_11 < val_5.Length)
            {
                goto label_23;
            }
            
            return val_1;
        }
        public LobbyItemsController()
        {
            string[] val_1 = new string[2];
            val_1[0] = "terrain_christmas_1";
            val_1[1] = "skybox_18";
            this.万丙丕三万且万丟丟 = val_1;
            this.Bundles = new System.Collections.Generic.List<Rilisoft.LobbyItemsBundle>();
            this.丟丆丐丛丈丛专上丄 = "lobby-item-clover-migraded";
        }
        private static LobbyItemsController()
        {
            null = null;
            Rilisoft.LobbyItemsController.三业七丛世下三丛世 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyItemsController.<>c.<>9, method:  System.Boolean LobbyItemsController.<>c::东丗丕下且丗丝丘与(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            System.Collections.Generic.List<Rilisoft.LobbyItemGroupType> val_2 = new System.Collections.Generic.List<Rilisoft.LobbyItemGroupType>();
            if(val_2 != null)
            {
                    val_2.Add(item:  200);
            }
            else
            {
                    val_2.Add(item:  200);
            }
            
            val_2.Add(item:  204);
            Rilisoft.LobbyItemsController.一丑不丐丌丁一上丒 = val_2;
            System.Collections.Generic.List<Rilisoft.下丟丑丁且专且三丘> val_3 = new System.Collections.Generic.List<Rilisoft.下丟丑丁且专且三丘>();
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  100, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            System.Collections.Generic.List<LobbyItemSlot> val_5 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_5.Add(item:  0);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  101, 下丟丕丛不丈一业三:  val_5, 丁丈东世丗丙丅丌丂:  100));
            System.Collections.Generic.List<LobbyItemSlot> val_7 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_7.Add(item:  2);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  102, 下丟丕丛不丈一业三:  val_7, 丁丈东世丗丙丅丌丂:  100));
            System.Collections.Generic.List<LobbyItemSlot> val_9 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_9.Add(item:  1);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  103, 下丟丕丛不丈一业三:  val_9, 丁丈东世丗丙丅丌丂:  100));
            System.Collections.Generic.List<LobbyItemSlot> val_11 = new System.Collections.Generic.List<LobbyItemSlot>();
            if(val_11 != null)
            {
                    val_11.Add(item:  10);
            }
            else
            {
                    val_11.Add(item:  10);
            }
            
            val_11.Add(item:  11);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  244, 下丟丕丛不丈一业三:  val_11, 丁丈东世丗丙丅丌丂:  100));
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  200, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            System.Collections.Generic.List<LobbyItemSlot> val_14 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_14.Add(item:  4);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  201, 下丟丕丛不丈一业三:  val_14, 丁丈东世丗丙丅丌丂:  200));
            System.Collections.Generic.List<LobbyItemSlot> val_16 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_16.Add(item:  5);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  202, 下丟丕丛不丈一业三:  val_16, 丁丈东世丗丙丅丌丂:  200));
            System.Collections.Generic.List<LobbyItemSlot> val_18 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_18.Add(item:  6);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  203, 下丟丕丛不丈一业三:  val_18, 丁丈东世丗丙丅丌丂:  200));
            System.Collections.Generic.List<LobbyItemSlot> val_20 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_20.Add(item:  7);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  204, 下丟丕丛不丈一业三:  val_20, 丁丈东世丗丙丅丌丂:  200));
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  44, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            System.Collections.Generic.List<LobbyItemSlot> val_23 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_23.Add(item:  8);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  46, 下丟丕丛不丈一业三:  val_23, 丁丈东世丗丙丅丌丂:  44));
            System.Collections.Generic.List<LobbyItemSlot> val_25 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_25.Add(item:  9);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  45, 下丟丕丛不丈一业三:  val_25, 丁丈东世丗丙丅丌丂:  44));
            System.Collections.Generic.List<LobbyItemSlot> val_27 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_27.Add(item:  12);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  47, 下丟丕丛不丈一业三:  val_27, 丁丈东世丗丙丅丌丂:  44));
            System.Collections.Generic.List<LobbyItemSlot> val_29 = new System.Collections.Generic.List<LobbyItemSlot>();
            val_29.Add(item:  3);
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  144, 下丟丕丛不丈一业三:  val_29, 丁丈东世丗丙丅丌丂:  0));
            val_3.Add(item:  new Rilisoft.下丟丑丁且专且三丘(一丐丅且丛不不丌丗:  88, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            Rilisoft.LobbyItemsController.丅业丟丝丝丘万上丄 = val_3;
            System.Collections.Generic.Dictionary<LobbyItemSlot, System.String> val_32 = new System.Collections.Generic.Dictionary<LobbyItemSlot, System.String>();
            if(val_32 != null)
            {
                    val_32.Add(key:  12, value:  "skybox_1");
            }
            else
            {
                    val_32.Add(key:  12, value:  "skybox_1");
            }
            
            val_32.Add(key:  9, value:  "background_2_military_1");
            if(val_32 != null)
            {
                    val_32.Add(key:  4, value:  "terrain_military_1");
            }
            else
            {
                    val_32.Add(key:  4, value:  "terrain_military_1");
            }
            
            val_32.Add(key:  5, value:  "road_military_1");
            if(val_32 != null)
            {
                    val_32.Add(key:  0, value:  "base_military_1");
            }
            else
            {
                    val_32.Add(key:  0, value:  "base_military_1");
            }
            
            val_32.Add(key:  1, value:  "wall_military_1");
            val_32.Add(key:  2, value:  "gate_military_1");
            Rilisoft.LobbyItemsController.三丏丄丁丘丆不丈丐 = val_32;
            System.Collections.Generic.List<LobbyItemSlot> val_33 = new System.Collections.Generic.List<LobbyItemSlot>();
            if(val_33 != null)
            {
                    val_33.Add(item:  12);
                val_33.Add(item:  4);
                val_33.Add(item:  5);
                val_33.Add(item:  0);
            }
            else
            {
                    val_33.Add(item:  12);
                val_33.Add(item:  4);
                val_33.Add(item:  5);
                val_33.Add(item:  0);
            }
            
            val_33.Add(item:  9);
            Rilisoft.LobbyItemsController.丘七一丘东与三世万 = val_33;
            Rilisoft.LobbyItemsController.丂丏丁下七丌七丆丅 = true;
        }
    
    }

}
