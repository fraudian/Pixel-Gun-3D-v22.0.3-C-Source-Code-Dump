using UnityEngine;
private sealed class LobbyCraftController.丅七丟业万且一上万
{
    // Fields
    public int 世丗丙丆七丄丌东上;
    public Rilisoft.LobbyCraftController.丗且丈丂丁丄专丞专 丕丅丏丁丅东且七丌;
    
    // Methods
    public LobbyCraftController.丅七丟业万且一上万()
    {
    
    }
    internal void 丙丅丕丈丈专丂丕丑(bool 万丗专丗丘一丞丄丛)
    {
        Rilisoft.丏丘七丞丄丙丌丞丁 val_12;
        LobbyCraftController.丗且丈丂丁丄专丞专 val_13;
        LobbyCraftController.丗且丈丂丁丄专丞专 val_14;
        LobbyCraftController.丗且丈丂丁丄专丞专 val_15;
        if(万丗专丗丘一丞丄丛 == false)
        {
                return;
        }
        
        val_13 = this.丕丅丏丁丅东且七丌;
        if(this.丕丅丏丁丅东且七丌 != null)
        {
            goto label_2;
        }
        
        val_13 = this.丕丅丏丁丅东且七丌;
        if(val_13 == null)
        {
            goto label_29;
        }
        
        label_2:
        val_12 = this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一;
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_12, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌(), 丘专丑丕且且丄专丁:  true)) == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丕丅丏丁丅东且七丌.丝且与丝丒丟万丁专._craftBeganAudio);
        }
        
        System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_8 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
        Rilisoft.LobbyItemPlayerInfo val_9 = this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一.丌七丌下丙三世丅一();
        val_9.IsCraftedAndNotShown = true;
        val_14 = this.丕丅丏丁丅东且七丌;
        if(this.丕丅丏丁丅东且七丌 != null)
        {
            goto label_20;
        }
        
        val_14 = this.丕丅丏丁丅东且七丌;
        if(val_14 == null)
        {
            goto label_29;
        }
        
        label_20:
        this.丕丅丏丁丅东且七丌.丝且与丝丒丟万丁专.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一);
        this.丕丅丏丁丅东且七丌.丝且与丝丒丟万丁专.上专丆丘业一不业专 = true;
        Rilisoft.一丟专且三万丞丁丂.丐丈业世丟丙丝丒丘(丂丏丟丛丞东七丝上:  this.世丗丙丆七丄丌东上);
        Rilisoft.一丟专且三万丞丁丂.三丕丝丘下一丟下专(丑丘丕且丆东丏丘丙:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一);
        val_15 = this.丕丅丏丁丅东且七丌;
        if(this.丕丅丏丁丅东且七丌 != null)
        {
            goto label_28;
        }
        
        val_15 = this.丕丅丏丁丅东且七丌;
        if(val_15 == null)
        {
            goto label_29;
        }
        
        label_28:
        Rilisoft.一丟专且三万丞丁丂.七丒丙东丛且万丛丛(丑丘丕且丆东丏丘丙:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一, 丝丘且丞丙丞丗丗丅:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌());
        Rilisoft.一丟专且三万丞丁丂.丙不丙不上与丛下丟(丑丘丕且丆东丏丘丙:  this.丕丅丏丁丅东且七丌.丙丑专丈一万三丟一);
        return;
        label_29:
    }

}
