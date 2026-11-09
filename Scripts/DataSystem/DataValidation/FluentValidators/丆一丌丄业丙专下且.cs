using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丆一丌丄业丙专下且 : AbstractValidator<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏>
    {
        // Methods
        public 丆一丌丄业丙专下且()
        {
            var val_22;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_24;
            var val_25;
            System.Func<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, System.String> val_27;
            System.Linq.Expressions.Expression val_28;
            var val_29;
            System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_31;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_22 = null;
            val_22 = null;
            val_24 = 丆一丌丄业丙专下且.<>c.<>9__0_1;
            if(val_24 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_8 = null;
                val_24 = val_8;
                val_8 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丆一丌丄业丙专下且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丆一丌丄业丙专下且.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丆一丌丄业丙专下且.<>c.<>9__0_1 = val_24;
            }
            
            val_25 = null;
            val_25 = null;
            val_27 = 丆一丌丄业丙专下且.<>c.<>9__0_2;
            if(val_27 == null)
            {
                    System.Func<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, System.String> val_10 = null;
                val_27 = val_10;
                val_10 = new System.Func<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, System.String>(object:  丆一丌丄业丙专下且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丆一丌丄业丙专下且.<>c::丒万三丛丝丗一丂专(PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏 业下丌下三丕丙丌下));
                丆一丌丄业丙专下且.<>c.<>9__0_2 = val_27;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏.Inapp})), parameters:  val_5)), predicate:  val_8), nameProvider:  val_10);
            System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_28 = System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏.PlayerPaymentType}));
            System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
            val_16[0] = val_13;
            val_29 = null;
            val_29 = null;
            val_31 = 丆一丌丄业丙专下且.<>c.<>9__0_4;
            if(val_31 == null)
            {
                    System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_19 = null;
                val_31 = val_19;
                val_19 = new System.Func<Rilisoft.PlayerPaymentType, System.Boolean>(object:  丆一丌丄业丙专下且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丆一丌丄业丙专下且.<>c::丌万专上万丐丌业不(Rilisoft.PlayerPaymentType 业下丌下三丕丙丌下));
                丆一丌丄业丙专下且.<>c.<>9__0_4 = val_31;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.PlayerPaymentType>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.PlayerPaymentType>(ruleBuilder:  this.RuleFor<Rilisoft.PlayerPaymentType>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏, Rilisoft.PlayerPaymentType>>(body:  val_28, parameters:  val_16)), predicate:  val_19), overridePropertyName:  "когорта");
        }
    
    }

}
