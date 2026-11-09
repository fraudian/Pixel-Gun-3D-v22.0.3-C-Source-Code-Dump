using UnityEngine;
public class AlphaSetter : MonoBehaviour
{
    // Fields
    public UnityEngine.Material mat;
    public float alpha;
    private string 丆丛丑世下一丐且丕;
    
    // Methods
    private void Update()
    {
        this.mat.SetFloat(name:  this.丆丛丑世下一丐且丕, value:  this.alpha);
    }
    public AlphaSetter()
    {
        this.alpha = 1f;
        this.丆丛丑世下一丐且丕 = "_Alpha";
    }

}
