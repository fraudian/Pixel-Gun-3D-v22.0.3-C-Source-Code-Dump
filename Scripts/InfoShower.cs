using UnityEngine;
public class InfoShower : MonoBehaviour
{
    // Methods
    public void U_ShowInfo()
    {
        Rilisoft.ItemViewer val_5 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  HatchEggUIBanner.丑七不且上丗丁一世().transform, 丈丄不七三万丄丁不:  this.GetComponent<PGCompany.InventoryItemView>().ItemParams, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  false, 丒不业且丄丅世世下:  false);
        UnityEngine.Vector3 val_11 = val_5.transform.localPosition;
        UnityEngine.Vector3 val_13 = val_5.transform.localPosition;
        val_5.transform.parent.GetComponentInChildren<PetInfoController>().transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public InfoShower()
    {
    
    }

}
