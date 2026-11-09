using UnityEngine;
public class TouchManager : Singleton<TouchManager>
{
    // Fields
    private System.Action<UnityEngine.Touch> 丄不丝丂业丝丅丛七;
    private System.Action<UnityEngine.Touch> 上丛丑且丈丈万丒丕;
    private System.Action<UnityEngine.Touch> 上且丘万与丂丗丁万;
    private System.Action<UnityEngine.Touch> 专业丄七丑丙丐丗丆;
    private System.Collections.Generic.Dictionary<int, UnityEngine.Touch> 丟丂丗与东下丁丒上;
    
    // Properties
    public System.Collections.Generic.Dictionary<int, UnityEngine.Touch> 不不丝不丞不三丟三 { get; }
    
    // Methods
    public void add_onTouchBegan(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄不丝丂业丝丅丛七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄不丝丂业丝丅丛七 != 1152921536921286552);
    
    }
    public void remove_onTouchBegan(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄不丝丂业丝丅丛七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄不丝丂业丝丅丛七 != 1152921536921423128);
    
    }
    public void add_onTouchEnded(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丛丑且丈丈万丒丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丛丑且丈丈万丒丕 != 1152921536921559712);
    
    }
    public void remove_onTouchEnded(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丛丑且丈丈万丒丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丛丑且丈丈万丒丕 != 1152921536921696288);
    
    }
    public void add_onTouchCanceled(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上且丘万与丂丗丁万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上且丘万与丂丗丁万 != 1152921536921832872);
    
    }
    public void remove_onTouchCanceled(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上且丘万与丂丗丁万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上且丘万与丂丗丁万 != 1152921536921969448);
    
    }
    public void add_onTouchEndedOrCanceled(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专业丄七丑丙丐丗丆, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专业丄七丑丙丐丗丆 != 1152921536922106032);
    
    }
    public void remove_onTouchEndedOrCanceled(System.Action<UnityEngine.Touch> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专业丄七丑丙丐丗丆, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专业丄七丑丙丐丗丆 != 1152921536922242608);
    
    }
    public System.Collections.Generic.Dictionary<int, UnityEngine.Touch> get_CurrentTouches()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Touch>)this.丟丂丗与东下丁丒上;
    }
    private void Update()
    {
        var val_9;
        System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Touch> val_10;
        var val_11;
        this.丟丂丗与东下丁丒上.Clear();
        UnityEngine.Touch[] val_1 = UnityEngine.Input.touches;
        val_9 = 0;
        goto label_2;
        label_6:
        var val_2 = 0 + 32;
        val_10 = this.丟丂丗与东下丁丒上;
        val_10.set_Item(key:  GetHashCode(), value:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        val_9 = 1;
        label_2:
        if(val_9 < val_1.Length)
        {
            goto label_6;
        }
        
        UnityEngine.Touch[] val_4 = UnityEngine.Input.touches;
        val_11 = 0;
        goto label_7;
        label_19:
        val_10 = 0;
        var val_5 = 0 + 32;
        if(专三三与三且一且一() == 0)
        {
                val_10 = this.丄不丝丂业丝丅丛七;
            if(val_10 != null)
        {
                val_10.Invoke(obj:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        }
        
        }
        
        if(专三三与三且一且一() == 3)
        {
                val_10 = this.上丛丑且丈丈万丒丕;
            if(val_10 != null)
        {
                val_10.Invoke(obj:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        }
        
        }
        
        if(专三三与三且一且一() == 4)
        {
                val_10 = this.上且丘万与丂丗丁万;
            if(val_10 != null)
        {
                val_10.Invoke(obj:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        }
        
        }
        
        if(专三三与三且一且一() != 3)
        {
                if(专三三与三且一且一() != 4)
        {
            goto label_17;
        }
        
        }
        
        val_10 = this.专业丄七丑丙丐丗丆;
        if(val_10 != null)
        {
                val_10.Invoke(obj:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        }
        
        label_17:
        val_11 = 1;
        label_7:
        if(val_11 < val_4.Length)
        {
            goto label_19;
        }
    
    }
    private void 专丞三丙丘丒七丂丕()
    {
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.丟丂丗与东下丁丒上.Values.GetEnumerator();
        label_5:
        if(((-2043777288) & 1) == 0)
        {
            goto label_3;
        }
        
        if(this.专业丄七丑丙丐丗丆 == null)
        {
            goto label_5;
        }
        
        this.专业丄七丑丙丐丗丆.Invoke(obj:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2()});
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丟丂丗与东下丁丒上.Clear();
    }
    private void OnApplicationPause(bool 丆丕与三丝丙丑丛三)
    {
        this.专丞三丙丘丒七丂丕();
    }
    private void OnApplicationFocus(bool 不丕东丏不七丘上丂)
    {
        this.专丞三丙丘丒七丂丕();
    }
    public TouchManager()
    {
        this.丟丂丗与东下丁丒上 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Touch>();
    }

}
