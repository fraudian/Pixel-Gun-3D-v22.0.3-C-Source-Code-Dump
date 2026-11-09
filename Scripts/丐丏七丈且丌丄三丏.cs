using UnityEngine;
internal static class 丐丏七丈且丌丄三丏
{
    // Fields
    internal static readonly int 业丁丙一万专丛丈七;
    internal static readonly int 丛七丞丂下丘丘丘东;
    internal const string 世丄东与丅丂丘一丈 = "clan_lootbox_point_buff";
    internal const string 丏丄丅上丂丅丐上丆 = "clan_silver_buff";
    internal const string 丒丛丗东与丕专丄丄 = "cw_tribute_auto";
    internal static readonly string 与丆丘东且丞丕万不;
    internal static readonly string 丁且丒丆丗上专丒丅;
    internal static readonly string 上一丌丘丙丑丏丄且;
    internal static readonly string 丆丅七一丟且丞丒下;
    internal static readonly string 上丈丐下业丂丕上业;
    internal static readonly string 丟丝且丄丅上丌世专;
    internal static readonly string 且业下下丒不业东不;
    internal static readonly string 丁丂下丂东丏丐丐三;
    internal static readonly string 一专一丒丟且丟丙丅;
    internal static readonly string 不万专丛三丘丆丗与;
    internal static readonly string 丙丕丌丙丌万业丗丌;
    internal static readonly string 丒丝丗专东业丌七世;
    internal static readonly string 丝丁丐丗丟丛世丁七;
    internal static readonly string 丟下丞不丛丒七一丌;
    internal static readonly string 丑丂丑且三丄一丂丛;
    internal static readonly string 丘丅丝丝与一丐丆丌;
    internal static readonly string 丌丛丅丙丌东丂丄丌;
    internal static readonly string 丙不与丝丆丏丏丂业;
    internal static readonly string 下与下不丄丘丟丒丛;
    internal static readonly string 专一丈丄上丂丄世丗;
    internal static readonly string 万世丝七不丒丁丟专;
    internal static readonly string 丌世业丆丐三专丛丆;
    internal static readonly string 业七万下业丞丅一丝;
    internal static readonly string 丂丙丙业上丛丌业丑;
    internal static readonly string 丆丏业丈专丏世丗丙;
    internal static readonly string 不下专丛三丈丌丘不;
    internal static readonly string 丝丈且丌丐不三业丄;
    internal static readonly string 七丌丒丏丟丂丒丑丙;
    internal static readonly string 丝下三丕七丕一万与;
    internal static readonly string 丅丂下丙丘业七丝且;
    internal static readonly string 且丌下丐丐上业上世;
    internal static readonly string 三丗与一丝一丛三业;
    internal static readonly string 丗丘三丞丕下丏丁丑;
    internal static readonly string 丑世丆世丄下丞丝世;
    internal static readonly string 下三丄丝不与丑与东;
    internal static readonly string 丝丞丌与三丞专丄丟;
    internal static readonly string 丑丂丟丄丏上且丝丂;
    internal static readonly string 丄丈不一丈丑丅万丈;
    internal static readonly string 丆世丒丒业丄三与七;
    internal static readonly string 丆丝丙丛万三丐丂世;
    
