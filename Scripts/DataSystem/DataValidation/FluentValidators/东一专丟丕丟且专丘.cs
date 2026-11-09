using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 东一专丟丕丟且专丘 : AbstractValidator<PGCompany.DataObjects.七丙丄三丐丒东世丅>
    {
        // Methods
        public 东一专丟丕丟且专丘()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七丙丄三丐丒东世丅.Tag})), parameters:  val_5)))), overridePropertyName:  "не указана секция");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.七丙丄三丐丒东世丅, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七丙丄三丐丒东世丅.TitleLocKey})), parameters:  val_15)))), overridePropertyName:  "не указан ключ локализации");
        }
    
    }

}
