using UnityEngine;
private sealed class AuthSceneController.万丙一丝丌丑且一丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.万丙一丝丌丑且一丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_30;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        ulong val_35;
        var val_36;
        var val_37;
        var val_38;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_61;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  16);
        PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().丒专一丄七丒丝与专(丘丒丅三丞丞丛丛丌:  this.丝且与丝丒丟万丁专.bannersHolder);
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_8:
        val_30 = 1152921505610518528;
        val_31 = null;
        val_31 = null;
        if(PGCompany.IosIdfaPermission.丅业东万丌丕上丌丄 != false)
        {
                val_32 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_32;
            return (bool)val_32;
        }
        
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false)
        {
                val_33 = 1;
        }
        
        val_34 = null;
        val_34 = null;
        bool val_12 = Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝();
        bool val_13 = ((UnityEngine.Application.platform == 8) ? 1 : 0) | MainMenuController.丈一丏一丂丟三且丌();
        var val_14 = (ExperienceController.丞丞丘业东丙丏七丌() < 2) ? 1 : 0;
        if((System.DateTime.TryParse(s:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "loginGuiCooldown", 丞丌丑丛上丕丙丕下:  ""), provider:  System.Globalization.CultureInfo.InvariantCulture, styles:  0, result: out  new System.DateTime())) != false)
        {
                val_35 = 0;
        }
        else
        {
                System.DateTime val_15 = 专七专下且专三一且.丐世丈专与东丏丛丑();
            val_35 = val_15.dateData;
        }
        
        val_13 = val_13 | val_12;
        val_14 = val_13 | val_14;
        System.DateTime val_17 = System.DateTime.UtcNow;
        val_12 = val_14 | BalanceController.丁丝与七丗丏丝丌丒 ^ 1;
        val_30 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
        bool val_21 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_35}, t2:  new System.DateTime() {dateData = val_17.dateData});
        val_21 = val_12 | val_21;
        val_21 = val_21 | (丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_30));
        if(val_21 == false)
        {
            goto label_39;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_52;
        }
        
        label_53:
        label_52:
        this.丝且与丝丒丟万丁专.七丘丟丒丑与东丑一();
        label_61:
        val_32 = 0;
        return (bool)val_32;
        label_39:
        val_36 = null;
        val_36 = null;
        PGCompany.AuthorizationScene.AuthSceneLoginGui val_23 = UnityEngine.Resources.Load<PGCompany.AuthorizationScene.AuthSceneLoginGui>(path:  PGCompany.AuthorizationScene.AuthSceneLoginGui.专业下三业丕丑丙丙);
        bool val_24 = UnityEngine.Object.op_Equality(x:  val_23, y:  0);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_45;
        }
        
        if(val_24 == false)
        {
            goto label_46;
        }
        
        label_54:
        val_37 = null;
        val_37 = null;
        UnityEngine.Debug.Log(message:  "[" + this.丝且与丝丒丟万丁专.GetType() + "] No component AuthSceneLoginGui on prefab in path " + PGCompany.AuthorizationScene.AuthSceneLoginGui.专业下三业丕丑丙丙);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_52;
        }
        
        goto label_53;
        label_45:
        if(val_24 == true)
        {
            goto label_54;
        }
        
        label_46:
        PGCompany.AuthorizationScene.AuthSceneLoginGui val_27 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.AuthorizationScene.AuthSceneLoginGui>(丑且不丕与专丄业丙:  val_23, 丈东丘丏与丌东东下:  this.丝且与丝丒丟万丁专._authInterface.UpdateBannerPoint, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        this.丝且与丝丒丟万丁专.<丐丆上丄丌丕与丛业>k__BackingField = val_27;
        val_38 = null;
        val_38 = null;
        val_27.下与丞三丅丛丄七丕(丆丙丌东三且丝一丞:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void AuthSceneController::丑与七丞丕业丏万三()), 七丒丏七丆专丙丂丄:  new System.Action(object:  AuthSceneController.<>c.<>9, method:  System.Void AuthSceneController.<>c::丂丅丌三丒且与丞世()));
        goto label_61;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
