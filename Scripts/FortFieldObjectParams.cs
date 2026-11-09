using UnityEngine;
internal sealed class FortFieldObjectParams : MonoBehaviour
{
    // Fields
    internal System.Collections.Generic.List<UnityEngine.Renderer> objectRenderers;
    internal UnityEngine.Vector3 scaleInFortField;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableWhenNotFortField;
    
    // Methods
    private void Start()
    {
        var val_6;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) == false)
        {
                return;
        }
        
        val_6 = 0;
        goto label_2;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableWhenNotFortField.Item[0], 丏业丟一东丂东丘丛:  false);
        val_6 = 1;
        label_2:
        if(val_6 < this.disableWhenNotFortField.Count)
        {
            goto label_7;
        }
    
    }
    public FortFieldObjectParams()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.scaleInFortField = val_1;
        mem[1152921536494464692] = val_1.y;
        mem[1152921536494464696] = val_1.z;
        this.disableWhenNotFortField = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
