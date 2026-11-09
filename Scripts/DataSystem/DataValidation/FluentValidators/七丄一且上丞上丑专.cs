using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 七丄一且上丞上丑专 : AbstractValidator<PGCompany.丅丞与丟与丄丕丒丂>
    {
        // Methods
        public 七丄一且上丞上丑专()
        {
            var val_118;
            var val_119;
            System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>, System.Boolean> val_121;
            System.Reflection.MethodInfo val_122;
            System.Reflection.MethodInfo val_124;
            System.Reflection.MethodInfo val_125;
            System.Reflection.MethodInfo val_127;
            System.Reflection.MethodInfo val_128;
            var val_129;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            var val_121 = 0;
            val_121 = val_121 + 1;
            val_118 = public FluentValidation.IRuleBuilderOptions<T, TProperty> FluentValidation.IRuleBuilder<T, TProperty>::SetValidator(FluentValidation.IValidator<TProperty> validator, string[] ruleSets);
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_13 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丞与丟与丄丕丒丂, 七东万一万丞丂且丒>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丞与丟与丄丕丒丂, 七东万一万丞丂且丒>(ruleBuilder:  this.RuleFor<七东万一万丞丂且丒>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, 七东万一万丞丂且丒>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.Common})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.东业丛丛丄丈丏丅下(), ruleSets:  System.Array.Empty<System.String>())));
            System.Linq.Expressions.ParameterExpression val_15 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_18 = new System.Linq.Expressions.ParameterExpression[1];
            val_18[0] = val_15;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_23 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_15, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.CohortsSettings})), parameters:  val_18)))), overridePropertyName:  "настройки когорт");
            System.Linq.Expressions.ParameterExpression val_25 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_28 = new System.Linq.Expressions.ParameterExpression[1];
            val_28[0] = val_25;
            val_119 = null;
            val_119 = null;
            val_121 = 七丄一且上丞上丑专.<>c.<>9__0_3;
            if(val_121 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>, System.Boolean> val_31 = null;
                val_121 = val_31;
                val_118 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>, System.Boolean>::.ctor(object object, IntPtr method);
                val_31 = new System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>, System.Boolean>(object:  七丄一且上丞上丑专.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 七丄一且上丞上丑专.<>c::与一丁丝一丟丟世丟(System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏> 丐丏东世不丅丌且万));
                七丄一且上丞上丑专.<>c.<>9__0_3 = val_121;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_33 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(ruleBuilder:  this.RuleForEach<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_25, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.CohortsSettings})), parameters:  val_28)), predicate:  val_31), overridePropertyName:  "настройки когорт");
            System.Linq.Expressions.ParameterExpression val_35 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_122 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_122 != null)
            {
                    val_122 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_42 = new System.Linq.Expressions.ParameterExpression[1];
            val_42[0] = val_35;
            var val_122 = 0;
            val_122 = val_122 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_48 = this.RuleForEach<专丙丆丏且七丈丗丏>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<专丙丆丏且七丈丗丏>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_35, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.CohortsSettings})), propertyAccessor:  val_122), parameters:  val_42)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.三丗丏万不丈丒丗丐(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_50 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_53 = new System.Linq.Expressions.ParameterExpression[1];
            val_53[0] = val_50;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_58 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_50, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.Packs})), parameters:  val_53)))), overridePropertyName:  "настройки паков");
            System.Linq.Expressions.ParameterExpression val_60 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_124 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.KeyCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>::get_Keys()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_124 != null)
            {
                    val_124 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_66 = new System.Linq.Expressions.ParameterExpression[1];
            val_66[0] = val_60;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_70 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.丅丞与丟与丄丕丒丂, System.Int32>(ruleBuilder:  this.RuleForEach<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<System.Int32>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_60, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.Packs})), propertyAccessor:  val_124), parameters:  val_66)), valueToCompare:  0), overridePropertyName:  "цена акции в паке");
            System.Linq.Expressions.ParameterExpression val_72 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_125 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_125 != null)
            {
                    val_125 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_78 = new System.Linq.Expressions.ParameterExpression[1];
            val_78[0] = val_72;
            var val_123 = 0;
            val_123 = val_123 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_84 = this.RuleForEach<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_72, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.Packs})), propertyAccessor:  val_125), parameters:  val_78)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.与上丞七东一专丝专(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_86 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_89 = new System.Linq.Expressions.ParameterExpression[1];
            val_89[0] = val_86;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_94 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_86, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.AvailableItems})), parameters:  val_89)))), overridePropertyName:  "доступные предметы");
            System.Linq.Expressions.ParameterExpression val_96 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_127 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.KeyCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>::get_Keys()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_127 != null)
            {
                    val_127 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_102 = new System.Linq.Expressions.ParameterExpression[1];
            val_102[0] = val_96;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_106 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.丅丞与丟与丄丕丒丂, System.Int32>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.丅丞与丟与丄丕丒丂, System.Int32>(ruleBuilder:  this.RuleForEach<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<System.Int32>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_96, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.AvailableItems})), propertyAccessor:  val_127), parameters:  val_102)), valueToCompare:  0), overridePropertyName:  "цена акции в доступных предметах");
            System.Linq.Expressions.ParameterExpression val_108 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            val_128 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>::get_Values()}, declaringType:  new System.RuntimeTypeHandle());
            if(val_128 != null)
            {
                    val_129 = 1152921507157464592;
                val_128 = 0;
            }
            else
            {
                    val_129 = 1152921507157464592;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_114 = new System.Linq.Expressions.ParameterExpression[1];
            val_114[0] = val_108;
            var val_124 = 0;
            val_124 = val_124 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_120 = this.RuleForEach<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.丅丞与丟与丄丕丒丂, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>>(body:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  val_108, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.丅丞与丟与丄丕丒丂.AvailableItems})), propertyAccessor:  val_128), parameters:  val_114)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专业丏东丐丏丂万且(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
