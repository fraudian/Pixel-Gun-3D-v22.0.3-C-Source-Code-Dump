using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丏丂丏丒七丙丈丞丑 : AbstractValidator<PGCompany.Attributes.丒丏丆且丕三丘丘丐>
    {
        // Methods
        public 丏丂丏丒七丙丈丞丑()
        {
            System.Reflection.MethodInfo val_21;
            System.Reflection.MethodInfo val_22;
            System.Reflection.MethodInfo val_23;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_21 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = static PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂 PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈::丛丗丗丙丞丈且丌与(int 丂世丒下丁三丄东丆)});
            System.Linq.Expressions.Expression[] val_4 = new System.Linq.Expressions.Expression[1];
            val_22 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Int32 Rilisoft.丝丑丂丛万丐丈丘且::世三丞丅丑丌丈丈一()});
            if(val_22 != null)
            {
                    val_22 = 0;
            }
            
            val_4[0] = System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.Attributes.丒丏丆且丕三丘丘丐.AttributeIndex})), propertyAccessor:  val_22);
            if(val_21 != null)
            {
                    val_21 = 0;
            }
            
            val_23 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = System.Boolean PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂::上专三丗丏丄丂丙丐()});
            if(val_23 != null)
            {
                    val_23 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
            val_16[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.Attributes.丒丏丆且丕三丘丘丐, System.Boolean>(rule:  FluentValidation.DefaultValidatorExtensions.NotEqual<PGCompany.Attributes.丒丏丆且丕三丘丘丐, System.Boolean>(ruleBuilder:  this.RuleFor<System.Boolean>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.Attributes.丒丏丆且丕三丘丘丐, System.Boolean>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Call(instance:  0, method:  val_21, arguments:  val_4), propertyAccessor:  val_23), parameters:  val_16)), toCompare:  true, comparer:  0), errorMessage:  "Системные атрибуты нельзя изменять");
        }
    
    }

}
