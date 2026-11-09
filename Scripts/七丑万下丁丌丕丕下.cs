using UnityEngine;
public class 七丑万下丁丌丕丕下
{
    // Fields
    private PhotonTransformViewScaleModel 丆丘不丛丁丅丙丙东;
    private UnityEngine.Vector3 且丟与丈与丞丕上丙;
    
    // Methods
    public 七丑万下丁丌丕丕下(PhotonTransformViewScaleModel 丟丞丄万丂丗丟丆七)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.且丟与丈与丞丕上丙 = val_1;
        mem[1152921535605264492] = val_1.y;
        mem[1152921535605264496] = val_1.z;
        this.丆丘不丛丁丅丙丙东 = 丟丞丄万丂丗丟丆七;
    }
    public UnityEngine.Vector3 丄丏万丌世与丈丄丗()
    {
        return new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙};
    }
    public UnityEngine.Vector3 丛丝业丂丒丙丛丆丙(UnityEngine.Vector3 丞丝丕丄与下七世业)
    {
        float val_8;
        if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 1)
        {
                if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 2)
        {
                return new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙, y = 丞丝丕丄与下七世业.y, z = 丞丝丕丄与下七世业.z};
        }
        
            val_8 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 丞丝丕丄与下七世业.x, y = 丞丝丕丄与下七世业.y, z = 丞丝丕丄与下七世业.z}, b:  new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙, y = V12.16B, z = V13.16B}, t:  this.丆丘不丛丁丅丙丙东.InterpolateLerpSpeed * val_8);
            return new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙, y = 丞丝丕丄与下七世业.y, z = 丞丝丕丄与下七世业.z};
        }
        
        val_8 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = 丞丝丕丄与下七世业.x, y = 丞丝丕丄与下七世业.y, z = 丞丝丕丄与下七世业.z}, target:  new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙, y = V12.16B, z = V13.16B}, maxDistanceDelta:  this.丆丘不丛丁丅丙丙东.InterpolateMoveTowardsSpeed * val_8);
        return new UnityEngine.Vector3() {x = this.且丟与丈与丞丕上丙, y = 丞丝丕丄与下七世业.y, z = 丞丝丕丄与下七世业.z};
    }
    public void 丁万丂丝丘业丈丛丘(UnityEngine.Vector3 丞丝丕丄与下七世业, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(this.丆丘不丛丁丅丙丙东.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丞丝丕丄与下七世业);
            this.且丟与丈与丞丕上丙 = 丞丝丕丄与下七世业;
            mem[1152921535605667020] = 丞丝丕丄与下七世业.y;
            mem[1152921535605667024] = 丞丝丕丄与下七世业.z;
            return;
        }
        
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.且丟与丈与丞丕上丙 = new UnityEngine.Vector3();
        mem[1152921535605667024] = ???;
    }

}
