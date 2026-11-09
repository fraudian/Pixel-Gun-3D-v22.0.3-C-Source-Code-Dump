using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 业且丄下丈丁丏丏一 : AbstractValidator<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>
    {
        // Methods
        public 业且丄下丈丁丏丏一()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒.Id})), parameters:  val_5)))), errorMessage:  "ид лут рейта");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒.LootBoxIndex})), parameters:  val_15)))), errorMessage:  "индекс лутбокса");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒.LootRateIndex})), parameters:  val_25)))), errorMessage:  "индекс лут рейта");
        }
    
    }

}
