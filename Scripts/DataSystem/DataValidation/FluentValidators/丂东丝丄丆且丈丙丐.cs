using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丂东丝丄丆且丈丙丐 : AbstractValidator<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>
    {
        // Methods
        public 丂东丝丄丆且丈丙丐()
        {
            var val_19;
            System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_21;
            System.Linq.Expressions.ParameterExpression[] val_22;
            var val_23;
            System.Func<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, System.Boolean> val_25;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_19 = null;
            val_19 = null;
            val_21 = 丂东丝丄丆且丈丙丐.<>c.<>9__0_1;
            if(val_21 == null)
            {
                    System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_8 = null;
                val_21 = val_8;
                val_8 = new System.Func<Rilisoft.PlayerPaymentType, System.Boolean>(object:  丂东丝丄丆且丈丙丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丂东丝丄丆且丈丙丐.<>c::丐丕丘三不丒丁丏丐(Rilisoft.PlayerPaymentType 业下丌下三丕丙丌下));
                丂东丝丄丆且丈丙丐.<>c.<>9__0_1 = val_21;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, Rilisoft.PlayerPaymentType>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, Rilisoft.PlayerPaymentType>(ruleBuilder:  this.RuleFor<Rilisoft.PlayerPaymentType>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, Rilisoft.PlayerPaymentType>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞.PlayerPaymentType})), parameters:  val_5)), predicate:  val_8), overridePropertyName:  "когорта");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_13 = new System.Linq.Expressions.ParameterExpression[1];
            val_22 = val_13;
            val_22[0] = val_12;
            val_23 = null;
            val_23 = null;
            val_25 = 丂东丝丄丆且丈丙丐.<>c.<>9__0_3;
            if(val_25 == null)
            {
                    System.Func<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, System.Boolean> val_16 = null;
                val_25 = val_16;
                val_16 = new System.Func<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, System.Boolean>(object:  丂东丝丄丆且丈丙丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丂东丝丄丆且丈丙丐.<>c::与一丁丝一丟丟世丟(PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞 三丟东丕丄丄下下丑));
                丂东丝丄丆且丈丙丐.<>c.<>9__0_3 = val_25;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>(ruleBuilder:  this.RuleFor<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞, PGCompany.DataObjects.Piggy.丕丐丒丝丌丁东丑丞>>(body:  val_12, parameters:  val_13)), predicate:  val_16), overridePropertyName:  "очков < 0");
        }
    
    }

}
