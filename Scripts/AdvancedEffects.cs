using UnityEngine;
internal sealed class AdvancedEffects : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal const float 丗一业丞丘丕东丄丆 = 0.5;
    public bool syncInLocal;
    public bool dontSync;
    private PhotonView 丅丏三七丁丑丞丄丏;
    private System.Collections.Generic.List<AdvancedEffects.一丒丒丘丈万丟丞不> 上上业下丝丟丙丙丟;
    private UnityEngine.GameObject 世丂世丏丅不下丈丅;
    private UnityEngine.GameObject 丆丏万丐东丕不万丌;
    
    // Methods
    private void Start()
    {
        if(this.dontSync == true)
        {
                return;
        }
        
        this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
    }
    public void SendAdvancedEffect(int 三丛丄一东丑丁且业, float 丘万丟丕与专丁三丘, int 丆丅丅丂下丏丏丞丂 = -1)
    {
        var val_3;
        Rilisoft.七丆丛上丂丏世丛丑 val_5;
        PhotonTargets val_6;
        System.Object[] val_7;
        this.丕三丐丏世世丐万丑(三丛丄一东丑丁且业:  三丛丄一东丑丁且业, 丘万丟丕与专丁三丘:  丘万丟丕与专丁三丘);
        if(this.dontSync != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(丆丅丅丂下丏丏丞丂 != 1)
        {
                object[] val_1 = new object[3];
            val_1[0] = 三丛丄一东丑丁且业;
            val_1[1] = 丘万丟丕与专丁三丘;
            val_1[2] = 丆丅丅丂下丏丏丞丂;
            val_5 = 9;
            val_6 = 1;
            val_7 = val_1;
        }
        else
        {
                object[] val_2 = new object[2];
            val_2[0] = 三丛丄一东丑丁且业;
            val_2[1] = 丘万丟丕与专丁三丘;
            val_5 = 8;
            val_6 = 1;
            val_7 = val_2;
        }
        
        this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  val_5, 丞下万上三丘上与专:  val_6, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public void SendAdvancedEffect(与丅丕丈丘东丝世丟 三丈一丑丕世万丁丙, int 三丛丄一东丑丁且业, float 丘万丟丕与专丁三丘 = 0, int 丆丅丅丂下丏丏丞丂 = -1)
    {
        var val_3;
        Rilisoft.七丆丛上丂丏世丛丑 val_5;
        与丅丕丈丘东丝世丟 val_6;
        System.Object[] val_7;
        if(this.dontSync != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(丆丅丅丂下丏丏丞丂 != 1)
        {
                object[] val_1 = new object[3];
            val_1[0] = 三丛丄一东丑丁且业;
            val_1[1] = 丘万丟丕与专丁三丘;
            val_1[2] = 丆丅丅丂下丏丏丞丂;
            val_5 = 9;
            val_6 = 三丈一丑丕世万丁丙;
            val_7 = val_1;
        }
        else
        {
                object[] val_2 = new object[2];
            val_2[0] = 三丛丄一东丑丁且业;
            val_2[1] = 丘万丟丕与专丁三丘;
            val_5 = 8;
            val_6 = 三丈一丑丕世万丁丙;
            val_7 = val_2;
        }
        
        this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  val_5, 万丌万丅专丞业丈万:  val_6, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        int val_3;
        int val_4;
        var val_5;
        val_2 = 丞世不丒下上上丝丑;
        byte val_1 = val_2 & 255;
        if(val_1 == 9)
        {
            goto label_1;
        }
        
        if(val_1 != 8)
        {
            goto label_2;
        }
        
        val_3 = 专丒丌丆下丐丞丟丞.Length;
        if(val_3 == 0)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_3 = 专丒丌丆下丐丞丟丞[1];
        this.丕三丐丏世世丐万丑(三丛丄一东丑丁且业:  21884928, 丘万丟丕与专丁三丘:  3.782474E-38f);
        goto label_6;
        label_1:
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        if(val_4 <= 1)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_5 = 专丒丌丆下丐丞丟丞[1];
        object val_6 = 专丒丌丆下丐丞丟丞[2];
        this.不丒业丌丛一不东丂(三丛丄一东丑丁且业:  21884928, 丘万丟丕与专丁三丘:  3.782474E-38f, 丆丅丅丂下丏丏丞丂:  21884928);
        label_6:
        val_5 = 1;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
    }
    internal void 丕三丐丏世世丐万丑(int 三丛丄一东丑丁且业, float 丘万丟丕与专丁三丘)
    {
        var val_6;
        float val_6 = 丘万丟丕与专丁三丘;
        val_6 = 0;
        goto label_1;
        label_5:
        一丒丒丘丈万丟丞不 val_1 = X22.Item[0];
        if(X22 == 三丛丄一东丑丁且业)
        {
            goto label_3;
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < this.上上业下丝丟丙丙丟.Count)
        {
            goto label_5;
        }
        
        val_6 = UnityEngine.Time.time + val_6;
        this.上上业下丝丟丙丙丟.Add(item:  new 一丒丒丘丈万丟丞不() {丏不丂丆且三丞丆丏 = 三丛丄一东丑丁且业, 与与专丟丗东丌与丆 = 三丛丄一东丑丁且业, 不丟丗丏丛丕不丁丌 = 三丛丄一东丑丁且业});
        this.丘丟丕丕业上三丛东(丏不丂丆且三丞丆丏:  三丛丄一东丑丁且业);
        return;
        label_3:
        一丒丒丘丈万丟丞不 val_4 = this.上上业下丝丟丙丙丟.Item[0];
        float val_5 = UnityEngine.Time.time;
        val_5 = val_5 + val_6;
        this.上上业下丝丟丙丙丟.set_Item(index:  0, value:  new 一丒丒丘丈万丟丞不() {丏不丂丆且三丞丆丏 = this.上上业下丝丟丙丙丟, 与与专丟丗东丌与丆 = this.上上业下丝丟丙丙丟, 不丟丗丏丛丕不丁丌 = this.上上业下丝丟丙丙丟});
    }
    internal void 不丒业丌丛一不东丂(int 三丛丄一东丑丁且业, float 丘万丟丕与专丁三丘, int 丆丅丅丂下丏丏丞丂)
    {
        int val_7;
        var val_8;
        System.Collections.Generic.List<一丒丒丘丈万丟丞不> val_9;
        val_7 = 丆丅丅丂下丏丏丞丂;
        val_8 = 0;
        goto label_1;
        label_11:
        一丒丒丘丈万丟丞不 val_1 = X23.Item[0];
        if(X23 != 三丛丄一东丑丁且业)
        {
            goto label_3;
        }
        
        if(三丛丄一东丑丁且业 != 2)
        {
            goto label_9;
        }
        
        一丒丒丘丈万丟丞不 val_2 = this.上上业下丝丟丙丙丟.Item[0];
        val_9 = mem[1460288881144];
        if((val_9.viewID.Equals(obj:  val_7)) == true)
        {
            goto label_9;
        }
        
        label_3:
        val_8 = 1;
        label_1:
        val_9 = this.上上业下丝丟丙丙丟;
        if(val_8 < this.上上业下丝丟丙丙丟.Count)
        {
            goto label_11;
        }
        
        val_9.Add(item:  new 一丒丒丘丈万丟丞不());
        this.丘丟丕丕业上三丛东(丏不丂丆且三丞丆丏:  三丛丄一东丑丁且业);
        return;
        label_9:
        一丒丒丘丈万丟丞不 val_6 = this.上上业下丝丟丙丙丟.Item[0];
        val_7 = 0;
        this.上上业下丝丟丙丙丟.set_Item(index:  0, value:  new 一丒丒丘丈万丟丞不());
    }
    private float 丕丞丝丗丟丙丐丑丟()
    {
        UnityEngine.Object val_8;
        var val_9;
        val_8 = this;
        val_9 = 0f;
        if(this.transform.childCount < 1)
        {
                return (float)val_9;
        }
        
        val_8 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.BoxCollider>();
        if(val_8 == 0)
        {
                return (float)val_9;
        }
        
        UnityEngine.Vector3 val_7 = val_8.center;
        val_9 = val_7.y;
        return (float)val_9;
    }
    private void 丘丟丕丕业上三丛东(AdvancedEffects.丄丑丐丝三世三丞丅 丏不丂丆且三丞丆丏)
    {
        if(丏不丂丆且三丞丆丏 == 2)
        {
            goto label_1;
        }
        
        if(丏不丂丆且三丞丆丏 != 1)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = GetParticle();
        this.世丂世丏丅不下丈丅 = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        this.世丂世丏丅不下丈丅.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
        if(this.世丂世丏丅不下丈丅 != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.丕丞丝丗丟丙丐丑丟());
        this.世丂世丏丅不下丈丅.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        return;
        label_1:
        UnityEngine.GameObject val_9 = GetParticle();
        this.丆丏万丐东丕不万丌 = val_9;
        if(val_9 == 0)
        {
                return;
        }
        
        this.丆丏万丐东丕不万丌.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
        if(this.丆丏万丐东丕不万丌 != null)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    private void 丛三丆丏与丂丝丈业(AdvancedEffects.丄丑丐丝三世三丞丅 丏不丂丆且三丞丆丏)
    {
        UnityEngine.GameObject val_7;
        if(丏不丂丆且三丞丆丏 != 2)
        {
                if(丏不丂丆且三丞丆丏 != 1)
        {
                return;
        }
        
            if(this.世丂世丏丅不下丈丅 == 0)
        {
                return;
        }
        
            val_7 = 1152921505103437824;
            if(ParticleStacks.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
            this.世丂世丏丅不下丈丅.transform.parent = 0;
            val_7 = this.世丂世丏丅不下丈丅;
            ReturnParticle(丅丅丌丕世丙不丑丄:  val_7);
            this.世丂世丏丅不下丈丅 = 0;
            return;
        }
        
        if(this.丆丏万丐东丕不万丌 == 0)
        {
                return;
        }
        
        val_7 = 1152921505103437824;
        if(ParticleStacks.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        this.丆丏万丐东丕不万丌.transform.parent = 0;
        val_7 = this.丆丏万丐东丕不万丌;
        ReturnParticle(丅丅丌丕世丙不丑丄:  val_7);
        this.丆丏万丐东丕不万丌 = 0;
    }
    internal bool 东丑不丘丂丘丞七丁(AdvancedEffects.丄丑丐丝三世三丞丅 丏不丂丆且三丞丆丏, Player_move_c 不丟丗丏丛丕不丁丌)
    {
        object val_5;
        object val_6;
        var val_7;
        val_5 = 0;
        goto label_1;
        label_8:
        一丒丒丘丈万丟丞不 val_1 = this.上上业下丝丟丙丙丟.Item[0];
        if(this.上上业下丝丟丙丙丟 != 丏不丂丆且三丞丆丏)
        {
            goto label_3;
        }
        
        一丒丒丘丈万丟丞不 val_2 = this.上上业下丝丟丙丙丟.Item[0];
        val_6 = val_5;
        if((不丟丗丏丛丕不丁丌.Equals(other:  val_6)) == true)
        {
            goto label_6;
        }
        
        label_3:
        val_5 = 1;
        label_1:
        val_6 = this.上上业下丝丟丙丙丟;
        if(val_5 < val_6.Count)
        {
            goto label_8;
        }
        
        val_7 = 0;
        return (bool)val_7;
        label_6:
        val_7 = 1;
        return (bool)val_7;
    }
    public bool IsEffectActive(AdvancedEffects.丄丑丐丝三世三丞丅 丏不丂丆且三丞丆丏)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        label_4:
        if(val_3 >= this.上上业下丝丟丙丙丟.Count)
        {
            goto label_2;
        }
        
        一丒丒丘丈万丟丞不 val_2 = this.上上业下丝丟丙丙丟.Item[0];
        val_3 = val_3 + 1;
        if(this.上上业下丝丟丙丙丟 != 丏不丂丆且三丞丆丏)
        {
            goto label_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
    }
    private void Update()
    {
        goto label_1;
        label_8:
        一丒丒丘丈万丟丞不 val_1 = this.上上业下丝丟丙丙丟.Item[0];
        if(UnityEngine.Time.time > (this.上上业下丝丟丙丙丟 >> 32))
        {
                一丒丒丘丈万丟丞不 val_4 = this.上上业下丝丟丙丙丟.Item[0];
            this.上上业下丝丟丙丙丟.RemoveAt(index:  0);
            if((this.IsEffectActive(丏不丂丆且三丞丆丏:  this.上上业下丝丟丙丙丟)) != true)
        {
                this.丛三丆丏与丂丝丈业(丏不丂丆且三丞丆丏:  this.上上业下丝丟丙丙丟);
        }
        
        }
        
        0 = 0;
        label_1:
        if(0 < this.上上业下丝丟丙丙丟.Count)
        {
            goto label_8;
        }
    
    }
    private void OnDestroy()
    {
        goto label_1;
        label_5:
        一丒丒丘丈万丟丞不 val_1 = this.上上业下丝丟丙丙丟.Item[0];
        this.丛三丆丏与丂丝丈业(丏不丂丆且三丞丆丏:  this.上上业下丝丟丙丙丟);
        this.上上业下丝丟丙丙丟.RemoveAt(index:  0);
        label_1:
        if(this.上上业下丝丟丙丙丟.Count > 0)
        {
            goto label_5;
        }
    
    }
    public AdvancedEffects()
    {
        this.上上业下丝丟丙丙丟 = new System.Collections.Generic.List<一丒丒丘丈万丟丞不>(capacity:  3);
    }

}
