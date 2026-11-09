using UnityEngine;

namespace PGCompany
{
    internal sealed class 丒丒丛丙不万专三丆
    {
        // Fields
        private const PGCompany.丏丆丕丘丟丙丈丕丛 丏丒丞不丛丅上丟丆 = 2;
        private const string 丐业七丘下丟丝丗丗 = "ConfigSystem.RetrievedConfigIndex";
        private static PGCompany.丒丒丛丙不万专三丆 世丒丞七专三与万丕;
        private static System.Collections.Generic.Dictionary<string, PGCompany.ConfigId> 专七三专下万万与与;
        private static string 丒丒下丛丆东七万上;
        private PGCompany.EmbeddedConfig 丞世上万丑不丁丝七;
        private PGCompany.丏丆丕丘丟丙丈丕丛 东下丞专丂丑丕丌三;
        private System.Collections.Generic.Dictionary<string, object> 一丈丅丅丞丛丛不万;
        private UnityEngine.Coroutine 三丈丏丗丐丗上丙丄;
        private bool 丌丐万且丌丑一丛丕;
        private bool 丕不丛业一丏丏丑且;
        private static System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> <丝丝丂下世丂世丂丒>k__BackingField;
        private System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> 丄且丂丈丙丝与下丕;
        private System.EventHandler 丐丑丟丅丞不丒丈丂;
        
        // Properties
        internal static PGCompany.丒丒丛丙不万专三丆 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal static System.Collections.Generic.Dictionary<string, PGCompany.ConfigId> 七丈丂丞丆丅万业丒 { get; }
        internal static System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 丏丕丙丞上万丂业不 { get; set; }
        internal PGCompany.丏丆丕丘丟丙丈丕丛 丆下丄七丝丁丝三不 { get; }
        internal PGCompany.丏丆丕丘丟丙丈丕丛 业丞东下一世专业丞 { set; }
        private PGCompany.EmbeddedConfig 丌七丝丗世三丕东与 { get; }
        private System.Collections.Generic.Dictionary<string, object> 丌丑丁三丈丁丈丏丞 { get; }
        
