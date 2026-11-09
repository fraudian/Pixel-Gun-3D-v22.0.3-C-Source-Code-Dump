using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 七丝丁万丛下且丘万 : AbstractValidator<PGCompany.丙且丟业丗世下丈且>
    {
        // Methods
        public 七丝丁万丛下且丘万()
        {
            System.Reflection.MethodInfo val_24;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_24 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_24 != null)
            {
                    val_24 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.丙且丟业丗世下丈且, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.丙且丟业丗世下丈且, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丙且丟业丗世下丈且, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丙且丟业丗世下丈且.TimeLife})), propertyAccessor:  val_24), parameters:  val_9)), valueToCompare:  0), errorMessage:  "время жизни");
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_18 = new System.Linq.Expressions.ParameterExpression[1];
            val_18[0] = val_15;
            var val_25 = 0;
            val_25 = val_25 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_24 = this.RuleForEach<丅万丂世不丘丕下一>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丙且丟业丗世下丈且, System.Collections.Generic.IEnumerable<丅万丂世不丘丕下一>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丙且丟业丗世下丈且.AllSettings})), parameters:  val_18)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丁丈东丙丙东丟丁丙(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
