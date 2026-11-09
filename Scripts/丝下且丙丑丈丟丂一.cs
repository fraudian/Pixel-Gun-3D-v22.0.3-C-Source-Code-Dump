using UnityEngine;
internal abstract class 丝下且丙丑丈丟丂一
{
    // Fields
    private bool 丗丛七丈丆丘丗丘丕;
    private bool 丑专且丗七业丑上丟;
    protected System.Action 丟万丂丝七丑丞丌一;
    protected System.Action 业丁丄专丕专丙丙东;
    protected System.Action 七丗丕上世丄丗丕一;
    internal System.Action 丂一丑丛不专万丁上;
    protected bool 丐丁东且一丕且世三;
    protected System.Action<int> 且丆世丆丅丄丞不上;
    protected System.Action<string> 丐丘丘丁丁丙丐七丑;
    protected System.Action 三丞丗丛丈与七丅丘;
    protected System.Action 丅丘丛万一万丏丏世;
    protected System.Action<bool> 丆丘丁丁丙不丙丗丙;
    protected System.Action 丝丝丅下丐上丗与与;
    protected System.Action 丐专下丅丏万丛丁且;
    
    // Methods
    internal void 三丑丛丄万丟丄丞丁()
    {
        this.丝丅七丑上丟业不东();
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丄下丈丝一丘丏丟丅(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    internal void 丄上一丌专丞且丗世()
    {
        var val_6;
        var val_7;
        if(this.丐丁东且一丕且世三 == true)
        {
                return;
        }
        
        this.丑专且丗七业丑上丟 = true;
        val_6 = null;
        val_6 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        if(丅丒丗丑丒丙丛不丆.丛丗一不丈丂丒丒丂() != true)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != true)
        {
                if(this.丟万丂丝七丑丞丌一 != null)
        {
            goto label_10;
        }
        
        }
        
        }
        
        GameConnect.下与业丒丝丕丙丘丙();
        label_10:
        val_7 = 0;
        if(MatchmakingConnect.instance.InRequest != false)
        {
                val_7 = 0;
            MatchmakingConnect.instance.且丞七丕丕丕丄丆丅();
        }
        
        if(this.丂一丑丛不专万丁上 != null)
        {
                this.丂一丑丛不专万丁上.Invoke();
        }
        
        this.业丁丄专丕专丙丙东 = 0;
        this.七丗丕上世丄丗丕一 = 0;
        this.丟万丂丝七丑丞丌一 = 0;
    }
    internal void 世业丒万丘丆专丘丐()
    {
        this.与丆丈丗丄丒东丈丘();
    }
    private void 丌丈丝丞东丅丁东业()
    {
        this.业丁丄专丕专丙丙东 = 0;
        this.七丗丕上世丄丗丕一 = 0;
        this.丟万丂丝七丑丞丌一 = 0;
    }
    private System.Collections.IEnumerable 丄下丈丝一丘丏丟丅(float 丕丕世且下一与丝与)
    {
        丝下且丙丑丈丟丂一.丐丌丅世一专丟三与 val_1 = new 丝下且丙丑丈丟丂一.丐丌丅世一专丟三与();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    protected virtual void 丝丛丅专上业与丞七(bool 万且万且丑丗且丌丆)
    {
        this.与丆丈丗丄丒东丈丘();
        if(this.丆丘丁丁丙不丙丗丙 == null)
        {
                return;
        }
        
        万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
        this.丆丘丁丁丙不丙丗丙.Invoke(obj:  万且万且丑丗且丌丆);
    }
    protected virtual void 丂与丁东业上丄丛一(int 世丁丙世丄一万丆三)
    {
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. StatusCode: "("On Failed To Connect To Photon. StatusCode: ") + 世丁丙世丄一万丆三);
        if(this.丑专且丗七业丑上丟 != false)
        {
                this.与丆丈丗丄丒东丈丘();
        }
        else
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            UnityEngine.Coroutine val_5 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丄下丈丝一丘丏丟丅(丕丕世且下一与丝与:  1f).GetEnumerator());
        }
        
        this.丑专且丗七业丑上丟 = false;
        if(this.且丆世丆丅丄丞不上 == null)
        {
                return;
        }
        
