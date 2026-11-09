using UnityEngine;
internal sealed class HoldPositionsPlayerDetector : PlayerDetector
{
    // Fields
    private HoldPositionsPoint myPoint;
    
    // Methods
    private void Awake()
    {
        this.myPoint = this.GetComponentInParent<HoldPositionsPoint>();
    }
    protected override void 三丑下丆丂丅丟丄丐()
    {
        if(this.myPoint.isLocked != false)
        {
                return;
        }
        
        this.三丑下丆丂丅丟丄丐();
    }
    private void Start()
    {
        this.丅丁丏丆丛世丂丙三();
    }
    private void 丅丁丏丆丛世丂丙三()
    {
        HoldPositionsPointVisual val_1 = this.GetComponentInChildren<HoldPositionsPointVisual>();
        if(val_1 == null)
        {
                return;
        }
        
        val_1.丅业上东丆丛世万丄(丙业与丙丗丝不丈东:  null);
    }
    private void OnValidate()
    {
        this.丅丁丏丆丛世丂丙三();
    }
    public HoldPositionsPlayerDetector()
    {
    
    }

}
