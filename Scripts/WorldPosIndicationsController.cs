using UnityEngine;
internal class WorldPosIndicationsController : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform baseItemsRoot;
    private UnityEngine.Transform createdItemsRoot;
    internal static WorldPosIndicationsController 丄丘七三上丕世丞业;
    private System.Collections.Generic.Dictionary<System.Type, UnityEngine.GameObject> 丒丄丟丌下丌丗丌丆;
    internal UnityEngine.Texture[] 下丘丌万丈丌专三与;
    public UnityEngine.Texture markEnemyTexture;
    
    // Methods
    private void Awake()
    {
        var val_14;
        System.Type val_15;
        WorldPosIndicationsController.丄丘七三上丕世丞业 = this;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((UnityEngine.Resources.Load<WorldPosIndicationsIcons>(path:  "WorldPosIndications/WorldPosIndicationsIcons_"("WorldPosIndications/WorldPosIndicationsIcons_") + GameConnect.丑丌丛丈丅丅与不业().ToString())) != 0)
        {
                this.下丘丌万丈丌专三与 = val_4.icons;
        }
        
        val_14 = 0;
        goto label_9;
        label_21:
        WorldPosIndicationItem val_7 = this.baseItemsRoot.GetChild(index:  0).GetComponent<WorldPosIndicationItem>();
        if(val_7 != 0)
        {
                val_7.gameObject.SetActive(value:  false);
            if(val_7 != null)
        {
                val_15 = val_7.GetType();
        }
        else
        {
                val_15 = 0.GetType();
        }
        
            this.丒丄丟丌下丌丗丌丆.Add(key:  val_15, value:  val_7.gameObject);
        }
        
        val_14 = 1;
        label_9:
        if(val_14 < this.baseItemsRoot.childCount)
        {
            goto label_21;
        }
    
    }
    private void OnDestroy()
    {
        WorldPosIndicationsController.丄丘七三上丕世丞业 = 0;
    }
    public T CreateItem<T>()
    {
        var val_19;
        System.Type val_20;
        var val_21;
        val_19 = this;
        val_20 = 1152921504625430528;
        if((this.丒丄丟丌下丌丗丌丆.ContainsKey(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}))) != false)
        {
                UnityEngine.GameObject val_4 = this.丒丄丟丌下丌丗丌丆.Item[System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})];
            val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            val_21 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丒丄丟丌下丌丗丌丆.Item[val_20]);
            val_21.transform.parent = this.createdItemsRoot;
            UnityEngine.Vector3 val_11 = val_4.transform.position;
            val_21.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Vector3 val_14 = val_4.transform.localScale;
            val_21.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_19 = val_21.transform;
            UnityEngine.Quaternion val_17 = val_4.transform.rotation;
            val_19.rotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
            val_21.gameObject.SetActive(value:  true);
            return (object)val_21;
        }
        
        val_21 = 0;
        return (object)val_21;
    }
    public void RemoveItem(ref WorldPosIndicationItem 下丅丙一丂丗丅丝七)
    {
        UnityEngine.Object.Destroy(obj:  下丅丙一丂丗丅丝七.gameObject);
        下丅丙一丂丗丅丝七 = 0;
    }
    public void ShowItems()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.createdItemsRoot.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void HideItems()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.createdItemsRoot.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public WorldPosIndicationsController()
    {
        this.丒丄丟丌下丌丗丌丆 = new System.Collections.Generic.Dictionary<System.Type, UnityEngine.GameObject>();
    }

}
