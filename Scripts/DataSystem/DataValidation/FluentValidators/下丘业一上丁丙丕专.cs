using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 下丘业一上丁丙丕专 : AbstractValidator<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七>
    {
        // Methods
        public 下丘业一上丁丙丕专()
        {
            System.Reflection.MethodInfo val_33;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七.RateId})), parameters:  val_5)))), errorMessage:  "ид лут рейта");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_33 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七::万东丏一且丛东丐丛()});
            if(val_33 != null)
            {
                    val_33 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_17 = new System.Linq.Expressions.ParameterExpression[1];
            val_17[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.AttributeSystem.三丘丌不丌丞不丟丟>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.AttributeSystem.三丘丌不丌丞不丟丟>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.AttributeSystem.三丘丌不丌丞不丟丟>(ruleBuilder:  this.RuleFor<PGCompany.AttributeSystem.三丘丌不丌丞不丟丟>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.AttributeSystem.三丘丌不丌丞不丟丟>>(body:  System.Linq.Expressions.Expression.Property(expression:  val_12, propertyAccessor:  val_33), parameters:  val_17)))), errorMessage:  "индекс атрибута");
            System.Linq.Expressions.ParameterExpression val_24 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_27 = new System.Linq.Expressions.ParameterExpression[1];
            val_27[0] = val_24;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.Common.丗七业丏东且丟丕一>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.Common.丗七业丏东且丟丕一>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.Common.丗七业丏东且丟丕一>(ruleBuilder:  this.RuleFor<PGCompany.Common.丗七业丏东且丟丕一>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七, PGCompany.Common.丗七业丏东且丟丕一>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_24, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七.Type})), parameters:  val_27)))), errorMessage:  "действие над атрибутом");
        }
    
    }

}
