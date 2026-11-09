using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 世丞且专丝万一丘丈 : AbstractValidator<PGCompany.丄丑一专丒业东丝丐.专专三东下丒丝丘且>
    {
        // Methods
        public 世丞且专丝万一丘丈()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<专专三东下丒丝丘且, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<专专三东下丒丝丘且, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<专专三东下丒丝丘且, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专专三东下丒丝丘且, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丄丑一专丒业东丝丐.专专三东下丒丝丘且.Id})), parameters:  val_5)))), errorMessage:  "ид акции");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithMessage<专专三东下丒丝丘且, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<专专三东下丒丝丘且, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<专专三东下丒丝丘且, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专专三东下丒丝丘且, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丄丑一专丒业东丝丐.专专三东下丒丝丘且.Name})), parameters:  val_15)))), errorMessage:  "имя акции");
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
            var val_47 = 0;
            val_47 = val_47 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_33 = FluentValidation.DefaultValidatorOptions.WithMessage<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丄丑一专丒业东丝丐.专专三东下丒丝丘且.ItemsFirst})), parameters:  val_25))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "набор предметов 1");
            System.Linq.Expressions.ParameterExpression val_35 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_38 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_38 == null)
            {
                goto label_28;
            }
            
            if(val_35 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_35 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            val_38[0] = val_35;
            var val_48 = 0;
            val_48 = val_48 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_46 = FluentValidation.DefaultValidatorOptions.WithMessage<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专专三东下丒丝丘且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_35, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丄丑一专丒业东丝丐.专专三东下丒丝丘且.ItemsSecond})), parameters:  val_38))).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "набор предметов 2");
        }
    
    }

}
