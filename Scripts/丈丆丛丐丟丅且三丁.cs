using UnityEngine;
private sealed class SkinName.丈丆丛丐丟丅且三丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SkinName 丝且与丝丒丟万丁专;
    public bool 七丅丅世丆丆丗丟丐;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkinName.丈丆丛丐丟丅且三丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_19;
        var val_20;
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_21;
        var val_22;
        UnityEngine.Object val_23;
        int val_24;
        var val_25;
        UnityEngine.Transform[] val_26;
        var val_27;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = null;
        val_20 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
            goto label_5;
        }
        
        val_21 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  "Boots/BootPrefab", 不丌丞专丈丙丛东丏:  false);
        val_22 = val_19;
        this.丅丒丑丄丞丑下丈丕 = val_21;
        if(val_21 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        val_22 = val_19;
        val_21 = this.丅丒丑丄丞丑下丈丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_21 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(val_21.下丑万三且丟丒丌丕() == false)
        {
            goto label_11;
        }
        
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_19 = this.丅丒丑丄丞丑下丈丕;
        UnityEngine.Object val_3 = val_19.丂丑且与丐七丟丝下();
        if(val_3 == null)
        {
            goto label_13;
        }
        
        val_19 = (null == null) ? (val_3) : 0;
        goto label_14;
        label_2:
        val_24 = 0;
        return (bool)val_24;
        label_11:
        val_24 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_13:
        val_23 = 0;
        label_14:
        val_25 = 1152921504848912384;
        if(val_23 == 0)
        {
            goto label_19;
        }
        
        val_25 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_23);
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_23);
        val_25.transform.SetParent(parent:  this.丝且与丝丒丟万丁专.LeftBootPoint.transform, worldPositionStays:  false);
        val_6.transform.SetParent(parent:  this.丝且与丝丒丟万丁专.RightBootPoint.transform, worldPositionStays:  false);
        val_25.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        string val_12 = 七丌丞万七万丁丐丙.与不丏一丐专丑丆下(丝丘丛业丁上丕丏丅:  this.丝且与丝丒丟万丁专.丗丝丅丅丂七东丞专);
        val_25.GetComponent<BootsMaterial>().SetBootsMaterial(丟东丕丗丑丏丐丟丅:  val_12);
        val_6.GetComponent<BootsMaterial>().SetBootsMaterial(丟东丕丗丑丏丐丟丅:  val_12);
        if(this.七丅丅世丆丆丗丟丐 != false)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  val_25.transform, 丈七与世丏丕业世丙:  false);
            Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  val_6.transform, 丈七与世丏丕业世丙:  false);
        }
        
        val_19 = this.丝且与丝丒丟万丁专.playerMoveC;
        val_26 = this.丝且与丝丒丟万丁专.playerMoveC.playerLegsRenderer.bones;
        val_27 = 0;
        goto label_42;
        label_19:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_43;
        }
        
        val_19 = this.丝且与丝丒丟万丁专.playerMoveC;
        if(this.丝且与丝丒丟万丁专.playerMoveC != null)
        {
            goto label_48;
        }
        
        label_49:
        label_48:
        val_27 = 1;
        val_26 = this.丝且与丝丒丟万丁专.playerMoveC.playerLegsRenderer.bones;
        label_42:
        val_19.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  true, 丑丅世丏与丁丝丒丏:  val_26);
        this.丅丒丑丄丞丑下丈丕 = 0;
        label_5:
        val_24 = 0;
        this.丝且与丝丒丟万丁专.丟丗丛丝不世下东丅 = 0;
        return (bool)val_24;
        label_43:
        if(36 != 0)
        {
            goto label_48;
        }
        
        goto label_49;
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
