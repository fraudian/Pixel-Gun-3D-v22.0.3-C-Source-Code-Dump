using UnityEngine;
internal sealed class FortFieldButtonMover : PGBehaviour
{
    // Fields
    private UIWidget 世丌丌丙丞丟下东丞;
    private UnityEngine.Transform shadowingTransform;
    
    // Methods
    private void Start()
    {
        this.世丌丌丙丞丟下东丞 = this.GetComponent<UIWidget>();
    }
    private void LateUpdate()
    {
        if(this.shadowingTransform == 0)
        {
                return;
        }
        
        this.上丅丕丅丟丕丏丁丆();
    }
    private void 上丅丕丅丟丕丏丁丆()
    {
        万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.丌丟丄业且三丛丕丄(), 丞下万上三丘上与专:  this.shadowingTransform);
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().localPosition;
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().localPosition;
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public FortFieldButtonMover()
    {
    
    }

}
