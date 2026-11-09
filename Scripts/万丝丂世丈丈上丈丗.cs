using UnityEngine;
private sealed class ShopNGUIController.万丝丂世丈丈上丈丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopNGUIController 丝且与丝丒丟万丁专;
    private Rilisoft.丝丄丄不丏丘丝世丗 丐丑丄七丗丑丅业丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopNGUIController.万丝丂世丈丈上丈丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Action val_20;
        int val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_107;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        val_16 = null;
        val_16 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_17 = null;
            val_17 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                val_18 = null;
            val_18 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                QuestsGSMAnager.丑七不且上丗丁一世().Check_Shtab_Task();
            val_19 = null;
            val_19 = null;
            MainMenuController.丄丞丁丈与业上丞丟.丆七丌三丈丕丅丗专();
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丏丐世且丑丅丘丅丟 == null)
        {
            goto label_26;
        }
        
        this.丝且与丝丒丟万丁专.丏丐世且丑丅丘丅丟.Invoke();
        goto label_27;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
        this.丝且与丝丒丟万丁专.丑下三丞丛世东丕三(丙业与丙丗丝不丈东:  true);
        val_20 = new System.Action();
        val_20 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void ShopNGUIController::丞且东丄东丝丑上丆());
        new Rilisoft.丝丄丄不丏丘丝世丗() = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  new System.Action());
        this.丐丑丄七丗丑丅业丘 = new Rilisoft.丝丄丄不丏丘丝世丗();
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丝且与丝丒丟万丁专.且业丛丕丑丗不不七();
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_26:
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        label_27:
        下丟且丅丒万丆丅丙.丝丕下丝下不万丌七();
        if(OnOpenModuleChestUI.丒丙丈下业丞丄丅丛() != 0)
        {
                OnOpenModuleChestUI.丒丙丈下业丞丄丅丛().Hide();
        }
        
        if(this.丝且与丝丒丟万丁专.丏且丛七丗丛丗丞丘 != false)
        {
                this.丝且与丝丒丟万丁专.丏且丛七丗丛丗丞丘 = false;
        }
        
        val_22 = null;
        val_22 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_23 = null;
            val_23 = null;
            MainMenuController.丄丞丁丈与业上丞丟.UpdateOldHints(丕丕世且下一与丝与:  false);
        }
        
        val_24 = null;
        val_24 = null;
        if(ShopNGUIController.丗丟万丂丘丈专丄丂 != null)
        {
                ShopNGUIController.丗丟万丂丘丈专丄丂.Invoke();
        }
        
        val_25 = null;
        val_25 = null;
        val_20 = SkinEditorController.丄丞丁丈与业上丞丟;
        if(val_20 != 0)
        {
                val_26 = null;
            val_26 = null;
            val_20 = SkinEditorController.丄丞丁丈与业上丞丟.gameObject;
            if(val_20.activeSelf != false)
        {
                val_27 = null;
            val_27 = null;
            val_20 = SkinEditorController.丄丞丁丈与业上丞丟;
            val_20.业业丘丟丒丗一丙丗();
        }
        
        }
        
        this.丝且与丝丒丟万丁专.万丞丂三下世丌丑丗 = false;
        this.一世丕丕业且且丅丌();
        this.丐丑丄七丗丑丅业丘 = 0;
        val_28 = null;
        val_28 = null;
        val_21 = 0;
        ShopNGUIController.丞业丙三丙丄丏丞丘 = false;
        return (bool)val_21;
        label_107:
        val_21 = 0;
        return (bool)val_21;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丐丑丄七丗丑丅业丘 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丑丄七丗丑丅业丘.Dispose();
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
