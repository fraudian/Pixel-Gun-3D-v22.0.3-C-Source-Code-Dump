using UnityEngine;
internal sealed class 万丕上一下丒丌丙丏.丆七下东丞丁丞与上 : AbstractValidator<RecipeSystem.丝丏三三丕丁下丅丒>
{
    // Methods
    public 万丕上一下丒丌丙丏.丆七下东丞丁丞与上()
    {
        var val_32;
        System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_34;
        var val_35;
        System.Func<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Boolean> val_37;
        System.Linq.Expressions.Expression val_38;
        var val_39;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_41;
        System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
        System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
        val_5[0] = val_2;
        val_32 = null;
        val_32 = null;
        val_34 = 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_1;
        if(val_34 == null)
        {
                System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_9 = null;
            val_34 = val_9;
            val_9 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
            万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_1 = val_34;
        }
        
        FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorOptions.WithMessage<RecipeSystem.丝丏三三丕丁下丅丒, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<RecipeSystem.丝丏三三丕丁下丅丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<RecipeSystem.丝丏三三丕丁下丅丒, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<RecipeSystem.丝丏三三丕丁下丅丒, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = RecipeSystem.丝丏三三丕丁下丅丒.Id})), parameters:  val_5))), predicate:  val_9), errorMessage:  "невалидный Id");
        System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
        System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
        val_16[0] = val_13;
        val_35 = null;
        val_35 = null;
        val_37 = 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_3;
        if(val_37 == null)
        {
                System.Func<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Boolean> val_19 = null;
            val_37 = val_19;
            val_19 = new System.Func<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Boolean>(object:  万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c::与一丁丝一丟丟世丟(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 业下丌下三丕丙丌下));
            万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_3 = val_37;
        }
        
        FluentValidation.IRuleBuilderOptions<T, TProperty> val_21 = FluentValidation.DefaultValidatorOptions.WithMessage<RecipeSystem.丝丏三三丕丁下丅丒, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(rule:  FluentValidation.DefaultValidatorExtensions.Must<RecipeSystem.丝丏三三丕丁下丅丒, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(ruleBuilder:  this.RuleFor<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<RecipeSystem.丝丏三三丕丁下丅丒, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = RecipeSystem.丝丏三三丕丁下丅丒.ItemInput})), parameters:  val_16)), predicate:  val_19), errorMessage:  "невалидный ItemInput");
        System.Linq.Expressions.ParameterExpression val_23 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
        val_38 = System.Linq.Expressions.Expression.Field(expression:  val_23, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = RecipeSystem.丝丏三三丕丁下丅丒.ItemReward}));
        System.Linq.Expressions.ParameterExpression[] val_26 = new System.Linq.Expressions.ParameterExpression[1];
        val_26[0] = val_23;
        val_39 = null;
        val_39 = null;
        val_41 = 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_5;
        if(val_41 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_29 = null;
            val_41 = val_29;
            val_29 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c::丘七丗丆丙下丌世丂(PGCompany.三东丏不丗世丅丌丄 业下丌下三丕丙丌下));
            万丕上一下丒丌丙丏.丆七下东丞丁丞与上.<>c.<>9__0_5 = val_41;
        }
        
        FluentValidation.IRuleBuilderOptions<T, TProperty> val_31 = FluentValidation.DefaultValidatorOptions.WithMessage<RecipeSystem.丝丏三三丕丁下丅丒, PGCompany.三东丏不丗世丅丌丄>(rule:  FluentValidation.DefaultValidatorExtensions.Must<RecipeSystem.丝丏三三丕丁下丅丒, PGCompany.三东丏不丗世丅丌丄>(ruleBuilder:  this.RuleFor<PGCompany.三东丏不丗世丅丌丄>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<RecipeSystem.丝丏三三丕丁下丅丒, PGCompany.三东丏不丗世丅丌丄>>(body:  val_38, parameters:  val_26)), predicate:  val_29), errorMessage:  "невалидный ItemReward");
    }

}
