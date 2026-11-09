using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 与丏七与东丄丂丄丞 : AbstractValidator<string>
    {
        // Methods
        public 与丏七与东丄丂丄丞()
        {
            System.Linq.Expressions.ParameterExpression[] val_16;
            var val_17;
            System.Action<System.String, FluentValidation.Validators.CustomContext> val_19;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_3[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorOptions.WithMessage<System.String, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<System.String, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<System.String, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.String, System.String>>(body:  val_2, parameters:  val_3)))), errorMessage:  "empty formula");
            System.Linq.Expressions.ParameterExpression val_10 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_11 = new System.Linq.Expressions.ParameterExpression[1];
            val_16 = val_11;
            val_16[0] = val_10;
            val_17 = null;
            val_17 = null;
            val_19 = 与丏七与东丄丂丄丞.<>c.<>9__0_2;
            if(val_19 == null)
            {
                    System.Action<System.String, FluentValidation.Validators.CustomContext> val_14 = null;
                val_19 = val_14;
                val_14 = new System.Action<System.String, FluentValidation.Validators.CustomContext>(object:  与丏七与东丄丂丄丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 与丏七与东丄丂丄丞.<>c::丒万三丛丝丗一丂专(string 专丌不丂丁丘丂丗业, FluentValidation.Validators.CustomContext 与且专丈不万东一万));
                与丏七与东丄丂丄丞.<>c.<>9__0_2 = val_19;
            }
            
            FluentValidation.IRuleBuilderInitial<T, TProperty> val_15 = FluentValidation.DefaultValidatorExtensions.Custom<System.String, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.String, System.String>>(body:  val_10, parameters:  val_11)), action:  val_14);
        }
    
    }

}
