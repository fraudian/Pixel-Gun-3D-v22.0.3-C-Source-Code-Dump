using UnityEngine;

namespace DataSystem.DataValidation
{
    public class 三丘丂丌丐丈东丈业 : 世丑下丛丘世下丑丗
    {
        // Methods
        public System.Threading.Tasks.Task<DataSystem.DataValidation.丑丌东丟业万丟一东> 丏且丕丄世丕不丕丙(object 丝丝丕专丞上丅上丁)
        {
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DataSystem.DataValidation.丑丌东丟业万丟一东>.Create();
            return (System.Threading.Tasks.Task<DataSystem.DataValidation.丑丌东丟业万丟一东>);
        }
        private DataSystem.DataValidation.丑丌东丟业万丟一东 不丂一东丄丝丌专与(System.Collections.Generic.List<FluentValidation.Results.ValidationResult> 一丙丂丂下丒且一丗)
        {
            var val_3;
            int val_18;
            var val_19;
            System.Func<System.String, System.String, System.String> val_21;
            val_18 = System.String.alignConst;
            List.Enumerator<T> val_1 = 一丙丂丂下丒且一丗.GetEnumerator();
            val_19 = 1152921505407004672;
            goto label_10;
            label_12:
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 & 1) == 0)
            {
                    System.Func<FluentValidation.Results.ValidationFailure, System.String> val_8 = new System.Func<FluentValidation.Results.ValidationFailure, System.String>(object:  三丘丂丌丐丈东丈业.<>c.<>9, method:  System.String 三丘丂丌丐丈东丈业.<>c::七丂丛一万不丛丑七(FluentValidation.Results.ValidationFailure 丕丙七东丄丙丏丌丂));
                val_19 = val_19;
                val_21 = 三丘丂丌丐丈东丈业.<>c.<>9__1_1;
                if(val_21 == null)
            {
                    val_21 = null;
                val_21 = new System.Func<System.String, System.String, System.String>(object:  三丘丂丌丐丈东丈业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 三丘丂丌丐丈东丈业.<>c::丆丕专丟业丙下不七(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                val_19 = val_19;
                三丘丂丌丐丈东丈业.<>c.<>9__1_1 = val_21;
            }
            
                val_18 = val_18 + System.Environment.NewLine(val_18 + System.Environment.NewLine) + System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<FluentValidation.Results.ValidationFailure, System.String>(source:  val_4.Errors, selector:  null), func:  null)(System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<FluentValidation.Results.ValidationFailure, System.String>(source:  val_4.Errors, selector:  null), func:  null));
            }
            
            label_10:
            if(((-1251498032) & 1) != 0)
            {
                goto label_12;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            bool val_13 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  null);
            DataSystem.DataValidation.丑丌东丟业万丟一东 val_14 = new DataSystem.DataValidation.丑丌东丟业万丟一东();
            DataSystem.业丂丟东业丏丏世与 val_15 = (val_13 != true) ? (1 + 1) : 1;
            if(val_14 != null)
            {
                    .专丑且且丛七丈丒万 = val_15;
                var val_16 = (val_13 != true) ? "Ok" : ();
            }
            else
            {
                    .专丑且且丛七丈丒万 = val_15;
            }
            
            .丌丝丆三丟专万业丝 = (val_13 != true) ? "Ok" : ();
            return val_14;
        }
        private DataSystem.DataValidation.丑丌东丟业万丟一东 丝上丆专丝三丙一万(string 且七丈丄丄业丞丟业)
        {
            DataSystem.DataValidation.丑丌东丟业万丟一东 val_1 = new DataSystem.DataValidation.丑丌东丟业万丟一东();
            if(val_1 != null)
            {
                    .专丑且且丛七丈丒万 = 1;
            }
            else
            {
                    mem[16] = 1;
            }
            
            .丌丝丆三丟专万业丝 = 且七丈丄丄业丞丟业;
            return val_1;
        }
        public 三丘丂丌丐丈东丈业()
        {
        
        }
    
    }

}
