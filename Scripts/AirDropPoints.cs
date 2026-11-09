using UnityEngine;
public class AirDropPoints : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> _listPoints;
    private UnityEngine.GameObject _example;
    
    // Methods
    internal UnityEngine.Vector3 七丘丅丆三不上七丆(UnityEngine.Vector3 丗上下丂万丑上与丌, float 且丛上丕业丂丒与一)
    {
        var val_4;
        System.Collections.Generic.List<UnityEngine.Vector3> val_15;
        float val_19;
        float val_20;
        float val_21;
        int val_22;
        val_15 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_19 = val_1.z;
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        List.Enumerator<T> val_3 = this._listPoints.GetEnumerator();
        float val_6 = 且丛上丕业丂丒与一 * 且丛上丕业丂丒与一;
        label_9:
        if(((-1775381216) & 1) == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_7 = val_4.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丗上下丂万丑上与丌.x, y = 丗上下丂万丑上与丌.y, z = 丗上下丂万丑上与丌.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_8.x = val_8.x * val_8.x;
        val_8.x = val_8.x + (val_8.z * val_8.z);
        if(val_8.x >= 0)
        {
            goto label_9;
        }
        
        val_2.Add(item:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_21 = val_1.y;
        val_20 = val_1.x;
        val_22 = 1152921516206144848;
        if(val_2.Count < 1)
        {
                return new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_19};
        }
        
        val_22 = UnityEngine.Random.Range(min:  0, max:  val_2.Count);
        UnityEngine.Vector3 val_13 = val_2.Item[val_22];
        val_15 = this._listPoints;
        val_20 = val_13.x;
        val_21 = val_13.y;
        val_19 = val_13.z;
        bool val_14 = val_15.Remove(item:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_19});
        return new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_19};
    }
    private void 丌丒丅世丅丙业上丘()
    {
        var val_2;
        List.Enumerator<T> val_1 = this._listPoints.GetEnumerator();
        label_10:
        if(((-1775231312) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_4 = val_2.position;
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._example);
        val_5.SetActive(value:  true);
        val_5.transform.SetParent(p:  this.transform);
        val_5.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丒丛丁专丈东丂且丞()
    {
        var val_17;
        UnityEngine.Object val_18;
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  this.transform.GetComponentsInChildren<UnityEngine.Transform>());
        val_17 = 0;
        goto label_18;
        label_20:
        val_18 = val_4.Item[0].gameObject;
        if(val_18.activeSelf == false)
        {
            goto label_9;
        }
        
        val_18 = val_4.Item[0];
        if((System.String.op_Equality(a:  val_18.tag, b:  "Respawn")) == false)
        {
            goto label_9;
        }
        
        UnityEngine.Vector3 val_12 = val_4.Item[0].position;
        val_1.Add(item:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_18 = val_4.Item[0].gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  val_18);
        val_4.RemoveAt(index:  0);
        goto label_18;
        label_9:
        val_17 = 1;
        label_18:
        if(val_17 < val_4.Count)
        {
            goto label_20;
        }
        
        if(val_1.Count == 0)
        {
                return;
        }
        
        mem[1152921524306682904].Clear();
        mem[1152921524306682904].AddRange(collection:  val_1);
    }
    public AirDropPoints()
    {
        this._listPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }

}
