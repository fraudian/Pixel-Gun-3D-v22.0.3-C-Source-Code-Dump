using UnityEngine;
public class EndlessScrollBar : MonoBehaviour
{
    // Fields
    private EndlessScroll 丅七丙丑丂丕丟丗不;
    private EndlessScrollDynamic 丞不丆丘东丁丝丏下;
    public UnityEngine.Transform start;
    public UnityEngine.Transform end;
    public UnityEngine.Transform thumb;
    public float lerpFactor;
    public float _value;
    
    // Properties
    public float 不丑一丙东丙丆丁七 { get; }
    
    // Methods
    public float get_Value()
    {
        return (float)this._value;
    }
    public void Init(EndlessScroll 丅七丙丑丂丕丟丗不)
    {
        this.丅七丙丑丂丕丟丗不 = 丅七丙丑丂丕丟丗不;
        this.丞不丆丘东丁丝丏下 = 0;
        UnityEngine.Vector3 val_2 = this.丅丗丐丂专世且丟丁();
        this.thumb.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public void Init(EndlessScrollDynamic 丞不丆丘东丁丝丏下)
    {
        this.丅七丙丑丂丕丟丗不 = 0;
        this.丞不丆丘东丁丝丏下 = 丞不丆丘东丁丝丏下;
        UnityEngine.Vector3 val_2 = this.丅丗丐丂专世且丟丁();
        this.thumb.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    private UnityEngine.Vector3 丅丗丐丂专世且丟丁()
    {
        EndlessScroll val_11;
        int val_12;
        EndlessScroll val_13;
        EndlessScroll val_14;
        float val_15;
        float val_16;
        EndlessScrollDynamic val_17;
        int val_18;
        EndlessScrollDynamic val_19;
        this._value = 0f;
        if(this.丅七丙丑丂丕丟丗不 == 0)
        {
            goto label_12;
        }
        
        val_11 = this.丅七丙丑丂丕丟丗不;
        if(val_11 == null)
        {
            goto label_4;
        }
        
        val_12 = this.丅七丙丑丂丕丟丗不.业丞丕与丄东丞丞丆;
        val_13 = val_11;
        goto label_7;
        label_4:
        val_13 = this.丅七丙丑丂丕丟丗不;
        val_12 = this.丅七丙丑丂丕丟丗不.业丞丕与丄东丞丞丆;
        if(val_13 == null)
        {
            goto label_6;
        }
        
        val_11 = val_13;
        goto label_7;
        label_6:
        val_11 = this.丅七丙丑丂丕丟丗不;
        if(val_11 == null)
        {
            goto label_21;
        }
        
        label_7:
        val_14 = this.丅七丙丑丂丕丟丗不.cellsList.Count;
        int val_4 = UnityEngine.Mathf.Max(a:  val_12, b:  this.丅七丙丑丂丕丟丗不.丏丌丞丅丅丟与丄丐 - val_14);
        if(val_4 >= 1)
        {
                val_14 = this.丅七丙丑丂丕丟丗不;
            val_15 = (float)val_4;
            val_16 = (float)this.丅七丙丑丂丕丟丗不.业丞丕与丄东丞丞丆 / val_15;
            this._value = val_16;
        }
        
        label_12:
        if(this.丞不丆丘东丁丝丏下 == 0)
        {
            goto label_25;
        }
        
        val_17 = this.丞不丆丘东丁丝丏下;
        if(val_17 == null)
        {
            goto label_17;
        }
        
        val_18 = this.丞不丆丘东丁丝丏下.业丞丕与丄东丞丞丆;
        val_19 = val_17;
        goto label_20;
        label_17:
        val_19 = this.丞不丆丘东丁丝丏下;
        val_18 = this.丞不丆丘东丁丝丏下.业丞丕与丄东丞丞丆;
        if(val_19 == null)
        {
            goto label_19;
        }
        
        val_17 = val_19;
        goto label_20;
        label_19:
        val_17 = this.丞不丆丘东丁丝丏下;
        if(val_17 == null)
        {
            goto label_21;
        }
        
        label_20:
        val_14 = this.丞不丆丘东丁丝丏下.cellsList.Count;
        int val_8 = UnityEngine.Mathf.Max(a:  val_18, b:  this.丞不丆丘东丁丝丏下.丏丌丞丅丅丟与丄丐 - val_14);
        if(val_8 >= 1)
        {
                val_14 = this.丞不丆丘东丁丝丏下;
            val_15 = (float)val_8;
            val_16 = (float)this.丞不丆丘东丁丝丏下.业丞丕与丄东丞丞丆 / val_15;
            this._value = val_16;
        }
        
        label_25:
        UnityEngine.Vector3 val_9 = this.start.position;
        UnityEngine.Vector3 val_10 = this.end.position;
        return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, t:  this._value);
        label_21:
    }
    private void LateUpdate()
    {
        if(this.丅七丙丑丂丕丟丗不 == 0)
        {
                if(this.丞不丆丘东丁丝丏下 == 0)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_5 = this.thumb.transform.position;
        UnityEngine.Vector3 val_6 = this.丅丗丐丂专世且丟丁();
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, t:  UnityEngine.Time.deltaTime * this.lerpFactor);
        this.thumb.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    public EndlessScrollBar()
    {
        this.lerpFactor = 10f;
    }

}
