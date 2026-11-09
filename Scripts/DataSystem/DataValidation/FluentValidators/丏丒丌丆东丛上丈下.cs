using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丏丒丌丆东丛上丈下 : AbstractValidator<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>
    {
        // Methods
        public 丏丒丌丆东丛上丈下()
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
            var val_12 = 0;
            val_12 = val_12 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorOptions.WithMessage<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  val_2, parameters:  val_3))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "невелидный предмет");
        }
    
    }

}
