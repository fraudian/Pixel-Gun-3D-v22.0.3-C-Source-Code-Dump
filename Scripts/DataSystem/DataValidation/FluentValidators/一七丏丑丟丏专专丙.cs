using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 一七丏丑丟丏专专丙 : AbstractValidator<PGCompany.LootBoxSystem.丏丛且不丏与万一上>
    {
        // Methods
        public 一七丏丑丟丏专专丙()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.LootBoxSystem.丏丛且不丏与万一上, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.LootBoxSystem.丏丛且不丏与万一上, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.LootBoxSystem.丏丛且不丏与万一上, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丏丛且不丏与万一上, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丏丛且不丏与万一上.LootRateIndex})), parameters:  val_5)))), errorMessage:  "индекс лут рейта");
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
            var val_22 = 0;
            val_22 = val_22 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.LootBoxSystem.丏丛且不丏与万一上, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.LootBoxSystem.丏丛且不丏与万一上.Rewards})), parameters:  val_15)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
