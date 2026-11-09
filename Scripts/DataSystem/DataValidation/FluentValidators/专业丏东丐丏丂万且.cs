using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 专业丏东丐丏丂万且 : AbstractValidator<System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>
    {
        // Methods
        public 专业丏东丐丏丂万且()
        {
            System.Reflection.MethodInfo val_32;
            System.Reflection.MethodInfo val_33;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_3[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorOptions.WithName<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(body:  val_2, parameters:  val_3)))), overridePropertyName:  "список категорий в доступных предметах");
            System.Linq.Expressions.ParameterExpression val_10 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_32 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.KeyCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>::get_Keys()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_32 != null)
            {
                    val_32 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            val_15[0] = val_10;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.String>(ruleBuilder:  this.RuleForEach<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.IEnumerable<System.String>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_10, propertyAccessor:  val_32), parameters:  val_15)))), overridePropertyName:  "имя категории в доступных предметах");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_33 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_33 != null)
            {
                    val_33 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
            val_26[0] = val_22;
            var val_33 = 0;
            val_33 = val_33 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = this.RuleForEach<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_22, propertyAccessor:  val_33), parameters:  val_26)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
