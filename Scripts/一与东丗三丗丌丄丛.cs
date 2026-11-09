using UnityEngine;
internal sealed class 万丙丂世下东丒与世.一与东丗三丗丌丄丛 : AbstractValidator<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂>
{
    // Methods
    public 万丙丂世下东丒与世.一与东丗三丗丌丄丛()
    {
        var val_23;
        System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_25;
        System.Linq.Expressions.Expression val_26;
        var val_27;
        System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_29;
        System.Linq.Expressions.ParameterExpression val_2 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
        System.Linq.Expressions.ParameterExpression[] val_5 = new System.Linq.Expressions.ParameterExpression[1];
        val_5[0] = val_2;
        val_23 = null;
        val_23 = null;
        val_25 = 万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.<>9__0_1;
        if(val_25 == null)
        {
                System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_9 = null;
            val_25 = val_9;
            val_9 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c::丐丕丘三不丒丁丏丐(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
            万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.<>9__0_1 = val_25;
        }
        
        FluentValidation.IRuleBuilderOptions<T, TProperty> val_11 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  System.Linq.Expressions.Expression.Field(expression:  val_2, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.GraffitiSystem.下万丆丗丄三丙东丂.Id})), parameters:  val_5))), predicate:  val_9), errorMessage:  "невалидный Id");
        System.Linq.Expressions.ParameterExpression val_13 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "x");
        val_26 = System.Linq.Expressions.Expression.Field(expression:  val_13, field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = PGCompany.GraffitiSystem.下万丆丗丄三丙东丂.LifeTime}));
        System.Linq.Expressions.ParameterExpression[] val_16 = new System.Linq.Expressions.ParameterExpression[1];
        val_16[0] = val_13;
        val_27 = null;
        val_27 = null;
        val_29 = 万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.<>9__0_3;
        if(val_29 == null)
        {
                System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean> val_20 = null;
            val_29 = val_20;
            val_20 = new System.Func<Rilisoft.丝丑丂丛万丐丈丘且, System.Boolean>(object:  万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c::与一丁丝一丟丟世丟(Rilisoft.丝丑丂丛万丐丈丘且 业下丌下三丕丙丌下));
            万丙丂世下东丒与世.一与东丗三丗丌丄丛.<>c.<>9__0_3 = val_29;
        }
        
        FluentValidation.IRuleBuilderOptions<T, TProperty> val_22 = FluentValidation.DefaultValidatorOptions.WithMessage<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(rule:  FluentValidation.DefaultValidatorExtensions.Must<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  FluentValidation.DefaultValidatorExtensions.NotEmpty<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>(ruleBuilder:  this.RuleFor<Rilisoft.丝丑丂丛万丐丈丘且>(expression:  System.Linq.Expressions.Expression.Lambda<System.Func<PGCompany.GraffitiSystem.下万丆丗丄三丙东丂, Rilisoft.丝丑丂丛万丐丈丘且>>(body:  val_26, parameters:  val_16))), predicate:  val_20), errorMessage:  "невалидный LifeTime");
    }

}
