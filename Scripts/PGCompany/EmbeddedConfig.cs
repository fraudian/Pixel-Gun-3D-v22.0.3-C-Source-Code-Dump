using UnityEngine;

namespace PGCompany
{
    public sealed class EmbeddedConfig : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        private static float 上丕丈丞丌丘丅不与;
        private static float 丒且丆丘丞丑业丅不;
        private static string 丂丕下丏业丛丌三丄;
        private static readonly System.Text.UTF8Encoding 与丕丗丗三上丙东下;
        private System.EventHandler 丒丄丟下丐世丌三丆;
        internal System.Collections.Generic.List<PGCompany.EmbeddedConfigEntry> Configs;
        internal System.Collections.Generic.Dictionary<PGCompany.ConfigId, PGCompany.EmbeddedConfigEntry> 丒且丄丕万丌丈丑业;
        private PGCompany.不万不丑专下三一丁 _configPlatform;
        private System.DateTime 东且丅万丌丌三丑丗;
        private System.Threading.CancellationTokenSource 丛世七世且丗丌丌丒;
        
        // Properties
        public static System.Collections.Generic.List<PGCompany.ConfigId> 丆丐专丂丑丙业一上 { get; }
        public PGCompany.不万不丑专下三一丁 且丏丁丆丐丐丈丝三 { get; }
        public System.DateTime 丄丌丞一丁业丞专下 { get; }
        public bool 下七一丆丈三丟丝丞 { get; set; }
        
