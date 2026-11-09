using UnityEngine;
internal sealed class PlaceableItemInfoProperties : ScriptableObject
{
    // Fields
    private static PlaceableItemInfoProperties _instance;
    public System.Collections.Generic.List<InfoPropertyData> infoPropertiesList;
    public System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData> _infoPropertiesDict;
    
    // Properties
    public static PlaceableItemInfoProperties Instance { get; }
    public System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData> InfoPropertiesDict { get; }
    
    // Methods
    public static PlaceableItemInfoProperties get_Instance()
    {
        if(PlaceableItemInfoProperties._instance != 0)
        {
                return (PlaceableItemInfoProperties)PlaceableItemInfoProperties._instance;
        }
        
        PlaceableItemInfoProperties._instance = UnityEngine.Resources.Load<PlaceableItemInfoProperties>(path:  "Clans/PlaceableItemSettings/InfoProperties");
        return (PlaceableItemInfoProperties)PlaceableItemInfoProperties._instance;
    }
    public System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData> get_InfoPropertiesDict()
    {
        if(this._infoPropertiesDict != null)
        {
                return (System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData>)this._infoPropertiesDict;
        }
        
        this._infoPropertiesDict = new System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData>();
        List.Enumerator<T> val_2 = this.infoPropertiesList.GetEnumerator();
        label_8:
        if(((-2086769544) & 1) == 0)
        {
            goto label_3;
        }
        
        if((this._infoPropertiesDict.ContainsKey(key:  val_3.m_stringLength)) == true)
        {
            goto label_8;
        }
        
        this._infoPropertiesDict.Add(key:  val_3.m_stringLength, value:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.Dictionary<丑丙上丛万丙丌且丙, InfoPropertyData>)this._infoPropertiesDict;
    }
    public static InfoPropertyData 丑丅丞丝业丄三一世(PlaceableItemSettings 业世丟丐丘丐专与不, 丑丙上丛万丙丌且丙 七丕世三丅上丐丄丐)
    {
        if((七丕世三丅上丐丄丐 - 1) > 12)
        {
                return PlaceableItemInfoProperties.丑丅丞丝业丄三一世(丒与丏丛且万丘业丆:  七丕世三丅上丐丄丐, 丙业与丙丗丝不丈东:  null);
        }
        
        var val_11 = 106043972 + ((七丕世三丅上丐丄丐 - 1)) << 2;
        val_11 = val_11 + 106043972;
        goto (106043972 + ((七丕世三丅上丐丄丐 - 1)) << 2 + 106043972);
    }
    public static InfoPropertyData 丅丞万丆丂七丒与上(PlaceableItemSettings 业世丟丐丘丐专与不, 丑丙上丛万丙丌且丙 七丕世三丅上丐丄丐)
    {
        if((七丕世三丅上丐丄丐 - 1) > 12)
        {
                return PlaceableItemInfoProperties.丑丅丞丝业丄三一世(丒与丏丛且万丘业丆:  七丕世三丅上丐丄丐, 丙业与丙丗丝不丈东:  null);
        }
        
        var val_11 = 106044024 + ((七丕世三丅上丐丄丐 - 1)) << 2;
        val_11 = val_11 + 106044024;
        goto (106044024 + ((七丕世三丅上丐丄丐 - 1)) << 2 + 106044024);
    }
    public static InfoPropertyData 丑丅丞丝业丄三一世(丑丙上丛万丙丌且丙 丒与丏丛且万丘业丆, float 丙业与丙丗丝不丈东)
    {
        丑丙上丛万丙丌且丙 val_11;
        var val_12;
        val_11 = 丒与丏丛且万丘业丆;
        InfoPropertyData val_1 = new InfoPropertyData();
        if(val_1 != null)
        {
                .propertyId = val_11;
        }
        else
        {
                mem[16] = val_11;
        }
        
        .value = 丙业与丙丗丝不丈东;
        val_12 = PlaceableItemInfoProperties.Instance.InfoPropertiesDict;
        if((val_12.ContainsKey(key:  val_11)) == false)
        {
                return val_1;
        }
        
        InfoPropertyData val_7 = PlaceableItemInfoProperties.Instance.InfoPropertiesDict.Item[val_11];
        .nameKey = val_7.nameKey;
        val_12 = PlaceableItemInfoProperties.Instance.InfoPropertiesDict;
        val_11 = val_12.Item[val_11];
        .iconName = val_10.iconName;
        return val_1;
    }
    public PlaceableItemInfoProperties()
    {
        this.infoPropertiesList = new System.Collections.Generic.List<InfoPropertyData>();
    }

}
