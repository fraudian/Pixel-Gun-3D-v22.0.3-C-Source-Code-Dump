using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 不丄丗三一上丗下丙 : AbstractValidator<ExpOpenSystem.丅一丐丌与丄上三丗>
    {
        // Methods
        public 不丄丗三一上丗下丙()
        {
            System.Linq.Expressions.Expression val_11;
            var val_12;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_14;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_11 = System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = ExpOpenSystem.丅一丐丌与丄上三丗.Progress}));
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_12 = null;
            val_12 = null;
            val_14 = 不丄丗三一上丗下丙.<>c.<>9__0_1;
            if(val_14 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_8 = null;
                val_14 = val_8;
                val_8 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  不丄丗三一上丗下丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 不丄丗三一上丗下丙.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                不丄丗三一上丗下丙.<>c.<>9__0_1 = val_14;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<ExpOpenSystem.丅一丐丌与丄上三丗, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<ExpOpenSystem.丅一丐丌与丄上三丗, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<ExpOpenSystem.丅一丐丌与丄上三丗, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  val_11, parameters:  val_5)), predicate:  val_8), overridePropertyName:  "Progress < 0");
        }
    
    }

}
