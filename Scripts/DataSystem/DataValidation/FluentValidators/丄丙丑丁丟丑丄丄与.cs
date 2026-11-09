using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丄丙丑丁丟丑丄丄与 : AbstractValidator<PGCompany.DataObjects.三丏世丟丟丙丟丙万>
    {
        // Methods
        public 丄丙丑丁丟丑丄丄与()
        {
            System.Reflection.MethodInfo val_24;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.三丏世丟丟丙丟丙万, System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.三丏世丟丟丙丟丙万, System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.三丏世丟丟丙丟丙万, System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.三丏世丟丟丙丟丙万.WeaponsPrefabNumbersDictionary})), parameters:  val_5))));
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_24 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_24 != null)
            {
                    val_24 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_18 = new System.Linq.Expressions.ParameterExpression[1];
            val_18[0] = val_11;
            var val_25 = 0;
            val_25 = val_25 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_24 = this.RuleForEach<上丈丕三丐丌丘丅丂>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.三丏世丟丟丙丟丙万, System.Collections.Generic.IEnumerable<上丈丕三丐丌丘丅丂>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.三丏世丟丟丙丟丙万.WeaponsPrefabNumbersDictionary})), propertyAccessor:  val_24), parameters:  val_18)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丈东丐业丞世丌东丒(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
