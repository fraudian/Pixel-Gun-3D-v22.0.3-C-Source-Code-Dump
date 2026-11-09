using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 且丕丈丞丕丌业丆世 : AbstractValidator<PGCompany.丅丝丂丕上业与丐丏.丝丕专世丙丆丛丝丝>
    {
        // Methods
        public 且丕丈丞丕丌业丆世()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<丝丕专世丙丆丛丝丝, System.Collections.Generic.List<专七丙丅丙东七万万>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<丝丕专世丙丆丛丝丝, System.Collections.Generic.List<专七丙丅丙东七万万>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<丝丕专世丙丆丛丝丝, System.Collections.Generic.List<专七丙丅丙东七万万>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<专七丙丅丙东七万万>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丝丕专世丙丆丛丝丝, System.Collections.Generic.List<专七丙丅丙东七万万>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丝丕专世丙丆丛丝丝.RegularSlotsSettings})), parameters:  val_5)))), overridePropertyName:  "регулярные слоты");
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
            var val_33 = 0;
            val_33 = val_33 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = this.RuleForEach<专七丙丅丙东七万万>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丝丕专世丙丆丛丝丝, System.Collections.Generic.IEnumerable<专七丙丅丙东七万万>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丝丕专世丙丆丛丝丝.RegularSlotsSettings})), parameters:  val_15)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.与一上万丁一万上丙(), ruleSets:  System.Array.Empty<System.String>());
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
            var val_34 = 0;
            val_34 = val_34 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<丝丕专世丙丆丛丝丝, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.丝丕专世丙丆丛丝丝.GiftSlotItemParams})), parameters:  val_26)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
