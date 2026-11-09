using UnityEngine;
internal sealed class FortFieldItemPlace : MonoBehaviour
{
    // Fields
    internal string subcategory;
    internal System.Collections.Generic.List<UnityEngine.Transform> places;
    internal System.Collections.Generic.List<UnityEngine.GameObject> objects;
    
    // Methods
    internal void 丏丁丏丗丄万业丑丁(UnityEngine.GameObject 丝丄丈丈业丆丘且丁, int 丞世不丒下上上丝丑)
    {
        if(this.objects.Count <= 丞世不丒下上上丝丑)
        {
                var val_3 = this.objects.Count;
            if(val_3 <= 丞世不丒下上上丝丑)
        {
                do
        {
            1152921519068977584 = this.objects;
            1152921519068977584.Add(item:  0);
            val_3 = val_3 + 1;
        }
        while(val_3 <= 丞世不丒下上上丝丑);
        
        }
        
        }
        
        this.objects.set_Item(index:  丞世不丒下上上丝丑, value:  丝丄丈丈业丆丘且丁);
    }
    internal void 丏与丘不丅世世丒一(int 丞世不丒下上上丝丑)
    {
        if(this.objects.Count <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.objects.Item[丞世不丒下上上丝丑].gameObject);
    }
    public FortFieldItemPlace()
    {
        this.places = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.objects = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
