using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丝丝三丅一七丐专丝 : AbstractValidator<PGCompany.DataObjects.丘与上丂不与丌万与>
    {
        // Methods
        public 丝丝三丅一七丐专丝()
        {
            System.Linq.Expressions.Expression val_11;
            var val_12;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_14;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_11 = System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.丘与上丂不与丌万与.Id}));
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            val_12 = null;
            val_12 = null;
            val_14 = 丝丝三丅一七丐专丝.<>c.<>9__0_1;
            if(val_14 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_8 = null;
                val_14 = val_8;
                val_8 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丝丝三丅一七丐专丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丝三丅一七丐专丝.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丝丝三丅一七丐专丝.<>c.<>9__0_1 = val_14;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.丘与上丂不与丌万与, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.丘与上丂不与丌万与, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.丘与上丂不与丌万与, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  val_11, parameters:  val_5)), predicate:  val_8), overridePropertyName:  "Id < 0");
        }
    
    }

}
