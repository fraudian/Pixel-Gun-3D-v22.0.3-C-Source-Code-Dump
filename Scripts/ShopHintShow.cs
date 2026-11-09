using UnityEngine;
public class ShopHintShow : MonoBehaviour
{
    // Fields
    public string lkey;
    public UnityEngine.GameObject oldStyleHint;
    public UnityEngine.GameObject newStyleArrow;
    private UnityEngine.Transform 一丗一七与七丄丛上;
    
    // Methods
    private void OnEnable()
    {
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                if(this.oldStyleHint != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.oldStyleHint, 丏业丟一东丂东丘丛:  false);
        }
        
            if(this.newStyleArrow != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newStyleArrow, 丏业丟一东丂东丘丛:  true);
        }
        
            if(this.一丗一七与七丄丛上 != 0)
        {
                return;
        }
        
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.lkey)) == true)
        {
                return;
        }
        
            UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "NguiWindows/Hints"));
            this.一丗一七与七丄丛上 = val_7;
            val_7.parent = this.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.一丗一七与七丄丛上.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            this.一丗一七与七丄丛上.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            this.一丗一七与七丄丛上.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.一丗一七与七丄丛上.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer);
            this.一丗一七与七丄丛上.GetChild(index:  1).GetComponent<TrainingHintSmall>().gameObject.SetActive(value:  true);
            val_16.hintLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.lkey);
            return;
        }
        
        if(this.oldStyleHint != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.oldStyleHint, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.newStyleArrow == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newStyleArrow, 丏业丟一东丂东丘丛:  false);
    }
    public ShopHintShow()
    {
    
    }

}
