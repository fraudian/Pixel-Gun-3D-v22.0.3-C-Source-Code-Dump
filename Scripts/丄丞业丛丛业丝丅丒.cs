using UnityEngine;
internal sealed class 丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒
{
    // Fields
    private readonly string <业丞丄丂丄下丞三世>k__BackingField;
    private readonly string <丄万丒丂丗丘丏上丂>k__BackingField;
    
    // Properties
    public string 丒丁丙丞丆丟丑业丈 { get; }
    public string 丟丙丂丞丕丄丐上一 { get; }
    
    // Methods
    private 丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒(string 万丄丅丝三丈丆世丟, string 与丗丆丏丙丟与丒业)
    {
        val_1 = new System.Object();
        this.<业丞丄丂丄下丞三世>k__BackingField = 万丄丅丝三丈丆世丟;
        this.<丄万丒丂丗丘丏上丂>k__BackingField = val_1;
    }
    public string 丞丈业东专丅丆与七()
    {
        return (string)this.<业丞丄丂丄下丞三世>k__BackingField;
    }
    public string 七丝上与丁丏丅业三()
    {
        return (string)this.<丄万丒丂丗丘丏上丂>k__BackingField;
    }
    public override string ToString()
    {
        return "UserId: "("UserId: ") + this.<业丞丄丂丄下丞三世>k__BackingField(this.<业丞丄丂丄下丞三世>k__BackingField) + ", Caller: "(", Caller: ") + this.<丄万丒丂丗丘丏上丂>k__BackingField(this.<丄万丒丂丗丘丏上丂>k__BackingField);
    }
    internal static PGCompany.Offerwall.丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒 东丝七业丄丑丒世七(string 万丄丅丝三丈丆世丟, string 与丗丆丏丙丟与丒业 = "")
    {
        string val_7;
        if(万丄丅丝三丈丆世丟 == null)
        {
            goto label_1;
        }
        
        if(与丗丆丏丙丟与丒业 == null)
        {
            goto label_2;
        }
        
        if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[CreditsListener.Create] userId: "("[CreditsListener.Create] userId: ") + 万丄丅丝三丈丆世丟 + ", caller: "(", caller: ") + 与丗丆丏丙丟与丒业);
        }
        
        丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒 val_3 = new 丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒();
        .<业丞丄丂丄下丞三世>k__BackingField = 万丄丅丝三丈丆世丟;
        .<丄万丒丂丗丘丏上丂>k__BackingField = 与丗丆丏丙丟与丒业;
        PGCompany.Offerwall.丙丛万丁丒丙丆七一.丑七不且上丗丁一世().丆业不丐丟上下丁丞(与丙丛丁三丞丆丟丐:  val_3);
        return (丄丞业丛丛业丝丅丒)val_3;
        label_1:
        val_7 = "userId";
        goto label_7;
        label_2:
        val_7 = "caller";
        label_7:
        null = new System.ArgumentNullException(paramName:  val_7);
    }
    internal void 丑丟丘与丞丙丝丟七(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
    {
        object val_23;
        string val_24;
        var val_26;
        MainMenuController val_27;
        var val_28;
        string val_29;
        string val_30;
        string val_31;
        string val_2 = 0;
        string val_12 = 0;
        PGCompany.Offerwall.丙丛万丁丒丙丆七一 val_1 = PGCompany.Offerwall.丙丛万丁丒丙丆七一.丑七不且上丗丁一世();
        val_1.丐丒丈东世丕丗与丆 = 0;
        val_23 = PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_2);
        bool val_4 = PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一();
        if(val_23 == false)
        {
            goto label_2;
        }
        
        if(val_4 == false)
        {
            goto label_3;
        }
        
        string[] val_5 = new string[8];
        val_5[0] = "[CreditsListener.OnOfferwallAdCredited] actualId: ";
        val_5[1] = val_2;
        val_5[2] = ", UserId: ";
        val_24 = this;
        val_5[3] = this.<业丞丄丂丄下丞三世>k__BackingField;
        val_5[4] = ", Caller: ";
        val_5[5] = this.<丄万丒丂丗丘丏上丂>k__BackingField;
        val_5[6] = ", dictionary: ";
        val_5[7] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑);
        val_23 = +val_5;
        UnityEngine.Debug.Log(message:  val_23);
        goto label_31;
        label_2:
        if(val_4 == false)
        {
            goto label_32;
        }
        
        string[] val_8 = new string[6];
        val_23 = val_8;
        val_23[0] = "[CreditsListener.OnOfferwallAdCredited] TryGetId: false, UserId: ";
        val_23[1] = this.<业丞丄丂丄下丞三世>k__BackingField;
        val_23[2] = ", Caller: ";
        val_23[3] = this.<丄万丒丂丗丘丏上丂>k__BackingField;
        val_23[4] = ", dictionary: ";
        val_23[5] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑);
        string val_10 = +val_8;
        goto label_70;
        label_3:
        val_24 = this.<业丞丄丂丄下丞三世>k__BackingField;
        label_31:
        bool val_11 = System.String.Equals(a:  mem[this.<业丞丄丂丄下丞三世>k__BackingField], b:  val_2, comparisonType:  4);
        if(val_11 == false)
        {
            goto label_53;
        }
        
        bool val_14 = PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一();
        if((val_11.丏世丒丕丘丕且七上(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 七世丄与丌且丁丙下: out  val_12)) == false)
        {
            goto label_54;
        }
        
        if(val_14 != false)
        {
                UnityEngine.Debug.Log(message:  "[CreditsListener.OnOfferwallAdCredited] actualId: "("[CreditsListener.OnOfferwallAdCredited] actualId: ") + val_2 + ", newPendingResponseString: "(", newPendingResponseString: ") + val_12);
        }
        
        PGCompany.Offerwall.丑丟专一丑丆一丒丙.丑七不且上丗丁一世().且且世专与丒丌专世(丙业与丙丗丝不丈东:  val_12);
        val_26 = null;
        val_26 = null;
        val_27 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_27 == 0)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        val_27 = MainMenuController.丄丞丁丈与业上丞丟;
        val_27.丄丙丆业丝丏丗且丒();
        return;
        label_32:
        val_29 = this.<业丞丄丂丄下丞三世>k__BackingField;
        val_30 = this.<丄万丒丂丗丘丏上丂>k__BackingField;
        val_31 = "[CreditsListener.OnOfferwallAdCredited] TryGetId: false, UserId: ";
        goto label_68;
        label_53:
        if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() == false)
        {
            goto label_69;
        }
        
        string val_20 = "[CreditsListener.OnOfferwallAdCredited] UserId != actualId. dictionary: "("[CreditsListener.OnOfferwallAdCredited] UserId != actualId. dictionary: ") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑));
        goto label_70;
        label_54:
        if(val_14 == false)
        {
                return;
        }
        
        val_27 = "[CreditsListener.OnOfferwallAdCredited] actualId: "("[CreditsListener.OnOfferwallAdCredited] actualId: ") + val_2 + ", wasUpdated: false"(", wasUpdated: false");
        UnityEngine.Debug.Log(message:  val_27);
        return;
        label_69:
        val_29 = this.<业丞丄丂丄下丞三世>k__BackingField;
        val_30 = this.<丄万丒丂丗丘丏上丂>k__BackingField;
        val_31 = "[CreditsListener.OnOfferwallAdCredited] UserId != actualId. UserId: ";
        label_68:
        label_70:
        val_27 = val_31 + val_29 + ", Caller: "(", Caller: ") + val_30;
        UnityEngine.Debug.LogWarning(message:  val_27);
    }
    internal void 不丂丝丏三丛丛万丂(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不)
    {
        PGCompany.Offerwall.丙丛万丁丒丙丆七一 val_1 = PGCompany.Offerwall.丙丛万丁丒丙丆七一.丑七不且上丗丁一世();
        val_1.丐丒丈东世丕丗与丆 = 0;
        if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        object[] val_3 = new object[7];
        val_3[0] = "CreditsListener.OnGetOfferwallCreditsFailed";
        val_3[1] = "error";
        val_3[2] = 丂七东不不丈一丐不;
        val_3[3] = "UserId";
        val_3[4] = this.<业丞丄丂丄下丞三世>k__BackingField;
        val_3[5] = "Caller";
        val_3[6] = this.<丄万丒丂丗丘丏上丂>k__BackingField;
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "[{0}] {1}: {2}, {3}: {4}, {5}: {6}", args:  val_3));
    }
    private bool 丏世丒丕丘丕且七上(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, out string 七世丄与丌且丁丙下)
    {
        object val_20;
        string val_21;
        object val_22;
        string val_23;
        string val_3 = 0;
        if(万丝且丘不丑丝下丑 == null)
        {
            goto label_1;
        }
        
        if(万丝且丘不丑丝下丑.Count == 0)
        {
            goto label_2;
        }
        
        val_20 = PGCompany.Offerwall.丑丟专一丑丆一丒丙.丑七不且上丗丁一世();
        if((val_20.下丆与与丛丕丄丌丕(丙业与丙丗丝不丈东: out  val_3)) == false)
        {
            goto label_4;
        }
        
        if((PGCompany.丄丙与丄丛丒丟下丛.东一万丈丘业丂丂丑(丌丏不下一与丛丙丝:  val_3, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false})) == false)
        {
            goto label_5;
        }
        
        PGCompany.丄丙与丄丛丒丟下丛 val_6 = PGCompany.丄丙与丄丛丒丟下丛.且丘万丙丝丈丆专与(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑);
        if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[CreditsListener.TryUpdatePendingResponse] incomingResponse: "("[CreditsListener.TryUpdatePendingResponse] incomingResponse: ") + val_6.<丝专丑丛业专世丘丅>k__BackingField(val_6.<丝专丑丛业专世丘丅>k__BackingField));
        }
        
        val_20 = 0;
        PGCompany.丄丙与丄丛丒丟下丛 val_10 = PGCompany.Offerwall.万丁七三丏专世一丆.丑七不且上丗丁一世().一且丌丛七丛不业专(丈丂丕下丏丈丞丗业:  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false}, 丂丌丌丛丆丆丙丌丈:  new PGCompany.丄丙与丄丛丒丟下丛() {<丝专丑丛业专世丘丅>k__BackingField = val_6.<丝专丑丛业专世丘丅>k__BackingField, <三丄世丝丑丂丄与丟>k__BackingField = val_6.<三丄世丝丑丂丄与丟>k__BackingField, <且不三万丒东专丕下>k__BackingField = val_6.<且不三万丒东专丕下>k__BackingField});
        val_21;
        return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_21 = val_23, 丄丙下丝丛丒七丂丘: out  string val_11 = 七世丄与丌且丁丙下);
        label_1:
        val_22 = "[CreditsListener.TryUpdatePendingResponse] dictionary: null";
        goto label_15;
        label_2:
        val_22 = "[CreditsListener.TryUpdatePendingResponse] Count: 0";
        label_15:
        UnityEngine.Debug.LogWarning(message:  val_22);
        val_21 = 0;
        bool val_12 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_21, 丄丙下丝丛丒七丂丘: out  val_11);
        return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_21, 丄丙下丝丛丒七丂丘: out  val_11);
        label_4:
        val_23 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑);
        if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() == false)
        {
            goto label_22;
        }
        
        val_20 = "[CreditsListener.TryUpdatePendingResponse] incomingDictionary: "("[CreditsListener.TryUpdatePendingResponse] incomingDictionary: ") + val_23;
        UnityEngine.Debug.Log(message:  val_20);
        goto label_22;
        label_5:
        val_23 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑);
        val_20 = "[CreditsListener.TryUpdatePendingResponse] incomingDictionary: "("[CreditsListener.TryUpdatePendingResponse] incomingDictionary: ") + val_23 + ", oldResponseString: "(", oldResponseString: ") + val_3;
        UnityEngine.Debug.LogWarning(message:  val_20);
        label_22:
        return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_21, 丄丙下丝丛丒七丂丘: out  val_11);
    }

}
