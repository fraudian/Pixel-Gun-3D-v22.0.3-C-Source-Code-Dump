using UnityEngine;
private sealed class BannerWindowController.丐世丆丛丝丒丙丂丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BannerWindowType 丌丅丕一丛丛丄一万;
    public BannerWindowController 丝且与丝丒丟万丁专;
    public System.Action 丟丘丙丄丅万丏与丗;
    public bool 丛万下上万丙下世丂;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    public PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东;
    private int 丒世丈丟东丌丒东丈;
    private UnityEngine.ResourceRequest 专万不丑东丌丞世丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BannerWindowController.丐世丆丛丝丒丙丂丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_30;
        UnityEngine.ResourceRequest val_31;
        BannerWindowType val_32;
        UnityEngine.ResourceRequest val_33;
        UnityEngine.GameObject val_34;
        int val_35;
        val_30 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_64;
        }
        
        val_31 = val_30;
        val_32 = this.丌丅丕一丛丛丄一万;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921536322787832] = val_32;
        if(val_32 > (this.丝且与丝丒丟万丁专.bannerWindows.Count - 1))
        {
            goto label_54;
        }
        
        if(this.丝且与丝丒丟万丁专.bannerWindows.Item[this.丒世丈丟东丌丒东丈] != 0)
        {
            goto label_92;
        }
        
        val_32 = val_32.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丌丅丕一丛丛丄一万 = null;
        string val_6 = "banners/"("banners/") + val_32;
        if(this.丛万下上万丙下世丂 == false)
        {
            goto label_12;
        }
        
        val_31 = UnityEngine.Resources.LoadAsync(path:  val_6);
        val_33 = this.专万不丑东丌丞世丕;
        this.专万不丑东丌丞世丕 = val_31;
        if(val_31 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_1:
        val_31 = this.专万不丑东丌丞世丕;
        val_33 = this.专万不丑东丌丞世丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_31 != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        if(val_31.isDone == false)
        {
            goto label_16;
        }
        
        var val_30 = mem[this.专万不丑东丌丞世丕];
        UnityEngine.Object val_9 = val_30.asset;
        if(val_9 == null)
        {
            goto label_18;
        }
        
        val_30 = (null == null) ? (val_9) : 0;
        goto label_19;
        label_16:
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
            goto label_54;
        }
        
        val_35 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_35;
        return (bool)val_35;
        label_18:
        val_34 = 0;
        label_19:
        mem2[0] = 0;
        if(val_34 != 0)
        {
            goto label_57;
        }
        
        label_58:
        label_57:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "BannerWindow banner {0} state is Active: {1}", arg0:  val_34.name, arg1:  val_34.activeSelf));
        val_34.SetActive(value:  false);
        UnityEngine.GameObject val_16 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_34, parent:  this.丝且与丝丒丟万丁专.transform.GetChild(index:  0));
        int val_18 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_16, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        UnityEngine.Transform val_19 = val_16.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        val_19.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        val_19.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        this.丝且与丝丒丟万丁专.bannerWindows.set_Item(index:  this.丒世丈丟东丌丒东丈, value:  val_16.GetComponent<BannerWindow>());
        label_92:
        val_32 = 1152921536322641456;
        val_31 = this.丝且与丝丒丟万丁专.bannerWindows.Item[this.丒世丈丟东丌丒东丈].gameObject;
        if(val_31.activeSelf != true)
        {
                val_31 = this.丝且与丝丒丟万丁专.bannerWindows.Item[this.丒世丈丟东丌丒东丈];
            if(this.丝且与丝丒丟万丁专.东一丏七业丙万丞丅 == 0)
        {
                this.丝且与丝丒丟万丁专.东一丏七业丙万丞丅 = val_31;
            val_26.<丟七丒三丙丝丅不不>k__BackingField = this.丌丅丕一丛丛丄一万;
            if((ConnectScene.丈丘丂丙不丛业丟三() == false) || (this.丌丅丕一丛丛丄一万 == 23))
        {
            goto label_54;
        }
        
            int val_31 = this.丝且与丝丒丟万丁专.viewedBannersCountInConnectScene;
            val_31 = val_31 + 1;
            this.丝且与丝丒丟万丁专.viewedBannersCountInConnectScene = val_31;
        }
        else
        {
                this.丝且与丝丒丟万丁专.丆丌专丟万丄东丟丂.Enqueue(item:  val_31);
        }
        
        }
        
        label_54:
        val_30 = this.丟丘丙丄丅万丏与丗;
        val_30.Invoke();
        label_64:
        val_35 = 0;
        return (bool)val_35;
        label_12:
        if((UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_6)) != null)
        {
            goto label_57;
        }
        
        goto label_58;
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
