using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丟丒万丂丗丅东东三 : AbstractValidator<PGCompany.丌三上丈丗丏丆万丆>
    {
        // Methods
        public 丟丒万丂丗丅东东三()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleFor<PGCompany.与丅不丈丆丛丒丙丞>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丌三上丈丗丏丆万丆, PGCompany.与丅不丈丆丛丒丙丞>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌三上丈丗丏丆万丆.StepsSettings})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丑不业业且世丆丐一(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
