using UnityEngine;

namespace Rilisoft
{
    internal sealed class FortsManager : Singleton<Rilisoft.FortsManager>
    {
        // Fields
        internal const string 丗下且七丞丂丏丄丈 = "part_";
        private const string 丂万不万丛万丒一三 = "details";
        private const string 丝丘丞不丂丆不丘且 = "items";
        private bool 丒丑世业丗丁万上丐;
        private Rilisoft.丅丟丒丟丑丈丒三丆 丕丟丘丒世与三丘丝;
        private Rilisoft.丅丟丒丟丑丈丒三丆 下上丟丑丝上万丙三;
        private System.Collections.Generic.Dictionary<string, object> 东丛丐丄丅专丕丑丒;
        private System.Collections.Generic.Dictionary<string, Rilisoft.FortItemState> 丒不与与丗丄七三丅;
        internal const string 三丒丏七上东东丂业 = "fort_items";
        internal const string 丏丁世万专丈丑专丑 = "decor_big_military_1";
        internal static System.Collections.Generic.List<Rilisoft.FortItemGroupType> 一丑不丐丌丁一上丒;
        private static bool 丗丌下业上丕丝丑丘;
        private static readonly System.Collections.Generic.List<Rilisoft.丗一且丈上丝下丈丝> 丅业丟丝丝丘万上丄;
        private static readonly System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丙七丟东丑丙丑丆且;
        private System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丛不丞丂七丞世丁丏;
        private bool 丆丘丒不上下一丙一;
        private bool 丘万万且丂丟丟与丌;
        private bool 丄且专与丌专丁丒丒;
        private static System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丛业不丏丒丄丐丑丈;
        private Rilisoft.东且东丒丐世丐丞丒 <世丝上丞东丌丑万专>k__BackingField;
        private Rilisoft.东且东丒丐世丐丞丒 <丛上丟丏与丕丒东丂>k__BackingField;
        private 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 <丛丄七丟丈丆丒丆丈>k__BackingField;
        private System.Action 丏且业不与丞丕丙丅;
        private static System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丘丐丟丑丈丗丟专下;
        private static System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丝与丟丕且丈丙且上;
        private static System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丒下业丙与一丟丑三;
        private static System.Action<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒> 世丐与下丂业上丗丛;
        private static System.Action<bool> 丛丄丅丄业丗丑专丑;
        private System.Action 丄丄丙丘丐一丌丁丄;
        private static System.Action<丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三, float> 丄丂丞丒丝业世不丕;
        private System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三, float> 丛与丙东不三丏业上;
        private System.Collections.Generic.Dictionary<Rilisoft.东且东丒丐世丐丞丒, System.Collections.Generic.List<Rilisoft.FortItemEffectHandler>> 丘丝一丕丂七七七丂;
        private System.Action 东丆七丟丙丘丒丏丄;
        
