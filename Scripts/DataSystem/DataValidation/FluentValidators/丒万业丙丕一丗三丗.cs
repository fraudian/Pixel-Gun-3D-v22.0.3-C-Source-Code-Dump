using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丒万业丙丕一丗三丗 : AbstractValidator<PGCompany.丅丝丂丕上业与丐丏>
    {
        // Methods
        public 丒万业丙丕一丗三丗()
        {
            var val_54;
            var val_55;
            System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>, System.Boolean> val_57;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            var val_55 = 0;
            val_55 = val_55 + 1;
            val_54 = public FluentValidation.IRuleBuilderOptions<T, TProperty> FluentValidation.IRuleBuilder<T, TProperty>::SetValidator(FluentValidation.IValidator<TProperty> validator, string[] ruleSets);
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丝丂丕上业与丐丏, 七东万一万丞丂且丒>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丝丂丕上业与丐丏, 七东万一万丞丂且丒>(ruleBuilder:  this.RuleFor<七东万一万丞丂且丒>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丝丂丕上业与丐丏, 七东万一万丞丂且丒>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.Common})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丅丅丕丆丝丙丐不丁(), ruleSets:  System.Array.Empty<System.String>())));
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_18 = new System.Linq.Expressions.ParameterExpression[1];
            val_18[0] = val_15;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_23 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.CohortSettings})), parameters:  val_18)))), overridePropertyName:  "настройки когорт");
            System.Linq.Expressions.ParameterExpression val_25 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_28 = new System.Linq.Expressions.ParameterExpression[1];
            val_28[0] = val_25;
            val_55 = null;
            val_55 = null;
            val_57 = 丒万业丙丕一丗三丗.<>c.<>9__0_3;
            if(val_57 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>, System.Boolean> val_31 = null;
                val_57 = val_31;
                val_54 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>, System.Boolean>::.ctor(object object, IntPtr method);
                val_31 = new System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>, System.Boolean>(object:  丒万业丙丕一丗三丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丒万业丙丕一丗三丗.<>c::与一丁丝一丟丟世丟(System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> 丐丏东世不丅丌且万));
                丒万业丙丕一丗三丗.<>c.<>9__0_3 = val_57;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_33 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(ruleBuilder:  this.RuleForEach<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_25, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.CohortSettings})), parameters:  val_28)), predicate:  val_31), overridePropertyName:  "настройки когорт");
            System.Linq.Expressions.ParameterExpression val_35 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_38 = new System.Linq.Expressions.ParameterExpression[1];
            val_38[0] = val_35;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_43 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.List<丌丙三且世与丄丁专>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.List<丌丙三且世与丄丁专>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.List<丌丙三且世与丄丁专>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<丌丙三且世与丄丁专>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.List<丌丙三且世与丄丁专>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_35, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.OffersSettings})), parameters:  val_38)))), overridePropertyName:  "настройки акций");
            System.Linq.Expressions.ParameterExpression val_45 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_48 = new System.Linq.Expressions.ParameterExpression[1];
            val_48[0] = val_45;
            var val_56 = 0;
            val_56 = val_56 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_54 = this.RuleForEach<丌丙三且世与丄丁专>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丝丂丕上业与丐丏, System.Collections.Generic.IEnumerable<丌丙三且世与丄丁专>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_45, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丝丂丕上业与丐丏.OffersSettings})), parameters:  val_48)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丁七丁不且七丑世下(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
