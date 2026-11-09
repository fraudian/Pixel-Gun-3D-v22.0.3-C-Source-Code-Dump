using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丅丅丕丆丝丙丐不丁 : AbstractValidator<PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒>
    {
        // Methods
        public 丅丅丕丆丝丙丐不丁()
        {
            System.Reflection.MethodInfo val_65;
            System.Reflection.MethodInfo val_66;
            System.Reflection.MethodInfo val_67;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_65 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_65 != null)
            {
                    val_65 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<七东万一万丞丂且丒, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.Version})), propertyAccessor:  val_65), parameters:  val_9)), valueToCompare:  0), overridePropertyName:  "версия");
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_66 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_66 != null)
            {
                    val_66 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_21 = new System.Linq.Expressions.ParameterExpression[1];
            val_21[0] = val_15;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_25 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<七东万一万丞丂且丒, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.OffersCount})), propertyAccessor:  val_66), parameters:  val_21)), valueToCompare:  0), overridePropertyName:  "количество одновременных предложений акции в банке");
            System.Linq.Expressions.ParameterExpression val_27 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_67 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_67 != null)
            {
                    val_67 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_33 = new System.Linq.Expressions.ParameterExpression[1];
            val_33[0] = val_27;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_37 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<七东万一万丞丂且丒, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_27, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.PayCount})), propertyAccessor:  val_67), parameters:  val_33)), valueToCompare:  0), overridePropertyName:  "количество покупок одной акции");
            System.Linq.Expressions.ParameterExpression val_39 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_42 = new System.Linq.Expressions.ParameterExpression[1];
            val_42[0] = val_39;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_46 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<七东万一万丞丂且丒, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_39, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.PresentationTime})), parameters:  val_42)), toCompare:  new System.DateTime(), comparer:  0), overridePropertyName:  "время презентации акции");
            System.Linq.Expressions.ParameterExpression val_48 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_51 = new System.Linq.Expressions.ParameterExpression[1];
            val_51[0] = val_48;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_55 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<七东万一万丞丂且丒, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_48, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.StartTime})), parameters:  val_51)), toCompare:  new System.DateTime(), comparer:  0), overridePropertyName:  "время старта акции");
            System.Linq.Expressions.ParameterExpression val_57 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_60 = new System.Linq.Expressions.ParameterExpression[1];
            val_60[0] = val_57;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_64 = FluentValidation.DefaultValidatorOptions.WithName<七东万一万丞丂且丒, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<七东万一万丞丂且丒, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<七东万一万丞丂且丒, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_57, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒.EndTime})), parameters:  val_60)), toCompare:  new System.DateTime(), comparer:  0), overridePropertyName:  "время окончания акции");
        }
    
    }

}
