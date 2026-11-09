using UnityEngine;
public class ChooseBoxItemOnClick : MonoBehaviour
{
    // Methods
    internal void OnClick()
    {
        string val_12;
        var val_13;
        var val_14;
        val_12 = this;
        val_13 = null;
        val_13 = null;
        if((this.gameObject.name.Contains(value:  (ChooseBoxNGUIController.__il2cppRuntimeField_generic_class + 1).ToString())) != false)
        {
                val_14 = null;
            val_14 = null;
            val_12 = this.gameObject.name;
            0.StartNameBox(业不万不丞丞不丄业:  val_12);
            return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        MyCenterOnChild val_9 = this.transform.parent.GetComponent<MyCenterOnChild>();
        if(val_9 == 0)
        {
                return;
        }
        
        val_12 = this.transform;
        val_9.CenterOn(丞下万上三丘上与专:  val_12);
    }
    public ChooseBoxItemOnClick()
    {
    
    }

}
