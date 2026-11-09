using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 专丝世丟丏三丘丌丕 : AbstractValidator<PGCompany.三东丏不丗世丅丌丄>
    {
        // Methods
        public 专丝世丟丏三丘丌丕()
        {
            System.Linq.Expressions.ParameterExpression[] val_11;
            var val_12;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_14;
            var val_15;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_17;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_3 = new System.Linq.Expressions.ParameterExpression[1];
            val_11 = val_3;
            val_11[0] = val_2;
            val_12 = null;
            val_12 = null;
            val_14 = 专丝世丟丏三丘丌丕.<>c.<>9__0_1;
            if(val_14 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_7 = null;
                val_14 = val_7;
                val_7 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  专丝世丟丏三丘丌丕.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 专丝世丟丏三丘丌丕.<>c::丐丕丘三不丒丁丏丐(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏));
                专丝世丟丏三丘丌丕.<>c.<>9__0_1 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = 专丝世丟丏三丘丌丕.<>c.<>9__0_2;
            if(val_17 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_9 = null;
                val_17 = val_9;
                val_9 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.String>(object:  专丝世丟丏三丘丌丕.<>c.__il2cppRuntimeField_static_fields, method:  System.String 专丝世丟丏三丘丌丕.<>c::丒万三丛丝丗一丂专(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
                专丝世丟丏三丘丌丕.<>c.<>9__0_2 = val_17;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>>(body:  val_2, parameters:  val_3))), predicate:  val_7), nameProvider:  val_9);
        }
    
    }

}
