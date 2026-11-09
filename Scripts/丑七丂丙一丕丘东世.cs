using UnityEngine;
private sealed class LobbyCraftController.丑七丂丙一丕丘东世
{
    // Fields
    public Rilisoft.LobbyCraftController 丝且与丝丒丟万丁专;
    public Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟;
    
    // Methods
    public LobbyCraftController.丑七丂丙一丕丘东世()
    {
    
    }
    internal void 丕丄丈丟世一丏丏一()
    {
        this.丝且与丝丒丟万丁专.不不丝与世丗七丙丅(丁世丛业丟下丕三丟:  this.丁世丛业丟下丕三丟);
    }
    internal void 业丂丝与专三业丛且(bool 丌丗丏丏丛东专丁且)
    {
        if(丌丗丏丏丛东专丁且 == false)
        {
                return;
        }
        
        bool val_6 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  this.丁世丛业丟下丕三丟.LobbyItem, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  this.丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈(), 丘专丑丕且且丄专丁:  true);
    }
    internal void 丏丐上丁与业丟丟丈(bool 丌丗丏丏丛东专丁且)
    {
        if(丌丗丏丏丛东专丁且 == false)
        {
                return;
        }
        
        Rilisoft.LobbyItemsController val_1 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if((val_1.<丛上丟丏与丕丒东丂>k__BackingField) != null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丆丑下丙专下丒丅丆(下丅丙一丂丗丅丝七:  this.丁世丛业丟下丕三丟.LobbyItem, 丑丝一丟丕上丆专下:  false, 万丐丏丐丒万不丟三:  0)) == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._craftBeganAudio);
        }
        
        Rilisoft.一丟专且三万丞丁丂.三丕丝丘下一丟下专(丑丘丕且丆东丏丘丙:  this.丁世丛业丟下丕三丟.LobbyItem);
        Rilisoft.一丟专且三万丞丁丂.七丒丙东丛且万丛丛(丑丘丕且丆东丏丘丙:  this.丁世丛业丟下丕三丟.LobbyItem, 丝丘且丞丙丞丗丗丅:  this.丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈());
        Rilisoft.一丟专且三万丞丁丂.丙不丙不上与丛下丟(丑丘丕且丆东丏丘丙:  this.丁世丛业丟下丕三丟.LobbyItem);
        NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  8);
    }

}
