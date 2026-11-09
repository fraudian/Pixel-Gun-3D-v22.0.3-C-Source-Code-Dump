using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class DailyTierProgress : ICloneable
    {
        // Fields
        private Rilisoft.丝丑丂丛万丐丈丘且 _seasonIdContainer;
        private Rilisoft.丝丑丂丛万丐丈丘且 _generateIndexContainer;
        internal string TierKey;
        internal System.Collections.Generic.List<Progress.DailyTierProgress.DailyTierOffersSettingKey> SelectedSettings;
        
        // Properties
        internal int SeasonId { get; set; }
        internal int GenerateIndex { get; set; }
        
        // Methods
        internal int get_SeasonId()
        {
        
        }
        internal void set_SeasonId(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._seasonIdContainer = val_1;
            mem[1152921541063208664] = val_1.上万三丆专丏丒丗业;
        }
        internal int get_GenerateIndex()
        {
        
        }
        internal void set_GenerateIndex(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._generateIndexContainer = val_1;
            mem[1152921541063432680] = val_1.上万三丆专丏丒丗业;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Progress.DailyTierProgress 七丏丄丅丌业与且丙)
        {
            var val_5;
            var val_6;
            val_5 = 七丏丄丅丌业与且丙;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_5 == null)
            {
                    return val_1;
            }
            
            val_6 = 1152921504622075904;
            val_1.Add(key:  "s", value:  七丏丄丅丌业与且丙._seasonIdContainer);
            val_1.Add(key:  "i", value:  七丏丄丅丌业与且丙._generateIndexContainer);
            val_1.Add(key:  "t", value:  七丏丄丅丌业与且丙.TierKey);
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
            if(七丏丄丅丌业与且丙.SelectedSettings == null)
            {
                goto label_15;
            }
            
            List.Enumerator<T> val_3 = 七丏丄丅丌业与且丙.SelectedSettings.GetEnumerator();
            val_6 = 1152921541063550336;
            label_9:
            if((2096984056 & 1) == 0)
            {
                goto label_6;
            }
            
            val_2.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                goto label_16;
            }
            
            goto label_11;
            label_15:
            if(val_1 != null)
            {
                goto label_16;
            }
            
            label_11:
            label_16:
            val_1.Add(key:  "ss", value:  val_2);
            return val_1;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Progress.DailyTierProgress 丛三七丟丗与专丙丂, Progress.DailyTierProgress 三丂丑丁丞丞丅东三)
        {
            Progress.DailyTierProgress val_10;
            var val_11;
            var val_12;
            System.Collections.Generic.List<DailyTierOffersSettingKey> val_13;
            var val_14;
            System.Func<DailyTierOffersSettingKey, System.String> val_16;
            string val_17;
            object val_18;
            var val_19;
            Progress.DailyTierProgress val_20;
            val_10 = 丛三七丟丗与专丙丂;
            if((三丂丑丁丞丞丅东三 | val_10) == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_11;
            }
            
            if(val_10 == null)
            {
                goto label_3;
            }
            
            if(三丂丑丁丞丞丅东三 == null)
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(三丂丑丁丞丞丅东三._seasonIdContainer != 丛三七丟丗与专丙丂._seasonIdContainer)
            {
                    val_3.Add(key:  "s", value:  三丂丑丁丞丞丅东三._seasonIdContainer);
            }
            
            val_12 = 三丂丑丁丞丞丅东三._generateIndexContainer;
            if(val_12 != 丛三七丟丗与专丙丂._generateIndexContainer)
            {
                    val_3.Add(key:  "i", value:  三丂丑丁丞丞丅东三._generateIndexContainer);
            }
            
            if((System.String.op_Inequality(a:  三丂丑丁丞丞丅东三.TierKey, b:  丛三七丟丗与专丙丂.TierKey)) != false)
            {
                    val_3.Add(key:  "t", value:  三丂丑丁丞丞丅东三.TierKey);
            }
            
            val_13 = 三丂丑丁丞丞丅东三.SelectedSettings;
            if(val_13 == null)
            {
                goto label_11;
            }
            
            if(丛三七丟丗与专丙丂.SelectedSettings != null)
            {
                    if((System.Linq.Enumerable.SequenceEqual<DailyTierOffersSettingKey>(first:  val_13, second:  丛三七丟丗与专丙丂.SelectedSettings)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_11;
            }
            
                val_13 = 三丂丑丁丞丞丅东三.SelectedSettings;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = DailyTierProgress.<>c.<>9__11_0;
            if(val_16 == null)
            {
                    System.Func<DailyTierOffersSettingKey, System.String> val_6 = null;
                val_16 = val_6;
                val_6 = new System.Func<DailyTierOffersSettingKey, System.String>(object:  DailyTierProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String DailyTierProgress.<>c::丟丄丑丙丙丘一专丒(Progress.DailyTierProgress.DailyTierOffersSettingKey 七丞丙丒三丕且丌丟));
                DailyTierProgress.<>c.<>9__11_0 = val_16;
            }
            
            val_10 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<DailyTierOffersSettingKey, System.String>(source:  val_13, selector:  val_6));
            val_17 = "ss";
            val_18 = val_10;
            val_19 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_20;
            label_3:
            val_20 = 三丂丑丁丞丞丅东三;
            return Progress.DailyTierProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_20 = val_10);
            label_4:
            return Progress.DailyTierProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_20);
            label_11:
            System.Collections.Generic.List<System.Int32> val_9 = new System.Collections.Generic.List<System.Int32>();
            val_18 = val_9;
            val_17 = "ss";
            val_19 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_20:
            val_3.Add(key:  val_17, value:  val_9);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_11;
        }
        public object Clone()
        {
            string val_8;
            var val_9;
            System.Collections.Generic.List<DailyTierOffersSettingKey> val_11;
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this._seasonIdContainer);
            ._seasonIdContainer = val_2;
            mem[1152921541064039256] = val_2.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this._generateIndexContainer);
            ._generateIndexContainer = val_3;
            mem[1152921541064039272] = val_3.上万三丆专丏丒丗业;
            val_8 = this.TierKey;
            .TierKey = val_8;
            if(this.SelectedSettings != null)
            {
                    val_9 = null;
                val_9 = null;
                val_8 = DailyTierProgress.<>c.<>9__12_0;
                if(val_8 == null)
            {
                    System.Func<DailyTierOffersSettingKey, DailyTierOffersSettingKey> val_4 = null;
                val_8 = val_4;
                val_4 = new System.Func<DailyTierOffersSettingKey, DailyTierOffersSettingKey>(object:  DailyTierProgress.<>c.__il2cppRuntimeField_static_fields, method:  DailyTierOffersSettingKey DailyTierProgress.<>c::且丅丙丈上丝一丕丞(Progress.DailyTierProgress.DailyTierOffersSettingKey 丏丛与丅丛丌万专丌));
                DailyTierProgress.<>c.<>9__12_0 = val_8;
            }
            
                val_11 = System.Linq.Enumerable.ToList<DailyTierOffersSettingKey>(source:  System.Linq.Enumerable.Select<DailyTierOffersSettingKey, DailyTierOffersSettingKey>(source:  this.SelectedSettings, selector:  val_4));
            }
            else
            {
                    System.Collections.Generic.List<DailyTierOffersSettingKey> val_7 = null;
                val_11 = val_7;
                val_7 = new System.Collections.Generic.List<DailyTierOffersSettingKey>();
            }
            
            .SelectedSettings = val_11;
            return (object)new Progress.DailyTierProgress();
        }
        public DailyTierProgress()
        {
            this.TierKey = System.String.alignConst;
            this.SelectedSettings = new System.Collections.Generic.List<DailyTierOffersSettingKey>();
        }
    
    }

}
