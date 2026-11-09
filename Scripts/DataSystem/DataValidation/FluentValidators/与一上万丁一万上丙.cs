using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 与一上万丁一万上丙 : AbstractValidator<PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万>
    {
        // Methods
        public 与一上万丁一万上丙()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithName<专七丙丅丙东七万万, 世丕上丞与业丂丞丞>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<专七丙丅丙东七万万, 世丕上丞与业丂丞丞>(ruleBuilder:  this.RuleFor<世丕上丞与业丂丞丞>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专七丙丅丙东七万万, 世丕上丞与业丂丞丞>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万.ItemGroup})), parameters:  val_5)), toCompare:  0, comparer:  0), overridePropertyName:  "группа предметов");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = this.RuleForEach<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<专七丙丅丙东七万万, System.Collections.Generic.IEnumerable<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万.AlternativeItemParams})), parameters:  val_14)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
