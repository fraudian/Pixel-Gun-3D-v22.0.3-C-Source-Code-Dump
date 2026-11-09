using UnityEngine;

namespace Rilisoft
{
    internal class 丟下且且与丗丒丛与
    {
        // Fields
        internal static readonly string 东世丄丕丞东三下丏;
        internal static readonly string 丒与丌丝丐丅与丕丆;
        internal static readonly string 丑丑丒丑丙丐丞与丈;
        internal static readonly string 业丕丐东丑丒丁丒丙;
        internal static readonly string 世丄丒丒丛丑丈丕一;
        internal static readonly string 丈丏丝与丄丑与业丙;
        internal static readonly string 一丑丄下丑丆且世一;
        private static readonly string 且且业丌专丗丑专三;
        private static readonly string 丞东丟不世丐下丈丑;
        private static readonly string 不下上下丞与七东下;
        private static readonly string 七丟丐一七丕丝丁丂;
        private static readonly string 三丕丁三丌丒丕上上;
        private static readonly string 且丑专世不一丛丘丞;
        private static readonly string 丝丏丏丏上上丕万丆;
        private static readonly string 丕万丅丂丄业丑七丑;
        private static readonly string 丌丗业丑丌业丒丐丏;
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.丆丐丄且丟丏丞丈丂.世东丆丞业丂丐三丁 专丞丙一丟专丞与丗)
        {
            var val_8;
            var val_15;
            string val_16;
            var val_17;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(专丞丙一丟专丞与丗.上丄丒丗丆世专七丟().Count == 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<System.Object> val_4 = new System.Collections.Generic.List<System.Object>();
            List.Enumerator<T> val_6 = 专丞丙一丟专丞与丗.上丄丒丗丆世专七丟().GetEnumerator();
            label_8:
            if(((-307547920) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            val_4.Add(item:  val_9.丈万上丙丝丂丑丄丂(且一丑丏上丙七一丅:  val_9));
            goto label_8;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_15 = null;
            val_15 = null;
            val_1.Add(key:  Rilisoft.丟下且且与丗丒丛与.世丄丒丒丛丑丈丕一, value:  val_4);
            label_3:
            val_16 = 专丞丙一丟专丞与丗.丙丈丄丕上丝东丐丞();
            if(val_16.Count == 0)
            {
                    return val_1;
            }
            
            val_17 = null;
            val_17 = null;
            val_16 = Rilisoft.丟下且且与丗丒丛与.丈丏丝与丄丑与业丙;
            val_1.Add(key:  val_16, value:  专丞丙一丟专丞与丗.丙丈丄丕上丝东丐丞());
            return val_1;
        }
        internal object 丈万上丙丝丂丑丄丂(System.Collections.Generic.List<int> 丙三丗专丏丞丅丏丒)
        {
            return (object)丙三丗专丏丞丅丏丒;
        }
        internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 且一丑丏上丙七一丅)
        {
            var val_10;
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            PGCompany.GameModeEvents.GMERewardConditionProgress val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_10 = null;
            val_10 = null;
            val_1.Add(key:  Rilisoft.丟下且且与丗丒丛与.一丑丄下丑丆且世一, value:  且一丑丏上丙七一丅.ConditionId);
            val_1.Add(key:  Rilisoft.丟下且且与丗丒丛与.七丟丐一七丕丝丁丂, value:  且一丑丏上丙七一丅.Progress.CompleteUtcTime);
            val_1.Add(key:  Rilisoft.丟下且且与丗丒丛与.三丕丁三丌丒丕上上, value:  且一丑丏上丙七一丅.Progress.MaxResetCount);
            if(且一丑丏上丙七一丅.Progress.Points >= 1)
            {
                    val_11 = null;
                val_11 = null;
                val_1.Add(key:  Rilisoft.丟下且且与丗丒丛与.且且业丌专丗丑专三, value:  且一丑丏上丙七一丅.Progress.Points);
            }
            
            if(且一丑丏上丙七一丅.Progress.CompleteResult >= 1)
            {
                    val_12 = null;
                val_12 = null;
                val_13 = Rilisoft.丟下且且与丗丒丛与.不下上下丞与七东下;
                val_14 = 且一丑丏上丙七一丅.Progress;
                int val_7 = val_14.CompleteResult;
            }
            else
            {
                    val_15 = 且一丑丏上丙七一丅.Progress;
                if(val_15.Points1 < 1)
            {
                    return val_1;
            }
            
                val_16 = null;
                val_16 = null;
                val_13 = Rilisoft.丟下且且与丗丒丛与.丞东丟不世丐下丈丑;
                val_14 = 且一丑丏上丙七一丅.Progress;
                int val_9 = val_14.Points1;
            }
            
            val_15 = val_9;
            val_1.Add(key:  val_13, value:  val_9);
            return val_1;
        }
        internal Progress.丆丐丄且丟丏丞丈丂.世东丆丞业丂丐三丁 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            string val_22;
            var val_23;
            var val_24;
            丆丐丄且丟丏丞丈丂.世东丆丞业丂丐三丁 val_1 = new 丆丐丄且丟丏丞丈丂.世东丆丞业丂丐三丁();
            val_16 = null;
            val_16 = null;
            val_17 = 1152921516630043280;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丟下且且与丗丒丛与.世丄丒丒丛丑丈丕一)) == false)
            {
                goto label_34;
            }
            
            val_18 = null;
            val_18 = null;
            val_19 = 一丐丗丁丞丆丅丟丄.Item[Rilisoft.丟下且且与丗丒丛与.世丄丒丒丛丑丈丕一];
            if(val_19 != null)
            {
                    val_19 = 0;
            }
            
            List.Enumerator<T> val_8 = val_19.GetEnumerator();
            label_23:
            if(((-307011040) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_10 = val_5.丐丏七丌丕丗业且上();
            UnityEngine.Debug.LogError(message:  "Ошибка!! Ожидался другой тип данных, что вы в меня суете?!");
            goto label_23;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_17 = 1152921516630043280;
            label_34:
            val_21 = null;
            val_21 = null;
            val_22 = Rilisoft.丟下且且与丗丒丛与.丈丏丝与丄丑与业丙;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_22)) == false)
            {
                    return val_1;
            }
            
            val_23 = null;
            val_23 = null;
            val_22 = Rilisoft.丟下且且与丗丒丛与.丈丏丝与丄丑与业丙;
            val_24 = 0;
            val_1.丄丒丛三业丑丘丄上(丙业与丙丗丝不丈东:  一丐丗丁丞丆丅丟丄.Item[val_22].丐上业丞且万七三丙(一丐丗丁丞丆丅丟丄:  null));
            return val_1;
        }
        private System.Collections.Generic.List<int> 丐上业丞且万七三丙(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄)
        {
            var val_4;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_6:
            if(((-306853952) & 1) == 0)
            {
                goto label_2;
            }
            
            val_1.Add(item:  System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上()));
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 丛三丌与丛丕丌丞丄(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_11;
            int val_5 = 0;
            .Progress = new PGCompany.GameModeEvents.GMERewardConditionProgress();
            val_11 = null;
            val_11 = null;
            bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.一丑丄下丑丆且世一, 丙业与丙丗丝不丈东: out  (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].ConditionId);
            bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.七丟丐一七丕丝丁丂, 丙业与丙丗丝不丈东: out  val_5);
            (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].Progress.CompleteUtcTime = 0;
            bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.三丕丁三丌丒丕上上, 丙业与丙丗丝不丈东: out  val_5);
            (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].Progress.MaxResetCount = 0;
            bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.不下上下丞与七东下, 丙业与丙丗丝不丈东: out  val_5);
            (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].Progress.CompleteResult = 0;
            bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.且且业丌专丗丑专三, 丙业与丙丗丝不丈东: out  val_5);
            (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].Progress.Points = 0;
            bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丟下且且与丗丒丛与.丞东丟不世丐下丈丑, 丙业与丙丗丝不丈东: out  val_5);
            (丈专丂丁丁东丌丁丅.GMERewardSavedConditions)[1152921542954903936].Progress.Points1 = 0;
            return (GMERewardSavedConditions)new 丈专丂丁丁东丌丁丅.GMERewardSavedConditions();
        }
        public 丟下且且与丗丒丛与()
        {
        
        }
        private static 丟下且且与丗丒丛与()
        {
            Rilisoft.丟下且且与丗丒丛与.东世丄丕丞东三下丏 = "d";
            Rilisoft.丟下且且与丗丒丛与.丒与丌丝丐丅与丕丆 = "u";
            Rilisoft.丟下且且与丗丒丛与.丑丑丒丑丙丐丞与丈 = "r";
            Rilisoft.丟下且且与丗丒丛与.业丕丐东丑丒丁丒丙 = "c";
            Rilisoft.丟下且且与丗丒丛与.世丄丒丒丛丑丈丕一 = "p";
            Rilisoft.丟下且且与丗丒丛与.丈丏丝与丄丑与业丙 = "r";
            Rilisoft.丟下且且与丗丒丛与.一丑丄下丑丆且世一 = "i";
            Rilisoft.丟下且且与丗丒丛与.且且业丌专丗丑专三 = "p";
            Rilisoft.丟下且且与丗丒丛与.丞东丟不世丐下丈丑 = "a";
            Rilisoft.丟下且且与丗丒丛与.不下上下丞与七东下 = "c";
            Rilisoft.丟下且且与丗丒丛与.七丟丐一七丕丝丁丂 = "t";
            Rilisoft.丟下且且与丗丒丛与.三丕丁三丌丒丕上上 = "r";
            Rilisoft.丟下且且与丗丒丛与.且丑专世不一丛丘丞 = "i";
            Rilisoft.丟下且且与丗丒丛与.丝丏丏丏上上丕万丆 = "r";
            Rilisoft.丟下且且与丗丒丛与.丕万丅丂丄业丑七丑 = "t";
            Rilisoft.丟下且且与丗丒丛与.丌丗业丑丌业丒丐丏 = "+";
        }
    
    }

}
