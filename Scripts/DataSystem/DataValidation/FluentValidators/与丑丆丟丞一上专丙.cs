using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 与丑丆丟丞一上专丙 : AbstractValidator<PGCompany.ShopSystem.不丘丁东丆丏与丌七>
    {
        // Methods
        public 与丑丆丟丞一上专丙()
        {
            System.Linq.Expressions.Expression val_65;
            var val_66;
            System.Func<PGCompany.Attributes.丝万专丆丂丘丌世丟, System.Boolean> val_68;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.Id})), parameters:  val_5)), valueToCompare:  0);
            System.Linq.Expressions.ParameterExpression val_10 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_13 = new System.Linq.Expressions.ParameterExpression[1];
            val_13[0] = val_10;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_16 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_10, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ItemPrice})), parameters:  val_13)));
            System.Linq.Expressions.ParameterExpression val_18 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_21 = new System.Linq.Expressions.ParameterExpression[1];
            val_21[0] = val_18;
            var val_65 = 0;
            val_65 = val_65 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_27 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_18, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ItemPrice})), parameters:  val_21)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_29 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_32 = new System.Linq.Expressions.ParameterExpression[1];
            val_32[0] = val_29;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_35 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_29, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ItemReward})), parameters:  val_32)));
            System.Linq.Expressions.ParameterExpression val_37 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_40 = new System.Linq.Expressions.ParameterExpression[1];
            val_40[0] = val_37;
            var val_66 = 0;
            val_66 = val_66 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_46 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_37, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ItemReward})), parameters:  val_40)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_48 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_51 = new System.Linq.Expressions.ParameterExpression[1];
            val_51[0] = val_48;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_54 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_48, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ShopTab})), parameters:  val_51)));
            System.Linq.Expressions.ParameterExpression val_56 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_65 = System.Linq.Expressions.Expression.Field(expression:  val_56, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.ShopSystem.不丘丁东丆丏与丌七.ConditionAttr}));
            System.Linq.Expressions.ParameterExpression[] val_59 = new System.Linq.Expressions.ParameterExpression[1];
            val_59[0] = val_56;
            val_66 = null;
            val_66 = null;
            val_68 = 与丑丆丟丞一上专丙.<>c.<>9__0_7;
            if(val_68 == null)
            {
                    System.Func<PGCompany.Attributes.丝万专丆丂丘丌世丟, System.Boolean> val_63 = null;
                val_68 = val_63;
                val_63 = new System.Func<PGCompany.Attributes.丝万专丆丂丘丌世丟, System.Boolean>(object:  与丑丆丟丞一上专丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丆丟丞一上专丙.<>c::丝丟下丑丛丕三丛下(PGCompany.Attributes.丝万专丆丂丘丌世丟 丁丂专业丁丅丅丈丙));
                与丑丆丟丞一上专丙.<>c.<>9__0_7 = val_68;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_64 = FluentValidation.DefaultValidatorExtensions.Must<PGCompany.ShopSystem.不丘丁东丆丏与丌七, PGCompany.Attributes.丝万专丆丂丘丌世丟>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.ShopSystem.不丘丁东丆丏与丌七, PGCompany.Attributes.丝万专丆丂丘丌世丟>(ruleBuilder:  this.RuleForEach<PGCompany.Attributes.丝万专丆丂丘丌世丟>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.ShopSystem.不丘丁东丆丏与丌七, System.Collections.Generic.IEnumerable<PGCompany.Attributes.丝万专丆丂丘丌世丟>>>(body:  val_65, parameters:  val_59))), predicate:  val_63);
        }
    
    }

}
