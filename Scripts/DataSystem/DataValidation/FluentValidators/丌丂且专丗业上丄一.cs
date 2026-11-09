using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丌丂且专丗业上丄一 : AbstractValidator<PGCompany.东丟东且丅与丞丌万>
    {
        // Methods
        public 丌丂且专丗业上丄一()
        {
            System.Reflection.MethodInfo val_12;
            System.Linq.Expressions.Expression val_13;
            var val_14;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_16;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_12 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = Rilisoft.丝丑丂丛万丐丈丘且 PGCompany.东丟东且丅与丞丌万::丞丁下丛丒一丈丌丑()});
            if(val_12 != null)
            {
                    val_12 = 0;
            }
            
            val_13 = System.Linq.Expressions.Expression.Property(expression:  val_2, propertyAccessor:  val_12);
            System.Linq.Expressions.ParameterExpression[] val_7 = new System.Linq.Expressions.ParameterExpression[1];
            val_7[0] = val_2;
            val_14 = null;
            val_14 = null;
            val_16 = 丌丂且专丗业上丄一.<>c.<>9__0_1;
            if(val_16 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_10 = null;
                val_16 = val_10;
                val_10 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丌丂且专丗业上丄一.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丂且专丗业上丄一.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 三丟东丕丄丄下下丑));
                丌丂且专丗业上丄一.<>c.<>9__0_1 = val_16;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorExtensions.Must<PGCompany.东丟东且丅与丞丌万, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.东丟东且丅与丞丌万, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  val_13, parameters:  val_7)), predicate:  val_10);
        }
    
    }

}
