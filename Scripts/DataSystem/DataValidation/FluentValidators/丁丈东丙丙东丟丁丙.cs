using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丁丈东丙丙东丟丁丙 : AbstractValidator<PGCompany.丙且丟业丗世下丈且.丅万丂世不丘丕下一>
    {
        // Methods
        public 丁丈东丙丙东丟丁丙()
        {
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_5 == null)
            {
                goto label_5;
            }
            
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_2 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<丅万丂世不丘丕下一, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<丅万丂世不丘丕下一, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丅万丂世不丘丕下一, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丅万丂世不丘丕下一, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丙且丟业丗世下丈且.丅万丂世不丘丕下一.VersionForBanner})), parameters:  val_5)))), errorMessage:  "версия баннера");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_15 == null)
            {
                goto label_11;
            }
            
            if(val_12 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_12 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_15[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithMessage<丅万丂世不丘丕下一, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<丅万丂世不丘丕下一, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丅万丂世不丘丕下一, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丅万丂世不丘丕下一, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丙且丟业丗世下丈且.丅万丂世不丘丕下一.VersionForReward})), parameters:  val_15)))), errorMessage:  "версия награды");
        }
    
    }

}
