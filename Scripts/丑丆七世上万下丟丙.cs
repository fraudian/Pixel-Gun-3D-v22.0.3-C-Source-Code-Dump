using UnityEngine;
private sealed class ComicsCampaign.丑丆七世上万下丟丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ComicsCampaign 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ComicsCampaign.丑丆七世上万下丟丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        bool val_23;
        IntPtr val_24;
        IntPtr val_25;
        int val_26;
        var val_27;
        object val_28;
        var val_29;
        System.String[] val_30;
        var val_31;
        var val_32;
        var val_33;
        string val_34;
        var val_35;
        int val_36;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_22 = null;
        val_22 = null;
        bool val_4 = UnityEngine.Object.op_Inequality(x:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  ComicsCampaign.东丂丌丑丁七与丝一(丙丐一丕丗万丁下一:  this.丝且与丝丒丟万丁专.东丘且丂下丟一七丕 + 1, 丗业丞丐丙三丆丘丟:  LevelArt.丗业丞丐丙三丆丘丟)), y:  0);
        this.丝且与丝丒丟万丁专.丌七丘丞丐丘且丄七 = val_4;
        this.丝且与丝丒丟万丁专.丄丄万丞不丝且丄丛 = 0;
        if(this.丝且与丝丒丟万丁专.七丛丙丏丗丏丁东丌 == false)
        {
            goto label_8;
        }
        
        this.丝且与丝丒丟万丁专.业东丞丑丟丞丏丐丙(丞丂丛七与丟丈专丙:  0);
        this.丝且与丝丒丟万丁专.backButton.gameObject.SetActive(value:  false);
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = this.丝且与丝丒丟万丁专.丌七丘丞丐丘且丄七;
        if(val_23 == false)
        {
            goto label_13;
        }
        
        val_24 = 1152921536960831472;
        goto label_14;
        label_8:
        if(val_4 == false)
        {
            goto label_15;
        }
        
        val_25 = 1152921536960831472;
        goto label_16;
        label_13:
        val_24 = 1152921536958967664;
        label_14:
        new System.Action() = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  val_24);
        this.丝且与丝丒丟万丁专.业东丞丑丟丞丏丐丙(丞丂丛七与丟丈专丙:  new System.Action());
        label_2:
        val_26 = 0;
        return (bool)val_26;
        label_15:
        val_25 = 1152921536958967664;
        label_16:
        new System.Action() = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  val_25);
        this.丝且与丝丒丟万丁专.业东丞丑丟丞丏丐丙(丞丂丛七与丟丈专丙:  new System.Action());
        label_11:
        val_23 = this.丝且与丝丒丟万丁专.background;
        if(val_23 != 0)
        {
                val_23 = this.丝且与丝丒丟万丁专.background;
            val_27 = null;
            val_27 = null;
            val_23.texture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Arts_background_" + 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
        }
        
        if(this.丝且与丝丒丟万丁专.东丘且丂下丟一七丕 == 0)
        {
            goto label_64;
        }
        
        val_28 = 0;
        label_63:
        val_29 = null;
        val_29 = null;
        val_23 = val_28 + 1;
        string val_12 = ComicsCampaign.东丂丌丑丁七与丝一(丙丐一丕丗万丁下一:  val_23, 丗业丞丐丙三丆丘丟:  LevelArt.丗业丞丐丙三丆丘丟);
        val_30 = val_12;
        UnityEngine.Texture val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_12);
        if(val_13 == 0)
        {
            goto label_29;
        }
        
        this.丝且与丝丒丟万丁专.comicFrames[0].rectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  (float)val_13);
        this.丝且与丝丒丟万丁专.comicFrames[0].rectTransform.SetSizeWithCurrentAnchors(axis:  1, size:  (float)val_13);
        this.丝且与丝丒丟万丁专.comicFrames[0].texture = val_13;
        this.丝且与丝丒丟万丁专.comicFrames[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_31 = null;
        val_31 = null;
        val_32 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                val_33 = null;
            val_34 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        }
        else
        {
                val_35 = null;
            val_34 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万;
        }
        
        val_30 = this.丝且与丝丒丟万丁专.丄专世一丘丑不丈东;
        val_36 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "{0}_{1}", arg0:  val_34, arg1:  val_28));
        if(val_36 == null)
        {
            goto label_55;
        }
        
        if(val_30 == null)
        {
            goto label_56;
        }
        
        label_59:
        if(val_36 != null)
        {
            goto label_57;
        }
        
        goto label_61;
        label_55:
        val_36 = System.String.alignConst;
        if(val_30 != null)
        {
            goto label_59;
        }
        
        label_56:
        if(val_36 == 0)
        {
            goto label_61;
        }
        
        label_57:
        label_61:
        val_30[0] = val_36;
        val_28 = val_23;
        if(val_23 != this.丝且与丝丒丟万丁专.东丘且丂下丟一七丕)
        {
            goto label_63;
        }
        
        goto label_64;
        label_29:
        val_23 = "Texture is null: "("Texture is null: ") + val_30;
        UnityEngine.Debug.LogWarning(message:  val_23);
        label_64:
        UnityEngine.Coroutine val_21 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丕丁丒与世不丕丁三(丞丂丛七与丟丈专丙:  0));
        this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 = val_21;
        this.丒上七丌业七丟与丐 = val_21;
        val_26 = 1;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
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
