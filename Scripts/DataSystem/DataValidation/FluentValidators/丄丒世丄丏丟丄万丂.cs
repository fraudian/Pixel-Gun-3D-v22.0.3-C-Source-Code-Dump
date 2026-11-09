using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丄丒世丄丏丟丄万丂 : AbstractValidator<PGCompany.DataObjects.七下上丁万东丑世业>
    {
        // Methods
        public 丄丒世丄丏丟丄万丂()
        {
            var val_6;
            System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean> val_8;
            IntPtr val_9;
            val_6 = null;
            val_6 = null;
            val_8 = 丄丒世丄丏丟丄万丂.<>c.<>9__0_0;
            if(val_8 == null)
            {
                    System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean> val_1 = null;
                val_8 = val_1;
                val_1 = new System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean>(object:  丄丒世丄丏丟丄万丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丄丒世丄丏丟丄万丂.<>c::不丁丂丐丄丈万丆丞(PGCompany.DataObjects.七下上丁万东丑世业 三丟东丕丄丄下下丑));
                丄丒世丄丏丟丄万丂.<>c.<>9__0_0 = val_8;
            }
            
            System.Action val_4 = null;
            val_9 = System.Void DataSystem.DataValidation.FluentValidators.丄丒世丄丏丟丄万丂::丒万三丛丝丗一丂专();
            val_4 = new System.Action(object:  this, method:  val_9);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = 0;
            this.When(predicate:  val_1, action:  new System.Action(object:  this, method:  System.Void DataSystem.DataValidation.FluentValidators.丄丒世丄丏丟丄万丂::丐丕丘三不丒丁丏丐())).Otherwise(action:  val_4);
        }
        private void 丐丕丘三不丒丁丏丐()
        {
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "y");
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.七下上丁万东丑世业, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.七下上丁万东丑世业, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七下上丁万东丑世业.ItemIdTable})), parameters:  val_5))));
        }
        private void 丒万三丛丝丗一丂专()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_8 = FluentValidation.DefaultValidatorExtensions.Null<PGCompany.DataObjects.七下上丁万东丑世业, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七下上丁万东丑世业.ItemIdTable})), parameters:  val_5)));
        }
    
    }

}
