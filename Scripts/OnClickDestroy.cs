using UnityEngine;
public class OnClickDestroy : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public bool DestroyByRpc;
    
    // Methods
    public void OnClick()
    {
        if(this.DestroyByRpc != false)
        {
                this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  18, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_4;
        if((丞世不丒下上上丝丑 & 255) == 18)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.DestroyRpc());
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal System.Collections.IEnumerator DestroyRpc()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new OnClickDestroy.丆丙丗丂丏丐世丁丙();
    }
    public OnClickDestroy()
    {
    
    }

}
