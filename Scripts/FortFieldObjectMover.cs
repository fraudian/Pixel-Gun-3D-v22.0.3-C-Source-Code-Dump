using UnityEngine;
internal sealed class FortFieldObjectMover : PGBehaviour
{
    // Fields
    public float firstX;
    public float secondX;
    public float firstY;
    public float secondY;
    
    // Methods
    private void Update()
    {
        this.东业丄丁丒与丕专丒();
    }
    private void 东业丄丁丒与丕专丒()
    {
        float val_1 = GestureCamera.ZoomValue01;
        float val_2 = UnityEngine.Mathf.Lerp(a:  this.firstX, b:  this.secondX, t:  val_1);
        float val_3 = UnityEngine.Mathf.Lerp(a:  this.firstY, b:  this.secondY, t:  val_1);
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public FortFieldObjectMover()
    {
    
    }

}
