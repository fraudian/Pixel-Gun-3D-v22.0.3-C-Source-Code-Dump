using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 万丙丂世下东丒与世 : AbstractValidator<PGCompany.GraffitiSystem.上业业不不七东丒丑>
    {
        // Methods
        public 万丙丂世下东丒与世()
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
            var val_12 = 0;
            val_12 = val_12 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.GraffitiSystem.上业业不不七东丒丑, System.Collections.Generic.IEnumerable<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.GraffitiSystem.上业业不不七东丒丑.GraffitiSettings})), parameters:  val_5)).SetValidator(validator:  new 万丙丂世下东丒与世.一与东丗三丗丌丄丛(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
