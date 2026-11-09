using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal class 丗上业东丐丌万与业 : AbstractValidator<PGCompany.DataObjects.业丏丈丞丘业丈丞一>
    {
        // Methods
        public 丗上业东丐丌万与业()
        {
            var val_105;
            System.Func<System.Int32, System.Boolean> val_107;
            var val_108;
            System.Func<System.Int32, System.Boolean> val_110;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Data})), parameters:  val_5))));
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_11;
            var val_105 = 0;
            val_105 = val_105 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = this.RuleForEach<PGCompany.DataObjects.七下上丁万东丑世业>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.七下上丁万东丑世业>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Data})), parameters:  val_14)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丄丒世丄丏丟丄万丂(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            val_25[0] = val_22;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_29 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.GatchaItems})), parameters:  val_25))));
            System.Linq.Expressions.ParameterExpression val_31 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_34 = new System.Linq.Expressions.ParameterExpression[1];
            val_34[0] = val_31;
            var val_106 = 0;
            val_106 = val_106 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_40 = this.RuleForEach<PGCompany.DataObjects.丈专丕下丂丏三专且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.丈专丕下丂丏三专且>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_31, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.GatchaItems})), parameters:  val_34)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丟丐三上丌丟丛不丗(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_42 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_45 = new System.Linq.Expressions.ParameterExpression[1];
            val_45[0] = val_42;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_49 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_42, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.GatchaSequence})), parameters:  val_45))));
            System.Linq.Expressions.ParameterExpression val_51 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_56 = new System.Linq.Expressions.ParameterExpression[1];
            val_56[0] = val_51;
            val_105 = null;
            val_105 = null;
            val_107 = 丗上业东丐丌万与业.<>c.<>9__0_6;
            if(val_107 == null)
            {
                    System.Func<System.Int32, System.Boolean> val_59 = null;
                val_107 = val_59;
                val_59 = new System.Func<System.Int32, System.Boolean>(object:  丗上业东丐丌万与业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丗上业东丐丌万与业.<>c::上丟上丌丄下与丁丄(int 三丟东丕丄丄下下丑));
                丗上业东丐丌万与业.<>c.<>9__0_6 = val_107;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_60 = FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  val_51, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Schedule})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七七丙丗丏丑专业丝.SeasonDays})), parameters:  val_56)), predicate:  val_59);
            System.Linq.Expressions.ParameterExpression val_62 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_67 = new System.Linq.Expressions.ParameterExpression[1];
            val_67[0] = val_62;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_71 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<GiftSettingType>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<GiftSettingType>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<GiftSettingType>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<GiftSettingType>>>(body:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  val_62, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Schedule})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.七七丙丗丏丑专业丝.SeasonSettings})), parameters:  val_67))));
            System.Linq.Expressions.ParameterExpression val_73 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_78 = new System.Linq.Expressions.ParameterExpression[1];
            val_78[0] = val_73;
            val_108 = null;
            val_108 = null;
            val_110 = 丗上业东丐丌万与业.<>c.<>9__0_9;
            if(val_110 == null)
            {
                    System.Func<System.Int32, System.Boolean> val_81 = null;
                val_110 = val_81;
                val_81 = new System.Func<System.Int32, System.Boolean>(object:  丗上业东丐丌万与业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丗上业东丐丌万与业.<>c::丗一与业七丐丑不世(int 三丟东丕丄丄下下丑));
                丗上业东丐丌万与业.<>c.<>9__0_9 = val_110;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_82 = FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Int32>(ruleBuilder:  this.RuleFor<System.Int32>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Int32>>(body:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  val_73, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Settings})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.世上丛丄丛专东丏丟.Version})), parameters:  val_78)), predicate:  val_81);
            System.Linq.Expressions.ParameterExpression val_84 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_89 = new System.Linq.Expressions.ParameterExpression[1];
            val_89[0] = val_84;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_93 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<System.Int32>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>>(body:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  val_84, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Settings})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.世上丛丄丛专东丏丟.SpinPrice})), parameters:  val_89))));
            System.Linq.Expressions.ParameterExpression val_95 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_100 = new System.Linq.Expressions.ParameterExpression[1];
            val_100[0] = val_95;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_104 = FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<System.Int32>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.业丏丈丞丘业丈丞一, System.Collections.Generic.List<System.Int32>>>(body:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  val_95, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.业丏丈丞丘业丈丞一.Settings})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.世上丛丄丛专东丏丟.SpinCoinsCompensation})), parameters:  val_100))));
        }
    
    }

}
