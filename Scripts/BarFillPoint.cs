using UnityEngine;
internal sealed class BarFillPoint : PGBehaviour
{
    // Fields
    public UISprite filledSprite;
    public UILabel label;
    private UnityEngine.Coroutine 下丈丞丆丅丁与丂专;
    
    // Properties
    public UnityEngine.Vector3 丕不东业专丞丑丝业 { get; }
    public UnityEngine.Vector3 东丂丏丑丐一丐丅丞 { get; }
    
    // Methods
    public UnityEngine.Vector3 get_StartPoint()
    {
        UnityEngine.Vector3[] val_1 = this.filledSprite.worldCorners;
        return new UnityEngine.Vector3() {x = val_1[0], y = val_1[0], z = val_1[1]};
    }
    public UnityEngine.Vector3 get_EndPoint()
    {
        UnityEngine.Vector3[] val_1 = this.filledSprite.worldCorners;
        return new UnityEngine.Vector3() {x = val_1[4], y = val_1[5], z = val_1[5]};
    }
    private void OnEnable()
    {
        if(this.下丈丞丆丅丁与丂专 != null)
        {
                this.StopCoroutine(routine:  this.下丈丞丆丅丁与丂专);
        }
        
        this.下丈丞丆丅丁与丂专 = this.StartCoroutine(routine:  this.丈丕丑丐世丒下丒上());
    }
    private System.Collections.IEnumerator 丈丕丑丐世丒下丒上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BarFillPoint.丕丕丅丈丙世东丄上();
    }
    internal void 丁丏下东七丙丏丗丘(float 丙业与丙丗丝不丈东)
    {
        if(this.filledSprite == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.StartPoint;
        UnityEngine.Vector3 val_4 = this.EndPoint;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  丙业与丙丗丝不丈东);
        this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public BarFillPoint()
    {
    
    }

}
