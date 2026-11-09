using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 与上丞七东一专丝专 : AbstractValidator<System.Collections.Generic.List<PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝>>
    {
        // Methods
        public 与上丞七东一专丝专()
        {
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_3 == null)
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
            val_3[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorOptions.WithName<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(body:  val_2, parameters:  val_3)))), overridePropertyName:  "настройки паков");
            System.Linq.Expressions.ParameterExpression val_10 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_11 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_11 == null)
            {
                goto label_11;
            }
            
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_10 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_11[0] = val_10;
            var val_18 = 0;
            val_18 = val_18 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_17 = this.RuleForEach<丞丗丆丙丝丌且丄丝>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>, System.Collections.Generic.IEnumerable<丞丗丆丙丝丌且丄丝>>>(body:  val_10, parameters:  val_11)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丙专三东世且不丛丏(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
