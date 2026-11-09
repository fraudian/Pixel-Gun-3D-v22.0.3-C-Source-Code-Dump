using UnityEngine;
internal sealed class MyMobIgnorIDamageable : IgnorIDamageable
{
    // Fields
    private System.Collections.Generic.List<System.Type> 丅丒丌丝丙一丏丂丈;
    
    // Methods
    internal override bool 上丂丗丗丙丏东丆丂(object[] 丗专丆万丏万丂丂丆)
    {
        System.Collections.Generic.List<System.Type> val_4;
        var val_5;
        val_4 = this;
        if(丗专丆万丏万丂丂丆.Length != 0)
        {
                object val_4 = 丗专丆万丏万丂丂丆[0];
            if(val_4 != null)
        {
                val_4 = this.丅丒丌丝丙一丏丂丈;
            val_5 = (val_4.Contains(item:  val_4.GetType())) ^ 1;
            return (bool)val_5 & 1;
        }
        
        }
        
        val_5 = 1;
        return (bool)val_5 & 1;
    }
    public MyMobIgnorIDamageable()
    {
        System.Collections.Generic.List<System.Type> val_1 = new System.Collections.Generic.List<System.Type>();
        val_1.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        this.丅丒丌丝丙一丏丂丈 = val_1;
    }

}
