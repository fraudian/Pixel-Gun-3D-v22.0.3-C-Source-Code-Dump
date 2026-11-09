using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丕不丞丑丌与不丕丛 : AbstractValidator<System.Collections.Generic.Dictionary<int, PGCompany.七丂专七业丏丟丗丕.丅万丂世不丘丕下一>>
    {
        // Methods
        public 丕不丞丑丌与不丕丛()
        {
            System.Reflection.MethodInfo val_30;
            System.Reflection.MethodInfo val_31;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_3[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_7 = FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>>>(body:  val_2, parameters:  val_3))));
            System.Linq.Expressions.ParameterExpression val_9 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_30 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.KeyCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>::get_Keys()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_30 != null)
            {
                    val_30 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_9;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithName<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Int32>(ruleBuilder:  this.RuleForEach<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Collections.Generic.IEnumerable<System.Int32>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_9, propertyAccessor:  val_30), parameters:  val_14)), valueToCompare:  0), overridePropertyName:  "Тир меньше 0");
            System.Linq.Expressions.ParameterExpression val_20 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_31 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_31 != null)
            {
                    val_31 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_24 = new System.Linq.Expressions.ParameterExpression[1];
            val_24[0] = val_20;
            var val_31 = 0;
            val_31 = val_31 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = this.RuleForEach<丅万丂世不丘丕下一>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.Int32, 丅万丂世不丘丕下一>, System.Collections.Generic.IEnumerable<丅万丂世不丘丕下一>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_20, propertyAccessor:  val_31), parameters:  val_24)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.且一丛丁丛下丏丄丌(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
