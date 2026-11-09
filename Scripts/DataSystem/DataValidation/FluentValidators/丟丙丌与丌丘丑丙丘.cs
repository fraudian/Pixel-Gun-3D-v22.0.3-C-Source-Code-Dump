using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丟丙丌与丌丘丑丙丘 : AbstractValidator<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, PGCompany.七丂专七业丏丟丗丕.丅万丂世不丘丕下一>>>
    {
        // Methods
        public 丟丙丌与丌丘丑丙丘()
        {
            System.Reflection.MethodInfo val_31;
            System.Reflection.MethodInfo val_32;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_3[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_7 = FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>>(body:  val_2, parameters:  val_3))));
            System.Linq.Expressions.ParameterExpression val_9 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_31 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.KeyCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>::get_Keys()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_31 != null)
            {
                    val_31 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_9;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_19 = FluentValidation.DefaultValidatorOptions.WithName<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.String>(ruleBuilder:  this.RuleForEach<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.Collections.Generic.IEnumerable<System.String>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_9, propertyAccessor:  val_31), parameters:  val_14)))), overridePropertyName:  "имя карты");
            System.Linq.Expressions.ParameterExpression val_21 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_32 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_32 != null)
            {
                    val_32 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            val_25[0] = val_21;
            var val_32 = 0;
            val_32 = val_32 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = this.RuleForEach<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_21, propertyAccessor:  val_32), parameters:  val_25)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丕不丞丑丌与不丕丛(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
