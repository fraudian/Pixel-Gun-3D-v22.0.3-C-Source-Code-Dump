using UnityEngine;
internal class KeyDungeonObject : SubscribeOnTriggerObject
{
    // Fields
    private static System.Action 专丞三丞丘与丛上丗;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    private bool 丟丝丕丄丗一丆东万;
    private UnityEngine.AudioClip _clip;
    
    // Methods
    internal static void 丏不一丁一丙万丂丄(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  KeyDungeonObject.专丞三丞丘与丛上丗, b:  丙业与丙丗丝不丈东);
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
    internal static void 东世丌丞丁丑丄丏丏(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  KeyDungeonObject.专丞三丞丘与丛上丗, value:  丙业与丙丗丝不丈东);
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
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new KeyDungeonObject.丕丌丏丞万丏三丙丏();
    }
    protected override void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)
    {
        UnityEngine.GameObject val_14;
        var val_15;
        var val_16;
        var val_17;
        val_14 = this;
        if((this.丟丝丕丄丗一丆东万 != true) && (KeyDungeonObject.专丞三丞丘与丛上丗 != null))
        {
                KeyDungeonObject.专丞三丞丘与丛上丗.Invoke();
        }
        
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() == 丅上丁不丛丁上七丈)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_15 = null;
            val_15 = null;
            gameObject.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this._clip);
        }
        
            val_16 = null;
            val_16 = null;
            if(DungeonsController.丄丘七三上丕世丞业 != 0)
        {
                val_17 = null;
            val_17 = null;
            DungeonsController.丄丘七三上丕世丞业.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  121);
        }
        
        }
        
        this.丟丝丕丄丗一丆东万 = true;
        if(this.丛丘丟业下丐专丕丑().isMine != false)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
        }
        
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_14 = this.gameObject;
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  val_14);
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
        DungeonsController.丄三丕东七下丒丒三(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void KeyDungeonObject::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        if((this.丟丝丕丄丗一丆东万 != true) && (KeyDungeonObject.专丞三丞丘与丛上丗 != null))
        {
                KeyDungeonObject.专丞三丞丘与丛上丗.Invoke();
        }
        
        this.丟丝丕丄丗一丆东万 = true;
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        this = this.gameObject;
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  this);
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        this.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, angle:  UnityEngine.Time.deltaTime * 30f, relativeTo:  0);
    }
    public KeyDungeonObject()
    {
    
    }

}
