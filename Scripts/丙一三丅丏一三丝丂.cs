using UnityEngine;
public class 丙一三丅丏一三丝丂
{
    // Fields
    private PhotonTransformViewRotationModel 丆丘不丛丁丅丙丙东;
    private UnityEngine.Quaternion 丙七七丌丆丛丂丘三;
    
    // Methods
    public 丙一三丅丏一三丝丂(PhotonTransformViewRotationModel 丟丞丄万丂丗丟丆七)
    {
        this.丆丘不丛丁丅丙丙东 = 丟丞丄万丂丗丟丆七;
    }
    public UnityEngine.Quaternion 丁丞丒万世丛专丑东()
    {
        return new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三};
    }
    public UnityEngine.Quaternion 下丞丙丄三万丛世丑(UnityEngine.Quaternion 丞丌万丈丐三丄丐业)
    {
        float val_6;
        if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 1)
        {
                if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 2)
        {
                return new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三, y = 丞丌万丈丐三丄丐业.y, z = 丞丌万丈丐三丄丐业.z, w = 丞丌万丈丐三丄丐业.w};
        }
        
            float val_1 = UnityEngine.Time.deltaTime;
            val_6 = val_1;
            val_1 = this.丆丘不丛丁丅丙丙东.InterpolateLerpSpeed * val_6;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = 丞丌万丈丐三丄丐业.x, y = 丞丌万丈丐三丄丐业.y, z = 丞丌万丈丐三丄丐业.z, w = 丞丌万丈丐三丄丐业.w}, b:  new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三, y = this.丙七七丌丆丛丂丘三, z = V15.16B, w = V14.16B}, t:  val_1);
            return new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三, y = 丞丌万丈丐三丄丐业.y, z = 丞丌万丈丐三丄丐业.z, w = 丞丌万丈丐三丄丐业.w};
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_6 = val_3;
        val_3 = this.丆丘不丛丁丅丙丙东.InterpolateRotateTowardsSpeed * val_6;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = 丞丌万丈丐三丄丐业.x, y = 丞丌万丈丐三丄丐业.y, z = 丞丌万丈丐三丄丐业.z, w = 丞丌万丈丐三丄丐业.w}, to:  new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三, y = this.丙七七丌丆丛丂丘三, z = V15.16B, w = V14.16B}, maxDegreesDelta:  val_3);
        return new UnityEngine.Quaternion() {x = this.丙七七丌丆丛丂丘三, y = 丞丌万丈丐三丄丐业.y, z = 丞丌万丈丐三丄丐业.z, w = 丞丌万丈丐三丄丐业.w};
    }
    public void 丁万丂丝丘业丈丛丘(UnityEngine.Quaternion 丞丌万丈丐三丄丐业, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(this.丆丘不丛丁丅丙丙东.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丞丌万丈丐三丄丐业);
            this.丙七七丌丆丛丂丘三 = 丞丌万丈丐三丄丐业;
            mem[1152921535605006716] = 丞丌万丈丐三丄丐业.y;
            mem[1152921535605006720] = 丞丌万丈丐三丄丐业.z;
            mem[1152921535605006724] = 丞丌万丈丐三丄丐业.w;
            return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  东业丄丅丅且世七丄.与万三丘与专丛丄七());
        this.丙七七丌丆丛丂丘三 = new UnityEngine.Quaternion();
        mem[1152921535605006716] = ???;
        mem[1152921535605006724] = ???;
    }

}
