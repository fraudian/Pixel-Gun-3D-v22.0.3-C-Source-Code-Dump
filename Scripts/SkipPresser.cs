using UnityEngine;
public sealed class SkipPresser : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject windowAnchor;
    private static System.Action 丛丒丑丏东丌七且丗;
    
    // Methods
    internal static void 丗丆丂七丄丅东与专(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SkipPresser.丛丒丑丏东丌七且丗, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丛上丅丛丂丞丐丈丏(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SkipPresser.丛丒丑丏东丌七且丗, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void Start()
    {
        this.gameObject.SetActive(value:  false);
    }
    public SkipPresser()
    {
    
    }

}
