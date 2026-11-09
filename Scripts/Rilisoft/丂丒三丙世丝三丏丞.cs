using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丂丒三丙世丝三丏丞
    {
        // Fields
        internal static int 不丛丗七丈东丒丞一;
        internal const string 一且丙丟丁业七丗丄 = "DoubleReward.StoragerKeysInitialized-v5";
        internal const string 丕丒丞丝丘不东丂丐 = "CutomReward.StoragerKeysInitialized";
        internal const string 上丈丟丅且丗丂丌下 = "CutomReward.StoragerKeysConfig";
        internal const string 丆上与丂丝一专七一 = "CutomReward.StoragerKeysConfigCoef";
        internal const string 丅丑丌丄下丁下三丂 = "CutomReward.RewardOffset";
        private static readonly Rilisoft.丂丒三丙世丝三丏丞 世丒丞七专三与万丕;
        private static readonly System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 丟七不一丌丈丞三丈;
        private readonly System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 丝丗丑世丈下世丁丁;
        internal int 东三丂丌万丛丂丐不;
        private bool <丛丌且业丆丑丗丘丄>k__BackingField;
        private int <丕三丑一丂一丂七不>k__BackingField;
        
        // Properties
        internal bool 三不专丗七丄且丝业 { get; set; }
        internal int 丑七专丞丑下丌丟丕 { get; set; }
        internal static Rilisoft.丂丒三丙世丝三丏丞 丆丕丝丒不丙且丐丗 { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世> 丑丈丞丅丛丏一丒丙 { get; }
        
        // Methods
        private 丂丒三丙世丝三丏丞()
        {
            this.丝丗丑世丈下世丁丁 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
            this.不东丄丄丅一丞丘丌();
            this.<丛丌且业丆丑丗丘丄>k__BackingField = true;
            this.<丕三丑一丂一丂七不>k__BackingField = 2;
        }
        internal bool 丈丙三三丟七且且丟()
        {
            var val_3 = null;
            return (bool)(ExperienceController.丞丞丘业东丙丏七丌() >= Rilisoft.丂丒三丙世丝三丏丞.丅丑丌丄下丁下三丂) ? 1 : 0;
        }
        internal void 不东丄丄丅一丞丘丌()
        {
            var val_11;
            int val_22;
            System.Collections.Generic.IEnumerable<T> val_23;
            val_22 = this;
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  10)) == null)
            {
                goto label_27;
            }
            
            char[] val_5 = new char[1];
            val_5[0] = ',';
            val_23 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  10).Split(separator:  val_5);
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>(collection:  val_23);
            if((val_7 == null) || (val_7.Count < 1))
            {
                goto label_27;
            }
            
            List.Enumerator<T> val_9 = val_7.GetEnumerator();
            label_21:
            if(((-714726544) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            if((System.String.op_Equality(a:  val_12, b:  System.String.alignConst)) == true)
            {
                goto label_21;
            }
            
            this.丝丗丑世丈下世丁丁.Add(item:  System.Int32.Parse(s:  val_12));
            goto label_21;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_27:
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  null)) == null)
            {
                    return;
            }
            
            val_22 = this.东三丂丌万丛丂丐不;
            bool val_20 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  null), 丙业与丙丗丝不丈东: out  val_22);
        }
        internal bool 世丑三丆丒七丘丕丑()
        {
            return (bool)this.<丛丌且业丆丑丗丘丄>k__BackingField;
        }
        internal void 丏丐丝上三丁丞丝丕(bool 丙业与丙丗丝不丈东)
        {
            this.<丛丌且业丆丑丗丘丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丑丟丕且丛一丒上万()
        {
            return (int)this.<丕三丑一丂一丂七不>k__BackingField;
        }
        internal void 一不丕丁丄丟丈丙七(int 丙业与丙丗丝不丈东)
        {
            this.<丕三丑一丂一丂七不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.丂丒三丙世丝三丏丞 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.丂丒三丙世丝三丏丞)Rilisoft.丂丒三丙世丝三丏丞.世丒丞七专三与万丕;
        }
        internal System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世> 七不丈专丙世丅丕丝()
        {
            null = null;
            return (System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世>)Rilisoft.丂丒三丙世丝三丏丞.丟七不一丌丈丞三丈;
        }
        internal int 丞业不丅丑丙与不不()
        {
            int val_4;
            List.Enumerator<T> val_1 = this.丝丗丑世丈下世丁丁.GetEnumerator();
            label_3:
            if(((-713852360) & 1) == 0)
            {
                goto label_2;
            }
            
            if((this.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  0.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_3;
            }
            
            val_4 = this.东三丂丌万丛丂丐不;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_4 = this.<丕三丑一丂一丂七不>k__BackingField;
            return val_4;
        }
        internal int 丑丆丗丞丈不丘丞丝(Rilisoft.七丕丟丏三丈一丄世 丅丈专上丄丅丛丈业)
        {
            return (int)((this.丝丗丑世丈下世丁丁.Contains(item:  丅丈专上丄丅丛丈业)) != true) ? this.东三丂丌万丛丂丐不 : this.<丕三丑一丂一丂七不>k__BackingField;
        }
        private void 丈丁丂丒上丛丘丏丏(System.Nullable<System.DateTime> 不丗万丘丆丗上丗丏)
        {
            var val_12;
            var val_34;
            var val_35;
            var val_37;
            var val_38;
            string val_39;
            val_34 = this;
            if(((-713501424) & 1) == 0)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  28);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  9, 丙业与丙丗丝不丈东:  不丗万丘丆丗上丗丏.HasValue);
            System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_3 = BalanceController.丒七丑七丗与丂专丌();
            this.东三丂丌万丛丂丐不 = val_3.Value;
            int val_4 = val_3.Value.GetHashCode();
            System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_5 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
            val_35 = null;
            val_35 = null;
            System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_6 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>(collection:  Rilisoft.丂丒三丙世丝三丏丞.丟七不一丌丈丞三丈);
            if(val_4 <= val_6.Count)
            {
                goto label_11;
            }
            
            int val_8 = val_6.Count;
            this.丝丗丑世丈下世丁丁.Clear();
            this.丝丗丑世丈下世丁丁.AddRange(collection:  val_6);
            goto label_44;
            label_11:
            if(this.丝丗丑世丈下世丁丁.Count < 1)
            {
                goto label_29;
            }
            
            List.Enumerator<T> val_10 = val_6.GetEnumerator();
            val_37 = 1152921538307641360;
            val_38 = 1152921538307486672;
            label_23:
            if(((-713501472) & 1) == 0)
            {
                goto label_19;
            }
            
            int val_13 = val_12.丙东专丂世丈丏丁丂();
            if((this.丝丗丑世丈下世丁丁.Contains(item:  val_13)) == true)
            {
                goto label_23;
            }
            
            val_5.Add(item:  val_13);
            goto label_23;
            label_19:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_5 != null)
            {
                goto label_30;
            }
            
            goto label_25;
            label_29:
            if(val_5 != null)
            {
                goto label_30;
            }
            
            label_25:
            label_30:
            if(val_4 >= val_5.Count)
            {
                goto label_31;
            }
            
            this.丝丗丑世丈下世丁丁.Clear();
            if(val_4 < 1)
            {
                goto label_44;
            }
            
            val_38 = 1152921525786468128;
            val_37 = 1152921525774719120;
            var val_33 = 0;
            do
            {
                label_39:
                Rilisoft.七丕丟丏三丈一丄世 val_18 = val_5.Item[UnityEngine.Random.Range(min:  0, max:  val_5.Count)];
            }
            while((this.丝丗丑世丈下世丁丁.Contains(item:  val_18)) == true);
            
            this.丝丗丑世丈下世丁丁.Add(item:  val_18);
            val_33 = val_33 + 1;
            if(val_33 != val_4)
            {
                goto label_39;
            }
            
            goto label_44;
            label_31:
            var val_34 = val_5.Count;
            this.丝丗丑世丈下世丁丁.Clear();
            this.丝丗丑世丈下世丁丁.AddRange(collection:  val_5);
            if(val_34 >= val_4)
            {
                goto label_44;
            }
            
            val_38 = 1152921525786468128;
            do
            {
                label_50:
                Rilisoft.七丕丟丏三丈一丄世 val_23 = val_6.Item[UnityEngine.Random.Range(min:  0, max:  val_6.Count)];
            }
            while((this.丝丗丑世丈下世丁丁.Contains(item:  val_23)) == true);
            
            this.丝丗丑世丈下世丁丁.Add(item:  val_23);
            val_34 = val_34 + 1;
            if(val_34 != val_4)
            {
                goto label_50;
            }
            
            label_44:
            val_39 = "";
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  11, 丙业与丙丗丝不丈东:  this.东三丂丌万丛丂丐不);
            List.Enumerator<T> val_26 = this.丝丗丑世丈下世丁丁.GetEnumerator();
            label_56:
            if(((-713501472) & 1) == 0)
            {
                goto label_55;
            }
            
            string val_30 = val_39 + val_12.丙东专丂世丈丏丁丂().ToString()(val_39 + val_12.丙东专丂世丈丏丁丂().ToString()) + ",";
            goto label_56;
            label_55:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  10, 丙业与丙丗丝不丈东:  null);
            val_34 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_34.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal System.Nullable<long> 丘丗丅丙丝丈丆丏不()
        {
            var val_7;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            val_7 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((-713286976) & 1) == 0)
            {
                    return 0;
            }
            
            System.DateTime val_2 = val_1.HasValue.Date;
            System.DateTime val_3 = val_2.dateData.AddDays(value:  1);
            System.TimeSpan val_4 = val_3.dateData.Subtract(value:  new System.DateTime() {});
            val_7 = System.Convert.ToInt64(value:  val_4._ticks.TotalSeconds);
            return 0;
        }
        internal System.Nullable<System.DateTime> 不丒丈不一丕丄丛丈(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            Rilisoft.七丕丟丏三丈一丄世 val_8;
            Progress.与丄东丄丘丐丙丅业 val_9;
            val_8 = 上且丗一丏丏万丅丌;
            val_9 = 12;
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  val_9);
            if(val_2 == null)
            {
                    return 0;
            }
            
            val_9 = val_8.ToString();
            if((val_2.ContainsKey(key:  val_9)) == false)
            {
                    return 0;
            }
            
            val_8 = val_2.Item[val_8.ToString()];
            if((System.DateTime.TryParse(s:  val_8, result: out  new System.DateTime())) == false)
            {
                    return 0;
            }
            
            val_9 = 0;
            return 0;
        }
        internal bool 东不丗丆丗丛丈丑丅(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            var val_3;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) != 0)
            {
                    val_3 = this;
                bool val_2 = this.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丅丏丅丂丝一丆丙丅:  new System.DateTime() {});
            }
            else
            {
                    val_3 = 0;
            }
            
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        internal bool 东不丗丆丗丛丈丑丅(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, System.DateTime 丅丏丅丂丝一丆丙丅)
        {
            System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_41;
            var val_42;
            string val_44;
            int val_45;
            if((this.<丛丌且业丆丑丗丘丄>k__BackingField) == false)
            {
                    return false;
            }
            
            val_41 = ExperienceController.丞丞丘业东丙丏七丌();
            val_42 = null;
            val_42 = null;
            if(val_41 < Rilisoft.丂丒三丙世丝三丏丞.丅丑丌丄下丁下三丂)
            {
                    return false;
            }
            
            val_41 = Rilisoft.丂丒三丙世丝三丏丞.丟七不一丌丈丞三丈;
            if((val_41.Contains(item:  上且丗一丏丏万丅丌)) == false)
            {
                    return false;
            }
            
            val_41 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
            if((val_41.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌)) != false)
            {
                    return false;
            }
            
            val_44 = "";
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  9)) != null)
            {
                    val_44 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  9);
            }
            
            int val_9 = 专丈专业丆且且业下.丈不丄丛丛丘东丁丙();
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "CutomReward.RewardOffset")) != false)
            {
                    val_45 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "CutomReward.RewardOffset", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            }
            else
            {
                    var val_41 = 0;
                val_41 = val_41 + val_9;
                val_41 = (val_41 >> 7) + (val_41 >> 31);
                val_45 = val_9 - (val_41 * 180);
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "CutomReward.RewardOffset", 下下丏一丙不丘丌丞:  val_45, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            }
            
            if((System.DateTime.TryParse(s:  val_44, result: out  new System.DateTime())) == false)
            {
                goto label_33;
            }
            
            int val_14 = 0.Year;
            int val_15 = 0.Month;
            int val_16 = 0.Day;
            System.DateTime val_17 = 0.AddSeconds(value:  (double)val_45);
            if(val_17.dateData.Day >= 丅丏丅丂丝一丆丙丅.dateData.Day)
            {
                goto label_37;
            }
            
            System.TimeSpan val_20 = val_17.dateData.TimeOfDay;
            System.TimeSpan val_21 = 丅丏丅丂丝一丆丙丅.dateData.TimeOfDay;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_20._ticks}, t2:  new System.TimeSpan() {_ticks = val_21._ticks})) == false)
            {
                goto label_37;
            }
            
            label_33:
            this.丈丁丂丒上丛丘丏丏(不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = false});
            label_37:
            bool val_23 = this.丝丗丑世丈下世丁丁.Contains(item:  上且丗一丏丏万丅丌);
            Progress.丘东丅丌东丒上七丁 val_42 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            object val_25 = val_42.东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  12);
            if(val_25 == null)
            {
                    return false;
            }
            
            val_42 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_25) : 0;
            if((val_42.ContainsKey(key:  上且丗一丏丏万丅丌.ToString())) == false)
            {
                    return false;
            }
            
            if((System.DateTime.TryParse(s:  val_42.Item[上且丗一丏丏万丅丌.ToString()], result: out  new System.DateTime())) != true)
            {
                    if(val_23 ^ 1 != true)
            {
                    return false;
            }
            
            }
            
            int val_32 = 0.Year;
            int val_33 = 0.Month;
            int val_34 = 0.Day;
            System.DateTime val_35 = 0.AddSeconds(value:  (double)val_45);
            if(val_23 == false)
            {
                    return false;
            }
            
            System.DateTimeOffset val_36 = System.DateTimeOffset.Now;
            System.DateTime val_37 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 丅丏丅丂丝一丆丙丅.dateData}, t:  new System.TimeSpan() {});
            System.TimeSpan val_38 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_37.dateData}, d2:  new System.DateTime() {dateData = val_35.dateData});
            var val_40 = (val_38._ticks.TotalSeconds > 86400) ? 1 : 0;
            return false;
        }
        internal void 丙丛丙专丛不丝丛丑(System.Nullable<System.DateTime> 不丗万丘丆丗上丗丏)
        {
            var val_3;
            var val_4;
            if(((-712683184) & 1) == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            List.Enumerator<T> val_1 = Rilisoft.丂丒三丙世丝三丏丞.丟七不一丌丈丞三丈.GetEnumerator();
            val_3 = 1152921538307641360;
            label_6:
            if(((-712683208) & 1) == 0)
            {
                goto label_5;
            }
            
            int val_2 = 0.丙东专丂世丈丏丁丂();
            val_2.丄丈丅丄七业丁上丐(上且丗一丏丏万丅丌:  val_2, 不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = 不丗万丘丆丗上丗丏.HasValue});
            goto label_6;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丄丈丅丄七业丁上丐(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, System.Nullable<System.DateTime> 不丗万丘丆丗上丗丏)
        {
            Rilisoft.七丕丟丏三丈一丄世 val_9;
            System.Collections.Generic.IDictionary<TKey, TValue> val_10;
            var val_11;
            val_9 = 上且丗一丏丏万丅丌;
            if(((-712542528) & 1) == 0)
            {
                    return;
            }
            
            System.DateTimeOffset val_1 = System.DateTimeOffset.Now;
            System.DateTime val_2 = System.DateTime.op_Addition(d:  new System.DateTime() {}, t:  new System.TimeSpan() {});
            val_10 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  12);
            val_11 = null;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = null;
            val_10 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_11 = null;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>(dictionary:  val_5);
            val_6.set_Item(key:  val_9.ToString(), value:  val_2.dateData);
            val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_9.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  12, 丙业与丙丗丝不丈东:  val_6);
        }
        internal bool 丌丄丕丁丗丝且丞一(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, ref System.Collections.Generic.Dictionary<string, object> 七丆世丌丆丟丙丆业)
        {
            Rilisoft.七丕丟丏三丈一丄世 val_13;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_14;
            var val_15;
            val_13 = 上且丗一丏丏万丅丌;
            val_14 = this;
            if((this.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_13)) == false)
            {
                goto label_13;
            }
            
            System.Nullable<System.DateTime> val_2 = FriendsController.业丈丏丏丞丘丛丈丛();
            val_14 = 七丆世丌丆丟丙丆业;
            if((val_14 == null) || ((val_14.ContainsKey(key:  val_13.ToString())) == false))
            {
                goto label_13;
            }
            
            if((System.DateTime.TryParse(s:  七丆世丌丆丟丙丆业.Item[val_13.ToString()], result: out  new System.DateTime())) == false)
            {
                goto label_10;
            }
            
            System.DateTime val_8 = 0.Date;
            val_14 = val_8.dateData;
            System.DateTime val_9 = val_2.HasValue.Date;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_14}, t2:  new System.DateTime() {dateData = val_9.dateData})) == false)
            {
                goto label_13;
            }
            
            label_10:
            Rilisoft.一丟专且三万丞丁丂.丅七三东东上丒业丏(上且丗一丏丏万丅丌:  val_13);
            val_14;
            val_13 = val_13.ToString();
            七丆世丌丆丟丙丆业.set_Item(key:  val_13, value:  val_2.HasValue);
            val_15 = 1;
            return (bool)val_15;
            label_13:
            val_15 = 0;
            return (bool)val_15;
        }
        internal static void 丁丒丑丈世一专丝丛()
        {
        
        }
        internal static string 丑与丙丝下丛丐不东(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            return (string)"LastDateDoubleReward." + 上且丗一丏丏万丅丌;
        }
        internal static string 七丘丗万丆丆丛丕世(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            return (string)"LastDateDoubleReward.Analytics." + 上且丗一丏丏万丅丌;
        }
        private static 丂丒三丙世丝三丏丞()
        {
            Rilisoft.丂丒三丙世丝三丏丞.丅丑丌丄下丁下三丂 = 4;
            Rilisoft.丂丒三丙世丝三丏丞.世丒丞七专三与万丕 = new Rilisoft.丂丒三丙世丝三丏丞();
            System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_2 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
            if(val_2 != null)
            {
                    val_2.Add(item:  2);
                val_2.Add(item:  0);
                val_2.Add(item:  1);
                val_2.Add(item:  4);
                val_2.Add(item:  5);
                val_2.Add(item:  3);
                val_2.Add(item:  20);
                val_2.Add(item:  8);
                val_2.Add(item:  16);
                val_2.Add(item:  17);
            }
            else
            {
                    val_2.Add(item:  2);
                val_2.Add(item:  0);
                val_2.Add(item:  1);
                val_2.Add(item:  4);
                val_2.Add(item:  5);
                val_2.Add(item:  3);
                val_2.Add(item:  20);
                val_2.Add(item:  8);
                val_2.Add(item:  16);
                val_2.Add(item:  17);
            }
            
            val_2.Add(item:  31);
            Rilisoft.丂丒三丙世丝三丏丞.丟七不一丌丈丞三丈 = val_2;
        }
    
    }

}
