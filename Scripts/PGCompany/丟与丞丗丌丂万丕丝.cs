using UnityEngine;

namespace PGCompany
{
    internal abstract class 丟与丞丗丌丂万丕丝
    {
        // Fields
        private PGCompany.ClanWarEventConfig <一丘一丐丝丘且丞丅>k__BackingField;
        private System.DateTime <丑丆一丌三丆丑丑专>k__BackingField;
        private System.DateTime <丕丝不世下专丕丟丂>k__BackingField;
        internal string 丗下与丏丒不丙丞丈;
        
        // Properties
        internal PGCompany.ClanWarEventConfig 一七且丗不丑丝且三 { get; set; }
        internal System.DateTime 丗丒丂丕丂业业丟丟 { get; set; }
        internal System.DateTime 丏不万且丑丗丄一丕 { get; set; }
        internal int 下丄丈不与世丐业专 { get; }
        internal PGCompany.丂不上丗与丌与丐丌 丒三丝一上丙专丗丒 { get; }
        
        // Methods
        internal PGCompany.ClanWarEventConfig 世丈丁业丛上丘丗丐()
        {
        
        }
        private void 与丟与丂丞丒下七丐(PGCompany.ClanWarEventConfig 丙业与丙丗丝不丈东)
        {
        
        }
        internal System.DateTime 上丟丄与丁三丌丘专()
        {
            return (System.DateTime)this.<丑丆一丌三丆丑丑专>k__BackingField;
        }
        private void 丅丈东上丑丅一东与(System.DateTime 丙业与丙丗丝不丈东)
        {
            this.<丑丆一丌三丆丑丑专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.DateTime 下丒丗丄丌丘不丑丘()
        {
            return (System.DateTime)this.<丕丝不世下专丕丟丂>k__BackingField;
        }
        private void 专下丏业七且一丒不(System.DateTime 丙业与丙丗丝不丈东)
        {
            this.<丕丝不世下专丕丟丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 业上丙丞丐丄丆丅七()
        {
            return (int)this.<一丘一丐丝丘且丞丅>k__BackingField;
        }
        internal PGCompany.丂不上丗与丌与丐丌 不业丙丒丂丞下丆丙()
        {
            return (PGCompany.丂不上丗与丌与丐丌)this;
        }
        internal 丟与丞丗丌丂万丕丝(PGCompany.ClanWarEventConfig 上世丏丁世丟世丆业, System.DateTime 专丛不上丙上业东丅, int 丝业丌丑丌丘世下丒)
        {
            this.丗下与丏丒不丙丞丈 = System.String.alignConst;
            System.DateTime val_1 = System.DateTime.Parse(s:  上世丏丁世丟世丆业.StartDay.上万三丆专丏丒丗业);
            System.DateTime val_2 = System.DateTime.Parse(s:  上世丏丁世丟世丆业.EndDay.上万三丆专丏丒丗业);
            int val_3 = 专丛不上丙上业东丅.dateData.Year;
            int val_4 = 专丛不上丙上业东丅.dateData.Month;
            int val_5 = 专丛不上丙上业东丅.dateData.Day;
            int val_6 = val_1.dateData.Hour;
            int val_7 = val_1.dateData.Minute;
            int val_8 = val_1.dateData.Second;
            System.DateTime val_11 = 0.AddSeconds(value:  (double)丝业丌丑丌丘世下丒 + ((UnityEngine.Mathf.Max(a:  0, b:  -1991779753)) * 86400));
            this.<丑丆一丌三丆丑丑专>k__BackingField = val_11;
            int val_12 = 专丛不上丙上业东丅.dateData.Year;
            int val_13 = 专丛不上丙上业东丅.dateData.Month;
            int val_14 = 专丛不上丙上业东丅.dateData.Day;
            int val_15 = val_2.dateData.Hour;
            int val_16 = val_2.dateData.Minute;
            int val_17 = val_2.dateData.Second;
            System.DateTime val_20 = 0.AddSeconds(value:  (double)丝业丌丑丌丘世下丒 + ((UnityEngine.Mathf.Max(a:  0, b:  -1991779729)) * 86400));
            this.<丕丝不世下专丕丟丂>k__BackingField = val_20;
        }
        internal abstract void 丛上且不与业专丘丘(); // 0
        internal abstract void 不与丞下业丑丒丙万(); // 0
        internal abstract bool 丝丑专业丕三丒与万(); // 0
        internal abstract bool 东丏丟不丒世且业世(); // 0
        internal abstract bool 丛丘丞丕丙丁下不丟(); // 0
        internal abstract 丌丈不下下丘丏丌一 丛丆丌东丆丕丞丄丙(); // 0
        internal string 七业丑不七丐业丟丂()
        {
            return (string)System.String.Format(format:  "{0}_{1}", arg0:  true, arg1:  this.<一丘一丐丝丘且丞丅>k__BackingField);
        }
        internal string 专丛丑与世上丌丄专()
        {
            return (string)System.String.Format(format:  "clan_war_event_{0}", arg0:  this.<一丘一丐丝丘且丞丅>k__BackingField);
        }
        internal virtual bool 丅业东万丌丕上丌丄()
        {
            var val_3;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) != 0)
            {
                    if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = this.<丑丆一丌三丆丑丑专>k__BackingField}, t2:  new System.DateTime() {})) != false)
            {
                    val_3 = 1152921554155064977;
                return (bool)val_3 & 1;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
        internal virtual bool 丞专丅丁丁三丄上专()
        {
            System.DateTime val_4;
            ulong val_5;
            val_4 = this;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            if((val_4 & 1) == 0)
            {
                goto label_4;
            }
            
            val_5 = 1;
            return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_4});
            label_3:
            val_5 = 0;
            return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_4});
            label_4:
            val_4 = this.<丕丝不世下专丕丟丂>k__BackingField;
            val_5 = ;
            return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_4});
        }
        internal int 丘丒不不丌丘下丒一()
        {
            System.DateTime val_4;
            int val_5;
            val_4 = this;
            if((val_4 & 1) == 0)
            {
                    System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
                if(((-1991177600) & 1) != 0)
            {
                    val_4 = this.<丕丝不世下专丕丟丂>k__BackingField;
                System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4}, d2:  new System.DateTime() {});
                val_5 = (int)val_2._ticks.TotalSeconds;
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        internal PGCompany.三东丏不丗世丅丌丄 丈丂下丕丆丌丗丌丄()
        {
            var val_3 = null;
            if((丟与丞丗丌丂万丕丝.<>c.<>9__29_0) != null)
            {
                    if(this == null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.FindAll(match:  丟与丞丗丌丂万丕丝.<>c.<>9__29_0));
            }
            
                return System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.FindAll(match:  丟与丞丗丌丂万丕丝.<>c.<>9__29_0));
            }
            
            丟与丞丗丌丂万丕丝.<>c.<>9__29_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  丟与丞丗丌丂万丕丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟与丞丗丌丂万丕丝.<>c::不丒丒丟丁业丄丕丞(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            if(this != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.FindAll(match:  丟与丞丗丌丂万丕丝.<>c.<>9__29_0));
            }
            
            return System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.FindAll(match:  丟与丞丗丌丂万丕丝.<>c.<>9__29_0));
        }
        public override string ToString()
        {
            var val_5;
            object[] val_1 = new object[4];
            string val_2 = this.七业丑不七丐业丟丂();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.<丑丆一丌三丆丑丑专>k__BackingField;
            if(((this.<丕丝不世下专丕丟丂>k__BackingField) != 0) && ((this.<丕丝不世下专丕丟丂>k__BackingField) == 0))
            {
                    val_5 = 0;
            }
            
            if(val_1.Length <= 2)
            {
                    val_5 = 0;
            }
            
            val_1[2] = this.<丕丝不世下专丕丟丂>k__BackingField;
            System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
            val_1[3] = val_3.HasValue;
            return (string)System.String.Format(format:  "{0}: {1} - {2} [{3}]", args:  val_1);
        }
    
    }

}
