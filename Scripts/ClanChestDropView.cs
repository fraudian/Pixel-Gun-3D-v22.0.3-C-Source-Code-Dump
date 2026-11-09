using UnityEngine;
public class ClanChestDropView : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
{
    // Fields
    private UnityEngine.Camera _3dCamera;
    private UnityEngine.Coroutine 丕丛万一且万丟丝世;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private 世不丁七七丘业专丅 不丑丆丌世丁丛与一;
    private UnityEngine.Animator 丐丏丁丞与丌丐丌上;
    private UnityEngine.GameObject _chestsHolder;
    private UIBasicSprite _chestTexture;
    private Rilisoft.GameEventMultyDrop _fakeDropView;
    private UnityEngine.Coroutine 丆丗丂丐丗不丆丟丁;
    private System.Collections.Generic.List<ClanItem> 丞与世且丑丏专丒丄;
    private UIGrid _grid;
    private UnityEngine.GameObject _gridObject;
    private System.Collections.Generic.List<ClanItemView> _gridViews;
    private UnityEngine.AudioClip _itemShowClip;
    private float 与丙丟与上且丒丘不;
    private UnityEngine.AudioClip _openChestClip;
    private PositionHolder _posHolder;
    private Rilisoft.ReelController _reelController;
    private System.Collections.Generic.List<ClanItem> 丑丘七丄万丐三下世;
    private UIScrollView _scroll;
    private UnityEngine.GameObject _scrollObject;
    private ClanItemView _scrollViewPrototype;
    private UILabel[] _windowHeader;
    private bool 不七丞丄丙一一丒丆;
    private bool 万丅专丏业丛丐丑业;
    private System.Action 丄丑上丕丂丈丘丙七;
    
    // Properties
    private UIBasicSprite 丐世丛东丈丒东不丒 { get; }
    public bool 东且世与一东丂一丆 { get; }
    
    // Methods
    private UIBasicSprite 丁丗丝丂与七与丙丂()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._chestTexture);
        this._chestTexture = val_1;
        return val_1;
    }
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
    
    }
    public void HideWindow()
    {
        if(this.丕丛万一且万丟丝世 != null)
        {
                this.StopCoroutine(routine:  this.丕丛万一且万丟丝世);
            this.丕丛万一且万丟丝世 = 0;
        }
        
        if(this.不七丞丄丙一一丒丆 != false)
        {
                this.不七丞丄丙一一丒丆 = false;
        }
        
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
        while(this.丄丑上丕丂丈丘丙七 != 1152921536533178232);
    
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
        while(this.丄丑上丕丂丈丘丙七 != 1152921536533314808);
    
    }
    private void Awake()
    {
        this._scrollViewPrototype.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanChestDropView::U_HideRequest()), 与且专丈不万东一万:  0);
        this.与丙丟与上且丒丘不 = UnityEngine.Time.realtimeSinceStartup;
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
    public void Show(世不丁七七丘业专丅 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<ClanItem> 上业丟世三与七七三)
    {
    
    }
    private string 丐丈丑丐丟万丙丁七(ClanItem 下丅丙一丂丗丅丝七)
    {
        int val_2;
        if(下丅丙一丂丗丅丝七 != null)
        {
                if(下丅丙一丂丗丅丝七._type != 100)
        {
                return (string)System.String.Format(format:  "x{0}", arg0:  下丅丙一丂丗丅丝七._count);
        }
        
        }
        
        val_2 = System.String.alignConst;
        return (string)System.String.Format(format:  "x{0}", arg0:  下丅丙一丂丗丅丝七._count);
    }
    public void Hide()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reelController.gameObject, 丏业丟一东丂东丘丛:  false);
        this._posHolder.SetState(丏业丟一东丂东丘丛:  0);
        this.gameObject.SetActive(value:  false);
        if(this.丄丑上丕丂丈丘丙七 == null)
        {
                return;
        }
        
        this.丄丑上丕丂丈丘丙七.Invoke();
    }
    public void U_HideRequest()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.与丙丟与上且丒丘不;
        if(val_1 <= 0.3f)
        {
            goto label_0;
        }
        
        if(this.不七丞丄丙一一丒丆 == false)
        {
            goto label_3;
        }
        
        this.万丅专丏业丛丐丑业 = true;
        return;
        label_0:
        if(this.不七丞丄丙一一丒丆 != false)
        {
                return;
        }
        
        label_3:
        this.Hide();
    }
    public ClanChestDropView()
    {
    
    }

}
