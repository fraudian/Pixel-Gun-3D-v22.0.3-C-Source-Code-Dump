using UnityEngine;
public class EnlargeYourPowerBannerWindow : BannerWindow
{
    // Fields
    private Rilisoft.BankBannersHolder _subBannersHolder;
    private UnityEngine.GameObject[] _hideIsSubbanerOpened;
    private static Rilisoft.且丈丞一丞丟与上七 丅下丌丏丒丏丞专丑;
    private const int 且万不东七与下丞业 = 172800;
    private static bool 丆七且与且且不世丏;
    
    // Properties
    internal static bool 业丗丝万专万丞丟上 { get; }
    
    // Methods
    internal static bool 丂丙上且不丟业丛丒()
    {
        return false;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        EnlargeYourPowerBannerWindow.丆七且与且且不世丏 = true;
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EnlargeYourPowerBannerWindow.丆七且与且且不世丏 = false;
    }
    public override void Show()
    {
        UnityEngine.GameObject val_1;
        var val_2;
        val_1 = this;
        this.Show();
        val_2 = 0;
        goto label_1;
        label_6:
        val_1 = this._hideIsSubbanerOpened[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
        val_2 = 1;
        label_1:
        if(val_2 < this._hideIsSubbanerOpened.Length)
        {
            goto label_6;
        }
    
    }
    public void U_ShowOfferRequest()
    {
    
    }
    private void 丏与上三上专丝丙丝(Rilisoft.业丙丘丆东丈丕丂丄 万且万且丑丗且丌丆)
    {
        Rilisoft.OfferPackWindow.上丗与世丄丁丗丅丆(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void EnlargeYourPowerBannerWindow::丏与上三上专丝丙丝(Rilisoft.业丙丘丆东丈丕丂丄 万且万且丑丗且丌丆)));
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  19);
    }
    private void 丈且丒丒东丈世丙丕(string 丆万一不丌且东丐丐)
    {
        UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "ArmoryInfoScreen"));
        val_2.parent = this.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        if(val_2 != null)
        {
                val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        else
        {
                val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_2.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        丙且上东下丏丏丟下 val_9 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丆万一不丌且东丐丐, 七丆丒与丗丌丄且丂:  0);
        ArmoryInfoScreenController val_10 = val_2.GetComponent<ArmoryInfoScreenController>();
    }
    private void 且丆丈业丁丛不东丅()
    {
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  19);
    }
    private void 丛丛业丈下下丐丟丒()
    {
        var val_2;
        var val_3;
        val_2 = static_value_081DACA8;
        val_2 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_3 = static_value_081DACA8;
            val_3 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.HandleGoBtnClicked();
        }
        
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  19);
    }
    public override void Hide()
    {
        EnlargeYourPowerBannerWindow.且万不东七与下丞业.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  FriendsController.丝丗专上三不丄丑丑());
        this.Hide();
    }
    public void U_StartGameRequest()
    {
        this.丛丛业丈下下丐丟丒();
    }
    public void U_Hide()
    {
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  19);
    }
    public EnlargeYourPowerBannerWindow()
    {
    
    }

}
