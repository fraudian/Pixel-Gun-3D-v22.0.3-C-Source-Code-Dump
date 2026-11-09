using UnityEngine;
internal sealed class 丑业丗三丘丟丑上丈
{
    // Fields
    private 丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三;
    
    // Methods
    private void 丄丑七丘丁且丞丙专(丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 丙业与丙丗丝不丈东)
    {
        this.丟丄丈上丌东丑丝三 = 丙业与丙丗丝不丈东;
        FirstPersonControlSharp.世万丈一丅上下丂与(丟丄丈上丌东丑丝三:  丙业与丙丗丝不丈东);
    }
    internal void 丑专东丁丞丑东丁丟(float 一丅万丈丗丐七东上)
    {
        丙丟与丐三丐万万丆 val_1;
        if(一丅万丈丗丐七东上 <= 0f)
        {
            goto label_0;
        }
        
        if(一丅万丈丗丐七东上 <= 0.1f)
        {
            goto label_1;
        }
        
        if(一丅万丈丗丐七东上 <= 0.2f)
        {
            goto label_2;
        }
        
        if(一丅万丈丗丐七东上 <= 0.3f)
        {
            goto label_3;
        }
        
        label_0:
        val_1 = 0;
        goto label_6;
        label_1:
        val_1 = 3;
        goto label_6;
        label_2:
        val_1 = 2;
        goto label_6;
        label_3:
        val_1 = 1;
        label_6:
        if(val_1 == this.丟丄丈上丌东丑丝三)
        {
                return;
        }
        
        this.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  val_1);
    }
    internal void 上专丄丑专丑丘业丌()
    {
        FirstPersonControlSharp.且丛三丕专专丙专万(丟丄丈上丌东丑丝三:  this.丟丄丈上丌东丑丝三);
    }
    public 丑业丗三丘丟丑上丈()
    {
    
    }

}
