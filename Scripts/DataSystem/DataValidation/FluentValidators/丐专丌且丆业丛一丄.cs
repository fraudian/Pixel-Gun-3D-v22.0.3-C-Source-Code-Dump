using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丐专丌且丆业丛一丄 : AbstractValidator<PGCompany.丌七丒万丝丄东且七>
    {
        // Methods
        public 丐专丌且丆业丛一丄()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<上丅且且万丅丞三丗>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丌七丒万丝丄东且七, System.Collections.Generic.IEnumerable<上丅且且万丅丞三丗>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.LeaguesSettings})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.上丏万丅丞丈一丂下(), ruleSets:  System.Array.Empty<System.String>());
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = this.RuleForEach<世不不丒丟丒丕丏丘>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丌七丒万丝丄东且七, System.Collections.Generic.IEnumerable<世不不丒丟丒丕丏丘>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.RewardsSettings})), parameters:  val_16)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丕丆丑东上丙不一丗(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
