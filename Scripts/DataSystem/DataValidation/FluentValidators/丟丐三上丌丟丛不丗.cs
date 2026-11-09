using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丟丐三上丌丟丛不丗 : AbstractValidator<PGCompany.DataObjects.丈专丕下丂丏三专且>
    {
        // Methods
        public 丟丐三上丌丟丛不丗()
        {
            System.Linq.Expressions.Expression val_19;
            var val_20;
            System.Func<System.Int32, System.Boolean> val_22;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.丈专丕下丂丏三专且, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.丈专丕下丂丏三专且, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丈专丕下丂丏三专且, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丈专丕下丂丏三专且.Counts})), parameters:  val_5))));
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_19 = System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丈专丕下丂丏三专且.Parity}));
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_11;
            val_20 = null;
            val_20 = null;
            val_22 = 丟丐三上丌丟丛不丗.<>c.<>9__0_2;
            if(val_22 == null)
            {
                    System.Func<System.Int32, System.Boolean> val_17 = null;
                val_22 = val_17;
                val_17 = new System.Func<System.Int32, System.Boolean>(object:  丟丐三上丌丟丛不丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丐三上丌丟丛不丗.<>c::丒万三丛丝丗一丂专(int 三丟东丕丄丄下下丑));
                丟丐三上丌丟丛不丗.<>c.<>9__0_2 = val_22;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.丈专丕下丂丏三专且, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丈专丕下丂丏三专且, System.Int32>>(body:  val_19, parameters:  val_14)), predicate:  val_17);
        }
    
    }

}
