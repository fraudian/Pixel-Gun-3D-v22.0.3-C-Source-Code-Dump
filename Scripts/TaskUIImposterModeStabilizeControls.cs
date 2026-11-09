using UnityEngine;
internal sealed class TaskUIImposterModeStabilizeControls : TaskUIImposterModeAbstract
{
    // Fields
    private UnityEngine.Transform target;
    private UnityEngine.Transform mover;
    private UiEvents uiEvents;
    private float positionDelta;
    private int xRandomPositionRange;
    private int yRandomPositionRange;
    private UnityEngine.GameObject completeMessage;
    
    // Methods
    protected override void OnEnable()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  false);
        this.uiEvents.add_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  public System.Void TaskUIImposterModeStabilizeControls::OnPointerDown(bool 丙与丈丛丑丘丞三七)));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.uiEvents.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  public System.Void TaskUIImposterModeStabilizeControls::OnPointerDown(bool 丙与丈丛丑丘丞三七)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        System.Random val_2 = new System.Random(Seed:  丐丕不丅三专万丕丗());
        UnityEngine.Vector3 val_3 = this.mover.localPosition;
        this.mover.localPosition = new UnityEngine.Vector3() {x = 1.152922E+18f, y = 1.152922E+18f, z = val_3.z};
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
    
    }
    private void Update()
    {
        if(137129984 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.mover.localPosition;
        UnityEngine.Vector3 val_3 = this.target.localPosition;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.target.localPosition;
        this.mover.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  true);
        this.万丏丛东下丝下丟丕();
    }
    public void OnPointerDown(bool 丙与丈丛丑丘丞三七)
    {
        if(丙与丈丛丑丘丞三七 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_5 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer).ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Matrix4x4 val_7 = this.uiEvents.transform.worldToLocalMatrix;
        this = this.mover;
        this.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public TaskUIImposterModeStabilizeControls()
    {
        this.positionDelta = 0.5f;
        val_1 = new PGBehaviour();
    }

}
