using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丈丏丟一七丐丘业丐 : AbstractValidator<PGCompany.Attributes.丅世下丈丌东一与丒>
    {
        // Methods
        public 丈丏丟一七丐丘业丐()
        {
            this.丙丑丈丛丐业且三丙();
        }
        private void 丙丑丈丛丐业且三丙()
        {
            var val_41;
            System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext> val_43;
            System.Linq.Expressions.Expression val_44;
            var val_45;
            System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext> val_47;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.Attributes.丅世下丈丌东一与丒.Changers})), parameters:  val_5)))), errorMessage:  "empty Changers collection");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            val_15[0] = val_12;
            var val_41 = 0;
            val_41 = val_41 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.Attributes.丅世下丈丌东一与丒, PGCompany.Attributes.丙丗丗丌丗丞丑丒专>(ruleBuilder:  this.RuleForEach<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.IEnumerable<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.Attributes.丅世下丈丌东一与丒.Changers})), parameters:  val_15))).SetValidator(validator:  new 丈丏丟一七丐丘业丐.万丕丘且丛上丐一一(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_24 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_27 = new System.Linq.Expressions.ParameterExpression[1];
            val_27[0] = val_24;
            val_41 = null;
            val_41 = null;
            val_43 = 丈丏丟一七丐丘业丐.<>c.<>9__1_3;
            if(val_43 == null)
            {
                    System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext> val_30 = null;
                val_43 = val_30;
                val_30 = new System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext>(object:  丈丏丟一七丐丘业丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丈丏丟一七丐丘业丐.<>c::丗丌七三丏三丟丑业(System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专> 专丌不丂丁丘丂丗业, FluentValidation.Validators.CustomContext 与且专丈不万东一万));
                丈丏丟一七丐丘业丐.<>c.<>9__1_3 = val_43;
            }
            
            FluentValidation.IRuleBuilderInitial<T, TProperty> val_31 = FluentValidation.DefaultValidatorExtensions.Custom<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_24, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.Attributes.丅世下丈丌东一与丒.Changers})), parameters:  val_27)), action:  val_30);
            System.Linq.Expressions.ParameterExpression val_33 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_44 = System.Linq.Expressions.Expression.Field(expression:  val_33, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.Attributes.丅世下丈丌东一与丒.Changers}));
            System.Linq.Expressions.ParameterExpression[] val_36 = new System.Linq.Expressions.ParameterExpression[1];
            val_36[0] = val_33;
            val_45 = null;
            val_45 = null;
            val_47 = 丈丏丟一七丐丘业丐.<>c.<>9__1_5;
            if(val_47 == null)
            {
                    System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext> val_39 = null;
                val_47 = val_39;
                val_39 = new System.Action<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>, FluentValidation.Validators.CustomContext>(object:  丈丏丟一七丐丘业丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丈丏丟一七丐丘业丐.<>c::丑丆丒业三丒业丐丂(System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专> 专丌不丂丁丘丂丗业, FluentValidation.Validators.CustomContext 与且专丈不万东一万));
                丈丏丟一七丐丘业丐.<>c.<>9__1_5 = val_47;
            }
            
            FluentValidation.IRuleBuilderInitial<T, TProperty> val_40 = FluentValidation.DefaultValidatorExtensions.Custom<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.Attributes.丅世下丈丌东一与丒, System.Collections.Generic.List<PGCompany.Attributes.丙丗丗丌丗丞丑丒专>>>(body:  val_44, parameters:  val_36)), action:  val_39);
        }
    
    }

}
