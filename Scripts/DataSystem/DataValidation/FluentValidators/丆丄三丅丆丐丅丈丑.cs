using UnityEngine;

namespace DataSystem.DataValidation.FluentValidators
{
    internal sealed class 丆丄三丅丆丐丅丈丑 : AbstractValidator<PGCompany.PixelPass.世丛丏丏上世丑东丕>
    {
        // Methods
        public 丆丄三丅丆丐丅丈丑()
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
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_10 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.SeasonId})), parameters:  val_5)))), errorMessage:  "ид сезона");
            System.Linq.Expressions.ParameterExpression val_12 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_15 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_15 == null)
            {
                goto label_11;
            }
            
            if(val_12 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_12 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_15[0] = val_12;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_20 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.String>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.String>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.String>(ruleBuilder:  this.RuleFor<System.String>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.String>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_12, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.SeasonName})), parameters:  val_15)))), errorMessage:  "имя сезона");
            System.Linq.Expressions.ParameterExpression val_22 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_25 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_25 == null)
            {
                goto label_17;
            }
            
            if(val_22 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_22 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_25[0] = val_22;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_30 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_22, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.StartDate})), parameters:  val_25)))), errorMessage:  "старт сезона");
            System.Linq.Expressions.ParameterExpression val_32 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_35 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_35 == null)
            {
                goto label_23;
            }
            
            if(val_32 != null)
            {
                goto label_24;
            }
            
            goto label_27;
            label_23:
            if(val_32 == null)
            {
                goto label_27;
            }
            
            label_24:
            label_27:
            val_35[0] = val_32;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_40 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>(ruleBuilder:  this.RuleFor<System.DateTime>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.DateTime>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_32, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.EndDate})), parameters:  val_35)))), errorMessage:  "окончание сезона");
            System.Linq.Expressions.ParameterExpression val_42 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_45 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_45 == null)
            {
                goto label_29;
            }
            
            if(val_42 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(val_42 == null)
            {
                goto label_33;
            }
            
            label_30:
            label_33:
            val_45[0] = val_42;
            var val_98 = 0;
            val_98 = val_98 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_51 = this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_42, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.EliteTaskRewards})), parameters:  val_45)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.丏丒丌丆东丛上丈下(), ruleSets:  System.Array.Empty<System.String>());
            System.Linq.Expressions.ParameterExpression val_53 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_56 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_56 == null)
            {
                goto label_40;
            }
            
            if(val_53 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_40:
            if(val_53 == null)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_56[0] = val_53;
            var val_99 = 0;
            val_99 = val_99 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_63 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>(rule:  this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_53, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.LevelPrice})), parameters:  val_56)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "цена за уровень");
            System.Linq.Expressions.ParameterExpression val_65 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_68 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_68 == null)
            {
                goto label_51;
            }
            
            if(val_65 != null)
            {
                goto label_52;
            }
            
            goto label_55;
            label_51:
            if(val_65 == null)
            {
                goto label_55;
            }
            
            label_52:
            label_55:
            val_68[0] = val_65;
            var val_100 = 0;
            val_100 = val_100 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_75 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>(rule:  this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_65, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.PremiumPrice})), parameters:  val_68)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "цена за премиум");
            System.Linq.Expressions.ParameterExpression val_77 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_80 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_80 == null)
            {
                goto label_62;
            }
            
            if(val_77 != null)
            {
                goto label_63;
            }
            
            goto label_66;
            label_62:
            if(val_77 == null)
            {
                goto label_66;
            }
            
            label_63:
            label_66:
            val_80[0] = val_77;
            var val_101 = 0;
            val_101 = val_101 + 1;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_87 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>(rule:  this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, PGCompany.三东丏不丗世丅丌丄>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_77, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.PremiumPackPrice})), parameters:  val_80)).SetValidator(validator:  new DataSystem.DataValidation.FluentValidators.专丝世丟丏三丘丌丕(), ruleSets:  System.Array.Empty<System.String>()), errorMessage:  "цена за премиум с бонусом");
            System.Linq.Expressions.ParameterExpression val_89 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
            System.Linq.Expressions.ParameterExpression[] val_92 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_92 == null)
            {
                goto label_73;
            }
            
            if(val_89 != null)
            {
                goto label_74;
            }
            
            goto label_77;
            label_73:
            if(val_89 == null)
            {
                goto label_77;
            }
            
            label_74:
            label_77:
            val_92[0] = val_89;
            FluentValidation.IRuleBuilderOptions<T, TProperty> val_97 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotNull<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.PixelPass.世丛丏丏上世丑东丕, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_89, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.PixelPass.世丛丏丏上世丑东丕.PremiumBuyLevels})), parameters:  val_92)))), errorMessage:  "количество уровней в премиуме");
        }
    
    }

}
