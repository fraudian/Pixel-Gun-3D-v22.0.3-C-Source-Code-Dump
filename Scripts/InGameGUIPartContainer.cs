using UnityEngine;
public class InGameGUIPartContainer : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<InGameGUIPartItem> items;
    
    // Methods
    internal void 丗万丙丙七丂丅世丕()
    {
        var val_2;
        var val_3;
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_39:
        if(((-845364544) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_2 > 6)
        {
            goto label_39;
        }
        
        var val_22 = 106013964 + (val_2) << 2;
        val_22 = val_22 + 106013964;
        goto (106013964 + (val_2) << 2 + 106013964);
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public static bool Load(string 丏丗丞且丙丑丐东专)
    {
        UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "InGameGUI/GameModsParts/InGameGUIPart_"("InGameGUI/GameModsParts/InGameGUIPart_") + 丏丗丞且丙丑丐东专);
        if(val_2 == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        }
        
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_2, parent:  InGameGUI.丙丞专丌丁丞与不丐.丝丙与东丈不丙三丟().transform);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_6.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        val_6.GetComponent<InGameGUIPartContainer>().丗万丙丙七丂丅世丕();
        return UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
    }
    public InGameGUIPartContainer()
    {
        this.items = new System.Collections.Generic.List<InGameGUIPartItem>();
    }

}
