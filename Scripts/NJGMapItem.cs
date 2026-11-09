using UnityEngine;
public class NJGMapItem : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.List<NJGMapItem> list;
    public bool drawDirection;
    public string content;
    public int type;
    public int revealDistance;
    public NJG.UIMapArrow arrow;
    public bool forceArrow;
    public bool dontShowIcon;
    public bool isCustomColor;
    public UnityEngine.Color customColor;
    public System.Action<bool> onSelect;
    public bool showIcon;
    public bool isActive;
    private UnityEngine.Color 业丒丗丄丏丏万丗丁;
    private bool 丏丘上丏丝万世一世;
    private bool 丘丁与丆丕丟专下丐;
    private bool 丕上七丌下三丐丈三;
    private bool 东与丐丗丛丛丞丙丟;
    private bool 上丏专丒丒七丏丁上;
    private bool 丞丌丄三下丐三七丝;
    private bool 丈三丆上丛三丞丁丛;
    private bool 丆丗丈业不世下丑一;
    private bool 丐丏丏上丝下上三丈;
    private float 丈丏七丑一丏丞万丑;
    private UnityEngine.Vector2 三七丑丈丝丈不丒丄;
    private UnityEngine.Vector2 万丗丛丁丘丛丆丑不;
    private UnityEngine.Vector2 丗丆丛丏丈丈丆丑业;
    private int 与且丈丏丗丅三下七;
    private int 东丅一与丒丑丛丛丟;
    private int 丕不丆丝丝业七丁丏;
    private int 万丈与丝三三下不与;
    private int 丗丁丌不丈丗专三丕;
    private int 丟丂丒丛业丁丞丛且;
    private int 丞专丕丌丙丕且丑丛;
    private bool 且丛业一丗丌上专业;
    private bool 一业丐丛上丑丅丙丈;
    private bool 与丌不一丟东与丄丘;
    private bool 丞丝丈下丑世丂万丞;
    private bool 与丌三丗丁下丌业丕;
    private bool 与三世业世丄丙丕丘;
    private bool 丐上专万丌世下丝专;
    private bool 丗三一丆专与业不东;
    private bool 下丟专专且不丈丕专;
    private bool 丌东专丏七丌丄不世;
    private bool 丅世丘丌丄丕东丐丕;
    private bool 东一且三丑丑丏丗七;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    public bool isSafeSphereIcon;
    public bool isUnsafeSphereIcon;
    public bool isForSafeRay;
    public bool isForUnsafeRay;
    public bool isMyPlayer;
    public bool inMagazine;
    private bool 丅丗丘丈丞丟丐丂丈;
    private System.Collections.IEnumerator 丙丁且丏与丏上丁上;
    
    // Properties
    public UnityEngine.Color 丑丞丈丗丄丙丟万丄 { get; }
    public bool 专一丝丗丟丂丞上丐 { get; }
    public bool 丁丛丅丌一丌丝丌东 { get; }
    public bool 丑不丗丌丟上丁丌世 { get; }
    public bool 丗丛与丗丄丟世东业 { get; }
    public bool 丑上东业下丄丆世专 { get; }
    public bool 丐丈丗下丄丑丅丒万 { get; }
    public bool 下丝三丞丑与丅丏丕 { get; }
    public float 丞万上丗丟与下且三 { get; }
    public int 丟丒且一专丟丙下一 { get; }
    public int 且上丄丕丒丞丙丑丏 { get; }
    public bool 丞丐丆丞东丄丈专丐 { get; }
    public int 丆下丑与丂丁丘不且 { get; }
    public virtual UnityEngine.Vector3 业丑丞不丕丗丄三丁 { get; }
    public virtual UnityEngine.Vector3 丙三丄丄丙丐下专不 { get; }
    public virtual UnityEngine.Vector3 万东丘丒丘丂一丌丆 { get; }
    public int 丟丕丞丁丝丂上丄上 { get; }
    public int 丞且与丆丁业丑丈七 { get; }
    public bool 丞丈丌且东丆丅丗万 { get; set; }
    public bool 丌丐不七业下业丑且 { get; set; }
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    
    // Methods
    public UnityEngine.Color get_color()
    {
        if(this.一业丐丛上丑丅丙丈 != false)
        {
            
        }
        else
        {
                UnityEngine.Color val_2 = NJG.NJGMapBase.instance.GetColor(丁丅丈丌丟世丗丗丟:  this.type);
            this.业丒丗丄丏丏万丗丁 = val_2;
            mem[1152921535380123376] = val_2.g;
            mem[1152921535380123380] = val_2.b;
            mem[1152921535380123384] = val_2.a;
        }
        
        this.一业丐丛上丑丅丙丈 = true;
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public bool get_rotate()
    {
        bool val_5;
        if(this.与丌不一丟东与丄丘 != false)
        {
                val_5 = this.丘丁与丆丕丟专下丐;
            return (bool)(val_5 == true) ? 1 : 0;
        }
        
        this.与丌不一丟东与丄丘 = true;
        val_5 = NJG.NJGMapBase.instance.GetRotate(丁丅丈丌丟世丗丗丟:  this.type);
        this.丘丁与丆丕丟专下丐 = val_5;
        return (bool)(val_5 == true) ? 1 : 0;
    }
    public bool get_interaction()
    {
        return false;
    }
    public bool get_updatePosition()
    {
        bool val_5;
        if(this.与丌三丗丁下丌业丕 != false)
        {
                val_5 = this.东与丐丗丛丛丞丙丟;
            return (bool)(val_5 == true) ? 1 : 0;
        }
        
        this.与丌三丗丁下丌业丕 = true;
        val_5 = NJG.NJGMapBase.instance.GetUpdatePosition(丁丅丈丌丟世丗丗丟:  this.type);
        this.东与丐丗丛丛丞丙丟 = val_5;
        return (bool)(val_5 == true) ? 1 : 0;
    }
    public bool get_animateOnVisible()
    {
        bool val_5;
        if(this.与三世业世丄丙丕丘 != false)
        {
                val_5 = this.上丏专丒丒七丏丁上;
            return (bool)(val_5 == true) ? 1 : 0;
        }
        
        this.与三世业世丄丙丕丘 = true;
        val_5 = NJG.NJGMapBase.instance.GetAnimateOnVisible(丁丅丈丌丟世丗丗丟:  this.type);
        this.上丏专丒丒七丏丁上 = val_5;
        return (bool)(val_5 == true) ? 1 : 0;
    }
    public bool get_showOnAction()
    {
        bool val_5;
        if(this.丐上专万丌世下丝专 != false)
        {
                val_5 = this.丞丌丄三下丐三七丝;
            return (bool)(val_5 == true) ? 1 : 0;
        }
        
        this.丐上专万丌世下丝专 = true;
        val_5 = NJG.NJGMapBase.instance.GetAnimateOnAction(丁丅丈丌丟世丗丗丟:  this.type);
        this.丞丌丄三下丐三七丝 = val_5;
        return (bool)(val_5 == true) ? 1 : 0;
    }
    public bool get_loopAnimation()
    {
        bool val_5;
        if(this.丗三一丆专与业不东 != false)
        {
                val_5 = this.丈三丆上丛三丞丁丛;
            return (bool)(val_5 == true) ? 1 : 0;
        }
        
        this.丗三一丆专与业不东 = true;
        val_5 = NJG.NJGMapBase.instance.GetLoopAnimation(丁丅丈丌丟世丗丗丟:  this.type);
        this.丈三丆上丛三丞丁丛 = val_5;
        return (bool)(val_5 == true) ? 1 : 0;
    }
    public bool get_haveArrow()
    {
        var val_5;
        bool val_6;
        if(this.forceArrow != false)
        {
                val_5 = 1;
            return (bool)(val_6 == true) ? 1 : 0;
        }
        
        if(this.下丟专专且不丈丕专 != false)
        {
                val_6 = this.丆丗丈业不世下丑一;
            return (bool)(val_6 == true) ? 1 : 0;
        }
        
        this.下丟专专且不丈丕专 = true;
        val_6 = NJG.NJGMapBase.instance.GetHaveArrow(丁丅丈丌丟世丗丗丟:  this.type);
        this.丆丗丈业不世下丑一 = val_6;
        return (bool)(val_6 == true) ? 1 : 0;
    }
    public float get_fadeOutAfterDelay()
    {
        if(this.丈丏七丑一丏丞万丑 != (-1f))
        {
                return val_2;
        }
        
        float val_2 = NJG.NJGMapBase.instance.GetFadeOutAfter(丁丅丈丌丟世丗丗丟:  this.type);
        this.丈丏七丑一丏丞万丑 = val_2;
        return val_2;
    }
    public int get_size()
    {
        int val_5;
        if((NJG.NJGMapBase.instance.GetCustom(丁丅丈丌丟世丗丗丟:  this.type)) != false)
        {
                val_5 = NJG.NJGMapBase.instance;
            int val_4 = val_5.GetSize(丁丅丈丌丟世丗丗丟:  this.type);
        }
        else
        {
                val_5 = val_3.iconSize;
        }
        
        this.丕不丆丝丝业七丁丏 = val_5;
        return val_5;
    }
    public int get_sizeArrow()
    {
        int val_5;
        if((NJG.NJGMapBase.instance.GetCustomArrow(丁丅丈丌丟世丗丗丟:  this.type)) != false)
        {
                val_5 = NJG.NJGMapBase.instance;
            int val_4 = val_5.GetArrowSize(丁丅丈丌丟世丗丗丟:  this.type);
        }
        else
        {
                val_5 = val_3.iconSize;
        }
        
        this.丕不丆丝丝业七丁丏 = val_5;
        return val_5;
    }
    public bool get_customArrowSize()
    {
        NJG.NJGMapBase val_1 = NJG.NJGMapBase.instance;
        if(val_1 != null)
        {
                return val_1.GetCustomArrow(丁丅丈丌丟世丗丗丟:  this.type);
        }
        
        return val_1.GetCustomArrow(丁丅丈丌丟世丗丗丟:  this.type);
    }
    public int get_borderSize()
    {
        int val_5;
        if((NJG.NJGMapBase.instance.GetCustomBorder(丁丅丈丌丟世丗丗丟:  this.type)) != false)
        {
                val_5 = NJG.NJGMapBase.instance;
            int val_4 = val_5.GetBorderSize(丁丅丈丌丟世丗丗丟:  this.type);
        }
        else
        {
                val_5 = val_3.borderSize;
        }
        
        this.万丈与丝三三下不与 = val_5;
        return val_5;
    }
    public virtual UnityEngine.Vector3 get_iconScale()
    {
        UnityEngine.Vector2 val_4;
        float val_5;
        if(this.与且丈丏丗丅三下七 == this.size)
        {
                val_4 = this.三七丑丈丝丈不丒丄;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4, y = val_5});
        }
        
        this.与且丈丏丗丅三下七 = this.size;
        val_5 = (float)this.size;
        val_4 = val_5;
        this.三七丑丈丝丈不丒丄 = val_5;
        mem[1152921535381698192] = val_5;
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4, y = val_5});
    }
    public virtual UnityEngine.Vector3 get_arrowScale()
    {
        UnityEngine.Vector2 val_3;
        float val_4;
        if(this.东丅一与丒丑丛丛丟 == this.sizeArrow)
        {
                val_3 = this.万丗丛丁丘丛丆丑不;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3, y = val_4});
        }
        
        int val_2 = this.sizeArrow;
        val_4 = (float)val_2;
        val_3 = val_4;
        this.东丅一与丒丑丛丛丟 = val_2;
        this.万丗丛丁丘丛丆丑不 = val_4;
        mem[1152921535381810200] = val_4;
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3, y = val_4});
    }
    public virtual UnityEngine.Vector3 get_borderScale()
    {
        UnityEngine.Vector2 val_4;
        float val_5;
        if(this.丗丁丌不丈丗专三丕 == this.borderSize)
        {
                val_4 = this.丗丆丛丏丈丈丆丑业;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4, y = val_5});
        }
        
        this.丗丁丌不丈丗专三丕 = this.borderSize;
        val_5 = (float)this.borderSize;
        val_4 = val_5;
        this.丗丆丛丏丈丈丆丑业 = val_5;
        mem[1152921535381922208] = val_5;
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4, y = val_5});
    }
    public int get_depth()
    {
        int val_3 = this.丟丂丒丛业丁丞丛且;
        if(val_3 != 2147483647)
        {
                return val_2;
        }
        
        val_3 = NJG.NJGMapBase.instance;
        int val_2 = val_3.GetDepth(丁丅丈丌丟世丗丗丟:  this.type);
        this.丟丂丒丛业丁丞丛且 = val_2;
        return val_2;
    }
    public int get_arrowDepth()
    {
        int val_3 = this.丞专丕丌丙丕且丑丛;
        if(val_3 != 2147483647)
        {
                return val_2;
        }
        
        val_3 = NJG.NJGMapBase.instance;
        int val_2 = val_3.GetArrowDepth(丁丅丈丌丟世丗丗丟:  this.type);
        this.丞专丕丌丙丕且丑丛 = val_2;
        return val_2;
    }
    public bool get_isSelected()
    {
        return (bool)this.东一且三丑丑丏丗七;
    }
    public void set_isSelected(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.东一且三丑丑丏丗七 = 丙业与丙丗丝不丈东;
        if(this.onSelect == null)
        {
                return;
        }
        
        this.onSelect.Invoke(obj:  丙业与丙丗丝不丈东);
    }
    public bool get_forceSelection()
    {
        return (bool)this.丅世丘丌丄丕东丐丕;
    }
    public void set_forceSelection(bool 丙业与丙丗丝不丈东)
    {
        this.丅世丘丌丄丕东丐丕 = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    public void SetType(string 丌下丏丐丕丏不丗一)
    {
        if(NJG.NJGMapBase.instance == 0)
        {
                return;
        }
        
        int val_4 = NJG.NJGMapBase.instance.GetMapItemTypeIndex(丁丅丈丌丟世丗丗丟:  丌下丏丐丕丏不丗一);
        if(val_4 < 1)
        {
                return;
        }
        
        this.type = val_4;
    }
    private void Awake()
    {
        int val_1 = this.type;
        val_1 = val_1 - 1;
        if(val_1 > 11)
        {
                return;
        }
        
        var val_2 = 106013512 + ((this.type - 1)) << 2;
        val_2 = val_2 + 106013512;
        goto (106013512 + ((this.type - 1)) << 2 + 106013512);
    }
    private void Start()
    {
    
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.且东专下世上丁丌下();
        this.丙丁且丏与丏上丁上 = val_1;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
    }
    private System.Collections.IEnumerator 且东专下世上丁丌下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NJGMapItem.业下丛丅专且丗丅丝();
    }
    public void AddToList()
    {
        var val_1;
        if(this.丅丗丘丈丞丟丐丂丈 != false)
        {
                return;
        }
        
        this.丅丗丘丈丞丟丐丂丈 = true;
        val_1 = null;
        val_1 = null;
        NJGMapItem.list.Add(item:  this);
    }
    private void 丆丘丐丛七丈不丄与()
    {
        var val_2;
        if(this.丅丗丘丈丞丟丐丂丈 == false)
        {
                return;
        }
        
        this.丅丗丘丈丞丟丐丂丈 = false;
        val_2 = null;
        val_2 = null;
        bool val_1 = NJGMapItem.list.Remove(item:  this);
    }
    private void OnDestroy()
    {
        this.丁丒与丘丂世丞丒丙();
    }
    private void OnDisable()
    {
        this.丁丒与丘丂世丞丒丙();
    }
    private void 丁丒与丘丂世丞丒丙()
    {
        NJG.UIMapArrow val_4;
        if(this.丙丁且丏与丏上丁上 != null)
        {
                this.StopCoroutine(routine:  this.丙丁且丏与丏上丁上);
            this.丙丁且丏与丏上丁上 = 0;
        }
        
        if(this.inMagazine != false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                val_4 = 1152921504848912384;
            if(this.arrow != 0)
        {
                if(NJG.UIMiniMapBase.inst != 0)
        {
                val_4 = this.arrow;
        }
        
        }
        
            this.arrow = 0;
        }
        
        this.丆丘丐丛七丈不丄与();
    }
    private void OnDrawGizmosSelected()
    {
    
    }
    public void Select()
    {
        this.东一且三丑丑丏丗七 = true;
    }
    public void Select(bool 万东不世丁不丆世丟)
    {
        this.东一且三丑丑丏丗七 = true;
        this.丅世丘丌丄丕东丐丕 = 万东不世丁不丆世丟;
    }
    public void UnSelect()
    {
        this.东一且三丑丑丏丗七 = false;
    }
    public void Show()
    {
        this.showIcon = true;
    }
    public NJGMapItem()
    {
        this.content = "";
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.customColor = val_1;
        mem[1152921535384623056] = val_1.g;
        mem[1152921535384623060] = val_1.b;
        mem[1152921535384623064] = val_1.a;
        this.isActive = true;
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.业丒丗丄丏丏万丗丁 = val_2;
        mem[1152921535384623088] = val_2.g;
        this.丈丏七丑一丏丞万丑 = -1f;
        mem[1152921535384623092] = val_2.b;
        mem[1152921535384623096] = val_2.a;
        this.与且丈丏丗丅三下七 = val_2.r;
        this.丗丁丌不丈丗专三丕 = 2147483647;
        this.丟丂丒丛业丁丞丛且 = 2147483647;
        this.丞专丕丌丙丕且丑丛 = 2147483647;
    }
    private static NJGMapItem()
    {
        NJGMapItem.list = new System.Collections.Generic.List<NJGMapItem>();
    }

}
