using UnityEngine;
internal class StonesActivateController : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> _listStones;
    
    // Methods
    private void Awake()
    {
        DungeonsController.丘专专上丑下丝业上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StonesActivateController::OnPhotonCustomRoomPropertiesChanged()));
        this.OnPhotonCustomRoomPropertiesChanged();
    }
    private void OnDestroy()
    {
        DungeonsController.一丕且万丂世丏丌丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StonesActivateController::OnPhotonCustomRoomPropertiesChanged()));
    }
    private void OnPhotonCustomRoomPropertiesChanged()
    {
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        this = this._listStones;
        List.Enumerator<T> val_2 = this.GetEnumerator();
        label_12:
        if((1108818280 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        object val_8 = val_3.name;
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_8);
        val_3.SetActive(value:  val_8);
        goto label_12;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public StonesActivateController()
    {
        this._listStones = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
