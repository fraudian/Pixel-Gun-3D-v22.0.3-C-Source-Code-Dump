using UnityEngine;
internal sealed class JoinPrivateGameInfoWindow : PGBehaviour
{
    // Fields
    private bool 上丑丏丛丕丑丏下丐;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void OnDisable()
    {
        this.丐七三与且丘丅丒丙();
    }
    private void 业丆不丌丟丗业丘丐()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void JoinPrivateGameInfoWindow::CloseWindow()), 与且专丈不万东一万:  "JoinPrivateGameInfoWindow");
    }
    public void CloseWindow()
    {
        static_value_081DACA8 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.HandleBackBtnClicked();
    }
    private void 丐七三与且丘丅丒丙()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnEnable()
    {
        if(this.上丑丏丛丕丑丏下丐 != false)
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丙丈七丞上丌丐东丑(东七上世万下丗丄丛:  0));
        }
        
        this.业丆不丌丟丗业丘丐();
    }
    public void ReadRoomNextFrame(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丙丈七丞上丌丐东丑(东七上世万下丗丄丛:  东七上世万下丗丄丛));
    }
    private System.Collections.IEnumerator 丙丈七丞上丌丐东丑(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        JoinPrivateGameInfoWindow.丄业丒业七业丄三且 val_1 = new JoinPrivateGameInfoWindow.丄业丒业七业丄三且();
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
        string val_13;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_18;
        val_13 = this;
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_2 = new System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>();
        if(this.上丑丏丛丕丑丏下丐 != false)
        {
                val_14 = null;
            val_14 = null;
            string val_3 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝);
        }
        else
        {
                val_16 = null;
            val_16 = null;
            val_13 = GameConnect.不丕丂三丙与丈且三;
            val_15 = 东七上世万下丗丄丛.丂丂丁丕专丂丏与丌().Item[val_13];
        }
        
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_6 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  val_15);
        if(val_6 == null)
        {
                return;
        }
        
        if(val_6.Count < 1)
        {
                return;
        }
        
        label_24:
        val_17 = 0;
        goto label_16;
        label_23:
        T val_13 = this.GetComponentsInChildren<GMEModificatorWidget>()[0];
        val_18 = val_13.myModType();
        if(val_18 == val_6.Item[0].不业丙丒丂丞下丆丙())
        {
                val_18 = val_6.Item[0];
            val_13.SetModificator(丄丘且丙丝七世丙且:  val_18);
        }
        
        val_17 = 1;
        label_16:
        if(val_17 < val_1.Length)
        {
            goto label_23;
        }
        
        val_13 = 0 + 1;
        if(val_13 < val_6.Count)
        {
            goto label_24;
        }
    
    }
    public JoinPrivateGameInfoWindow()
    {
    
    }

}