        // Methods
        public static System.Collections.Generic.List<PGCompany.ConfigId> get_BalanceConfigs()
        {
            null = null;
            return (System.Collections.Generic.List<PGCompany.ConfigId>)BalanceController.丒一丛丐丛且世丟丟;
        }
        private void 丅丈丆丂下丕丂丗丅()
        {
        
        }
        private void 业丒且丒三丅丈丈丘()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  21);
        }
        private void 专丘世一与丂专三丄()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  22);
        }
        private void 且丂丛丁丕丑下丞不()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  23);
        }
        private void 丞专丗丞丛丐丄丂丙()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  24);
        }
        private void 丒与丟丕与丄丌世下()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  25);
        }
        private void 丄东丆丗三下丝丏丗()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  26);
        }
        private void 上丘东三丘丁万上丅()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  27);
        }
        private void 上丞丝下丏业三丏丘()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  28);
        }
        private void 东三丏业丅丕与丒七()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  30);
        }
        private void 不丟下丟丏丛丕世丅()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  31);
        }
        private void 且丕三七丐丂丁上丑()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  32);
        }
        private void 东与丂丑丅丌丙丂丝()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  20);
        }
        private void 业丆丌万且丗丗丐下()
        {
            new System.Collections.Generic.List<PGCompany.ConfigId>().Add(item:  48);
        }
        private void 丘与丝丙世丗丁丏世(System.Collections.Generic.List<PGCompany.ConfigId> 下不丆上丗丕丙与七)
        {
        
        }
        private static System.Collections.Generic.IEnumerator<object> 不且丄丌丐丝万七业(PGCompany.ConfigId 丘丏丘三七不不与丝, string 丟丈一下东业一丝丆)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)new EmbeddedConfig.且且丟丛一丂三丂丕();
        }
        private void 下万丐东三丛丄丐丄()
        {
            System.Action<System.String> val_1 = new System.Action<System.String>(object:  this, method:  System.Void PGCompany.EmbeddedConfig::世专不丘丏丅且丙丌(string 丕丗丘丑丛与丑业丒));
        }
        private void 万东下丅丙丌丌且丂()
        {
            System.Action<System.String> val_1 = new System.Action<System.String>(object:  this, method:  System.Void PGCompany.EmbeddedConfig::万下丕三丑丙丈丌上(string 丕丗丘丑丛与丑业丒));
        }
        private void 丘丑下丆上业丛一丄(string 下一且丌三专丄且丁, string 七丙不丅丛丘丗万与, System.Action<string> 丅丁三世丝三丞专世)
        {
        
        }
        private static System.Collections.Generic.IEnumerator<object> 丏丛丏丈丝东三业下(string 丟丈一下东业一丝丆, string 下一且丌三专丄且丁, string 七丙不丅丛丘丗万与, System.Action<string> 丅丁三世丝三丞专世)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)new EmbeddedConfig.丟业丆丂丂丂丘万丒();
        }
        private static void 丏丛万万丙丐不丙一(PGCompany.ConfigId 丁丅丈丌丟世丗丗丟, string 上世丏丁世丟世丆业, string 丟丈一下东业一丝丆, bool 万丘丞丙丕丗丂丐丑 = True)
        {
        
        }
        private void 丄丟丞丛专丐丞一丟()
        {
            System.Collections.Generic.List<PGCompany.ConfigId> val_1 = new System.Collections.Generic.List<PGCompany.ConfigId>();
            if(val_1 != null)
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  14);
                val_1.Add(item:  15);
                val_1.Add(item:  33);
                val_1.Add(item:  36);
                val_1.Add(item:  37);
                val_1.Add(item:  39);
                val_1.Add(item:  42);
                val_1.Add(item:  43);
                val_1.Add(item:  41);
                val_1.Add(item:  91);
                val_1.Add(item:  44);
                val_1.Add(item:  52);
                val_1.Add(item:  49);
                val_1.Add(item:  54);
                val_1.Add(item:  62);
                val_1.Add(item:  63);
                val_1.Add(item:  70);
                val_1.Add(item:  76);
                val_1.Add(item:  77);
                val_1.Add(item:  90);
                val_1.Add(item:  75);
                val_1.Add(item:  95);
            }
            else
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  14);
                val_1.Add(item:  15);
                val_1.Add(item:  33);
                val_1.Add(item:  36);
                val_1.Add(item:  37);
                val_1.Add(item:  39);
                val_1.Add(item:  42);
                val_1.Add(item:  43);
                val_1.Add(item:  41);
                val_1.Add(item:  91);
                val_1.Add(item:  44);
                val_1.Add(item:  52);
                val_1.Add(item:  49);
                val_1.Add(item:  54);
                val_1.Add(item:  62);
                val_1.Add(item:  63);
                val_1.Add(item:  70);
                val_1.Add(item:  76);
                val_1.Add(item:  77);
                val_1.Add(item:  90);
                val_1.Add(item:  75);
                val_1.Add(item:  95);
            }
            
            val_1.Add(item:  106);
        }
        private void 且丅丌三上丑丑丟丄(System.Collections.Generic.List<PGCompany.ConfigId> 下不丆上丗丕丙与七)
        {
        
        }
        private static System.Collections.Generic.IEnumerator<object> 丝三丞丏丞丄丟丅丂(PGCompany.ConfigId 丘丏丘三七不不与丝, string 丟丈一下东业一丝丆, PGCompany.不万不丑专下三一丁 丐丑万与丏丄丒三丄)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)new EmbeddedConfig.与丝丕丞丟业丂丝丝();
        }
        public void add_SaveRequired(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丒丄丟下丐世丌三丆, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丒丄丟下丐世丌三丆 != 1152921555213012904);
        
        }
        public void remove_SaveRequired(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丒丄丟下丐世丌三丆, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丒丄丟下丐世丌三丆 != 1152921555213149480);
        
        }
        public PGCompany.不万不丑专下三一丁 get_Platform()
        {
            return (PGCompany.不万不丑专下三一丁)this._configPlatform;
        }
        public System.DateTime get_LastUpdated()
        {
            return (System.DateTime)this.东且丅万丌丌三丑丗;
        }
        public bool get_IsDirty()
        {
            null = null;
            return System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.东且丅万丌丌三丑丗}, t2:  new System.DateTime() {dateData = System.DateTime.MaxValue});
        }
        public void set_IsDirty(bool 丙业与丙丗丝不丈东)
        {
            var val_2;
            System.DateTime val_3;
            val_2 = null;
            if(丙业与丙丗丝不丈东 == false)
            {
                goto label_1;
            }
            
            System.DateTime val_1 = System.DateTime.Now;
            val_3 = val_1.dateData;
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_5;
            label_1:
            val_2 = null;
            val_3 = System.DateTime.MaxValue;
            if(this != null)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            this.东且丅万丌丌三丑丗 = val_3;
        }
        private void OnValidate()
        {
            List.Enumerator<T> val_1 = this.Configs.GetEnumerator();
            label_4:
            if(((-932712088) & 1) == 0)
            {
                goto label_2;
            }
            
            0.丐丏七丌丕丗业且上().丏且丕丄世丕不丕丙();
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.IsDirty = true;
            if(this.丛世七世且丗丌丌丒 != null)
            {
                    this.丛世七世且丗丌丌丒.Cancel();
            }
            
            System.Threading.CancellationTokenSource val_3 = new System.Threading.CancellationTokenSource();
            this.丛世七世且丗丌丌丒 = val_3;
            System.Threading.CancellationToken val_4 = val_3.Token;
            System.Collections.Generic.IEnumerator<System.Object> val_5 = this.下丗丕丝丅丝丗丌丟(七不丆三丏一世下丌:  new System.Threading.CancellationToken() {m_source = val_4.m_source});
        }
        private static bool 丑丕丈丈不不且丑且(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙)
        {
            return (bool)((丑丛丕不丛丌不丌丙 - 1) < 4) ? 1 : 0;
        }
        private System.Collections.Generic.IEnumerator<object> 下丗丕丝丅丝丗丌丟(System.Threading.CancellationToken 七不丆三丏一世下丌)
        {
            EmbeddedConfig.七丆丏丄丙丁丄丐三 val_1 = new EmbeddedConfig.七丆丏丄丙丁丄丐三();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .七不丆三丏一世下丌 = 七不丆三丏一世下丌;
            return (System.Collections.Generic.IEnumerator<System.Object>)val_1;
        }
        public void OnBeforeSerialize()
        {
        
        }
        public void OnAfterDeserialize()
        {
            var val_4 = this;
            this.丒且丄丕万丌丈丑业 = new System.Collections.Generic.Dictionary<PGCompany.ConfigId, PGCompany.EmbeddedConfigEntry>();
            List.Enumerator<T> val_2 = this.Configs.GetEnumerator();
            label_5:
            if(((-932208824) & 1) == 0)
            {
                goto label_2;
            }
            
            this.丒且丄丕万丌丈丑业.set_Item(key:  val_3.m_stringLength, value:  0.丐丏七丌丕丗业且上());
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丅丁专东丘且丘且丏()
        {
            PGCompany.EmbeddedConfig.与丝丘丏丒丆一且丅(丑丛丕不丛丌不丌丙:  this._configPlatform, 丟丈一下东业一丝丆:  this.gameObject.name);
        }
        private static void 与丝丘丏丒丆一且丅(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙, string 丟丈一下东业一丝丆)
        {
            PGCompany.不万不丑专下三一丁 val_6;
            System.Object[] val_7;
            val_6 = 丑丛丕不丛丌不丌丙;
            object[] val_2 = new object[1];
            val_7 = val_2;
            if((val_6 - 1) >= 4)
            {
                    val_7[0] = val_6;
                UnityEngine.Debug.LogErrorFormat(format:  "[E_mbeddedConfig] D_ownloadModulesConfig => Bad configPlatform: {0}", args:  val_2);
                return;
            }
            
            val_7[0] = val_6;
            UnityEngine.Debug.LogFormat(format:  "[E_mbeddedConfig] D_ownloadModulesConfig => configPlatform: {0}", args:  val_2);
            val_7 = PGCompany.EmbeddedConfig.三丁丏丗上丆丈丐东(丑丛丕不丛丌不丌丙:  val_6);
            UnityEngine.WWW val_4 = null;
            val_6 = val_4;
            val_4 = new UnityEngine.WWW(url:  val_7);
            System.Collections.Generic.IEnumerator<System.Object> val_5 = PGCompany.EmbeddedConfig.丞丆世专七丕丄专专(东丞丒丙世丏三下丟:  val_4, 丟丈一下东业一丝丆:  丟丈一下东业一丝丆);
        }
        private static System.Collections.Generic.IEnumerator<object> 丞丆世专七丕丄专专(UnityEngine.WWW 东丞丒丙世丏三下丟, string 丟丈一下东业一丝丆)
        {
            EmbeddedConfig.丆丂丏丑丙业上且丁 val_1 = new EmbeddedConfig.丆丂丏丑丙业上且丁();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .东丞丒丙世丏三下丟 = 东丞丒丙世丏三下丟;
            }
            else
            {
                    mem[32] = 东丞丒丙世丏三下丟;
            }
            
            .丟丈一下东业一丝丆 = 丟丈一下东业一丝丆;
            return (System.Collections.Generic.IEnumerator<System.Object>)val_1;
        }
        private static string 三丁丏丗上丆丈丐东(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙)
        {
            return System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "https://secure.pixelgunserver.com/pg3d-config-system/{0}/{1}.json", arg0:  PGCompany.丒丒丛丙不万专三丆.丅丙丑丒丈不上丂丘(丞丅上丏丂且下丅与:  14), arg1:  PGCompany.EmbeddedConfig.东业丗丆专丞专丒丂(丑丛丕不丛丌不丌丙:  丑丛丕不丛丌不丌丙));
        }
        private static string 东业丗丆专丞专丒丂(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙)
        {
            var val_2;
            if((丑丛丕不丛丌不丌丙 - 1) >= 4)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_2 = mem[130689040 + ((丑丛丕不丛丌不丌丙 - 1)) << 3];
            val_2 = 130689040 + ((丑丛丕不丛丌不丌丙 - 1)) << 3;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private void 丞丌丘丒丁万丆丗丏()
        {
            PGCompany.EmbeddedConfig.万丂丁下丈不丑丛东(丑丛丕不丛丌不丌丙:  this._configPlatform, 丟丈一下东业一丝丆:  this.gameObject.name);
        }
        private static void 万丂丁下丈不丑丛东(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙, string 丟丈一下东业一丝丆)
        {
            PGCompany.不万不丑专下三一丁 val_6;
            System.Object[] val_7;
            val_6 = 丑丛丕不丛丌不丌丙;
            object[] val_2 = new object[1];
            val_7 = val_2;
            if((val_6 - 1) >= 4)
            {
                    val_7[0] = val_6;
                UnityEngine.Debug.LogErrorFormat(format:  "[E_mbeddedConfig] D_ownloadModulesChestsConfig => Bad configPlatform: {0}", args:  val_2);
                return;
            }
            
            val_7[0] = val_6;
            UnityEngine.Debug.LogFormat(format:  "[E_mbeddedConfig] D_ownloadModulesChestsConfig => configPlatform: {0}", args:  val_2);
            val_7 = PGCompany.EmbeddedConfig.丝丌丌丑与东丈丙丄(丑丛丕不丛丌不丌丙:  val_6);
            UnityEngine.WWW val_4 = null;
            val_6 = val_4;
            val_4 = new UnityEngine.WWW(url:  val_7);
            System.Collections.Generic.IEnumerator<System.Object> val_5 = PGCompany.EmbeddedConfig.下万上丙丑丗三丕丄(东丞丒丙世丏三下丟:  val_4, 丟丈一下东业一丝丆:  丟丈一下东业一丝丆);
        }
        private static System.Collections.Generic.IEnumerator<object> 下万上丙丑丗三丕丄(UnityEngine.WWW 东丞丒丙世丏三下丟, string 丟丈一下东业一丝丆)
        {
            EmbeddedConfig.丄丏东下且丄且不丌 val_1 = new EmbeddedConfig.丄丏东下且丄且不丌();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .东丞丒丙世丏三下丟 = 东丞丒丙世丏三下丟;
            }
            else
            {
                    mem[32] = 东丞丒丙世丏三下丟;
            }
            
            .丟丈一下东业一丝丆 = 丟丈一下东业一丝丆;
            return (System.Collections.Generic.IEnumerator<System.Object>)val_1;
        }
        private static string 丝丌丌丑与东丈丙丄(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙)
        {
            return System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "https://secure.pixelgunserver.com/pg3d-config-system/{0}/{1}.json", arg0:  PGCompany.丒丒丛丙不万专三丆.丅丙丑丒丈不上丂丘(丞丅上丏丂且下丅与:  15), arg1:  PGCompany.EmbeddedConfig.七丛且东丁丂丒专丁(丑丛丕不丛丌不丌丙:  丑丛丕不丛丌不丌丙));
        }
        private static string 七丛且东丁丂丒专丁(PGCompany.不万不丑专下三一丁 丑丛丕不丛丌不丌丙)
        {
            var val_2;
            if((丑丛丕不丛丌不丌丙 - 1) >= 4)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_2 = mem[130689040 + ((丑丛丕不丛丌不丌丙 - 1)) << 3];
            val_2 = 130689040 + ((丑丛丕不丛丌不丌丙 - 1)) << 3;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public EmbeddedConfig()
        {
            null = null;
            this.东且丅万丌丌三丑丗 = System.DateTime.MaxValue;
        }
        private static EmbeddedConfig()
        {
            PGCompany.EmbeddedConfig.上丕丈丞丌丘丅不与 = 0f;
            PGCompany.EmbeddedConfig.丒且丆丘丞丑业丅不 = 10f;
            PGCompany.EmbeddedConfig.与丕丗丗三上丙东下 = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false, throwOnInvalidBytes:  false);
        }
        private void 世专不丘丏丅且丙丌(string 丕丗丘丑丛与丑业丒)
        {
            string val_2 = this.gameObject.name;
        }
        private void 万下丕三丑丙丈丌上(string 丕丗丘丑丛与丑业丒)
        {
            string val_2 = this.gameObject.name;
        }
    
    }

}
