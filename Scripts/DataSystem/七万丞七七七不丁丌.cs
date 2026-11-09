using UnityEngine;

namespace DataSystem
{
    public class 七万丞七七七不丁丌 : DefaultContractResolver
    {
        // Methods
        protected override System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type 丁丅丈丌丟世丗丗丟, Newtonsoft.Json.MemberSerialization 专丞丕与专丟下丄丂)
        {
            var val_9;
            七万丞七七七不丁丌.丞上丕丈丒丘丆三丈 val_1 = new 七万丞七七七不丁丌.丞上丕丈丒丘丆三丈();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .专丞丕与专丟下丄丂 = 专丞丕与专丟下丄丂;
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<Newtonsoft.Json.Serialization.JsonProperty>(source:  System.Linq.Enumerable.Union<Newtonsoft.Json.Serialization.JsonProperty>(first:  System.Linq.Enumerable.Select<System.Reflection.PropertyInfo, Newtonsoft.Json.Serialization.JsonProperty>(source:  丁丅丈丌丟世丗丗丟, selector:  new System.Func<System.Reflection.PropertyInfo, Newtonsoft.Json.Serialization.JsonProperty>(object:  val_1, method:  Newtonsoft.Json.Serialization.JsonProperty 七万丞七七七不丁丌.丞上丕丈丒丘丆三丈::丗一三下东丏丟不不(System.Reflection.PropertyInfo 七丏丄丅丌业与且丙))), second:  System.Linq.Enumerable.Select<System.Reflection.FieldInfo, Newtonsoft.Json.Serialization.JsonProperty>(source:  丁丅丈丌丟世丗丗丟, selector:  new System.Func<System.Reflection.FieldInfo, Newtonsoft.Json.Serialization.JsonProperty>(object:  val_1, method:  Newtonsoft.Json.Serialization.JsonProperty 七万丞七七七不丁丌.丞上丕丈丒丘丆三丈::三业丘丈丝万丌丒丆(System.Reflection.FieldInfo 与丕丁三万专世不丅)))));
            val_9 = null;
            val_9 = null;
            if((七万丞七七七不丁丌.<>c.<>9__0_2) == null)
            {
                goto label_7;
            }
            
            label_12:
            val_7.ForEach(action:  七万丞七七七不丁丌.<>c.<>9__0_2);
            return (System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty>)val_7;
            label_7:
            七万丞七七七不丁丌.<>c.<>9__0_2 = new System.Action<Newtonsoft.Json.Serialization.JsonProperty>(object:  七万丞七七七不丁丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 七万丞七七七不丁丌.<>c::丛东东丙万丕下丝丙(Newtonsoft.Json.Serialization.JsonProperty 七丏丄丅丌业与且丙));
            if(val_7 != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        public 七万丞七七七不丁丌()
        {
        
        }
        private Newtonsoft.Json.Serialization.JsonProperty 专三丟丆专万丈上上(System.Reflection.MemberInfo 上与丄丌丛七与丘丈, Newtonsoft.Json.MemberSerialization 专丞丕与专丟下丄丂)
        {
            return this.CreateProperty(member:  上与丄丌丛七与丘丈, memberSerialization:  专丞丕与专丟下丄丂);
        }
    
    }

}
