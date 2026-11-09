using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 万丕上一下丒丌丙丏 : AbstractValidator<RecipeSystem.丌下丟丅丆丞万丅业>
    {
        // Methods
        public 万丕上一下丒丌丙丏()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<RecipeSystem.丝丏三三丕丁下丅丒>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<RecipeSystem.丌下丟丅丆丞万丅业, System.Collections.Generic.IEnumerable<RecipeSystem.丝丏三三丕丁下丅丒>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = RecipeSystem.丌下丟丅丆丞万丅业.RecipeSettings})), parameters:  val_5)).SetValidator(validator:  new 万丕上一下丒丌丙丏.丆七下东丞丁丞与上(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
