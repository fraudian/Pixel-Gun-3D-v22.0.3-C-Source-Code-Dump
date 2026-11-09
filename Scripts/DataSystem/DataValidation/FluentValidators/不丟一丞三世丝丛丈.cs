using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 不丟一丞三世丝丛丈 : AbstractValidator<Rilisoft.GameEventChestData>
    {
        // Methods
        public 不丟一丞三世丝丛丈()
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
            var val_23 = 0;
            val_23 = val_23 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleFor<Rilisoft.GameEventItemData>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<Rilisoft.GameEventChestData, Rilisoft.GameEventItemData>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Rilisoft.GameEventChestData.LastLapReward})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.东与万丈丈丏丒与七(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_16 == null)
            {
                goto label_16;
            }
            
            if(val_13 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_13 == null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            val_16[0] = val_13;
            var val_24 = 0;
            val_24 = val_24 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = this.RuleForEach<Rilisoft.GameEventItemContainerData>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<Rilisoft.GameEventChestData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Rilisoft.GameEventChestData.ItemContainers})), parameters:  val_16)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.东七专与丟丒不丏七(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
