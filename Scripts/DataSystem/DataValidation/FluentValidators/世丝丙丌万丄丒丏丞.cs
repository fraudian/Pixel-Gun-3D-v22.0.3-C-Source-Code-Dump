using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 世丝丙丌万丄丒丏丞 : AbstractValidator<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕>
    {
        // Methods
        public 世丝丙丌万丄丒丏丞()
        {
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_5 == null)
            {
                goto label_5;
            }
            
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_2 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.Season})), parameters:  val_5)))), overridePropertyName:  "не указан сезон");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_15 == null)
            {
                goto label_11;
            }
            
            if(val_12 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_12 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_15[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.Sections})), parameters:  val_15)))), overridePropertyName:  "нет ни одной секции");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_25 == null)
            {
                goto label_17;
            }
            
            if(val_22 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_22 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_25[0] = val_22;
            var val_65 = 0;
            val_65 = val_65 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, PGCompany.DataObjects.丙七丘三丛丕丙丒丒>(ruleBuilder:  this.RuleForEach<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.Sections})), parameters:  val_25))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏上丐三丂丄丈丁与(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_34 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_37 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_37 == null)
            {
                goto label_28;
            }
            
            if(val_34 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_34 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            val_37[0] = val_34;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_42 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.七丙丄三丐丒东世丅>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.七丙丄三丐丒东世丅>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.七丙丄三丐丒东世丅>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.七丙丄三丐丒东世丅>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.List<PGCompany.DataObjects.七丙丄三丐丒东世丅>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_34, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.Tabs})), parameters:  val_37)))), overridePropertyName:  "нет ни одной вкладки");
            System.Linq.Expressions.ParameterExpression val_44 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_47 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_47 == null)
            {
                goto label_34;
            }
            
            if(val_44 != null)
            {
                goto label_35;
            }
            
            goto label_38;
            label_34:
            if(val_44 == null)
            {
                goto label_38;
            }
            
            label_35:
            label_38:
            val_47[0] = val_44;
            var val_66 = 0;
            val_66 = val_66 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_54 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, PGCompany.DataObjects.七丙丄三丐丒东世丅>(ruleBuilder:  this.RuleForEach<PGCompany.DataObjects.七丙丄三丐丒东世丅>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.七丙丄三丐丒东世丅>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_44, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.Tabs})), parameters:  val_47))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.东一专丟丕丟且专丘(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_56 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_59 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_59 == null)
            {
                goto label_45;
            }
            
            if(val_56 != null)
            {
                goto label_46;
            }
            
            goto label_49;
            label_45:
            if(val_56 == null)
            {
                goto label_49;
            }
            
            label_46:
            label_49:
            val_59[0] = val_56;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_64 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.DataObjects.丄丛一丞丏丕世万三>>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.DataObjects.丄丛一丞丏丕世万三>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.DataObjects.丄丛一丞丏丕世万三>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.DataObjects.丄丛一丞丏丕世万三>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丏丆丘丏丘丂丌万丕, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.DataObjects.丄丛一丞丏丕世万三>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_56, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丏丆丘丏丘丂丌万丕.CurrencySettings})), parameters:  val_59)))), overridePropertyName:  "нет настроек для валюты");
        }
    
    }

}
