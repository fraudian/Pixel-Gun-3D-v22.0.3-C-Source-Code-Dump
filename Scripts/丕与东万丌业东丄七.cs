using UnityEngine;
private sealed class PlayerBotMovement.丕与东万丌业东丄七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅;
    public PlayerBotMovement 丝且与丝丒丟万丁专;
    private UnityEngine.Vector3 丟丘丐一下丗丑丘且;
    private UnityEngine.Vector3 丘上三丈丏丑丙丘丄;
    private float 丞与上丅丗丏丙丆世;
    private float 与丏丆丝不业下丛丏;
    private float 万下七且与丑丛丁丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerBotMovement.丕与东万丌业东丄七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_4;
        float val_37;
        float val_38;
        float val_39;
        float val_40;
        PlayerBotController val_41;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.AI.OffMeshLinkData val_1 = this.七丘东丞世丆丕丙丅.currentOffMeshLinkData;
        UnityEngine.Vector3 val_6 = this.丝且与丝丒丟万丁专.transform.position;
        this.丟丘丐一下丗丑丘且 = val_6;
        mem[1152921538687260772] = val_6.y;
        mem[1152921538687260776] = val_6.z;
        UnityEngine.Vector3 val_7 = val_4.velocity;
        float val_40 = val_7.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.七丘东丞世丆丕丙丅.baseOffset);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_40}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_37 = this;
        this.丞与上丅丗丏丙丆世 = 0f;
        mem[1152921538687260780] = val_11.x;
        mem[1152921538687260784] = val_11.y;
        mem[1152921538687260788] = val_11.z;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.z);
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  this.丟丘丐一下丗丑丘且, y:  mem[1152921538687260776]);
        float val_14 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        float val_36 = System.Math.Abs(val_14);
        if(val_4 == 0)
        {
            goto label_15;
        }
        
        if(val_4.area > 8)
        {
            goto label_17;
        }
        
        var val_37 = 106021376 + (val_16) << 2;
        val_37 = val_37 + 106021376;
        goto (106021376 + (val_16) << 2 + 106021376);
        label_15:
        if(val_4 == 0)
        {
            goto label_18;
        }
        
        val_38 = 2f;
        goto label_31;
        label_1:
        val_37 = this.丞与上丅丗丏丙丆世;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_63;
        label_18:
        if(val_40 >= 0)
        {
            goto label_21;
        }
        
        if(val_36 > 6f)
        {
            goto label_22;
        }
        
        var val_18 = ((System.Math.Abs(val_40 - val_8.x)) > 4f) ? 2f : 1f;
        goto label_31;
        label_21:
        if(val_36 <= 6f)
        {
            goto label_26;
        }
        
        label_22:
        val_38 = val_36;
        if(val_36 <= 15f)
        {
            goto label_31;
        }
        
        val_39 = 0.5f;
        goto label_28;
        label_17:
        val_38 = 1f;
        goto label_31;
        label_28:
        val_38 = val_36 * ;
        goto label_31;
        label_26:
        float val_20 = ((System.Math.Abs(val_40 - val_8.x)) > 4f) ? (val_36) : 1f;
        label_31:
        this.与丏丆丝不业下丛丏 = val_20;
        float val_41 = 4f;
        val_40 = val_20 * val_41;
        val_20 = val_40 * val_40;
        float val_21 = val_14 * val_14;
        val_20 = val_21 + val_20;
        if(val_14 >= _TYPE_MAX_)
        {
                val_40 = val_20;
        }
        
        val_20 = val_40 + val_40;
        val_20 = val_20 / val_36;
        val_41 = val_21 / val_40;
        val_20 = val_41 * val_20;
        val_40 = val_40 + val_20;
        float val_22 = this.七丘东丞世丆丕丙丅.speed;
        val_22 = val_22 + val_22;
        float val_42 = 0.5f;
        val_22 = val_40 / val_22;
        val_42 = val_22 * val_42;
        val_22 = (val_36 > 6f) ? (val_42) : (val_22);
        this.万下七且与丑丛丁丏 = val_22;
        val_41 = this.丝且与丝丒丟万丁专.playerBotController;
        if(val_41 != 0)
        {
                val_41 = this.丝且与丝丒丟万丁专.playerBotController.player;
            if(val_41 != 0)
        {
                val_41 = this.丝且与丝丒丟万丁专.playerBotController.player.丕丁丘丆万丄世专丛;
            if(val_41 != 0)
        {
                val_41 = this.丝且与丝丒丟万丁专.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName;
            if(val_41 != 0)
        {
                val_41 = this.丝且与丝丒丟万丁专.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation;
            if(val_41 != 0)
        {
                val_41 = this.丝且与丝丒丟万丁专.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation;
            val_41.丌业丈丏东上丕丟世();
        }
        
        }
        
        }
        
        }
        
        }
        
        label_63:
        if(this.丞与上丅丗丏丙丆世 >= 0)
        {
                return false;
        }
        
        val_41 = this.丝且与丝丒丟万丁专.playerBotController.player;
        if(this.丝且与丝丒丟万丁专.playerBotController.player.万丝一万丐且丌业丛 != false)
        {
                return false;
        }
        
        float val_43 = this.与丏丆丝不业下丛丏;
        float val_44 = this.丞与上丅丗丏丙丆世;
        val_43 = val_43 * 4f;
        val_44 = val_44 - (val_44 * val_44);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丟丘丐一下丗丑丘且, y = val_40, z = V15.16B}, b:  new UnityEngine.Vector3() {x = this.丘上三丈丏丑丙丘丄, y = val_8.z, z = val_21}, t:  this.丞与上丅丗丏丙丆世);
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(d:  val_43 * val_44, a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        this.丝且与丝丒丟万丁专.transform.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        float val_35 = UnityEngine.Time.deltaTime;
        val_35 = val_35 / this.万下七且与丑丛丁丏;
        val_35 = this.丞与上丅丗丏丙丆世 + val_35;
        this.丞与上丅丗丏丙丆世 = val_35;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
