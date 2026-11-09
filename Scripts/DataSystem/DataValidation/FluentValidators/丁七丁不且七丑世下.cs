using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丁七丁不且七丑世下 : AbstractValidator<PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专>
    {
        // Methods
        public 丁七丁不且七丑世下()
        {
            System.Reflection.MethodInfo val_58;
            System.Reflection.MethodInfo val_59;
            System.Reflection.MethodInfo val_60;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_58 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_58 != null)
            {
                    val_58 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorOptions.WithName<丌丙三且世与丄丁专, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<丌丙三且世与丄丁专, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丌丙三且世与丄丁专, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专.InappPrice})), propertyAccessor:  val_58), parameters:  val_9)), valueToCompare:  0), overridePropertyName:  "стоимость акции");
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_59 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_59 != null)
            {
                    val_59 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_21 = new System.Linq.Expressions.ParameterExpression[1];
            val_21[0] = val_15;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_25 = FluentValidation.DefaultValidatorOptions.WithName<丌丙三且世与丄丁专, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<丌丙三且世与丄丁专, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丌丙三且世与丄丁专, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专.OldPrice})), propertyAccessor:  val_59), parameters:  val_21)), valueToCompare:  0), overridePropertyName:  "стоимость акции без скидки");
            System.Linq.Expressions.ParameterExpression val_27 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_60 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_60 != null)
            {
                    val_60 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_33 = new System.Linq.Expressions.ParameterExpression[1];
            val_33[0] = val_27;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_37 = FluentValidation.DefaultValidatorOptions.WithName<丌丙三且世与丄丁专, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<丌丙三且世与丄丁专, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丌丙三且世与丄丁专, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_27, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专.Sale})), propertyAccessor:  val_60), parameters:  val_33)), valueToCompare:  0), overridePropertyName:  "скидка");
            System.Linq.Expressions.ParameterExpression val_39 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_42 = new System.Linq.Expressions.ParameterExpression[1];
            val_42[0] = val_39;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_47 = FluentValidation.DefaultValidatorOptions.WithName<丌丙三且世与丄丁专, System.Collections.Generic.List<丝丕专世丙丆丛丝丝>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丌丙三且世与丄丁专, System.Collections.Generic.List<丝丕专世丙丆丛丝丝>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<丌丙三且世与丄丁专, System.Collections.Generic.List<丝丕专世丙丆丛丝丝>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<丝丕专世丙丆丛丝丝>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丌丙三且世与丄丁专, System.Collections.Generic.List<丝丕专世丙丆丛丝丝>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_39, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专.SlotsSettings})), parameters:  val_42)))), overridePropertyName:  "настройки слотов акции");
            System.Linq.Expressions.ParameterExpression val_49 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_52 = new System.Linq.Expressions.ParameterExpression[1];
            val_52[0] = val_49;
            var val_59 = 0;
            val_59 = val_59 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_58 = this.RuleForEach<丝丕专世丙丆丛丝丝>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丌丙三且世与丄丁专, System.Collections.Generic.IEnumerable<丝丕专世丙丆丛丝丝>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_49, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丌丙三且世与丄丁专.SlotsSettings})), parameters:  val_52)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.且丕丈丞丕丌业丆世(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
