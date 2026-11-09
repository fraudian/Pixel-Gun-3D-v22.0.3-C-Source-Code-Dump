using UnityEngine;
internal static class 丑七丕丛丐丌七丙丄
{
    // Methods
    internal static void 下万丆七丙下与丂丞(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝, 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 三丂丞丒一与且丈丆)
    {
        int val_91;
        var val_92;
        var val_93;
        var val_94;
        int val_95;
        var val_96;
        int val_97;
        var val_98;
        Rilisoft.七丕丟丏三丈一丄世 val_99;
        var val_100;
        var val_101;
        var val_102;
        OnlineModeController val_103;
        var val_104;
        var val_105;
        var val_106;
        var val_107;
        int val_108;
        double val_109;
        double val_110;
        var val_111;
        int val_112;
        val_91 = 丞丙下万丗丝丄七丝;
        if(ExperienceController.丞丞丘业东丙丏七丌() == 1)
        {
                UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.Equals(a:  val_2.m_Handle.name, b:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七(), comparisonType:  5)) != false)
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  28);
        }
        
            UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.Equals(a:  val_6.m_Handle.name, b:  PGCompany.丁东丌世与丕东丆上.丈丝丘丑丞丗丐丒丆(), comparisonType:  5)) != false)
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  33);
        }
        
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() == 2)
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  39);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.上丗专丌丁一三丞世(下与丗丕专丅丕丗丌:  ExpController.丑七不且上丗丁一世().丆丝丁丞丙上万三一(), 三丁丙丌业不丆丂与:  丞丙下万丗丝丄七丝.且七丙丁与丌丗与上 + 1);
            val_92 = 丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙();
        }
        else
        {
                val_92 = 丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙();
        }
        
        val_92.丁丝丑丆丟东丝专万(丑一丂丙丈丝丑丅丑:  (丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛 == true) ? 1 : 0);
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "DaterDayLived", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "DaterDayLived", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_93 = null;
            val_93 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                val_94 = null;
            val_94 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟下丗丙丕丁丞丞丛]);
        }
        else
        {
                if((UnityEngine.PlayerPrefs.GetString(key:  "MaxKill", defaultValue:  "9").Equals(value:  "")) != false)
        {
                val_95 = 5;
        }
        else
        {
                val_95 = System.Int32.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  "MaxKill", defaultValue:  "5"));
        }
        
        }
        
            Rilisoft.一丟专且三万丞丁丂.东下专丟专丏业七业(东且丒丘下万丐世下:  val_95, 不且东三三丐世下丝:  false);
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "End match");
        }
        
        int val_30 = (UnityEngine.PlayerPrefs.GetInt(key:  "CountMatch", defaultValue:  0)) + 1;
        UnityEngine.PlayerPrefs.SetInt(key:  "CountMatch", value:  val_30);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_31 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_31.Add(key:  "count", value:  val_30);
        Rilisoft.丝丄三业丙专丛与不.东三丆丁三下七丑上(丝丏业丅丈东业丝丒:  "games_multiplayer_count", 丗丟上上丒丐丗丞丙:  val_31);
        if(((GameConnect.丑丌丛丈丅丅与不业() != 2) && (GameConnect.丑丌丛丈丅丅与不业() != 28)) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_73;
        }
        
        }
        
        }
        
        val_96 = null;
        val_96 = null;
        Rilisoft.一丟专且三万丞丁丂.丅丆丏丄丄世且专丝(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 七丆丂丂下丈且丟世:  丙且上丒不下丑下丞(), 万丌丐业丈丛丁下丛:  丞丙下万丗丝丄七丝.丞丆丞丘与三万丈丛);
        label_73:
        丁一业专丈三丄丘专.与一丅丝不丈业与丙().丂且不业丂专丛丆东();
        val_97 = 1152921505189646336;
        val_98 = null;
        val_98 = null;
        丁一业专丈三丄丘专 val_40 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        val_99 = GameConnect.丑丌丛丈丅丅与不业();
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 == 0)
        {
            goto label_92;
        }
        
        if(val_40 != null)
        {
            goto label_96;
        }
        
        goto label_95;
        label_92:
        val_100 = 0;
        if(val_40 != null)
        {
            goto label_96;
        }
        
        label_95:
        label_96:
        val_40.不丄与丟丌世丐与专(丂丛丑东不丅丈一东:  val_99, 丞丁丑丏丄丏七丂不:  0);
        if(丞丙下万丗丝丄七丝.丅且丅且丙丘丗万丞 != false)
        {
            
        }
        else
        {
                if(丞丙下万丗丝丄七丝.万丏且七丟丕丄丈上 != false)
        {
                val_101 = 3;
        }
        else
        {
                if(丞丙下万丗丝丄七丝.丗与丒丒且万丄万万 != false)
        {
                val_101 = 2;
        }
        
        }
        
        }
        
        val_102 = null;
        val_102 = null;
        val_103 = GameController.onlineMode;
        if(val_103 != 0)
        {
                val_104 = null;
            val_104 = null;
            if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != false)
        {
                val_103 = 三丂丞丒一与且丈丆.下丅丌丌丆不东专丁;
            val_105 = null;
            val_105 = null;
            Rilisoft.一丟专且三万丞丁丂.丝万丄一丐丘一丒东(业东丞丏丒业万丏丘:  (val_103 > 0) ? 1 : 0, 丙世不不一丏业三且:  (SquadController.丘业不丅万不丐东丝 == true) ? 1 : 0);
            Rilisoft.一丟专且三万丞丁丂.丆丕丈丆下丛丒上丛(丙世不不一丏业三且:  SquadController.丘业不丅万不丐东丝);
        }
        
        }
        
        val_106 = null;
        val_106 = null;
        if(GameController.onlineMode.丅丅丌丞七东丂上丙 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 0)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 2)
        {
            goto label_125;
        }
        
        }
        
            if(GameConnect.丑丌丛丈丅丅与不业() != 0)
        {
                var val_50 = (丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛 == true) ? 1 : 0;
        }
        
            val_107 = null;
            val_107 = null;
            val_99 = 丙且上丒不下丑下丞();
            Rilisoft.一丟专且三万丞丁丂.丏丏丄丙丅丄与丝丂(丝丘丅丑东与东丕世:  (丞丙下万丗丝丄七丝.且七丙丁与丌丗与上 < 3) ? 1 : 0, 丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  val_99);
        }
        
        label_125:
        if(丞丙下万丗丝丄七丝.丘三三东且丈丅丈丛 == false)
        {
            goto label_208;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_103 = 0;
        }
        else
        {
                val_103 = 丞丙下万丗丝丄七丝.丂丌丙丝且东丗丙万;
        }
        
        double val_89 = 丞丙下万丗丝丄七丝.丏丏业东上七丐万东;
        val_89 = val_89 * 60;
        if(val_89 >= 0f)
        {
            goto label_145;
        }
        
        if(val_89 != (-0.5))
        {
            goto label_146;
        }
        
        val_108 = val_30;
        val_109 = -1;
        goto label_147;
        label_145:
        if(val_89 != 0.5)
        {
            goto label_148;
        }
        
        val_108 = val_30;
        val_109 = 1;
        label_147:
        val_109 = val_108 + val_109;
        var val_55 = (((long)val_108 & 1) != 0) ? (val_108) : (val_109);
        goto label_150;
        label_146:
        double val_56 = val_89 + (-0.5);
        goto label_150;
        label_148:
        double val_57 = val_89 + 0.5;
        label_150:
        if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_156;
        }
        
        }
        
        val_110 = System.Math.Round(value:  丞丙下万丗丝丄七丝.丌丑丁上丂丙与丈丞, digits:  2);
        label_156:
        if(((NetworkStartTable.与一专丒东丏丘专丕() != true) && (GameConnect.一与东丝万上三丆丏() != false)) && (TeamDuelController.丅丌丛丏丞上万丛丕 != 0))
        {
                val_111 = mem[TeamDuelController.丅丌丛丏丞上万丛丕 + 144];
            val_111 = TeamDuelController.丅丌丛丏丞上万丛丕 + 144;
        }
        else
        {
                val_111 = 0;
        }
        
        val_99 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.SceneManagement.Scene val_67 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_97 = 丞丙下万丗丝丄七丝.万且丒下丕丝专丟上;
        PGCompany.Analytics.一业丗丆世世上丁且.丘丒丑业一丗丞丁丛(丆丛丑世下一丐且丕:  val_99, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 丏丈丗世丙万丆丐丅:  val_67.m_Handle.name, 丌三丒丌丆东万丆一:  (丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛 == true) ? 1 : 0, 专世专丟丝丌与丘上:  丞丙下万丗丝丄七丝.且七丙丁与丌丗与上 + 1, 与丈业丛丝丒丙一丏:  val_110, 丝丐丐丟丙丆一丄丗:  0, 下丝丘丁专丐丅丛丝:  val_97, 丞丗丄七专丈丕丕业:  val_103, 丕丈一丐丛世丆上万:  new RatingSystem.丁上且上一丆丘与业() {丈丘丙丛丗不七专丟 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丈丐丒丐丕丛东丑业 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丗丛世世丙丝丌与丑 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丙东与与万丌丟专丛 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丂丆与与丐丕丘不丌 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 不丐丈丁一丘丄丐丅 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万}, 万三丟世三一不专丛:  (丞丙下万丗丝丄七丝.七与上丝上与丏丞丂 == false) ? 4 : (0 + 1));
        if(((((((((GameConnect.丅业东业丞七上丞丑() != true) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && (GameConnect.丑丌丛丈丅丅与不业() != 38)) && (GameConnect.丑丌丛丈丅丅与不业() != 0)) && (GameConnect.业丛丛丂一丆丕丗丟() != true)) && (GameConnect.东且三丆丑世世丘丟() != true)) && (GameConnect.东丒七专丂世丝丏丗() != true)) && (GameConnect.丑丌丛丈丅丅与不业() != 30)) && (GameConnect.丑丌丛丈丅丅与不业() != 0))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_208;
        }
        
        }
        
        }
        
        val_103 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        PGCompany.Analytics.一业丗丆世世上丁且.丆丛业上丛丒三丆丗(丆丛丑世下一丐且丕:  val_103, 三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 下丝丘丁专丐丅丛丝:  丞丙下万丗丝丄七丝.万且丒下丕丝专丟上, 丞丗丄七专丈丕丕业:  丞丙下万丗丝丄七丝.丂丌丙丝且东丗丙万);
        label_208:
        if(GameConnect.一业上七丟业且业丙() == false)
        {
                return;
        }
        
        val_103 = 丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛;
        val_91 = 丞丙下万丗丝丄七丝.且七丙丁与丌丗与上 + 1;
        if(val_103 != false)
        {
                val_112 = System.String.alignConst;
        }
        else
        {
                万与专世三世丝业丏 val_86 = RedLightController.Instance.一且三万专东丏不丞();
            val_99 = val_86;
            val_112 = val_86.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.七万且丂丝丛一丘丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且东丝丏下万丒丘下:  val_103, 丐业不不丂丐丄七丙:  val_91, 丒三丅业丝丟三丒丅:  val_112);
    }

}
