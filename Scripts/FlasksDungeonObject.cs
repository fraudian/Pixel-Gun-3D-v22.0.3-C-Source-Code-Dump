using UnityEngine;
internal class FlasksDungeonObject : SubscribeOnTriggerObject
{
    // Fields
    private static System.Action<FlasksDungeonObject> 丁丛万丙丄丗丄丄上;
    private System.Action<FlasksDungeonObject> 丐丐世专丗丘丛丝一;
    private bool 丟丝丕丄丗一丆东万;
    private UnityEngine.AudioClip _clip;
    
    // Methods
    internal static void 东专上万且专丏专上(System.Action<FlasksDungeonObject> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  FlasksDungeonObject.丁丛万丙丄丗丄丄上, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 业丞世专上东丅业丏(System.Action<FlasksDungeonObject> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  FlasksDungeonObject.丁丛万丙丄丗丄丄上, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal void 丁上世丕丛丕丌丒专(System.Action<FlasksDungeonObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐丐世专丗丘丛丝一, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丐世专丗丘丛丝一 != 1152921540033499592);
    
    }
    internal void 丝丆丑丂丝不丙丙一(System.Action<FlasksDungeonObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐丐世专丗丘丛丝一, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丐世专丗丘丛丝一 != 1152921540033636168);
    
    }
    private void Start()
    {
        DungeonsController.丒与丒丄丏东万上丛(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FlasksDungeonObject::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        if(FlasksDungeonObject.丁丛万丙丄丗丄丄上 == null)
        {
                return;
        }
        
        FlasksDungeonObject.丁丛万丙丄丗丄丄上.Invoke(obj:  this);
    }
    protected override void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if((this.丟丝丕丄丗一丆东万 != true) && (this.丐丐世专丗丘丛丝一 != null))
        {
                this.丐丐世专丗丘丛丝一.Invoke(obj:  this);
        }
        
        this.丟丝丕丄丗一丆东万 = true;
        val_10 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_10.业丐丐三丕一丗丛丁() == 丅上丁不丛丁上七丈)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_11 = null;
            val_11 = null;
            gameObject.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this._clip);
        }
        
            val_10 = 1152921505058603008;
            val_12 = null;
            val_12 = null;
            if(DungeonsController.丄丘七三上丕世丞业 != 0)
        {
                val_13 = null;
            val_13 = null;
            DungeonsController.丄丘七三上丕世丞业.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  123);
        }
        
        }
        
        if(this.丛丘丟业下丐专丕丑().isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丟丝丕丄丗一丆东万 == false)
        {
                return;
        }
        
        if(this.丛丘丟业下丐专丕丑().isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
    }
    private void OnDestroy()
    {
        DungeonsController.丄三丕东七下丒丒三(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FlasksDungeonObject::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        if((this.丟丝丕丄丗一丆东万 != true) && (this.丐丐世专丗丘丛丝一 != null))
        {
                this.丐丐世专丗丘丛丝一.Invoke(obj:  this);
        }
        
        this.丟丝丕丄丗一丆东万 = true;
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        this.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, angle:  UnityEngine.Time.deltaTime * 30f, relativeTo:  0);
    }
    public FlasksDungeonObject()
    {
    
    }

}
