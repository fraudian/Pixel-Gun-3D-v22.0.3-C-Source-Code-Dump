using UnityEngine;
internal class TaskUIImposterBuildPath : TaskUIImposterModeAbstract
{
    // Fields
    public IMDragAndDrop ship;
    public UnityEngine.Transform shipTexture;
    internal StretchAnchor lineForShip;
    public System.Collections.Generic.List<IMPath> paths;
    public int currentIndexPaths;
    public int currentIndexPoint;
    public UnityEngine.AudioClip CheckPointClip;
    public UnityEngine.AudioSource audioSource;
    private IMBuildPathPoint 丗丘丌世丁业一丏丐;
    
    // Properties
    private IMBuildPathPoint 不丘且丘专与丐丄丂 { get; }
    private int 丅专三丝丆上丂丁丐 { get; }
    
    // Methods
    private IMBuildPathPoint 丏丒丁且丌下万丄丆()
    {
        IMPath val_1 = this.paths.Item[this.currentIndexPaths];
        if(val_1.pathPoints != null)
        {
                return val_1.pathPoints.Item[this.currentIndexPoint];
        }
        
        return val_1.pathPoints.Item[this.currentIndexPoint];
    }
    private int 东丅丏丛下丐与上万()
    {
        IMPath val_1 = this.paths.Item[this.currentIndexPaths];
        if(val_1.pathPoints != null)
        {
                return val_1.pathPoints.Count;
        }
        
        return val_1.pathPoints.Count;
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        goto typeof(TaskUIImposterBuildPath).__il2cppRuntimeField_178;
    }
    private void OnEnable()
    {
        goto typeof(TaskUIImposterBuildPath).__il2cppRuntimeField_178;
    }
    private void 丒丏丂丏专丐丙且丞()
    {
        var val_3;
        var val_7;
        var val_8;
        List.Enumerator<T> val_1 = this.paths.GetEnumerator();
        val_7 = 0;
        val_8 = 0;
        var val_7 = 0;
        label_18:
        if(((-1341431904) & 1) == 0)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_5 = X22.GetEnumerator();
        label_7:
        if(((-1341431936) & 1) == 0)
        {
            goto label_5;
        }
        
        val_3.丐丏七丌丕丗业且上().不与丁丕丒丄上三丟();
        goto label_7;
        label_5:
        val_7 = val_7 + 1;
        mem2[0] = 73;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_7 != 1) && ((1152921537625153360 + ((0 + 1)) << 2) == 73))
        {
                var val_8 = 0;
            val_8 = val_8 ^ (val_7 >> 31);
            val_7 = val_7 + val_8;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_18;
        label_2:
        val_7 = val_7 + 1;
        mem2[0] = 105;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_7 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921537625153360 + ((0 + 1)) << 2) == 105)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 丌丞下丏丙丑与业专()
    {
        this.丒丏丂丏专丐丙且丞();
        int val_2 = UnityEngine.Random.Range(min:  0, max:  this.paths.Count);
        this.currentIndexPaths = val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.paths.Item[val_2], 丏业丟一东丂东丘丛:  true);
    }
    private void 上与万丑世丞丁丅丒()
    {
        int val_1 = this.currentIndexPoint;
        val_1 = val_1 + 1;
        this.currentIndexPoint = val_1;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        int val_5;
        this.丌丞下丏丙丑与业专();
        val_5 = this.currentIndexPoint;
        if(val_5 >= 1)
        {
                var val_5 = 0;
            do
        {
            IMPath val_1 = this.paths.Item[this.currentIndexPaths];
            val_1.pathPoints.Item[0].万且丄上三丝东丗丙();
            IMPath val_3 = this.paths.Item[this.currentIndexPaths];
            val_3.pathPoints.Item[0].与七且三丌丁丒专丑();
            val_5 = this.currentIndexPoint;
            val_5 = val_5 + 1;
        }
        while(val_5 < val_5);
        
        }
        
        val_5 = val_5 - 1;
        val_5 = val_5 & (~(val_5 >> 31));
        this.currentIndexPoint = val_5;
        this.丅且专业丘丟丅丝丑();
    }
    private void 丅且专业丘丟丅丝丑()
    {
        UnityEngine.GameObject val_46;
        UnityEngine.GameObject val_47;
        UnityEngine.GameObject val_48;
        var val_49;
        val_46 = this;
        IMBuildPathPoint val_1 = this.丏丒丁且丌下万丄丆();
        if(val_1 != 0)
        {
                val_1.万且丄上三丝东丗丙();
        }
        
        val_1.与七且三丌丁丒专丑();
        this.丗丘丌世丁业一丏丐 = val_1;
        if((this.currentIndexPoint + 1) >= this.东丅丏丛下丐与上万())
        {
            goto label_6;
        }
        
        int val_45 = this.currentIndexPoint;
        val_45 = val_45 + 1;
        this.currentIndexPoint = val_45;
        if(val_45 == 0)
        {
            goto label_8;
        }
        
        if(this.ship == null)
        {
            goto label_9;
        }
        
        val_47 = this.ship.gameObject;
        goto label_10;
        label_6:
        if(this.ship == null)
        {
            goto label_11;
        }
        
        val_48 = this.ship.gameObject;
        goto label_12;
        label_8:
        val_49 = 0;
        goto label_13;
        label_11:
        val_48 = 0.gameObject;
        label_12:
        this.ship.StopDragging(丝三丁东丈丒世丅业:  val_48);
        this.currentIndexPoint = 0;
        this.万丏丛东下丝下丟丕();
        return;
        label_9:
        val_47 = 0.gameObject;
        label_10:
        this.ship.StopDragging(丝三丁东丈丒世丅业:  val_47);
        val_49 = 1;
        label_13:
        this.ship.transform.SetParent(p:  val_1.path);
        this.ship._widget = val_1.path.GetComponent<UIWidget>();
        this.ship.丌七丏且不丘丗东丅();
        UnityEngine.Matrix4x4 val_13 = this.ship._widget.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_19 = val_1.transform.position;
        this.ship.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Matrix4x4 val_21 = this.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_27 = this.ship.transform.position;
        UnityEngine.Matrix4x4 val_29 = this.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_36 = this.丏丒丁且丌下万丄丆().transform.position;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
        UnityEngine.Vector3 val_40 = this.丏丒丁且丌下万丄丆().transform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        UnityEngine.Quaternion val_43 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (val_40.y * 57.29578f) + 90f);
        this.shipTexture.rotation = new UnityEngine.Quaternion() {x = val_43.x, y = val_43.y, z = val_43.z, w = val_43.w};
        if(val_49 != 0)
        {
                this.ship.StartDragging();
        }
        
        val_48 = this.lineForShip;
        val_46 = val_1.gameObject;
        this.lineForShip._leftAnchor = val_46;
    }
    private void Update()
    {
        if(this.丏丒丁且丌下万丄丆() == 0)
        {
                return;
        }
        
        UnityEngine.Matrix4x4 val_4 = this.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_10 = this.ship.transform.position;
        UnityEngine.Matrix4x4 val_12 = this.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_19 = this.丏丒丁且丌下万丄丆().transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z})) >= 0)
        {
                return;
        }
        
        this.丅且专业丘丟丅丝丑();
        if(this.CheckPointClip == 0)
        {
                return;
        }
        
        this = this.CheckPointClip;
        this.audioSource.PlayOneShot(clip:  this);
    }
    public TaskUIImposterBuildPath()
    {
        this.paths = new System.Collections.Generic.List<IMPath>();
        this = new PGBehaviour();
    }

}
