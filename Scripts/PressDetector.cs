using UnityEngine;
internal sealed class PressDetector : MonoBehaviour
{
    // Fields
    internal static System.EventHandler<System.EventArgs> 世丗一上丑上丑丄一;
    
    // Methods
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_2;
        if(PressDetector.世丗一上丑上丑丄一 == null)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PressDetector.世丗一上丑上丑丄一.Invoke(sender:  this.gameObject, e:  System.EventArgs.Empty);
    }
    public PressDetector()
    {
    
    }

}
