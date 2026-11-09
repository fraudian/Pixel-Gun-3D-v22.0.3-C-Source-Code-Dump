using UnityEngine;
public class StrechSpriteToGameObject : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform to;
    private UIWidget 与丘东下丈东丛丂万;
    public int width;
    public float alpha;
    
    // Methods
    private void Start()
    {
        this.与丘东下丈东丛丂万 = this.GetComponent<UIWidget>();
    }
    private void Update()
    {
        var val_17;
        var val_18;
        float val_19;
        UIWidget val_20;
        float val_21;
        val_17 = this;
        if(this.与丘东下丈东丛丂万 == 0)
        {
                return;
        }
        
        if(this.to == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.to.position;
        val_18 = 0;
        UnityEngine.Vector3 val_5 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_19 = val_5.x;
        val_20 = this.与丘东下丈东丛丂万;
        val_21 = 2f;
        if((val_19 + (float)this.width) < 0)
        {
                val_20 = ???;
            val_17 = ???;
            val_19 = ???;
            val_21 = 0f;
        }
        else
        {
                val_17 + 32.width = (val_17 + 40) + (UnityEngine.Mathf.CeilToInt(f:  val_19));
        }
    
    }
    public StrechSpriteToGameObject()
    {
        this.width = 80;
        this.alpha = 5.510186E-41f;
    }

}
