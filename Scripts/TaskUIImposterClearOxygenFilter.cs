using UnityEngine;
internal class TaskUIImposterClearOxygenFilter : TaskUIImposterModeAbstract
{
    // Fields
    public UnityEngine.Transform transfromEndDrag;
    public UIWidget activeZone;
    public UIWidget spawnZone;
    public System.Collections.Generic.List<IMDragAndDrop> leafsTypes;
    public float dropDistance;
    public UnityEngine.AudioClip leafDropClip;
    public UnityEngine.AudioSource audioSource;
    public int maxLeafs;
    internal System.Collections.Generic.List<IMDragAndDrop> 万丙丛三丂丒丄丌丝;
    private bool 下上丐万丅丘丏不丂;
    
    // Methods
    protected override void 丗下丗丕丂丈万七丛()
    {
        goto typeof(TaskUIImposterClearOxygenFilter).__il2cppRuntimeField_178;
    }
    private void Start()
    {
        System.Collections.Generic.List<IMDragAndDrop> val_3;
        this.audioSource.loop = false;
        val_3 = this.leafsTypes;
        List.Enumerator<T> val_1 = val_3.GetEnumerator();
        label_6:
        if(((-1338108136) & 1) == 0)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.MonoBehaviour val_17;
        if(this.下上丐万丅丘丏不丂 == true)
        {
                return;
        }
        
        int val_14 = UnityEngine.Random.Range(min:  3, max:  this.maxLeafs);
        if(null == null)
        {
                val_14 = 0;
        }
        
        if(null <= 2)
        {
                val_15 = 0;
        }
        
        if(null == null)
        {
                val_16 = 0;
        }
        
        val_17 = this.spawnZone;
        if(val_14 >= 1)
        {
                do
        {
            val_17 = UnityEngine.Object.Instantiate<IMDragAndDrop>(original:  this.leafsTypes.Item[UnityEngine.Random.Range(min:  0, max:  this.leafsTypes.Count)], parent:  this.spawnZone.transform);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_17, 丏业丟一东丂东丘丛:  true);
            float val_8 = UnityEngine.Random.Range(min:  V8.16B, max:  V9.16B);
            float val_9 = UnityEngine.Random.Range(min:  V10.16B, max:  V11.16B);
            val_17.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_11 = UnityEngine.Random.Range(min:  0f, max:  360f);
            val_17.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_17.transform.SetParent(p:  this.activeZone.transform);
            if(val_17 != null)
        {
                val_6._widget = this.activeZone;
        }
        else
        {
                mem[144] = this.activeZone;
        }
        
            val_17.丌七丏且不丘丗东丅();
            this.万丙丛三丂丒丄丌丝.Add(item:  val_17);
            val_14 = val_14 - 1;
        }
        while(val_14 != 0);
        
        }
        
        this.下上丐万丅丘丏不丂 = true;
    }
    private void Update()
    {
        var val_4;
        var val_5;
        int val_17;
        var val_18;
        if(this.下上丐万丅丘丏不丂 == false)
        {
                return;
        }
        
        if(this.万丙丛三丂丒丄丌丝.Count < 1)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_3 = this.万丙丛三丂丒丄丌丝.GetEnumerator();
        val_17 = 1152921537628458112;
        label_19:
        if(((-1337685584) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_8 = val_6.transform.localPosition;
        UnityEngine.Vector3 val_9 = this.transfromEndDrag.localPosition;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) > this.dropDistance)
        {
            goto label_19;
        }
        
        val_2.Add(item:  this.万丙丛三丂丒丄丌丝.IndexOf(item:  val_6));
        UnityEngine.Object.Destroy(obj:  val_6.gameObject);
        if(this.leafDropClip == 0)
        {
            goto label_19;
        }
        
        this.audioSource.PlayOneShot(clip:  this.leafDropClip);
        goto label_19;
        label_3:
        this.下上丐万丅丘丏不丂 = false;
        this.万丏丛东下丝下丟丕();
        return;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_18 = 0;
        goto label_35;
        label_39:
        val_17 = val_2.Item[0];
        this.万丙丛三丂丒丄丌丝.RemoveAt(index:  val_17);
        val_18 = 1;
        label_35:
        if(val_18 < val_2.Count)
        {
            goto label_39;
        }
    
    }
    public TaskUIImposterClearOxygenFilter()
    {
        this.leafsTypes = new System.Collections.Generic.List<IMDragAndDrop>();
        this.dropDistance = 50f;
        this.maxLeafs = 3;
        this.万丙丛三丂丒丄丌丝 = new System.Collections.Generic.List<IMDragAndDrop>();
        this = new PGBehaviour();
    }

}
