using UnityEngine;
public class KeepLayer : PGBehaviour
{
    // Fields
    public string layer;
    
    // Methods
    private void OnEnable()
    {
        this.丘丘与上东丕一丌不();
    }
    private void Update()
    {
        this.丘丘与上东丕一丌不();
    }
    private void 丘丘与上东丕一丌不()
    {
        if(this.丅与丌专丟一丝业三().layer == (UnityEngine.LayerMask.NameToLayer(layerName:  this.layer)))
        {
                return;
        }
        
        KeepLayer.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丁东丑丞与下丛丐东:  UnityEngine.LayerMask.NameToLayer(layerName:  this.layer));
    }
    internal static void 世丙丆业世丝与丝七(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丁东丑丞与下丛丐东)
    {
        var val_3;
        goto label_2;
        label_7:
        val_3 = 丝三丁东丈丒世丅业.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true)[0].gameObject;
        val_3.layer = 丁东丑丞与下丛丐东;
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_7;
        }
    
    }
    public KeepLayer()
    {
        this.layer = "Layer Name";
    }

}
