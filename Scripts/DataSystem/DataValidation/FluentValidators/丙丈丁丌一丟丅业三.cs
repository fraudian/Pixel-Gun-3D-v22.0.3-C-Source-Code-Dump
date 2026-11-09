using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    public class 丙丈丁丌一丟丅业三 : AbstractValidator<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏>
    {
        // Methods
        public 丙丈丁丌一丟丅业三()
        {
            var val_89;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_91;
            var val_92;
            var val_93;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_95;
            var val_96;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_98;
            var val_99;
            System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_101;
            System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
            val_5[0] = val_2;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_9 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.StartTime})), parameters:  val_5)), valueToCompare:  new System.DateTime()), overridePropertyName:  "id сезона акции");
            System.Linq.Expressions.ParameterExpression val_11 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[1];
            val_14[0] = val_11;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_18 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.GreaterThan<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_11, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.EndTime})), parameters:  val_14)), valueToCompare:  new System.DateTime()), overridePropertyName:  "время завершения акции");
            System.Linq.Expressions.ParameterExpression val_20 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_23 = new System.Linq.Expressions.ParameterExpression[1];
            val_23[0] = val_20;
            val_89 = null;
            val_89 = null;
            val_91 = 丙丈丁丌一丟丅业三.<>c.<>9__0_3;
            if(val_91 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_26 = null;
                val_91 = val_26;
                val_92 = public System.Void System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>::.ctor(object object, IntPtr method);
                val_26 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丙丈丁丌一丟丅业三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丈丁丌一丟丅业三.<>c::与一丁丝一丟丟世丟(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丙丈丁丌一丟丅业三.<>c.<>9__0_3 = val_91;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_28 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_20, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.Id})), parameters:  val_23)), predicate:  val_26), overridePropertyName:  "id сезона акции < 1");
            System.Linq.Expressions.ParameterExpression val_30 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_33 = new System.Linq.Expressions.ParameterExpression[1];
            val_33[0] = val_30;
            val_93 = null;
            val_93 = null;
            val_95 = 丙丈丁丌一丟丅业三.<>c.<>9__0_5;
            if(val_95 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_36 = null;
                val_95 = val_36;
                val_92 = public System.Void System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>::.ctor(object object, IntPtr method);
                val_36 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丙丈丁丌一丟丅业三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丈丁丌一丟丅业三.<>c::丘七丗丆丙下丌世丂(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丙丈丁丌一丟丅业三.<>c.<>9__0_5 = val_95;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_38 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_30, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.LevelAvailable})), parameters:  val_33)), predicate:  val_36), overridePropertyName:  "уровень игрока < 1");
            System.Linq.Expressions.ParameterExpression val_40 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_43 = new System.Linq.Expressions.ParameterExpression[1];
            val_43[0] = val_40;
            val_96 = null;
            val_96 = null;
            val_98 = 丙丈丁丌一丟丅业三.<>c.<>9__0_7;
            if(val_98 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_46 = null;
                val_98 = val_46;
                val_92 = public System.Void System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>::.ctor(object object, IntPtr method);
                val_46 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丙丈丁丌一丟丅业三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丈丁丌一丟丅业三.<>c::丝丟下丑丛丕三丛下(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丙丈丁丌一丟丅业三.<>c.<>9__0_7 = val_98;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_48 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_40, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.PointsPerMatch})), parameters:  val_43)), predicate:  val_46), overridePropertyName:  "очки выдаваемые за матч < 1");
            System.Linq.Expressions.ParameterExpression val_50 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_53 = new System.Linq.Expressions.ParameterExpression[1];
            val_53[0] = val_50;
            val_99 = null;
            val_99 = null;
            val_101 = 丙丈丁丌一丟丅业三.<>c.<>9__0_9;
            if(val_101 == null)
            {
                    System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_56 = null;
                val_101 = val_56;
                val_92 = public System.Void System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>::.ctor(object object, IntPtr method);
                val_56 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  丙丈丁丌一丟丅业三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丈丁丌一丟丅业三.<>c::丗一与业七丐丑不世(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
                丙丈丁丌一丟丅业三.<>c.<>9__0_9 = val_101;
            }
            
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_58 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_50, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.TimeToRepeat})), parameters:  val_53)), predicate:  val_56), overridePropertyName:  "время через которое акция запускается снова < 1");
            System.Linq.Expressions.ParameterExpression val_60 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_63 = new System.Linq.Expressions.ParameterExpression[1];
            val_63[0] = val_60;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_68 = FluentValidation.DefaultValidatorOptions.WithName<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_60, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.LevelSettings})), parameters:  val_63)))), overridePropertyName:  "Настройка инаппов в зависимости от когорты игрока и уровня акци");
            System.Linq.Expressions.ParameterExpression val_70 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_73 = new System.Linq.Expressions.ParameterExpression[1];
            val_73[0] = val_70;
            var val_91 = 0;
            val_91 = val_91 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_79 = this.RuleForEach<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_70, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.LevelSettings})), parameters:  val_73)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丐三专丏丆丟东且且(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_81 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_84 = new System.Linq.Expressions.ParameterExpression[1];
            val_84[0] = val_81;
            var val_92 = 0;
            val_92 = val_92 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_90 = this.RuleForEach<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏, System.Collections.Generic.IEnumerable<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_81, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏.InappSettings})), parameters:  val_84)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丆一丌丄业丙专下且(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
