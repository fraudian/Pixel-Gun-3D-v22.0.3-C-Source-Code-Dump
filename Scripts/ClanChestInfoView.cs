using UnityEngine;
public class ClanChestInfoView : PGBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.Vector4 丑丘三丈且丄丒一丗;
    private 世不丁七七丘业专丅 不丑丆丌世丁丛与一;
    private bool 上丁专万丗丘丄七丌;
    private System.Action 丄丑上丕丂丈丘丙七;
    private UIBasicSprite _chestTexture;
    private System.Collections.Generic.List<UnityEngine.GameObject> _progressObjects;
    private System.Collections.Generic.List<UIBasicSprite> _progressSprites;
    private System.Collections.Generic.List<UILabel> _progressLabels;
    private System.Collections.Generic.List<UILabel> _headerLabels;
    private UIScrollView _scroll;
    private UIWrapContent _wrap;
    private UnityEngine.GameObject _medalsLeftObject;
    private UILabel _medalsLeftLabel;
    private UnityEngine.GameObject _chestOpenedObject;
    private UITable _guaranteedRarityTable;
    private UITable _randomRarityTable;
    
    // Properties
    public bool 东且世与一东丂一丆 { get; }
    
    // Methods
    public bool get___InterfaceEnabled()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    public void ShowWindow()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void HideWindow()
    {
        this.Hide();
    }
    public void add_OnClose(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921536534856400);
    
    }
    public void remove_OnClose(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921536534992976);
    
    }
    public void Show(世不丁七七丘业专丅 丐下丝丘丑丟丟丗丌)
    {
        this.不丑丆丌世丁丛与一 = 丐下丝丘丑丟丟丗丌;
        if(丐下丝丘丑丟丟丗丌 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        System.IDisposable val_4 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanChestInfoView::Hide()), 与且专丈不万东一万:  0);
        this.丐丆七且丞丏下三丙 = val_4;
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  val_4.丁万丝且丙丅万丟丄());
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this.丄丑上丕丂丈丘丙七 == null)
        {
                return;
        }
        
        this.丄丑上丕丂丈丘丙七.Invoke();
    }
    private void 丝一丅丆三东丂丞七()
    {
    
    }
    private System.Collections.IEnumerator 丁万丝且丙丅万丟丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new ClanChestInfoView.丂丐丒东丗一上丟丒();
    }
    public void U_BackRequest()
    {
        this.Hide();
    }
    public ClanChestInfoView()
    {
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
        this.丑丘三丈且丄丒一丗 = val_1;
        mem[1152921536536000628] = val_1.y;
        mem[1152921536536000632] = val_1.z;
        mem[1152921536536000636] = val_1.w;
        this.上丁专万丗丘丄七丌 = true;
    }

}
