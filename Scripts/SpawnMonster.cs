using UnityEngine;
public class SpawnMonster : MonoBehaviour
{
    // Fields
    private float 丞东不丙万丒世且万;
    private float 上丗且丙丂丕丙丑丑;
    private float 丑丟丑丑万下一不丈;
    private UnityEngine.GameObject 丐丒丅丗丏上一丏丅;
    private UnityEngine.Rect 丏丒丑万丟七丆丛丑;
    private UnityEngine.AI.NavMeshAgent 丅丞丅丛丄丄丏丆丗;
    private Sounds 丁一世丈下上与丅七;
    private UnityEngine.Vector2 下丄丘丘丁丘丌专且;
    public UnityEngine.GameObject[] _targetCyclePoints;
    private int 丈丝三丑下与万专丗;
    private UnityEngine.Vector3 三丌上七丙丌丅一丘;
    private float 世丐丛丏一丝三下丂;
    private float 丐世世丄丄丈下丗专;
    public bool isCycle;
    public bool shouldMove;
    
    // Properties
    public bool 丝丛下万丅丐七丐丟 { get; set; }
    
    // Methods
    public bool get_ShouldMove()
    {
        return (bool)this.shouldMove;
    }
    public void set_ShouldMove(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.shouldMove == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.shouldMove = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.丈丝三丑下与万专丗 = 0;
        this.上丗且丙丂丕丙丑丑 = -1f;
        this.SendMessage(methodName:  "Walk");
    }
    private void Awake()
    {
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        var val_17;
        var val_20;
        var val_21;
        this.丅丞丅丛丄丄丏丆丗 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_12;
        label_7:
        val_20 = 0;
        val_21 = 0;
        goto label_13;
        label_12:
        if(val_3.Current == null)
        {
            goto label_14;
        }
        
        val_17 = (System.Object.__il2cppRuntimeField_typeHierarchy + (UnityEngine.Transform.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8;
        if(val_17 == null)
        {
            goto label_16;
        }
        
        label_14:
        label_16:
        val_20 = 0;
        val_21 = 0;
        this.丐丒丅丗丏上一丏丅 = 0.gameObject;
        label_13:
        if(val_3 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_3.Dispose();
        }
        
        if(val_20 == 1)
        {
            goto label_22;
        }
        
        if((val_21 == 0) || (79 == 79))
        {
            goto label_32;
        }
        
        label_31:
        label_32:
        this.丁一世丈下上与丅七 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        if(this.isCycle != true)
        {
                UnityEngine.Vector3 val_14 = this.transform.position;
            UnityEngine.Vector3 val_16 = this.transform.position;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_14.x, y:  val_16.z);
            this.下丄丘丘丁丘丌专且 = val_17.x;
            mem[1152921539182126612] = val_17.y;
        }
        
        if(this.shouldMove != false)
        {
                this.shouldMove = false;
        }
        
        this.ShouldMove = true;
        float val_18 = this.丐世世丄丄丈下丗专 + this.丐世世丄丄丈下丗专;
        this.丏丒丑万丟七丆丛丑 = 0;
        mem[1152921539182126580] = 0;
        mem[1152921539182126588] = 0;
        return;
        label_22:
        if(val_21 != 0)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    private void Update()
    {
        UnityEngine.AI.NavMeshAgent val_16;
        float val_17;
        val_16 = this;
        if(this.shouldMove == false)
        {
                return;
        }
        
        val_17 = this.上丗且丙丂丕丙丑丑;
        if(val_17 > UnityEngine.Time.time)
        {
                return;
        }
        
        this.丅丞丅丛丄丄丏丆丗.ResetPath();
        UnityEngine.Vector3 val_5 = this.transform.position;
        float val_8 = (UnityEngine.Random.Range(min:  0f, max:  this.丐世世丄丄丈下丗专 + this.丐世世丄丄丈下丗专)) - this.丐世世丄丄丈下丗专;
        float val_9 = (UnityEngine.Random.Range(min:  0f, max:  this.丐世世丄丄丈下丗专 + this.丐世世丄丄丈下丗专)) - this.丐世世丄丄丈下丗专;
        this.三丌上七丙丌丅一丘 = 0;
        mem[1152921539182308316] = 0;
        UnityEngine.Vector3 val_12 = this.transform.position;
        float val_13 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = V12.16B, z = this.丐世世丄丄丈下丗专});
        float val_16 = this.丁一世丈下上与丅七.notAttackingSpeed;
        val_16 = val_13 / val_16;
        val_16 = UnityEngine.Time.time + val_16;
        val_16 = this.世丐丛丏一丝三下丂 + val_16;
        this.上丗且丙丂丕丙丑丑 = val_16;
        this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_13, z = val_12.y});
        bool val_15 = this.丅丞丅丛丄丄丏丆丗.SetDestination(target:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_13, z = val_12.y});
        val_16 = this.丅丞丅丛丄丄丏丆丗;
        val_17 = this.丁一世丈下上与丅七.notAttackingSpeed;
        val_16.speed = val_17;
    }
    private void 七上丆丕与丘丏七丈()
    {
        this.丈丝三丑下与万专丗 = 0;
        this.上丗且丙丂丕丙丑丑 = -1f;
    }
    public SpawnMonster()
    {
        this.上丗且丙丂丕丙丑丑 = -1f;
        this.丑丟丑丑万下一不丈 = 5f;
        this.世丐丛丏一丝三下丂 = 2f;
        this.丐世世丄丄丈下丗专 = 17f;
        this.shouldMove = true;
    }

}
