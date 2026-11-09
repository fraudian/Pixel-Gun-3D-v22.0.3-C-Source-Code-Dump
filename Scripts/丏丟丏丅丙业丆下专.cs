using UnityEngine;
internal sealed class 丏丟丏丅丙业丆下专
{
    // Properties
    internal static bool 丆丁丒丒不一丞下丌 { get; }
    
    // Methods
    internal static bool 一丈丒丑一丏丗丛丈(System.Action 丟万上三丙下丞丝丐)
    {
        CompetitionConnectWindow val_5;
        var val_6;
        if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() != false)
        {
                if(InfoWindowController.丑七不且上丗丁一世() != null)
        {
                val_5 = val_2.competitionConnectWindow;
        }
        else
        {
                val_5 = 0;
        }
        
            if(val_5 != 0)
        {
                InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
            val_4.competitionConnectWindow.丅丆丘丄丙一一丐丙(丞丕不丙万世丘丙上:  丟万上三丙下丞丝丐);
            val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal static bool 专业丄丏丂丌丁世且()
    {
        InfoWindowController val_6 = InfoWindowController.丑七不且上丗丁一世();
        if(val_6 == 0)
        {
                return false;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        val_6 = val_3.competitionConnectWindow;
        if(val_6 == 0)
        {
                return false;
        }
        
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        if(val_5.competitionConnectWindow != null)
        {
                return val_5.competitionConnectWindow.丙东丞丛丝丅世七三();
        }
        
        return val_5.competitionConnectWindow.丙东丞丛丝丅世七三();
    }
    public 丏丟丏丅丙业丆下专()
    {
    
    }

}
