using UnityEngine;
internal abstract class TaskUIImposterModeFillAbstract : TaskUIImposterModeAbstract
{
    // Fields
    protected Rilisoft.ButtonHandler _buttonHandler;
    protected UIBasicSprite _fillBaseSprite;
    protected float _fillSeconds;
    protected bool 丄东不且丘丏上与业;
    protected float 丅丞丆丘丄丗上丁上;
    
    // Methods
    protected abstract void 丙上东丏丕丐丑丗丛(bool 丆丟专丑丁丒丁上丙); // 0
    protected override void OnEnable()
    {
        this._buttonHandler.add_OnPressed(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void TaskUIImposterModeFillAbstract::丝世丆丏丙丂东丐丕(bool 丆丟专丑丁丒丁上丙)));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this._buttonHandler.remove_OnPressed(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void TaskUIImposterModeFillAbstract::丝世丆丏丙丂东丐丕(bool 丆丟专丑丁丒丁上丙)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this._fillBaseSprite.fillAmount = 0f;
        this.丄东不且丘丏上与业 = false;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.丅丞丆丘丄丗上丁上 = 0f;
    }
    private void 丝世丆丏丙丂东丐丕(bool 丆丟专丑丁丒丁上丙)
    {
        this.丄东不且丘丏上与业 = 丆丟专丑丁丒丁上丙;
        goto typeof(TaskUIImposterModeFillAbstract).__il2cppRuntimeField_1B8;
    }
    private void Update()
    {
        if(W8 != 0)
        {
                return;
        }
        
        if(this.丄东不且丘丏上与业 == false)
        {
                return;
        }
        
        goto typeof(TaskUIImposterModeFillAbstract).__il2cppRuntimeField_1C8;
    }
    protected virtual void 丟丛三专丗丞丌一丕()
    {
        float val_3 = this.丅丞丆丘丄丗上丁上;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_3 = val_3 + val_1;
        this.丅丞丆丘丄丗上丁上 = val_3;
        val_1 = val_3 / this._fillSeconds;
        this._fillBaseSprite.fillAmount = UnityEngine.Mathf.Clamp01(value:  val_1);
        if(this.丅丞丆丘丄丗上丁上 < this._fillSeconds)
        {
                return;
        }
        
        mem[1152921537586420184] = 1;
        this.万丏丛东下丝下丟丕();
    }
    protected TaskUIImposterModeFillAbstract()
    {
        this._fillSeconds = 10f;
        val_1 = new PGBehaviour();
    }

}
