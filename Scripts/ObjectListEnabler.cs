using UnityEngine;
public class ObjectListEnabler : PGBehaviour
{
    // Fields
    private System.Action 丝丝万丄丏丝世三丏;
    private System.Action 万万丗丛丏丐七丘丏;
    private System.Action 七东业丅丗下一丄丘;
    public bool looped;
    public float loopDelay;
    public bool executeOnStart;
    public bool executeOnEnable;
    public System.Collections.Generic.List<ObjectListEnabler.ObjectListEntry> objectList;
    private UnityEngine.Coroutine 丕丂丛丏专业丛下丂;
    
    // Methods
    public void add_onBegin(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丝丝万丄丏丝世三丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝丝万丄丏丝世三丏 != 1152921538173472392);
    
    }
    public void remove_onBegin(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丝丝万丄丏丝世三丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝丝万丄丏丝世三丏 != 1152921538173608968);
    
    }
    public void add_onFinish(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.万万丗丛丏丐七丘丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.万万丗丛丏丐七丘丏 != 1152921538173745552);
    
    }
    public void remove_onFinish(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.万万丗丛丏丐七丘丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.万万丗丛丏丐七丘丏 != 1152921538173882128);
    
    }
    public void add_onEnable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.七东业丅丗下一丄丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七东业丅丗下一丄丘 != 1152921538174018712);
    
    }
    public void remove_onEnable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.七东业丅丗下一丄丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七东业丅丗下一丄丘 != 1152921538174155288);
    
    }
    private void Start()
    {
        if(this.executeOnStart == false)
        {
                return;
        }
        
        this.Begin();
    }
    private void OnEnable()
    {
        if(this.executeOnEnable == false)
        {
                return;
        }
        
        this.Begin();
    }
    private void OnDisable()
    {
        if(this.丕丂丛丏专业丛下丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丂丛丏专业丛下丂);
    }
    public void Begin()
    {
        if(this.丕丂丛丏专业丛下丂 != null)
        {
                this.StopCoroutine(routine:  this.丕丂丛丏专业丛下丂);
        }
        
        this.DisableAll();
        this.丕丂丛丏专业丛下丂 = this.StartCoroutine(routine:  this.丗丂三丏三丛不丐丂());
        if(this.丝丝万丄丏丝世三丏 == null)
        {
                return;
        }
        
        this.丝丝万丄丏丝世三丏.Invoke();
    }
    public void DisableAll()
    {
        List.Enumerator<T> val_1 = this.objectList.GetEnumerator();
        label_6:
        if(((-791816680) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objectList = this.objectList, 丏业丟一东丂东丘丛:  false);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void AddObject(float 丕丕世且下一与丝与, UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        ObjectListEnabler.ObjectListEntry val_1 = null;
        .delay = 1f;
        val_1 = new ObjectListEnabler.ObjectListEntry();
        .delay = 丕丕世且下一与丝与;
        .gameObject = 下丐三丆丝与不丗丕;
        this.且上丛丂三丛且丟下(三且丑东与丝丛丐丏:  val_1);
    }
    public void Removebject(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        .下丐三丆丝与不丗丕 = 下丐三丆丝与不丗丕;
        this.下丘三丛丞且三丛万(三且丑东与丝丛丐丏:  System.Linq.Enumerable.FirstOrDefault<ObjectListEntry>(source:  this.objectList, predicate:  new System.Func<ObjectListEntry, System.Boolean>(object:  new ObjectListEnabler.丈业丗丞丁七下一不(), method:  System.Boolean ObjectListEnabler.丈业丗丞丁七下一不::业上下丞丆丟丌丏丙(ObjectListEnabler.ObjectListEntry 三丟东丕丄丄下下丑))));
    }
    public void ClearList()
    {
        this.objectList.Clear();
    }
    private void 且上丛丂三丛且丟下(ObjectListEnabler.ObjectListEntry 三且丑东与丝丛丐丏)
    {
        if(三且丑东与丝丛丐丏 == null)
        {
                return;
        }
        
        this.objectList.Add(item:  三且丑东与丝丛丐丏);
    }
    private void 下丘三丛丞且三丛万(ObjectListEnabler.ObjectListEntry 三且丑东与丝丛丐丏)
    {
        if(三且丑东与丝丛丐丏 == null)
        {
                return;
        }
        
        this.objectList.Add(item:  三且丑东与丝丛丐丏);
    }
    private void 丌丄丏下七丁专丂世()
    {
        if(this.丕丂丛丏专业丛下丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丂丛丏专业丛下丂);
    }
    private System.Collections.IEnumerator 丗丂三丏三丛不丐丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ObjectListEnabler.一世且丟丅丆丞丆不();
    }
    public ObjectListEnabler()
    {
        this.loopDelay = 1f;
        this.executeOnEnable = true;
        this.objectList = new System.Collections.Generic.List<ObjectListEntry>();
    }

}
