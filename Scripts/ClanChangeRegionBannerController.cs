using UnityEngine;
public class ClanChangeRegionBannerController : BannerWindow
{
    // Fields
    private static System.Action<string> 丆丅且下丆三丕丛丕;
    private UIButton _applyButton;
    private PGCompany.PopupList _regionPopupList;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal static bool 业丗丝万专万丞丟上 { get; }
    
    // Methods
    internal static void 三丂东丑上丅丞东丞(System.Action<string> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ClanChangeRegionBannerController.丆丅且下丆三丕丛丕, b:  丙业与丙丗丝不丈东);
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
    internal static void 丁丟且丅丁世世丄丏(System.Action<string> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ClanChangeRegionBannerController.丆丅且下丆三丕丛丕, value:  丙业与丙丗丝不丈东);
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
    internal static bool 丂丙上且不丟业丛丒()
    {
        var val_12;
        if(ClanStartGui_v2.丑七不且上丗丁一世() != 0)
        {
                val_12 = ClanStartGui_v2.丑七不且上丗丁一世().丅与丌专丟一丝业三().activeInHierarchy;
        }
        else
        {
                val_12 = 0;
        }
        
        bool val_8 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  PGCompany.不东丏三丞丞东丕丙.不东丏丅不丌丄丝丝());
        val_8 = ((val_12 != ClansTutorialController.上且世丘丝三丄丈丗()) ? 1 : 0) & val_8 ^ 1;
        return (bool)val_8;
    }
    public void U_Apply()
    {
        int val_4 = System.String.alignConst;
        if(this._regionPopupList != 0)
        {
                val_4 = this._regionPopupList.丕丟丐丈丐丄丌三丐();
            if(val_4 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = val_4.GetStringValue();
        }
        
        }
        
        if(ClanChangeRegionBannerController.丆丅且下丆三丕丛丕 != null)
        {
                ClanChangeRegionBannerController.丆丅且下丆三丕丛丕.Invoke(obj:  val_4);
        }
        
        this.HideSelf();
    }
    protected override void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  0);
        this.丄七丛丅专丑业丛业();
    }
    protected override void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    private void 丄七丛丅专丑业丛业()
    {
        PGCompany.PopupList val_5;
        var val_6;
        val_5 = this;
        this._regionPopupList.Clear();
        val_6 = null;
        val_6 = null;
        List.Enumerator<T> val_1 = PGCompany.不东丏三丞丞东丕丙.丞一丌丙不丄丝且丐.GetEnumerator();
        label_7:
        if(((-368508120) & 1) == 0)
        {
            goto label_5;
        }
        
        this._regionPopupList.AddItemWithValue(丙业与丙丗丝不丈东:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_3 = PGCompany.不东丏三丞丞东丕丙.丟与丄丒丝丗万丟丁();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_3)) == false)
        {
                return;
        }
        
        val_5 = this._regionPopupList;
        val_5.SelectItemWithValue(丙业与丙丗丝不丈东:  val_3);
    }
    public ClanChangeRegionBannerController()
    {
    
    }

}
