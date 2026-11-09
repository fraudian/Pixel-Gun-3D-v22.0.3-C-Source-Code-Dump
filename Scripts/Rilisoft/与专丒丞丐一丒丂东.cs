using UnityEngine;

namespace Rilisoft
{
    public class 与专丒丞丐一丒丂东 : 上专业三丟丁丞专下
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丌丅丒丙丂丒一不七;
        private UnityEngine.Texture 丌丑丁丏丒丙丂且万;
        private object 专万世且丙万丂上丌;
        private System.Func<int> 专丂丗丁丈丄丒东丁;
        private System.Collections.Generic.List<System.Collections.Generic.List<Rilisoft.GameEventItemContainer>> 一丄丁丙下专丑丘丝;
        private System.Collections.Generic.List<丈丞丕丘丕丗与上一> <专业业丑丞七丌万上>k__BackingField;
        private 丈丞丕丘丕丗与上一 <丘丒且丈丕丆专专下>k__BackingField;
        private Rilisoft.丝丑丂丛万丐丈丘且 <三下与丌世东丌丝丅>k__BackingField;
        private System.Action<Rilisoft.与专丒丞丐一丒丂东> 丞专丂不七丅丛与丒;
        
        // Properties
        internal override 丈丞丕丘丕丗与上一 业丏丌丌丝东丌世丑 { get; }
        public int 丑丅业丁丕丕业丞丗 { get; set; }
        public System.TimeSpan 下丒丘不丘世世丘丌 { get; }
        public System.Nullable<System.TimeSpan> 三丘三丛丝丛业一东 { get; }
        public string 丛丆下丙丛丞丐万丂 { get; }
        internal System.Collections.Generic.List<丈丞丕丘丕丗与上一> 业丐丝丑丕丒下且不 { get; set; }
        internal 丈丞丕丘丕丗与上一 丞丕丂丙下业丞且丐 { get; set; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 丅丛丟丅丛丗丂丟不 { get; set; }
        public System.Collections.Generic.List<int> 万丛丒与且与与丞丐 { get; }
        public System.Collections.Generic.List<int> 东丑丆专丆丕丘东丑 { get; }
        public bool 万丛丌丘丐丈丈七与 { get; }
        public bool 丞三丘丄万丛丁且丂 { get; }
        private object 东东丛下丕丁丆上丌 { get; }
        public bool 丒丐一专专业丄丏丂 { get; }
        public override bool 丙三丝丏专丘丈丐业 { get; }
        public int 丐不丘世且丝丙丑与 { get; }
        public int 世丑与丘丂丒丏丟万 { get; }
        public int 丘丗丛丟三丂丙专丑 { get; }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 七丗一丑且丅下不丌 { get; }
        public System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 下丆丒丂丁丁一丗上 { get; }
        public float 不丅与丙世丐与丁丌 { get; }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 下丂丟世丐与丆东业 { get; }
        public bool 丝丂丕丅丂丝丏丂丁 { get; }
        public UnityEngine.Texture 一七丆丈丑丅一丙丌 { get; }
        public string 世丗业下丛丙丆丙丁 { get; }
        public int 万上三丗上丁丆丄丒 { get; }
        public int 丆丑不丕一东丞业丝 { get; }
        public override string 专丕与丒丗丁丘专丟 { get; }
        
        // Methods
        internal override 丈丞丕丘丕丗与上一 丆一丘万丁上丒丏三()
        {
            var val_6;
            if((this.丟丝与丙东世丗丞与() & 2147483648) == 0)
            {
                    val_6 = this.丟丝与丙东世丗丞与();
            }
            else
            {
                    val_6 = 0;
            }
            
            if((this.<专业业丑丞七丌万上>k__BackingField) != null)
            {
                    return this.<专业业丑丞七丌万上>k__BackingField.Item[System.Math.Min(val1:  0, val2:  (this.<专业业丑丞七丌万上>k__BackingField.Count) - 1)];
            }
            
            return this.<专业业丑丞七丌万上>k__BackingField.Item[System.Math.Min(val1:  0, val2:  (this.<专业业丑丞七丌万上>k__BackingField.Count) - 1)];
        }
        public int 丟丝与丙东世丗丞与()
        {
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return (int)val_1.SpinsCount;
            }
            
            return (int)val_1.SpinsCount;
        }
        private void 丙丆丄丗丞丝丐丐与(int 丙业与丙丗丝不丈东)
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            val_1.SpinsCount = 丙业与丙丗丝不丈东;
        }
        public System.TimeSpan 世丙不业丛丂东万丈()
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            return System.TimeSpan.FromSeconds(value:  (double)val_1.ResetInterval);
        }
        public System.Nullable<System.TimeSpan> 七丆丄丟丟丕三上上()
        {
            if(FriendsController.丝丗专上三不丄丑丑() <= 0)
            {
                    return 0;
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            System.TimeSpan val_3 = this.世丙不业丛丂东万丈();
            double val_4 = val_3._ticks.TotalSeconds;
            double val_7 = (double)val_2.LastResetTime;
            val_7 = val_4 + val_7;
            val_7 = val_7 - (double)FriendsController.丝丗专上三不丄丑丑();
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  val_4);
            return 0;
        }
        public string 丅三专且丈一丝丂丏()
        {
            if(this.丁专丗万三上丟三丆() != null)
            {
                    return (string)val_1.BindedItem;
            }
            
            return (string)val_1.BindedItem;
        }
        internal System.Collections.Generic.List<丈丞丕丘丕丗与上一> 与丄丌丅世丏丑上丈()
        {
            return (System.Collections.Generic.List<丈丞丕丘丕丗与上一>)this.<专业业丑丞七丌万上>k__BackingField;
        }
        private void 丄上丌丈世丄丒世丟(System.Collections.Generic.List<丈丞丕丘丕丗与上一> 丙业与丙丗丝不丈东)
        {
            this.<专业业丑丞七丌万上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丈丞丕丘丕丗与上一 东不七丏上丑丈专下()
        {
            return (丈丞丕丘丕丗与上一)this.<丘丒且丈丕丆专专下>k__BackingField;
        }
        private void 丅世丝丛与丂丝丞丘(丈丞丕丘丕丗与上一 丙业与丙丗丝不丈东)
        {
            this.<丘丒且丈丕丆专专下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 万丝世丘丞东万丟万()
        {
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this.<三下与丌世东丌丝丅>k__BackingField, 丑丒丄下丁丐专丄丞 = this.<三下与丌世东丌丝丅>k__BackingField};
        }
        private void 丑东业丈丝一三上丟(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
        {
            this.<三下与丌世东丌丝丅>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921542908576544] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
        }
        public System.Collections.Generic.List<int> 万丐丘丟丂丛丂丈万()
        {
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_1.ExcludeContainers;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_1.ExcludeContainers;
        }
        public System.Collections.Generic.List<int> 丁且且丐不丝丐下丘()
        {
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_1.DroppedContainers;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_1.DroppedContainers;
        }
        public bool 丒世业三丘丝不下丕()
        {
            string val_11;
            var val_12;
            val_11 = this;
            if(this.丑专丐丐丏丆东丘万() >= this.东丂七不丄丑丄丆七())
            {
                goto label_1;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_3 = WeaponManager.万一丛七丙丑丄丆丑();
            if((System.String.op_Equality(a:  val_3.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  this.丅三专且丈一丝丂丏())) == false)
            {
                goto label_4;
            }
            
            label_1:
            val_12 = 1;
            return (bool)val_12.Contains(item:  val_11 = this.丅三专且丈一丝丂丏());
            label_4:
            val_12 = WeaponManager.七世丂丁丆丙丐丆丌();
            return (bool)val_12.Contains(item:  val_11);
        }
        public bool 七丝丝丈七三丝丘一()
        {
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) == false)
            {
                    return 丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  this.丅三专且丈一丝丂丏());
            }
            
            Rilisoft.PetsManager val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if(val_3 != null)
            {
                    return val_3.七丗世且东丞丙丏丟(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏());
            }
            
            return val_3.七丗世且东丞丙丏丟(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏());
        }
        private object 丌下下丟丂丆丟万万()
        {
            object val_20;
            var val_21;
            string val_22;
            val_20 = this.专万世且丙万丂上丌;
            if(val_20 != null)
            {
                    return val_20;
            }
            
            val_20 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏());
            if(val_20 == null)
            {
                goto label_4;
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = WeaponManager.丗丈丁世且世丂丈丝;
            if((val_22.Contains(item:  this.丅三专且丈一丝丂丏())) == true)
            {
                goto label_13;
            }
            
            label_4:
            System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_7 = null;
            val_22 = val_7;
            val_7 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.与专丒丞丐一丒丂东::丕丁丁下丅且世万万(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌));
            if((System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  val_7)) != null)
            {
                    val_20 = val_8.上七不丅丈丁不丛丝;
            }
            else
            {
                    if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) != false)
            {
                    val_22 = this.丅三专且丈一丝丂丏();
                PetInfo val_13 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_22);
            }
            else
            {
                    if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.丅三专且丈一丝丂丏())) == false)
            {
                    return val_20;
            }
            
                val_22 = this.丅三专且丈一丝丂丏();
            }
            
                val_20 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[val_22];
            }
            
            label_13:
            this.专万世且丙万丂上丌 = val_20;
            return val_20;
        }
        public bool 丟丘不丙不丘丑上万()
        {
            return (bool)(this.丌下下丟丂丆丟万万() != 0) ? 1 : 0;
        }
        public override bool 一业丟丁上丑丘丕丄()
        {
            object val_1 = this.丌下下丟丂丆丟万万();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return this.七丂丌丈丄专丄三世();
        }
        public int 丆丈业丏丑丟丆丒丈()
        {
            Rilisoft.GameEventChestData val_1 = this.丁专丗万三上丟三丆();
            if(val_1.LapSize > 0)
            {
                    if(this.丁专丗万三上丟三丆() != null)
            {
                    return (int)val_2.LapSize;
            }
            
                return (int)val_2.LapSize;
            }
            
            if(this.丌丅丒丙丂丒一不七 != null)
            {
                    return this.丌丅丒丙丂丒一不七.Count;
            }
            
            return this.丌丅丒丙丂丒一不七.Count;
        }
        public int 专丝东丘一丐丛丂丛()
        {
            return UnityEngine.Mathf.FloorToInt(f:  (float)this.Count / this.丆丈业丏丑丟丆丒丈());
        }
        public int 专且丌丁丙丂上丘丄()
        {
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return (int)val_1.CurrentLap;
            }
            
            return (int)val_1.CurrentLap;
        }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 业业世七丛丌业丙丅()
        {
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_1 = this.丌丅丒丙丂丒一不七;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.丂丙丗丄丄东且丗世();
            val_1 = this.丌丅丒丙丂丒一不七;
            return val_1;
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丈丒三丏专且丆万丙()
        {
            if(this.丌丅丒丙丂丒一不七 == null)
            {
                    this.丂丙丗丄丄东且丗世();
            }
            
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return this.丙丁丐丞三丘丕上丕(丒丝丆一丏专且丌丝:  val_1.CurrentLap);
            }
            
            return this.丙丁丐丞三丘丕上丕(丒丝丆一丏专且丌丝:  val_1.CurrentLap);
        }
        public float 丏丗丘且下丞丐丐丙()
        {
            float val_13;
            ChestProgressDataObject val_3 = this.业丑丁丆丕丆丂丅万();
            val_13 = (float)this.专且丌丁丙丂上丘丄() / (float)this.专丝东丘一丐丛丂丛();
            if(val_3.DropContainersHistory == null)
            {
                    return (float)val_13;
            }
            
            ChestProgressDataObject val_4 = this.业丑丁丆丕丆丂丅万();
            if(val_4.DropContainersHistory.Count < 1)
            {
                    return (float)val_13;
            }
            
            int val_8 = this.丈丒三丏专且丆万丙().IndexOf(item:  this.丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0));
            if(val_8 < 1)
            {
                    return (float)val_13;
            }
            
            float val_13 = (float)val_8;
            val_13 = val_13 / ((float)this.丈丒三丏专且丆万丙().Count - 1);
            val_13 = val_13 / (float)this.专丝东丘一丐丛丂丛();
            val_13 = val_13 + val_13;
            return (float)val_13;
        }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 一不丄七丘丕丞丑丏()
        {
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  this, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.与专丒丞丐一丒丂东::丝不丕一丐丌世上丅(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙))));
            val_3.Sort(comparison:  new System.Comparison<Rilisoft.GameEventItemContainer>(object:  0, method:  static System.Int32 Rilisoft.丛且世丐丆上七业丁::不丙丝下与丞业不丒(Rilisoft.GameEventItemContainer 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemContainer 丒丈丙丐丏丕丆万丗)));
            return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_3;
        }
        public bool 丒业丌丕七丛丆丒丄()
        {
            if(this.业丑丁丆丕丆丂丅万() != null)
            {
                    return (bool)val_1.LastLapRewardGetted;
            }
            
            return (bool)val_1.LastLapRewardGetted;
        }
        public UnityEngine.Texture 东七丗丝丟丈下世丛()
        {
            if(this.丌丑丁丏丒丙丂且万 != 0)
            {
                    return (UnityEngine.Texture)this.丌丑丁丏丒丙丂且万;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丅三专且丈一丝丂丏())) == true)
            {
                    return (UnityEngine.Texture)this.丌丑丁丏丒丙丂且万;
            }
            
            string val_6 = this.丅三专且丈一丝丂丏();
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) != false)
            {
                    string val_7 = PetInfo.丏且上丒且丂东丂专(世丐丗专丅三丝丑丆:  val_6);
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == true)
            {
                    return (UnityEngine.Texture)this.丌丑丁丏丒丙丂且万;
            }
            
                UnityEngine.Texture val_9 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_7);
            }
            
            this.丌丑丁丏丒丙丂且万 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏(), 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_6), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            return (UnityEngine.Texture)this.丌丑丁丏丒丙丂且万;
        }
        public string 丕丗丙丞丛丞丁专丁()
        {
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) == false)
            {
                    return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏(), 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏()));
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5.Lkey);
        }
        public int 丑专丐丐丏丆东丘万()
        {
            System.Func<System.Int32> val_7;
            System.Func<System.Int32> val_8;
            System.Func<System.Int32> val_9;
            与专丒丞丐一丒丂东.丝丝下不丗专丅丒下 val_1 = new 与专丒丞丐一丒丂东.丝丝下不丗专丅丒下();
            .丝且与丝丒丟万丁专 = this;
            val_7 = this.专丂丗丁丈丄丒东丁;
            if(val_7 != null)
            {
                    return val_5.Invoke();
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_4 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  this.丅三专且丈一丝丂丏());
            .三丐业七丘丂丐下丘 = val_4;
            if(val_4 == null)
            {
                goto label_4;
            }
            
            System.Func<System.Int32> val_5 = null;
            val_8 = val_5;
            val_5 = new System.Func<System.Int32>(object:  val_1, method:  System.Int32 与专丒丞丐一丒丂东.丝丝下不丗专丅丒下::丕上与与三丄丑业丄());
            this.专丂丗丁丈丄丒东丁 = val_8;
            if(val_8 == null)
            {
                goto label_5;
            }
            
            label_7:
            if(val_8 == null)
            {
                    return 0;
            }
            
            return val_5.Invoke();
            label_4:
            if(this.专丂丗丁丈丄丒东丁 != null)
            {
                goto label_7;
            }
            
            label_5:
            System.Func<System.Int32> val_6 = null;
            val_9 = val_6;
            val_6 = new System.Func<System.Int32>(object:  val_1, method:  System.Int32 与专丒丞丐一丒丂东.丝丝下不丗专丅丒下::丄丑丙丐丛三丗三丈());
            this.专丂丗丁丈丄丒东丁 = val_9;
            if(val_9 != null)
            {
                    return val_5.Invoke();
            }
            
            return 0;
        }
        public int 东丂七不丄丑丄丆七()
        {
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏());
            if(val_2 != null)
            {
                    string val_3 = val_2.三与丛丑且丐丈业丌();
                return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this.丅三专且丈一丝丂丏());
            }
            
            return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this.丅三专且丈一丝丂丏());
        }
        public override string 东丙上东业丆不丟丘()
        {
            string val_15;
            var val_16;
            Rilisoft.GameEventChestData val_2 = this.丁专丗万三上丟三丆();
            Rilisoft.丛且世丐丆上七业丁 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  val_2.EventId);
            if(val_3 == null)
            {
                goto label_5;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丅三专且丈一丝丂丏())) == false)
            {
                goto label_8;
            }
            
            val_15 = val_3.丑丐丏丌丑下一丑丒();
            val_16 = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15 = val_13.Lkey);
            label_5:
            Rilisoft.GameEventChestData val_7 = this.丁专丗万三上丟三丆();
            return (string)"#CHEST_NAME_" + val_7.ChestId;
            label_8:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) == false)
            {
                    return 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.丅三专且丈一丝丂丏());
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丅三专且丈一丝丂丏())) == null)
            {
                    return (string)"#CHEST_NAME_" + val_7.ChestId;
            }
            
            val_16 = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15);
        }
        public void 东七丁丝丁丁东丁上(System.Action<Rilisoft.与专丒丞丐一丒丂东> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丞专丂不七丅丛与丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丞专丂不七丅丛与丒 != 1152921542911723176);
        
        }
        public void 丟丝丙世业与三丌上(System.Action<Rilisoft.与专丒丞丐一丒丂东> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丞专丂不七丅丛与丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丞专丂不七丅丛与丒 != 1152921542911859752);
        
        }
        internal 丈丞丕丘丕丗与上一 七丏丐丛七一东丄丕(int 七丁丐丘丏丕丂丅七)
        {
            if((this.<专业业丑丞七丌万上>k__BackingField) != null)
            {
                    return this.<专业业丑丞七丌万上>k__BackingField.Item[System.Math.Min(val1:  七丁丐丘丏丕丂丅七, val2:  (this.<专业业丑丞七丌万上>k__BackingField.Count) - 1)];
            }
            
            return this.<专业业丑丞七丌万上>k__BackingField.Item[System.Math.Min(val1:  七丁丐丘丏丕丂丅七, val2:  (this.<专业业丑丞七丌万上>k__BackingField.Count) - 1)];
        }
        public T 丄丆丁丝丆下业万一<T>()
        {
            var val_3;
            var val_4;
            val_3 = __RuntimeMethodHiddenParam;
            object val_1 = this.丌下下丟丂丆丟万万();
            if(val_1 == null)
            {
                    return (object)val_4;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48];
            val_3 = __RuntimeMethodHiddenParam + 48;
            if(val_1 != null)
            {
                    val_4 = val_1;
                if(val_4 != null)
            {
                    return (object)val_4;
            }
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丙丁丐丞三丘丕上丕(int 丒丝丆一丏专且丌丝)
        {
            var val_3;
            if(this.丌丅丒丙丂丒一不七 == null)
            {
                    this.丂丙丗丄丄东且丗世();
            }
            
            if(this.一丄丁丙下专丑丘丝.Count > 丒丝丆一丏专且丌丝)
            {
                    System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_2 = this.一丄丁丙下专丑丘丝.Item[丒丝丆一丏专且丌丝];
                return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_3;
            }
            
            val_3 = 0;
            return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_3;
        }
        public Rilisoft.GameEventItemContainer 丆专万丄不丆丙丟专(int 丒丝丆一丏专且丌丝)
        {
            var val_6;
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_8;
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_1 = this.丙丁丐丞三丘丕上丕(丒丝丆一丏专且丌丝:  丒丝丆一丏专且丌丝);
            if(val_1 == null)
            {
                    return (Rilisoft.GameEventItemContainer)System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_1, predicate:  System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_2 = null);
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = 与专丒丞丐一丒丂东.<>c.<>9__74_0;
            if(val_8 != null)
            {
                    return (Rilisoft.GameEventItemContainer)System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_1, predicate:  val_2);
            }
            
            val_8 = val_2;
            val_2 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  与专丒丞丐一丒丂东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与专丒丞丐一丒丂东.<>c::丌丄上丗业上丙业且(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            与专丒丞丐一丒丂东.<>c.<>9__74_0 = val_8;
            return (Rilisoft.GameEventItemContainer)System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_1, predicate:  val_2);
        }
        public Rilisoft.GameEventItem 且丗丌一万一丁丐不(int 丒丝丆一丏专且丌丝)
        {
            var val_5;
            Rilisoft.GameEventItemContainer val_6 = this.丆专万丄不丆丙丟专(丒丝丆一丏专且丌丝:  丒丝丆一丏专且丌丝);
            if(val_6 == null)
            {
                    return (Rilisoft.GameEventItem)val_6.Item[0];
            }
            
            val_5 = 0;
            if(val_6.AnyItemAvailableToDrop == false)
            {
                    return (Rilisoft.GameEventItem)val_6.Item[0];
            }
            
            val_6 = val_6.AvailableToDropItems;
            return (Rilisoft.GameEventItem)val_6.Item[0];
        }
        private void 丂丙丗丄丄东且丗世()
        {
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            if(this.业丑丁丆丕丆丂丅万() == null)
            {
                goto label_6;
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            if(val_2.ContainersPositions == null)
            {
                goto label_6;
            }
            
            ChestProgressDataObject val_3 = this.业丑丁丆丕丆丂丅万();
            if(val_3.ContainersPositions.Count == 0)
            {
                goto label_6;
            }
            
            this.丌丅丒丙丂丒一不七 = new System.Collections.Generic.List<Rilisoft.GameEventItemContainer>();
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_6 = this.业业世七丛丌业丙丅();
            val_25 = 0;
            goto label_7;
            label_10:
            this.丌丅丒丙丂丒一不七.Add(item:  0);
            val_25 = 1;
            label_7:
            if(val_25 < val_6.Count)
            {
                goto label_10;
            }
            
            与专丒丞丐一丒丂东.丐上丆丙且丕上不专 val_8 = new 与专丒丞丐一丒丂东.丐上丆丙且丕上不专();
            if(val_8 == null)
            {
                goto label_11;
            }
            
            .丝且与丝丒丟万丁专 = this;
            goto label_12;
            label_6:
            this.丌丅丒丙丂丒一不七 = this.业业世七丛丌业丙丅();
            goto label_13;
            label_11:
            mem[24] = this;
            label_12:
            val_26 = 0;
            goto label_14;
            label_18:
            this.丌丅丒丙丂丒一不七.set_Item(index:  (与专丒丞丐一丒丂东.丐上丆丙且丕上不专)[1152921542912831856].七丞丙丒三丕且丌丟, value:  System.Linq.Enumerable.First<Rilisoft.GameEventItemContainer>(source:  val_6, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  val_8, method:  System.Boolean 与专丒丞丐一丒丂东.丐上丆丙且丕上不专::丟丐丂丈丁丞丐上业(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙))));
            val_26 = (与专丒丞丐一丒丂东.丐上丆丙且丕上不专)[1152921542912831856].七丞丙丒三丕且丌丟 + 1;
            label_14:
            .七丞丙丒三丕且丌丟 = val_26;
            ChestProgressDataObject val_12 = this.业丑丁丆丕丆丂丅万();
            if(val_26 < val_12.ContainersPositions.Count)
            {
                goto label_18;
            }
            
            val_27 = 0;
            goto label_19;
            label_27:
            Rilisoft.GameEventItemContainer val_14 = val_6.Item[0];
            if((this.丌丅丒丙丂丒一不七.Contains(item:  val_14)) != true)
            {
                    int val_16 = this.丌丅丒丙丂丒一不七.IndexOf(item:  0);
                if((val_16 & 2147483648) == 0)
            {
                    this.丌丅丒丙丂丒一不七.set_Item(index:  val_16, value:  val_14);
            }
            
            }
            
            val_27 = 1;
            label_19:
            if(val_27 < val_6.Count)
            {
                goto label_27;
            }
            
            label_13:
            if(this.一丄丁丙下专丑丘丝 != null)
            {
                    this.一丄丁丙下专丑丘丝.Clear();
            }
            else
            {
                    this.一丄丁丙下专丑丘丝 = new System.Collections.Generic.List<System.Collections.Generic.List<Rilisoft.GameEventItemContainer>>();
            }
            
            int val_19 = this.丆丈业丏丑丟丆丒丈();
            val_28 = 0;
            goto label_34;
            label_39:
            int val_21 = val_28 / val_19;
            val_21 = val_28 - (val_21 * val_19);
            if(val_21 == 0)
            {
                goto label_32;
            }
            
            label_37:
            0.Add(item:  this.丌丅丒丙丂丒一不七.Item[0]);
            val_28 = 1;
            goto label_34;
            label_32:
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_22 = new System.Collections.Generic.List<Rilisoft.GameEventItemContainer>();
            this.一丄丁丙下专丑丘丝.Add(item:  val_22);
            if(val_22 != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_34:
            if(val_28 < this.丌丅丒丙丂丒一不七.Count)
            {
                goto label_39;
            }
        
        }
        public float 丗丏上丞丐丞丛丒丄(int 丒丝丆一丏专且丌丝)
        {
            System.Collections.Generic.List<System.Int32> val_13;
            if(this.专且丌丁丙丂上丘丄() == 丒丝丆一丏专且丌丝)
            {
                    val_13 = this.业丑丁丆丕丆丂丅万();
                if(val_2.DropContainersHistory == null)
            {
                    return 0f;
            }
            
                ChestProgressDataObject val_3 = this.业丑丁丆丕丆丂丅万();
                val_13 = val_3.DropContainersHistory;
                if(val_13.Count < 1)
            {
                    return 0f;
            }
            
                val_13 = this.丈丒三丏专且丆万丙().IndexOf(item:  this.丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0));
                if(val_13 < 1)
            {
                    return 0f;
            }
            
                var val_11 = ((this.专丝东丘一丐丛丂丛() - 1) == 丒丝丆一丏专且丌丝) ? 1 : 0;
                val_11 = this.丆丈业丏丑丟丆丒丈() - val_11;
                float val_13 = (float)val_13;
                val_13 = val_13 / (float)val_11;
                return 0f;
            }
            
            if(this.专且丌丁丙丂上丘丄() <= 丒丝丆一丏专且丌丝)
            {
                    return 0f;
            }
            
            return 0f;
        }
        public bool 世不万丙丏丁丞丄三(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且, bool 世一一丝三丞丅下业)
        {
            var val_11;
            var val_12;
            if(世一一丝三丞丅下业 != false)
            {
                    System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_1 = this.丈丒三丏专且丆万丙();
            }
            else
            {
                    val_11 = this;
            }
            
            val_12 = val_11;
            if((this.Contains(item:  万三丂且丆三且丝且)) == false)
            {
                    return (bool)0 & 1;
            }
            
            if(万三丂且丆三且丝且.AnyItemAvailableToDrop == false)
            {
                    return (bool)0 & 1;
            }
            
            val_12 = this.丁且且丐不丝丐下丘();
            if((val_12.Contains(item:  万三丂且丆三且丝且.Id)) != false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_11 = (this.万丐丘丟丂丛丂丈万().Contains(item:  万三丂且丆三且丝且.Id)) ^ 1;
            return (bool)0 & 1;
        }
        public override void 丑七丂丌世与七丏与(Rilisoft.GameEventChestData 丄丌丟东专业丗丟丆, string 丟丟丄专上丟丁丐丝, int 丅且三万丘丙业丙丗)
        {
            var val_8;
            int val_9;
            var val_10;
            Rilisoft.GameEventChestPriceContainer val_11;
            var val_12;
            val_9 = 丅且三万丘丙业丙丗;
            val_10 = this;
            this.丑七丂丌世与七丏与(丄丌丟东专业丗丟丆:  丄丌丟东专业丗丟丆, 丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丅且三万丘丙业丙丗:  val_9);
            if(丄丌丟东专业丗丟丆 == null)
            {
                    return;
            }
            
            int val_2 = 丄丌丟东专业丗丟丆.ExcludeItemsAmount;
            this.<三下与丌世东丌丝丅>k__BackingField = 0;
            mem[1152921542913340832] = 0;
            val_9 = 丄丌丟东专业丗丟丆.ResetPrice;
            val_11 = val_9;
            if(val_9 == null)
            {
                    val_11 = 丄丌丟东专业丗丟丆.ResetPrice;
                if(val_11 == null)
            {
                goto label_15;
            }
            
            }
            
            this.<丘丒且丈丕丆专专下>k__BackingField = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丄丌丟东专业丗丟丆.ResetPrice.Price, 丏丂不专上丘丂不丅:  丄丌丟东专业丗丟丆.ResetPrice.Currency);
            System.Collections.Generic.List<丈丞丕丘丕丗与上一> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Collections.Generic.List<丈丞丕丘丕丗与上一>();
            this.<专业业丑丞七丌万上>k__BackingField = val_9;
            List.Enumerator<T> val_5 = 丄丌丟东专业丗丟丆.OpenPrices.GetEnumerator();
            val_8 = 1152921542913301296;
            label_9:
            if(((-348224104) & 1) == 0)
            {
                goto label_5;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                
            }
            else
            {
                    val_12 = 28563616;
            }
            
            new 丈丞丕丘丕丗与上一() = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  28563616, 丏丂不专上丘丂不丅:  val_6.m_stringLength);
            this.<专业业丑丞七丌万上>k__BackingField.Add(item:  new 丈丞丕丘丕丗与上一());
            goto label_9;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_15:
            if(Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑() == 1)
            {
                    val_10 = 1179403647;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                if(val_10 == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        public void 丄三丏丏丆专丟上丛(System.Collections.Generic.List<int> 丄丗丙东丌且不丕丘)
        {
            System.Collections.Generic.List<System.Int32> val_3 = 丄丗丙东丌且不丕丘;
            if(val_3 == null)
            {
                    System.Collections.Generic.List<System.Int32> val_1 = null;
                val_3 = val_1;
                val_1 = new System.Collections.Generic.List<System.Int32>();
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            val_2.ExcludeContainers = val_3;
        }
        public void 丑丌丌世丌丅七七世(System.Collections.Generic.List<int> 丄丗丙东丌且不丕丘)
        {
            System.Collections.Generic.List<System.Int32> val_3 = 丄丗丙东丌且不丕丘;
            if(val_3 == null)
            {
                    System.Collections.Generic.List<System.Int32> val_1 = null;
                val_3 = val_1;
                val_1 = new System.Collections.Generic.List<System.Int32>();
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            val_2.DroppedContainers = val_3;
        }
        public void 不丂丟丒丕丗丑三不(System.Collections.Generic.List<int> 丄丗丙东丌且不丕丘)
        {
            System.Collections.Generic.List<System.Int32> val_3 = 丄丗丙东丌且不丕丘;
            if(val_3 == null)
            {
                    System.Collections.Generic.List<System.Int32> val_1 = null;
                val_3 = val_1;
                val_1 = new System.Collections.Generic.List<System.Int32>();
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            val_2.ContainersPositions = val_3;
            this.丌丅丒丙丂丒一不七 = 0;
        }
        public void 与丄一下一且下万且(int 丏丆丑丗七丄丙丝与, int 丒丈丙丐丏丕丆万丗)
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            丞东丑专丛丆丄丝世.与万丞丌丂丗丆东丁<System.Int32>(丝丘丑业丛万丞丌丝:  val_1.ContainersPositions, 与丕丁三万专世不丅:  丏丆丑丗七丄丙丝与, 丏丛与丅丛丌万专丌:  丒丈丙丐丏丕丆万丗);
            this.丌丅丒丙丂丒一不七 = 0;
        }
        public void 丕且专一三不世东丈(int 丒丁东世世丗丅丅丄)
        {
            if((this.丁且且丐不丝丐下丘().Contains(item:  丒丁东世世丗丅丅丄)) != false)
            {
                    return;
            }
            
            this.丁且且丐不丝丐下丘().Add(item:  丒丁东世世丗丅丅丄);
        }
        public bool 丅不丛不丟丄且丄丙(int 丒丁东世世丗丅丅丄)
        {
            System.Collections.Generic.List<System.Int32> val_1 = this.丁且且丐不丝丐下丘();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            System.Collections.Generic.List<System.Int32> val_2 = this.丁且且丐不丝丐下丘();
            if(val_2 != null)
            {
                    return val_2.Contains(item:  丒丁东世世丗丅丅丄);
            }
            
            return val_2.Contains(item:  丒丁东世世丗丅丅丄);
        }
        public int 与丑世且万丝丈丌七(Rilisoft.GameEventItemContainer 七不丛丁万丕且丙丞)
        {
            Rilisoft.GameEventItemContainer val_7;
            int val_8;
            val_7 = 七不丛丁万丕且丙丞;
            if(val_7 != null)
            {
                    int val_1 = this.丌丅丒丙丂丒一不七.IndexOf(item:  val_7);
                if((val_1 & 2147483648) == 0)
            {
                    val_8 = UnityEngine.Mathf.FloorToInt(f:  (float)val_1 / this.丆丈业丏丑丟丆丒丈());
                object[] val_5 = new object[2];
                val_5[0] = val_7.Id;
                val_7 = val_8;
                val_5[1] = val_7;
                UnityEngine.Debug.LogFormat(format:  "[LAP] for container \'{0}\': {1}", args:  val_5);
                return (int)val_8;
            }
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        public void 下三与丞不且丘丅丝(int 丒丁东世世丗丅丅丄)
        {
            if(val_1.DropContainersHistory == null)
            {
                    this.业丑丁丆丕丆丂丅万() = this.业丑丁丆丕丆丂丅万();
                val_2.DropContainersHistory = new System.Collections.Generic.List<System.Int32>();
            }
            
            ChestProgressDataObject val_4 = this.业丑丁丆丕丆丂丅万();
            val_4.DropContainersHistory.Add(item:  丒丁东世世丗丅丅丄);
        }
        public void 一丈丘七丙丙丁三丕()
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            val_1.LastLapRewardGetted = true;
        }
        public System.Collections.Generic.List<int> 丗七丂不丈丈丂丟丑()
        {
            var val_7;
            System.Collections.Generic.IEnumerable<TSource> val_8;
            System.Collections.Generic.List<System.Int32> val_9;
            var val_10;
            System.Func<Rilisoft.GameEventItemContainer, System.Int32> val_12;
            val_7 = 0;
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            if(val_1.ContainersPositions != null)
            {
                    ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
                val_7 = public System.Int32 System.Collections.Generic.List<System.Int32>::get_Count();
                if(val_2.ContainersPositions.Count != 0)
            {
                    val_8 = this.业丑丁丆丕丆丂丅万();
                val_9 = val_4.ContainersPositions;
                return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventItemContainer, System.Int32>(source:  this, selector:  System.Func<Rilisoft.GameEventItemContainer, System.Int32> val_5 = null));
            }
            
            }
            
            val_8 = this;
            val_10 = null;
            val_10 = null;
            val_12 = 与专丒丞丐一丒丂东.<>c.<>9__89_0;
            if(val_12 != null)
            {
                    return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventItemContainer, System.Int32>(source:  this, selector:  val_5));
            }
            
            val_12 = val_5;
            val_5 = new System.Func<Rilisoft.GameEventItemContainer, System.Int32>(object:  与专丒丞丐一丒丂东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 与专丒丞丐一丒丂东.<>c::丒丑丁下上丟下东丁(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            与专丒丞丐一丒丂东.<>c.<>9__89_0 = val_12;
            return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventItemContainer, System.Int32>(source:  this, selector:  val_5));
        }
        public Rilisoft.GameEventItemContainer 丂丄七丒与丐下且丘(int 且丟丑世丆万丏不世 = 0)
        {
            int val_12 = 且丟丑世丆万丏不世;
            if(this.丌丅丒丙丂丒一不七 == null)
            {
                    return 0;
            }
            
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            if(val_2.DropContainersHistory == null)
            {
                    return 0;
            }
            
            ChestProgressDataObject val_3 = this.业丑丁丆丕丆丂丅万();
            if((val_3.DropContainersHistory.Count - 1) < val_12)
            {
                    return 0;
            }
            
            ChestProgressDataObject val_6 = this.业丑丁丆丕丆丂丅万();
            val_12 = val_6.DropContainersHistory.Count + (~val_12);
            ChestProgressDataObject val_8 = this.业丑丁丆丕丆丂丅万();
            .丞丅上丏丂且下丅与 = val_8.DropContainersHistory.Item[val_12];
            Rilisoft.GameEventItemContainer val_11 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  this.丌丅丒丙丂丒一不七, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new 与专丒丞丐一丒丂东.与且世丛丗丞三丞且(), method:  System.Boolean 与专丒丞丐一丒丂东.与且世丛丗丞三丞且::东丝丝与丙一上专丕(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)));
            return 0;
        }
        public void 丘丕万丏丝丑丅丅丛()
        {
            var val_10;
            System.Func<System.Boolean> val_12;
            ChestProgressDataObject val_3 = this.业丑丁丆丕丆丂丅万();
            val_3.SpinsCount = this.丟丝与丙东世丗丞与() + 1;
            ChestProgressDataObject val_4 = this.业丑丁丆丕丆丂丅万();
            if(val_4.ResetInterval > 0)
            {
                    return;
            }
            
            if(this.丟丝与丙东世丗丞与() < 1)
            {
                    return;
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    this.上世且丗万业一丙丅();
                return;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = 与专丒丞丐一丒丂东.<>c.<>9__91_0;
            if(val_12 == null)
            {
                    System.Func<System.Boolean> val_7 = null;
                val_12 = val_7;
                val_7 = new System.Func<System.Boolean>(object:  与专丒丞丐一丒丂东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与专丒丞丐一丒丂东.<>c::不丂丗世东丕与丐丄());
                与专丒丞丐一丒丂东.<>c.<>9__91_0 = val_12;
            }
            
            UnityEngine.Coroutine val_9 = CoroutineRunner.丆万七与丏丁丞丂专(且丐丈丕三丟丕丙丒:  val_7, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void Rilisoft.与专丒丞丐一丒丂东::上世且丗万业一丙丅()));
        }
        public void 世三下七东一七丐丈()
        {
            var val_5;
            System.Func<Rilisoft.GameEventItemContainer, System.Int32> val_7;
            this.丌丅丒丙丂丒一不七 = 0;
            val_5 = null;
            val_5 = null;
            val_7 = 与专丒丞丐一丒丂东.<>c.<>9__92_0;
            if(val_7 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, System.Int32> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<Rilisoft.GameEventItemContainer, System.Int32>(object:  与专丒丞丐一丒丂东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 与专丒丞丐一丒丂东.<>c::丂丟丘东世丞丗上丄(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                与专丒丞丐一丒丂东.<>c.<>9__92_0 = val_7;
            }
            
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventItemContainer, System.Int32>(source:  this.业业世七丛丌业丙丅(), selector:  val_2));
            丞东丑专丛丆丄丝世.万丕业万不丐与丂丐<System.Int32>(丝丘丑业丛万丞丌丝:  val_4, 丂丆且一丛丙丑七丒:  0);
            this.不丂丟丒丕丗丑三不(丄丗丙东丌且不丕丘:  val_4);
            this.丗丄丐万丏业丏丑万();
        }
        public bool 丅丄与三丅丌万三且()
        {
            var val_5;
            int val_6;
            var val_7;
            ChestProgressDataObject val_2 = this.业丑丁丆丕丆丂丅万();
            if(val_2.CurrentLap >= (this.专丝东丘一丐丛丂丛() - 1))
            {
                goto label_2;
            }
            
            val_5 = this.业丑丁丆丕丆丂丅万();
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_6 = val_4.CurrentLap;
            goto label_4;
            label_2:
            val_7 = 0;
            return (bool)val_7;
            label_3:
            val_5 = 32;
            val_6 = 64;
            label_4:
            mem[32] = 65;
            this.丗丄丐万丏业丏丑万();
            if(this.丞专丂不七丅丛与丒 != null)
            {
                    this.丞专丂不七丅丛与丒.Invoke(obj:  this);
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        private void 上世且丗万业一丙丅()
        {
            Rilisoft.GameEventChestData val_1 = this.丁专丗万三上丟三丆();
            if(val_1.ResetIntervals.Count == 0)
            {
                    return;
            }
            
            Rilisoft.GameEventChestData val_3 = this.丁专丗万三上丟三丆();
            Rilisoft.GameEventChestData val_6 = this.丁专丗万三上丟三丆();
            ChestProgressDataObject val_8 = this.业丑丁丆丕丆丂丅万();
            val_8.ResetInterval = val_6.ResetIntervals.Item[UnityEngine.Random.Range(min:  0, max:  val_3.ResetIntervals.Count)];
            this = this.业丑丁丆丕丆丂丅万();
            val_9.LastResetTime = FriendsController.丝丗专上三不丄丑丑();
        }
        public override void 且七丙丄丘一丄上不()
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            val_1.SpinsCount = 0;
            this.丄三丏丏丆专丟上丛(丄丗丙东丌且不丕丘:  new System.Collections.Generic.List<System.Int32>());
            this.丑丌丌世丌丅七七世(丄丗丙东丌且不丕丘:  new System.Collections.Generic.List<System.Int32>());
            this.不丂丟丒丕丗丑三不(丄丗丙东丌且不丕丘:  new System.Collections.Generic.List<System.Int32>());
            ChestProgressDataObject val_5 = this.业丑丁丆丕丆丂丅万();
            val_5.ResetInterval = 0;
            ChestProgressDataObject val_6 = this.业丑丁丆丕丆丂丅万();
            val_6.LastResetTime = 0;
            ChestProgressDataObject val_7 = this.业丑丁丆丕丆丂丅万();
            val_7.DropContainersHistory = new System.Collections.Generic.List<System.Int32>();
            ChestProgressDataObject val_9 = this.业丑丁丆丕丆丂丅万();
            val_9.CurrentLap = 0;
            ChestProgressDataObject val_10 = this.业丑丁丆丕丆丂丅万();
            val_10.LastLapRewardGetted = false;
        }
        internal void 东丁丈丌且七丄上丝()
        {
            ChestProgressDataObject val_1 = this.业丑丁丆丕丆丂丅万();
            val_1.SpinsCount = 0;
        }
        public 与专丒丞丐一丒丂东()
        {
        
        }
        private bool 丕丁丁下丅且世万万(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌)
        {
            if(丏丛与丅丛丌万专丌.上七不丅丈丁不丛丝 == null)
            {
                    return false;
            }
            
            return System.String.op_Equality(a:  丏丛与丅丛丌万专丌.上七不丅丈丁不丛丝.下丄丈不与世丐业专, b:  this.丅三专且丈一丝丂丏());
        }
        private bool 丝不丕一丐丌世上丅(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)
        {
            var val_9;
            int val_10;
            var val_11;
            val_10 = 丁丂专业丁丅丅丈丙;
            if(val_10.AnyItemAvailableToDrop == false)
            {
                goto label_2;
            }
            
            val_9 = this.丁且且丐不丝丐下丘();
            if((val_9.Contains(item:  val_10.Id)) == false)
            {
                goto label_5;
            }
            
            label_2:
            val_11 = 0;
            goto label_6;
            label_5:
            val_10 = val_10.Id;
            bool val_7 = this.万丐丘丟丂丛丂丈万().Contains(item:  val_10);
            val_11 = val_7 ^ 1;
            label_6:
            val_7 = val_11;
            return (bool)val_7;
        }
    
    }

}
