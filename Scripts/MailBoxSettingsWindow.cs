using UnityEngine;
internal sealed class MailBoxSettingsWindow : PGBehaviour
{
    // Fields
    private Rilisoft.ButtonHandler SaveButton;
    private UIToggle ContestCheckBox;
    private UIToggle Entertainment;
    private UIToggle Upcoming;
    private UIToggle Updates;
    private int[] 丙一丄丌丐丄丈万东;
    
    // Methods
    private void Awake()
    {
        this.SaveButton.ClearEvents();
        this.SaveButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MailBoxSettingsWindow::丌丝七丑一三东且丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnDestroy()
    {
        this.SaveButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MailBoxSettingsWindow::丌丝七丑一三东且丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnEnable()
    {
        string val_1 = PGCompany.NewsLobbyController.丁世丛丘丘丟专丅丟();
        string val_10 = val_1;
        val_10 = PGCompany.NewsLobbyController.世丕丐丘不不万丈专(万世丆万丙丙丅七东:  5, 丏上丆丗丄丟七丄丙:  val_10);
        this.ContestCheckBox.Set(丏业丟一东丂东丘丛:  val_10);
        string val_11 = val_1;
        val_11 = PGCompany.NewsLobbyController.世丕丐丘不不万丈专(万世丆万丙丙丅七东:  4, 丏上丆丗丄丟七丄丙:  val_11);
        this.Upcoming.Set(丏业丟一东丂东丘丛:  val_11);
        string val_12 = val_1;
        val_12 = PGCompany.NewsLobbyController.世丕丐丘不不万丈专(万世丆万丙丙丅七东:  3, 丏上丆丗丄丟七丄丙:  val_12);
        this.Updates.Set(丏业丟一东丂东丘丛:  val_12);
        string val_13 = val_1;
        val_13 = PGCompany.NewsLobbyController.世丕丐丘不不万丈专(万世丆万丙丙丅七东:  2, 丏上丆丗丄丟七丄丙:  val_13);
        this.Entertainment.Set(丏业丟一东丂东丘丛:  val_13);
        UIToggle val_14 = this.Entertainment;
        val_14 = (~val_14.value) & 1;
        this.丙一丄丌丐丄丈万东[0] = val_14;
        UIToggle val_15 = this.Updates;
        val_15 = (~val_15.value) & 1;
        this.丙一丄丌丐丄丈万东[1] = val_15;
        UIToggle val_16 = this.ContestCheckBox;
        val_16 = (~val_16.value) & 1;
        this.丙一丄丌丐丄丈万东[2] = val_16;
        UIToggle val_17 = this.Upcoming;
        val_17 = (~val_17.value) & 1;
        this.丙一丄丌丐丄丈万东[3] = val_17;
    }
    private void 丌丝七丑一三东且丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        System.Object[] val_11;
        int val_12;
        int val_13;
        int val_14;
        var val_15;
        var val_16;
        bool val_2 = this.Updates.value;
        val_11 = val_2;
        val_11 = ~val_2;
        val_12 = (~this.Entertainment.value) & 1;
        int[] val_5 = new int[4];
        val_13 = val_5.Length;
        int val_6 = val_11 & 1;
        if(val_13 == 0)
        {
                val_13 = val_5.Length;
        }
        
        int val_12 = ~this.Upcoming.value;
        val_14 = (~this.ContestCheckBox.value) & 1;
        val_5[0] = val_12;
        if(val_13 <= 1)
        {
                val_13 = val_5.Length;
        }
        
        val_12 = val_12 & 1;
        val_5[0] = val_6;
        if(val_13 <= 2)
        {
                val_13 = val_5.Length;
        }
        
        val_5[1] = val_14;
        if(val_13 <= 3)
        {
                val_13 = val_5.Length;
        }
        
        val_5[1] = val_12;
        if(val_13 < 1)
        {
            goto label_23;
        }
        
        label_15:
        val_11 = 0;
        if(val_5[0] != this.丙一丄丌丐丄丈万东[val_11])
        {
            goto label_14;
        }
        
        if((val_11 + 1) < val_5.Length)
        {
            goto label_15;
        }
        
        goto label_23;
        label_14:
        PGCompany.NewsLobbyController.三丏七上丗丂丂丆丆(丞丕东上丞丑丑丗世:  val_12, 丗专与丐丌一专丒三:  val_6, 丌东丙丙业专丅丞与:  val_14, 丁东丗丄丁业专丛丂:  val_12);
        val_15 = null;
        val_15 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                if(MailBoxMessagesController.丄丞丁丈与业上丞丟 != null)
        {
                object[] val_9 = new object[4];
            val_11 = val_9;
            val_12 = val_12;
            val_11[0] = val_12;
            val_11[1] = val_6;
            val_14 = val_14;
            val_11[2] = val_14;
            val_11[3] = val_12;
            string val_10 = System.String.Format(format:  "{0}{1}{2}{3}", args:  val_9);
            MailBoxMessagesController.丄丞丁丈与业上丞丟.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  val_9);
        }
        
            val_16 = null;
            val_16 = null;
            PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丛丘丗丟世丂一东一(七三丞丘丟下丛丛不:  false);
        }
        
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
    }
    public MailBoxSettingsWindow()
    {
        this.丙一丄丌丐丄丈万东 = new int[4];
    }

}
