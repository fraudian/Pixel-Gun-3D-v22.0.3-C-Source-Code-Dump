using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 东业丛丛丄丈丏丅下 : AbstractValidator<PGCompany.丅丞与丟与丄丕丒丂.七东万一万丞丂且丒>
    {
        // Methods
        public 东业丛丛丄丈丏丅下()
        {
            System.Reflection.MethodInfo val_32;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<七东万一万丞丂且丒, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.七东万一万丞丂且丒.StartTime})), parameters:  val_5)), toCompare:  new System.DateTime(), comparer:  0), overridePropertyName:  "время старта акции");
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_11;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<七东万一万丞丂且丒, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.七东万一万丞丂且丒.EndTime})), parameters:  val_14)), toCompare:  new System.DateTime(), comparer:  0), overridePropertyName:  "время окончания акции");
            System.Linq.Expressions.ParameterExpression val_20 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_32 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_32 != null)
            {
                    val_32 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_27 = new System.Linq.Expressions.ParameterExpression[1];
            val_27[0] = val_20;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<七东万一万丞丂且丒, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_20, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.七东万一万丞丂且丒.Duration})), propertyAccessor:  val_32), parameters:  val_27)), valueToCompare:  0), overridePropertyName:  "время жизни акции");
        }
    
    }

}
