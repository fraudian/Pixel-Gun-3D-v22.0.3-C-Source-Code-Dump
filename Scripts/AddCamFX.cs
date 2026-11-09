using UnityEngine;
internal sealed class AddCamFX : MonoBehaviour
{
    // Methods
    private void Start()
    {
    
    }
    private UnityEngine.Component 丄世丟丒丒丐丒七丏(UnityEngine.Component 专丑业丁丗丏丌不丛, UnityEngine.GameObject 丁丆丈丂上丙丈丙万)
    {
        var val_4;
        System.Type val_1 = 专丑业丁丗丏丌不丛.GetType();
        UnityEngine.Component val_2 = 丁丆丈丂上丙丈丙万.AddComponent(componentType:  val_1);
        val_4 = 0;
        goto label_3;
        label_8:
        System.Reflection.FieldInfo val_4 = val_1.GetFields()[0];
        val_4.SetValue(obj:  val_2, value:  val_4);
        val_4 = 1;
        label_3:
        if(val_4 < val_3.Length)
        {
            goto label_8;
        }
        
        return val_2;
    }
    public AddCamFX()
    {
    
    }

}
