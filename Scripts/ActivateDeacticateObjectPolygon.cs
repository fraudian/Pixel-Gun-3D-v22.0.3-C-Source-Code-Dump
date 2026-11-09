using UnityEngine;
internal class ActivateDeacticateObjectPolygon : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> _listActivateObject;
    
    // Methods
    private void Awake()
    {
        PolygonController.add_ActivatePolygon(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ActivateDeacticateObjectPolygon::丗一三丌三与丆上与(bool 世丁万下丗专世万丅)));
    }
    private void OnDestroy()
    {
        PolygonController.remove_ActivatePolygon(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ActivateDeacticateObjectPolygon::丗一三丌三与丆上与(bool 世丁万下丗专世万丅)));
    }
    private void 丗一三丌三与丆上与(bool 世丁万下丗专世万丅)
    {
        bool val_4;
        List.Enumerator<T> val_1 = this._listActivateObject.GetEnumerator();
        val_4 = 世丁万下丗专世万丅 ^ 1;
        label_5:
        if(((-1795084376) & 1) == 0)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  val_4);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ActivateDeacticateObjectPolygon()
    {
        this._listActivateObject = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
