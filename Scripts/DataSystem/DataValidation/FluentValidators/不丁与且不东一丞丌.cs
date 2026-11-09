using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 不丁与且不东一丞丌 : AbstractValidator<丈丞丕丘丕丗与上一>
    {
        // Methods
        public 不丁与且不东一丞丌()
        {
            System.Linq.Expressions.ParameterExpression[] val_9;
            var val_10;
            System.Func<丈丞丕丘丕丗与上一, System.Boolean> val_12;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_9 = val_3;
            val_9[0] = val_2;
            val_10 = null;
            val_10 = null;
            val_12 = 不丁与且不东一丞丌.<>c.<>9__0_1;
            if(val_12 == null)
            {
                    System.Func<丈丞丕丘丕丗与上一, System.Boolean> val_7 = null;
                val_12 = val_7;
                val_7 = new System.Func<丈丞丕丘丕丗与上一, System.Boolean>(object:  不丁与且不东一丞丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 不丁与且不东一丞丌.<>c::丐丕丘三不丒丁丏丐(丈丞丕丘丕丗与上一 与丛丗丈七专上丕丏));
                不丁与且不东一丞丌.<>c.<>9__0_1 = val_12;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorOptions.When<丈丞丕丘丕丗与上一, 丈丞丕丘丕丗与上一>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<丈丞丕丘丕丗与上一, 丈丞丕丘丕丗与上一>(ruleBuilder:  this.RuleFor<丈丞丕丘丕丗与上一>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丈丞丕丘丕丗与上一, 丈丞丕丘丕丗与上一>>(body:  val_2, parameters:  val_3))), predicate:  val_7, applyConditionTo:  0);
        }
    
    }

}
