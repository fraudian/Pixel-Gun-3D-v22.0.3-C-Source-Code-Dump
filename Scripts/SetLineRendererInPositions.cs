using UnityEngine;
internal sealed class SetLineRendererInPositions : PGBehaviour
{
    // Fields
    private UnityEngine.LineRenderer _lineRenderer;
    private float _timeLife;
    private float 丘丅丆业世丂丝丝丐;
    private MiniPoolMonoBehaviour 丒丙丑丈三丟东不丆;
    
    // Methods
    internal void 丟三丒丂丌丒丒丕丏(UnityEngine.Vector3[] 一丅万丒上万七下世)
    {
        UnityEngine.LineRenderer val_2;
        var val_3;
        val_2 = this._lineRenderer;
        if(val_2 == 0)
        {
                return;
        }
        
        val_3 = 0;
        this.丘丅丆业世丂丝丝丐 = this._timeLife;
        goto label_4;
        label_7:
        val_2 = this._lineRenderer;
        val_2.SetPositions(positions:  一丅万丒上万七下世);
        val_3 = 1;
        label_4:
        if(val_3 < 一丅万丒上万七下世.Length)
        {
            goto label_7;
        }
    
    }
    internal void 丗与丗丙丆丌丄与丅(float 丂三丟丂丈丐丆丗丟)
    {
        this._timeLife = 丂三丟丂丈丐丆丗丟;
    }
    internal void 丟上业专丈东丞丅上(MiniPoolMonoBehaviour 丝东丄不不东丐不不)
    {
        this.丒丙丑丈三丟东不丆 = 丝东丄不不东丐不不;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丘丅丆业世丂丝丝丐 - val_1;
        this.丘丅丆业世丂丝丝丐 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        if(this.丒丙丑丈三丟东不丆 == 0)
        {
                return;
        }
        
        this.丒丙丑丈三丟东不丆.Return(万且万且丑丗且丌丆:  this);
    }
    public SetLineRendererInPositions()
    {
        this._timeLife = 0.5f;
    }

}
