using UnityEngine;
internal class AlternativeAttackFactory : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.Dictionary<三丛丏丒不专丈万业, System.Type> 世丂上丌丞且丁七丏;
    
    // Methods
    public static 一上不上一丅专专丐 GetHandler(三丛丏丒不专丈万业 丘世丐不丈丐丟上业, object[] 专丒丌丆下丐丞丟丞)
    {
        三丛丏丒不专丈万业 val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丘世丐不丈丐丟上业;
        val_7 = null;
        val_7 = null;
        if((AlternativeAttackFactory.世丂上丌丞且丁七丏.ContainsKey(key:  val_6)) != false)
        {
                val_8 = null;
            val_8 = null;
            object val_3 = System.Activator.CreateInstance(type:  AlternativeAttackFactory.世丂上丌丞且丁七丏.Item[val_6]);
            if(val_3 == null)
        {
                return (一上不上一丅专专丐)val_9;
        }
        
            var val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (一上不上一丅专专丐.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            return (一上不上一丅专专丐)val_9;
        }
        
        val_6 = System.String.Format(format:  "TypeAlternativeAttack {0} does\'t have implementation!", arg0:  val_6);
        UnityEngine.Debug.LogError(message:  val_6);
        val_9 = 0;
        return (一上不上一丅专专丐)val_9;
    }
    public AlternativeAttackFactory()
    {
    
    }
    private static AlternativeAttackFactory()
    {
        System.Collections.Generic.Dictionary<三丛丏丒不专丈万业, System.Type> val_1 = new System.Collections.Generic.Dictionary<三丛丏丒不专丈万业, System.Type>();
        val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        AlternativeAttackFactory.世丂上丌丞且丁七丏 = val_1;
    }

}
