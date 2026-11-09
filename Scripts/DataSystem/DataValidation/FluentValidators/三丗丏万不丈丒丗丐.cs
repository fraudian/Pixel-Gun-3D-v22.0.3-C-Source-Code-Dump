using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 三丗丏万不丈丒丗丐 : AbstractValidator<PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏>
    {
        // Methods
        public 三丗丏万不丈丒丗丐()
        {
            System.Reflection.MethodInfo val_26;
            System.Reflection.MethodInfo val_27;
            var val_28;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_26 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_26 != null)
            {
                    val_26 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorOptions.WithName<专丙丆丏且七丈丗丏, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<专丙丆丏且七丈丗丏, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专丙丆丏且七丈丗丏, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏.InappPriceFirst})), propertyAccessor:  val_26), parameters:  val_9)), valueToCompare:  0), overridePropertyName:  "цена первой акции");
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_27 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_27 != null)
            {
                    val_28 = 1152921542026899616;
                val_27 = 0;
            }
            else
            {
                    val_28 = 1152921542026899616;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_21 = new System.Linq.Expressions.ParameterExpression[1];
            val_21[0] = val_15;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_25 = FluentValidation.DefaultValidatorOptions.WithName<专丙丆丏且七丈丗丏, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<专丙丆丏且七丈丗丏, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专丙丆丏且七丈丗丏, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏.InappPriceSecond})), propertyAccessor:  val_27), parameters:  val_21)), valueToCompare:  0), overridePropertyName:  "цена второй акции");
        }
    
    }

}
