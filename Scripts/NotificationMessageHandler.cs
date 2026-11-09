using UnityEngine;
internal class NotificationMessageHandler : PGBehaviour
{
    // Fields
    public ClanNotificationType notificationType;
    private NotificationMessageController 丛三不丟与丌丞与三;
    public UnityEngine.GameObject newMessageSprite;
    public UILabel countLabel;
    
    // Methods
    private void OnEnable()
    {
        NotificationMessageController val_1 = Rilisoft.Singleton<NotificationMessageController>.Instance;
        this.丛三不丟与丌丞与三 = val_1;
        val_1.下丌业业丐丘丐丘三(丁丅丈丌丟世丗丗丟:  this.notificationType);
        NotificationMessageController.丒丅丏七丈丗东与丗(丙业与丙丗丝不丈东:  new System.Action<ClanNotificationType, NotificationResponseStruct>(object:  this, method:  System.Void NotificationMessageHandler::上丌丗下下丂丁世丘(ClanNotificationType 万且万且丑丗且丌丆, NotificationResponseStruct 丑与丂丌世丕丆一丗)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newMessageSprite, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        NotificationMessageController val_1 = Rilisoft.Singleton<NotificationMessageController>.Instance;
        this.丛三不丟与丌丞与三 = val_1;
        val_1.万不丒上丕丗丂丘丒(丁丅丈丌丟世丗丗丟:  this.notificationType);
        NotificationMessageController.丙一丈万丟丗丘丏三(丙业与丙丗丝不丈东:  new System.Action<ClanNotificationType, NotificationResponseStruct>(object:  this, method:  System.Void NotificationMessageHandler::上丌丗下下丂丁世丘(ClanNotificationType 万且万且丑丗且丌丆, NotificationResponseStruct 丑与丂丌世丕丆一丗)));
    }
    private void 上丌丗下下丂丁世丘(ClanNotificationType 万且万且丑丗且丌丆, NotificationResponseStruct 丑与丂丌世丕丆一丗)
    {
        UnityEngine.GameObject val_7;
        UILabel val_8;
        val_7 = 万且万且丑丗且丌丆;
        val_8 = this;
        if(this.notificationType != val_7)
        {
                return;
        }
        
        val_7 = this.newMessageSprite;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = this.newMessageSprite;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  (丑与丂丌世丕丆一丗.hasNotif != true) ? 1 : 0);
        if((丑与丂丌世丕丆一丗.hasNotif & 255) == false)
        {
                return;
        }
        
        val_7 = this.countLabel;
        if((丑与丂丌世丕丆一丗.hasNotif >> 32) == false)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
        
        val_8 = this.countLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_8, 丕丗丘丑丛与丑业丒:  ToString());
    }
    public NotificationMessageHandler()
    {
    
    }

}