        // Methods
        private 丒丒丛丙不万专三丆()
        {
            var val_3;
            业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丒丒丛丙不万专三丆::丆三丁丂三丙七丐一()));
            val_3 = null;
            val_3 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.与丟丕丒七丆丕与一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.丒丒丛丙不万专三丆::与丝三不丈东丈三东(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        internal static PGCompany.丒丒丛丙不万专三丆 丑七不且上丗丁一世()
        {
            PGCompany.丒丒丛丙不万专三丆 val_2 = PGCompany.丒丒丛丙不万专三丆.世丒丞七专三与万丕;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.丒丒丛丙不万专三丆 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丒丒丛丙不万专三丆();
            PGCompany.丒丒丛丙不万专三丆.世丒丞七专三与万丕 = val_2;
            return val_2;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal static System.Collections.Generic.Dictionary<string, PGCompany.ConfigId> 下丝丁业万丌三世业()
        {
            if(PGCompany.丒丒丛丙不万专三丆.专七三专下万万与与 != null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, PGCompany.ConfigId> val_1 = PGCompany.丒丒丛丙不万专三丆.丕丘丏专专业万与丌();
            PGCompany.丒丒丛丙不万专三丆.专七三专下万万与与 = val_1;
            return val_1;
        }
        internal static System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 丟丄丑丙与丏七丕丏()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>>)PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField;
        }
        internal static void 丝丄丒丑上万丙且丝(System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 丙业与丙丗丝不丈东)
        {
            PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.丏丆丕丘丟丙丈丕丛 丟东丒三一丐业且专()
        {
            return (PGCompany.丏丆丕丘丟丙丈丕丛)((this.东下丞专丂丑丕丌三 - 1) < 2) ? this.东下丞专丂丑丕丌三 : 2;
        }
        internal void 业七丝专下丑上丙七(PGCompany.丏丆丕丘丟丙丈丕丛 丙业与丙丗丝不丈东)
        {
            var val_8;
            if(this.东下丞专丂丑丕丌三 == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this.东下丞专丂丑丕丌三 = 丙业与丙丗丝不丈东;
            if((((this.东下丞专丂丑丕丌三 - 1) < 2) ? this.东下丞专丂丑丕丌三 : 2) == (((丙业与丙丗丝不丈东 - 1) < 2) ? 丙业与丙丗丝不丈东 : 2))
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_6 = new object[2];
                val_6[0] = this.GetType();
                val_6[1] = this.东下丞专丂丑丕丌三;
                UnityEngine.Debug.LogFormat(format:  "[{0}] RawMode => rawMode: {1}", args:  val_6);
            }
            
            if(this.丐丑丟丅丞不丒丈丂 == null)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            this.丐丑丟丅丞不丒丈丂.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        private PGCompany.EmbeddedConfig 一一丂与下七丈三丁()
        {
            if(this.丞世上万丑不丁丝七 != null)
            {
                    return val_1;
            }
            
            PGCompany.EmbeddedConfig val_1 = PGCompany.丒丒丛丙不万专三丆.东且丙丞丞丑丝丄万();
            this.丞世上万丑不丁丝七 = val_1;
            return val_1;
        }
        private System.Collections.Generic.Dictionary<string, object> 丝丞丟丗且丗上且丙()
        {
            if(this.一丈丅丅丞丛丛不万 != null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = PGCompany.丒丒丛丙不万专三丆.丗业业丈专丛丞三与();
            this.一丈丅丅丞丛丛不万 = val_1;
            return val_1;
        }
        internal void 丗丈下上丙下七丙下(System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄且丂丈丙丝与下丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄且丂丈丙丝与下丕 != 1152921555201344280);
        
        }
        internal void 丛丌丌且下丌丌丂丅(System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄且丂丈丙丝与下丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄且丂丈丙丝与下丕 != 1152921555201480856);
        
        }
        internal void 丙丗丂丙七丁丈万丗(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丐丑丟丅丞不丒丈丂, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丑丟丅丞不丒丈丂 != 1152921555201617440);
        
        }
        internal void 丅丘三丈丄丒三三丞(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丐丑丟丅丞不丒丈丂, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丑丟丅丞不丒丈丂 != 1152921555201754016);
        
        }
        internal string 丘丑下丆上业丛一丄(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            if(丈丄丈世一且不不丁 == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            return this.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  丈丄丈世一且不不丁, 丒丗丁与丅丏丂丕且:  PGCompany.丒丒丛丙不万专三丆.丅丙丑丒丈不上丂丘(丞丅上丏丂且下丅与:  丈丄丈世一且不不丁));
        }
        internal byte[] 丞万丏丁万不丅且丝(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            if(丈丄丈世一且不不丁 == 0)
            {
                    return 0;
            }
            
            return this.丈与与丌丏下丕丗丐(丈丄丈世一且不不丁:  丈丄丈世一且不不丁);
        }
        internal void 不世丐丄丛与上专万()
        {
            if(this.丞世上万丑不丁丝七 != 0)
            {
                    return;
            }
            
            this.丞世上万丑不丁丝七 = PGCompany.丒丒丛丙不万专三丆.东且丙丞丞丑丝丄万();
        }
        private static System.Collections.Generic.Dictionary<string, object> 丗业业丈专丛丞三与()
        {
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ConfigSystem.RetrievedConfigIndex")) == false)
            {
                goto label_3;
            }
            
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "ConfigSystem.RetrievedConfigIndex"));
            if(val_3 == null)
            {
                goto label_8;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_3;
            label_3:
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ConfigSystem.RetrievedConfigIndex", 下下丏一丙不丘丌丞:  System.String.alignConst);
            label_8:
            if((PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不()) == null)
            {
                
            }
        
        }
        private static PGCompany.ConfigId 丞丂万丝丌丝丝丆万(string 丛丄业丕且丗下一万)
        {
            if((System.String.IsNullOrEmpty(value:  丛丄业丕且丗下一万)) == true)
            {
                    return (PGCompany.ConfigId)0;
            }
            
            PGCompany.ConfigId val_3 = 0;
            bool val_4 = PGCompany.丒丒丛丙不万专三丆.下丝丁业万丌三世业().TryGetValue(key:  丛丄业丕且丗下一万, value: out  val_3);
            0 = val_3;
            return (PGCompany.ConfigId)0;
        }
        private static string 业丁丟丐专一七丟三(string 丒丗丁与丅丏丂丕且)
        {
            return "ConfigSystem.Path." + 丒丗丁与丅丏丂丕且;
        }
        private static string 丟万丏丒专丑一世丅(string 丒丗丁与丅丏丂丕且)
        {
            return "ConfigSystem.Version." + 丒丗丁与丅丏丂丕且;
        }
        private string 丘丑下丆上业丛一丄(PGCompany.ConfigId 丈丄丈世一且不不丁, string 丒丗丁与丅丏丂丕且)
        {
            string val_11;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
            var val_13;
            val_11 = 丒丗丁与丅丏丂丕且;
            val_12 = this.一丈丅丅丞丛丛不万;
            if(val_12 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = PGCompany.丒丒丛丙不万专三丆.丗业业丈专丛丞三与();
                this.一丈丅丅丞丛丛不万 = val_1;
                if(val_1 == null)
            {
                    val_12 = 0;
            }
            
            }
            
            if((val_12.ContainsKey(key:  val_11)) == false)
            {
                    return this.丞丏世丏丂丘丄丝上(丈丄丈世一且不不丁:  丈丄丈世一且不不丁);
            }
            
            string val_3 = PGCompany.丒丒丛丙不万专三丆.丟万丏丒专丑一世丅(丒丗丁与丅丏丂丕且:  val_11);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_3)) == false)
            {
                goto label_6;
            }
            
            val_13 = null;
            val_13 = null;
            if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_3), b:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒)) == true)
            {
                    return this.丞丏世丏丂丘丄丝上(丈丄丈世一且不不丁:  丈丄丈世一且不不丁);
            }
            
            string val_7 = PGCompany.丒丒丛丙不万专三丆.业丁丟丐专一七丟三(丒丗丁与丅丏丂丕且:  val_11);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_7)) == false)
            {
                goto label_22;
            }
            
            string val_9 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_7);
            val_11 = val_9;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                    return this.丞丏世丏丂丘丄丝上(丈丄丈世一且不不丁:  丈丄丈世一且不不丁);
            }
            
            return (string)val_11;
            label_6:
            val_11 = System.String.alignConst;
            label_22:
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  val_11);
            return this.丞丏世丏丂丘丄丝上(丈丄丈世一且不不丁:  丈丄丈世一且不不丁);
        }
        private byte[] 丈与与丌丏下丕丗丐(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            bool val_10;
            var val_11;
            System.Byte[] val_2 = 0;
            string val_3 = 0;
            val_10 = PGCompany.三丏与丌丘丙丌丕万.丑七不且上丗丁一世().丅下上丕丞与不丘万(丈丄丈世一且不不丁:  丈丄丈世一且不不丁, 下丗丈丈一三下上丈: out  val_2, 丏丞专丏业丗丝七丝: out  val_3);
            if(PGCompany.丒丒丛丙不万专三丆.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ConfigSystem.GetBinaryConfigCore", arg1:  "TryLoadConfigOrFallback", arg2:  val_10));
            }
            
            if(val_10 != false)
            {
                    val_11 = val_2;
                return (System.Byte[])val_11;
            }
            
            object[] val_8 = new object[4];
            val_8[0] = "ConfigSystem.GetBinaryConfigCore";
            val_8[1] = 丈丄丈世一且不不丁;
            val_8[2] = "explanation";
            val_8[3] = val_3;
            val_10 = System.String.Format(format:  "[{0}] Failed to load config: {1}, {2}: {3}", args:  val_8);
            UnityEngine.Debug.LogWarning(message:  val_10);
            val_11 = 0;
            return (System.Byte[])val_11;
        }
        private static PGCompany.EmbeddedConfig 东且丙丞丞丑丝丄万()
        {
            return UnityEngine.Resources.Load<PGCompany.EmbeddedConfig>(path:  PGCompany.丒丒丛丙不万专三丆.丏上丈丝丗丂丈七一());
        }
        private static PGCompany.丏丆丕丘丟丙丈丕丛 东丘世东丕丁丁丈丏(PGCompany.丏丆丕丘丟丙丈丕丛 丆下丙下丐丙丂丒丏)
        {
            return (PGCompany.丏丆丕丘丟丙丈丕丛)((丆下丙下丐丙丂丒丏 - 1) < 2) ? 丆下丙下丐丙丂丒丏 : 2;
        }
        private void 丆三丁丂三丙七丐一()
        {
            var val_12;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    object[] val_2 = new object[1];
                val_2[0] = this.GetType();
                val_12 = 0;
                UnityEngine.Debug.LogFormat(format:  "<color=white>[{0}] OnA_uthorized</color>", args:  val_2);
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> val_4 = this.丒万丐不专上丞丙丛();
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_12 = 0;
                object[] val_9 = new object[2];
                val_9[0] = this.GetType();
                val_9[1] = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4);
                UnityEngine.Debug.LogFormat(format:  "<color=white>[{0}] Config groups: {1}</color>", args:  val_9);
            }
            
            if(this.三丈丏丗丐丗上丙丄 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.三丈丏丗丐丗上丙丄);
                this.三丈丏丗丐丗上丙丄 = 0;
            }
            
            this.三丈丏丗丐丗上丙丄 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丙丏一上丒与丅丞万(三万丟丁万丄一三丛:  val_4));
        }
        private System.Collections.IEnumerator 丙丏一上丒与丅丞万(System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 三万丟丁万丄一三丛)
        {
            丒丒丛丙不万专三丆.丈下丝与且丈丞丝丞 val_1 = new 丒丒丛丙不万专三丆.丈下丝与且丈丞丝丞();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .三万丟丁万丄一三丛 = 三万丟丁万丄一三丛;
            return (System.Collections.IEnumerator)val_1;
        }
        internal void 一丏东东丗七东丞丙(PGCompany.ConfigId 丏世丑万世一七丟丞, string 丌丄丟丂丆丑下丐世)
        {
            if(this.丄且丂丈丙丝与下丕 == null)
            {
                    return;
            }
            
            this.丄且丂丈丙丝与下丕.Invoke(sender:  this, e:  new PGCompany.丏专丆丒丏丗丞丐丘(丈丄丈世一且不不丁:  丏世丑万世一七丟丞, 丒丗丁与丅丏丂丕且:  丌丄丟丂丆丑下丐世));
        }
        private void 与丝三不丈东丈三东(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            object val_16;
            object val_85;
            object val_86;
            var val_87;
            var val_88;
            var val_90;
            var val_92;
            PGCompany.七丑一上且三世丝三<K, V> val_93;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_95;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_96;
            object val_97;
            PGCompany.东丑丒丗一丞下丙丙<T> val_101;
            var val_102;
            System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_103;
            val_85 = 不丅丕丏下丏万丁丅;
            val_86 = this;
            object val_28 = 0;
            string val_42 = 0;
            this.丕不丛业一丏丏丑且 = false;
            if(val_85 == null)
            {
                goto label_1;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_88 = 0;
                UnityEngine.Debug.Log(message:  "[ConfigSystem.OnWebS_ocketCallback] responseKeysString: "("[ConfigSystem.OnWebS_ocketCallback] responseKeysString: ") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  PGCompany.丟一丘丄三丘丄丒丄.丕丗丏丘丛丌与丟丒<System.String>(丈丆丕与丒丌丘丕且:  val_85.Keys))(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  PGCompany.丟一丘丄三丘丄丒丄.丕丗丏丘丛丌与丟丒<System.String>(丈丆丕与丒丌丘丕且:  val_85.Keys))));
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    val_88 = 0;
                UnityEngine.Debug.Log(message:  "[ConfigSystem.OnWebS_ocketCallback] responseDictionaryString: "("[ConfigSystem.OnWebS_ocketCallback] responseDictionaryString: ") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_85)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_85)));
            }
            
            int val_10 = val_85.Count;
            PGCompany.东丑丒丗一丞下丙丙<T> val_11 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.丏专丆丒丏丗丞丐丘>.万世丅七一专丕丞不();
            int val_12 = val_85.Count;
            Dictionary.Enumerator<TKey, TValue> val_13 = val_85.GetEnumerator();
            label_111:
            if(((-942338224) & 1) == 0)
            {
                goto label_16;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_16.GetAwaiter();
            if((PGCompany.丒丒丛丙不万专三丆.丞丂万丝丌丝丝丆万(丛丄业丕且丗下一万:  val_17._value._obj.丐丏七丌丕丗业且上())) == 0)
            {
                goto label_17;
            }
            
            if(val_17._value._obj != 0)
            {
                    val_90 = ((-942338240) == 0) ? 0 : -942338240.GetType();
            }
            
            UnityEngine.Debug.Log(message:  "[ConfigSystem.OnWebS_ocketCallback] Unexpected entry. " + val_17._value._obj.丐丏七丌丕丗业且上() + ": "(": ") + (val_90 == 0) ? "null" : (val_90)((val_90 == 0) ? "null" : (val_90)));
            goto label_111;
            label_17:
            object[] val_25 = new object[4];
            val_25[0] = "ConfigSystem.OnWebS_ocketCallback";
            val_25[1] = "configId";
            val_16 = 0;
            val_25[2] = val_16;
            val_25[3] = val_17._value._obj.丐丏七丌丕丗业且上();
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "[{0}] Unknown {1}: {2}, Key: {3}", args:  val_25));
            goto label_111;
            label_1:
            UnityEngine.Debug.LogError(message:  "[ConfigSystem.OnWebS_ocketCallback] responseDictionary: null");
            return;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_92 = 1152921505171275776;
            val_93 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            Dictionary.Enumerator<TKey, TValue> val_70 = GetEnumerator();
            label_179:
            if(((-942338224) & 1) == 0)
            {
                goto label_176;
            }
            
            ConfiguredValueTaskAwaiter val_71 = val_16.GetAwaiter();
            val_95 = this.一丈丅丅丞丛丛不万;
            if(val_95 == null)
            {
                    val_95 = PGCompany.丒丒丛丙不万专三丆.丗业业丈专丛丞三与();
                this.一丈丅丅丞丛丛不万 = val_95;
            }
            
            val_95.set_Item(key:  val_71._value._obj.丐丏七丌丕丗业且上(), value:  val_71._value._obj);
            goto label_179;
            label_176:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.七丑一上且三世丝三<K, V> val_74 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            val_96 = this.一丈丅丅丞丛丛不万;
            if(val_96 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_75 = PGCompany.丒丒丛丙不万专三丆.丗业业丈专丛丞三与();
                this.一丈丅丅丞丛丛不万 = val_75;
            }
            
            val_97 = 0;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ConfigSystem.RetrievedConfigIndex", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_75));
            List.Enumerator<T> val_77 = val_11.GetEnumerator();
            val_87 = "ConfigId";
            val_85 = "[{0}] Failed to invoke handler for {1}: {2}";
            goto label_202;
            label_213:
            string val_78 = val_16.丐丏七丌丕丗业且上();
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_16 = val_78.丐丂丏丑丄丑丛丂丝();
                val_97 = "ConfigId";
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] Invoking handler for {1}: {2}", arg0:  "ConfigSystem.OnWebS_ocketCallback", arg1:  val_97, arg2:  val_16));
            }
            
            if(this.丄且丂丈丙丝与下丕 != null)
            {
                    val_97 = val_78;
                this.丄且丂丈丙丝与下丕.Invoke(sender:  this, e:  val_97);
            }
            
            label_202:
            if(((-942338336) & 1) != 0)
            {
                goto label_213;
            }
            
            val_101 = val_11;
            val_102 = 0;
            val_103 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_223;
            }
            
            if(( == 0) || (1096 == 1096))
            {
                goto label_230;
            }
            
            label_229:
            val_97 = 0;
            label_230:
            val_86 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.丏专丆丒丏丗丞丐丘>.万世丅七一专丕丞不();
            return;
            label_223:
            if( != 0)
            {
                goto label_229;
            }
            
            goto label_230;
        }
        private static bool 与一丟与下丛下丛丟(object 丄三丅七丆丛与与上, out int 丙业与丙丗丝不丈东, out System.Exception 世丝丒丙下东丗丙上)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Convert.ChangeType(value:  丄三丅七丆丛与与上, conversionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), provider:  System.Globalization.CultureInfo.InvariantCulture));
            丙业与丙丗丝不丈东 = null;
            世丝丒丙下东丗丙上 = 0;
            return true;
        }
        private string 丆下业丌与七丗世丝(string 丒丗丁与丅丏丂丕且)
        {
            string val_10;
            int val_11;
            var val_12;
            string val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  丒丗丁与丅丏丂丕且)) != false)
            {
                    val_11 = System.String.alignConst;
                return (string)val_11;
            }
            
            val_10 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  PGCompany.丒丒丛丙不万专三丆.丟万丏丒专丑一世丅(丒丗丁与丅丏丂丕且:  丒丗丁与丅丏丂丕且));
            val_12 = null;
            val_12 = null;
            if((丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒.Equals(value:  val_10, comparisonType:  4)) != false)
            {
                    val_10 = this.一丈丅丅丞丛丛不万;
                if(val_10 == null)
            {
                    val_10 = PGCompany.丒丒丛丙不万专三丆.丗业业丈专丛丞三与();
                this.一丈丅丅丞丛丛不万 = val_10;
            }
            
                val_11 = val_6;
                if(val_11 != 0)
            {
                    if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_10, 下上丐丆丝丟丝丒不:  丒丗丁与丅丏丂丕且, 丙业与丙丗丝不丈东: out  val_6)) == true)
            {
                    return (string)val_11;
            }
            
            }
            
            }
            
            val_11 = this.丐丟丈丘丏丕七丞丑(丈丄丈世一且不不丁:  PGCompany.丒丒丛丙不万专三丆.丞丂万丝丌丝丝丆万(丛丄业丕且丗下一万:  丒丗丁与丅丏丂丕且));
            return (string)val_11;
        }
        private System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 丒万丐不专上丞丙丛()
        {
            System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> val_11;
            var val_12;
            System.Func<System.Collections.Generic.List<PGCompany.ConfigId>, System.Collections.Generic.IEnumerable<PGCompany.ConfigId>> val_14;
            var val_15;
            if(this.丌丐万且丌丑一丛丕 != true)
            {
                    FriendsController.丞丘丁业丙专且一世();
                this.丌丐万且丌丑一丛丕 = true;
            }
            
            val_11 = PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField;
            System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>>();
            Dictionary.ValueCollection<TKey, TValue> val_3 = PGCompany.丒丒丛丙不万专三丆.下丝丁业万丌三世业().Values;
            if(val_11 == null)
            {
                goto label_6;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = 丒丒丛丙不万专三丆.<>c.<>9__53_0;
            if(val_14 == null)
            {
                    System.Func<System.Collections.Generic.List<PGCompany.ConfigId>, System.Collections.Generic.IEnumerable<PGCompany.ConfigId>> val_4 = null;
                val_14 = val_4;
                val_4 = new System.Func<System.Collections.Generic.List<PGCompany.ConfigId>, System.Collections.Generic.IEnumerable<PGCompany.ConfigId>>(object:  丒丒丛丙不万专三丆.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<PGCompany.ConfigId> 丒丒丛丙不万专三丆.<>c::丄丕丒下丞丝丙三且(System.Collections.Generic.List<PGCompany.ConfigId> 三丟东丕丄丄下下丑));
                丒丒丛丙不万专三丆.<>c.<>9__53_0 = val_14;
            }
            
            val_1.Add(item:  System.Linq.Enumerable.ToList<PGCompany.ConfigId>(source:  System.Linq.Enumerable.Except<PGCompany.ConfigId>(first:  val_3, second:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<PGCompany.ConfigId>, PGCompany.ConfigId>(source:  PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField, selector:  val_4))));
            val_15 = 0;
            val_11 = 93233;
            goto label_14;
            label_20:
            val_1.Add(item:  PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField.Item[0]);
            val_15 = 1;
            label_14:
            if(val_15 < (PGCompany.丒丒丛丙不万专三丆.<丝丝丂下世丂世丂丒>k__BackingField.Count))
            {
                goto label_20;
            }
            
            return val_1;
            label_6:
            val_1.Add(item:  System.Linq.Enumerable.ToList<PGCompany.ConfigId>(source:  val_3));
            return val_1;
        }
        internal static string 丐丑丈丘丑丄专丘丄()
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true)
            {
                    if(PGCompany.丄丝东丌丛业丂业丛.三丈上丅专丕丗世丏() == false)
            {
                goto label_4;
            }
            
            }
            
            return "Test";
            label_4:
            UnityEngine.RuntimePlatform val_3 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            if(val_3 == 8)
            {
                    return "Test";
            }
            
            if(val_3 != 11)
            {
                    return "Test";
            }
            
            丏丆丙专丂东丆丐丟 val_4 = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
            if(val_4 == 2)
            {
                    return "Test";
            }
            
            if(val_4 != 1)
            {
                    return "Test";
            }
            
            return "Test";
        }
        private static string 丏上丈丝丗丂丈七一()
        {
            if(PGCompany.丒丒丛丙不万专三丆.丒丒下丛丆东七万上 != null)
            {
                    return val_1;
            }
            
            string val_1 = PGCompany.丒丒丛丙不万专三丆.专业丑业与不丞丅丂();
            PGCompany.丒丒丛丙不万专三丆.丒丒下丛丆东七万上 = val_1;
            return val_1;
        }
        private static string 专业丑业与不丞丅丂()
        {
            string val_1 = PGCompany.丒丒丛丙不万专三丆.丐丑丈丘丑丄专丘丄();
            if((System.String.IsNullOrEmpty(value:  val_1)) == false)
            {
                    return "EmbeddedConfig." + val_1;
            }
            
            return (string)System.String.alignConst;
        }
        internal static string 丅丙丑丒丈不上丂丘(PGCompany.ConfigId 丞丅上丏丂且下丅与)
        {
            if((丞丅上丏丂且下丅与 - 1) > 142)
            {
                    return (string);
            }
            
            var val_2 = 106033168;
            val_2 = (106033168 + ((丞丅上丏丂且下丅与 - 1)) << 2) + val_2;
            goto (106033168 + ((丞丅上丏丂且下丅与 - 1)) << 2 + 106033168);
        }
        private static System.Collections.Generic.Dictionary<string, PGCompany.ConfigId> 丕丘丏专专业万与丌()
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.ConfigId> val_2 = new System.Collections.Generic.Dictionary<System.String, PGCompany.ConfigId>(comparer:  System.StringComparer.Ordinal);
            if(val_2 != null)
            {
                    val_2.Add(key:  "advert-v7", value:  1);
            }
            else
            {
                    val_2.Add(key:  "advert-v7", value:  1);
            }
            
            val_2.Add(key:  "events-v43", value:  2);
            if(val_2 != null)
            {
                    val_2.Add(key:  "battlepass-v38", value:  3);
            }
            else
            {
                    val_2.Add(key:  "battlepass-v38", value:  3);
            }
            
            val_2.Add(key:  "gme-v17", value:  4);
            if(val_2 != null)
            {
                    val_2.Add(key:  "fullSlots_v1", value:  7);
            }
            else
            {
                    val_2.Add(key:  "fullSlots_v1", value:  7);
            }
            
            val_2.Add(key:  "matchmaking", value:  5);
            if(val_2 != null)
            {
                    val_2.Add(key:  "try-guns-v17", value:  6);
            }
            else
            {
                    val_2.Add(key:  "try-guns-v17", value:  6);
            }
            
            val_2.Add(key:  "offers-tier-v3", value:  8);
            if(val_2 != null)
            {
                    val_2.Add(key:  "offers-es-v27", value:  9);
            }
            else
            {
                    val_2.Add(key:  "offers-es-v27", value:  9);
            }
            
            val_2.Add(key:  "offers-ad-v7", value:  11);
            if(val_2 != null)
            {
                    val_2.Add(key:  "tier-matchmaking-v4", value:  12);
            }
            else
            {
                    val_2.Add(key:  "tier-matchmaking-v4", value:  12);
            }
            
            val_2.Add(key:  "geme-rewards-v1", value:  13);
            if(val_2 != null)
            {
                    val_2.Add(key:  "modules-v5", value:  14);
            }
            else
            {
                    val_2.Add(key:  "modules-v5", value:  14);
            }
            
            val_2.Add(key:  "module-chests-v4", value:  15);
            if(val_2 != null)
            {
                    val_2.Add(key:  "gatcha-v6", value:  16);
            }
            else
            {
                    val_2.Add(key:  "gatcha-v6", value:  16);
            }
            
            val_2.Add(key:  "Actions-v2", value:  19);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceLoopContent_v28", value:  20);
            }
            else
            {
                    val_2.Add(key:  "BalanceLoopContent_v28", value:  20);
            }
            
            val_2.Add(key:  "BalanceWeapons_v20", value:  21);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceEconomic_v22", value:  22);
            }
            else
            {
                    val_2.Add(key:  "BalanceEconomic_v22", value:  22);
            }
            
            val_2.Add(key:  "BalanceLeveling_v20", value:  23);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceVehicle_v20", value:  24);
            }
            else
            {
                    val_2.Add(key:  "BalanceVehicle_v20", value:  24);
            }
            
            val_2.Add(key:  "BalanceItemPrices_v20", value:  25);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalancePets_v20", value:  26);
            }
            else
            {
                    val_2.Add(key:  "BalancePets_v20", value:  26);
            }
            
            val_2.Add(key:  "BalanceGadgets_v20", value:  27);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceLobbyItems_v20", value:  28);
            }
            else
            {
                    val_2.Add(key:  "BalanceLobbyItems_v20", value:  28);
            }
            
            val_2.Add(key:  "BalanceRewards_v20", value:  30);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceInappsAndClans_v21", value:  31);
            }
            else
            {
                    val_2.Add(key:  "BalanceInappsAndClans_v21", value:  31);
            }
            
            val_2.Add(key:  "BalanceOthers_v20", value:  32);
            if(val_2 != null)
            {
                    val_2.Add(key:  "BalanceWeaponSkins_v22", value:  48);
            }
            else
            {
                    val_2.Add(key:  "BalanceWeaponSkins_v22", value:  48);
            }
            
            val_2.Add(key:  "PromoActions", value:  33);
            if(val_2 != null)
            {
                    val_2.Add(key:  "x10", value:  34);
            }
            else
            {
                    val_2.Add(key:  "x10", value:  34);
            }
            
            val_2.Add(key:  "MapList_v5", value:  35);
            if(val_2 != null)
            {
                    val_2.Add(key:  "Tournament_0-v2", value:  36);
            }
            else
            {
                    val_2.Add(key:  "Tournament_0-v2", value:  36);
            }
            
            val_2.Add(key:  "Tournament_1-v2", value:  37);
            if(val_2 != null)
            {
                    val_2.Add(key:  "clan-chests-v1", value:  38);
            }
            else
            {
                    val_2.Add(key:  "clan-chests-v1", value:  38);
            }
            
            val_2.Add(key:  "BestBuy", value:  39);
            if(val_2 != null)
            {
                    val_2.Add(key:  "Pereliv", value:  41);
            }
            else
            {
                    val_2.Add(key:  "Pereliv", value:  41);
            }
            
            val_2.Add(key:  "BuffSettings", value:  42);
            if(val_2 != null)
            {
                    val_2.Add(key:  "RatingConfig-v2", value:  43);
            }
            else
            {
                    val_2.Add(key:  "RatingConfig-v2", value:  43);
            }
            
            val_2.Add(key:  "FilterBadWord", value:  44);
            if(val_2 != null)
            {
                    val_2.Add(key:  "offers-md-v1", value:  47);
            }
            else
            {
                    val_2.Add(key:  "offers-md-v1", value:  47);
            }
            
            val_2.Add(key:  "collections-v2", value:  49);
            if(val_2 != null)
            {
                    val_2.Add(key:  "taskbook-v9", value:  50);
            }
            else
            {
                    val_2.Add(key:  "taskbook-v9", value:  50);
            }
            
            val_2.Add(key:  "offers-dt-v1", value:  51);
            if(val_2 != null)
            {
                    val_2.Add(key:  "Bots", value:  52);
            }
            else
            {
                    val_2.Add(key:  "Bots", value:  52);
            }
            
            val_2.Add(key:  "offers-sp-v2", value:  53);
            if(val_2 != null)
            {
                    val_2.Add(key:  "InHouseAnalytics-v3", value:  54);
            }
            else
            {
                    val_2.Add(key:  "InHouseAnalytics-v3", value:  54);
            }
            
            val_2.Add(key:  "PixelbookSettings", value:  62);
            if(val_2 != null)
            {
                    val_2.Add(key:  "MobileInapps", value:  63);
            }
            else
            {
                    val_2.Add(key:  "MobileInapps", value:  63);
            }
            
            val_2.Add(key:  "subscriptions-v1", value:  66);
            if(val_2 != null)
            {
                    val_2.Add(key:  "matchmaking-v6", value:  64);
            }
            else
            {
                    val_2.Add(key:  "matchmaking-v6", value:  64);
            }
            
            val_2.Add(key:  "fort-defence", value:  65);
            if(val_2 != null)
            {
                    val_2.Add(key:  "fort-defence-global", value:  72);
            }
            else
            {
                    val_2.Add(key:  "fort-defence-global", value:  72);
            }
            
            val_2.Add(key:  "clan-war", value:  67);
            if(val_2 != null)
            {
                    val_2.Add(key:  "clan-war-1", value:  71);
            }
            else
            {
                    val_2.Add(key:  "clan-war-1", value:  71);
            }
            
            val_2.Add(key:  "clan-loot-boxes-v2", value:  68);
            if(val_2 != null)
            {
                    val_2.Add(key:  "clan-v5", value:  69);
            }
            else
            {
                    val_2.Add(key:  "clan-v5", value:  69);
            }
            
            val_2.Add(key:  "pi-v1", value:  70);
            if(val_2 != null)
            {
                    val_2.Add(key:  "cpi-v1", value:  76);
            }
            else
            {
                    val_2.Add(key:  "cpi-v1", value:  76);
            }
            
            val_2.Add(key:  "clan-buffs-v1", value:  73);
            if(val_2 != null)
            {
                    val_2.Add(key:  "MailBox-v1", value:  74);
            }
            else
            {
                    val_2.Add(key:  "MailBox-v1", value:  74);
            }
            
            val_2.Add(key:  "clanrank-v1", value:  77);
            if(val_2 != null)
            {
                    val_2.Add(key:  "ItemIndexes", value:  75);
            }
            else
            {
                    val_2.Add(key:  "ItemIndexes", value:  75);
            }
            
            val_2.Add(key:  "offers-lb-v1", value:  78);
            if(val_2 != null)
            {
                    val_2.Add(key:  "ABTest-v2", value:  80);
            }
            else
            {
                    val_2.Add(key:  "ABTest-v2", value:  80);
            }
            
            val_2.Add(key:  "AdaptiveAutoAim-v1", value:  79);
            if(val_2 != null)
            {
                    val_2.Add(key:  "mm2020-v1", value:  85);
            }
            else
            {
                    val_2.Add(key:  "mm2020-v1", value:  85);
            }
            
            val_2.Add(key:  "mm-bots-v1", value:  86);
            if(val_2 != null)
            {
                    val_2.Add(key:  "ct-v1", value:  83);
            }
            else
            {
                    val_2.Add(key:  "ct-v1", value:  83);
            }
            
            val_2.Add(key:  "cb-v1", value:  84);
            if(val_2 != null)
            {
                    val_2.Add(key:  "update-banner-v1", value:  90);
            }
            else
            {
                    val_2.Add(key:  "update-banner-v1", value:  90);
            }
            
            val_2.Add(key:  "ClickerDetector", value:  95);
            if(val_2 != null)
            {
                    val_2.Add(key:  PGCompany.丝丛专专世与丏丒丒.丏丝丏上丝上丌不丆, value:  89);
            }
            else
            {
                    val_2.Add(key:  PGCompany.丝丛专专世与丏丒丒.丏丝丏上丝上丌不丆, value:  89);
            }
            
            val_2.Add(key:  "offers-tb-v4", value:  96);
            if(val_2 != null)
            {
                    val_2.Add(key:  "promotions-v7", value:  91);
            }
            else
            {
                    val_2.Add(key:  "promotions-v7", value:  91);
            }
            
            val_2.Add(key:  "connect-scene-chest-v3", value:  93);
            if(val_2 != null)
            {
                    val_2.Add(key:  "connect-scene-v1", value:  92);
            }
            else
            {
                    val_2.Add(key:  "connect-scene-v1", value:  92);
            }
            
            val_2.Add(key:  "bm1-v3", value:  87);
            if(val_2 != null)
            {
                    val_2.Add(key:  "bm2-v3", value:  98);
            }
            else
            {
                    val_2.Add(key:  "bm2-v3", value:  98);
            }
            
            val_2.Add(key:  "constructable-offers-v7", value:  104);
            if(val_2 != null)
            {
                    val_2.Add(key:  "mr-v1", value:  94);
            }
            else
            {
                    val_2.Add(key:  "mr-v1", value:  94);
            }
            
            val_2.Add(key:  "tutorial-v9", value:  99);
            if(val_2 != null)
            {
                    val_2.Add(key:  "combat_tokens-v2", value:  101);
            }
            else
            {
                    val_2.Add(key:  "combat_tokens-v2", value:  101);
            }
            
            val_2.Add(key:  "trophy_road-v3", value:  100);
            if(val_2 != null)
            {
                    val_2.Add(key:  "mptest-v2", value:  102);
            }
            else
            {
                    val_2.Add(key:  "mptest-v2", value:  102);
            }
            
            val_2.Add(key:  "ms-v8", value:  103);
            if(val_2 != null)
            {
                    val_2.Add(key:  "event-hub-v1", value:  105);
            }
            else
            {
                    val_2.Add(key:  "event-hub-v1", value:  105);
            }
            
            val_2.Add(key:  "plc-v1", value:  106);
            if(val_2 != null)
            {
                    val_2.Add(key:  "marathon-v3", value:  107);
            }
            else
            {
                    val_2.Add(key:  "marathon-v3", value:  107);
            }
            
            val_2.Add(key:  "po-v7", value:  110);
            if(val_2 != null)
            {
                    val_2.Add(key:  "freeplaytask-v1", value:  112);
            }
            else
            {
                    val_2.Add(key:  "freeplaytask-v1", value:  112);
            }
            
            val_2.Add(key:  "mo-v2", value:  111);
            if(val_2 != null)
            {
                    val_2.Add(key:  "double-offres-v2", value:  109);
            }
            else
            {
                    val_2.Add(key:  "double-offres-v2", value:  109);
            }
            
            val_2.Add(key:  "vip-v5", value:  113);
            if(val_2 != null)
            {
                    val_2.Add(key:  "multiplayer-bot-v6", value:  114);
            }
            else
            {
                    val_2.Add(key:  "multiplayer-bot-v6", value:  114);
            }
            
            val_2.Add(key:  "imposter-v1", value:  108);
            if(val_2 != null)
            {
                    val_2.Add(key:  "exp-open-v11", value:  116);
            }
            else
            {
                    val_2.Add(key:  "exp-open-v11", value:  116);
            }
            
            val_2.Add(key:  "local-notification-v4", value:  118);
            if(val_2 != null)
            {
                    val_2.Add(key:  "novice-double-offres-v2", value:  115);
            }
            else
            {
                    val_2.Add(key:  "novice-double-offres-v2", value:  115);
            }
            
            val_2.Add(key:  "change-log-v3", value:  117);
            if(val_2 != null)
            {
                    val_2.Add(key:  "arm-race-v2", value:  120);
            }
            else
            {
                    val_2.Add(key:  "arm-race-v2", value:  120);
            }
            
            val_2.Add(key:  "loot-boxes-v7", value:  119);
            if(val_2 != null)
            {
                    val_2.Add(key:  "holding-positions-v1", value:  122);
            }
            else
            {
                    val_2.Add(key:  "holding-positions-v1", value:  122);
            }
            
            val_2.Add(key:  "universal-promotion-v7", value:  121);
            if(val_2 != null)
            {
                    val_2.Add(key:  "gme-c-v1", value:  125);
            }
            else
            {
                    val_2.Add(key:  "gme-c-v1", value:  125);
            }
            
            val_2.Add(key:  "pixel-pass-v6", value:  123);
            if(val_2 != null)
            {
                    val_2.Add(key:  "pixel-pass-offers-v6", value:  140);
            }
            else
            {
                    val_2.Add(key:  "pixel-pass-offers-v6", value:  140);
            }
            
            val_2.Add(key:  "gme-r-v4", value:  126);
            if(val_2 != null)
            {
                    val_2.Add(key:  "s-v3", value:  127);
            }
            else
            {
                    val_2.Add(key:  "s-v3", value:  127);
            }
            
            val_2.Add(key:  "plugin-photon-v1", value:  128);
            if(val_2 != null)
            {
                    val_2.Add(key:  "plant-bomb-v1", value:  129);
            }
            else
            {
                    val_2.Add(key:  "plant-bomb-v1", value:  129);
            }
            
            val_2.Add(key:  "a-v1", value:  130);
            if(val_2 != null)
            {
                    val_2.Add(key:  "graffiti-v2", value:  133);
            }
            else
            {
                    val_2.Add(key:  "graffiti-v2", value:  133);
            }
            
            val_2.Add(key:  "offers-ncforB-v1", value:  132);
            if(val_2 != null)
            {
                    val_2.Add(key:  "universal-promotion-forB-v2", value:  131);
            }
            else
            {
                    val_2.Add(key:  "universal-promotion-forB-v2", value:  131);
            }
            
            val_2.Add(key:  "recipe-v2", value:  136);
            if(val_2 != null)
            {
                    val_2.Add(key:  "mutation-v1", value:  134);
            }
            else
            {
                    val_2.Add(key:  "mutation-v1", value:  134);
            }
            
            val_2.Add(key:  "class-system-v1", value:  135);
            if(val_2 != null)
            {
                    val_2.Add(key:  "ach-v1", value:  138);
            }
            else
            {
                    val_2.Add(key:  "ach-v1", value:  138);
            }
            
            val_2.Add(key:  "subscription-20-v1", value:  139);
            if(val_2 != null)
            {
                    val_2.Add(key:  "lack-buy-v1", value:  137);
            }
            else
            {
                    val_2.Add(key:  "lack-buy-v1", value:  137);
            }
            
            val_2.Add(key:  "red-light-v1", value:  143);
            if(val_2 != null)
            {
                    val_2.Add(key:  "competition-system-settings-v1", value:  141);
            }
            else
            {
                    val_2.Add(key:  "competition-system-settings-v1", value:  141);
            }
            
            val_2.Add(key:  "gmh-v3", value:  124);
            return val_2;
        }
        internal byte[] 不万丂丟丝三世丌一(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            object val_7;
            var val_8;
            System.Byte[] val_2 = 0;
            string val_3 = 0;
            val_7 = PGCompany.丐上丛三上丂丂丌东.丑七不且上丗丁一世();
            if((val_7.三丛丕一万丑丟一丏(丈丄丈世一且不不丁:  丈丄丈世一且不不丁, 下丗丈丈一三下上丈: out  val_2, 丏丞专丏业丗丝七丝: out  val_3)) != false)
            {
                    val_8 = val_2;
                return (System.Byte[])val_8;
            }
            
            object[] val_5 = new object[4];
            val_5[0] = "ConfigSystem.GetBinaryFallbackConfig";
            val_5[1] = 丈丄丈世一且不不丁;
            val_5[2] = "explanation";
            val_5[3] = val_3;
            val_7 = System.String.Format(format:  "[{0}] Failed to load binary embedded config: {1}, {2}: {3}", args:  val_5);
            UnityEngine.Debug.LogWarning(message:  val_7);
            val_8 = 0;
            return (System.Byte[])val_8;
        }
        internal string 丞丏世丏丂丘丄丝上(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            PGCompany.ConfigId val_5;
            PGCompany.EmbeddedConfig val_6;
            int val_7;
            val_5 = 丈丄丈世一且不不丁;
            PGCompany.EmbeddedConfigEntry val_2 = 0;
            val_6 = this.丞世上万丑不丁丝七;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            PGCompany.EmbeddedConfig val_1 = PGCompany.丒丒丛丙不万专三丆.东且丙丞丞丑丝丄万();
            this.丞世上万丑不丁丝七 = val_1;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_1:
            if((val_1.丒且丄丕万丌丈丑业.TryGetValue(key:  val_5, value: out  val_2)) != false)
            {
                    val_5 = val_2;
                string val_4 = val_5.ConfigJson;
                return (string)val_7;
            }
            
            label_4:
            val_7 = System.String.alignConst;
            return (string)val_7;
        }
        private string 丐丟丈丘丏丕七丞丑(PGCompany.ConfigId 丈丄丈世一且不不丁)
        {
            PGCompany.ConfigId val_5;
            PGCompany.EmbeddedConfig val_6;
            int val_7;
            val_5 = 丈丄丈世一且不不丁;
            PGCompany.EmbeddedConfigEntry val_2 = 0;
            val_6 = this.丞世上万丑不丁丝七;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            PGCompany.EmbeddedConfig val_1 = PGCompany.丒丒丛丙不万专三丆.东且丙丞丞丑丝丄万();
            this.丞世上万丑不丁丝七 = val_1;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_1:
            if((val_1.丒且丄丕万丌丈丑业.TryGetValue(key:  val_5, value: out  val_2)) != false)
            {
                    val_5 = val_2;
                string val_4 = val_5.ConfigHash;
                return (string)val_7;
            }
            
            label_4:
            val_7 = System.String.alignConst;
            return (string)val_7;
        }
    
    }

}
