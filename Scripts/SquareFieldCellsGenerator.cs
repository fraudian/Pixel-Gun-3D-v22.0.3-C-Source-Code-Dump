using UnityEngine;
public class SquareFieldCellsGenerator : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _baseCell;
    
    // Methods
    private void OnEnable()
    {
        if(this._baseCell == 0)
        {
                return;
        }
        
        var val_11 = 0;
        do
        {
            var val_10 = 0;
            do
        {
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._baseCell);
            val_2.transform.SetParent(p:  this.transform);
            val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_2.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            val_10 = val_10 + 1;
        }
        while(val_10 != 20);
        
            val_11 = val_11 + 1;
        }
        while(val_11 != 20);
    
    }
    private void OnDisable()
    {
        int val_2 = this.transform.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        int val_3 = val_2 + 1;
        do
        {
            UnityEngine.Object.DestroyImmediate(obj:  this.transform.GetChild(index:  val_3 - 2).gameObject);
            val_3 = val_3 - 1;
        }
        while(val_3 > 1);
    
    }
    public SquareFieldCellsGenerator()
    {
    
    }

}
