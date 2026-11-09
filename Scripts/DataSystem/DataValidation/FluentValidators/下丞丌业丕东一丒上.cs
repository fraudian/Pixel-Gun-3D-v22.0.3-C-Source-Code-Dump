using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 下丞丌业丕东一丒上 : AbstractValidator<ExpOpenSystem.一丘不丘丄万丂丈丝>
    {
        // Methods
        public 下丞丌业丕东一丒上()
        {
            var val_41;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_43;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_41 = null;
            val_41 = null;
            val_43 = 下丞丌业丕东一丒上.<>c.<>9__0_1;
            if(val_43 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_8 = null;
                val_43 = val_8;
                val_8 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  下丞丌业丕东一丒上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 下丞丌业丕东一丒上.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                下丞丌业丕东一丒上.<>c.<>9__0_1 = val_43;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<ExpOpenSystem.一丘不丘丄万丂丈丝, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<ExpOpenSystem.一丘不丘丄万丂丈丝, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<ExpOpenSystem.一丘不丘丄万丂丈丝, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = ExpOpenSystem.一丘不丘丄万丂丈丝.MaxLevelRewardExp})), parameters:  val_5)), predicate:  val_8), overridePropertyName:  "MaxLevelRewardExp < 0");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            val_15[0] = val_12;
            var val_43 = 0;
            val_43 = val_43 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = ExpOpenSystem.一丘不丘丄万丂丈丝.SpecialRewards})), parameters:  val_15)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_23 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
            val_26[0] = val_23;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = FluentValidation.DefaultValidatorOptions.WithName<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Boolean>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Boolean>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Boolean>(ruleBuilder:  this.RuleFor<System.Boolean>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Boolean>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = ExpOpenSystem.一丘不丘丄万丂丈丝.IsEnable})), parameters:  val_26)))), overridePropertyName:  "не указан IsEnable");
            System.Linq.Expressions.ParameterExpression val_33 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_36 = new System.Linq.Expressions.ParameterExpression[1];
            val_36[0] = val_33;
            var val_44 = 0;
            val_44 = val_44 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_42 = this.RuleForEach<ExpOpenSystem.丅一丐丌与丄上三丗>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<ExpOpenSystem.一丘不丘丄万丂丈丝, System.Collections.Generic.IEnumerable<ExpOpenSystem.丅一丐丌与丄上三丗>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_33, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = ExpOpenSystem.一丘不丘丄万丂丈丝.ExpOpenSettings})), parameters:  val_36)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.不丄丗三一上丗下丙(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
