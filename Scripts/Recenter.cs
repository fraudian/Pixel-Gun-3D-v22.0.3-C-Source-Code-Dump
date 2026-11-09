using UnityEngine;
public class Recenter : MonoBehaviour
{
    // Fields
    public UICenterOnChild centerOnChildScript;
    public int nextChild;
    public int prevChild;
    
    // Methods
    public void CenterOn(int 不七丘丘丒万七丄丒)
    {
        int val_8 = 不七丘丘丒万七丄丒;
        val_8 = this.centerOnChildScript.centeredObject.transform.GetSiblingIndex() + val_8;
        if((val_8 & 2147483648) != 0)
        {
                return;
        }
        
        if(val_8 >= this.centerOnChildScript.transform.childCount)
        {
                return;
        }
        
        this.centerOnChildScript.CenterOn(丞下万上三丘上与专:  this.centerOnChildScript.transform.GetChild(index:  val_8));
    }
    public Recenter()
    {
        this.nextChild = -4294967295;
        this.prevChild = -1;
    }

}
