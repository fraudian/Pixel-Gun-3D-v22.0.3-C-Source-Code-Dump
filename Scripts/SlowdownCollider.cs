using UnityEngine;
public class SlowdownCollider : MonoBehaviour
{
    // Fields
    public float slowCoef;
    private const string 上七丅丏丒丐七丆上 = "BodyCollider";
    private const string 下专三专丁丙七东丏 = "Water";
    public bool slowdownZoneTrigger;
    
    // Methods
    private void Awake()
    {
        var val_21;
        UnityEngine.GameObject val_22;
        val_21 = this;
        if(this.slowdownZoneTrigger == true)
        {
                return;
        }
        
        if(this.transform.parent != 0)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.transform.parent.GetComponent<SlowdownCollider>())) == true)
        {
                return;
        }
        
        }
        
        UnityEngine.Object val_8 = UnityEngine.Resources.Load(path:  "SlowdownZoneTrigger");
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
        if(val_8 != null)
        {
                var val_14 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_22, position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, parent:  this.transform);
        UnityEngine.Vector3 val_18 = this.GetComponent<UnityEngine.BoxCollider>().size;
        val_15.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        val_21 = val_15.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
        val_21.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        UnityEngine.Object val_12;
        if(this.slowdownZoneTrigger == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丆丛丂丝丄世且丛丕.tag, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_12 = 0;
        if(丆丛丂丝丄世且丛丕.transform.parent != 0)
        {
                val_12 = 丆丛丂丝丄世且丛丕.transform.parent.GetComponent<FirstPersonControlSharp>();
        }
        
        if(val_12 == 0)
        {
                return;
        }
        
        val_8.slowdownList.Add(item:  this);
        if((System.String.op_Equality(a:  this.tag, b:  "Water")) == false)
        {
                return;
        }
        
        val_8.丅丁丝丞丄丏三丌三 = true;
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_17;
        SlowdownCollider val_18;
        UnityEngine.Object val_19;
        val_17 = 丆丛丂丝丄世且丛丕;
        val_18 = this;
        if(this.slowdownZoneTrigger == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_17.tag, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_19 = 0;
        if(val_17.transform.parent != 0)
        {
                val_19 = val_17.transform.parent.GetComponent<FirstPersonControlSharp>();
        }
        
        if(val_19 == 0)
        {
                return;
        }
        
        bool val_10 = val_8.slowdownList.Remove(item:  this);
        val_17 = "Water";
        if((System.String.op_Equality(a:  this.tag, b:  "Water")) == false)
        {
                return;
        }
        
        val_18 = val_8.slowdownList;
        val_8.丅丁丝丞丄丏三丌三 = false;
        List.Enumerator<T> val_13 = val_18.GetEnumerator();
        label_21:
        if((883450712 & 1) == 0)
        {
            goto label_19;
        }
        
        val_18 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_18.tag, b:  "Water")) == false)
        {
            goto label_21;
        }
        
        val_8.丅丁丝丞丄丏三丌三 = true;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public SlowdownCollider()
    {
        this.slowCoef = 0.5f;
    }

}
