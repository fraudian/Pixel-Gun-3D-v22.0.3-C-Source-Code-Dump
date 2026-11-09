using UnityEngine;

namespace PGCompany.GameModeEvents
{
    internal class 丈专丂丁丁东丌丁丅
    {
        // Fields
        private const string 世丞丝不丂丕且且丆 = "GME.ConfigStoragerKey";
        private static PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 丝业丆丁业三丈丟东;
        private static System.Action 丂丌业丏丙万丙业业;
        private UnityEngine.Coroutine 丐丝丝下下丁丙丄专;
        private static bool <丗七丂丅丞一丑一丁>k__BackingField;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 丏丆且丟丈丞一专不;
        private System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丝世丄丟丑业专丟与;
        private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 世丒丑专丕与下丂东;
        private Rilisoft.不丅且丝丁丁与不丒<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardConditionProgressContainer> 专丟丆三丆不丒与丈;
        private Rilisoft.不丅且丝丁丁与不丒<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEPlayerState> 业上丄丘丝不丕丘丐;
        private Rilisoft.不丅且丝丁丁与不丒<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.SavedParamsContainer> 丐丌丂丟丟丕丙丟丘;
        
        // Properties
        internal static PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 丆丕丝丒不丙且丐丗 { get; }
        internal static bool 三与丙上丆丐丄丐丏 { get; set; }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 上丁三万东世丂丅丙 { get; }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丑丗丝专上丛丕丝丏 { get; }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 万业不丌丞丞丂一与 { get; set; }
        
