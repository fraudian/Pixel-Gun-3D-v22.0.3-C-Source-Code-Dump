using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丞丑一业丒万丄丛丌 : AbstractValidator<PGCompany.TaskBookConfig.TaskConfig>
    {
        // Methods
        public 丞丑一业丒万丄丛丌()
        {
            System.Reflection.MethodInfo val_42;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = 1152921504800509952}), name:  "x");
            val_42 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 TaskBookConfig.TaskConfig::get_Id()});
            if(val_42 != null)
            {
                    val_42 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_7 = new System.Linq.Expressions.ParameterExpression[1];
            val_7[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorOptions.WithMessage<TaskConfig, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<TaskConfig, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<TaskConfig, System.Int32>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_2, propertyAccessor:  val_42), parameters:  val_7))), errorMessage:  "пустой ид задачи");
            System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = 1152921504800509952}), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
            val_16[0] = val_13;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = FluentValidation.DefaultValidatorOptions.WithMessage<TaskConfig, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<TaskConfig, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<TaskConfig, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<TaskConfig, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.TaskBookConfig.TaskConfig.Description})), parameters:  val_16)))), errorMessage:  "пустое описание задачи");
            System.Linq.Expressions.ParameterExpression val_23 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = 1152921504800509952}), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
            val_26[0] = val_23;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = FluentValidation.DefaultValidatorOptions.WithMessage<TaskConfig, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<TaskConfig, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<TaskConfig, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<TaskConfig, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.TaskBookConfig.TaskConfig.Rewards})), parameters:  val_26)))), errorMessage:  "нет наград в задаче");
            System.Linq.Expressions.ParameterExpression val_33 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = 1152921504800509952}), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_36 = new System.Linq.Expressions.ParameterExpression[1];
            val_36[0] = val_33;
            var val_43 = 0;
            val_43 = val_43 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_42 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<TaskConfig, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_33, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.TaskBookConfig.TaskConfig.Rewards})), parameters:  val_36)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
