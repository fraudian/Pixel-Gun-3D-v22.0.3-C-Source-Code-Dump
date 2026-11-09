using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丑丙与东丅业丁丞丁 : AbstractValidator<System.Collections.Generic.List<PGCompany.TaskBookConfig.TaskConfig>>
    {
        // Methods
        public 丑丙与东丅业丁丞丁()
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
            var val_10 = 0;
            val_10 = val_10 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = this.RuleForEach<TaskConfig>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.List<TaskConfig>, System.Collections.Generic.IEnumerable<TaskConfig>>>(body:  val_2, parameters:  val_3)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丞丑一业丒万丄丛丌(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
