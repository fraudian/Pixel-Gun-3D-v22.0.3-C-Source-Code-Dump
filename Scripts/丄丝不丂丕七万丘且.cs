using UnityEngine;
internal static class 丄丝不丂丕七万丘且
{
    // Methods
    internal static void 东丝七丛丄丙丝三七(UnityEngine.GameObject 上丞不世东丛东下丒, 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, string, float, int, int> 丌专业且丛丏丞丝且, CategoryNames 七丆丒与丗丌丄且丂, WeaponSounds 丐丑七万丌丂专与丌)
    {
        float val_84;
        UnityEngine.Object val_98;
        var val_99;
        float val_100;
        UnityEngine.Vector3 val_101;
        UnityEngine.Vector3 val_104;
        float val_107;
        UnityEngine.GameObject val_108;
        var val_109;
        var val_110;
        string val_111;
        UnityEngine.GameObject val_112;
        var val_113;
        UnityEngine.Object val_114;
        var val_115;
        float val_116;
        UnityEngine.Object val_118;
        UnityEngine.Mesh val_119;
        var val_120;
        UnityEngine.Mesh val_121;
        var val_122;
        val_98 = 上丞不世东丛东下丒;
        val_99 = 1152921504838316032;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_5;
        }
        
        if(丐丑七万丌丂专与丌 == null)
        {
            goto label_6;
        }
        
        val_100 = 丐丑七万丌丂专与丌.scaleShop;
        val_101 = 丐丑七万丌丂专与丌.positionShop;
        val_104 = 丐丑七万丌丂专与丌.rotationShop;
        goto label_7;
        label_5:
        if(七丆丒与丗丌丄且丂 <= 13000)
        {
            goto label_8;
        }
        
        if(七丆丒与丗丌丄且丂 <= 150000)
        {
            goto label_9;
        }
        
        if(七丆丒与丗丌丄且丂 != 160000)
        {
                if(七丆丒与丗丌丄且丂 != 210000)
        {
            goto label_142;
        }
        
        }
        
        ShopPositionParams val_4 = val_98.GetComponent<ShopPositionParams>();
        if(val_4 == 0)
        {
            goto label_15;
        }
        
        if(val_4 != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_8:
        if((七丆丒与丗丌丄且丂 - 6) > 6)
        {
            goto label_18;
        }
        
        var val_98 = 106025184 + ((七丆丒与丗丌丄且丂 - 6)) << 2;
        val_98 = val_98 + 106025184;
        goto (106025184 + ((七丆丒与丗丌丄且丂 - 6)) << 2 + 106025184);
        label_6:
        val_100 = 6.964453E-43f;
        val_101 = 丐丑七万丌丂专与丌.positionShop;
        val_104 = 丐丑七万丌丂专与丌.rotationShop;
        label_7:
        InnerWeaponPars val_15 = 丐丑七万丌丂专与丌._innerPars;
        val_108 = val_15.bonusPrefab;
        val_111 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丐丑七万丌丂专与丌.Tag).丟丄丞丅丑七丞丄丞();
        val_110 = 0;
        val_109 = 0;
        label_142:
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        if(七丆丒与丗丌丄且丂 != 8)
        {
            goto label_35;
        }
        
        val_112 = val_108;
        goto label_185;
        label_35:
        if(((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == true) || (七丆丒与丗丌丄且丂 == 210000))
        {
            goto label_40;
        }
        
        if(七丆丒与丗丌丄且丂 != 160000)
        {
            goto label_41;
        }
        
        val_112 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_108);
        GliderShop val_21 = val_112.GetComponent<GliderShop>();
        val_21.Arms.gameObject.SetActive(value:  false);
        val_113 = 0;
        goto label_50;
        label_55:
        val_112.transform.GetComponentsInChildren<UnityEngine.ParticleSystem>()[0].gameObject.SetActive(value:  false);
        val_113 = 1;
        label_50:
        if(val_113 < val_24.Length)
        {
            goto label_55;
        }
        
