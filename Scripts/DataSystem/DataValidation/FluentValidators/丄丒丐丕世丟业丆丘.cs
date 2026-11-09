using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丄丒丐丕世丟业丆丘 : AbstractValidator<PGCompany.PixelPass.世丒上丝专丄不丒丟>
    {
        // Methods
        public 丄丒丐丕世丟业丆丘()
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
            var val_117 = 0;
            val_117 = val_117 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = this.RuleFor<PGCompany.PixelPass.世丛丏丏上世丑东丕>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, PGCompany.PixelPass.世丛丏丏上世丑东丕>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Common})), parameters:  val_5)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丆丄三丅丆丐丅丈丑(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_16 == null)
            {
                goto label_16;
            }
            
            if(val_13 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_13 == null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            val_16[0] = val_13;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Pages})), parameters:  val_16)))), errorMessage:  "станицы сезона");
            System.Linq.Expressions.ParameterExpression val_23 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_26 == null)
            {
                goto label_22;
            }
            
            if(val_23 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_23 == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            val_26[0] = val_23;
            var val_118 = 0;
            val_118 = val_118 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_32 = this.RuleForEach<PGCompany.PixelPass.丆丄万专丄万不世丁>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.IEnumerable<PGCompany.PixelPass.丆丄万专丄万不世丁>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Pages})), parameters:  val_26)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.世丞丅丞丈丘丑不专(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_34 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_37 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_37 == null)
            {
                goto label_33;
            }
            
            if(val_34 != null)
            {
                goto label_34;
            }
            
            goto label_37;
            label_33:
            if(val_34 == null)
            {
                goto label_37;
            }
            
            label_34:
            label_37:
            val_37[0] = val_34;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_42 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_34, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Levels})), parameters:  val_37)))), errorMessage:  "ячейки уровней");
            System.Linq.Expressions.ParameterExpression val_44 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_47 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_47 == null)
            {
                goto label_39;
            }
            
            if(val_44 != null)
            {
                goto label_40;
            }
            
            goto label_43;
            label_39:
            if(val_44 == null)
            {
                goto label_43;
            }
            
            label_40:
            label_43:
            val_47[0] = val_44;
            var val_119 = 0;
            val_119 = val_119 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_53 = this.RuleForEach<PGCompany.PixelPass.世丗丘丈丄丙七丆七>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.IEnumerable<PGCompany.PixelPass.世丗丘丈丄丙七丆七>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_44, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Levels})), parameters:  val_47)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丅丁丞世不丁丏丑丗(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_55 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_58 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_58 == null)
            {
                goto label_50;
            }
            
            if(val_55 != null)
            {
                goto label_51;
            }
            
            goto label_54;
            label_50:
            if(val_55 == null)
            {
                goto label_54;
            }
            
            label_51:
            label_54:
            val_58[0] = val_55;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_63 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_55, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Tasks})), parameters:  val_58)))), errorMessage:  "задачи");
            System.Linq.Expressions.ParameterExpression val_65 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_68 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_68 == null)
            {
                goto label_56;
            }
            
            if(val_65 != null)
            {
                goto label_57;
            }
            
            goto label_60;
            label_56:
            if(val_65 == null)
            {
                goto label_60;
            }
            
            label_57:
            label_60:
            val_68[0] = val_65;
            var val_120 = 0;
            val_120 = val_120 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_74 = this.RuleForEach<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.IEnumerable<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_65, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.Tasks})), parameters:  val_68)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丐七业三万下丌业(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_76 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_79 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_79 == null)
            {
                goto label_67;
            }
            
            if(val_76 != null)
            {
                goto label_68;
            }
            
            goto label_71;
            label_67:
            if(val_76 == null)
            {
                goto label_71;
            }
            
            label_68:
            label_71:
            val_79[0] = val_76;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_84 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_76, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.TasksBase})), parameters:  val_79)))), errorMessage:  "настройки задачи");
            System.Linq.Expressions.ParameterExpression val_86 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_89 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_89 == null)
            {
                goto label_73;
            }
            
            if(val_86 != null)
            {
                goto label_74;
            }
            
            goto label_77;
            label_73:
            if(val_86 == null)
            {
                goto label_77;
            }
            
            label_74:
            label_77:
            val_89[0] = val_86;
            var val_121 = 0;
            val_121 = val_121 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_95 = this.RuleForEach<PGCompany.PixelPass.丙一丘一一丟丄丈世>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.IEnumerable<PGCompany.PixelPass.丙一丘一一丟丄丈世>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_86, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.TasksBase})), parameters:  val_89)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丕丅东专专上丙丁一(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_97 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_100 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_100 == null)
            {
                goto label_84;
            }
            
            if(val_97 != null)
            {
                goto label_85;
            }
            
            goto label_88;
            label_84:
            if(val_97 == null)
            {
                goto label_88;
            }
            
            label_85:
            label_88:
            val_100[0] = val_97;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_105 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈>>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈>>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_97, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.TasksForAds})), parameters:  val_100)))), errorMessage:  "задачи за рекламу");
            System.Linq.Expressions.ParameterExpression val_107 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_110 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_110 == null)
            {
                goto label_90;
            }
            
            if(val_107 != null)
            {
                goto label_91;
            }
            
            goto label_94;
            label_90:
            if(val_107 == null)
            {
                goto label_94;
            }
            
            label_91:
            label_94:
            val_110[0] = val_107;
            var val_122 = 0;
            val_122 = val_122 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_116 = this.RuleForEach<PGCompany.PixelPass.丁七业丂与业丒丑丈>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丒上丝专丄不丒丟, System.Collections.Generic.IEnumerable<PGCompany.PixelPass.丁七业丂与业丒丑丈>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_107, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丒上丝专丄不丒丟.TasksForAds})), parameters:  val_110)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丐专丛丐丏丝万丆世(), ruleSets:  System.Array.Empty<System.String>());
        }
    
    }

}
