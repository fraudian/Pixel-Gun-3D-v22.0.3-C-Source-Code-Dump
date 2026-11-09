using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丄丁丈一丙丟丁一丈 : AbstractValidator<PGCompany.上世东丗与丈丐丙丘>
    {
        // Methods
        public 丄丁丈一丙丟丁一丈()
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
            var val_34 = 0;
            val_34 = val_34 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<PGCompany.丐丐上丝丑七丕三丑>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.上世东丗与丈丐丙丘, System.Collections.Generic.IEnumerable<PGCompany.丐丐上丝丑七丕三丑>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.上世东丗与丈丐丙丘.PromotionSettings})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.与丅一丆专丁业丄东(), ruleSets:  System.Array.Empty<System.String>());
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
            var val_35 = 0;
            val_35 = val_35 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = this.RuleForEach<PGCompany.丛上丐万下丘丙丘丌>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.上世东丗与丈丐丙丘, System.Collections.Generic.IEnumerable<PGCompany.丛上丐万下丘丙丘丌>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.上世东丗与丈丐丙丘.GroupSettings})), parameters:  val_16)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丕三万丆万一丑丁万(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_24 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_27 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_27 == null)
            {
                goto label_27;
            }
            
            if(val_24 != null)
            {
                goto label_28;
            }
            
            goto label_31;
            label_27:
            if(val_24 == null)
            {
                goto label_31;
            }
            
            label_28:
            label_31:
            val_27[0] = val_24;
            var val_36 = 0;
            val_36 = val_36 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_33 = this.RuleForEach<PGCompany.丛且丂丐丌丈丈不一>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.上世东丗与丈丐丙丘, System.Collections.Generic.IEnumerable<PGCompany.丛且丂丐丌丈丈不一>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_24, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.上世东丗与丈丐丙丘.GuiSettings})), parameters:  val_27)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.万丄不七丗与丁丁丈(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
