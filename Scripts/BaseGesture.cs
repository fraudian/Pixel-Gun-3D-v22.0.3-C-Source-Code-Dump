using UnityEngine;
internal class BaseGesture : PGBehaviour
{
    // Fields
    private System.Action 丈三下丛丞丝世不丏;
    private System.Action 丄丆丙业世丏与丞丛;
    public UIRect uiRect;
    protected System.Collections.Generic.List<int> 三丛且丘丈七上丌一;
    protected bool 东丕丘丝丕不丕且丞;
    private bool 下丕丈丆丝丆丌丂与;
    
    // Properties
    public virtual bool 丗上且与丐丛丙丞不 { get; }
    
    // Methods
    public void add_onStart(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈三下丛丞丝世不丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921536902898200);
    
    }
    public void remove_onStart(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈三下丛丞丝世不丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921536903034776);
    
    }
    public void add_onEnd(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丆丙业世丏与丞丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921536903171360);
    
    }
    public void remove_onEnd(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丆丙业世丏与丞丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921536903307936);
    
    }
    public virtual bool get_Occurring()
    {
        return (bool)this.东丕丘丝丕不丕且丞;
    }
    protected virtual void OnEnable()
    {
        Rilisoft.Singleton<TouchManager>.Instance.add_onTouchBegan(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void BaseGesture::三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)));
        Rilisoft.Singleton<TouchManager>.Instance.add_onTouchEndedOrCanceled(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void BaseGesture::与三上万丒丈业与一(UnityEngine.Touch 丟下丙丆不东一与丅)));
    }
    protected virtual void OnDisable()
    {
        Rilisoft.Singleton<TouchManager>.Instance.remove_onTouchBegan(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void BaseGesture::三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)));
        Rilisoft.Singleton<TouchManager>.Instance.remove_onTouchEndedOrCanceled(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void BaseGesture::与三上万丒丈业与一(UnityEngine.Touch 丟下丙丆不东一与丅)));
        goto typeof(BaseGesture).__il2cppRuntimeField_1E8;
    }
    private void 三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        if((专且丝丄丙丗丈不丞.丆丁万上丗三丑丐东(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2()}, 丁丄七万不专丅丗丝:  this.uiRect = this.uiRect)) == false)
        {
                return;
        }
        
        this.三丛且丘丈七上丌一.Add(item:  丟下丙丆不东一与丅.m_FingerId.GetHashCode());
    }
    private void 与三上万丒丈业与一(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        if((this.三丛且丘丈七上丌一.Contains(item:  丟下丙丆不东一与丅.m_FingerId.GetHashCode())) == false)
        {
                return;
        }
        
        bool val_4 = this.三丛且丘丈七上丌一.Remove(item:  丟下丙丆不东一与丅.m_FingerId.GetHashCode());
    }
    protected virtual void 上丏丝下丅业丑且世(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.下丕丈丆丝丆丌丂与 = true;
    }
    protected virtual void 丝丞丙三三丗万丛丁(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.下丕丈丆丝丆丌丂与 = true;
    }
    protected virtual void 丙丌下上三万一丁上()
    {
        this.东丕丘丝丕不丕且丞 = true;
        if(this.丈三下丛丞丝世不丏 == null)
        {
                return;
        }
        
        this.丈三下丛丞丝世不丏.Invoke();
    }
    protected virtual void 不与与丌丗丞丒专业()
    {
        this.东丕丘丝丕不丕且丞 = false;
        if(this.丄丆丙业世丏与丞丛 == null)
        {
                return;
        }
        
        this.丄丆丙业世丏与丞丛.Invoke();
    }
    public System.Nullable<UnityEngine.Touch> GetTouch(int 丞世不丒下上上丝丑)
    {
        var val_10;
        var val_11;
        val_10 = this;
        if(this.三丛且丘丈七上丌一.Count > 丞世不丒下上上丝丑)
        {
                if((Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.ContainsKey(key:  this.三丛且丘丈七上丌一.Item[丞世不丒下上上丝丑])) != false)
        {
                val_10 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches;
            UnityEngine.Touch val_9 = val_10.Item[this.三丛且丘丈七上丌一.Item[丞世不丒下上上丝丑]];
            val_11 = X8;
            return (System.Nullable<UnityEngine.Touch>)val_11;
        }
        
        }
        
        val_11 = X8;
        return (System.Nullable<UnityEngine.Touch>)val_11;
    }
    protected virtual void 丄与丅下丙丟专丅东()
    {
    
    }
    public virtual void CancelGesture()
    {
        this.三丛且丘丈七上丌一.Clear();
        goto typeof(BaseGesture).__il2cppRuntimeField_1C8;
    }
    protected virtual void LateUpdate()
    {
        if(this.下丕丈丆丝丆丌丂与 != false)
        {
                this.下丕丈丆丝丆丌丂与 = false;
        }
    
    }
    protected virtual void OnApplicationPause(bool 丆丕与三丝丙丑丛三)
    {
        goto typeof(BaseGesture).__il2cppRuntimeField_1E8;
    }
    protected virtual void OnApplicationFocus(bool 不丕东丏不七丘上丂)
    {
        goto typeof(BaseGesture).__il2cppRuntimeField_1E8;
    }
    public BaseGesture()
    {
        this.三丛且丘丈七上丌一 = new System.Collections.Generic.List<System.Int32>();
    }

}
