using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丕丆丑东上丙不一丗 : AbstractValidator<PGCompany.丌七丒万丝丄东且七.世不不丒丟丒丕丏丘>
    {
        // Methods
        public 丕丆丑东上丙不一丗()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithMessage<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotNull<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.世不不丒丟丒丕丏丘.LeagueId})), parameters:  val_5))), errorMessage:  "Ид лиги");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_19 = FluentValidation.DefaultValidatorOptions.WithMessage<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<世不不丒丟丒丕丏丘, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.世不不丒丟丒丕丏丘.Place})), parameters:  val_14)))), errorMessage:  "Место");
            System.Linq.Expressions.ParameterExpression val_21 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_24 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_24 == null)
            {
                goto label_17;
            }
            
            if(val_21 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_21 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_24[0] = val_21;
            var val_42 = 0;
            val_42 = val_42 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<世不不丒丟丒丕丏丘, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_21, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.世不不丒丟丒丕丏丘.Rewards})), parameters:  val_24)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_32 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_35 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_35 == null)
            {
                goto label_28;
            }
            
            if(val_32 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_32 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            val_35[0] = val_32;
            var val_43 = 0;
            val_43 = val_43 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_41 = this.RuleForEach<丑不且丁丌专不东丂>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<世不不丒丟丒丕丏丘, System.Collections.Generic.IEnumerable<丑不且丁丌专不东丂>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_32, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丌七丒万丝丄东且七.世不不丒丟丒丕丏丘.AttributeDatas})), parameters:  val_35)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丒丅丁丒丑丙丒不业(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
