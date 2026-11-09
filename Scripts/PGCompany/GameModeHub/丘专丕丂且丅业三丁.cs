using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class 丘专丕丂且丅业三丁 : IDisposable
    {
        // Fields
        private static System.Action<string> 丗业丁专不三丞下丅;
        private UnityEngine.Coroutine 万上丛丗丄丂丌丅丞;
        
        // Properties
        private PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 丅万丂世不丘丕下一 { get; }
        private PGCompany.GameModeHub.丙上七且上丆丞丞丒 丙丕丈一一丝丑七丈 { get; }
        
        // Methods
        internal static void 丂下三东丘上丗丞丘(System.Action<string> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 且丗世三万专丈丟上(System.Action<string> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        private PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 丏丘下丞丘不丑万丏()
        {
            PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 val_2;
            if((PGCompany.业专丐丐丘丌丕世丅<PGCompany.GameModeHub.丝下丏丒丐业丗七业>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  124)) == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.CommonSettings;
            return val_2;
        }
        internal 丘专丕丂且丅业三丁()
        {
        
        }
        private PGCompany.GameModeHub.丙上七且上丆丞丞丒 丘专上世与丟丝丟丛()
        {
            return Progress.七七世万专丕丁上业.丑丑世七丗三七三丏();
        }
        internal void 丘丞丏丈丝丟不丅丞()
        {
            var val_20;
            LogsSystem.丟丝上丗丆万丘丞万 val_28;
            double val_29;
            var val_30;
            var val_31;
            var val_32;
            val_28 = this;
            PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 val_1 = this.丏丘下丞丘不丑万丏();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            PGCompany.GameModeHub.丙上七且上丆丞丞丒 val_2 = val_1.丘专上世与丟丝丟丛();
            if((val_2.丈丄丂下丒专丌丛丄 == null) || (val_2.丈丄丂下丒专丌丛丄.LastResetDay < 1))
            {
                goto label_4;
            }
            
            System.DateTime val_4 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丙丅丅业丟丁世丁丗());
            System.DateTime val_5 = 专七专下且专三一且.丐世丈专与东丏丛丑();
            val_29 = (double)val_2.丈丄丂下丒专丌丛丄.LastResetDay + 1;
            System.DateTime val_7 = val_5.dateData.AddDays(value:  val_29);
            PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 val_8 = val_7.dateData.丏丘下丞丘不丑万丏();
            System.DateTime val_10 = val_7.dateData.AddSeconds(value:  val_8.DailyRefreshTime.TotalSeconds);
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10.dateData}, t2:  new System.DateTime() {dateData = val_4.dateData})) == false)
            {
                goto label_12;
            }
            
            label_4:
            val_29 = (double)PixelTime.丙丅丅业丟丁世丁丗();
            System.TimeSpan val_13 = System.TimeSpan.FromSeconds(value:  val_29);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不七上下丂丙丛丄丘(丁不七丈与丐丌丅世:  (int)val_13._ticks.TotalDays);
            label_12:
            List.Enumerator<T> val_18 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丈世世三万丝一丕一().GetEnumerator();
            val_30 = 1152921526157003984;
            label_26:
            if((29576144 & 1) == 0)
            {
                goto label_22;
            }
            
            if(((val_20.丐丏七丌丕丗业且上() == null) || (as. 
                
              
             
            
             
              == 0)) || (PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅 == null))
            {
                goto label_26;
            }
            
            PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅.Invoke(obj:  public PGCompany.GameModeHub.丟与丗不不上丆丞三 List.Enumerator<PGCompany.GameModeHub.丟与丗不不上丆丞三>::get_Current());
            goto label_26;
            label_1:
            val_31 = null;
            val_31 = null;
            val_28 = LogsSystem.丆丏丌丆丆丑丞不丈.丅丄七丏丈万上丞丕;
            if(val_28 != null)
            {
                    return;
            }
            
            return;
            label_22:
            val_32 = public System.Void List.Enumerator<PGCompany.GameModeHub.丟与丗不不上丆丞三>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Nullable<System.TimeSpan> val_22 = this.七与七丟丕下世丟丁();
            if((29576192 & 1) == 0)
            {
                    return;
            }
            
            val_30 = 1152921523592578336;
            if((val_22.HasValue.System.IConvertible.ToInt64(provider:  0)) < 1)
            {
                    return;
            }
            
            if(this.万上丛丗丄丂丌丅丞 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.万上丛丗丄丂丌丅丞);
            }
            
            float val_27 = (float)val_22.HasValue.TotalSeconds;
            val_27 = val_27 + 1f;
            this.万上丛丗丄丂丌丅丞 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  val_27, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.丘专丕丂且丅业三丁::丘丞丏丈丝丟不丅丞()));
        }
        internal bool 丏丝丐丗丅丌专上下()
        {
            var val_7;
            var val_8;
            if(this.东丐与丆一丝三丟丟() == false)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_4 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丈世世三万丝一丕一().GetEnumerator();
            label_6:
            if((29745544 & 1) == 0)
            {
                goto label_4;
            }
            
            if(0.丐丏七丌丕丗业且上() == null)
            {
                    val_7 = 0;
            }
            
            if((this.不专上一丌丅世丅丈(七丆丒与丗丌丄且丂:  public PGCompany.GameModeHub.丟与丗不不上丆丞三 List.Enumerator<PGCompany.GameModeHub.丟与丗不不上丆丞三>::get_Current())) == false)
            {
                goto label_6;
            }
            
            val_8 = 1;
            goto label_7;
            label_4:
            val_8 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_8;
            label_1:
            val_8 = 0;
            return (bool)val_8;
        }
        internal bool 不专上一丌丅世丅丈(string 七丆丒与丗丌丄且丂)
        {
            string val_13;
            var val_14;
            val_13 = 七丆丒与丗丌丄且丂;
            if((((this.东丐与丆一丝三丟丟() != false) && ((((PGCompany.业专丐丐丘丌丕世丅<PGCompany.GameModeHub.丝下丏丒丐业丗七业>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  124)) != null) && (val_2.CommonSettings != null)) && (val_2.CommonSettings.FreeDailyReward != null))) && (val_2.CommonSettings.DailyRefreshTime.TotalSeconds >= 0)) && ((val_2.CommonSettings.DailyRefreshTime.丘专上世与丟丝丟丛().七丆业丞丑业丐丟三(七丆丒与丗丌丄且丂:  val_13)) != true))
            {
                    if((PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().业上丝丁与三丞业丘(丑丅七丅一丈丘丞七:  val_13)) != false)
            {
                    val_13 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丆业丝不一丒丞且丝(丑丅七丅一丈丘丞七:  val_13).与不丞丑七丘丁丂丛();
                string[] val_11 = new string[1];
                val_11[0] = "locked";
                val_14 = (~(val_13.不丈丅万不下丙丄丅(丏上业丞上丈丄丈不:  val_11))) & 1;
                return (bool)val_14;
            }
            
            }
            
            val_14 = 0;
            return (bool)val_14;
        }
        internal PGCompany.三东丏不丗世丅丌丄 一且丞丈下丑东专丑(string 七丆丒与丗丌丄且丂)
        {
            PGCompany.三东丏不丗世丅丌丄 val_5;
            if((PGCompany.业专丐丐丘丌丕世丅<PGCompany.GameModeHub.丝下丏丒丐业丗七业>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  124)) == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_5;
            }
            
            if(val_1.CommonSettings != null)
            {
                    val_5 = val_1.CommonSettings.FreeDailyReward;
                if(val_5 == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_5;
            }
            
                if(val_5.Clone() == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_5;
            }
            
            }
            
            val_5 = 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_5;
        }
        internal bool 与下丆与与丆丑上下(string 七丆丒与丗丌丄且丂)
        {
            var val_12;
            PGCompany.三东丏不丗世丅丌丄 val_1 = this.一且丞丈下丑东专丑(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
            if(val_1 == null)
            {
                    return (bool)val_12;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  163);
            PGCompany.丏丈丈且东丅上丄丙 val_3 = new PGCompany.丏丈丈且东丅上丄丙(丁丅丈丌丟世丗丗丟:  11, 丞丅上丏丂且下丅与:  "DailyReward");
            var val_6 = ((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  val_1.不业丙丒丂丞下丆丙())) != true) ? 97 : 0;
            PGCompany.丗丟丄丈东丝丕丄世 val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_1, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丌丛丟丁丛丛一丈东(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅 != null)
            {
                    PGCompany.GameModeHub.丘专丕丂且丅业三丁.丗业丁专不三丞下丅.Invoke(obj:  七丆丒与丗丌丄且丂);
            }
            
            val_12 = 1;
            return (bool)val_12;
        }
        internal System.Nullable<System.TimeSpan> 七与七丟丕下世丟丁()
        {
            ulong val_7;
            System.TimeSpan val_8;
            var val_9;
            val_7 = 1152921505243639808;
            if(PixelTime.丒丙专丟世丟丌丁上() == false)
            {
                    return 0;
            }
            
            System.DateTime val_3 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丙丅丅业丟丁世丁丗());
            val_7 = val_3.dateData;
            System.Nullable<System.DateTime> val_4 = val_3.dateData.世东丛丘东丐不丌三();
            val_8 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if((30402576 & 1) == 0)
            {
                    return 0;
            }
            
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {dateData = val_7});
            if(val_5._ticks.TotalSeconds < 0)
            {
                    val_7 = 1152921504624898048;
                val_9 = null;
                val_9 = null;
                val_8 = System.TimeSpan.Zero;
            }
            else
            {
                    val_8 = val_8;
            }
            
            return 0;
        }
        private System.Nullable<System.DateTime> 世东丛丘东丐不丌三()
        {
            System.TimeSpan val_15;
            int val_16;
            if(this.丏丘下丞丘不丑万丏() == null)
            {
                    return 0;
            }
            
            System.DateTime val_3 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丙丅丅业丟丁世丁丗());
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  (double)PixelTime.丙丅丅业丟丁世丁丗());
            PGCompany.GameModeHub.丑专丝丐丞丄七丁丘 val_7 = val_5._ticks.丏丘下丞丘不丑万丏();
            val_15 = val_7.DailyRefreshTime;
            val_16 = (int)val_5._ticks.TotalDays;
            System.TimeSpan val_8 = val_3.dateData.TimeOfDay;
            System.TimeSpan val_9 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = val_15}, t2:  new System.TimeSpan() {_ticks = val_8._ticks});
            if(val_9._ticks.TotalSeconds > 0f)
            {
                
            }
            else
            {
                    val_16 = val_16 + 1;
            }
            
            System.TimeSpan val_11 = System.TimeSpan.FromDays(value:  (double)val_16);
            System.TimeSpan val_12 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = val_11._ticks}, t2:  new System.TimeSpan() {_ticks = val_15});
            System.DateTime val_14 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (long)val_12._ticks.TotalSeconds);
            return 0;
        }
        private bool 东丐与丆一丝三丟丟()
        {
            string val_6;
            var val_13;
            string val_14;
            var val_16;
            var val_17;
            val_14 = this.丏丘下丞丘不丑万丏();
            if(val_14 == null)
            {
                    return (bool)val_13;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1.CategoryDailyRewardUnlockByAttr)) == true)
            {
                goto label_15;
            }
            
            val_14 = val_1.CategoryDailyRewardUnlockByAttr;
            PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> val_4 = Expressions.七上丈丂与丝丛丑七.丑七不且上丗丁一世().丝丅三且丄世丄与丂<Expressions.丁丟丟不丄东世丁上>(不丝世不丈丏专万丅:  val_14);
            if(val_6.下丕且丝丐丙丏丛上() == false)
            {
                goto label_6;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_11;
            label_6:
            val_16 = null;
            val_16 = null;
            val_14 = LogsSystem.丆丏丌丆丆丑丞不丈.丅丄七丏丈万上丞丕;
            string val_9 = "fail to execute expression with message: "("fail to execute expression with message: ") + val_6;
            if(val_14 != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_11:
            if(val_6.丐丏七丌丕丗业且上().丞丙东丌一三专丏不() == false)
            {
                goto label_16;
            }
            
            label_15:
            val_13 = 1;
            return (bool)val_13;
            label_16:
            val_17 = null;
            val_17 = null;
            string val_12 = "not available by formula \'" + val_14 + "\'";
            if(LogsSystem.丆丏丌丆丆丑丞不丈.丅丄七丏丈万上丞丕 != null)
            {
                    return (bool)val_13;
            }
            
            return (bool)val_13;
        }
        public void Dispose()
        {
        
        }
    
    }

}
