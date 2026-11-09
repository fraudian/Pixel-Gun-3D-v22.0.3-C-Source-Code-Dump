using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 下丅且丕与丙丝丆丞 : AbstractValidator<PGCompany.与丅与丛丗七丞七丛>
    {
        // Methods
        public 下丅且丕与丙丝丆丞()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.与丅与丛丗七丞七丛, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.与丅与丛丗七丞七丛, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.与丅与丛丗七丞七丛, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.与丅与丛丗七丞七丛.Id})), parameters:  val_5))), errorMessage:  "Ид тира цены");
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_14 == null)
            {
                goto label_11;
            }
            
            if(val_11 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_11 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_14[0] = val_11;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.与丅与丛丗七丞七丛, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.与丅与丛丗七丞七丛, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.与丅与丛丗七丞七丛, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.与丅与丛丗七丞七丛.DollarPrice})), parameters:  val_14))), errorMessage:  "Цена в долларах");
        }
    
    }

}
