using UnityEngine;
internal sealed class MainMenuQuestSystemListener : MonoBehaviour
{
    // Fields
    private static MainMenuQuestSystemListener 丝业丆丁业三丈丟东;
    public DailyQuestItem dailyQuestItem;
    
    // Methods
    internal static void 业不不且丐且与不与()
    {
        MainMenuQuestSystemListener val_3 = MainMenuQuestSystemListener.丝业丆丁业三丈丟东;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[MainMenuQuestSystemListener.丝业丆丁业三丈丟东 + 24];
        val_3 = MainMenuQuestSystemListener.丝业丆丁业三丈丟东.dailyQuestItem;
        if(val_3 == 0)
        {
                return;
        }
        
        Refresh();
    }
    private void Awake()
    {
        MainMenuQuestSystemListener.丝业丆丁业三丈丟东 = this;
    }
    private void Start()
    {
    
    }
    private void OnDestroy()
    {
    
    }
    private void 丁上三不丅丅丈丈七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.dailyQuestItem == 0)
        {
                return;
        }
        
        this.dailyQuestItem.Refresh();
    }
    public MainMenuQuestSystemListener()
    {
    
    }

}
