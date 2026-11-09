using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丏上丐三丂丄丈丁与 : AbstractValidator<PGCompany.DataObjects.丙七丘三丛丕丙丒丒>
    {
        // Methods
        public 丏上丐三丂丄丈丁与()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.Section})), parameters:  val_5)))), overridePropertyName:  "не указана секция");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.TitleLocKey})), parameters:  val_15)))), overridePropertyName:  "не указан ключ локализации");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.Season})), parameters:  val_25)))), overridePropertyName:  "не указан сезон секции");
            System.Linq.Expressions.ParameterExpression val_32 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_35 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_35 == null)
            {
                goto label_23;
            }
            
            if(val_32 != null)
            {
                goto label_24;
            }
            
            goto label_27;
            label_23:
            if(val_32 == null)
            {
                goto label_27;
            }
            
            label_24:
            label_27:
            val_35[0] = val_32;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_40 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_32, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.ViewVariant})), parameters:  val_35)))), overridePropertyName:  "не указан вариант отображения");
            System.Linq.Expressions.ParameterExpression val_42 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_45 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_45 == null)
            {
                goto label_29;
            }
            
            if(val_42 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(val_42 == null)
            {
                goto label_33;
            }
            
            label_30:
            label_33:
            val_45[0] = val_42;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_50 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.Collections.Generic.List<System.String>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.Collections.Generic.List<System.String>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.Collections.Generic.List<System.String>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<System.String>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.Collections.Generic.List<System.String>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_42, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.Shops})), parameters:  val_45)))), overridePropertyName:  "нет ни одного типа стора");
            System.Linq.Expressions.ParameterExpression val_52 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_55 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_55 == null)
            {
                goto label_35;
            }
            
            if(val_52 != null)
            {
                goto label_36;
            }
            
            goto label_39;
            label_35:
            if(val_52 == null)
            {
                goto label_39;
            }
            
            label_36:
            label_39:
            val_55[0] = val_52;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_60 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.String>(ruleBuilder:  this.RuleForEach<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丙七丘三丛丕丙丒丒, System.Collections.Generic.IEnumerable<System.String>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_52, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丙七丘三丛丕丙丒丒.Shops})), parameters:  val_55)))), overridePropertyName:  "не указан тип стора");
        }
    
    }

}
