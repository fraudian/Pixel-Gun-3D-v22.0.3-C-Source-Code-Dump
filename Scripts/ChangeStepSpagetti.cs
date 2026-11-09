using UnityEngine;
public class ChangeStepSpagetti : MonoBehaviour
{
    // Fields
    public float timeChangeStep;
    private float 丙一丑丏丁一且丒业;
    public UnityEngine.GameObject[] steps;
    
    // Methods
    private void Start()
    {
        this.丙一丑丏丁一且丒业 = 0f;
    }
    private void Update()
    {
        float val_5 = this.丙一丑丏丁一且丒业;
        val_5 = val_5 + UnityEngine.Time.unscaledDeltaTime;
        this.丙一丑丏丁一且丒业 = val_5;
        this.丛丘专世三丅丈一丛(丒且丆丘丞丑业丅不:  UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_5), b:  this.steps.Length - 1));
    }
    private void 丛丘专世三丅丈一丛(int 丒且丆丘丞丑业丅不)
    {
        var val_2 = 0;
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.steps[0], 丏业丟一东丂东丘丛:  (丒且丆丘丞丑业丅不 == val_2) ? 1 : 0);
        val_2 = 1;
        label_1:
        if(val_2 < this.steps.Length)
        {
            goto label_7;
        }
    
    }
    public ChangeStepSpagetti()
    {
        this.timeChangeStep = 4f;
    }

}
