using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丐三专丏丆丟东且且 : AbstractValidator<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>
    {
        // Methods
        public 丐三专丏丆丟东且且()
        {
            var val_51;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_53;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_51 = null;
            val_51 = null;
            val_53 = 丐三专丏丆丟东且且.<>c.<>9__0_1;
            if(val_53 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_8 = null;
                val_53 = val_8;
                val_8 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丐三专丏丆丟东且且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐三专丏丆丟东且且.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丐三专丏丆丟东且且.<>c.<>9__0_1 = val_53;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三.Level})), parameters:  val_5)), predicate:  val_8), overridePropertyName:  "уровень < 1");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            val_15[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三.PointSettings})), parameters:  val_15)))), overridePropertyName:  "настройки очков");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            val_25[0] = val_22;
            var val_53 = 0;
            val_53 = val_53 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = this.RuleForEach<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三.PointSettings})), parameters:  val_25)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丂东丝丄丆且丈丙丐(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_33 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_36 = new System.Linq.Expressions.ParameterExpression[1];
            val_36[0] = val_33;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_41 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_33, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三.RewardSettings})), parameters:  val_36)))), overridePropertyName:  "настройки когорт");
            System.Linq.Expressions.ParameterExpression val_43 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_46 = new System.Linq.Expressions.ParameterExpression[1];
            val_46[0] = val_43;
            var val_54 = 0;
            val_54 = val_54 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_52 = this.RuleForEach<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.Piggy.与丐丅专丘丁上丟丕>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_43, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三.RewardSettings})), parameters:  val_46)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丛丄不七丅业丟与丘(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
