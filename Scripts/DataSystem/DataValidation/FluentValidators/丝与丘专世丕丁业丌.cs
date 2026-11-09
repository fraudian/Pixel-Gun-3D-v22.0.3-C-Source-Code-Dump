using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丝与丘专世丕丁业丌 : AbstractValidator<PGCompany.DataObjects.丟业专丘七丐丗且丌>
    {
        // Methods
        public 丝与丘专世丕丁业丌()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.SeasonId})), parameters:  val_5)))), overridePropertyName:  "не указан сезон");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.NextDayInterval})), parameters:  val_15)))), overridePropertyName:  "нет ни дневной интервал");
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
            var val_33 = 0;
            val_33 = val_33 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丟业专丘七丐丗且丌, 丙丕丈一一丝丑七丈>(ruleBuilder:  this.RuleForEach<丙丕丈一一丝丑七丈>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丟业专丘七丐丗且丌, System.Collections.Generic.IEnumerable<丙丕丈一一丝丑七丈>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丟业专丘七丐丗且丌.Slots})), parameters:  val_25))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丕东丅丑不七丗丏丞(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
