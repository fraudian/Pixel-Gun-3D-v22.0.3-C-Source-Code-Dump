using UnityEngine;
public class ScopeViewGameEventGuiItem : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform 专丘专丏世丝丞丆七;
    private UIWidget 与东七丏丆世丟丁丌;
    private UIWidget[] coloredSprites;
    public 业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 eventType;
    private UnityEngine.GameObject[] freezeRotationObjects;
    
    // Properties
    private UIWidget 世丌丌丙丞丟下东丞 { get; }
    
    // Methods
    private UIWidget 一丗丝丄丛丌不下与()
    {
        UIWidget val_3;
        if(this.与东七丏丆世丟丁丌 == 0)
        {
                this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
            return val_3;
        }
        
        val_3 = this.与东七丏丆世丟丁丌;
        return val_3;
    }
    public void SetColor(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.coloredSprites == null)
        {
                return;
        }
        
        if(this.coloredSprites.Length < 1)
        {
                return;
        }
        
        do
        {
            this.coloredSprites[0].color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        }
        while((0 + 1) < this.coloredSprites.Length);
    
    }
    public void SetAlpha(float 与专丌丅丙上丌一丄)
    {
        float val_2 = UnityEngine.Mathf.Clamp(value:  与专丌丅丙上丌一丄, min:  0.01f, max:  1f);
        if(this.一丗丝丄丛丌不下与() == null)
        {
            
        }
    
    }
    public void SetRotation(float 一不丅与丟丌丏丟东)
    {
        UnityEngine.GameObject val_6;
        float val_7;
        float val_8;
        val_6 = this;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  一不丅与丟丌丏丟东);
        val_7 = val_2.x;
        val_8 = val_2.z;
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_7, y = val_2.y, z = val_8, w = val_2.w};
        if(this.freezeRotationObjects == null)
        {
                return;
        }
        
        if(this.freezeRotationObjects.Length < 1)
        {
                return;
        }
        
        do
        {
            val_6 = this.freezeRotationObjects[0];
            if(val_6 != 0)
        {
                val_6 = val_6.transform;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            val_7 = val_5.x;
            val_8 = val_5.z;
            val_6.rotation = new UnityEngine.Quaternion() {x = val_7, y = val_5.y, z = val_8, w = val_5.w};
        }
        
        }
        while((0 + 1) < this.freezeRotationObjects.Length);
    
    }
    public void SetTarget(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.专丘专丏世丝丞丆七 = 丞下万上三丘上与专;
    }
    public ScopeViewGameEventGuiItem()
    {
    
    }

}
