using UnityEngine;
internal sealed class FortFieldTurretInfoUI : PGBehaviour
{
    // Fields
    private UILabel forceLabel;
    private UILabel energyLabel;
    private UnityEngine.Transform shadowingTransform;
    private UISprite centerSprite;
    private float centerAlpha;
    private UISprite outlineSprite;
    
    // Methods
    private void LateUpdate()
    {
        if(this.shadowingTransform == 0)
        {
                return;
        }
        
        this.上丅丕丅丟丕丏丁丆();
    }
    internal void 丄丅一万丐七三丘世(int 七丆丟丗世丟且丒丆, int 东丝丅专丝丈一丘下)
    {
        this.forceLabel.text = 七丆丟丗世丟且丒丆.ToString();
        this.energyLabel.text = 东丝丅专丝丈一丘下.ToString();
    }
    internal void 丗世七丕东且业业万(ItemRarity 丈下丑丆上丏丗丈专)
    {
        UnityEngine.Color val_1 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  丈下丑丆上丏丗丈专);
        this.centerSprite.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = this.centerAlpha};
        this.outlineSprite.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    internal void 丆七丕不与丟丟一丘(UnityEngine.Transform 丝丐丐三丅丒且丐丗)
    {
        this.shadowingTransform = 丝丐丐三丅丒且丐丗;
    }
    private void 上丅丕丅丟丕丏丁丆()
    {
        万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.丌丟丄业且三丛丕丄(), 丞下万上三丘上与专:  this.shadowingTransform);
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().localPosition;
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().localPosition;
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public FortFieldTurretInfoUI()
    {
    
    }

}
