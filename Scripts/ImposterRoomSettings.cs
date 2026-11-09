using UnityEngine;
public class ImposterRoomSettings : MonoBehaviour
{
    // Fields
    public UILabel roomName;
    public UILabel roomPassword;
    public UnityEngine.GameObject roomPrivateSelected;
    public Rilisoft.ButtonHandler startButton;
    public string KeyRoom;
    public string KeyPassword;
    private bool 三不业东丂丅丕丒丗;
    private bool 东丗丏专三丈丏丝上;
    private string 东丅丒丛丏丄丒丞专;
    
    // Methods
    private void OnEnable()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        this.东丗丏专三丈丏丝上 = false;
        val_18 = null;
        val_18 = null;
        object val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七];
        bool val_18 = ~val_3;
        val_18 = val_18 & 1;
        this.三不业东丂丅丕丒丗 = val_18;
        if((val_3 & 1) == 0)
        {
            goto label_8;
        }
        
        ExitGames.Client.Photon.Hashtable val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_19 = null;
        val_19 = null;
        if(val_5 != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        val_20 = this;
        this.东丅丒丛丏丄丒丞专 = val_5.Item[GameConnect.丐丌专下丌丁丄丏丕];
        this.roomName.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.KeyRoom), arg0:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘());
        val_21 = null;
        val_21 = null;
        bool val_12 = this.东丅丒丛丏丄丒丞专.Equals(value:  GameConnect.丂万且丟丛丈与丞丏);
        this.roomPassword.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.KeyPassword), arg0:  System.String.__il2cppRuntimeField_static_fields);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roomPrivateSelected, 丏业丟一东丂东丘丛:  (this.三不业东丂丅丕丒丗 == true) ? 1 : 0);
        this.startButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ImposterRoomSettings::七丙丂三丒丙丈丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        return;
        label_8:
        val_22 = null;
        val_22 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆() != null)
        {
            goto label_35;
        }
        
        goto label_36;
    }
    private void OnDisable()
    {
        this.startButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ImposterRoomSettings::七丙丂三丒丙丈丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 七丙丂三丒丙丈丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        if(GameController.onlineMode == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        (null == null) ? GameController.onlineMode : 0.丞丝下丄丆且丌丈丐();
        this.startButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ImposterRoomSettings::七丙丂三丒丙丈丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.startButton, 丏业丟一东丂东丘丛:  false);
        this.东丗丏专三丈丏丝上 = true;
    }
    public void U_ClickPrivate()
    {
        var val_7;
        string val_8;
        var val_9;
        string val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() < 2)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        if(this.三不业东丂丅丕丒丗 != false)
        {
            
        }
        else
        {
                val_8 = this.东丅丒丛丏丄丒丞专;
        }
        
        val_3.set_Item(key:  GameConnect.丗三丅丞丏七与上七, value:  mem[this.东丅丒丛丏丄丒丞专]);
        val_9 = null;
        val_9 = null;
        if(this.三不业东丂丅丕丒丗 != false)
        {
                val_10 = this.东丅丒丛丏丄丒丞专;
        }
        
        val_3.set_Item(key:  GameConnect.丐丌专下丌丁丄丏丕, value:  System.String.__il2cppRuntimeField_static_fields);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_3, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.三不业东丂丅丕丒丗 = this.三不业东丂丅丕丒丗 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roomPrivateSelected, 丏业丟一东丂东丘丛:  (this.三不业东丂丅丕丒丗 == false) ? 1 : 0);
    }
    private void Update()
    {
        var val_4;
        UnityEngine.MonoBehaviour val_5;
        if(this.东丗丏专三丈丏丝上 != false)
        {
                return;
        }
        
        if(this.三不业东丂丅丕丒丗 != false)
        {
                var val_3 = (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() > 4) ? 1 : 0;
            val_5 = this.startButton;
        }
        else
        {
                val_5 = this.startButton;
            val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
    }
    public ImposterRoomSettings()
    {
        this.KeyRoom = "Key_10162";
        this.KeyPassword = "Key_10163";
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
    }

}
