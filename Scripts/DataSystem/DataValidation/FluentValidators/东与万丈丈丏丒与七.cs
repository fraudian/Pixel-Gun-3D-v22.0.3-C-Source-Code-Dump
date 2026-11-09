using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 东与万丈丈丏丒与七 : AbstractValidator<Rilisoft.GameEventItemData>
    {
        // Methods
        public 东与万丈丈丏丒与七()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<Rilisoft.GameEventItemData, PGCompany.三东丏不丗世丅丌丄>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Rilisoft.GameEventItemData.ItemParams})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
