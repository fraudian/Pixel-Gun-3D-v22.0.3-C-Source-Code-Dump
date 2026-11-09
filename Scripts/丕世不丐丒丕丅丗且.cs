using UnityEngine;
internal class 丕世不丐丒丕丅丗且
{
    // Fields
    private const string 丟丐丈世上丌丙丝丗 = "AuthorizationScene";
    private static System.Action 丝丝下丆且下丞丄三;
    private static int 东丒三丙东丕丑丁不;
    
    // Methods
    internal static void 七丅东丐世与下万丞(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  丕世不丐丒丕丅丗且.丝丝下丆且下丞丄三, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 业世世七丌丕丝丆丙(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  丕世不丐丒丕丅丗且.丝丝下丆且下丞丄三, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 东丟东丝一丐丈丗业(bool 丝丏丁丟丌丄丁与专, bool 丘丘不丏且丂丐丘丝)
    {
        丕世不丐丒丕丅丗且.上丕丄丝丐世七丄丘();
        AuthSceneController.万七丗与业丒且万不(丙业与丙丗丝不丈东:  丘丘不丏且丂丐丘丝);
        AuthSceneController.与丈下一丐丝丄世丐(丙业与丙丗丝不丈东:  丝丏丁丟丌丄丁与专);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                UnityEngine.Texture val_5 = ConnectScene.丗丅专与丁丙且且丐();
        }
        
        ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Switcher.丌三丟丈东丑七丑上(丑丅世丐丒丏丐三丅:  3)));
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  AuthSceneController.万丛七万万万世丈丏());
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "AuthorizationScene", mode:  0);
    }
    internal static void 上丑丅丟丒丘业东万()
    {
        if(丕世不丐丒丕丅丗且.东丒三丙东丕丑丁不 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        丕世不丐丒丕丅丗且.东丒三丙东丕丑丁不 = UnityEngine.Time.frameCount;
        丕世不丐丒丕丅丗且.上丕丄丝丐世七丄丘();
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                UnityEngine.Texture val_5 = ConnectScene.丗丅专与丁丙且且丐();
        }
        
        ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Switcher.丌三丟丈东丑七丑上(丑丅世丐丒丏丐三丅:  3)));
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  false);
        MainMenuController.丅上丏丈万丒丈丑东(丙业与丙丗丝不丈东:  true);
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
    }
    private static void 上丕丄丝丐世七丄丘()
    {
        var val_24;
        System.Action<ProfileView> val_26;
        var val_28;
        System.Action<ProfileView> val_30;
        var val_31;
        var val_32;
        var val_33;
        PreviewOfferPackController val_34;
        var val_35;
        System.Action<BankController> val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
        }
        
        UnityEngine.Time.timeScale = 1f;
        Rilisoft.AbstractGameEventGui.丙丛东世东丌业一丝();
        val_24 = null;
        val_24 = null;
        val_26 = 丕世不丐丒丕丅丗且.<>c.<>9__8_0;
        if(val_26 == null)
        {
                System.Action<ProfileView> val_2 = null;
            val_26 = val_2;
            val_2 = new System.Action<ProfileView>(object:  丕世不丐丒丕丅丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丕世不丐丒丕丅丗且.<>c::丂丄三丘丛丗丁专丏(ProfileView 三丟东丕丄丄下下丑));
            丕世不丐丒丕丅丗且.<>c.<>9__8_0 = val_26;
        }
        
        ProfileView val_3 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<ProfileView>(丞下万上三丘上与专:  ProfileView.丄丞丁丈与业上丞丟, 丌专业且丛丏丞丝且:  val_2);
        val_28 = null;
        val_28 = null;
        val_30 = 丕世不丐丒丕丅丗且.<>c.<>9__8_1;
        if(val_30 == null)
        {
                System.Action<ProfileView> val_4 = null;
            val_30 = val_4;
            val_4 = new System.Action<ProfileView>(object:  丕世不丐丒丕丅丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丕世不丐丒丕丅丗且.<>c::一业七丗丂不丒丐东(ProfileView 三丟东丕丄丄下下丑));
            丕世不丐丒丕丅丗且.<>c.<>9__8_1 = val_30;
        }
        
        ProfileView val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<ProfileView>(丞下万上三丘上与专:  ProfileView.丄丞丁丈与业上丞丟, 丌专业且丛丏丞丝且:  val_4);
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丄丘丆丐丗不丌专丐();
        val_31 = null;
        val_31 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        }
        
        val_32 = null;
        val_32 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_33 = null;
            val_33 = null;
            SetActive(value:  true);
        }
        
        if(BankController.丑七不且上丗丁一世() != null)
        {
                val_34 = val_9.PreviewOfferPackController;
        }
        else
        {
                val_34 = 0;
        }
        
        if(val_34 != 0)
        {
                BankController val_11 = BankController.丑七不且上丗丁一世();
            val_11.PreviewOfferPackController.七丘一丝丈一丛专丅(丞丑丏七丏丐专万专:  false);
        }
        
        if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false)
        {
                val_35 = null;
            val_35 = null;
            val_37 = 丕世不丐丒丕丅丗且.<>c.<>9__8_2;
            if(val_37 == null)
        {
                System.Action<BankController> val_15 = null;
            val_37 = val_15;
            val_15 = new System.Action<BankController>(object:  丕世不丐丒丕丅丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丕世不丐丒丕丅丗且.<>c::丞丆东丐丑丞下丂丐(BankController 三丟东丕丄丄下下丑));
            丕世不丐丒丕丅丗且.<>c.<>9__8_2 = val_37;
        }
        
            BankController val_16 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<BankController>(丞下万上三丘上与专:  BankController.丑七不且上丗丁一世(), 丌专业且丛丏丞丝且:  val_15);
        }
        
        val_38 = static_value_081DACA8;
        val_38 = static_value_081DACA8;
        mem2[0] = 0;
        val_39 = null;
        val_39 = null;
        MainMenuController.丆不丑丆下丞丙不丞 = false;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        MainMenuController.丞且丙丛丞不世专七 = true;
        MainMenuController.下且丄丝丘丝丈上丒 = false;
        PGCompany.BattlePass.BattlePassGuiHandler.且与丌一东不丝丛业();
        val_40 = null;
        val_40 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_41 = null;
            val_41 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                Rilisoft.Singleton<Rilisoft.FortCraftSceneLoader>.Instance.LeaveWithoutUnload();
        }
        
        }
        
        PGCompany.丑且丆万丏丝丘丙丟 val_21 = PGCompany.TransitionController.丑七不且上丗丁一世().丘丁丒东丒丏上丛丝();
        if(val_21 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_21.TurnOff();
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丁丏一专丁七丝丞();
        if(丕世不丐丒丕丅丗且.丝丝下丆且下丞丄三 == null)
        {
                return;
        }
        
        丕世不丐丒丕丅丗且.丝丝下丆且下丞丄三.Invoke();
    }
    public 丕世不丐丒丕丅丗且()
    {
    
    }

}
