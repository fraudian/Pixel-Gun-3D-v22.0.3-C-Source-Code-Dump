using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 专专丘丁一与丏丂丌 : AbstractValidator<PGCompany.丄丑一专丒业东丝丐>
    {
        // Methods
        public 专专丘丁一与丏丂丌()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<专专三东下丒丝丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丄丑一专丒业东丝丐, System.Collections.Generic.IEnumerable<专专三东下丒丝丘且>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丄丑一专丒业东丝丐.OfferSettings})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.世丞且专丝万一丘丈(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
