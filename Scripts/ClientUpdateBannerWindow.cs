using UnityEngine;
public class ClientUpdateBannerWindow : BannerWindow
{
    // Fields
    private static Rilisoft.业业丛上世丄业上丐<ClientUpdateBannerWindow.丏且且与三丙丘丒三> 丂丞丁世丒丁七七业;
    private static Rilisoft.七丒丛丑丙丑丞丁丘 丅丐七丝丒丄丌丘丂;
    private const int 丑丌下丌丟不丈丝业 = 3600;
    private NewGameBalance12_5WindowController _bannerComponent;
    private static UnityEngine.GameObject 丕专与专丈丘丑且丕;
    
    // Properties
    internal static ClientUpdateBannerWindow.丏且且与三丙丘丒三 下丂丈下丛丌丛丈丞 { get; set; }
    
    // Methods
    internal static ClientUpdateBannerWindow.丏且且与三丙丘丒三 业丝上东世世七万业()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(专七专下且专三一且.上且一丈丐三丄一丆() > ((ClientUpdateBannerWindow.丅丐七丝丒丄丌丘丂.世三丞丅丑丌丈丈一() + 3600) << ))
        {
                val_5 = null;
            val_5 = null;
            ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
        }
        
        val_6 = null;
        val_6 = null;
        if(ClientUpdateBannerWindow.丑丌下丌丟不丈丝业 != 0)
        {
                return ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.世三丞丅丑丌丈丈一();
        }
        
        return ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.世三丞丅丑丌丈丈一();
    }
    internal static void 丞东东丗丅丗丟丅丁(ClientUpdateBannerWindow.丏且且与三丙丘丒三 丙业与丙丗丝不丈东)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        Rilisoft.七丒丛丑丙丑丞丁丘 val_8;
        var val_9;
        var val_10;
        var val_11;
        val_4 = null;
        val_4 = null;
        if(ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.世三丞丅丑丌丈丈一() == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        val_6 = null;
        if(ClientUpdateBannerWindow.丑丌下丌丟不丈丝业.世三丞丅丑丌丈丈一() != 0)
        {
                val_7 = null;
            val_8 = ClientUpdateBannerWindow.丅丐七丝丒丄丌丘丂;
            val_9 = 1152921531052698208;
            val_10 = 专七专下且专三一且.上且一丈丐三丄一丆();
        }
        else
        {
                val_11 = null;
            val_8 = ClientUpdateBannerWindow.丅丐七丝丒丄丌丘丂;
            val_9 = 1152921531052698208;
            val_10 = 0;
        }
        
        val_8.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
    }
    internal static bool 丕世一与业丅万专丑()
    {
        return (bool)(ClientUpdateBannerWindow.业丝上东世世七万业() != 0) ? 1 : 0;
    }
    internal static void 一万丆丏丏世与世丝()
    {
        UnityEngine.Object val_5;
        if(ClientUpdateBannerWindow.业丝上东世世七万业() == 0)
        {
                return;
        }
        
        val_5 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_5.ForceShowBanner(丌丅丕一丛丛丄一万:  20, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public override void Show()
    {
        var val_13;
        var val_14;
        var val_15;
        val_13 = null;
        val_13 = null;
        if(ClientUpdateBannerWindow.丕专与专丈丘丑且丕 != 0)
        {
                val_14 = null;
            val_14 = null;
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  ClientUpdateBannerWindow.丕专与专丈丘丑且丕);
            ClientUpdateBannerWindow.丕专与专丈丘丑且丕 = 0;
        }
        
        this.Show();
        val_15 = null;
        val_15 = null;
        ClientUpdateBannerWindow.丕专与专丈丘丑且丕 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/NewBalanceBanner"));
        UnityEngine.Transform val_4 = ClientUpdateBannerWindow.丕专与专丈丘丑且丕.transform;
        val_4.SetParent(p:  this.transform);
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  ClientUpdateBannerWindow.丕专与专丈丘丑且丕, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_4.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        val_4.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        this._bannerComponent = ClientUpdateBannerWindow.丕专与专丈丘丑且丕.GetComponent<NewGameBalance12_5WindowController>();
        val_11.ContentType = ClientUpdateBannerWindow.业丝上东世世七万业();
        this._bannerComponent.Show(丑丒丄万丅丛丗丛丕:  false);
    }
    private void Update()
    {
        if(this._bannerComponent != 0)
        {
                0 = 0;
            if(this._bannerComponent.gameObject != 0)
        {
                return;
        }
        
        }
        
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  20);
    }
    public ClientUpdateBannerWindow()
    {
    
    }
    private static ClientUpdateBannerWindow()
    {
        ClientUpdateBannerWindow.丑丌下丌丟不丈丝业 = new Rilisoft.业业丛上世丄业上丐<丏且且与三丙丘丒三>(丟东丟丑丕丄丂丟丙:  "update-banner-saved-type1");
        ClientUpdateBannerWindow.丅丐七丝丒丄丌丘丂 = new Rilisoft.七丒丛丑丙丑丞丁丘(丟东丟丑丕丄丂丟丙:  "update-banner-first-view-type1");
    }

}
