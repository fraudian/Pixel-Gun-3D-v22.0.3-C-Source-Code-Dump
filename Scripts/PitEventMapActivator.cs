using UnityEngine;
internal sealed class PitEventMapActivator : PGBehaviour
{
    // Fields
    internal System.Collections.Generic.List<UnityEngine.GameObject> _listActivateObject;
    internal System.Collections.Generic.List<UnityEngine.GameObject> _listDeactivateObject;
    
    // Methods
    private void Start()
    {
        var val_4;
        if(GameConnect.七丕丟上且丄丂丞丕() == false)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this._listActivateObject.GetEnumerator();
        label_9:
        if((1361740080 & 1) == 0)
        {
            goto label_5;
        }
        
        val_4.丐丏七丌丕丗业且上().SetActive(value:  GameConnect.七丕丟上且丄丂丞丕());
        goto label_9;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this = this._listDeactivateObject;
        List.Enumerator<T> val_8 = this.GetEnumerator();
        label_20:
        if((1361740080 & 1) == 0)
        {
            goto label_16;
        }
        
        val_4.丐丏七丌丕丗业且上().SetActive(value:  (~GameConnect.七丕丟上且丄丂丞丕()) & 1);
        goto label_20;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public PitEventMapActivator()
    {
        this._listActivateObject = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this._listDeactivateObject = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
