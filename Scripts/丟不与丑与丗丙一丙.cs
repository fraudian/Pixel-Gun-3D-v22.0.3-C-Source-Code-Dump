using UnityEngine;
private class BuffSystem.丟不与丑与丗丙一丙
{
    // Fields
    public int 与丈丂一丌三丈丟丅;
    public BuffSystem.SituationBuffType 丁丅丈丌丟世丗丗丟;
    public float 万上一丗上丂丞丁丟;
    public float 七一丅下丄业世七下;
    public float 丂三丟丂丈丐丆丗丟;
    public float 丁丑业专不丘上丁七;
    
    // Methods
    public BuffSystem.丟不与丑与丗丙一丙(BuffSystem.SituationBuffType 丁丅丈丌丟世丗丗丟, float 万上一丗上丂丞丁丟, float 七一丅下丄业世七下, float 丂三丟丂丈丐丆丗丟, int 与丈丂一丌三丈丟丅)
    {
        this.与丈丂一丌三丈丟丅 = 与丈丂一丌三丈丟丅;
        this.丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        this.万上一丗上丂丞丁丟 = 万上一丗上丂丞丁丟;
        this.七一丅下丄业世七下 = 七一丅下丄业世七下;
        this.丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        this.丁丑业专不丘上丁七 = 1800f;
    }
    public BuffSystem.丟不与丑与丗丙一丙(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
    {
        float val_18;
        object val_4 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  System.Convert.ToString(value:  万丝且丘不丑丝下丑.Item["type"]));
        this.丁丅丈丌丟世丗丗丟 = null;
        if((万丝且丘不丑丝下丑.ContainsKey(key:  "health")) != false)
        {
                float val_7 = System.Convert.ToSingle(value:  万丝且丘不丑丝下丑.Item["health"]);
        }
        else
        {
                val_18 = 1f;
        }
        
        this.万上一丗上丂丞丁丟 = val_18;
        if((万丝且丘不丑丝下丑.ContainsKey(key:  "damage")) != false)
        {
                float val_10 = System.Convert.ToSingle(value:  万丝且丘不丑丝下丑.Item["damage"]);
        }
        else
        {
                val_18 = 1f;
        }
        
        this.七一丅下丄业世七下 = val_18;
        this.丁丑业专不丘上丁七 = System.Convert.ToSingle(value:  万丝且丘不丑丝下丑.Item["timeToBuy"]);
        this.与丈丂一丌三丈丟丅 = System.Convert.ToInt32(value:  万丝且丘不丑丝下丑.Item["prior"]);
        this.丂三丟丂丈丐丆丗丟 = System.Convert.ToSingle(value:  万丝且丘不丑丝下丑.Item["time"]);
    }

}
