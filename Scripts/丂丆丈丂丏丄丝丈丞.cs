using UnityEngine;
internal class 丂丆丈丂丏丄丝丈丞
{
    // Fields
    private static string 丕丄世丘与丄不丕丛;
    internal System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct> 三丛丁万且丌丘下丕;
    
    // Methods
    internal void 丗丗丏不丗专丙丆丕()
    {
        var val_7;
        .notificationFlags = this.三丛丁万且丌丘下丕;
        var val_7 = 0;
        val_7 = val_7 + 1;
        string val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  new SerializedNotifications());
        val_7 = null;
        val_7 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  丂丆丈丂丏丄丝丈丞.丕丄世丘与丄不丕丛, 下下丏一丙不丘丌丞:  val_4);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[ClanN_otif] Saved to storager:"("[ClanN_otif] Saved to storager:") + val_4);
    }
    internal void 一丒丙不丂丐丐丐万()
    {
        var val_10;
        object val_18;
        var val_19;
        System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct> val_21;
        var val_22;
        val_18 = this;
        val_19 = null;
        val_19 = null;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  丂丆丈丂丏丄丝丈丞.丕丄世丘与丄不丕丛);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
        {
                return;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        if((DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝() != null) && (val_1 != null))
        {
                this.三丛丁万且丌丘下丕 = val_1;
        }
        else
        {
                System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct> val_5 = null;
            val_21 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct>();
            this.三丛丁万且丌丘下丕 = val_21;
        }
        
        val_22 = public System.Int32 System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct>::get_Count();
        if(val_5.Count < 1)
        {
            goto label_60;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = val_5.GetEnumerator();
        label_43:
        if(((-353880096) & 1) == 0)
        {
            goto label_21;
        }
        
        object[] val_11 = new object[6];
        val_11[0] = "[ClanN_otif] ";
        val_11[1] = val_10.丙东专丂世丈丏丁丂();
        val_11[2] = "|";
        val_11[3] = 0;
        val_11[4] = "|";
        val_11[5] = val_10.ToString();
        UnityEngine.Debug.Log(message:  +val_11);
        goto label_43;
        label_21:
        val_22 = public System.Void Dictionary.Enumerator<ClanNotificationType, NotificationResponseStruct>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_60:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        val_18 = "[ClanN_otif] Loaded from storager:"("[ClanN_otif] Loaded from storager:") + val_5;
        UnityEngine.Debug.Log(message:  val_18);
    }
    internal bool 世上一不丄丂丐不丕(ClanNotificationType 业丄七丙丛上专专丕)
    {
        if(this.三丛丁万且丌丘下丕 != null)
        {
                return this.三丛丁万且丌丘下丕.ContainsKey(key:  业丄七丙丛上专专丕);
        }
        
        return this.三丛丁万且丌丘下丕.ContainsKey(key:  业丄七丙丛上专专丕);
    }
    internal void 丄丄上且丛丒万丙七(ClanNotificationType 业丄七丙丛上专专丕, System.Nullable<NotificationResponseStruct> 丑与丂丌世丕丆一丗)
    {
        if(丑与丂丌世丕丆一丗.HasValue.HasValue == false)
        {
                return;
        }
        
        if((this.世上一不丄丂丐不丕(业丄七丙丛上专专丕:  业丄七丙丛上专专丕)) != false)
        {
                this.丙丈丅上下丕丞丗丐(业丄七丙丛上专专丕:  业丄七丙丛上专专丕, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = 丑与丂丌世丕丆一丗.HasValue, counter = 丑与丂丌世丕丆一丗.HasValue, countOnView = -353608512, isViewd = true});
            return;
        }
        
        bool val_3 = this.且丝下丐丆下丝丑丏(业丄七丙丛上专专丕:  业丄七丙丛上专专丕, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = 丑与丂丌世丕丆一丗.HasValue, counter = 丑与丂丌世丕丆一丗.HasValue, countOnView = -353608512, isViewd = true});
    }
    internal bool 且丝下丐丆下丝丑丏(ClanNotificationType 业丄七丙丛上专专丕, NotificationResponseStruct 丑与丂丌世丕丆一丗)
    {
        object val_5;
        var val_6;
        val_5 = 丑与丂丌世丕丆一丗.countOnView;
        if((this.三丛丁万且丌丘下丕.ContainsKey(key:  业丄七丙丛上专专丕)) != false)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5 = "[ClanN_otif] " + 业丄七丙丛上专专丕.ToString() + " already exists in notification flags";
            UnityEngine.Debug.Log(message:  val_5);
        }
        
            val_6 = 0;
            return (bool)val_6;
        }
        
        this.三丛丁万且丌丘下丕.Add(key:  业丄七丙丛上专专丕, value:  new NotificationResponseStruct() {hasNotif = 丑与丂丌世丕丆一丗.hasNotif, counter = 丑与丂丌世丕丆一丗.counter, countOnView = val_5, isViewd = 丑与丂丌世丕丆一丗.isViewd});
        val_6 = 1;
        return (bool)val_6;
    }
    internal void 丙丈丅上下丕丞丗丐(ClanNotificationType 业丄七丙丛上专专丕, NotificationResponseStruct 丑与丂丌世丕丆一丗)
    {
        bool val_7 = 丑与丂丌世丕丆一丗.hasNotif;
        if((val_7 & 255) == false)
        {
            goto label_1;
        }
        
        NotificationResponseStruct val_2 = this.三丛丁万且丌丘下丕.Item[业丄七丙丛上专专丕];
        val_7 = (val_7 & (-4294967296)) | 1;
        if(this.三丛丁万且丌丘下丕 != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.三丛丁万且丌丘下丕.set_Item(key:  业丄七丙丛上专专丕, value:  new NotificationResponseStruct() {hasNotif = val_7, counter = val_7, countOnView = val_2.hasNotif >> 32, isViewd = val_2.hasNotif >> 32});
        return;
        label_1:
        NotificationResponseStruct val_5 = this.三丛丁万且丌丘下丕.Item[业丄七丙丛上专专丕];
        bool val_8 = val_5.hasNotif;
        NotificationResponseStruct val_6 = this.三丛丁万且丌丘下丕.Item[业丄七丙丛上专专丕];
        val_8 = val_8 & (-4294967296);
        if(this.三丛丁万且丌丘下丕 != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    internal void 丅丘东丂丁七丏一丏()
    {
        this.三丛丁万且丌丘下丕.Clear();
    }
    internal NotificationResponseStruct 丘一丗丘一丙丛丌丕(ClanNotificationType 业丄七丙丛上专专丕)
    {
        var val_3;
        ClanNotificationType val_4;
        if((this.三丛丁万且丌丘下丕.ContainsKey(key:  业丄七丙丛上专专丕)) != false)
        {
                val_3 = this.三丛丁万且丌丘下丕;
            val_4 = 业丄七丙丛上专专丕;
            NotificationResponseStruct val_2 = val_3.Item[val_4];
            return new NotificationResponseStruct() {hasNotif = false, isViewd = false};
        }
        
        val_3 = 0;
        val_4 = 0;
        return new NotificationResponseStruct() {hasNotif = false, isViewd = false};
    }
    public 丂丆丈丂丏丄丝丈丞()
    {
        this.三丛丁万且丌丘下丕 = new System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct>();
    }
    private static 丂丆丈丂丏丄丝丈丞()
    {
        丂丆丈丂丏丄丝丈丞.丕丄世丘与丄不丕丛 = "C_lanN_otifications";
    }

}