    // Methods
    internal static Rilisoft.OfferItemType 不丌七丅丆丝丗丌东(丏丒丏上丄七丘丌丅 不丈丒丄丂不业七丗)
    {
        丏丒丏上丄七丘丌丅 val_3;
        var val_4;
        val_3 = 不丈丒丄丂不业七丗;
        if((val_3 - 39) < 3)
        {
                val_4 = mem[106025156 + ((不丈丒丄丂不业七丗 - 39)) << 2];
            val_4 = 106025156 + ((不丈丒丄丂不业七丗 - 39)) << 2;
            return (Rilisoft.OfferItemType)val_4;
        }
        
        val_3 = System.String.Format(format:  "NOT_FOUND CATEGORY FOR {0}", arg0:  val_3);
        UnityEngine.Debug.LogError(message:  val_3);
        val_4 = 0;
        return (Rilisoft.OfferItemType)val_4;
    }
    private static 丐丏七丈且丌丄三丏()
    {
        丐丏七丈且丌丄三丏.丒丛丗东与丕专丄丄 = 0;
        丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东 = 0;
        丐丏七丈且丌丄三丏.与丆丘东且丞丕万不 = "clan_building_governor";
        丐丏七丈且丌丄三丏.丁且丒丆丗上专丒丅 = "clan_building_governor_point";
        丐丏七丈且丌丄三丏.上一丌丘丙丑丏丄且 = "clan_building_black_market";
        丐丏七丈且丌丄三丏.丆丅七一丟且丞丒下 = "clan_building_black_market_point";
        丐丏七丈且丌丄三丏.上丈丐下业丂丕上业 = "clan_building_forge";
        丐丏七丈且丌丄三丏.丟丝且丄丅上丌世专 = "clan_building_forge_point";
        丐丏七丈且丌丄三丏.且业下下丒不业东不 = "clan_building_laboratory";
        丐丏七丈且丌丄三丏.丁丂下丂东丏丐丐三 = "clan_building_laboratory_point";
        丐丏七丈且丌丄三丏.一专一丒丟且丟丙丅 = "primary";
        丐丏七丈且丌丄三丏.不万专丛三丘丆丗与 = "backup";
        丐丏七丈且丌丄三丏.丙丕丌丙丌万业丗丌 = "melee";
        丐丏七丈且丌丄三丏.丒丝丗专东业丌七世 = "special";
        丐丏七丈且丌丄三丏.丝丁丐丗丟丛世丁七 = "sniper";
        丐丏七丈且丌丄三丏.丟下丞不丛丒七一丌 = "premium";
        丐丏七丈且丌丄三丏.丑丂丑且三丄一丂丛 = "KeySmallChest";
        丐丏七丈且丌丄三丏.丘丅丝丝与一丐丆丌 = "KeyBigChest";
        丐丏七丈且丌丄三丏.丌丛丅丙丌东丂丄丌 = "KeyEventChest";
        丐丏七丈且丌丄三丏.丙不与丝丆丏丏丂业 = "SmallChest";
        丐丏七丈且丌丄三丏.下与下不丄丘丟丒丛 = "BigChest";
        丐丏七丈且丌丄三丏.专一丈丄上丂丄世丗 = "MegaChest";
        丐丏七丈且丌丄三丏.万世丝七不丒丁丟专 = "EventChest";
        丐丏七丈且丌丄三丏.丌世业丆丐三专丛丆 = "KeySmallChestBonus";
        丐丏七丈且丌丄三丏.业七万下业丞丅一丝 = "PiggyPoints";
        丐丏七丈且丌丄三丏.丂丙丙业上丛丌业丑 = "EventRouletteSuperSpin";
        丐丏七丈且丌丄三丏.丆丏业丈专丏世丗丙 = "EventChestsSuperSpin";
        丐丏七丈且丌丄三丏.不下专丛三丈丌丘不 = "PixelPassExp";
        丐丏七丈且丌丄三丏.丝丈且丌丐不三业丄 = "PixelPassCurrency";
        丐丏七丈且丌丄三丏.七丌丒丏丟丂丒丑丙 = "CurrencyCompetitionTier1";
        丐丏七丈且丌丄三丏.丝下三丕七丕一万与 = "CurrencyCompetitionTier2";
        丐丏七丈且丌丄三丏.丅丂下丙丘业七丝且 = "MainModeSlotTokens";
        丐丏七丈且丌丄三丏.且丌下丐丐上业上世 = "BattleRoyaleSlotTokens";
        丐丏七丈且丌丄三丏.三丗与一丝一丛三业 = "CaptureSlotTokens";
        丐丏七丈且丌丄三丏.丗丘三丞丕下丏丁丑 = "CompetitiveSlotTokens";
        丐丏七丈且丌丄三丏.丑世丆世丄下丞丝世 = "BrawlsSlotTokens";
        丐丏七丈且丌丄三丏.下三丄丝不与丑与东 = "MainModeSlot";
        丐丏七丈且丌丄三丏.丝丞丌与三丞专丄丟 = "BattleRoyaleSlot";
        丐丏七丈且丌丄三丏.丑丂丟丄丏上且丝丂 = "CaptureSlot";
        丐丏七丈且丌丄三丏.丄丈不一丈丑丅万丈 = "CompetitiveSlot";
        丐丏七丈且丌丄三丏.丆世丒丒业丄三与七 = "BrawlsSlot";
        丐丏七丈且丌丄三丏.丆丝丙丛万三丐丂世 = "PixelBucks";
    }

}
