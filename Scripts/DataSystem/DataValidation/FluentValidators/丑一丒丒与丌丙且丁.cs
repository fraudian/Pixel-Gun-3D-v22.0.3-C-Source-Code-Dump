using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丑一丒丒与丌丙且丁 : AbstractValidator<PGCompany.BM.丝七丙下丈丌丈丞丘>
    {
        // Methods
        public 丑一丒丒与丌丙且丁()
        {
            System.Reflection.MethodInfo val_26;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_26 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_26 != null)
            {
                    val_26 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            var val_28 = 0;
            val_28 = val_28 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_15 = this.RuleForEach<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.BM.丝七丙下丈丌丈丞丘, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.BM.丝七丙下丈丌丈丞丘._currencyConvertation})), propertyAccessor:  val_26), parameters:  val_9)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_17 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_20 = new System.Linq.Expressions.ParameterExpression[1];
            val_20[0] = val_17;
            var val_29 = 0;
            val_29 = val_29 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_27 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.BM.丝七丙下丈丌丈丞丘, 世与七丄且丆丙丗丘>(ruleBuilder:  this.RuleFor<世与七丄且丆丙丗丘>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.BM.丝七丙下丈丌丈丞丘, 世与七丄且丆丙丗丘>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_17, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.BM.丝七丙下丈丌丈丞丘._refreshParameters})), parameters:  val_20))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丗世丁丂丂丗三万与(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
