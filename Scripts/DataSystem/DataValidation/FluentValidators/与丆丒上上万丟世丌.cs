using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 与丆丒上上万丟世丌 : AbstractValidator<PGCompany.TaskBookConfig>
    {
        // Methods
        public 与丆丒上上万丟世丌()
        {
            System.Reflection.MethodInfo val_15;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_15 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<TaskConfig>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_15 != null)
            {
                    val_15 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            val_9[0] = val_2;
            var val_16 = 0;
            val_16 = val_16 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_15 = this.RuleForEach<System.Collections.Generic.List<TaskConfig>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.TaskBookConfig, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<TaskConfig>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.TaskBookConfig.Tasks})), propertyAccessor:  val_15), parameters:  val_9)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丑丙与东丅业丁丞丁(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