        // Properties
        internal System.Collections.Generic.Dictionary<string, Rilisoft.FortItemState> 丑丛丕丅丛丘不丙丛 { get; }
        internal System.Collections.Generic.Dictionary<string, object> 丝丟丞三不七世丁丛 { get; }
        internal bool 丒丆丁丘丈丏丆丌丘 { get; set; }
        internal bool 丌专且三丁丞丄世丅 { get; }
        internal bool 丐且丟丝下丅丞七业 { get; }
        internal static System.Nullable<long> 丏一丛丗丝丘丆丌专 { get; }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丙万丗丑丐专且与丈 { get; }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丆丈业丄上丝专丕三 { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.东且东丒丐世丐丞丒> 丛世不丂不丆丄丝专 { get; }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丑丙丞万丞丏与丟丝 { get; }
        internal Rilisoft.东且东丒丐世丐丞丒 丌丑上丞与丆丏丌一 { get; set; }
        internal Rilisoft.东且东丒丐世丐丞丒 丛七丐且下丅上丁丘 { get; set; }
        internal 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丈业丐丂三丞与且丄 { get; set; }
        internal System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒> 丅丈丐丘丌不丌东东 { get; }
        internal static bool 丛丏且丗世七丞丝丐 { get; }
        internal static System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 且丑与丟丝业且世丕 { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.FortItemState> 丅东丘不东丛丈丘丄 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, Rilisoft.FortItemState> 三万丈丈丌丛上不下()
        {
            return (System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>)this.丒不与与丗丄七三丅;
        }
        internal System.Collections.Generic.Dictionary<string, object> 丑丝丛丟上万丕丕上()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.东丛丐丄丅专丕丑丒;
        }
        public void OnInstanceCreated()
        {
            var val_13;
            var val_32;
            var val_42;
            var val_43;
            var val_44;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::与丒丛丗上丅三丟丘()));
            PGCompany.Clans.Network.丘且丂世丆东丂不丘.与丈丏不丘专丙丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::与丒丛丗上丅三丟丘()));
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::与丒丛丗上丅三丟丘()));
            PGCompany.Clans.Network.丘且丂世丆东丂不丘.与丈丏不丘专丙丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::与丒丛丗上丅三丟丘()));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.下上丟丑丝上万丙三.世三丞丅丑丌丈丈一())) != false)
            {
                    this.丒不与与丗丄七三丅 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
            }
            else
            {
                    Rilisoft.FortItemStatesContainer val_9 = UnityEngine.JsonUtility.FromJson<Rilisoft.FortItemStatesContainer>(json:  this.下上丟丑丝上万丙三.世三丞丅丑丌丈丈一());
                this.丒不与与丗丄七三丅 = val_9.States;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_11 = 与丙丅丛不丘一与专.一三专丞丒丅上业上().GetEnumerator();
            val_42 = 1152921542575620688;
            label_18:
            if(((-685814624) & 1) == 0)
            {
                goto label_13;
            }
            
            ConfiguredValueTaskAwaiter val_15 = val_13.GetAwaiter();
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  val_15._value._obj.丐丏七丌丕丗业且上())) == true)
            {
                goto label_18;
            }
            
            new Rilisoft.FortItemState() = new System.Object();
            .ItemId = val_15._value._obj.丐丏七丌丕丗业且上();
            this.丒不与与丗丄七三丅.Add(key:  val_15._value._obj.丐丏七丌丕丗业且上(), value:  new Rilisoft.FortItemState());
            goto label_18;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_43 = 1152921505284374528;
            val_44 = 1152921536195947008;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丕丟丘丒世与三丘丝.世三丞丅丑丌丈丈一())) != false)
            {
                    val_46 = 0;
                this.东丛丐丄丅专丕丑丒 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            else
            {
                    object val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  this.丕丟丘丒世与三丘丝.世三丞丅丑丌丈丈一());
                val_46 = 0;
            }
            
            label_73:
            val_47 = 0;
            label_78:
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                    if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(丑东与丅丐丅丂丞业:  this.东丛丐丄丅专丕丑丒)) == false)
            {
                goto label_49;
            }
            
            }
            
            this.东丛丐丄丅专丕丑丒 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_48 = null;
            val_48 = null;
            Dictionary.Enumerator<TKey, TValue> val_29 = Rilisoft.FortsManager.丙七丟东丑丙丑丆且.GetEnumerator();
            val_42 = 1152921526038841376;
            label_57:
            if(((-685814752) & 1) == 0)
            {
                goto label_53;
            }
            
            ConfiguredValueTaskAwaiter val_33 = val_32.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_34 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "id", value:  val_33._value._obj);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.东丛丐丄丅专丕丑丒.Add(key:  val_33._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  null);
            goto label_57;
            label_53:
            val_49 = val_46;
            val_47 = val_47 + 1;
            mem2[0] = 556;
            goto label_58;
            label_62:
            if(((-685814688) & 1) == 0)
            {
                goto label_60;
            }
            
            ConfiguredValueTaskAwaiter val_38 = val_13.GetAwaiter();
            this.东丛丐丄丅专丕丑丒.Add(key:  val_38._value._obj.丐丏七丌丕丗业且上(), value:  val_38._value._obj);
            goto label_62;
            label_60:
            val_50 = 0;
            val_51 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if(388 == 388)
            {
                goto label_73;
            }
            
            }
            
            if( == 0)
            {
                goto label_78;
            }
            
            goto label_78;
            label_81:
            if((null & 1) == 0)
            {
                goto label_77;
            }
            
            this.东丛丐丄丅专丕丑丒 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            goto label_78;
            label_77:
            mem[8] = val_13;
            goto label_81;
            label_58:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_92;
            }
            
            if(( == 0) || (388 == 556))
            {
                goto label_97;
            }
            
            label_96:
            label_97:
            this.世上丁丏世万且下业();
            label_49:
            this.不世丘东丂丟丗下丙();
            this.世丗丏丂丅丘且上丏();
            if(this.东丆七丟丙丘丒丏丄 == null)
            {
                    return;
            }
            
            this.东丆七丟丙丘丒丏丄.Invoke();
            return;
            label_92:
            if( != 0)
            {
                goto label_96;
            }
            
            goto label_97;
        }
        internal void 丘下丆专一丈丅丈丝()
        {
            var val_7;
            var val_17;
            var val_18;
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                    if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(丑东与丅丐丅丂丞业:  this.东丛丐丄丅专丕丑丒)) != true)
            {
                    val_17 = null;
                val_17 = null;
                if(this.东丛丐丄丅专丕丑丒.Count >= Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Count)
            {
                    return;
            }
            
            }
            
            }
            
            this.东丛丐丄丅专丕丑丒 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_18 = null;
            val_18 = null;
            Dictionary.Enumerator<TKey, TValue> val_5 = Rilisoft.FortsManager.丙七丟东丑丙丑丆且.GetEnumerator();
            label_20:
            if(((-685509088) & 1) == 0)
            {
                goto label_13;
            }
            
            ConfiguredValueTaskAwaiter val_9 = val_7.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "id", value:  val_9._value._obj);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((this.东丛丐丄丅专丕丑丒.ContainsKey(key:  val_9._value._obj.丙东专丂世丈丏丁丂().ToString())) == true)
            {
                goto label_20;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.东丛丐丄丅专丕丑丒.Add(key:  val_9._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  null);
            goto label_20;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.世上丁丏世万且下业();
        }
        internal static System.Collections.Generic.Dictionary<string, object> 一上丄与丌七业丈不(System.Collections.Generic.Dictionary<string, object> 专丘丘丗万一业下丆)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
            var val_13;
            val_12 = 专丘丘丗万一业下丆;
            val_13 = null;
            val_13 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = Rilisoft.FortsManager.丙七丟东丑丙丑丆且.GetEnumerator();
            label_11:
            if(((-685331552) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_12.ContainsKey(key:  val_5._value._obj.丙东专丂世丈丏丁丂().ToString())) == true)
            {
                goto label_11;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "id", value:  val_5._value._obj);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_12.Add(key:  val_5._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  null);
            goto label_11;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>);
        }
        internal Rilisoft.FortItemState 世下丗丆一专丞丂丟(string 丞一丁业丄一一业且)
        {
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  丞一丁业丄一一业且)) != true)
            {
                    object[] val_2 = new object[1];
                val_2[0] = 丞一丁业丄一一业且;
                UnityEngine.Debug.LogErrorFormat(format:  "state for fort item : \'{0}\' not found", args:  val_2);
            }
            
            if(this.丒不与与丗丄七三丅 != null)
            {
                    return this.丒不与与丗丄七三丅.Item[丞一丁业丄一一业且];
            }
            
            return this.丒不与与丗丄七三丅.Item[丞一丁业丄一一业且];
        }
        internal System.Collections.Generic.Dictionary<string, object> 丗丈专上不万丙丛丟(string 丄丒下业一不丈丝丘, string 丈丙七丆丂七丌丒丏)
        {
            var val_6;
            Rilisoft.FortsManager val_18;
            Rilisoft.FortsManager val_19;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20;
            var val_21;
            val_19 = this;
            object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丈丙七丆丂七丌丒丏);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_20 = null;
            val_20 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_3 = val_1.GetEnumerator();
            label_6:
            if(((-685003792) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            null.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  val_7._value._obj);
            goto label_6;
            label_4:
            val_18 = 0;
            val_21 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_15;
            }
            
            if( == 0)
            {
                goto label_19;
            }
            
            if(86 != 86)
            {
                goto label_17;
            }
            
            goto label_19;
            label_15:
            if( == 0)
            {
                goto label_19;
            }
            
            label_17:
            label_19:
            val_19 = 1152921524404748272;
            if((Rilisoft.Singleton<ClansController>.Instance) == 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_20;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_20;
            }
            
            if((System.String.op_Equality(a:  丄丒下业一不丈丝丘, b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁())) == false)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_20;
            }
            
            val_18 = val_19;
            mem[1152921542576561040].Clear();
            mem[1152921542576561040] = val_20;
            this.丄七丝三与丁丆丞丛();
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_20;
            label_3:
            val_20 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_20;
        }
        internal void 七丅丒三丏专一丒丑()
        {
            UnityEngine.Object val_5 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = Rilisoft.Singleton<ClansController>.Instance;
            丞丂丘丒丟丞丑下丄 val_4 = val_5.丞丗丑丈一丅丗丌丟();
        }
        private void 丄七丝三与丁丆丞丛()
        {
            var val_11;
            var val_46;
            var val_47;
            var val_48;
            var val_50;
            string val_51;
            var val_52;
            int val_55;
            Rilisoft.FortsManager val_56;
            MoonSharp.Interpreter.DynValue val_57;
            var val_58;
            var val_59;
            System.Collections.Generic.List<T> val_60;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>> val_1 = null;
            val_47 = val_1;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>>();
            DiscreteVector2 val_2 = new DiscreteVector2(三丟东丕丄丄下下丑:  237, 丒丒丄丁且丄丆丂丌:  245);
            val_1.Add(item:  new System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>() {Value = val_2._x});
            DiscreteVector2 val_3 = new DiscreteVector2(三丟东丕丄丄下下丑:  238, 丒丒丄丁且丄丆丂丌:  246);
            val_1.Add(item:  new System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>() {Value = val_3._x});
            DiscreteVector2 val_4 = new DiscreteVector2(三丟东丕丄丄下下丑:  235, 丒丒丄丁且丄丆丂丌:  243);
            val_1.Add(item:  new System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>() {Value = val_4._x});
            DiscreteVector2 val_5 = new DiscreteVector2(三丟东丕丄丄下下丑:  236, 丒丒丄丁且丄丆丂丌:  244);
            val_1.Add(item:  new System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, 丗丞丏丙七丑丕且丐>() {Value = val_5._x});
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_6 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>();
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            Dictionary.Enumerator<TKey, TValue> val_8 = this.东丛丐丄丅专丕丑丒.GetEnumerator();
            val_48 = 0;
            label_65:
            if(((-684596496) & 1) == 0)
            {
                goto label_6;
            }
            
            new FortsManager.与丟业一丈上丅上不() = new FortsManager.与丟业一丈上丅上不();
            ConfiguredValueTaskAwaiter val_13 = val_11.GetAwaiter();
            if(new FortsManager.与丟业一丈上丅上不() != null)
            {
                    val_50 = new FortsManager.与丟业一丈上丅上不();
                .下丅丙一丂丗丅丝七 = val_13._value._obj;
                mem[1152921542577016696] = val_13._value._token;
                mem[1152921542577016698] = val_13._value._continueOnCapturedContext;
            }
            else
            {
                    mem[16] = val_13._value._obj;
                mem[24] = val_13._value._token;
                mem[26] = val_13._value._continueOnCapturedContext;
                val_50 = 16;
            }
            
            if((val_50 == 0) || ((mem[16].ContainsKey(key:  "id")) == false))
            {
                goto label_65;
            }
            
            object val_15 = mem[16].Item["id"];
            if(val_15 != null)
            {
                    var val_16 = (null == null) ? (val_15) : 0;
            }
            else
            {
                    val_51 = 0;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_17 = this.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_51);
            if((val_17 != null) && (val_17.丁丞一不不丗丕丟丛() != null))
            {
                    System.Func<丗丞丏丙七丑丕且丐, System.Boolean> val_20 = new System.Func<丗丞丏丙七丑丕且丐, System.Boolean>(object:  new FortsManager.与丟业一丈上丅上不(), method:  System.Boolean FortsManager.与丟业一丈上丅上不::丁上东丑丕丟不东丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 三丟东丕丄丄下下丑));
                if((System.Linq.Enumerable.Any<丗丞丏丙七丑丕且丐>(source:  val_17.丁丞一不不丗丕丟丛(), predicate:  null)) != true)
            {
                    val_7.Add(item:  mem[16].丐丏七丌丕丗业且上());
            }
            
            }
            
            List.Enumerator<T> val_23 = val_1.GetEnumerator();
            goto label_24;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_2._x.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂().ToString() == val_50)
            {
                    mem[1152921542576968312] = 0;
            }
            
            label_24:
            if(((-684596528) & 1) != 0)
            {
                goto label_25;
            }
            
            val_52 = 0 + 1;
            mem2[0] = 364;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_52 != 1) && ((1152921542576955824 + ((0 + 1)) << 2) == 364))
            {
                    var val_46 = 0;
                val_46 = val_46 ^ (val_52 >> 31);
                val_52 = val_52 + val_46;
            }
            
            if(mem[1152921542576968312] == 0)
            {
                goto label_65;
            }
            
            List.Enumerator<T> val_28 = val_1.GetEnumerator();
            label_46:
            if(((-684596528) & 1) == 0)
            {
                goto label_40;
            }
            
            string val_30 = val_3._x.丐丏七丌丕丗业且上();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.String.op_Equality(a:  val_30.丙东专丂世丈丏丁丂().ToString(), b:  mem[16].丐丏七丌丕丗业且上())) == false)
            {
                goto label_46;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_11 = 0;
            MoonSharp.Interpreter.TablePair val_36 = new MoonSharp.Interpreter.TablePair(key:  val_51, val:  val_30.ToString());
            val_6.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>() {Value = val_36.key});
            goto label_46;
            label_40:
            val_52 = val_52 + 1;
            mem2[0] = 492;
            val_55 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_52 == 1) || ((1152921542576955824 + (((0 + 1) + 1)) << 2) != 492))
            {
                goto label_62;
            }
            
            var val_47 = 0;
            val_47 = val_47 ^ (val_52 >> 31);
            val_52 = val_52 + val_47;
            goto label_65;
            label_62:
            if( == 0)
            {
                goto label_65;
            }
            
            goto label_65;
            label_6:
            val_56 = this;
            val_57 = 0;
            val_58 = 0 + 1;
            mem2[0] = 520;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_58 == 1) || ((1152921542576955824 + ((0 + 1)) << 2) != 520))
            {
                goto label_88;
            }
            
            var val_48 = 0;
            val_48 = val_48 ^ (val_58 >> 31);
            val_58 = val_58 + val_48;
            if(val_6 != null)
            {
                goto label_92;
            }
            
            goto label_90;
            label_88:
            if( != 0)
            {
                    val_57 = 0;
            }
            
            if(val_6 != null)
            {
                goto label_92;
            }
            
            label_90:
            label_92:
            if(val_6.Count < 1)
            {
                goto label_110;
            }
            
            List.Enumerator<T> val_38 = val_6.GetEnumerator();
            val_48 = 1152921542576928928;
            val_59 = 1152921516595667312;
            label_98:
            if(((-684596592) & 1) == 0)
            {
                goto label_95;
            }
            
            ConfiguredValueTaskAwaiter val_39 = val_36.key.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_40 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "id", value:  val_39._value._obj.丐丏七丌丕丗业且上());
            this.东丛丐丄丅专丕丑丒.Add(key:  val_39._value._obj, value:  null);
            goto label_98;
            label_95:
            val_46 = -684596816;
            val_56 = this;
            val_57 = val_57;
            val_58 = val_58 + 1;
            mem2[0] = 619;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && ((val_46 + ((0 + 1)) << 2) == 619))
            {
                    var val_49 = 0;
                val_49 = val_49 ^ ( >> 31);
                val_58 =  + val_49;
            }
            else
            {
                    if( != 0)
            {
                    val_57 = 0;
            }
            
            }
            
            label_110:
            val_60 = val_7;
            if(val_60 == 0)
            {
                    val_60 = val_7;
            }
            
            if(val_7.Count < 1)
            {
                    return;
            }
            
            val_48 = ;
            if(val_60 == 0)
            {
                    val_60 = val_7;
            }
            
            List.Enumerator<T> val_43 = val_7.GetEnumerator();
            val_47 = 1152921519126359200;
            label_116:
            if(((-684596632) & 1) == 0)
            {
                goto label_114;
            }
            
            bool val_45 = this.东丛丐丄丅专丕丑丒.Remove(key:  0.丐丏七丌丕丗业且上());
            goto label_116;
            label_114:
            val_59 =  + 1;
            mem2[0] = 686;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_59 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((val_48 + (((0 + 1) + 1)) << 2) == 686)
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
        private void 与丒丛丗上丅三丟丘()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) == 0)
            {
                    return;
            }
            
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                    this.东丛丐丄丅专丕丑丒.Clear();
            }
            
            if(this.丒不与与丗丄七三丅 != null)
            {
                    this.丒不与与丗丄七三丅.Clear();
            }
            
            if(this.下上丟丑丝上万丙三 != null)
            {
                    this.下上丟丑丝上万丙三.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
            }
            
            if(this.丕丟丘丒世与三丘丝 != null)
            {
                    this.丕丟丘丒世与三丘丝.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
            }
            
            if(this.丛不丞丂七丞世丁丏 == null)
            {
                    return;
            }
            
            this.丛不丞丂七丞世丁丏.Clear();
            this.丛不丞丂七丞世丁丏 = 0;
        }
        internal void 丑七丂丌世与七丏与(string 丛七丅东丒丅丘不业)
        {
            var val_7;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_35;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_36;
            var val_37;
            var val_39;
            if(this.丄且专与丌专丁丒丒 == true)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛七丅东丒丅丘不业)) == true)
            {
                    return;
            }
            
            if((this.丐丕世丄业丝丑丌一(丛七丅东丒丅丘不业:  丛七丅东丒丅丘不业, 丌丄万上丙万丄丒七: out  0, 丑七不与丛丆一丂丞: out  0)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_5 = val_3.GetEnumerator();
            label_20:
            if(((-684087824) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if((与丙丅丛不丘一与专.一三专丞丒丅上业上().ContainsKey(key:  X22)) == false)
            {
                goto label_20;
            }
            
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  X22)) == false)
            {
                goto label_14;
            }
            
            Rilisoft.FortItemState val_12 = this.丒不与与丗丄七三丅.Item[this.丒不与与丗丄七三丅];
            mem2[0] = val_12.WasShown;
            this.丒不与与丗丄七三丅.set_Item(key:  this.丒不与与丗丄七三丅, value:  val_8);
            goto label_20;
            label_14:
            this.丒不与与丗丄七三丅.Add(key:  this.丒不与与丗丄七三丅, value:  val_8);
            goto label_20;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Dictionary.Enumerator<TKey, TValue> val_13 = val_2.GetEnumerator();
            label_41:
            if(((-684087872) & 1) == 0)
            {
                goto label_33;
            }
            
            ConfiguredValueTaskAwaiter val_15 = val_7.GetAwaiter();
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  val_15._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_35;
            }
            
            Rilisoft.FortItemState val_19 = this.丒不与与丗丄七三丅.Item[val_15._value._obj.丐丏七丌丕丗业且上()];
            val_19.PartsExists = ;
            goto label_41;
            label_35:
            new Rilisoft.FortItemState() = new System.Object();
            .ItemId = val_15._value._obj.丐丏七丌丕丗业且上();
            .PartsExists = val_15._value._obj;
            this.丒不与与丗丄七三丅.Add(key:  val_15._value._obj.丐丏七丌丕丗业且上(), value:  new Rilisoft.FortItemState());
            goto label_41;
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_36 = this.丛不丞丂七丞世丁丏;
            if(val_36 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_36 = this.丛不丞丂七丞世丁丏;
            }
            
            val_37 = null;
            val_37 = null;
            val_35 = FortsManager.<>c.<>9__20_0;
            if(val_35 == null)
            {
                    System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_23 = null;
                val_35 = val_23;
                val_23 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortsManager.<>c::专下业与丑丛丁业下(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
                FortsManager.<>c.<>9__20_0 = val_35;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_24 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_36, predicate:  val_23);
            this.<丛上丟丏与丕丒东丂>k__BackingField = val_24;
            if(val_24 == null)
            {
                goto label_63;
            }
            
            if((val_24.丁丞一不不丗丕丟丛() == null) || ((this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Count) < 1))
            {
                goto label_67;
            }
            
            val_35 = this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Contains(item:  this.<丛上丟丏与丕丒东丂>k__BackingField.丏世丛丂与丐丟与丏());
            if(val_35 == false)
            {
                goto label_72;
            }
            
            丗丞丏丙七丑丕且丐 val_31 = this.<丛上丟丏与丕丒东丂>k__BackingField.丏世丛丂与丐丟与丏();
            goto label_74;
            label_67:
            val_39 = 1023;
            goto label_74;
            label_72:
            label_74:
            this.<丛丄七丟丈丆丒丆丈>k__BackingField = this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Item[0];
            label_63:
            this.世上丁丏世万且下业();
            if(this.东丆七丟丙丘丒丏丄 == null)
            {
                    return;
            }
            
            this.东丆七丟丙丘丒丏丄.Invoke();
        }
        internal void 世业丒万丘丆专丘丐()
        {
            this.丒不与与丗丄七三丅.Clear();
            this.东丛丐丄丅专丕丑丒.Clear();
            this.世上丁丏世万且下业();
            if(this.东丆七丟丙丘丒丏丄 == null)
            {
                    return;
            }
            
            this.东丆七丟丙丘丒丏丄.Invoke();
        }
        internal void 世上丁丏世万且下业()
        {
            .States = this.丒不与与丗丄七三丅;
            this.下上丟丑丝上万丙三.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  UnityEngine.JsonUtility.ToJson(obj:  new Rilisoft.FortItemStatesContainer()));
            if(this.东丛丐丄丅专丕丑丒 == null)
            {
                    return;
            }
            
            this.丕丟丘丒世与三丘丝.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.东丛丐丄丅专丕丑丒));
        }
        internal void 丁丈世丐丛世丂丆丝(System.Collections.Generic.Dictionary<string, Rilisoft.FortItemState> 三万下丂丅丒丐世丐, bool 上丅丏不丗丒丈七丒 = False)
        {
            if((Rilisoft.Singleton<ClansController>.Instance) == 0)
            {
                    return;
            }
            
            if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) - 1) > 1)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            Rilisoft.Singleton<ClansController>.Instance.业与丏专丒世与丞丝(丛不万丄丘世世万万:  三万下丂丅丒丐世丐, 上丅丏不丗丒丈七丒:  上丅丏不丗丒丈七丒);
        }
        internal void 丏丐业一丆丙丛七丗(bool 上丅丏不丗丒丈七丒 = False)
        {
            丌丌丄丂丕丑专万丆 val_18 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            if(this.东丛丐丄丅专丕丑丒 == null)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance) == 0)
            {
                    return;
            }
            
            if((val_18 - 1) > 1)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            val_18 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_18 == 0)
            {
                    return;
            }
            
            val_18 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_18.丞丗丑丈一丅丗丌丟() == null)
            {
                    return;
            }
            
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丛世专业丌下一丏上().万不丄丟丑丗七万丗(丘业七不丌丌上丑丌:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.东丛丐丄丅专丕丑丒), 七丂专丗丝业业业世:  上丅丏不丗丒丈七丒);
        }
        private bool 丐丕世丄业丝丑丌一(string 丛七丅东丒丅丘不业, out System.Collections.Generic.Dictionary<string, int> 丌丄万上丙万丄丒七, out System.Collections.Generic.List<Rilisoft.FortItemState> 丑七不与丛丆一丂丞)
        {
            var val_9;
            string val_62;
            var val_63;
            var val_64;
            var val_66;
            var val_68;
            bool val_69;
            int val_70;
            val_62 = 丛七丅东丒丅丘不业;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            丌丄万上丙万丄丒七 = val_1;
            System.Collections.Generic.List<Rilisoft.FortItemState> val_2 = new System.Collections.Generic.List<Rilisoft.FortItemState>();
            丑七不与丛丆一丂丞 = val_2;
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_62);
            if(val_3 == null)
            {
                    return (bool)val_63;
            }
            
            val_62 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            val_63 = 0;
            return (bool)val_63;
            label_17:
            if(((-682957408) & 1) == 0)
            {
                goto label_11;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  Item[val_10], 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_17;
            }
            
            val_1.Add(key:  val_10, value:  0);
            goto label_17;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_64 = 1152921516630043280;
            if((val_62.ContainsKey(key:  "items")) == false)
            {
                    return (bool)val_63;
            }
            
            object val_15 = val_62.Item["items"];
            if(val_15 == null)
            {
                    return (bool)val_63;
            }
            
            val_62 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
            Dictionary.Enumerator<TKey, TValue> val_16 = val_62.GetEnumerator();
            label_123:
            if(((-682957456) & 1) == 0)
            {
                goto label_33;
            }
            
            ConfiguredValueTaskAwaiter val_18 = val_9.GetAwaiter();
            new FortsManager.丄丆丌丌丕丈丆丆业() = new FortsManager.丄丆丌丌丕丈丆丆业();
            .丞丅上丏丂且下丅与 = val_18._value._obj.丐丏七丌丕丗业且上();
            System.Func<Rilisoft.FortItemState, System.Boolean> val_21 = new System.Func<Rilisoft.FortItemState, System.Boolean>(object:  new FortsManager.丄丆丌丌丕丈丆丆业(), method:  System.Boolean FortsManager.丄丆丌丌丕丈丆丆业::丘业丈且三丞一丙万(Rilisoft.FortItemState 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<Rilisoft.FortItemState>(source:  val_2, predicate:  null)) == false)
            {
                goto label_35;
            }
            
            object[] val_23 = new object[1];
            val_23[0] = (FortsManager.丄丆丌丌丕丈丆丆业)[1152921542578684288].丞丅上丏丂且下丅与;
            UnityEngine.Debug.LogErrorFormat(format:  "duplicate fort iten info, id: \'{0}\'", args:  val_23);
            goto label_123;
            label_35:
            new Rilisoft.FortItemState() = new System.Object();
            .ItemId = (FortsManager.丄丆丌丌丕丈丆丆业)[1152921542578684288].丞丅上丏丂且下丅与;
            if((0.ContainsKey(key:  "crafted")) != false)
            {
                    bool val_28 = System.Boolean.TryParse(value:  0.Item["crafted"], result: out  (Rilisoft.FortItemState)[1152921542578704784].Crafted);
            }
            
            if((0.ContainsKey(key:  "slot2")) == false)
            {
                goto label_53;
            }
            
            val_66 = ;
            object val_32 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  0.Item["slot2"]);
            goto label_60;
            label_53:
            if((0.ContainsKey(key:  "slot")) == false)
            {
                goto label_62;
            }
            
            val_66 = ;
            object val_36 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  0.Item["slot"]);
            label_60:
            .CraftSlot = null;
            if((1 & 1) == 0)
            {
                goto label_69;
            }
            
            label_71:
            val_68 = 1;
            goto label_70;
            label_62:
            val_66 = ;
            if(1 != 0)
            {
                goto label_71;
            }
            
            label_69:
            val_68 = 0;
            label_70:
            if((0.ContainsKey(key:  "craft_start")) != false)
            {
                    bool val_40 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  0.Item["craft_start"], 丙业与丙丗丝不丈东: out  (Rilisoft.FortItemState)[1152921542578704784].CraftStarted);
            }
            
            if((0.ContainsKey(key:  "craft_startv2")) != false)
            {
                    bool val_44 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  0.Item["craft_startv2"], 丙业与丙丗丝不丈东: out  (Rilisoft.FortItemState)[1152921542578704784].CraftStartedV2);
            }
            
            if((0.ContainsKey(key:  "count")) != false)
            {
                    bool val_48 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  0.Item["count"], 丙业与丙丗丝不丈东: out  (Rilisoft.FortItemState)[1152921542578704784].ItemCount);
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_49 = this.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  (Rilisoft.FortItemState)[1152921542578704784].ItemId);
            if(((val_49 != null) && (val_49.丁丞一不不丗丕丟丛() != null)) && (val_49.丁丞一不不丗丕丟丛().Count >= 1))
            {
                    if((val_49.丁丞一不不丗丕丟丛().Contains(item:  (Rilisoft.FortItemState)[1152921542578704784].CraftSlot)) != true)
            {
                    .CraftSlot = val_49.丁丞一不不丗丕丟丛().Item[0];
            }
            
            }
            
            if((((Rilisoft.FortItemState)[1152921542578704784].CraftStarted >= 1) && ((Rilisoft.FortItemState)[1152921542578704784].CraftStartedV2 == 0)) && ((Rilisoft.FortItemState)[1152921542578704784].Crafted != true))
            {
                    .CraftStartedV2 = (Rilisoft.FortItemState)[1152921542578704784].CraftStarted;
            }
            
            val_69 = (Rilisoft.FortItemState)[1152921542578704784].Crafted;
            if(val_69 == false)
            {
                goto label_101;
            }
            
            if((Rilisoft.FortItemState)[1152921542578704784].ItemCount == 0)
            {
                goto label_100;
            }
            
            val_69 = 0;
            goto label_101;
            label_100:
            if(val_49 == null)
            {
                goto label_102;
            }
            
            .ItemCount = val_49.丁丞一不不丗丕丟丛().Count;
            if((val_49.丁丞一不不丗丕丟丛().Contains(item:  1023)) == false)
            {
                goto label_105;
            }
            
            val_70 = (Rilisoft.FortItemState)[1152921542578704784].ItemCount - 1;
            goto label_106;
            label_102:
            val_70 = 1;
            label_106:
            .ItemCount = val_70;
            label_105:
            val_69 = true;
            label_101:
            this.丒丑世业丗丁万上丐 = val_69;
            val_2.Add(item:  new Rilisoft.FortItemState());
            goto label_123;
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_63;
        }
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
            if(Rilisoft.FortsManager.丛丄丅丄业丗丑专丑 == null)
            {
                    return;
            }
            
            Rilisoft.FortsManager.丛丄丅丄业丗丑专丑.Invoke(obj:  (this.丆丘丒不上下一丙一 == true) ? 1 : 0);
        }
        internal bool 丄丆丑世东丏丐上丒()
        {
            return (bool)this.丄且专与丌专丁丒丒;
        }
        internal bool 七丑丆且丞丅丞一万()
        {
            return (bool)this.丘万万且丂丟丟与丌;
        }
        internal static System.Nullable<long> 丅丘七世上丘且丗不()
        {
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return 0;
            }
            
            long val_2 = FriendsController.丝丗专上三不丄丑丑();
            return 0;
        }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 三下丙丛且丛丄丅丕()
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_1 = this.丛不丞丂七丞世丁丏;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.不世丘东丂丟丗下丙();
            val_1 = this.丛不丞丂七丞世丁丏;
            return val_1;
        }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丆丆专丄三丘丆丛丞()
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_3;
            var val_4;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_6;
            val_3 = this.丛不丞丂七丞世丁丏;
            if(val_3 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_3 = this.丛不丞丂七丞世丁丏;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = FortsManager.<>c.<>9__48_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_1 = null));
            }
            
            val_6 = val_1;
            val_1 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortsManager.<>c::上且丂丈专丌丂丄七(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            FortsManager.<>c.<>9__48_0 = val_6;
            return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  val_1));
        }
        internal System.Collections.Generic.IEnumerable<Rilisoft.东且东丒丐世丐丞丒> 东丄丗专不丟丝丂与()
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_3;
            var val_4;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_6;
            val_3 = this.丛不丞丂七丞世丁丏;
            if(val_3 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_3 = this.丛不丞丂七丞世丁丏;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = FortsManager.<>c.<>9__50_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_1 = null));
            }
            
            val_6 = val_1;
            val_1 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortsManager.<>c::万丏七丅丞丒丙一丛(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            FortsManager.<>c.<>9__50_0 = val_6;
            return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  val_1));
        }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丄七丗东万丙丘丆丌()
        {
            var val_7;
            var val_8;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_9;
            var val_10;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_11;
            var val_12;
            val_7 = null;
            val_7 = null;
            Rilisoft.FortsManager.丛业不丏丒丄丐丑丈.Clear();
            val_8 = 0;
            goto label_4;
            label_20:
            if(this.丛不丞丂七丞世丁丏 == null)
            {
                    this.不世丘东丂丟丗下丙();
            }
            
            val_9 = 0.Item[0];
            if(val_9.且丅一一三七专丑丏() != false)
            {
                    if(this.丛不丞丂七丞世丁丏 == null)
            {
                    this.不世丘东丂丟丗下丙();
            }
            
                val_9 = 0.Item[0];
                if(val_9.丛三上业丑东丅丐世() != false)
            {
                    val_10 = null;
                val_10 = null;
                val_9 = Rilisoft.FortsManager.丛业不丏丒丄丐丑丈;
                if(this.丛不丞丂七丞世丁丏 == null)
            {
                    this.不世丘东丂丟丗下丙();
            }
            
                val_9.Add(item:  0.Item[0]);
            }
            
            }
            
            val_8 = 1;
            label_4:
            val_11 = this.丛不丞丂七丞世丁丏;
            if(val_11 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_11 = this.丛不丞丂七丞世丁丏;
                if(val_11 == null)
            {
                    val_11 = 0;
            }
            
            }
            
            if(val_8 < val_11.Count)
            {
                goto label_20;
            }
            
            val_12 = null;
            val_12 = null;
            return (System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒>)Rilisoft.FortsManager.丛业不丏丒丄丐丑丈;
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丄丐且丐业丙世丞与()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this.<世丝上丞东丌丑万专>k__BackingField;
        }
        private void 丑丌一业丛丏丑一不(Rilisoft.东且东丒丐世丐丞丒 丙业与丙丗丝不丈东)
        {
            this.<世丝上丞东丌丑万专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丟丑丒丂万丟专丁万()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this.<丛上丟丏与丕丒东丂>k__BackingField;
        }
        private void 丌丘丘上三丅丆不丝(Rilisoft.东且东丒丐世丐丞丒 丙业与丙丗丝不丈东)
        {
            this.<丛上丟丏与丕丒东丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丏世丛丂与丐丟与丏()
        {
            return (丗丞丏丙七丑丕且丐)this.<丛丄七丟丈丆丒丆丈>k__BackingField;
        }
        private void 丐与丙丏业且丏丛万(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丙业与丙丗丝不丈东)
        {
            this.<丛丄七丟丈丆丒丆丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒> 不丁万专不业不丗与()
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_21;
            System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒> val_1 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒>();
            val_19 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_2.东丛丐丄丅专丕丑丒 == null)
            {
                    return val_1;
            }
            
            Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            val_19 = val_3.东丛丐丄丅专丕丑丒;
            Dictionary.Enumerator<TKey, TValue> val_4 = val_19.GetEnumerator();
            label_39:
            if(((-680714976) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
            new FortsManager.专丌业丝丈丘万丈专() = new FortsManager.专丌业丝丈丘万丈专();
            val_20;
            if(val_8._value._obj != 0)
            {
                    val_20 = 0;
            }
            
            .丈丆且丝丈丂不丄丌 = ;
            if(new FortsManager.专丌业丝丈丘万丈专() == null)
            {
                goto label_10;
            }
            
            goto label_12;
            label_10:
            val_20 = (FortsManager.专丌业丝丈丘万丈专)[1152921542580902288].丈丆且丝丈丂不丄丌;
            if(val_20 != null)
            {
                goto label_13;
            }
            
            label_12:
            label_13:
            if((val_20.ContainsKey(key:  "id")) == false)
            {
                goto label_39;
            }
            
            val_21 = this.丛不丞丂七丞世丁丏;
            if(val_21 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_21 = this.丛不丞丂七丞世丁丏;
            }
            
            System.Predicate<Rilisoft.东且东丒丐世丐丞丒> val_13 = new System.Predicate<Rilisoft.东且东丒丐世丐丞丒>(object:  new FortsManager.专丌业丝丈丘万丈专(), method:  System.Boolean FortsManager.专丌业丝丈丘万丈专::丅丕与东丅丈下不丟(Rilisoft.东且东丒丐世丐丞丒 三丟东丕丄丄下下丑));
            Rilisoft.东且东丒丐世丐丞丒 val_14 = System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  val_21).Find(match:  null);
            if(val_14 == null)
            {
                goto label_39;
            }
            
            object val_17 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_8._value._obj.丐丏七丌丕丗业且上());
            val_1.Add(key:  1152921504628731904, value:  val_14);
            goto label_39;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static bool 丑丆丏丟丗丌丄丟丝()
        {
            return true;
        }
        internal static System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丕丗丕丆丛丄丆丘()
        {
            null = null;
            return (System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String>)Rilisoft.FortsManager.丙七丟东丑丙丑丆且;
        }
        internal void 丂丈世丅不东七丑业(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丏且业不与丞丕丙丅, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丏且业不与丞丕丙丅 != 1152921542581259640);
        
        }
        internal void 丒丞业丅业丒丆丌丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丏且业不与丞丕丙丅, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丏且业不与丞丕丙丅 != 1152921542581396216);
        
        }
        internal static void 丏丏与一丁丄世世万(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.丘丐丟丑丈丗丟专下, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丘丐丟丑丈丗丟专下 != 1152921505444282408);
        
        }
        internal static void 与丌丌丒丘丅一丒上(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.丘丐丟丑丈丗丟专下, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丘丐丟丑丈丗丟专下 != 1152921505444282408);
        
        }
        internal static void 专丏业且丙丆丁且丈(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.丝与丟丕且丈丙且上, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丝与丟丕且丈丙且上 != 1152921505444282416);
        
        }
        internal static void 专七三丂下业丘丏丑(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.丝与丟丕且丈丙且上, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丝与丟丕且丈丙且上 != 1152921505444282416);
        
        }
        internal static void 三丘丒丞丕下丘万丂(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.丒下业丙与一丟丑三, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丒下业丙与一丟丑三 != 1152921505444282424);
        
        }
        internal static void 万丂丐一世业世万丑(System.Action<Rilisoft.东且东丒丐世丐丞丒, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.丒下业丙与一丟丑三, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丒下业丙与一丟丑三 != 1152921505444282424);
        
        }
        internal static void 东与丐东下丈七不丒(System.Action<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.世丐与下丂业上丗丛, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.世丐与下丂业上丗丛 != 1152921505444282432);
        
        }
        internal static void 七万丐丟业业且丕丂(System.Action<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.世丐与下丂业上丗丛, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.世丐与下丂业上丗丛 != 1152921505444282432);
        
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
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.丛丄丅丄业丗丑专丑, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丛丄丅丄业丗丑专丑 != 1152921505444282440);
        
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
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.丛丄丅丄业丗丑专丑, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丛丄丅丄业丗丑专丑 != 1152921505444282440);
        
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
            while(this.丄丄丙丘丐一丌丁丄 != 1152921542582816640);
        
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
            while(this.丄丄丙丘丐一丌丁丄 != 1152921542582953216);
        
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丒丅丙丄丞丟下丏业(string 丞丅上丏丂且下丅与)
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_3;
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            val_3 = this.丛不丞丂七丞世丁丏;
            if(val_3 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3 = this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.上与专上专丞东丄丆(), method:  System.Boolean FortsManager.上与专上专丞东丄丆::丗下丕丒丕丒与丛丈(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟)));
            }
            
            this.不世丘东丂丟丗下丙();
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.上与专上专丞东丄丆(), method:  System.Boolean FortsManager.上与专上专丞东丄丆::丗下丕丒丕丒与丛丈(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟)));
        }
        internal static 丞东丌丟与丅丅万丝 丅丁专丘丛丝丆丙丘(string 丞丅上丏丂且下丅与)
        {
            var val_5;
            if((与丙丅丛不丘一与专.一三专丞丒丅上业上().ContainsKey(key:  丞丅上丏丂且下丅与)) != false)
            {
                    丞东丌丟与丅丅万丝 val_4 = 与丙丅丛不丘一与专.一三专丞丒丅上业上().Item[丞丅上丏丂且下丅与];
                return (丞东丌丟与丅丅万丝)val_5;
            }
            
            val_5 = 0;
            return (丞东丌丟与丅丅万丝)val_5;
        }
        internal static bool 东上万与丟丙丅丆不(string 丞丅上丏丂且下丅与)
        {
            System.Collections.Generic.Dictionary<System.String, 丞东丌丟与丅丅万丝> val_1 = 与丙丅丛不丘一与专.一三专丞丒丅上业上();
            if(val_1 != null)
            {
                    return val_1.ContainsKey(key:  丞丅上丏丂且下丅与);
            }
            
            return val_1.ContainsKey(key:  丞丅上丏丂且下丅与);
        }
        internal bool 丕丌丈丏丙丁丟东丘(string 丞一丁业丄一一业且)
        {
            string val_4;
            var val_5;
            val_4 = 丞一丁业丄一一业且;
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  val_4)) != false)
            {
                    val_4 = this.丒不与与丗丄七三丅.Item[val_4];
                var val_3 = (val_2.Crafted == true) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        internal static int 丌七丐丙丛丄丒且业()
        {
            null = null;
            if(Rilisoft.FortsManager.丙七丟东丑丙丑丆且 != null)
            {
                    return Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Count;
            }
            
            return Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Count;
        }
        internal int 丂丝丂丑丄丑丟丆专()
        {
            return 0;
        }
        internal static bool 丛且一与丑丅下丌丏(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
        {
            var val_2;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return false;
            }
            
            val_2 = null;
            val_2 = null;
            if(Rilisoft.FortsManager.丙七丟东丑丙丑丆且 != null)
            {
                    return Rilisoft.FortsManager.丙七丟东丑丙丑丆且.ContainsValue(value:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
            }
            
            return Rilisoft.FortsManager.丙七丟东丑丙丑丆且.ContainsValue(value:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        }
        internal static Rilisoft.东且东丒丐世丐丞丒 丟丝丌丏一下丒丝丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 val_8;
            丗丞丏丙七丑丕且丐 val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_12;
            val_8 = 与丄不丌一世东丁丙;
            FortsManager.丑三与丒丛业专世与 val_1 = new FortsManager.丑三与丒丛业专世与();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .与丄不丌一世东丁丙 = val_8;
            }
            else
            {
                    val_9 = 16;
                mem[16] = val_8;
                val_8 = mem[16];
            }
            
            if((Rilisoft.FortsManager.丄专与丝上专下东专(与丄不丌一世东丁丙:  val_8)) != false)
            {
                    val_10 = 0;
                return (Rilisoft.东且东丒丐世丐丞丒)System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_12 = val_5.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_6 = null);
            }
            
            val_11 = null;
            val_11 = null;
            val_10 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Item[val_9])) == true)
            {
                    return (Rilisoft.东且东丒丐世丐丞丒)System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_12, predicate:  val_6);
            }
            
            val_12 = val_5.丛不丞丂七丞世丁丏;
            if(val_12 == null)
            {
                    Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.不世丘东丂丟丗下丙();
            }
            
            val_9 = val_6;
            val_6 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丑三与丒丛业专世与::丒万不三专丒上丌万(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七));
            return (Rilisoft.东且东丒丐世丐丞丒)System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_12, predicate:  val_6);
        }
        internal static bool 丄专与丝上专下东专(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            null = null;
            bool val_1 = Rilisoft.FortsManager.丙七丟东丑丙丑丆且.ContainsKey(key:  与丄不丌一世东丁丙);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal static string 业东与东与丝丟七丕(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_3;
            var val_4;
            if((Rilisoft.FortsManager.丄专与丝上专下东专(与丄不丌一世东丁丙:  与丄不丌一世东丁丙)) != false)
            {
                    val_3 = 0;
                return (string)Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Item[与丄不丌一世东丁丙];
            }
            
            val_4 = null;
            val_4 = null;
            return (string)Rilisoft.FortsManager.丙七丟东丑丙丑丆且.Item[与丄不丌一世东丁丙];
        }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 万丂丙丒丒丞丏下下(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗, bool 丁丅丑下丝丆丄下丏 = False)
        {
            System.Linq.IOrderedEnumerable<TSource> val_11;
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_12;
            var val_13;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, ItemRarity> val_15;
            var val_16;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32> val_18;
            var val_19;
            val_11 = this;
            FortsManager.万丐丘不丝一丏丐世 val_1 = new FortsManager.万丐丘不丝一丏丐世();
            val_12 = Rilisoft.FortsManager.一丟丏丕丘丁丏丌七(一丐丅且丛不不丌丗:  一丐丅且丛不不丌丗, 丁丅丑下丝丆丄下丏:  丁丅丑下丝丆丄下丏);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            .丒丆丛上东丝三丟世 = val_12;
            if(val_12 == null)
            {
                goto label_4;
            }
            
            label_17:
            val_12 = this.丛不丞丂七丞世丁丏;
            if(val_12 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_12 = this.丛不丞丂七丞世丁丏;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = FortsManager.<>c.<>9__103_1;
            if(val_15 == null)
            {
                    System.Func<Rilisoft.东且东丒丐世丐丞丒, ItemRarity> val_6 = null;
                val_15 = val_6;
                val_6 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, ItemRarity>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  ItemRarity FortsManager.<>c::七丅丟丏丒丛丄丟且(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
                FortsManager.<>c.<>9__103_1 = val_15;
            }
            
            val_16 = null;
            val_11 = System.Linq.Enumerable.OrderBy<Rilisoft.东且东丒丐世丐丞丒, ItemRarity>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_12, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.万丐丘不丝一丏丐世::丅丟丅专且丐丐下丕(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟))), keySelector:  val_6);
            val_16 = null;
            val_18 = FortsManager.<>c.<>9__103_2;
            if(val_18 == null)
            {
                    System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32> val_8 = null;
                val_18 = val_8;
                val_8 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FortsManager.<>c::丒丑下丌丞丐丕丗丂(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
                FortsManager.<>c.<>9__103_2 = val_18;
            }
            
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.ThenBy<Rilisoft.东且东丒丐世丐丞丒, System.Int32>(source:  val_11, keySelector:  val_8));
            return (System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒>)val_19;
            label_3:
            mem[16] = val_12;
            val_12 = mem[16];
            if(val_12 != 0)
            {
                goto label_17;
            }
            
            label_4:
            val_19 = 0;
            return (System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒>)val_19;
        }
        internal static System.Collections.Generic.List<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> 一丟丏丕丘丁丏丌七(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗, bool 丁丅丑下丝丆丄下丏)
        {
            var val_16;
            object val_23;
            var val_24;
            System.Collections.Generic.List<Rilisoft.丗一且丈上丝下丈丝> val_25;
            var val_26;
            var val_27;
            var val_28;
            System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Collections.Generic.IEnumerable<丗丞丏丙七丑丕且丐>> val_30;
            var val_31;
            var val_32;
            FortsManager.丟丗东丛丘丂丌七丑 val_1 = null;
            val_23 = val_1;
            val_1 = new FortsManager.丟丗东丛丘丂丌七丑();
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_24 = null;
            val_24 = null;
            val_25 = Rilisoft.FortsManager.丅业丟丝丝丘万上丄;
            System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean> val_2 = null;
            val_26 = 1152921542584637648;
            val_2 = new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丟丗东丛丘丂丌七丑::业丐丕三业丈上丐丐(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈));
            Rilisoft.丗一且丈上丝下丈丝 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丗一且丈上丝下丈丝>(source:  val_25, predicate:  val_2);
            .不丝丄丒丌丐一一与 = val_3;
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if(丁丅丑下丝丆丄下丏 == false)
            {
                goto label_34;
            }
            
            val_27 = null;
            val_27 = null;
            val_28 = null;
            val_28 = null;
            val_30 = FortsManager.<>c.<>9__104_2;
            if(val_30 == null)
            {
                    System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Collections.Generic.IEnumerable<丗丞丏丙七丑丕且丐>> val_6 = null;
                val_30 = val_6;
                val_6 = new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Collections.Generic.IEnumerable<丗丞丏丙七丑丕且丐>>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<丗丞丏丙七丑丕且丐> FortsManager.<>c::丄丁丕下丑丈丟丅丅(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈));
                FortsManager.<>c.<>9__104_2 = val_30;
            }
            
            val_31 = null;
            val_32 = System.Linq.Enumerable.ToList<丗丞丏丙七丑丕且丐>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.丗一且丈上丝下丈丝, 丗丞丏丙七丑丕且丐>(source:  System.Linq.Enumerable.Where<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丟丗东丛丘丂丌七丑::万万丈一丟丒丈丆一(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈))), selector:  val_6));
            val_31 = null;
            val_25 = System.Linq.Enumerable.ToList<Rilisoft.丗一且丈上丝下丈丝>(source:  System.Linq.Enumerable.Where<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丟丗东丛丘丂丌七丑::丁丅丒世七专东丟丐(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈))));
            if((FortsManager.丟丗东丛丘丂丌七丑)[1152921542584795024].不丝丄丒丌丐一一与.丈三丒业丑丗丘不东() != null)
            {
                    val_32.AddRange(collection:  (FortsManager.丟丗东丛丘丂丌七丑)[1152921542584795024].不丝丄丒丌丐一一与.丈三丒业丑丗丘不东());
            }
            
            if(val_25 == null)
            {
                    return (System.Collections.Generic.List<丗丞丏丙七丑丕且丐>)val_32;
            }
            
            List.Enumerator<T> val_14 = val_25.GetEnumerator();
            val_26 = 1152921542584701136;
            label_27:
            if(((-676805840) & 1) == 0)
            {
                goto label_20;
            }
            
            Rilisoft.FortItemGroupType val_18 = val_16.丐丏七丌丕丗业且上().世丞丗丏丏丛世丌东();
            if(val_18 == 0)
            {
                goto label_27;
            }
            
            val_32.AddRange(collection:  val_18);
            goto label_27;
            label_4:
            val_32 = 0;
            return (System.Collections.Generic.List<丗丞丏丙七丑丕且丐>)val_32;
            label_20:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<丗丞丏丙七丑丕且丐>)val_32;
            label_34:
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_19 = null;
            val_32 = val_19;
            val_19 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_25 = (FortsManager.丟丗东丛丘丂丌七丑)[1152921542584795024].不丝丄丒丌丐一一与;
            if(val_25.丈三丒业丑丗丘不东() == null)
            {
                    return (System.Collections.Generic.List<丗丞丏丙七丑丕且丐>)val_32;
            }
            
            val_23 = (FortsManager.丟丗东丛丘丂丌七丑)[1152921542584795024].不丝丄丒丌丐一一与.丈三丒业丑丗丘不东();
            val_19.AddRange(collection:  val_23);
            return (System.Collections.Generic.List<丗丞丏丙七丑丕且丐>)val_32;
        }
        internal static bool 业丙丘丟七丕东丞丟(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗, Rilisoft.FortItemGroupType 丁丈东世丗丙丅丌丂)
        {
            var val_6;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_6 = null;
            val_6 = null;
            Rilisoft.丗一且丈上丝下丈丝 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  new FortsManager.丙丁业世一丆下一七(), method:  System.Boolean FortsManager.丙丁业世一丆下一七::丐万世与丈且业丌东(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈)));
            if(val_3 == null)
            {
                    return (bool)(val_3.与一万丆丙东东丏丄() == 丁丈东世丗丙丅丌丂) ? 1 : 0;
            }
            
            return (bool)(val_3.与一万丆丙东东丏丄() == 丁丈东世丗丙丅丌丂) ? 1 : 0;
        }
        internal static Rilisoft.FortItemGroupType 丌丐七丕丅丙不一丐(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗)
        {
            var val_4;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_4 = null;
            val_4 = null;
            Rilisoft.丗一且丈上丝下丈丝 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  new FortsManager.丑且丐丄业且丅业丅(), method:  System.Boolean FortsManager.丑且丐丄业且丅业丅::丐世丒丌丞一丑丟丘(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈)));
            if(val_3 == null)
            {
                    return (Rilisoft.FortItemGroupType)val_3;
            }
            
            return val_3.与一万丆丙东东丏丄();
        }
        internal static System.Collections.Generic.List<Rilisoft.FortItemGroupType> 丞业丘东七丙万丕丂(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗)
        {
            var val_6;
            System.Func<TSource, System.Boolean> val_7;
            var val_8;
            System.Func<Rilisoft.丗一且丈上丝下丈丝, Rilisoft.FortItemGroupType> val_10;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            val_6 = null;
            val_6 = null;
            System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  new FortsManager.东上丁业丆丈丆下下(), method:  System.Boolean FortsManager.东上丁业丆丈丆下下::东丛丏丘丁丝东丝丂(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈));
            val_8 = null;
            val_8 = null;
            val_10 = FortsManager.<>c.<>9__107_1;
            if(val_10 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.FortItemGroupType>(source:  System.Linq.Enumerable.Select<Rilisoft.丗一且丈上丝下丈丝, Rilisoft.FortItemGroupType>(source:  System.Linq.Enumerable.Where<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  val_2), selector:  System.Func<Rilisoft.丗一且丈上丝下丈丝, Rilisoft.FortItemGroupType> val_4 = null));
            }
            
            val_10 = val_4;
            val_4 = new System.Func<Rilisoft.丗一且丈上丝下丈丝, Rilisoft.FortItemGroupType>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.FortItemGroupType FortsManager.<>c::且丌丐东丆专丐丘上(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈));
            FortsManager.<>c.<>9__107_1 = val_10;
            return System.Linq.Enumerable.ToList<Rilisoft.FortItemGroupType>(source:  System.Linq.Enumerable.Select<Rilisoft.丗一且丈上丝下丈丝, Rilisoft.FortItemGroupType>(source:  System.Linq.Enumerable.Where<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  val_2), selector:  val_4));
        }
        internal static Rilisoft.FortItemGroupType 丕丙专丂丛丐与下上(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_4;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_4 = null;
            val_4 = null;
            Rilisoft.丗一且丈上丝下丈丝 val_3 = System.Linq.Enumerable.First<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  new FortsManager.丅丝丒且丄万丛丅丐(), method:  System.Boolean FortsManager.丅丝丒且丄万丛丅丐::丙丆丑丈丅一丐万丛(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈)));
            if(val_3 != null)
            {
                    return val_3.世丞丗丏丏丛世丌东();
            }
            
            return val_3.世丞丗丏丏丛世丌东();
        }
        internal static Rilisoft.FortItemGroupType 丗世丅丕丞丄万不丟(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_7;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_7 = null;
            val_7 = null;
            Rilisoft.FortItemGroupType val_4 = System.Linq.Enumerable.First<Rilisoft.丗一且丈上丝下丈丝>(source:  Rilisoft.FortsManager.丅业丟丝丝丘万上丄, predicate:  new System.Func<Rilisoft.丗一且丈上丝下丈丝, System.Boolean>(object:  new FortsManager.丟一丛丑丘上丗下东(), method:  System.Boolean FortsManager.丟一丛丑丘上丗下东::丒丅万丆丐丅丕丐三(Rilisoft.丗一且丈上丝下丈丝 业七丐世专丝丂丟丈))).世丞丗丏丏丛世丌东();
            Rilisoft.FortItemGroupType val_5 = Rilisoft.FortsManager.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  val_4);
            return (Rilisoft.FortItemGroupType)(val_5 != 0) ? (val_5) : (val_4);
        }
        internal System.Collections.Generic.List<string> 丄不丘东丅三丂世丟()
        {
            var val_4;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.String> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = FortsManager.<>c.<>9__110_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.东且东丒丐世丐丞丒, System.String>(source:  this.丄七丗东万丙丘丆丌(), selector:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.String> val_2 = null));
            }
            
            val_6 = val_2;
            val_2 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.String>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String FortsManager.<>c::丂世业丈丂与上丑一(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            FortsManager.<>c.<>9__110_0 = val_6;
            return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.东且东丒丐世丐丞丒, System.String>(source:  this.丄七丗东万丙丘丆丌(), selector:  val_2));
        }
        internal static bool 丞丑丙一与丐万且下(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, Rilisoft.FortItemGroupType 不丝丄丒丌丐一一与, bool 丌七丅一丘与丅丅丏 = False)
        {
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_2 = Rilisoft.FortsManager.一丟丏丕丘丁丏丌七(一丐丅且丛不不丌丗:  不丝丄丒丌丐一一与, 丁丅丑下丝丆丄下丏:  丌七丅一丘与丅丅丏);
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            return val_2.Contains(item:  与丄不丌一世东丁丙);
        }
        internal System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> 丕丗专丟丕丒丛七丕(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_4;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_4 = this.丛不丞丂七丞世丁丏;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_4 = this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.丗不上丛丟丙与丘丆(), method:  System.Boolean FortsManager.丗不上丛丟丙与丘丆::丌丁丗丄上七丙七丅(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟))));
            }
            
            this.不世丘东丂丟丗下丙();
            return System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_4, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.丗不上丛丟丙与丘丆(), method:  System.Boolean FortsManager.丗不上丛丟丙与丘丆::丌丁丗丄上七丙七丅(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟))));
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丅丟丝丗丌丂且丗一(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_3;
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            val_3 = this.丛不丞丂七丞世丁丏;
            if(val_3 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3 = this.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.丐丙丆丑上三丗丅上(), method:  System.Boolean FortsManager.丐丙丆丑上三丗丅上::丑丞一丏下丏上下丑(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟)));
            }
            
            this.不世丘东丂丟丗下丙();
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  new FortsManager.丐丙丆丑上三丗丅上(), method:  System.Boolean FortsManager.丐丙丆丑上三丗丅上::丑丞一丏下丏上下丑(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟)));
        }
        internal bool 丕丌丈丏丙丁丟东丘(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_3;
            var val_4;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_6;
            val_3 = this.丛不丞丂七丞世丁丏;
            if(val_3 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_3 = this.丛不丞丂七丞世丁丏;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = FortsManager.<>c.<>9__114_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.Contains<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_1 = null), value:  下丅丙一丂丗丅丝七);
            }
            
            val_6 = val_1;
            val_1 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortsManager.<>c::七丟丄东与业三丄丏(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            FortsManager.<>c.<>9__114_0 = val_6;
            return System.Linq.Enumerable.Contains<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_3, predicate:  val_1), value:  下丅丙一丂丗丅丝七);
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丞丏丆丙丁丒丕与丄(string 丞丅上丏丂且下丅与)
        {
            string val_5;
            System.Func<TSource, System.Boolean> val_6;
            var val_7;
            val_5 = 丞丅上丏丂且下丅与;
            val_6 = this;
            FortsManager.丛丘丗世丙丅下上与 val_1 = new FortsManager.丛丘丗世丙丅下上与();
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
                    return (Rilisoft.东且东丒丐世丐丞丒)System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_5 = this.丛不丞丂七丞世丁丏, predicate:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_3 = null);
            }
            
            val_5 = this.丛不丞丂七丞世丁丏;
            if(val_5 == null)
            {
                    this.不世丘东丂丟丗下丙();
            }
            
            val_6 = val_3;
            val_3 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丛丘丗世丙丅下上与::丏上丁丑七三丝丘丄(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            return (Rilisoft.东且东丒丐世丐丞丒)System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  val_5, predicate:  val_3);
        }
        internal Rilisoft.东且东丒丐世丐丞丒 丌丆丙一丟丗丐丞与(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, int 丏世丞丅丁丄丁万丑)
        {
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_6;
            var val_7;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32> val_9;
            FortsManager.丝丄且丟丝丞且丅万 val_1 = new FortsManager.丝丄且丟丝丞且丅万();
            if(val_1 != null)
            {
                    .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            }
            else
            {
                    mem[16] = 与丄不丌一世东丁丙;
            }
            
            .丏世丞丅丁丄丁万丑 = 丏世丞丅丁丄丁万丑;
            val_6 = this.丛不丞丂七丞世丁丏;
            if(val_6 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_6 = this.丛不丞丂七丞世丁丏;
            }
            
            val_7 = null;
            val_7 = null;
            val_9 = FortsManager.<>c.<>9__116_1;
            if(val_9 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.东且东丒丐世丐丞丒, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_6, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丝丄且丟丝丞且丅万::世丄丞丄丞与丕七上(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟))), keySelector:  System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32> val_4 = null));
            }
            
            val_9 = val_4;
            val_4 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Int32>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FortsManager.<>c::丞三专不世上丐万且(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
            FortsManager.<>c.<>9__116_1 = val_9;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.东且东丒丐世丐丞丒, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.东且东丒丐世丐丞丒>(source:  val_6, predicate:  new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  val_1, method:  System.Boolean FortsManager.丝丄且丟丝丞且丅万::世丄丞丄丞与丕七上(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟))), keySelector:  val_4));
        }
        internal System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒> 世下丂丅丒不丄三专(int 丏世丞丅丁丄丁万丑)
        {
            FortsManager.丏丈世丗七丅万丆与 val_1 = new FortsManager.丏丈世丗七丅万丆与();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丏世丞丅丁丄丁万丑 = 丏世丞丅丁丄丁万丑;
            .东且丁丆丛丁丏丘且 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒>();
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<丗丞丏丙七丑丕且丐>(七丐丅专且专七三丆:  new System.Action<丗丞丏丙七丑丕且丐>(object:  val_1, method:  System.Void FortsManager.丏丈世丗七丅万丆与::与七不与上丗丄与丑(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下下丏一丙不丘丌丞)));
            return (System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒>)(FortsManager.丏丈世丗七丅万丆与)[1152921542586891024].东且丁丆丛丁丏丘且;
        }
        internal bool 丆丑下丙专下丒丅丆(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            Rilisoft.FortsManager val_17;
            var val_18;
            var val_19;
            object val_20;
            var val_21;
            val_17 = this;
            FortsManager.丂世丁下东业丘且七 val_1 = new FortsManager.丂世丁下东业丘且七();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = val_17;
            }
            else
            {
                    mem[32] = val_17;
            }
            
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            if(this.丘万万且丂丟丟与丌 != false)
            {
                    val_18 = null;
                val_18 = null;
                val_17 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
                val_17.丄东丘七世世丞不丛();
                return false;
            }
            
            if(this.丄且专与丌专丁丒丒 != false)
            {
                    return false;
            }
            
            this.丄且专与丌专丁丒丒 = true;
            val_19 = null;
            System.Nullable<System.Int64> val_2 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            if((FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七 == null)
            {
                goto label_12;
            }
            
            if((FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七.丑丆丑三且丛上且丟() == false)
            {
                goto label_13;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = (FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "item \'{0}\' is crafting now", args:  val_4);
            goto label_22;
            label_11:
            val_20 = "CurrentTime is null";
            goto label_25;
            label_12:
            val_20 = "item is null";
            label_25:
            UnityEngine.Debug.LogError(message:  val_20);
            label_22:
            this.丄且专与丌专丁丒丒 = false;
            return false;
            label_13:
            .丏业丟一东丂东丘丛 = this.世下丗丆一专丞丂丟(丞一丁业丄一一业且:  (FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
            val_21 = (FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七.丁丞一不不丗丕丟丛();
            if(val_21.Count > 1)
            {
                    System.Nullable<System.Int64> val_11 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
                (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丏业丟一东丂东丘丛.CraftStartedV2 = ;
            }
            else
            {
                    System.Nullable<System.Int64> val_12 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
                (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丏业丟一东丂东丘丛.CraftStarted = ;
            }
            
            this.<丛丄七丟丈丆丒丆丈>k__BackingField = 与丄不丌一世东丁丙;
            this.<丛上丟丏与丕丒东丂>k__BackingField = (FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七;
            (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丏业丟一东丂东丘丛.CraftSlot = 与丄不丌一世东丁丙;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState> val_13 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
            val_13.Add(key:  (FortsManager.丂世丁下东业丘且七)[1152921542587128304].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), value:  (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丏业丟一东丂东丘丛);
            .万世丌东丑且丏丅丏 = 0;
            .丟业丌丅丆与万丈丛 = 0;
            .万世丌东丑且丏丅丏 = new System.Action(object:  val_1, method:  System.Void FortsManager.丂世丁下东业丘且七::业丗丒上丁丐丏业丌());
            .丟业丌丅丆与万丈丛 = new System.Action(object:  val_1, method:  System.Void FortsManager.丂世丁下东业丘且七::丕丆丟丂与且丏七专());
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.业下丅万丝丐专世下(丙业与丙丗丝不丈东:  (FortsManager.丂世丁下东业丘且七)[1152921542587128304].万世丌东丑且丏丅丏);
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丟业丌丅丆与万丈丛);
            (FortsManager.丂世丁下东业丘且七)[1152921542587128304].丟业丌丅丆与万丈丛.丁丈世丐丛世丂丆丝(三万下丂丅丒丐世丐:  val_13, 上丅丏不丗丒丈七丒:  false);
            return false;
        }
        internal bool 丂丗丕三丏丙丕丈一(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
        {
            Rilisoft.FortsManager val_20;
            var val_21;
            var val_22;
            var val_23;
            Rilisoft.FortItemState val_24;
            int val_25;
            var val_26;
            丗丞丏丙七丑丕且丐 val_27;
            val_20 = this;
            FortsManager.丛丐丆丛专世丂丛丟 val_1 = new FortsManager.丛丐丆丛专世丂丛丟();
            if(val_1 != null)
            {
                    val_21 = val_1;
                .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            }
            else
            {
                    val_21 = 16;
                mem[16] = 下丅丙一丂丗丅丝七;
            }
            
            .丝且与丝丒丟万丁专 = val_20;
            if(this.丘万万且丂丟丟与丌 != false)
            {
                    val_22 = null;
                val_22 = null;
                val_20 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
                val_20.丄东丘七世世丞不丛();
                return false;
            }
            
            if(this.丄且专与丌专丁丒丒 != false)
            {
                    return false;
            }
            
            this.丄且专与丌专丁丒丒 = true;
            if(mem[16] == 0)
            {
                goto label_9;
            }
            
            if(mem[16].丕丐丈丁上丞与三丌() == false)
            {
                goto label_10;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = mem[16].丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "item \'{0}\' allready exists", args:  val_3);
            goto label_22;
            label_9:
            UnityEngine.Debug.LogError(message:  "item is null");
            goto label_22;
            label_10:
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                goto label_25;
            }
            
            val_23 = null;
            System.Nullable<System.Int64> val_7 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            .丏业丟一东丂东丘丛 = this.世下丗丆一专丞丂丟(丞一丁业丄一一业且:  mem[16].业上丙丞丐丄丆丅七());
            if(mem[16].丁丞一不不丗丕丟丛().Count <= 1)
            {
                goto label_31;
            }
            
            (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛.CraftStartedV2 = 0;
            goto label_33;
            label_25:
            UnityEngine.Debug.LogWarning(message:  "add fort item: server time is not synchronized, using system time");
            long val_12 = 专七专下且专三一且.上且一丈丐三丄一丆();
            label_22:
            this.丄且专与丌专丁丒丒 = false;
            return false;
            label_31:
            (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛.CraftStarted =  - mem[16].丅丞上丘丆下上丘丅();
            label_33:
            (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛.Crafted = true;
            val_24 = (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛;
            if(val_24 != null)
            {
                    val_25 = (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛.ItemCount;
            }
            else
            {
                    val_24 = 32;
                val_25 = 64;
            }
            
            mem[32] = 65;
            if(mem[16] == (this.<丛上丟丏与丕丒东丂>k__BackingField))
            {
                goto label_44;
            }
            
            val_26 = null;
            val_26 = null;
            val_27 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.丆丘世丛丗丘三丌丙();
            if((FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛 != null)
            {
                goto label_50;
            }
            
            goto label_49;
            label_44:
            val_27 = this.<丛丄七丟丈丆丒丆丈>k__BackingField;
            if((FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛 != null)
            {
                goto label_50;
            }
            
            label_49:
            label_50:
            (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛.CraftSlot = val_27;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState> val_16 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
            val_16.Add(key:  mem[16].业上丙丞丐丄丆丅七(), value:  (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丏业丟一东丂东丘丛);
            .万世丌东丑且丏丅丏 = 0;
            .丟业丌丅丆与万丈丛 = 0;
            .万世丌东丑且丏丅丏 = new System.Action(object:  val_1, method:  System.Void FortsManager.丛丐丆丛专世丂丛丟::丆东专且丆下丟丄丗());
            .丟业丌丅丆与万丈丛 = new System.Action(object:  val_1, method:  System.Void FortsManager.丛丐丆丛专世丂丛丟::丕丙丌不上丏且一丕());
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.业下丅万丝丐专世下(丙业与丙丗丝不丈东:  (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].万世丌东丑且丏丅丏);
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丟业丌丅丆与万丈丛);
            (FortsManager.丛丐丆丛专世丂丛丟)[1152921542587427040].丟业丌丅丆与万丈丛.丁丈世丐丛世丂丆丝(三万下丂丅丒丐世丐:  val_16, 上丅丏不丗丒丈七丒:  false);
            return false;
        }
        internal bool 丛下丛七上上上丛丐(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, bool 上丅丏不丗丒丈七丒 = False)
        {
            丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 val_18;
            Rilisoft.FortCraftController val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            object val_25;
            Rilisoft.FortItemState val_26;
            int val_27;
            Rilisoft.FortItemState val_28;
            var val_29;
            val_18 = 与丄不丌一世东丁丙;
            FortsManager.丘丒丘世万丁且下丈 val_1 = null;
            val_19 = val_1;
            val_1 = new FortsManager.丘丒丘世万丁且下丈();
            if(val_19 != null)
            {
                    val_20 = val_19;
                .上丅丏不丗丒丈七丒 = 上丅丏不丗丒丈七丒;
                val_21 = 1152921542587721488;
                mem[1152921542587721496] = 下丅丙一丂丗丅丝七;
                mem[1152921542587721520] = this;
            }
            else
            {
                    val_20 = 16;
                mem[16] = 上丅丏不丗丒丈七丒;
                val_21 = 24;
                mem[24] = 下丅丙一丂丗丅丝七;
                mem[48] = this;
            }
            
            .与丄不丌一世东丁丙 = val_18;
            if(this.丘万万且丂丟丟与丌 == false)
            {
                goto label_3;
            }
            
            val_22 = null;
            val_22 = null;
            val_19 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            val_19.丄东丘七世世丞不丛();
            label_26:
            val_23 = 0;
            return (bool)val_23;
            label_3:
            if(val_20 == false)
            {
                goto label_8;
            }
            
            this.丘万万且丂丟丟与丌 = true;
            label_27:
            val_24 = null;
            System.Nullable<System.Int64> val_4 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            if(val_21 == 0)
            {
                goto label_12;
            }
            
            if(val_21.丕丐丈丁上丞与三丌() == false)
            {
                goto label_13;
            }
            
            object[] val_6 = new object[1];
            val_19 = val_6;
            val_18 = mem[24].丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            val_19[0] = val_18;
            UnityEngine.Debug.LogErrorFormat(format:  "item \'{0}\' is crafted", args:  val_6);
            goto label_22;
            label_11:
            val_25 = "CurrentTime is null";
            goto label_25;
            label_8:
            bool val_18 = this.丄且专与丌专丁丒丒;
            val_18 = val_18 + 7;
            var val_19 = ~val_18;
            val_19 = val_19 & 7;
            if(val_19 != 0)
            {
                goto label_26;
            }
            
            this.丄且专与丌专丁丒丒 = true;
            goto label_27;
            label_12:
            val_25 = "item is null";
            label_25:
            UnityEngine.Debug.LogError(message:  val_25);
            label_22:
            val_23 = 0;
            this.丄且专与丌专丁丒丒 = false;
            return (bool)val_23;
            label_13:
            .丏业丟一东丂东丘丛 = this.世下丗丆一专丞丂丟(丞一丁业丄一一业且:  mem[24].业上丙丞丐丄丆丅七());
            val_10.Crafted = true;
            val_26 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛;
            if(val_26 != null)
            {
                    val_27 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛.ItemCount;
            }
            else
            {
                    val_26 = 32;
                val_27 = 64;
            }
            
            mem[32] = 65;
            (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛.CraftSlot = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].与丄不丌一世东丁丙;
            .丛上不万业上专世专 = 0;
            if(mem[24].丁丞一不不丗丕丟丛().Count < 2)
            {
                goto label_37;
            }
            
            val_28 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛;
            if(val_28 == null)
            {
                goto label_38;
            }
            
            .丛上不万业上专世专 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛.CraftStartedV2;
            goto label_39;
            label_38:
            val_28 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛;
            .丛上不万业上专世专 = (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛.CraftStartedV2;
            if((FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛 == null)
            {
                goto label_40;
            }
            
            label_39:
            (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛.CraftStartedV2 = 0;
            label_37:
            System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState> val_13 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
            val_13.Add(key:  mem[24].业上丙丞丐丄丆丅七(), value:  (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丏业丟一东丂东丘丛);
            .万世丌东丑且丏丅丏 = 0;
            .丟业丌丅丆与万丈丛 = 0;
            .万世丌东丑且丏丅丏 = new System.Action(object:  val_1, method:  System.Void FortsManager.丘丒丘世万丁且下丈::丁丅三丒与丝丟一丗());
            .丟业丌丅丆与万丈丛 = new System.Action(object:  val_1, method:  System.Void FortsManager.丘丒丘世万丁且下丈::不丙丏下三不丕不不());
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.业下丅万丝丐专世下(丙业与丙丗丝不丈东:  (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].万世丌东丑且丏丅丏);
            if(mem[16] != false)
            {
                    val_29 = 1;
            }
            else
            {
                    PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丟业丌丅丆与万丈丛);
            }
            
            (FortsManager.丘丒丘世万丁且下丈)[1152921542587721472].丟业丌丅丆与万丈丛.丁丈世丐丛世丂丆丝(三万下丂丅丒丐世丐:  val_13, 上丅丏不丗丒丈七丒:  (mem[16] == true) ? 1 : 0);
            return (bool)val_23;
            label_40:
        }
        internal void 丛上丑下丐丄丘丗七(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙 = 0, bool 上丅丏不丗丒丈七丒 = False)
        {
            var val_29;
            var val_30;
            string val_31;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_33;
            string val_34;
            FortsManager.业丏丏丏世三丈丐一 val_1 = new FortsManager.业丏丏丏世三丈丐一();
            if(val_1 != null)
            {
                    val_29 = val_1;
                .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
                mem[1152921542588090544] = this;
            }
            else
            {
                    mem[32] = this;
                val_29 = 40;
                mem[40] = 与丄不丌一世东丁丙;
            }
            
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            if(this.丘万万且丂丟丟与丌 != false)
            {
                    val_30 = null;
                val_30 = null;
                Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.丄东丘七世世丞不丛();
                return;
            }
            
            if(this.丄且专与丌专丁丒丒 == true)
            {
                    return;
            }
            
            this.丄且专与丌专丁丒丒 = true;
            if(((FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].下丅丙一丂丗丅丝七 == null) || (((FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].下丅丙一丂丗丅丝七.且丅一一三七专丑丏() == false) || (this.东丛丐丄丅专丕丑丒 == null)))
            {
                goto label_10;
            }
            
            .丅三丂万丅丘丄东万 = 0;
            .与世丐丙丞万丕世东 = "";
            Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            val_31 = mem[40].ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem[40] = null;
            if((val_3.东丛丐丄丅专丕丑丒.ContainsKey(key:  val_31)) == false)
            {
                goto label_15;
            }
            
            FortsManager.丄且丁丘丟丌丑丞东 val_6 = new FortsManager.丄且丁丘丟丌丑丞东();
            Rilisoft.FortsManager val_7 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            val_31 = mem[40];
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem[40] = null;
            val_32 = val_7.东丛丐丄丅专丕丑丒.Item[mem[40].ToString()];
            if(val_32 == null)
            {
                goto label_23;
            }
            
            val_32 = 0;
            goto label_23;
            label_10:
            this.丄且专与丌专丁丒丒 = false;
            return;
            label_15:
            .丅三丂万丅丘丄东万 = 0;
            goto label_37;
            label_23:
            .专丘丘丗万一业下丆 = ;
            if(val_6 == null)
            {
                    val_32 = (FortsManager.丄且丁丘丟丌丑丞东)[1152921542588119184].专丘丘丗万一业下丆;
            }
            
            if((val_32.ContainsKey(key:  "id")) != false)
            {
                    val_33 = this.丛不丞丂七丞世丁丏;
                if(val_33 == null)
            {
                    this.不世丘东丂丟丗下丙();
                val_33 = this.丛不丞丂七丞世丁丏;
            }
            
                System.Predicate<Rilisoft.东且东丒丐世丐丞丒> val_13 = null;
                val_31 = val_13;
                val_13 = new System.Predicate<Rilisoft.东且东丒丐世丐丞丒>(object:  val_6, method:  System.Boolean FortsManager.丄且丁丘丟丌丑丞东::专不丗丌世业一丂不(Rilisoft.东且东丒丐世丐丞丒 三丟东丕丄丄下下丑));
                Rilisoft.东且东丒丐世丐丞丒 val_14 = System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  val_33).Find(match:  val_13);
                .丅三丂万丅丘丄东万 = val_14;
                if(val_14 != null)
            {
                    val_34 = val_14.业上丙丞丐丄丆丅七();
                .与世丐丙丞万丕世东 = val_34;
            }
            else
            {
                    val_34 = (FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].与世丐丙丞万丕世东;
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_34)) != false)
            {
                    Rilisoft.东且东丒丐世丐丞丒 val_17 = Rilisoft.FortsManager.丟丝丌丏一下丒丝丛(与丄不丌一世东丁丙:  mem[40]);
                if(val_17 != null)
            {
                    .与世丐丙丞万丕世东 = val_17.业上丙丞丐丄丆丅七();
            }
            
            }
            
            }
            
            label_37:
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem[40] = null;
                if((this.东丛丐丄丅专丕丑丒.ContainsKey(key:  mem[40].ToString())) != false)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem[40] = null;
                bool val_22 = this.东丛丐丄丅专丕丑丒.Remove(key:  mem[40].ToString());
            }
            
                System.Collections.Generic.Dictionary<System.String, System.Object> val_23 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_23.Add(key:  "id", value:  (FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
                val_31 = mem[40];
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem[40] = null;
                this.东丛丐丄丅专丕丑丒.Add(key:  mem[40].ToString(), value:  val_23);
            }
            
            .万世丌东丑且丏丅丏 = 0;
            .丟业丌丅丆与万丈丛 = 0;
            .万世丌东丑且丏丅丏 = new System.Action(object:  val_1, method:  System.Void FortsManager.业丏丏丏世三丈丐一::丁丈丈丘丛丘丕东丆());
            .丟业丌丅丆与万丈丛 = new System.Action(object:  val_1, method:  System.Void FortsManager.业丏丏丏世三丈丐一::专三世上丏上丄世三());
            PGCompany.Clans.Network.三与丞不下丆且丑世.世东丄丌丞且丁丆东(丙业与丙丗丝不丈东:  (FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].万世丌东丑且丏丅丏);
            if(上丅丏不丗丒丈七丒 != true)
            {
                    PGCompany.Clans.Network.三与丞不下丆且丑世.下丞世丏丐上丑专丁(丙业与丙丗丝不丈东:  (FortsManager.业丏丏丏世三丈丐一)[1152921542588090512].丟业丌丅丆与万丈丛);
            }
            
            this.丏丐业一丆丙丛七丗(上丅丏不丗丒丈七丒:  上丅丏不丗丒丈七丒);
        }
        internal void 丂丂丘与与丂下丞丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_33;
            var val_34;
            FortsManager.丆丕丒不丕不丘丞丒 val_1 = new FortsManager.丆丕丒不丕不丘丞丒();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .与丄不丌一世东丁丙 = 与丄不丌一世东丁丙;
            if(this.丘万万且丂丟丟与丌 != false)
            {
                    val_28 = null;
                val_28 = null;
                Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.丄东丘七世世丞不丛();
                return;
            }
            
            if(this.丄且专与丌专丁丒丒 == true)
            {
                    return;
            }
            
            this.丄且专与丌专丁丒丒 = true;
            Rilisoft.东且东丒丐世丐丞丒 val_2 = this.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  (FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].与丄不丌一世东丁丙);
            .丅三丂万丅丘丄东万 = val_2;
            if(val_2 == null)
            {
                goto label_8;
            }
            
            .丌三世丟丂丙下丘专 = val_2.业上丙丞丐丄丆丅七();
            if((FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].丅三丂万丅丘丄东万 == null)
            {
                    return;
            }
            
            val_29 = 1152921505444278272;
            if((Rilisoft.FortsManager.丄专与丝上专下东专(与丄不丌一世东丁丙:  (FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].与丄不丌一世东丁丙)) == false)
            {
                goto label_12;
            }
            
            FortsManager.丏丑丕丁丛专专丏不 val_5 = new FortsManager.丏丑丕丁丛专专丏不();
            .丕丏丘上业下不丛丙 = val_1;
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                    val_29 = (FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].与丄不丌一世东丁丙;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                if((this.东丛丐丄丅专丕丑丒.ContainsKey(key:  (FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].与丄不丌一世东丁丙.ToString())) != false)
            {
                    val_29 = (FortsManager.丏丑丕丁丛专专丏不)[1152921542588546576].丕丏丘上业下不丛丙.与丄不丌一世东丁丙;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                bool val_9 = this.东丛丐丄丅专丕丑丒.Remove(key:  (FortsManager.丏丑丕丁丛专专丏不)[1152921542588546576].丕丏丘上业下不丛丙.与丄不丌一世东丁丙.ToString());
            }
            
            }
            
            .与丈三万丐丌世东丅 = 0;
            .丙东丝丁丂丝丟专一 = 0;
            .与丈三万丐丌世东丅 = new System.Action(object:  val_5, method:  System.Void FortsManager.丏丑丕丁丛专专丏不::世丕丑丂丟丄且业丝());
            .丙东丝丁丂丝丟专一 = new System.Action(object:  val_5, method:  System.Void FortsManager.丏丑丕丁丛专专丏不::三专丗丝且专七丂三());
            label_71:
            PGCompany.Clans.Network.三与丞不下丆且丑世.世东丄丌丞且丁丆东(丙业与丙丗丝不丈东:  (FortsManager.丏丑丕丁丛专专丏不)[1152921542588546576].与丈三万丐丌世东丅);
            label_72:
            PGCompany.Clans.Network.三与丞不下丆且丑世.下丞世丏丐上丑专丁(丙业与丙丗丝不丈东:  (FortsManager.丏丑丕丁丛专专丏不)[1152921542588546576].丙东丝丁丂丝丟专一);
            this.丏丐业一丆丙丛七丗(上丅丏不丗丒丈七丒:  false);
            return;
            label_12:
            if((Rilisoft.FortsManager.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  (FortsManager.丆丕丒不丕不丘丞丒)[1152921542588522000].丅三丂万丅丘丄东万)) == false)
            {
                goto label_24;
            }
            
            label_8:
            this.丄且专与丌专丁丒丒 = false;
            return;
            label_24:
            FortsManager.丅丙上业丂丂丌一丛 val_13 = new FortsManager.丅丙上业丂丂丌一丛();
            if(val_13 != null)
            {
                    val_30 = val_13;
                .东丟且丗且三专丙丁 = val_1;
            }
            else
            {
                    val_30 = 24;
                mem[24] = val_1;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_14 = Rilisoft.FortsManager.丟丝丌丏一下丒丝丛(与丄不丌一世东丁丙:  .与丄不丌一世东丁丙);
            if(val_13 == null)
            {
                goto label_30;
            }
            
            .丄不丒业不一丗丅丙 = val_14;
            if(val_14 != null)
            {
                goto label_31;
            }
            
            return;
            label_30:
            mem[16] = val_14;
            if(mem[16] == 0)
            {
                    return;
            }
            
            label_31:
            FortsManager.丄三丈丛七不丛丆丒 val_15 = new FortsManager.丄三丈丛七不丛丆丒();
            if(val_15 != null)
            {
                    val_31 = val_15;
                .丕丅丏丁丅东且七丌 = val_13;
                val_32 = this;
                val_33 = this.东丛丐丄丅专丕丑丒;
            }
            else
            {
                    val_31 = 32;
                mem[32] = val_13;
                val_32 = this;
                val_33 = this.东丛丐丄丅专丕丑丒;
            }
            
            string val_16 = 0x10000008D7E25E10.与丄不丌一世东丁丙.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            if(val_33 == null)
            {
                goto label_40;
            }
            
            if((val_33.ContainsKey(key:  val_16)) != false)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                bool val_19 = this.东丛丐丄丅专丕丑丒.Remove(key:  0x10000008D7E25E10.与丄不丌一世东丁丙.ToString());
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_20.Add(key:  "id", value:  .丄不丒业不一丗丅丙.业上丙丞丐丄丆丅七());
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            this.东丛丐丄丅专丕丑丒.Add(key:  0x10000008D7E25E10.与丄不丌一世东丁丙.ToString(), value:  val_20);
            if(val_15 != null)
            {
                goto label_58;
            }
            
            goto label_67;
            label_40:
            if((val_33.ContainsKey(key:  val_16)) != false)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                bool val_25 = this.东丛丐丄丅专丕丑丒.Remove(key:  0x10000008D7E25E10.与丄不丌一世东丁丙.ToString());
            }
            
            if(val_15 == null)
            {
                goto label_67;
            }
            
            label_58:
            val_34 = val_15;
            .万业且一七业丒丏丕 = 0;
            goto label_68;
            label_67:
            val_34 = 16;
            mem[16] = 0;
            label_68:
            .丒丝丌丕丑下丝丈业 = 0;
            System.Action val_26 = new System.Action(object:  val_15, method:  System.Void FortsManager.丄三丈丛七不丛丆丒::丙丕丟丄丛丐丑丝丂());
            mem[16] = val_26;
            System.Action val_27 = new System.Action(object:  val_15, method:  System.Void FortsManager.丄三丈丛七不丛丆丒::丞丝丐丗一专丑丟上());
            if(val_15 == null)
            {
                goto label_70;
            }
            
            .丒丝丌丕丑下丝丈业 = val_27;
            goto label_71;
            label_70:
            .丒丝丌丕丑下丝丈业 = val_27;
            PGCompany.Clans.Network.三与丞不下丆且丑世.世东丄丌丞且丁丆东(丙业与丙丗丝不丈东:  val_26);
            goto label_72;
        }
        private void Update()
        {
            var val_7;
            var val_8;
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            val_7 = null;
            val_7 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = 0;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != val_9)
            {
                    val_10 = null;
                val_10 = null;
                val_9 = 0;
                if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.isActiveAndEnabled == false)
            {
                    return;
            }
            
            }
            
            val_11 = null;
            System.Nullable<System.Int64> val_4 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
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
            
            if(this.丄且专与丌专丁丒丒 == true)
            {
                    return;
            }
            
            if(this.丘万万且丂丟丟与丌 == true)
            {
                    return;
            }
            
            bool val_6 = this.丛下丛七上上上丛丐(下丅丙一丂丗丅丝七:  this.<丛上丟丏与丕丒东丂>k__BackingField, 与丄不丌一世东丁丙:  this.<丛丄七丟丈丆丒丆丈>k__BackingField, 上丅丏不丗丒丈七丒:  true);
        }
        private void OnApplicationPause(bool 丆丕与三丝丙丑丛三)
        {
        
        }
        private void OnDestroy()
        {
        
        }
        private void 不世丘东丂丟丗下丙()
        {
            var val_5;
            var val_27;
            var val_28;
            var val_29;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_31;
            var val_32;
            this.丛不丞丂七丞世丁丏 = new System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒>();
            Dictionary.Enumerator<TKey, TValue> val_3 = 与丙丅丛不丘一与专.一三专丞丒丅上业上().GetEnumerator();
            val_27 = 1152921505446141952;
            label_6:
            if(((-672353376) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
            new Rilisoft.东且东丒丐世丐丞丒() = new Rilisoft.东且东丒丐世丐丞丒(东一丁世丑丞业丄丐:  val_7._value._obj);
            this.丛不丞丂七丞世丁丏.Add(item:  new Rilisoft.东且东丒丐世丐丞丒());
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.东丛丐丄丅专丕丑丒 != null)
            {
                goto label_14;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = null;
            val_27 = 1152921516595667312;
            val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            this.东丛丐丄丅专丕丑丒 = val_9;
            val_28 = null;
            val_28 = null;
            Dictionary.Enumerator<TKey, TValue> val_10 = Rilisoft.FortsManager.丙七丟东丑丙丑丆且.GetEnumerator();
            label_22:
            if(((-672353440) & 1) == 0)
            {
                goto label_18;
            }
            
            ConfiguredValueTaskAwaiter val_11 = val_5.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "id", value:  val_11._value._obj);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.东丛丐丄丅专丕丑丒.Add(key:  val_11._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  null);
            goto label_22;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.世上丁丏世万且下业();
            label_14:
            val_29 = null;
            val_29 = null;
            val_31 = FortsManager.<>c.<>9__126_0;
            if(val_31 == null)
            {
                    System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_15 = null;
                val_31 = val_15;
                val_15 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortsManager.<>c::业万丟万丑丗丘丘不(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
                FortsManager.<>c.<>9__126_0 = val_31;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_16 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.东且东丒丐世丐丞丒>(source:  this.丛不丞丂七丞世丁丏, predicate:  val_15);
            this.<丛上丟丏与丕丒东丂>k__BackingField = val_16;
            if(val_16 == null)
            {
                goto label_40;
            }
            
            if((val_16.丁丞一不不丗丕丟丛() == null) || ((this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Count) < 1))
            {
                goto label_44;
            }
            
            val_31 = this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Contains(item:  this.<丛上丟丏与丕丒东丂>k__BackingField.丏世丛丂与丐丟与丏());
            if((this.<丛上丟丏与丕丒东丂>k__BackingField) == null)
            {
                goto label_48;
            }
            
            if(val_31 == false)
            {
                goto label_49;
            }
            
            label_52:
            丗丞丏丙七丑丕且丐 val_23 = this.<丛上丟丏与丕丒东丂>k__BackingField.丏世丛丂与丐丟与丏();
            goto label_51;
            label_44:
            val_32 = 1023;
            goto label_51;
            label_48:
            if(val_31 == true)
            {
                goto label_52;
            }
            
            label_49:
            label_51:
            this.<丛丄七丟丈丆丒丆丈>k__BackingField = this.<丛上丟丏与丕丒东丂>k__BackingField.丁丞一不不丗丕丟丛().Item[0];
            label_40:
            this.丝专丞丈丂东丝丈丌(丙业与丙丗丝不丈东:  true);
            this.丘万万且丂丟丟与丌 = false;
            this.丄且专与丌专丁丒丒 = false;
        }
        internal static void 丞下丟丅丅丅与七丕(System.Action<丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortsManager.丄丂丞丒丝业世不丕, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丄丂丞丒丝业世不丕 != 1152921505444282448);
        
        }
        internal static void 丝下世丐丏丌丁不丄(System.Action<丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortsManager.丄丂丞丒丝业世不丕, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortsManager.丄丂丞丒丝业世不丕 != 1152921505444282448);
        
        }
        internal static float 丒丈东丟丁七丏万下(丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 丏丟丌丙丏丏丒三丆)
        {
            Rilisoft.FortsManager val_1 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_1.丛与丙东不三丏业上 == null)
            {
                    return 0f;
            }
            
            Rilisoft.FortsManager val_2 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_2.丛与丙东不三丏业上.Count < 1)
            {
                    return 0f;
            }
            
            Rilisoft.FortsManager val_4 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if((val_4.丛与丙东不三丏业上.ContainsKey(key:  丏丟丌丙丏丏丒三丆)) == false)
            {
                    return 0f;
            }
            
            Rilisoft.FortsManager val_6 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_6.丛与丙东不三丏业上 != null)
            {
                    return val_6.丛与丙东不三丏业上.Item[丏丟丌丙丏丏丒三丆];
            }
            
            return val_6.丛与丙东不三丏业上.Item[丏丟丌丙丏丏丒三丆];
        }
        private void 世丗丏丂丅丘且上丏()
        {
            var val_5;
            var val_14;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            this.丛与丙东不三丏业上 = new System.Collections.Generic.Dictionary<且丟世丆丑丞丄三三, System.Single>();
            if(this.丘丝一丕丂七七七丂 == null)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丘丝一丕丂七七七丂.GetEnumerator();
            val_27 = 0;
            val_28 = 0;
            var val_26 = 0;
            label_15:
            if(((-671549024) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            List.Enumerator<T> val_7 = val_6._value._obj.GetEnumerator();
            label_7:
            if(((-671549072) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Object.Destroy(obj:  val_5.丐丏七丌丕丗业且上());
            goto label_7;
            label_4:
            val_26 = val_26 + 1;
            mem2[0] = 93;
            val_29 = val_28;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_26 == 1) || ((1152921542590003456 + ((0 + 1)) << 2) != 93))
            {
                goto label_12;
            }
            
            var val_27 = 0;
            val_27 = val_27 ^ (val_26 >> 31);
            val_26 = val_26 + val_27;
            goto label_15;
            label_12:
            if( == 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_1:
            val_28 = 0;
            val_30 = 0;
            goto label_25;
            label_2:
            val_30 = val_26 + 1;
            mem2[0] = 118;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_26 != 1) && ((1152921542590003456 + ((0 + 1)) << 2) == 118))
            {
                    var val_28 = 0;
                val_28 = val_28 ^ (val_26 >> 31);
                val_30 = val_26 + val_28;
            }
            else
            {
                    if( != 0)
            {
                    val_28 = 0;
            }
            
            }
            
            label_25:
            this.丘丝一丕丂七七七丂 = new System.Collections.Generic.Dictionary<Rilisoft.东且东丒丐世丐丞丒, System.Collections.Generic.List<Rilisoft.FortItemEffectHandler>>();
            List.Enumerator<T> val_12 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄七丗东万丙丘丆丌().GetEnumerator();
            label_36:
            if(((-671549104) & 1) == 0)
            {
                goto label_28;
            }
            
            string val_15 = val_14.丐丏七丌丕丗业且上();
            if(val_15.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万() == null)
            {
                goto label_36;
            }
            
            FortItemBuff[] val_19 = val_15.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万();
            if(val_19.Length == 0)
            {
                goto label_36;
            }
            
            this.丁丕专且丄丘丄东万(三丐业七丘丂丐下丘:  val_15);
            goto label_36;
            label_28:
            val_26 = val_26 + 1;
            mem2[0] = 218;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_26 == 1)
            {
                goto label_45;
            }
            
            if(( == 0) || ((1152921542590003456 + (((0 + 1) + 1)) << 2) == 218))
            {
                goto label_53;
            }
            
            label_52:
            label_53:
            Rilisoft.FortsManager.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortsManager::丒且东丘专七业丌丒(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)));
            Rilisoft.FortsManager.东与丐东下丈七不丒(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortsManager::丒且东丘专七业丌丒(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)));
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丛上丐丑丙三万丒丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::世丗丏丂丅丘且上丏()));
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丛丁丞专七丛世三不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortsManager::世丗丏丂丅丘且上丏()));
            return;
            label_45:
            if( != 0)
            {
                goto label_52;
            }
            
            goto label_53;
        }
        private void 丒且东丘专七业丌丒(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)
        {
            this.丅丘不下丆丆丝丂不(三丐业七丘丂丐下丘:  丌丏丗与丕丈丄三丈);
            this.丁丕专且丄丘丄东万(三丐业七丘丂丐下丘:  丏一丕东丙丆与丒丄);
        }
        private void 丁丕专且丄丘丄东万(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            System.Collections.Generic.Dictionary<Rilisoft.东且东丒丐世丐丞丒, System.Collections.Generic.List<Rilisoft.FortItemEffectHandler>> val_10;
            var val_11;
            float val_12;
            float val_13;
            var val_14;
            if(三丐业七丘丂丐下丘 == null)
            {
                    return;
            }
            
            val_10 = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑();
            if(val_10.丞一下丐丟丏下丅万() == null)
            {
                    return;
            }
            
            val_10 = this.丘丝一丕丂七七七丂;
            if((val_10.ContainsKey(key:  三丐业七丘丂丐下丘)) != true)
            {
                    val_10 = this.丘丝一丕丂七七七丂;
                val_10.Add(key:  三丐业七丘丂丐下丘, value:  this.丒且丘三丄丆丕丞且(三丐业七丘丂丐下丘:  三丐业七丘丂丐下丘));
            }
            
            val_11 = 0;
            goto label_8;
            label_25:
            FortItemBuff val_10 = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            if((this.丛与丙东不三丏业上.ContainsKey(key:  val_6[0x0][0].BuffType)) != false)
            {
                    val_12 = this.丛与丙东不三丏业上.Item[val_6[0x0][0].BuffType];
                val_13 = val_12 + val_6[0x0][0].Value;
                this.丛与丙东不三丏业上.set_Item(key:  val_6[0x0][0].BuffType, value:  val_13);
            }
            else
            {
                    val_12 = val_6[0x0][0].Value;
                val_13 = val_12;
                this.丛与丙东不三丏业上.Add(key:  val_6[0x0][0].BuffType, value:  val_13);
            }
            
            val_14 = null;
            val_14 = null;
            val_10 = Rilisoft.FortsManager.丄丂丞丒丝业世不丕;
            if(val_10 != null)
            {
                    val_10 = Rilisoft.FortsManager.丄丂丞丒丝业世不丕;
                val_12 = this.丛与丙东不三丏业上.Item[val_6[0x0][0].BuffType];
                val_10.Invoke(arg1:  val_6[0x0][0].BuffType, arg2:  val_12);
            }
            
            val_11 = 1;
            label_8:
            if(val_11 < val_6.Length)
            {
                goto label_25;
            }
        
        }
        private void 丅丘不下丆丆丝丂不(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            var val_7;
            System.Collections.Generic.Dictionary<Rilisoft.东且东丒丐世丐丞丒, System.Collections.Generic.List<Rilisoft.FortItemEffectHandler>> val_16;
            System.Collections.Generic.Dictionary<且丟世丆丑丞丄三三, System.Single> val_17;
            var val_18;
            float val_19;
            var val_20;
            if(三丐业七丘丂丐下丘 == null)
            {
                    return;
            }
            
            val_16 = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑();
            if(val_16.丞一下丐丟丏下丅万() == null)
            {
                    return;
            }
            
            val_16 = this.丘丝一丕丂七七七丂;
            if((val_16.ContainsKey(key:  三丐业七丘丂丐下丘)) == false)
            {
                goto label_5;
            }
            
            List.Enumerator<T> val_5 = this.丘丝一丕丂七七七丂.Item[三丐业七丘丂丐下丘].GetEnumerator();
            val_17 = 1152921542589854544;
            label_10:
            if(((-670656992) & 1) == 0)
            {
                goto label_8;
            }
            
            if(val_7.丐丏七丌丕丗业且上() != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_16 = this.丘丝一丕丂七七七丂;
            bool val_9 = val_16.Remove(key:  三丐业七丘丂丐下丘);
            label_5:
            val_18 = 0;
            goto label_17;
            label_32:
            FortItemBuff val_15 = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            val_16 = this.丛与丙东不三丏业上;
            if((val_16.ContainsKey(key:  val_11[0x0][0].BuffType)) != false)
            {
                    float val_13 = this.丛与丙东不三丏业上.Item[val_11[0x0][0].BuffType];
                val_19 = val_13;
                val_13 = val_19 - val_11[0x0][0].Value;
                this.丛与丙东不三丏业上.set_Item(key:  val_11[0x0][0].BuffType, value:  val_13);
                val_20 = null;
                val_20 = null;
                val_16 = Rilisoft.FortsManager.丄丂丞丒丝业世不丕;
                if(val_16 != null)
            {
                    val_16 = Rilisoft.FortsManager.丄丂丞丒丝业世不丕;
                val_17 = this.丛与丙东不三丏业上;
                val_19 = val_17.Item[val_11[0x0][0].BuffType];
                val_16.Invoke(arg1:  val_11[0x0][0].BuffType, arg2:  val_19);
            }
            
            }
            
            val_18 = 1;
            label_17:
            if(val_18 < val_11.Length)
            {
                goto label_32;
            }
        
        }
        private System.Collections.Generic.List<Rilisoft.FortItemEffectHandler> 丒且丘三丄丆丕丞且(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            System.Collections.Generic.List<Rilisoft.FortItemEffectHandler> val_1 = new System.Collections.Generic.List<Rilisoft.FortItemEffectHandler>();
            if(三丐业七丘丂丐下丘 == null)
            {
                    return val_1;
            }
            
            if(三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万() == null)
            {
                    return val_1;
            }
            
            val_11 = 0;
            goto label_5;
            label_23:
            FortItemBuff val_11 = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
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
            val_12 = 1152921542591224144;
            goto label_14;
            label_8:
            UnityEngine.GameObject val_7 = this.gameObject;
            val_12 = 1152921542591241552;
            goto label_14;
            label_9:
            UnityEngine.GameObject val_8 = this.gameObject;
            val_12 = 1152921542591223120;
            label_14:
            val_13 = 0.AddComponent<Rilisoft.FortItemEffectFreeSpins>();
            goto label_16;
            label_10:
            val_13 = 0;
            label_16:
            if(val_13 != 0)
            {
                    val_13.Initialize(三丐业七丘丂丐下丘:  三丐业七丘丂丐下丘);
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
        internal System.Collections.Generic.IEnumerable<Rilisoft.FortItemState> 上世丕丞上丗世三丟()
        {
            if(this.丒不与与丗丄七三丅 != null)
            {
                    return this.丒不与与丗丄七三丅.Values;
            }
            
            return this.丒不与与丗丄七三丅.Values;
        }
        internal void 丈且丆丅且丛丒丐丅(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.东丆七丟丙丘丒丏丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丆七丟丙丘丒丏丄 != 1152921542591635096);
        
        }
        internal void 丟七世万东丐丌丐丕(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.东丆七丟丙丘丒丏丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丆七丟丙丘丒丏丄 != 1152921542591771672);
        
        }
        internal Rilisoft.FortItemState 丁丟业丝丐业东丟丈(string 丞一丁业丄一一业且)
        {
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.FortItemState>(source:  this.上世丕丞上丗世三丟(), predicate:  new System.Func<Rilisoft.FortItemState, System.Boolean>(object:  new FortsManager.丗丝丈丛东丝东丁丅(), method:  System.Boolean FortsManager.丗丝丈丛东丝东丁丅::下东丏且丞丈丗与专(Rilisoft.FortItemState 七丞丙丒三丕且丌丟)));
        }
        internal bool 世丟丐丕东世业业丅(string 丞一丁业丄一一业且, out Rilisoft.FortItemState 东且丁丆丛丁丏丘且)
        {
            var val_4;
            if((this.丒不与与丗丄七三丅.TryGetValue(key:  丞一丁业丄一一业且, value: out  Rilisoft.FortItemState val_1 = 东且丁丆丛丁丏丘且)) != false)
            {
                    var val_3 = (val_1 != 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        internal void 丗且且丘丐三丙丆丁(System.Collections.Generic.Dictionary<string, int> 丌丄万上丙万丄丒七)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_18;
            if(丌丄万上丙万丄丒七 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = 丌丄万上丙万丄丒七.GetEnumerator();
            label_10:
            if(((-669331456) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if((this.丒不与与丗丄七三丅.ContainsKey(key:  val_5._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_4;
            }
            
            Rilisoft.FortItemState val_9 = this.丒不与与丗丄七三丅.Item[val_5._value._obj.丐丏七丌丕丗业且上()];
            val_9.PartsExists = 1152921542592221168 + val_9.PartsExists;
            goto label_10;
            label_4:
            new Rilisoft.FortItemState() = new System.Object();
            .ItemId = val_5._value._obj.丐丏七丌丕丗业且上();
            .PartsExists = val_5._value._obj;
            this.丒不与与丗丄七三丅.Add(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  new Rilisoft.FortItemState());
            goto label_10;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(丌丄万上丙万丄丒七.Count < 1)
            {
                    return;
            }
            
            this.世上丁丏世万且下业();
            BalanceController.丙丏丂下丂上七不一();
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_15 = null;
            val_18 = val_15;
            val_15 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            val_15.Add(key:  "details", value:  丌丄万上丙万丄丒七);
            Rilisoft.Singleton<ClansController>.Instance.丑丂一万专与丐丟不(七与丆业丆与丗丑丘:  val_15);
            if(this.东丆七丟丙丘丒丏丄 == null)
            {
                    return;
            }
            
            this.东丆七丟丙丘丒丏丄.Invoke();
        }
        internal int 丐丛业丅丟上丘丟东(string 丞一丁业丄一一业且)
        {
            string val_4;
            int val_5;
            val_4 = 丞一丁业丄一一业且;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true)
            {
                    if((this.丒不与与丗丄七三丅.ContainsKey(key:  val_4)) != false)
            {
                    val_4 = this.丒不与与丗丄七三丅.Item[val_4];
                val_5 = val_3.PartsExists;
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public FortsManager()
        {
            this.丕丟丘丒世与三丘丝 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  "fortitemplaced");
            this.下上丟丑丝上万丙三 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  "fort-data");
            this.东丛丐丄丅专丕丑丒 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            this.丒不与与丗丄七三丅 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
        }
        private static FortsManager()
        {
            Rilisoft.FortsManager.一丑不丐丌丁一上丒 = new System.Collections.Generic.List<Rilisoft.FortItemGroupType>();
            System.Collections.Generic.List<Rilisoft.丗一且丈上丝下丈丝> val_2 = new System.Collections.Generic.List<Rilisoft.丗一且丈上丝下丈丝>();
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  3, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  4, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  3));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  10, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  3));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_6 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_6.Add(item:  1020);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  28, 下丟丕丛不丈一业三:  val_6, 丁丈东世丗丙丅丌丂:  3));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_8 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_8.Add(item:  253);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  29, 下丟丕丛不丈一业三:  val_8, 丁丈东世丗丙丅丌丂:  3));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_10 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_10.Add(item:  0);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  5, 下丟丕丛不丈一业三:  val_10, 丁丈东世丗丙丅丌丂:  4));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_12 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_12.Add(item:  2);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  6, 下丟丕丛不丈一业三:  val_12, 丁丈东世丗丙丅丌丂:  4));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_14 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_14.Add(item:  1);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  7, 下丟丕丛不丈一业三:  val_14, 丁丈东世丗丙丅丌丂:  4));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_16 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_16.Add(item:  233);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  8, 下丟丕丛不丈一业三:  val_16, 丁丈东世丗丙丅丌丂:  4));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_18 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_18.Add(item:  250);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  9, 下丟丕丛不丈一业三:  val_18, 丁丈东世丗丙丅丌丂:  4));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_20 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_20.Add(item:  247);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  27, 下丟丕丛不丈一业三:  val_20, 丁丈东世丗丙丅丌丂:  10));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  12, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  10));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_23 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_23.Add(item:  3);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  25, 下丟丕丛不丈一业三:  val_23, 丁丈东世丗丙丅丌丂:  10));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_25 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_25.Add(item:  251);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  26, 下丟丕丛不丈一业三:  val_25, 丁丈东世丗丙丅丌丂:  10));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  13, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  12));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  15, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  12));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  14, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  12));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  16, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  12));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_31 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_31.Add(item:  237);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  17, 下丟丕丛不丈一业三:  val_31, 丁丈东世丗丙丅丌丂:  13));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_33 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_33.Add(item:  235);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  19, 下丟丕丛不丈一业三:  val_33, 丁丈东世丗丙丅丌丂:  15));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_35 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_35.Add(item:  238);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  18, 下丟丕丛不丈一业三:  val_35, 丁丈东世丗丙丅丌丂:  14));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_37 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_37.Add(item:  236);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  20, 下丟丕丛不丈一业三:  val_37, 丁丈东世丗丙丅丌丂:  16));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_39 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_39.Add(item:  245);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  21, 下丟丕丛不丈一业三:  val_39, 丁丈东世丗丙丅丌丂:  13));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_41 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_41.Add(item:  243);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  23, 下丟丕丛不丈一业三:  val_41, 丁丈东世丗丙丅丌丂:  15));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_43 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_43.Add(item:  246);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  22, 下丟丕丛不丈一业三:  val_43, 丁丈东世丗丙丅丌丂:  14));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_45 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_45.Add(item:  244);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  24, 下丟丕丛不丈一业三:  val_45, 丁丈东世丗丙丅丌丂:  16));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_47 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_47.Add(item:  232);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  1, 下丟丕丛不丈一业三:  val_47, 丁丈东世丗丙丅丌丂:  0));
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  30, 下丟丕丛不丈一业三:  0, 丁丈东世丗丙丅丌丂:  0));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_50 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_50.Add(item:  8);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  31, 下丟丕丛不丈一业三:  val_50, 丁丈东世丗丙丅丌丂:  30));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_52 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_52.Add(item:  4);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  11, 下丟丕丛不丈一业三:  val_52, 丁丈东世丗丙丅丌丂:  30));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_54 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_54.Add(item:  6);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  32, 下丟丕丛不丈一业三:  val_54, 丁丈东世丗丙丅丌丂:  30));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_56 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_56.Add(item:  7);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  33, 下丟丕丛不丈一业三:  val_56, 丁丈东世丗丙丅丌丂:  30));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_58 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_58.Add(item:  249);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  34, 下丟丕丛不丈一业三:  val_58, 丁丈东世丗丙丅丌丂:  30));
            System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_60 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            val_60.Add(item:  1022);
            val_2.Add(item:  new Rilisoft.丗一且丈上丝下丈丝(一丐丅且丛不不丌丗:  35, 下丟丕丛不丈一业三:  val_60, 丁丈东世丗丙丅丌丂:  30));
            Rilisoft.FortsManager.丅业丟丝丝丘万上丄 = val_2;
            System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String> val_62 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String>();
            if(val_62 != null)
            {
                    val_62.Add(key:  0, value:  "fort_defaultfort");
            }
            else
            {
                    val_62.Add(key:  0, value:  "fort_defaultfort");
            }
            
            val_62.Add(key:  4, value:  "fort_footpath");
            if(val_62 != null)
            {
                    val_62.Add(key:  1, value:  "fort_defaultgates");
            }
            else
            {
                    val_62.Add(key:  1, value:  "fort_defaultgates");
            }
            
            val_62.Add(key:  3, value:  "fort_moat_water");
            if(val_62 != null)
            {
                    val_62.Add(key:  2, value:  "fort_defaultwalls");
            }
            else
            {
                    val_62.Add(key:  2, value:  "fort_defaultwalls");
            }
            
            val_62.Add(key:  6, value:  "fort_desert");
            if(val_62 != null)
            {
                    val_62.Add(key:  8, value:  "fort_cloudy_day");
            }
            else
            {
                    val_62.Add(key:  8, value:  "fort_cloudy_day");
            }
            
            val_62.Add(key:  7, value:  "fort_background_desert");
            val_62.Add(key:  232, value:  "fort_simpleram_ram");
            Rilisoft.FortsManager.丙七丟东丑丙丑丆且 = val_62;
            Rilisoft.FortsManager.丛业不丏丒丄丐丑丈 = new System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒>();
        }
    
    }

}
