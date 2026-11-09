using UnityEngine;
internal class WatchForMobAndSpawn : MonoBehaviour
{
    // Fields
    private float 丒万一七丁上丅丁世;
    private float 丟丈丕上丒上丌丗世;
    private UnityEngine.GameObject 一丞世丈上丒万丈丕;
    
    // Methods
    private void Start()
    {
        this.丟丕丏专专丙专丂丗();
        this.丟丈丕上丒上丌丗世 = this.丒万一七丁上丅丁世;
        Player_move_c.丛丝丄不丟丛丅七丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WatchForMobAndSpawn::丟丕丏专专丙专丂丗()));
    }
    private void OnDestroy()
    {
        Player_move_c.丁一丗世丄丑丞丄七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WatchForMobAndSpawn::丟丕丏专专丙专丂丗()));
    }
    private void Update()
    {
        if(this.一丞世丈上丒万丈丕 != 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丟丈丕上丒上丌丗世 - val_2;
        this.丟丈丕上丒上丌丗世 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        this.丟丕丏专专丙专丂丗();
    }
    private void 丟丕丏专专丙专丂丗()
    {
        System.String[] val_11;
        var val_12;
        if(this.一丞世丈上丒万丈丕 != 0)
        {
                return;
        }
        
        this.丟丈丕上丒上丌丗世 = this.丒万一七丁上丅丁世;
        if((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一())) == null)
        {
            goto label_8;
        }
        
        val_11 = val_3.万丕业丅丝丁丑专丙;
        if(val_11 != null)
        {
            goto label_9;
        }
        
        label_8:
        val_11 = new string[1];
        val_11[0] = "1";
        label_9:
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Vector3 val_7 = val_6.丈丐七丙丗丅丁专丂(丟不丄不三不东业丆:  val_6);
        val_12 = null;
        val_12 = null;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        this.一丞世丈上丒万丈丕 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  Item[UnityEngine.Random.Range(min:  0, max:  val_4.Length)], position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
    }
    private UnityEngine.Vector3 丈丐七丙丗丅丁专丂(UnityEngine.GameObject 丟不丄不三不东业丆)
    {
        UnityEngine.BoxCollider val_1 = 丟不丄不三不东业丆.GetComponent<UnityEngine.BoxCollider>();
        UnityEngine.Vector3 val_2 = val_1.size;
        UnityEngine.Vector3 val_4 = 丟不丄不三不东业丆.transform.localScale;
        UnityEngine.Vector3 val_5 = val_1.size;
        UnityEngine.Vector3 val_7 = 丟不丄不三不东业丆.transform.localScale;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_2.x * val_4.x, y:  val_5.z * val_7.z);
        UnityEngine.Vector3 val_12 = 丟不丄不三不东业丆.transform.position;
        UnityEngine.Vector3 val_14 = 丟不丄不三不东业丆.transform.position;
        float val_23 = 0.5f;
        float val_15 = val_10.x * val_23;
        val_15 = val_12.x - val_15;
        val_23 = val_10.y * val_23;
        val_23 = val_14.z - val_23;
        float val_16 = 0.x;
        UnityEngine.Vector3 val_19 = 丟不丄不三不东业丆.transform.position;
        float val_21 = val_16 + (UnityEngine.Random.Range(min:  0f, max:  val_16));
        float val_22 = val_19.x + (UnityEngine.Random.Range(min:  0f, max:  val_19.x));
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public WatchForMobAndSpawn()
    {
        this.丒万一七丁上丅丁世 = 25f;
    }

}
