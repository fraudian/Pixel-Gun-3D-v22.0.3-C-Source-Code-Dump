using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丞丑丝与世七下不且 : AbstractValidator<PGCompany.PixelPass.丞丞丁丐丒与丈丅一>
    {
        // Methods
        public 丞丑丝与世七下不且()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleForEach<PGCompany.且丏丝丗丞丅丂丝丂>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.丞丞丁丐丒与丈丅一, System.Collections.Generic.IEnumerable<PGCompany.且丏丝丗丞丅丂丝丂>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.丞丞丁丐丒与丈丅一.Offers})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丅七丂七三丆丞丝丒(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
