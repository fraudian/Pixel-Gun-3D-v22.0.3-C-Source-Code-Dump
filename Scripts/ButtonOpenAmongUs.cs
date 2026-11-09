using UnityEngine;
internal sealed class ButtonOpenAmongUs : PGBehaviour
{
    // Fields
    private UnityEngine.AudioClip _audioClip;
    
    // Methods
    public void U_Open()
    {
        if(AmongUsButtonLobby.丙丝丌与丘丗与东丁() == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this = this._audioClip;
        }
        
        不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this).GoToGameModeImposter();
    }
    public void GoToGameModeImposter()
    {
        var val_9;
        MainMenuController val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        val_10 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_10 == 0)
        {
                return;
        }
        
        val_11 = static_value_081DACA8;
        val_11 = static_value_081DACA8;
        val_10 = mem[static_value_081DACA8 + 184 + 16];
        val_10 = static_value_081DACA8 + 184 + 16;
        if(val_10 == 0)
        {
                return;
        }
        
        PGCompany.丌不丞丐世丞三丘丌 val_3 = null;
        val_10 = val_3;
        val_3 = new PGCompany.丌不丞丐世丞三丘丌();
        if(val_10 != null)
        {
                .Type = 11;
        }
        else
        {
                mem[16] = 11;
        }
        
        .GameMode = 30;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_3)) == null)
        {
                return;
        }
        
        val_10 = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public ButtonOpenAmongUs()
    {
    
    }

}
