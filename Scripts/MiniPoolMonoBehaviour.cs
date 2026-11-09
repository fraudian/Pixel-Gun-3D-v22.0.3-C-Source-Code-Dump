using UnityEngine;
public class MiniPoolMonoBehaviour : MonoBehaviour
{
    // Fields
    public bool addExampleToThePool;
    private bool 三丄下三丁七丐东丁;
    public UnityEngine.MonoBehaviour example;
    public System.Collections.Generic.List<UnityEngine.MonoBehaviour> pool;
    
    // Methods
    public void SetupExample(UnityEngine.MonoBehaviour 丗丝丘丒丅丄专上丗)
    {
        this.example = 丗丝丘丒丅丄专上丗;
    }
    public T Get<T>()
    {
        System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_16;
        var val_17;
        val_16 = __RuntimeMethodHiddenParam;
        if((this.addExampleToThePool != false) && (this.三丄下三丁七丐东丁 != true))
        {
                this.Return(万且万且丑丗且丌丆:  this.example);
            this.三丄下三丁七丐东丁 = true;
        }
        
        if(this.pool.Count < 1)
        {
            goto label_4;
        }
        
        UnityEngine.MonoBehaviour val_2 = this.pool.Item[0];
        if(val_2 == null)
        {
            goto label_8;
        }
        
        val_17 = val_2;
        if(val_17 != null)
        {
            goto label_9;
        }
        
        label_8:
        val_17 = 0;
        label_9:
        val_16 = this.pool;
        val_16.RemoveAt(index:  0);
        return (CategorySelectableButton)val_17;
        label_4:
        val_17 = 0;
        if(this.example == 0)
        {
                return (CategorySelectableButton)val_17;
        }
        
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.example.gameObject, parent:  this.example.transform.parent);
        val_16 = ???;
        val_17 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public void Return(UnityEngine.MonoBehaviour 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        万且万且丑丗且丌丆.gameObject.SetActive(value:  false);
        this.pool.Add(item:  万且万且丑丗且丌丆);
    }
    public void Return(System.Collections.Generic.List<UnityEngine.MonoBehaviour> 三丐上丄丝下丙丟业)
    {
        var val_3 = this;
        if(三丐上丄丝下丙丟业 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 三丐上丄丝下丙丟业.GetEnumerator();
        label_3:
        if(((-1716369416) & 1) == 0)
        {
            goto label_2;
        }
        
        this.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_3;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public MiniPoolMonoBehaviour()
    {
        this.pool = new System.Collections.Generic.List<UnityEngine.MonoBehaviour>();
    }

}
