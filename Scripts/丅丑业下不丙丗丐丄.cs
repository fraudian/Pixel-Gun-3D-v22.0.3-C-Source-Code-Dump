using UnityEngine;
public class 丅丑业下不丙丗丐丄 : 万丑丅丆东三万不丒
{
    // Fields
    public int 丏丂丁丁丏丛丙丙上;
    public int 丑丅丅与与三丅丘丆;
    
    // Methods
    public override string ToString()
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(X21 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(X21 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = null;
        val_1[1] = val_1.Length;
        val_1[2] = this.丑丅丅与与三丅丘丆;
        val_1[3] = this.丏丂丁丁丏丛丙丙上;
        return (string)System.String.Format(format:  "TypedLobbyInfo \'{0}\'[{1}] rooms: {2} players: {3}", args:  val_1);
    }
    public 丅丑业下不丙丗丐丄()
    {
    
    }

}