        goto label_185;
        label_40:
        val_112 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_108);
        label_185:
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_112);
        UnityEngine.GameObject val_27 = new UnityEngine.GameObject();
        val_27.name = "Manipulate object";
        val_112.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        val_112.transform.parent = val_27.transform;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_27, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUIShop"));
        if(丌专业且丛丏丞丝且 == null)
        {
                return;
        }
        
        丌专业且丛丏丞丝且.Invoke(丛丆东与丑丞丅丝专:  val_27, 不丁丌丐业丑丟且不:  new UnityEngine.Vector3() {x = val_101, y = val_1.y, z = val_1.z}, 丌丙专丟丆丘上一丒:  new UnityEngine.Vector3() {x = val_104, y = val_2.y, z = val_2.z}, 丂丛世丁丞专不万丛:  val_111, 专丛专业万且不专丌:  val_100, 丏万丗丄丝七丌与丈:  0, 丞丁上一丙上上万七:  0);
        return;
        label_9:
        if(七丆丒与丗丌丄且丂 == 13500)
        {
            goto label_91;
        }
        
        if(七丆丒与丗丌丄且丂 != 150000)
        {
            goto label_142;
        }
        
        UnityEngine.Transform val_33 = val_98.transform.GetChild(index:  0);
        if(val_33 == null)
        {
            goto label_72;
        }
        
        UnityEngine.GameObject val_34 = val_33.gameObject;
        goto label_73;
        label_41:
        if(val_108 == 0)
        {
            goto label_185;
        }
        
        val_114 = val_108.GetComponent<UnityEngine.SkinnedMeshRenderer>();
        if(val_114 == 0)
        {
                T[] val_38 = val_108.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>(includeInactive:  true);
            if((val_38 != null) && (val_38.Length != 0))
        {
                val_114 = val_38[0];
        }
        
            val_99 = 1152921504838316032;
        }
        
        if(val_114 == 0)
        {
            goto label_88;
        }
        
        if(val_114 == 0)
        {
            goto label_89;
        }
        
        val_115 = val_114.sharedMaterials;
        goto label_90;
        label_18:
        if(七丆丒与丗丌丄且丂 != 12500)
        {
                if(七丆丒与丗丌丄且丂 != 13000)
        {
            goto label_142;
        }
        
        }
        
        label_91:
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.zero;
        goto label_142;
        label_15:
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.zero;
        val_107 = val_43.z;
        label_17:
        if(val_4 != 0)
        {
                val_116 = val_4.scaleShop;
        }
        else
        {
                val_116 = 100f;
        }
        
        if(val_4 == 0)
        {
            goto label_106;
        }
        
        if(val_98 != null)
        {
            goto label_112;
        }
        
        goto label_109;
        label_106:
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.zero;
        if(val_98 != null)
        {
            goto label_112;
        }
        
        label_109:
        label_112:
        UnityEngine.GameObject val_48 = val_98.transform.gameObject;
        goto label_142;
        label_88:
        if(val_108 == null)
        {
            goto label_131;
        }
        
        val_118 = val_108.GetComponent<UnityEngine.MeshFilter>();
        goto label_132;
        label_72:
        UnityEngine.GameObject val_60 = 0.gameObject;
        label_73:
        UnityEngine.Quaternion val_61 = val_33.localRotation;
        if(val_33 != null)
        {
                UnityEngine.Vector3 val_62 = val_33.localScale;
        }
        else
        {
                UnityEngine.Vector3 val_63 = 0.localScale;
        }
        
        UnityEngine.Vector3 val_64 = val_33.localPosition;
        goto label_142;
        label_89:
        val_115 = 0.sharedMaterials;
        label_90:
        val_119 = val_114.sharedMesh;
        val_120 = val_115;
        val_98 = val_98;
        if(val_120 != null)
        {
            goto label_143;
        }
        
        goto label_153;
        label_131:
        val_118 = 0.GetComponent<UnityEngine.MeshFilter>();
        label_132:
        UnityEngine.MeshRenderer val_72 = val_108.GetComponent<UnityEngine.MeshRenderer>();
        val_121 = 0;
        if(val_118 != 0)
        {
                val_121 = val_118.sharedMesh;
        }
        
        val_122 = 0;
        if(val_72 == 0)
        {
            goto label_198;
        }
        
        UnityEngine.Material[] val_76 = val_72.sharedMaterials;
        val_99 = 1152921504838316032;
        val_119 = val_121;
        if(val_76 == null)
        {
            goto label_153;
        }
        
        label_143:
        val_119 = val_119;
        val_122 = 0;
        if(val_119 == 0)
        {
            goto label_198;
        }
        
        UnityEngine.GameObject val_78 = null;
        val_122 = val_78;
        val_78 = new UnityEngine.GameObject();
        string val_79 = val_108.name;
        if(val_122 == null)
        {
            goto label_158;
        }
        
        val_78.name = val_79;
        goto label_159;
        label_153:
        val_122 = 0;
        goto label_198;
        label_158:
        0.name = val_79;
        label_159:
        val_78.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_119;
        UnityEngine.MeshRenderer val_81 = val_78.AddComponent<UnityEngine.MeshRenderer>();
        if(val_81 != null)
        {
                val_81.materials = val_76;
        }
        else
        {
                0.materials = val_76;
        }
        
        UnityEngine.Bounds val_82 = val_81.bounds;
        UnityEngine.Vector3 val_85 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_84, y = val_18.y, z = val_18.z});
        WeaponSkinChanger val_86 = val_78.AddComponent<WeaponSkinChanger>();
        val_86.weaponMeshRenderer = val_81;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) != false)
        {
                三丅丁丗丗丝丂万且 val_89 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  丐丑七万丌丂专与丌));
            if(val_89 != null)
        {
                if(val_89.丁丑与专丌丝丛丆上() != false)
        {
                UvScroller val_91 = val_78.AddComponent<UvScroller>();
        }
        
        }
        
        }
        
        label_198:
        if((Rilisoft.上丑业三丆丆丅丕三.下三世且丅下业下一(丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_98))) == null)
        {
            goto label_185;
        }
        
        UnityEngine.GameObject val_94 = val_78.gameObject;
        goto label_185;
    }
    internal static void 丒七丂丁丁东专且丕(WeaponSounds 丛丟三丘丛且业丈丏, UnityEngine.Transform 丈东丘丏与丌东东下, int 且丅丟丛丛万丝下上, UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, UnityEngine.Vector3 丝丕丁丏丏上丅丏且)
    {
        float val_1;
        UnityEngine.GameObject val_10;
        var val_11;
        UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  "Weapons/"("Weapons/") + 丛丟三丘丛且业丈丏.armoryPreviewName);
        if(val_3 != null)
        {
                val_3 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_10);
        val_4.transform.SetParent(p:  丈东丘丏与丌东东下);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4, 不东丛三丂丌丑专丆:  且丅丟丛丛万丝下上);
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        val_4.transform.localRotation = new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w};
        val_4.transform.localScale = new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = val_1, z = 丝丕丁丏丏上丅丏且.y};
        if(丛丟三丘丛且业丈丏.useTextureSkinForArmoryPreview == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_4, 丐丅丁丂丐下丘世丄:  SkinsController.丌与世丂丘且下丒丑, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
    }

}
