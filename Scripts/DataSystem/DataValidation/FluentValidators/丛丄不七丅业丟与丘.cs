using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丛丄不七丅业丟与丘 : AbstractValidator<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>
    {
        // Methods
        public 丛丄不七丅业丟与丘()
        {
            var val_31;
            System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_33;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_31 = null;
            val_31 = null;
            val_33 = 丛丄不七丅业丟与丘.<>c.<>9__0_1;
            if(val_33 == null)
            {
                    System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_8 = null;
                val_33 = val_8;
                val_8 = new System.Func<Rilisoft.PlayerPaymentType, System.Boolean>(object:  丛丄不七丅业丟与丘.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛丄不七丅业丟与丘.<>c::丐丕丘三不丒丁丏丐(Rilisoft.PlayerPaymentType 业下丌下三丕丙丌下));
                丛丄不七丅业丟与丘.<>c.<>9__0_1 = val_33;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, Rilisoft.PlayerPaymentType>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, Rilisoft.PlayerPaymentType>(ruleBuilder:  this.RuleFor<Rilisoft.PlayerPaymentType>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, Rilisoft.PlayerPaymentType>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕.PlayerPaymentType})), parameters:  val_5)), predicate:  val_8), overridePropertyName:  "когорта");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            val_15[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕.ItemParams})), parameters:  val_15)))), overridePropertyName:  "награды");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            val_25[0] = val_22;
            var val_32 = 0;
            val_32 = val_32 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕.ItemParams})), parameters:  val_25)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
