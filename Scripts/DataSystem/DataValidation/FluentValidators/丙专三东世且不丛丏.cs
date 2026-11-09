using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丙专三东世且不丛丏 : AbstractValidator<PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝>
    {
        // Methods
        public 丙专三东世且不丛丏()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithName<丞丗丆丙丝丌且丄丝, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丞丗丆丙丝丌且丄丝, System.String>(ruleBuilder:  this.RuleForEach<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丞丗丆丙丝丌且丄丝, System.Collections.Generic.IEnumerable<System.String>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝.ItemsFirst})), parameters:  val_5))), overridePropertyName:  "пустой предмет в паке");
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_14 == null)
            {
                goto label_11;
            }
            
            if(val_11 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_11 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_14[0] = val_11;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithName<丞丗丆丙丝丌且丄丝, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丞丗丆丙丝丌且丄丝, System.String>(ruleBuilder:  this.RuleForEach<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丞丗丆丙丝丌且丄丝, System.Collections.Generic.IEnumerable<System.String>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝.ItemsSeconds})), parameters:  val_14))), overridePropertyName:  "пустой предмет в паке");
        }
    
    }

}
