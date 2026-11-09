using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丅七丂七三丆丞丝丒 : AbstractValidator<PGCompany.且丏丝丗丞丅丂丝丂>
    {
        // Methods
        public 丅七丂七三丆丞丝丒()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.且丏丝丗丞丅丂丝丂.Items})), parameters:  val_5)))), errorMessage:  "пустые предметы в офере");
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
            var val_43 = 0;
            val_43 = val_43 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.且丏丝丗丞丅丂丝丂.Items})), parameters:  val_15)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_23 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_26 == null)
            {
                goto label_22;
            }
            
            if(val_23 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_23 == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            val_26[0] = val_23;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.且丏丝丗丞丅丂丝丂.Price})), parameters:  val_26)))), errorMessage:  "пустая цена в офере");
            System.Linq.Expressions.ParameterExpression val_33 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_36 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_36 == null)
            {
                goto label_28;
            }
            
            if(val_33 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_33 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            val_36[0] = val_33;
            var val_44 = 0;
            val_44 = val_44 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_42 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.且丏丝丗丞丅丂丝丂, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_33, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.且丏丝丗丞丅丂丝丂.Price})), parameters:  val_36)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
