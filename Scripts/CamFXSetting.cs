using UnityEngine;
public sealed class CamFXSetting : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject CamFX;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_3 = this.transform.GetChild(index:  0).gameObject;
        this.CamFX = val_3;
        val_3.SetActive(value:  false);
    }
    public CamFXSetting()
    {
    
    }

}
