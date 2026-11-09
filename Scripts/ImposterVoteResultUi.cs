using UnityEngine;
public class ImposterVoteResultUi : PGBehaviour
{
    // Fields
    private static readonly int 专丛专丐丗七三丒丄;
    private static readonly int 丄一东不专丏丐七丆;
    private static readonly int 丝上丅丆丅丂丈丏丛;
    private static readonly int 丗一世丂丙一丛丁丞;
    private static readonly int 丗丒丞与业丙丙世丗;
    private UILabel _topTextLabel;
    private UILabel _bottomTextLabel;
    private System.Collections.Generic.List<UILabel> _centerTextLabel;
    private UnityEngine.Animator _animator;
    private UITextureMasked _playerTexture;
    private UnityEngine.GameObject _crossGameObject;
    private UnityEngine.GameObject _imposterStampGameObject;
    private UISprite _playerColoredBackground;
    private float _textPrintDelay;
    private UnityEngine.AudioClip resultSound;
    private ImposterVoteController 丑丒且丆丌一丌下七;
    private bool 丂丝专丗业丁丂丆丘;
    private bool 丑丞丅丘丆丅丏丅丘;
    private System.Collections.Generic.Dictionary<int, System.ValueTuple<bool, string, string>> 丅丁下丗丂与三东丞;
    
    // Methods
    internal void 丗不专世丈下东丂丝(ImposterVoteController 东丌与与且丝三丟业)
    {
        this.丑丒且丆丌一丌下七 = 东丌与与且丝三丟业;
        this.丗丂万丙丌一丁万丏();
        if(this.丑丒且丆丌一丌下七 == null)
        {
                this = 0;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丏丒世丕丛七业丑丂(不丑与下丅三丑丅七:  val_5.不丅丞丄丑世一丆不(), 丟丘丙丄丅万丏与丗:  new System.Action(object:  this, method:  System.Void ImposterVoteResultUi::丒丐万丞不专丁丆丙())));
    }
    internal void 且七丁丈不七下与七()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        this.丅丁下丗丂与三东丞.Clear();
        val_11 = 0;
        goto label_2;
        label_22:
        val_12 = null;
        val_12 = null;
        NetworkStartTable val_1 = Item[0];
        if(val_1.丄丈丑丐丆丞丘与丗.owner != null)
        {
                val_13 = null;
            val_13 = null;
            NetworkStartTable val_3 = Item[0];
            string val_7 = val_3.万丑一东丅上丗一东();
            bool val_8 = val_3.丟东丘丏上世且上丕();
            this.丅丁下丗丂与三东丞.set_Item(key:  val_3.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁(), value:  new System.ValueTuple<System.Boolean, System.String, System.String>());
        }
        
        val_11 = 1;
        label_2:
        val_14 = null;
        val_14 = null;
        if(val_11 < Count)
        {
            goto label_22;
        }
    
    }
    private void 丒丐万丞不专丁丆丙()
    {
        this.丑丒且丆丌一丌下七.丆丅与东丏丈丟丅东();
    }
    private System.Collections.IEnumerator 丏丒世丕丛七业丑丂(int 不丑与下丅三丑丅七, System.Action 丟丘丙丄丅万丏与丗)
    {
        ImposterVoteResultUi.丑世且丏丑三丅且三 val_1 = new ImposterVoteResultUi.丑世且丏丑三丅且三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .不丑与下丅三丑丅七 = 不丑与下丅三丑丅七;
        }
        else
        {
                mem[32] = this;
            mem[40] = 不丑与下丅三丑丅七;
        }
        
        .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丗丛丏东与上丟三丁(float 丟丞一专丕三东丗一, string 丕丗丘丑丛与丑业丒, UILabel 七丐丞丑丑丕世丙七)
    {
        ImposterVoteResultUi.丝丆丘专丐丄业丕且 val_1 = new ImposterVoteResultUi.丝丆丘专丐丄业丕且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丟丞一专丕三东丗一 = 丟丞一专丕三东丗一;
            .丕丗丘丑丛与丑业丒 = 丕丗丘丑丛与丑业丒;
        }
        else
        {
                mem[56] = this;
            mem[48] = 丟丞一专丕三东丗一;
            mem[40] = 丕丗丘丑丛与丑业丒;
        }
        
        .七丐丞丑丑丕世丙七 = 七丐丞丑丑丕世丙七;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丗丂万丙丌一丁万丏()
    {
        null = null;
        this._animator.ResetTrigger(id:  ImposterVoteResultUi.专丛专丐丗七三丒丄);
        this._animator.ResetTrigger(id:  ImposterVoteResultUi.丄一东不专丏丐七丆);
        this._animator.ResetTrigger(id:  ImposterVoteResultUi.丝上丅丆丅丂丈丏丛);
        this._animator.ResetTrigger(id:  ImposterVoteResultUi.丗一世丂丙一丛丁丞);
        this._animator.ResetTrigger(id:  ImposterVoteResultUi.丗丒丞与业丙丙世丗);
    }
    public void OnPrintTextAnimationEvent()
    {
        this.丂丝专丗业丁丂丆丘 = true;
    }
    public void OnCanExitAnimationEvent()
    {
        this.丑丞丅丘丆丅丏丅丘 = true;
    }
    private void OnDisable()
    {
        if(this.丑丒且丆丌一丌下七 == 0)
        {
                return;
        }
        
        this.丑丒且丆丌一丌下七.丆丅与东丏丈丟丅东();
    }
    public ImposterVoteResultUi()
    {
        this.丅丁下丗丂与三东丞 = new System.Collections.Generic.Dictionary<System.Int32, System.ValueTuple<System.Boolean, System.String, System.String>>();
    }
    private static ImposterVoteResultUi()
    {
        ImposterVoteResultUi.专丛专丐丗七三丒丄 = UnityEngine.Animator.StringToHash(name:  "imposter");
        ImposterVoteResultUi.丄一东不专丏丐七丆 = UnityEngine.Animator.StringToHash(name:  "notImposter");
        ImposterVoteResultUi.丝上丅丆丅丂丈丏丛 = UnityEngine.Animator.StringToHash(name:  "draw");
        ImposterVoteResultUi.丗一世丂丙一丛丁丞 = UnityEngine.Animator.StringToHash(name:  "skip");
        ImposterVoteResultUi.丗丒丞与业丙丙世丗 = UnityEngine.Animator.StringToHash(name:  "exit");
    }
    private bool 七一不丞丂丌东不丁()
    {
        return (bool)this.丂丝专丗业丁丂丆丘;
    }
    private bool 不丞三丏丐丏丗丛丝()
    {
        return (bool)this.丑丞丅丘丆丅丏丅丘;
    }

}