        this.且丆世丆丅丄丞不上.Invoke(obj:  世丁丙世丄一万丆三);
    }
    protected virtual void 丒丁七万丌一与丞丂(string 万且万且丑丗且丌丆)
    {
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. " + 万且万且丑丗且丌丆);
        this.丑专且丗七业丑上丟 = true;
        this.与丆丈丗丄丒东丈丘();
        if(this.丐丘丘丁丁丙丐七丑 == null)
        {
                return;
        }
        
        this.丐丘丘丁丁丙丐七丑.Invoke(obj:  万且万且丑丗且丌丆);
    }
    protected virtual void 丏丛丄万下业一七专()
    {
        UnityEngine.Debug.Log(message:  "On Connected To Master");
        丅丒丗丑丒丙丛不丆.丅丗业与万且不丐丈(丙业与丙丗丝不丈东:  ProfileController.丆三丂丂丆上丆丕专());
        if(this.丟万丂丝七丑丞丌一 != null)
        {
                this.丟万丂丝七丑丞丌一.Invoke();
            this.丟万丂丝七丑丞丌一 = 0;
        }
        else
        {
                GameConnect.下与业丒丝丕丙丘丙();
        }
        
        this.丑专且丗七业丑上丟 = false;
        if(this.三丞丗丛丈与七丅丘 == null)
        {
                return;
        }
        
        this.三丞丗丛丈与七丅丘.Invoke();
    }
    protected virtual void 丂丐与丞丗丒丘丑上()
    {
        var val_4;
        UnityEngine.Debug.Log(message:  "On Disconnected From Photon");
        val_4 = null;
        val_4 = null;
        GameConnect.七七丈东丅上丝丒万 = false;
        if(this.丟万丂丝七丑丞丌一 != null)
        {
                if(this.丑专且丗七业丑上丟 == false)
        {
            goto label_6;
        }
        
        }
        
        this.丄上一丌专丞且丗世();
        goto label_7;
        label_6:
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丄下丈丝一丘丏丟丅(丕丕世且下一与丝与:  0.5f).GetEnumerator());
        label_7:
        if(this.丅丘丛万一万丏丏世 == null)
        {
                return;
        }
        
        this.丅丘丛万一万丏丏世.Invoke();
    }
    protected virtual void 且丄丈丏东丕三丐业()
    {
        this.丐丁东且一丕且世三 = true;
        this.与丆丈丗丄丒东丈丘();
        if(this.业丁丄专丕专丙丙东 != null)
        {
                this.业丁丄专丕专丙丙东.Invoke();
            this.业丁丄专丕专丙丙东 = 0;
        }
        
        if(this.丝丝丅下丐上丗与与 == null)
        {
                return;
        }
        
        this.丝丝丅下丐上丗与与.Invoke();
    }
    protected virtual void 东丏丏专丏丗丒丌丛()
    {
        this.丐丁东且一丕且世三 = true;
        if(this.七丗丕上世丄丗丕一 != null)
        {
                this.七丗丕上世丄丗丕一.Invoke();
            this.七丗丕上世丄丗丕一 = 0;
        }
        
        if(this.丐专下丅丏万丛丁且 == null)
        {
                return;
        }
        
        this.丐专下丅丏万丛丁且.Invoke();
    }
    protected virtual void 丘不丁丘万丑丈丞世()
    {
        this.与丆丈丗丄丒东丈丘();
    }
    private void 丝丅七丑上丟业不东()
    {
        var val_16;
        System.Action<System.Boolean> val_17;
        var val_18;
        丑丕与三丟且三丈丌 val_19;
        var val_20;
        System.Action<System.String> val_21;
        var val_22;
        System.Action val_23;
        var val_24;
        var val_25;
        System.Action val_26;
        var val_27;
        var val_28;
        System.Action val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        if(this.丗丛七丈丆丘丗丘丕 == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_170))) != null) && (null != null))
        {
                val_18 = null;
            val_17 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_17;
        val_20 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_180))) != null) && (null != null))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_19;
        val_22 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丒丁七万丌一与丞丂, b:  new System.Action<System.String>(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_190))) != null) && (null != null))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_21;
        val_24 = null;
        val_25 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1A0))) != null) && (null != val_25))
        {
                val_24 = null;
            val_25 = null;
            val_23 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_23;
        val_27 = null;
        val_28 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1B0))) != null) && (null != val_28))
        {
                val_27 = null;
            val_28 = null;
            val_26 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_26;
        val_30 = null;
        val_31 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1C0))) != null) && (null != val_31))
        {
                val_30 = null;
            val_31 = null;
            val_29 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_29;
        if(((System.Delegate.Combine(a:  GameConnect.一与丁丂丒丗丌世丞, b:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1D0))) != null) && (null != null))
        {
                val_32 = 0;
        }
        
        GameConnect.一与丁丂丒丗丌世丞 = val_32;
        this.丗丛七丈丆丘丗丘丕 = true;
    }
    private void 与丆丈丗丄丒东丈丘()
    {
        var val_16;
        System.Action<System.Boolean> val_17;
        var val_18;
        丑丕与三丟且三丈丌 val_19;
        var val_20;
        System.Action<System.String> val_21;
        var val_22;
        System.Action val_23;
        var val_24;
        var val_25;
        System.Action val_26;
        var val_27;
        var val_28;
        System.Action val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        val_16 = null;
        val_16 = null;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_170);
        val_18 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  null)) != null) && (null != null))
        {
                val_18 = null;
            val_17 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_17;
        val_20 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_180))) != null) && (null != null))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_19;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丒丁七万丌一与丞丂, value:  new System.Action<System.String>(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_190))) != null) && (null != null))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_21;
        val_24 = null;
        val_25 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1A0))) != null) && (null != val_25))
        {
                val_24 = null;
            val_25 = null;
            val_23 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_23;
        val_27 = null;
        val_28 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1B0))) != null) && (null != val_28))
        {
                val_27 = null;
            val_28 = null;
            val_26 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_26;
        val_30 = null;
        val_31 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1C0))) != null) && (null != val_31))
        {
                val_30 = null;
            val_31 = null;
            val_29 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_29;
        if(((System.Delegate.Remove(source:  GameConnect.一与丁丂丒丗丌世丞, value:  new System.Action(object:  this, method:  typeof(丝下且丙丑丈丟丂一).__il2cppRuntimeField_1D0))) != null) && (null != null))
        {
                val_32 = 0;
        }
        
        GameConnect.一与丁丂丒丗丌世丞 = val_32;
        this.丗丛七丈丆丘丗丘丕 = false;
    }
    protected abstract void 且丈丄丝丙世丙丗丏(); // 0
    protected abstract void 一丌丞丙丁丄丞丗一(); // 0
    protected abstract void 丆下丅丟下丂一不丙(); // 0
    protected 丝下且丙丑丈丟丂一()
    {
    
    }

}
