using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 与丅一丆专丁业丄东 : AbstractValidator<PGCompany.丐丐上丝丑七丕三丑>
    {
        // Methods
        public 与丅一丆专丁业丄东()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.丐丐上丝丑七丕三丑, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丐丐上丝丑七丕三丑, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丐丐上丝丑七丕三丑, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丐丐上丝丑七丕三丑.Index})), parameters:  val_5))), errorMessage:  "Индекс акции");
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
            var val_21 = 0;
            val_21 = val_21 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = this.RuleForEach<PGCompany.Attributes.丒丏丆且丕三丘丘丐>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丐丐上丝丑七丕三丑, System.Collections.Generic.IEnumerable<PGCompany.Attributes.丒丏丆且丕三丘丘丐>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丐丐上丝丑七丕三丑.ModifyAttributeDatas})), parameters:  val_14)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丂丏丒七丙丈丞丑(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
