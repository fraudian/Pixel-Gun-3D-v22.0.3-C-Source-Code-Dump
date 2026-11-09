using UnityEngine;
public class RayAndExplosionsStackController : MonoBehaviour
{
    // Fields
    internal static RayAndExplosionsStackController 丄丞丁丈与业上丞丟;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.GameObject>> 丑一七七丕世丒一丄;
    private System.Collections.Generic.Dictionary<string, float> 丙与丐丒上七世与丐;
    public UnityEngine.Transform mytranform;
    
    // Methods
    private void Awake()
    {
        RayAndExplosionsStackController.丄丞丁丈与业上丞丟 = this;
        this.mytranform = this.GetComponent<UnityEngine.Transform>();
    }
    public UnityEngine.GameObject GetObjectFromName(string 丛丟丒且丌丂丗丑丞)
    {
        string val_26;
        var val_27;
        UnityEngine.Object val_28;
        UnityEngine.Object val_29;
        val_26 = 丛丟丒且丌丂丗丑丞;
        if((this.丑一七七丕世丒一丄.ContainsKey(key:  val_26)) == false)
        {
            goto label_16;
        }
        
        val_27 = 1152921536056324528;
        goto label_3;
        label_13:
        if(this.丑一七七丕世丒一丄.Item[val_26].Item[0] != 0)
        {
            goto label_8;
        }
        
        this.丑一七七丕世丒一丄.Item[val_26].RemoveAt(index:  0);
        label_3:
        if(this.丑一七七丕世丒一丄.Item[val_26].Count >= 1)
        {
            goto label_13;
        }
        
        label_8:
        if(this.丑一七七丕世丒一丄.Item[val_26].Count < 1)
        {
            goto label_16;
        }
        
        val_28 = this.丑一七七丕世丒一丄.Item[val_26].Item[0];
        this.丑一七七丕世丒一丄.Item[val_26].RemoveAt(index:  0);
        val_28.SetActive(value:  true);
        goto label_37;
        label_16:
        UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  val_26);
        if(val_13 != null)
        {
                var val_14 = (null == null) ? (val_13) : 0;
        }
        else
        {
                val_29 = 0;
        }
        
        val_27 = 1152921504848912384;
        val_28 = 0;
        if(val_29 != 0)
        {
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  10000f);
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.identity;
            val_28 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_29, position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, rotation:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w});
            val_28.GetComponent<UnityEngine.Transform>().parent = this.mytranform;
            if((val_28.GetComponent<RayAndExplosionsStackItem>()) != 0)
        {
                val_21.myName = val_26;
        }
        
        }
        
        label_37:
        if(val_28 != 0)
        {
                return (UnityEngine.GameObject)val_28;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return (UnityEngine.GameObject)val_28;
        }
        
        val_26 = "GameOblect " + val_26 + " in RayAndExplosionsStackController not create!!!"(" in RayAndExplosionsStackController not create!!!");
        UnityEngine.Debug.LogError(message:  val_26);
        return (UnityEngine.GameObject)val_28;
    }
    public void ReturnObjectFromName(UnityEngine.GameObject 丆且丑丗丛丄丕丂丄, string 丛丟丒且丌丂丗丑丞)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  10000f);
        丆且丑丗丛丄丕丂丄.GetComponent<UnityEngine.Transform>().position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        if(丆且丑丗丛丄丕丂丄 != null)
        {
                丆且丑丗丛丄丕丂丄.SetActive(value:  false);
        }
        else
        {
                0.SetActive(value:  false);
        }
        
        丆且丑丗丛丄丕丂丄.transform.parent = this.mytranform;
        if((this.丑一七七丕世丒一丄.ContainsKey(key:  丛丟丒且丌丂丗丑丞)) != true)
        {
                this.丑一七七丕世丒一丄.Add(key:  丛丟丒且丌丂丗丑丞, value:  new System.Collections.Generic.List<UnityEngine.GameObject>());
        }
        
        bool val_7 = this.丙与丐丒上七世与丐.ContainsKey(key:  丛丟丒且丌丂丗丑丞);
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        if(this.丙与丐丒上七世与丐 == null)
        {
            goto label_12;
        }
        
        if(val_7 == false)
        {
            goto label_13;
        }
        
        label_15:
        this.丙与丐丒上七世与丐.set_Item(key:  丛丟丒且丌丂丗丑丞, value:  val_8);
        goto label_14;
        label_12:
        if(val_7 == true)
        {
            goto label_15;
        }
        
        label_13:
        this.丙与丐丒上七世与丐.Add(key:  丛丟丒且丌丂丗丑丞, value:  val_8);
        label_14:
        this.丑一七七丕世丒一丄.Item[丛丟丒且丌丂丗丑丞].Add(item:  丆且丑丗丛丄丕丂丄);
    }
    private void OnDestroy()
    {
        RayAndExplosionsStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public RayAndExplosionsStackController()
    {
        this.丑一七七丕世丒一丄 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<UnityEngine.GameObject>>();
        this.丙与丐丒上七世与丐 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
    }

}
