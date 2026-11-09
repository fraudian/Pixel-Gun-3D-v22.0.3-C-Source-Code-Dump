using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丌丛且丆一丌东丈丏 : AbstractValidator<PGCompany.DataObjects.三上一且丄东丑业丞>
    {
        // Methods
        public 丌丛且丆一丌东丈丏()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.三上一且丄东丑业丞, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.三上一且丄东丑业丞, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.三上一且丄东丑业丞, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.三上一且丄东丑业丞, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.三上一且丄东丑业丞.CountInDay})), parameters:  val_5)))), overridePropertyName:  "не указано кол-во нотификаций в день");
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
            var val_23 = 0;
            val_23 = val_23 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.三上一且丄东丑业丞, PGCompany.DataObjects.丆丏丛丝丈三七丗东>(ruleBuilder:  this.RuleForEach<PGCompany.DataObjects.丆丏丛丝丈三七丗东>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.三上一且丄东丑业丞, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.丆丏丛丝丈三七丗东>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.三上一且丄东丑业丞.localNotificationParameters})), parameters:  val_15))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.世丗丐上业万丐专丆(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
