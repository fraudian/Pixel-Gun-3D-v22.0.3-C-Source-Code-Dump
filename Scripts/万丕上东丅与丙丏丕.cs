using UnityEngine;
public class ClansInviteGuiController.万丕上东丅与丙丏丕
{
    // Fields
    public int 东丝世世丗专丟丏丘;
    public string 丄丏丆丝世丙业下丌;
    public string 丞丞下东且丗丄丒丏;
    public int 专世专丟丝丌与丘上;
    public Rilisoft.七下上丝三丛三上一 丝丝不丝上丂三丌世;
    public ClansInviteGuiController.不丑丙丒专丟丕丘丙 丁丅丈丌丟世丗丗丟;
    
    // Methods
    public ClansInviteGuiController.万丕上东丅与丙丏丕(string 丄丏丆丝世丙业下丌, ClansInviteGuiController.不丑丙丒专丟丕丘丙 丁丅丈丌丟世丗丗丟)
    {
        var val_14;
        Rilisoft.七下上丝三丛三上一 val_15;
        this.丄丏丆丝世丙业下丌 = 丄丏丆丝世丙业下丌;
        this.丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        this.专世专丟丝丌与丘上 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().七丙丞且世七丙丐下(丄丒且丙三丆丟与丏:  丄丏丆丝世丙业下丌);
        this.丝丝不丝上丂三丌世 = 4;
        this.东丝世世丗专丟丏丘 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().七丛丂丟丐三下丝丏(丄丒且丙三丆丟与丏:  丄丏丆丝世丙业下丌);
        this.丞丞下东且丗丄丒丏 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  丄丏丆丝世丙业下丌);
        val_14 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        if((val_14.ContainsKey(key:  丄丏丆丝世丙业下丌)) == false)
        {
                return;
        }
        
        val_14 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        System.Collections.Generic.Dictionary<System.String, System.String> val_12 = val_14.Item[丄丏丆丝世丙业下丌];
        if(val_12 != null)
        {
                int val_13 = FriendsWindowController.丏丕专一丞不丟丑丗(丄且丆丘丆丏丄且东:  val_12);
        }
        else
        {
                val_15 = 4;
        }
        
        this.丝丝不丝上丂三丌世 = val_15;
    }

}
