using UnityEngine;
internal sealed class VIPNotificationController : MonoBehaviour
{
    // Fields
    private const string 丑丝万且丑丛丏丅丑 = "OfferIcons/MiniOfferIcons/offer_icon_VIP";
    private const string 且丝丈七不丗且世东 = "vip_time_left_shown_key";
    private const string 丐业东与三丐丐丐丝 = "vip_expired_shown_key";
    private const string 丕丟一丟丘丅下丑丗 = "Snd/VIP_client";
    internal const int 丟丄丆万丌丝一丈丏 = 12;
    private static UnityEngine.Texture 丛丁且丘丑丟丅一丟;
    private static UnityEngine.AudioClip 丂三丟丂丝专丈丒丛;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.七东丅丙东业丈不下());
    }
    internal static void Reset()
    {
        VIPNotificationController.丈丘下不不与丗下不();
        VIPNotificationController.下丘专丌丕丝世丕丅();
    }
    internal static void 丈丘下不不与丗下不()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "vip_time_left_shown_key", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static void 下丘专丌丕丝世丕丅()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "vip_expired_shown_key", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private System.Collections.IEnumerator 七东丅丙东业丈不下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VIPNotificationController.一丘世不万丁东丑丝();
    }
    public void TryShowTimeLeftMessage()
    {
        var val_15 = Rilisoft.Singleton<Rilisoft.VIPController>.Instance;
        if(val_15.下一与丄丄丆三丝丐() == false)
        {
                return;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "vip_time_left_shown_key", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
                return;
        }
        
        val_15 = Rilisoft.Singleton<Rilisoft.VIPController>.Instance;
        if(val_15.东且丅业七丂丌不上() > 43199)
        {
                return;
        }
        
        if(VIPNotificationController.丛丁且丘丑丟丅一丟 == 0)
        {
                VIPNotificationController.丛丁且丘丑丟丅一丟 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
        }
        
        InfoWindowController.丙丈与丙丑丁东业七(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4087"), 世丙丁丗业丝世丕丈:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4080"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)), 不且丁丐不丌丟上丌:  VIPNotificationController.丛丁且丘丑丟丅一丟, 不上丏上丝丆一丛丑:  "");
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "vip_time_left_shown_key", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void TryShowVipExpiredMessage()
    {
        if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) == true)
        {
                return;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "vip_expired_shown_key", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 1)
        {
                return;
        }
        
        if(VIPNotificationController.丛丁且丘丑丟丅一丟 == 0)
        {
                VIPNotificationController.丛丁且丘丑丟丅一丟 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
        }
        
        InfoWindowController.丙丈与丙丑丁东业七(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4087"), 世丙丁丗业丝世丕丈:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4081"), 不且丁丐不丌丟上丌:  VIPNotificationController.丛丁且丘丑丟丅一丟, 不上丏上丝丆一丛丑:  "");
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "vip_expired_shown_key", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static void 丗丂一业且七世丄下(int 丆丐七丅丆丗丛上与)
    {
        string val_16;
        int val_17;
        string val_18;
        if(VIPNotificationController.丛丁且丘丑丟丅一丟 == 0)
        {
                VIPNotificationController.丛丁且丘丑丟丅一丟 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
        }
        
        if(VIPNotificationController.丂三丟丂丝专丈丒丛 == 0)
        {
                VIPNotificationController.丂三丟丂丝专丈丒丛 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/VIP_client");
        }
        
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4087");
        System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  (double)丆丐七丅丆丗丛上与);
        val_17 = System.String.alignConst;
        if(val_6._ticks.Hours < 1)
        {
            goto label_11;
        }
        
        val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5026");
        double val_9 = val_6._ticks.TotalHours;
        goto label_14;
        label_11:
        if(val_6._ticks.Days < 1)
        {
            goto label_15;
        }
        
        val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4079");
        label_14:
        val_17 = System.String.Format(format:  val_18, arg0:  (int)val_6._ticks.TotalDays);
        label_15:
        InfoWindowController.丙丈与丙丑丁东业七(丕丗丘丑丛与丑业丒:  val_16, 世丙丁丗业丝世丕丈:  val_17, 不且丁丐不丌丟上丌:  VIPNotificationController.丛丁且丘丑丟丅一丟, 不上丏上丝丆一丛丑:  "");
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_16 = VIPNotificationController.丂三丟丂丝专丈丒丛;
        UnityEngine.AudioSource val_15 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_16);
    }
    private void Update()
    {
    
    }
    public VIPNotificationController()
    {
    
    }

}
