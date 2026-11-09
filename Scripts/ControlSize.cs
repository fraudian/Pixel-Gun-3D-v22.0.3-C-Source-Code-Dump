using UnityEngine;
internal sealed class ControlSize : MonoBehaviour
{
    // Fields
    public int defaultValue;
    public int maxValue;
    public int minValue;
    
    // Methods
    private void Update()
    {
        int val_1;
        int val_2;
        val_1 = this.maxValue;
        if(val_1 < this.minValue)
        {
                val_1 = this.minValue;
            this.maxValue = this.minValue;
        }
        
        val_2 = this.defaultValue;
        if(val_2 < this.minValue)
        {
                val_2 = this.minValue;
            this.defaultValue = this.minValue;
        }
        
        if(val_2 <= val_1)
        {
                return;
        }
        
        this.defaultValue = val_1;
    }
    public ControlSize()
    {
    
    }

}
