using UnityEngine;
public class AlmanachLobbyButton : MonoBehaviour
{
    // Fields
    private UILabel needLevelLabel;
    private UnityEngine.GameObject lockedState;
    private UnityEngine.GameObject unlockedState;
    
    // Methods
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅();
        AlmanachTutorialManager.add_onTutorialFinished(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachLobbyButton::丈且东丑丂且万丒丅()));
    }
    private void OnDisable()
    {
        AlmanachTutorialManager.remove_onTutorialFinished(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachLobbyButton::丈且东丑丂且万丒丅()));
    }
    private void 丈且东丑丂且万丒丅()
    {
        string val_7;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.needLevelLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unlockedState, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        val_7 = 1152921505031233536;
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unlockedState, 丏业丟一东丂东丘丛:  true);
            if(上且丁万与丌下丐上.丑一丁丈丝丛下丛丏() == false)
        {
                return;
        }
        
            上且丁万与丌下丐上.丄专且丟丂不丑丞丐(业下丌一丛丞丄丘上:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.needLevelLabel, 丏业丟一东丂东丘丛:  true);
        val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081");
        ExpOpenSystem.丅一丐丌与丄上三丗 val_5 = 上且丁万与丌下丐上.丐丟东专丒丈一丅丕();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.needLevelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_7, arg0:  val_5.Progress));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unlockedState, 丏业丟一东丂东丘丛:  false);
    }
    public void GoToAlmanach()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_6 = null;
            val_6 = null;
            val_8 = AlmanachLobbyButton.<>c.<>9__6_0;
            if(val_8 == null)
        {
                System.Action val_3 = null;
            val_8 = val_3;
            val_3 = new System.Action(object:  AlmanachLobbyButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AlmanachLobbyButton.<>c::丘东且三丝万丂丝且());
            AlmanachLobbyButton.<>c.<>9__6_0 = val_8;
        }
        
            CoroutineRunner.DoOnNextFrame(七丐丅专且专七三丆:  val_3);
            return;
        }
        
        val_5 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_5.ForceShowBanner(丌丅丕一丛丛丄一万:  37, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public AlmanachLobbyButton()
    {
    
    }

}
