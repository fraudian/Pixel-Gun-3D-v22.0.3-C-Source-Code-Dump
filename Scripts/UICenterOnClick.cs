using UnityEngine;
public class UICenterOnClick : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        var val_25;
        float val_29;
        float val_30;
        UICenterOnChild val_2 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UICenterOnChild>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        UIPanel val_4 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if(val_2 != 0)
        {
                if(val_2.enabled == false)
        {
                return;
        }
        
            val_2.CenterOn(丞下万上三丘上与专:  this.transform);
            return;
        }
        
        if(val_4 == 0)
        {
                return;
        }
        
        if(val_4.clipping == 0)
        {
                return;
        }
        
        if(val_4 != null)
        {
                val_25 = val_4.GetComponent<UIScrollView>();
        }
        else
        {
                val_25 = 0.GetComponent<UIScrollView>();
        }
        
        UnityEngine.Vector3 val_14 = this.transform.position;
        UnityEngine.Vector3 val_15 = val_4.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        val_29 = val_16.x;
        val_30 = val_16.y;
        if(val_25.canMoveHorizontally != true)
        {
                UnityEngine.Vector3 val_19 = val_4.cachedTransform.localPosition;
            val_29 = val_19.x;
        }
        
        if(val_25.canMoveVertically != true)
        {
                UnityEngine.Vector3 val_22 = val_4.cachedTransform.localPosition;
            val_30 = val_22.y;
        }
        
        SpringPanel val_24 = SpringPanel.Begin(丝三丁东丈丒世丅业:  val_4.cachedGameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_16.z}, 丛上丟丌丄丗丁世与:  6f);
    }
    public UICenterOnClick()
    {
    
    }

}
