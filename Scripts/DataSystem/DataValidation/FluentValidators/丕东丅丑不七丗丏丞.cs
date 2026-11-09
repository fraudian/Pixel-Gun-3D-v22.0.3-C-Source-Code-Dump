using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丕东丅丑不七丗丏丞 : AbstractValidator<PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈>
    {
        // Methods
        public 丕东丅丑不七丗丏丞()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<丙丕丈一一丝丑七丈, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丙丕丈一一丝丑七丈, System.Int32>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<丙丕丈一一丝丑七丈, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丙丕丈一一丝丑七丈, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈.DayNumber})), parameters:  val_5)))), overridePropertyName:  "не указана номер дня");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<丙丕丈一一丝丑七丈, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丙丕丈一一丝丑七丈, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<丙丕丈一一丝丑七丈, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丙丕丈一一丝丑七丈, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈.Rewards})), parameters:  val_15)))), overridePropertyName:  "нет ни одной награды");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_25 == null)
            {
                goto label_17;
            }
            
            if(val_22 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_22 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_25[0] = val_22;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = FluentValidation.DefaultValidatorOptions.WithName<丙丕丈一一丝丑七丈, PGCompany.三东丏不丗世丅丌丄>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丙丕丈一一丝丑七丈, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<丙丕丈一一丝丑七丈, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丙丕丈一一丝丑七丈, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈.AlternativeRewards})), parameters:  val_25)))), overridePropertyName:  "не указано ни одной альтернативной награды");
        }
    
    }

}
