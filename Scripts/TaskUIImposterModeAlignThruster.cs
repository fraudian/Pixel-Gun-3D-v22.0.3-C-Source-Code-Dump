using UnityEngine;
internal sealed class TaskUIImposterModeAlignThruster : TaskUIImposterModeAbstract
{
    // Fields
    private UISlider _slider;
    private UnityEngine.Transform _thruster;
    private UnityEngine.Transform _controlLine;
    private UnityEngine.GameObject _successIndicator;
    private UIWidget[] _thrusterSprites;
    private UnityEngine.Color 万丌不七丂东上东丒;
    private UnityEngine.Color 丟一丌丅丕不一丘专;
    private System.Random 世丙丄丐世专丌下丁;
    private float 东丛丂丘丏世世丌丗;
    private float _linesThreshold;
    
    // Methods
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.世丙丄丐世专丌下丁 = new System.Random(Seed:  丐丕不丅三专万丕丗());
        this.东丛丂丘丏世世丌丗 = (float)D0;
        goto typeof(TaskUIImposterModeAlignThruster).__il2cppRuntimeField_178;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this._slider.value = this.东丛丂丘丏世世丌丗;
        this.UpdateThrusterRotation();
    }
    protected override void Awake()
    {
        if(this._thrusterSprites.Length == 0)
        {
                return;
        }
        
        UnityEngine.Color val_1 = this._thrusterSprites[0].color;
        this.万丌不七丂东上东丒 = val_1;
        mem[1152921537576121868] = val_1.g;
        mem[1152921537576121872] = val_1.b;
        mem[1152921537576121876] = val_1.a;
    }
    protected override void OnEnable()
    {
        mem2[0] = new UIProgressBar.丒丗丝专丝下且业与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TaskUIImposterModeAlignThruster::丒丗丝专丝下且业与());
        this.OnEnable();
    }
    private void 丒丗丝专丝下且业与()
    {
        if(this.三丞与一下东与丒丗() == false)
        {
                return;
        }
        
        this.万丏丛东下丝下丟丕();
    }
    protected override void OnDisable()
    {
        mem2[0] = 0;
    }
    public void UpdateThrusterRotation()
    {
        float val_1 = this._slider.value;
        float val_2 = -45f;
        val_1 = val_1 * 90f;
        val_2 = val_1 + val_2;
        this._thruster.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 且丝丕丌丝世丝世业()
    {
        var val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._successIndicator, 丏业丟一东丂东丘丛:  this.三丞与一下东与丒丗());
        val_8 = 0;
        goto label_3;
        label_9:
        bool val_3 = this.三丞与一下东与丒丗();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._thrusterSprites[0], 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = (val_3 != true) ? this.丟一丌丅丕不一丘专 : this.万丌不七丂东上东丒, g = (val_3 != true) ? 1152921537576883612 : 1152921537576883596, b = (val_3 != true) ? 1152921537576883616 : 1152921537576883600, a = (val_3 != true) ? 1152921537576883620 : 1152921537576883604});
        val_8 = 1;
        label_3:
        if(val_8 < this._thrusterSprites.Length)
        {
            goto label_9;
        }
    
    }
    private bool 三丞与一下东与丒丗()
    {
        UnityEngine.Quaternion val_1 = this._controlLine.localRotation;
        UnityEngine.Quaternion val_2 = this._thruster.localRotation;
        return (bool)((UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, b:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w})) <= this._linesThreshold) ? 1 : 0;
    }
    private void Update()
    {
        this.UpdateThrusterRotation();
        this.且丝丕丌丝世丝世业();
    }
    public TaskUIImposterModeAlignThruster()
    {
        this.丟一丌丅丕不一丘专 = 0;
        mem[1152921537577317916] = 0;
        mem[1152921537577317924] = 0;
        this = new PGBehaviour();
    }

}
