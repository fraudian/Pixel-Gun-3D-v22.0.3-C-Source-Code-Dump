using UnityEngine;
internal sealed class PrivateGameInfo_InPause : PGBehaviour
{
    // Methods
    private void OnEnable()
    {
        UIPanel val_1 = this.GetComponent<UIPanel>();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丙丈七丞上丌丐东丑(东七上世万下丗丄丛:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且()));
    }
    public void ReadRoomNextFrame(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丙丈七丞上丌丐东丑(东七上世万下丗丄丛:  东七上世万下丗丄丛));
    }
    private System.Collections.IEnumerator 丙丈七丞上丌丐东丑(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        PrivateGameInfo_InPause.丕且七丗下万丐专三 val_1 = new PrivateGameInfo_InPause.丕且七丗下万丐专三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .东七上世万下丗丄丛 = 东七上世万下丗丄丛;
        return (System.Collections.IEnumerator)val_1;
    }
    public void ReadRoom(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        var val_12;
        string val_13;
        var val_14;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_15;
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_2 = new System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>();
        val_12 = null;
        val_12 = null;
        val_13 = GameConnect.不丕丂三丙与丈且三;
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_5 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  东七上世万下丗丄丛.丂丂丁丕专丂丏与丌().Item[val_13]);
        if(val_5 == null)
        {
                return;
        }
        
        if(val_5.Count < 1)
        {
                return;
        }
        
        label_18:
        val_14 = 0;
        goto label_10;
        label_17:
        T val_12 = this.GetComponentsInChildren<GMEModificatorWidget>()[0];
        val_15 = val_12.myModType();
        if(val_15 == val_5.Item[0].不业丙丒丂丞下丆丙())
        {
                val_15 = val_5.Item[0];
            val_12.SetModificator(丄丘且丙丝七世丙且:  val_15);
        }
        
        val_14 = 1;
        label_10:
        if(val_14 < val_1.Length)
        {
            goto label_17;
        }
        
        val_13 = 0 + 1;
        if(val_13 < val_5.Count)
        {
            goto label_18;
        }
    
    }
    public PrivateGameInfo_InPause()
    {
    
    }

}
