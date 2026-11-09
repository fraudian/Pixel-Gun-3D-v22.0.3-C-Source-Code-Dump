using UnityEngine;
internal abstract class GMEModificatorWidget : MonoBehaviour
{
    // Fields
    protected UISprite icon;
    protected UILabel description;
    protected PGCompany.GameModeEvents.下丑一丈与丝与丐丛.ModificatorType _myModType;
    protected PGCompany.GameModeEvents.下丑一丈与丝与丐丛 与下丅丘丗七不丏七;
    
    // Methods
    public PGCompany.GameModeEvents.下丑一丈与丝与丐丛.ModificatorType myModType()
    {
        return (ModificatorType)this._myModType;
    }
    public void SetModificator(PGCompany.GameModeEvents.下丑一丈与丝与丐丛 丄丘且丙丝七世丙且)
    {
        this.与下丅丘丗七不丏七 = 丄丘且丙丝七世丙且;
        goto typeof(GMEModificatorWidget).__il2cppRuntimeField_168;
    }
    protected abstract void 丁丅丏丈七下丁丝丞(); // 0
    protected abstract void 丝丂不不世丈丏丟不(); // 0
    protected void Start()
    {
        goto typeof(GMEModificatorWidget).__il2cppRuntimeField_178;
    }
    private void OnEnable()
    {
        goto typeof(GMEModificatorWidget).__il2cppRuntimeField_178;
    }
    protected GMEModificatorWidget()
    {
    
    }

}