        // Methods
        internal static PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 丑七不且上丗丁一世()
        {
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅();
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal static void 丐丐且下丁丄丒专丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丂丌业丏丙万丙业业, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丂丌业丏丙万丙业业 != 1152921505658978312);
        
        }
        internal static void 上丗丌丌上不丛丌专(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丂丌业丏丙万丙业业, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丂丌业丏丙万丙业业 != 1152921505658978312);
        
        }
        private 丈专丂丁丁东丌丁丅()
        {
            System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_13;
            this.丏丆且丟丈丞一专不 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>();
            this.丝世丄丟丑业专丟与 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
            this.专丟丆三丆不丒与丈 = new Rilisoft.不丅且丝丁丁与不丒<GMERewardConditionProgressContainer>(丟东丟丑丕丄丂丟丙:  "GME-_savedRewardsProgresses");
            this.业上丄丘丝不丕丘丐 = new Rilisoft.不丅且丝丁丁与不丒<GMEPlayerState>(丟东丟丑丕丄丂丟丙:  "gme-player");
            this.丐丌丂丟丟丕丙丟丘 = new Rilisoft.不丅且丝丁丁与不丒<SavedParamsContainer>(丟东丟丑丕丄丂丟丙:  "GME-_lastSavedParameters");
            丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
            if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
            {
                    this.丗专丟丂东丝七丈丝();
            }
            
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅::丗专丟丂东丝七丈丝()));
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            if(((System.Delegate.Combine(a:  PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且, b:  new System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  this, method:  System.Void PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅::丟丌万一一丛丑下一(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, bool 东丅丞丁丗万且丁丗)))) != null) && (null != null))
            {
                    val_13 = 0;
            }
            
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且 = val_13;
        }
        internal static bool 世丄七东丈一七丆丌()
        {
            return (bool)PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.<丗七丂丅丞一丑一丁>k__BackingField;
        }
        private static void 丈丄丁丗且丒丝七万(bool 丙业与丙丗丝不丈东)
        {
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.<丗七丂丅丞一丑一丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void 丗专丟丂东丝七丈丝()
        {
            this.丌丐丅丄且丛丟上世(丈丄丈世一且不不丁:  4);
            this.丌丐丅丄且丛丟上世(丈丄丈世一且不不丁:  125);
            this.丌丐丅丄且丛丟上世(丈丄丈世一且不不丁:  126);
        }
        private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 4)
            {
                    if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 125)
            {
                    if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 126)
            {
                    return;
            }
            
            }
            
            }
            
            this.丌丐丅丄且丛丟上世(丈丄丈世一且不不丁:  丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝());
        }
        private void 丌丐丅丄且丛丟上世(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            UnityEngine.Coroutine val_2 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.不一丘丅且丆不七上(丈丄丈世一且不不丁:  丈丄丈世一且不不丁));
        }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丙丄丏丆万丐丅丌丂()
        {
            return (System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>)this.丝世丄丟丑业专丟与;
        }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丞七丐与下丈一丞丙()
        {
            var val_3;
            System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丈专丂丁丁东丌丁丅.<>c.<>9__20_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丝世丄丟丑业专丟与, predicate:  System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  丈专丂丁丁东丌丁丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丈专丂丁丁东丌丁丅.<>c::丁一与不丙丂丁丂丒(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且));
            丈专丂丁丁东丌丁丅.<>c.<>9__20_0 = val_5;
            return System.Linq.Enumerable.ToList<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丝世丄丟丑业专丟与, predicate:  val_1));
        }
        internal bool 专丕丄三丑丙万世不(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, string 丞丁丑丏丄丏七丂不)
        {
            string val_7;
            var val_8;
            丈专丂丁丁东丌丁丅.丌丐丝丐下上三丛丌 val_1 = new 丈专丂丁丁东丌丁丅.丌丐丝丐下上三丛丌();
            if(val_1 != null)
            {
                    .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            }
            else
            {
                    mem[16] = 丂丛丑东不丅丈一东;
            }
            
            .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丝世丄丟丑业专丟与, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丌丐丝丐下上三丛丌::丏丌丝丒丒下丝万丕(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            val_7 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(丑东与丅丐丅丂丞业:  val_3)) != false)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            val_7 = (丈专丂丁丁东丌丁丅.丌丐丝丐下上三丛丌)[1152921559673096720].丞丁丑丏丄丏七丂不;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == false)
            {
                    return System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_3, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丌丐丝丐下上三丛丌::万丗丑东上且丅业且(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗世丑丄丈业与上丌(int 丞丅上丏丂且下丅与)
        {
            var val_6;
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丝世丄丟丑业专丟与, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  new 丈专丂丁丁东丌丁丅.上三且上丁业与与丑(), method:  System.Boolean 丈专丂丁丁东丌丁丅.上三且上丁业与与丑::丆万且丝丁不丁丛丕(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(丑东与丅丐丅丂丞业:  val_3)) == false)
            {
                    return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_3);
            }
            
            val_6 = 0;
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_3);
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丘一一丛丏丕下丟丛(int 丞丅上丏丂且下丅与)
        {
            var val_7;
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丞七丐与下丈一丞丙(), predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  new 丈专丂丁丁东丌丁丅.丛东丟丅丙丗世丗不(), method:  System.Boolean 丈专丂丁丁东丌丁丅.丛东丟丅丙丗世丗不::不世丁丘且七丌丘七(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(丑东与丅丐丅丂丞业:  val_4)) == false)
            {
                    return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_4);
            }
            
            val_7 = 0;
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_4);
        }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丙丗丑世丄丁丏丈业()
        {
            return this.丞七丐与下丈一丞丙();
        }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丐世三三丕丅上丝专(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, string 丞丁丑丏丄丏七丂不)
        {
            丈专丂丁丁东丌丁丅.丒丂万丒丂一上丞一 val_1 = new 丈专丂丁丁东丌丁丅.丒丂万丒丂一上丞一();
            if(val_1 != null)
            {
                    .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            }
            else
            {
                    mem[16] = 丂丛丑东不丅丈一东;
            }
            
            .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丞七丐与下丈一丞丙(), predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丒丂万丒丂一上丞一::七世丌丏且丌丞丝丈(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (丈专丂丁丁东丌丁丅.丒丂万丒丂一上丞一)[1152921559673697296].丞丁丑丏丄丏七丂不)) == false)
            {
                    return System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_4, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丒丂万丒丂一上丞一::丄丘专丒丏丑丙丘丘(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            }
            
            return (System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>)val_4;
        }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 下专丆丁丕丗东不丗(string 丞丁丑丏丄丏七丂不)
        {
            var val_7;
            System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_9;
            .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
            val_7 = null;
            val_7 = null;
            val_9 = 丈专丂丁丁东丌丁丅.<>c.<>9__27_0;
            if(val_9 == null)
            {
                    System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_3 = null;
                val_9 = val_3;
                val_3 = new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  丈专丂丁丁东丌丁丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丈专丂丁丁东丌丁丅.<>c::丕丑七丗与丏丘世三(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且));
                丈专丂丁丁东丌丁丅.<>c.<>9__27_0 = val_9;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丞七丐与下丈一丞丙(), predicate:  val_3);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (丈专丂丁丁东丌丁丅.丘丞三且东万丕丙丂)[1152921559673868688].丞丁丑丏丄丏七丂不)) == false)
            {
                    return System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_4, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  new 丈专丂丁丁东丌丁丅.丘丞三且东万丕丙丂(), method:  System.Boolean 丈专丂丁丁东丌丁丅.丘丞三且东万丕丙丂::丏世丛丌丛丄一丙丕(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            }
            
            return (System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>)val_4;
        }
        internal System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丑不七不万丙丆七东(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, string 丞丁丑丏丄丏七丂不)
        {
            丈专丂丁丁东丌丁丅.丐丐七丈丅丐三且丆 val_1 = new 丈专丂丁丁东丌丁丅.丐丐七丈丅丐三且丆();
            if(val_1 != null)
            {
                    .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            }
            else
            {
                    mem[16] = 丂丛丑东不丅丈一东;
            }
            
            .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  this.丞七丐与下丈一丞丙(), predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丐丐七丈丅丐三且丆::丒业七专不七丈丞下(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (丈专丂丁丁东丌丁丅.丐丐七丈丅丐三且丆)[1152921559674048272].丞丁丑丏丄丏七丂不)) == false)
            {
                    return System.Linq.Enumerable.Where<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_4, predicate:  new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  val_1, method:  System.Boolean 丈专丂丁丁东丌丁丅.丐丐七丈丅丐三且丆::下且一丕下且丒丏丘(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丗丛不丁丑专专丂且)));
            }
            
            return (System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>)val_4;
        }
        internal bool 业七丟丕东七丕专下()
        {
            var val_7;
            List.Enumerator<T> val_1 = this.丝世丄丟丑业专丟与.GetEnumerator();
            label_7:
            if(((-767272888) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(((-767272856) & 1) == 0)
            {
                goto label_7;
            }
            
            var val_4 = (val_2.m_firstChar.丙东专丂世丈丏丁丂() == 2) ? 1 : 0;
            val_4 = val_4 & ;
            if((((val_4 & 1) == 0) || (val_2.七丂丌丈丄专丄三世() == false)) || (val_2.丐万且七专丒七丛丞() == false))
            {
                goto label_7;
            }
            
            val_7 = 1;
            goto label_8;
            label_2:
            val_7 = 0;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_7;
        }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丅丒丐七丒且丂专丒()
        {
            System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_1 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
            List.Enumerator<T> val_2 = this.丝世丄丟丑业专丟与.GetEnumerator();
            label_7:
            if(((-767140424) & 1) == 0)
            {
                goto label_2;
            }
            
            if(((-767140392) & 1) == 0)
            {
                goto label_7;
            }
            
            var val_5 = (val_3.m_firstChar.丙东专丂世丈丏丁丂() == 2) ? 1 : 0;
            val_5 = val_5 & ;
            if((val_5 & 1) == 0)
            {
                goto label_7;
            }
            
            val_1.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private int 一丆世丛丏丄三丆业(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丒丒丄丁且丄丆丂丌)
        {
            ulong val_8;
            ulong val_9;
            var val_10;
            val_9 = 丒丒丄丁且丄丆丂丌;
            if(三丟东丕丄丄下下丑.七丂丌丈丄专丄三世() == false)
            {
                goto label_2;
            }
            
            label_27:
            val_10 = 0;
            return (int)val_10;
            label_2:
            if(val_9.七丂丌丈丄专丄三世() == false)
            {
                goto label_5;
            }
            
            label_33:
            val_10 = 1;
            return (int)val_10;
            label_5:
            System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-767007904) & 1) == 0)
            {
                goto label_11;
            }
            
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            val_8 = ;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {})) == true)
            {
                goto label_33;
            }
            
            label_11:
            if(((-767007904) & 1) == 0)
            {
                goto label_17;
            }
            
            if(( & 1) == 0)
            {
                goto label_17;
            }
            
            val_8 = ;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {})) == true)
            {
                goto label_27;
            }
            
            label_17:
            if(( & 1) == 0)
            {
                goto label_24;
            }
            
            if(( & 1) == 0)
            {
                goto label_24;
            }
            
            val_8 = ;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {})) == true)
            {
                goto label_27;
            }
            
            label_24:
            if(( & 1) == 0)
            {
                goto label_30;
            }
            
            if(( & 1) == 0)
            {
                goto label_30;
            }
            
            val_8 = 1152921516746598144;
            val_9 = ;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {}, t2:  new System.DateTime() {dateData = val_9})) == true)
            {
                goto label_33;
            }
            
            label_30:
            val_10 = 0;
            return (int)val_10;
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 一丝丈丈三一丒丒丅()
        {
            var val_4;
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_13;
            System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_14;
            System.Collections.Generic.List<T> val_15;
            var val_16;
            val_13 = this;
            System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_1 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
            val_14 = this.丝世丄丟丑业专丟与;
            List.Enumerator<T> val_2 = val_14.GetEnumerator();
            label_14:
            if(((-766864208) & 1) == 0)
            {
                goto label_2;
            }
            
            if(((-766864216) & 1) == 0)
            {
                goto label_14;
            }
            
            var val_7 = (val_5.m_firstChar.丙东专丂世丈丏丁丂() == 5) ? 1 : 0;
            val_7 = val_7 & 1152921559674557600;
            if((val_7 & 1) == 0)
            {
                goto label_14;
            }
            
            System.Nullable<System.DateTime> val_8 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-766864256) & 1) == 0)
            {
                goto label_8;
            }
            
            if(((-766864240) & 1) == 0)
            {
                goto label_14;
            }
            
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {}, t2:  new System.DateTime() {})) == false)
            {
                goto label_14;
            }
            
            label_8:
            val_1.Add(item:  val_4.丐丏七丌丕丗业且上());
            goto label_14;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_15 = val_1;
            if(val_1.Count == 0)
            {
                goto label_29;
            }
            
            System.Comparison<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_11 = null;
            val_14 = val_11;
            val_11 = new System.Comparison<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(object:  this, method:  System.Int32 PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅::一丆世丛丏丄三丆业(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丒丒丄丁且丄丆丂丌));
            if( == 0)
            {
                goto label_30;
            }
            
            val_1.Sort(comparison:  val_11);
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)val_1.Item[0];
            label_29:
            val_16 = 0;
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)val_1.Item[0];
            label_30:
            val_1.Sort(comparison:  val_11);
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)val_1.Item[0];
        }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 丏丛丏丁专丏丞丘业()
        {
            var val_4;
            System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_1 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
            List.Enumerator<T> val_2 = this.丝世丄丟丑业专丟与.GetEnumerator();
            label_9:
            if(((-766719440) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(((-766719400) & 1) == 0)
            {
                goto label_9;
            }
            
            var val_7 = (val_5.m_firstChar.丙东专丂世丈丏丁丂() == 2) ? 1 : 0;
            val_7 = val_7 & 1152921559674702376;
            if((((val_7 & 1) == 0) || (val_5.七丂丌丈丄专丄三世() == false)) || (val_5.丐万且七专丒七丛丞() == false))
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_5);
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丒丈世万业丌丌丅专(string 下丅丙一丂丗丅丝七)
        {
            goto label_1;
            label_12:
            if(this.丝世丄丟丑业专丟与.Item[0].七丂丌丈丄专丄三世() != false)
            {
                    if(this.丝世丄丟丑业专丟与.Item[0].丐万且七专丒七丛丞() != false)
            {
                    if((this.丝世丄丟丑业专丟与.Item[0].万七上丁丑丞业丑丛(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_10;
            }
            
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_12;
            }
            
            return 0;
            label_10:
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_8 = this.丝世丄丟丑业专丟与.Item[0];
            return 0;
        }
        private System.Collections.IEnumerator 不一丘丅且丆不七上(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            丈专丂丁丁东丌丁丅.三丁上三业且不万世 val_1 = new 丈专丂丁丁东丌丁丅.三丁上三业且不万世();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈丄丈世一且不不丁 = 丈丄丈世一且不不丁;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丟丌万一一丛丑下一(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, bool 东丅丞丁丗万且丁丗)
        {
            PGCompany.ConfigId val_2;
            if(((-766268680) & 1) == 0)
            {
                    return;
            }
            
            if(东丅丞丁丗万且丁丗 == true)
            {
                    return;
            }
            
            if(( & 1) == 0)
            {
                goto label_6;
            }
            
            int val_1 = 与不下三丈专丘丂世.<丌七丏上丞且世世丁>k__BackingField.丙东专丂世丈丏丁丂();
            if(val_1 == 5)
            {
                goto label_5;
            }
            
            if(val_1 != 4)
            {
                goto label_6;
            }
            
            val_2 = 125;
            goto label_8;
            label_6:
            val_2 = 4;
            goto label_8;
            label_5:
            val_2 = 126;
            label_8:
            this.丌丐丅丄且丛丟上世(丈丄丈世一且不不丁:  val_2);
        }
        private void 不丄丞丏丕与与丆一()
        {
            var val_12;
            var val_15;
            var val_17;
            var val_18;
            if(this.丐丌丂丟丟丕丙丟丘 == null)
            {
                    .EventsIds = new System.Collections.Generic.List<System.Int32>();
                val_12 = new 丈专丂丁丁东丌丁丅.SavedParamsContainer();
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = System.Linq.Enumerable.Where<System.Int32>(source:  this.丐丌丂丟丟丕丙丟丘, predicate:  new System.Func<System.Int32, System.Boolean>(object:  this, method:  System.Boolean PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅::丐万丁万上下丆丄丑(int 丞丅上丏丂且下丅与))).GetEnumerator();
            label_25:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            PGCompany.东丂七丁上世丈丁丏.丗丏东丟世丅丏一丈(专专三丒丛丁且七丛:  System.String.Format(format:  "gme-img-{0}", arg0:  val_6.Current), 七丙不丅丛丘丗万与:  0, 业丒丒专丞丒丘丌丗:  0);
            goto label_25;
            label_17:
            val_17 = 0;
            val_18 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_15 = public System.Void System.IDisposable::Dispose();
                val_6.Dispose();
            }
            
            if(( == 1) && ( != false))
            {
                    val_15 = 0;
            }
            
            mem2[0] = System.Linq.Enumerable.ToList<System.Int32>(source:  this.丏丆且丟丈丞一专不.Keys);
            this.丐丌丂丟丟丕丙丟丘.丂且不业丂专丛丆东();
        }
        internal static void 丕丁丕丆世丆丌一丂(System.Collections.Generic.Dictionary<string, object> 丞世丏业且世丝丐丈, System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> 与世丗且丟丁不专丏, int 丟丟丄专上丟丁丐丝, ref System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> 上业丟世三与七七三, ref System.Collections.Generic.List<PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七> 丛丂东一丕丙三上与)
        {
            var val_20;
            string val_28;
            var val_29;
            PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七 val_30;
            var val_31;
            int val_32;
            string val_33;
            var val_34;
            var val_35;
            PGCompany.GameModeEvents.丆不丞丗不丏丞丕丗 val_36;
            PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七 val_37;
            val_29 = 1152921559675623088;
            if(丞世丏业且世丝丐丈 == null)
            {
                    return;
            }
            
            val_30 = "type";
            object val_1 = 丞世丏业且世丝丐丈.Item["type"];
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_28 = 0;
            }
            
            val_31 = 1152921516630043280;
            if((丞世丏业且世丝丐丈.ContainsKey(key:  "type")) == false)
            {
                    return;
            }
            
            if((丞世丏业且世丝丐丈.ContainsKey(key:  "range")) == false)
            {
                goto label_5;
            }
            
            object val_5 = 丞世丏业且世丝丐丈.Item["range"];
            val_32 = 丟丟丄专上丟丁丐丝;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            var val_6 = (null == null) ? (val_5) : 0;
            goto label_7;
            label_5:
            val_32 = 丟丟丄专上丟丁丐丝;
            val_34 = 1152921559675619040;
            val_35 = val_29;
            val_36 = 0;
            goto label_11;
            label_6:
            val_33 = 0;
            label_7:
            val_34 = 1152921559675619040;
            val_35 = val_29;
            val_36 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_33)) != true)
            {
                    val_36 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丝三且三丛丏丗丕万(下丈丌三且三丝丄与:  val_33, 丌下丏丐丕丏不丗一:  val_28);
            }
            
            label_11:
            if((丞世丏业且世丝丐丈.ContainsKey(key:  "once")) != false)
            {
                    object val_10 = 丞世丏业且世丝丐丈.Item["once"];
                if(val_10 != null)
            {
                    var val_11 = (null == null) ? (val_10) : 0;
            }
            
            }
            
            val_30 = "value";
            val_28 = val_28;
            val_29 = val_35;
            if((丞世丏业且世丝丐丈.ContainsKey(key:  "value")) == false)
            {
                    return;
            }
            
            if(丞世丏业且世丝丐丈.Item["value"] == null)
            {
                    return;
            }
            
            val_31 = 与世丗且丟丁不专丏.HasValue.丙东专丂世丈丏丁丂();
            if((val_31 != 2) || (((-765850984) & 1) == 0))
            {
                goto label_20;
            }
            
            object val_15 = 丞世丏业且世丝丐丈.Item["value"];
            if(val_15 == null)
            {
                    return;
            }
            
            if(val_36 == 0)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七 val_17 = null;
            val_30 = val_17;
            val_17 = new PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七(三万专七专丞且丒丝:  val_8 + 16, 专丈专丘世专业业一:  val_8 + 16 + 4);
            if(val_30 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_18 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0.GetEnumerator();
            label_39:
            if(((-765851008) & 1) == 0)
            {
                goto label_26;
            }
            
            string val_21 = val_20.丐丏七丌丕丗业且上();
            if(val_21 == null)
            {
                goto label_39;
            }
            
            PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 val_22 = PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗.东丝七业丄丑丒世七(丟丟丄专上丟丁丐丝:  val_32, 丟七万丆丆丞上丟三:  val_28, 丆丐丗丙丂三丄丟万:  0, 且丛七丈一东丑丑丆:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = true}, 丈丕三丆丟且丆一上:  val_21);
            if(val_22 == null)
            {
                goto label_39;
            }
            
            var val_24 = (与世丗且丟丁不专丏.HasValue.丙东专丂世丈丏丁丂() == 2) ? 1 : 0;
            val_24 = val_24 & 1152921559675570840;
            if(((val_24 & 1) == 0) || ((val_22.<且丈丁专东丆丄丂与>k__BackingField) != 8))
            {
                goto label_34;
            }
            
            if(val_22.丂丑丞丝且万丐万丟() == null)
            {
                goto label_39;
            }
            
            val_17.丈丘丙三丑世业世世(丄丄七丞丙丞丗一丟:  val_22);
            goto label_39;
            label_34:
            if(上业丟世三与七七三 == null)
            {
                goto label_39;
            }
            
            (上业丟世三与七七三 == 0) ? 0 : 上业丟世三与七七三.Add(item:  val_22);
            goto label_39;
            label_20:
            PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 val_27 = PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  丞世丏业且世丝丐丈, 丟丟丄专上丟丁丐丝:  val_32, 且丛七丈一东丑丑丆:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = 与世丗且丟丁不专丏.HasValue});
            if(val_27 == null)
            {
                    return;
            }
            
            if(上业丟世三与七七三 == null)
            {
                    return;
            }
            
            label_54:
            上业丟世三与七七三.Add(item:  val_27);
            return;
            label_26:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_37 = val_30;
            if(丛丂东一丕丙三上与 == null)
            {
                    return;
            }
            
            goto label_54;
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丆丌上丄丁万丞丈()
        {
            return (PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒)this.世丒丑专丕与下丂东;
        }
        internal void 丐丌与丌丁丛丞不丝(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丙业与丙丗丝不丈东)
        {
            this.世丒丑专丕与下丂东 = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions> 丄丝丆与丂与丏丕丒()
        {
            var val_2;
            if((this.专丟丆三丆不丒与丈 != null) && (null != null))
            {
                    if(this.专丟丆三丆不丒与丈 != null)
            {
                    return (System.Collections.Generic.List<GMERewardSavedConditions>)val_2;
            }
            
                return (System.Collections.Generic.List<GMERewardSavedConditions>)val_2;
            }
            
            System.Collections.Generic.List<GMERewardSavedConditions> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<GMERewardSavedConditions>();
            return (System.Collections.Generic.List<GMERewardSavedConditions>)val_2;
        }
        private PGCompany.GameModeEvents.GMERewardConditionProgress 东丘三丝业一丏且且(int 丟丟丄专上丟丁丐丝)
        {
            PGCompany.GameModeEvents.GMERewardConditionProgress val_6;
            .丟丟丄专上丟丁丐丝 = 丟丟丄专上丟丁丐丝;
            if((System.Linq.Enumerable.FirstOrDefault<GMERewardSavedConditions>(source:  Progress.七七世万专丕丁上业.一丛丂且且丕丆不丐().丛丟丞丛丁东丙与丈(), predicate:  new System.Func<GMERewardSavedConditions, System.Boolean>(object:  new 丈专丂丁丁东丌丁丅.丅三丈世丝丑专丂世(), method:  System.Boolean 丈专丂丁丁东丌丁丅.丅三丈世丝丑专丂世::丑与一专丈上丝丞丄(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 丁丂专业丁丅丅丈丙)))) == null)
            {
                    return val_6;
            }
            
            val_6 = val_5.Progress;
            return val_6;
        }
        private void 丞丗丟丙东丏丒丅且()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丆丐丗三且丗丙万丂(一丝与丆丛业且世丌:  this.一世一丝东七丙丁丆(), 且且万丅丏与丟丑丗:  this.业不且丟丝上丕万七(), 丝丒丘专与丝丞丂且:  this.世下与下专丛七丁专());
        }
        internal bool 丅上丗丂丕丟丟与丝(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
        {
            var val_13;
            var val_14;
            var val_21;
            if(丐且丘丑与万丞丑丅 == null)
            {
                goto label_11;
            }
            
            val_21 = 0;
            if((丐且丘丑与万丞丑丅.<丌七丏上丞且世世丁>k__BackingField.丙东专丂世丈丏丁丂()) != 1)
            {
                    return (bool)val_21;
            }
            
            if(( & 1) == 0)
            {
                    return (bool)val_21;
            }
            
            if((丐且丘丑与万丞丑丅.不丁丄下三丝与一丘() == true) || (丐且丘丑与万丞丑丅.且与业丞丞业丐丄丗().Count < 1))
            {
                goto label_11;
            }
            
            PGCompany.GameModeEvents.丝一七万丗不丄丒上 val_6 = 丐且丘丑与万丞丑丅.且与业丞丞业丐丄丗().Item[0];
            if(val_6 == null)
            {
                    return (bool)val_21;
            }
            
            if((val_6.丑丑丏丁丗丏丘七一() != 1) || (丐且丘丑与万丞丑丅.丙丐丗丏与丛丌丐丂().Count < 1))
            {
                goto label_11;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  180);
            List.Enumerator<T> val_12 = 丐且丘丑与万丞丑丅.丙丐丗丏与丛丌丐丂().GetEnumerator();
            label_21:
            if(((-764930240) & 1) == 0)
            {
                goto label_16;
            }
            
            string val_15 = val_14.丐丏七丌丕丗业且上();
            if((val_13 == 0) || ((val_15.丂丑丞丝且万丐万丟() == null) || (val_13 != 8)))
            {
                goto label_21;
            }
            
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_15.丂丑丞丝且万丐万丟(), 丁且丟不七下丆丒丟:  false, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  45, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
            goto label_21;
            label_11:
            val_21 = 0;
            return (bool)val_21;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.List<System.Int32> val_19 = new System.Collections.Generic.List<System.Int32>();
            val_19.Add(item:  丐且丘丑与万丞丑丅.<上七东下丏不丕丐丑>k__BackingField);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万业专不下丅三上专(丒丐业丐丌东丑不丌:  val_19);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            Rilisoft.丞丛七上丕专丏丌丈.丂丅丞丘丒丐丙东一();
            return (bool)val_21;
        }
        private System.Collections.Generic.List<string> 一世一丝东七丙丁丆()
        {
            var val_4;
            var val_11;
            var val_12;
            var val_13;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_2 = this.丝世丄丟丑业专丟与.GetEnumerator();
            val_11 = 0;
            val_12 = 0;
            var val_11 = 0;
            label_21:
            if(((-764732256) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5.丑丛业丛东业且丒下() == null)
            {
                goto label_21;
            }
            
            List.Enumerator<T> val_8 = val_5.且与业丞丞业丐丄丗().GetEnumerator();
            label_11:
            if(((-764732288) & 1) == 0)
            {
                goto label_7;
            }
            
            if(val_4.丐丏七丌丕丗业且上() == null)
            {
                goto label_11;
            }
            
            val_1.Add(item:  val_5.m_stringLength.ToString());
            goto label_11;
            label_7:
            val_11 = val_11 + 1;
            mem2[0] = 105;
            val_13 = val_12;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_11 == 1) || ((1152921559676689488 + ((0 + 1)) << 2) != 105))
            {
                goto label_18;
            }
            
            var val_12 = 0;
            val_12 = val_12 ^ (val_11 >> 31);
            val_11 = val_11 + val_12;
            goto label_21;
            label_18:
            if( == 0)
            {
                goto label_21;
            }
            
            goto label_21;
            label_2:
            val_11 = val_11 + 1;
            mem2[0] = 130;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_11 != 1)
            {
                    if( == 0)
            {
                    return val_1;
            }
            
                if((1152921559676689488 + ((0 + 1)) << 2) == 130)
            {
                    return val_1;
            }
            
                return val_1;
            }
            
            if( != 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        internal void 丂丙丒一丙业丕下专(int 丟丟丄专上丟丁丐丝)
        {
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            val_2.Add(item:  丟丟丄专上丟丁丐丝);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丂丙丒一丙业丕下专(丒丐业丐丌东丑不丌:  val_2);
        }
        internal void 三世业三丑上丐丁不(string 丐丕丂丐丟不丅万丏, PGCompany.GameModeEvents.GMERewardConditionProgress 丘丙且丕世丕丆丁丅)
        {
            丈专丂丁丁东丌丁丅.GMERewardSavedConditions val_1 = new 丈专丂丁丁东丌丁丅.GMERewardSavedConditions();
            if(val_1 != null)
            {
                    .ConditionId = 丐丕丂丐丟不丅万丏;
            }
            else
            {
                    mem[16] = 丐丕丂丐丟不丅万丏;
            }
            
            .Progress = 丘丙且丕世丕丆丁丅;
            System.Collections.Generic.List<GMERewardSavedConditions> val_3 = new System.Collections.Generic.List<GMERewardSavedConditions>();
            val_3.Add(item:  val_1);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丛丒丆丘丆上丄丌(且且万丅丏与丟丑丗:  val_3);
        }
        internal System.Collections.Generic.List<int> 世下与下专丛七丁专()
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_9 = 0;
            goto label_1;
            label_16:
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = this.丝世丄丟丑业专丟与.Item[0];
            if(val_2.丑丛业丛东业且丒下() == null)
            {
                goto label_4;
            }
            
            val_10 = 0;
            goto label_5;
            label_14:
            if((val_2.且与业丞丞业丐丄丗().Item[0] != null) && (val_5.丙丆丂丄丑且丛与丏 != false))
            {
                    val_1.Add(item:  val_2.<上七东下丏不丕丐丑>k__BackingField);
                val_5.丙丆丂丄丑且丛与丏 = false;
            }
            
            val_10 = 1;
            label_5:
            if(val_10 < val_2.且与业丞丞业丐丄丗().Count)
            {
                goto label_14;
            }
            
            label_4:
            val_9 = 1;
            label_1:
            if(val_9 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_16;
            }
            
            return val_1;
        }
        internal System.Collections.Generic.List<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions> 业不且丟丝上丕万七()
        {
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_12;
            var val_13;
            var val_14;
            val_12 = this;
            System.Collections.Generic.List<GMERewardSavedConditions> val_1 = new System.Collections.Generic.List<GMERewardSavedConditions>();
            val_13 = 0;
            goto label_1;
            label_17:
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = this.丝世丄丟丑业专丟与.Item[0];
            if(val_2.丑丛业丛东业且丒下() == null)
            {
                goto label_4;
            }
            
            val_14 = 0;
            goto label_5;
            label_15:
            PGCompany.GameModeEvents.丝一七万丗不丄丒上 val_5 = val_2.且与业丞丞业丐丄丗().Item[0];
            if(val_5 != null)
            {
                    丈专丂丁丁东丌丁丅.GMERewardSavedConditions val_7 = new 丈专丂丁丁东丌丁丅.GMERewardSavedConditions();
                string val_8 = val_2.<上七东下丏不丕丐丑>k__BackingField.ToString();
                if(val_7 != null)
            {
                    .ConditionId = val_8;
            }
            else
            {
                    mem[16] = val_8;
            }
            
                .Progress = val_5.丄且丙丂丆不一万七(丂丘丈丈专万丈丈丆:  false, 丑丟丙丄不丟丄丗丕:  0);
                val_1.Add(item:  val_7);
            }
            
            val_14 = 1;
            label_5:
            if(val_14 < val_2.且与业丞丞业丐丄丗().Count)
            {
                goto label_15;
            }
            
            label_4:
            val_12 = val_12;
            val_13 = val_13 + 1;
            label_1:
            if(val_13 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_17;
            }
            
            return val_1;
        }
        internal PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEPlayerState 下丙专丗丐丄丗丛丞()
        {
            if(this.业上丄丘丝不丕丘丐 == null)
            {
                    return (GMEPlayerState)new 丈专丂丁丁东丌丁丅.GMEPlayerState();
            }
            
            if(this.业上丄丘丝不丕丘丐 == null)
            {
                
            }
        
        }
        internal T 丄丏丄丙世丄丈三专<T>(int 丟丟丄专上丟丁丐丝, string 丂丐丄丁丆与丈丂上, string 丄丒丞丝丑丑丘与丅)
        {
            var val_9;
            string val_10;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_11;
            var val_12;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = 丂丐丄丁丆与丈丂上;
            val_11 = this;
            if((this.丏丆且丟丈丞一专不.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
            {
                    val_11 = this.丏丆且丟丈丞一专不;
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = val_11.Item[丟丟丄专上丟丁丐丝];
                if((val_2.ContainsKey(key:  val_10)) != false)
            {
                    val_10 = val_2.Item[val_10];
                if(val_10 == null)
            {
                    return (object)val_12;
            }
            
                string val_5 = (丄丒丞丝丑丑丘与丅 == null) ? "v" : 丄丒丞丝丑丑丘与丅;
                if((val_10.ContainsKey(key:  val_5)) != false)
            {
                    object val_7 = val_10.Item[val_5];
                val_10 = mem[__RuntimeMethodHiddenParam + 48];
                val_10 = __RuntimeMethodHiddenParam + 48;
                val_12 = val_7;
                if(val_12 == null)
            {
                    return (object)val_12;
            }
            
                val_9 = mem[__RuntimeMethodHiddenParam + 48];
                val_9 = __RuntimeMethodHiddenParam + 48;
                if(val_7 != null)
            {
                    val_12 = val_7;
                if(val_12 != null)
            {
                    return (object)val_12;
            }
            
            }
            
            }
            
            }
            
            }
            
            val_12 = 0;
            return (object)val_12;
        }
        internal bool 丕且一三丅上万丑三(string 丂三丗丑丕丛丝业丌, int 丟丟丄专上丟丁丐丝, bool 不与丝且下万专且不 = True)
        {
            System.Collections.Generic.List<System.Int32> val_2 = Progress.七七世万专丕丁上业.一丛丂且且丕丆不丐().三丁一丁上丏世万七();
            if(val_2 != null)
            {
                    return val_2.Contains(item:  丟丟丄专上丟丁丐丝);
            }
            
            return val_2.Contains(item:  丟丟丄专上丟丁丐丝);
        }
        private bool 丐万丁万上下丆丄丑(int 丞丅上丏丂且下丅与)
        {
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            bool val_3 = this.丝世丄丟丑业专丟与.Exists(match:  new System.Predicate<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(object:  new 丈专丂丁丁东丌丁丅.丟丑不七不丆业丐丛(), method:  System.Boolean 丈专丂丁丁东丌丁丅.丟丑不七不丆业丐丛::不丒世业丈三丁下丐(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑)));
            val_3 = (~val_3) & 1;
            return (bool)val_3;
        }
    
    }

}
