using UnityEngine;
internal abstract class BaseEquipmentController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public PhotonView photonView;
    public FortEquipObject[] equipObjects;
    public float distanceMultupler;
    
    // Methods
    private void Update()
    {
        if(this.equipObjects == null)
        {
                return;
        }
        
        if(this.equipObjects.Length < 1)
        {
                return;
        }
        
        do
        {
            this = this.equipObjects[0];
            if(this != 0)
        {
                if(this.isActive != true)
        {
                double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        }
        
        }
        
        }
        while((0 + 1) < this.equipObjects.Length);
    
    }
    public void SendRemoveTargetRPC(FortEquipObject 上世万世丐丄上丑丆, int 世上丕丐丈世上不丏, byte 丏与丅下丞丗与七下)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 世上丕丐丈世上不丏;
        val_1[2] = 丏与丅下丞丗与七下;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  158, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendSetTargetRPC(FortEquipObject 上世万世丐丄上丑丆, int 世上丕丐丈世上不丏, byte 丏与丅下丞丗与七下)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 世上丕丐丈世上不丏;
        val_1[2] = 丏与丅下丞丗与七下;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  87, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotRPC(FortEquipObject 上世万世丐丄上丑丆)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotTargets(FortEquipObject 上世万世丐丄上丑丆, int[] 丏丌丄丆丟丝下丟丝, byte[] 丘业丌下丁业下丐东)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 丏丌丄丆丟丝下丟丝;
        val_1[2] = 丘业丌下丁业下丐东;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotRPC(FortEquipObject 上世万世丐丄上丑丆, double 一万与三东丞丈丙丁)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 一万与三东丞丈丙丁;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotRPC(FortEquipObject 上世万世丐丄上丑丆, double 一万与三东丞丈丙丁, 与丅丕丈丘东丝世丟 丞下万上三丘上与专)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 一万与三东丞丈丙丁;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 万丌万丅专丞业丈万:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotArtilleryRPC(FortEquipObject 上世万世丐丄上丑丆, UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 丌丐丏丐丆丙丛丁丕;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  160, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendShotArtilleryRPC(FortEquipObject 上世万世丐丄上丑丆, UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 丛上丟丌丄丗丁世与)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 丌丐丏丐丆丙丛丁丕;
        val_1[2] = 丛上丟丌丄丗丁世与;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  160, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendSetDestinationRPC(FortEquipObject 上世万世丐丄上丑丆, UnityEngine.Vector3 丙七丟丏丅丘丈丁丄, float 东丗上东丘丄东丘世)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 丙七丟丏丅丘丈丁丄;
        val_1[2] = 东丗上东丘丄东丘世;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  161, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendDamageRPC(FortEquipObject 上世万世丐丄上丑丆, float 丞丈专下丈专业三丞, int 丞丗且下世丐业丌丙, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专)
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(上世万世丐丄上丑丆.fortObjectID != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(上世万世丐丄上丑丆.fortObjectID == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 上世万世丐丄上丑丆.fortObjectID;
        val_1[1] = 丞丈专下丈专业三丞;
        val_1[2] = 丞丗且下世丐业丌丙;
        val_1[3] = 丐丟丘世丁三丕专专;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public PhotonView GetPhotonView()
    {
        return (PhotonView)this.photonView;
    }
    public FortEquipObject GetEquipmentByID(byte 丞丅上丏丂且下丅与)
    {
        var val_2;
        FortEquipObject val_3;
        val_2 = 丞丅上丏丂且下丅与;
        if((val_2 & 255) < this.equipObjects.Length)
        {
                val_2 = val_2 & 255;
            val_3 = this.equipObjects[val_2];
            return (FortEquipObject)val_3;
        }
        
        val_3 = 0;
        return (FortEquipObject)val_3;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_3;
        object val_4;
        int val_5;
        UnityEngine.Vector2[] val_6;
        var val_7;
        int val_8;
        var val_9;
        int val_10;
        var val_12;
        int val_13;
        int val_14;
        var val_15;
        int val_16;
        UnityEngine.Vector2[] val_17;
        System.Int32[] val_18;
        System.Byte[] val_19;
        val_3 = 丞世不丒下上上丝丑;
        val_4 = this;
        byte val_1 = val_3 & 255;
        if(val_1 > 87)
        {
            goto label_1;
        }
        
        if(val_1 == 24)
        {
            goto label_2;
        }
        
        if(val_1 != 87)
        {
            goto label_3;
        }
        
        val_5 = 专丒丌丆下丐丞丟丞.Length;
        if(val_5 == 0)
        {
                val_5 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        if(val_5 <= 1)
        {
                val_5 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_4 = 专丒丌丆下丐丞丟丞[1];
        object val_5 = 专丒丌丆下丐丞丟丞[2];
        val_6 = 1152921504617762816;
        this.丁丏且丒丗且下丙丈(世丏丛七且东丕丕丞:  0, 业上上丏丄不上丅丈:  21884928, 丏与丅下丞丗与七下:  0);
        goto label_94;
        label_1:
        val_7 = 0;
        if(val_1 <= 157)
        {
            goto label_9;
        }
        
        if(val_1 == 158)
        {
            goto label_10;
        }
        
        if(val_1 == 160)
        {
            goto label_11;
        }
        
        if(val_1 != 161)
        {
                return (bool)val_7;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_13;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞;
        val_8 = 专丒丌丆下丐丞丟丞.Length;
        if(val_8 != 2)
        {
            goto label_14;
        }
        
        label_86:
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        object val_7 = 专丒丌丆下丐丞丟丞[1];
        val_9 = 1152921504628731904;
        goto label_18;
        label_9:
        if(val_1 == 92)
        {
            goto label_19;
        }
        
        if(val_1 != 128)
        {
                return (bool)val_7;
        }
        
        val_10 = 专丒丌丆下丐丞丟丞.Length;
        if(val_10 == 0)
        {
                val_10 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[0];
        if(val_10 <= 1)
        {
                val_10 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_9 = 专丒丌丆下丐丞丟丞[1];
        object val_10 = 专丒丌丆下丐丞丟丞[2];
        if(val_9 == null)
        {
            goto label_25;
        }
        
        val_6 = null;
        val_3 = val_9;
        if(val_3 != null)
        {
            goto label_26;
        }
        
        label_25:
        val_3 = 0;
        label_26:
        if((val_10 == null) || (val_10 != null))
        {
            goto label_94;
        }
        
        goto label_94;
        label_2:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_30;
        }
        
        val_12 = 专丒丌丆下丐丞丟丞;
        val_13 = 专丒丌丆下丐丞丟丞.Length;
        if(val_13 != 3)
        {
            goto label_31;
        }
        
        label_59:
        val_4 = 专丒丌丆下丐丞丟丞[0];
        val_3 = 专丒丌丆下丐丞丟丞[1];
        object val_11 = 专丒丌丆下丐丞丟丞[2];
        goto label_94;
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_10:
        val_14 = 专丒丌丆下丐丞丟丞.Length;
        if(val_14 == 0)
        {
                val_14 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        if(val_14 <= 1)
        {
                val_14 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_13 = 专丒丌丆下丐丞丟丞[1];
        object val_14 = 专丒丌丆下丐丞丟丞[2];
        val_6 = 1152921504617762816;
        this.世三丏上丐丈三丙丕(世丏丛七且东丕丕丞:  0, 业上上丏丄不上丅丈:  21884928, 丏与丅下丞丗与七下:  0);
        goto label_94;
        label_11:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_44;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞;
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_73;
        }
        
        label_74:
        label_73:
        val_3 = 专丒丌丆下丐丞丟丞[0];
        object val_15 = 专丒丌丆下丐丞丟丞[1];
        if(专丒丌丆下丐丞丟丞.Length != 3)
        {
            goto label_48;
        }
        
        object val_16 = 专丒丌丆下丐丞丟丞[2];
        if(val_15 == null)
        {
            goto label_50;
        }
        
        val_6 = val_15;
        if(val_6 != null)
        {
            goto label_51;
        }
        
        label_50:
        val_6 = 0;
        label_51:
        this.世丄下万与丁丐与三(世丏丛七且东丕丕丞:  0, 丌丐丏丐丆丙丛丁丕:  val_6, 丛上丟丌丄丗丁世与:  3.782474E-38f);
        goto label_94;
        label_19:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_53;
        }
        
        val_15 = 专丒丌丆下丐丞丟丞;
        val_16 = 专丒丌丆下丐丞丟丞.Length;
        if(val_16 == 3)
        {
            goto label_54;
        }
        
        label_96:
        val_3 = 专丒丌丆下丐丞丟丞[0];
        if(val_16 != 2)
        {
            goto label_56;
        }
        
        object val_17 = 专丒丌丆下丐丞丟丞[1];
        this.世且丂丕丐丝丐丐且(世丏丛七且东丕丕丞:  0, 一万与三东丞丈丙丁:  1.28822976017949E-231);
        goto label_94;
        label_30:
        val_12 = 24;
        val_3 = 28563616;
        val_13 = 28563616;
        if(val_3 == 3)
        {
            goto label_59;
        }
        
        label_31:
        if(val_13 != 4)
        {
            goto label_94;
        }
        
        object val_18 = 专丒丌丆下丐丞丟丞[0];
        object val_19 = 专丒丌丆下丐丞丟丞[1];
        val_6 = 专丒丌丆下丐丞丟丞[2];
        object val_20 = 专丒丌丆下丐丞丟丞[3];
        this.万不丄下丂三丕丒不(世丏丛七且东丕丕丞:  0, 丞丈专下丈专业三丞:  3.782474E-38f, 丑东丁丈丄丞丙万上:  21884928, 丐丟丘世丁三丕专专:  21884928);
        goto label_94;
        label_48:
        if(val_15 == null)
        {
            goto label_70;
        }
        
        val_3 = null;
        val_17 = val_15;
        if(val_17 != null)
        {
            goto label_71;
        }
        
        label_70:
        val_17 = 0;
        label_71:
        this.世丄下万与丁丐与三(世丏丛七且东丕丕丞:  0, 丌丐丏丐丆丙丛丁丕:  val_17);
        goto label_94;
        label_44:
        if(28563616 != 0)
        {
            goto label_73;
        }
        
        goto label_74;
        label_53:
        val_15 = 24;
        val_16 = 28563616;
        if(28563616 != 3)
        {
            goto label_75;
        }
        
        label_54:
        object val_21 = 专丒丌丆下丐丞丟丞[0];
        val_6 = 专丒丌丆下丐丞丟丞[1];
        val_3 = 专丒丌丆下丐丞丟丞[2];
        if(val_6 == null)
        {
            goto label_81;
        }
        
        val_18 = val_6;
        if(val_18 != null)
        {
            goto label_82;
        }
        
        label_81:
        val_18 = 0;
        label_82:
        if(val_3 == null)
        {
            goto label_83;
        }
        
        val_6 = null;
        val_19 = val_3;
        if(val_19 != null)
        {
            goto label_84;
        }
        
        label_83:
        val_19 = 0;
        label_84:
        this.世且丂丕丐丝丐丐且(世丏丛七且东丕丕丞:  0, 丏丌丄丆丟丝下丟丝:  val_18, 丘业丌下丁业下丐东:  val_19);
        goto label_94;
        label_13:
        val_6 = 24;
        val_3 = 28563616;
        val_8 = 28563616;
        if(val_3 == 2)
        {
            goto label_86;
        }
        
        label_14:
        if(val_8 != 3)
        {
            goto label_94;
        }
        
        object val_22 = 专丒丌丆下丐丞丟丞[0];
        object val_23 = 专丒丌丆下丐丞丟丞[1];
        object val_24 = 专丒丌丆下丐丞丟丞[2];
        val_9 = 1152921504628731904;
        label_18:
        this.丄世丁丘不世丗与丞(世丏丛七且东丕丕丞:  0, 丁丆丈丂上丙丈丙万:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 东丗上东丘丄东丘世:  3.782474E-38f);
        goto label_94;
        label_56:
        this.世且丂丕丐丝丐丐且(世丏丛七且东丕丕丞:  0);
        label_94:
        val_7 = 1;
        return (bool)val_7;
        label_75:
        if(28563616 != 0)
        {
            goto label_96;
        }
        
        goto label_96;
    }
    private void 丁丏且丒丗且下丙丈(byte 世丏丛七且东丕丕丞, int 业上上丏丄不上丅丈, byte 丏与丅下丞丗与七下)
    {
        FortEquipObject val_1 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.isActive == false)
        {
                return;
        }
        
        val_1.SetTargetRPC(世上丕丐丈世上不丏:  业上上丏丄不上丅丈, 丏与丅下丞丗与七下:  丏与丅下丞丗与七下);
    }
    private void 世三丏上丐丈三丙丕(byte 世丏丛七且东丕丕丞, int 业上上丏丄不上丅丈, byte 丏与丅下丞丗与七下)
    {
        FortEquipObject val_1 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.isActive == false)
        {
                return;
        }
        
        val_1.RemoveTargetRPC(世上丕丐丈世上不丏:  业上上丏丄不上丅丈, 丏与丅下丞丗与七下:  丏与丅下丞丗与七下);
    }
    private void 世且丂丕丐丝丐丐且(byte 世丏丛七且东丕丕丞)
    {
        FortEquipObject val_9 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_9 == 0)
        {
                return;
        }
        
        if(val_9.isActive == false)
        {
                return;
        }
        
        val_9 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_178;
    }
    private void 世且丂丕丐丝丐丐且(byte 世丏丛七且东丕丕丞, int[] 丏丌丄丆丟丝下丟丝, byte[] 丘业丌下丁业下丐东)
    {
        var val_11;
        UnityEngine.Object val_12;
        val_11 = 丘业丌下丁业下丐东;
        val_12 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_12 == 0)
        {
                return;
        }
        
        if(val_12.isActive == false)
        {
                return;
        }
        
        val_11 = ???;
        val_12 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_188;
    }
    private void 世且丂丕丐丝丐丐且(byte 世丏丛七且东丕丕丞, double 一万与三东丞丈丙丁)
    {
        FortEquipObject val_10 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_10 == 0)
        {
                return;
        }
        
        if(val_10.isActive == false)
        {
                return;
        }
        
        val_10 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_198;
    }
    private void 世丄下万与丁丐与三(byte 世丏丛七且东丕丕丞, UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕)
    {
        var val_10;
        var val_11;
        val_10 = 丌丐丏丐丆丙丛丁丕;
        val_11 = this;
        FortEquipObject val_1 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.isActive == false)
        {
                return;
        }
        
        val_10 = ???;
        val_11 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_1A8;
    }
    private void 世丄下万与丁丐与三(byte 世丏丛七且东丕丕丞, UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 丛上丟丌丄丗丁世与)
    {
        var val_11;
        var val_12;
        val_11 = 丌丐丏丐丆丙丛丁丕;
        val_12 = this;
        FortEquipObject val_1 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.isActive == false)
        {
                return;
        }
        
        val_11 = ???;
        val_12 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_1B8;
    }
    private void 万不丄下丂三丕丒不(byte 世丏丛七且东丕丕丞, float 丞丈专下丈专业三丞, int 丑东丁丈丄丞丙万上)
    {
    
    }
    private void 万不丄下丂三丕丒不(byte 世丏丛七且东丕丕丞, float 丞丈专下丈专业三丞, int 丑东丁丈丄丞丙万上, int 丐丟丘世丁三丕专专)
    {
        var val_12;
        UnityEngine.Object val_13;
        val_12 = 丐丟丘世丁三丕专专;
        val_13 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_13 == 0)
        {
                return;
        }
        
        if(val_13.isActive == false)
        {
                return;
        }
        
        val_12 = ???;
        val_13 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_1C8;
    }
    private void 丄世丁丘不世丗与丞(byte 世丏丛七且东丕丕丞, UnityEngine.Vector3 丁丆丈丂上丙丈丙万)
    {
        this.丄世丁丘不世丗与丞(世丏丛七且东丕丕丞:  世丏丛七且东丕丕丞, 丁丆丈丂上丙丈丙万:  new UnityEngine.Vector3() {x = 丁丆丈丂上丙丈丙万.x, y = 丁丆丈丂上丙丈丙万.y, z = 丁丆丈丂上丙丈丙万.z}, 东丗上东丘丄东丘世:  0f);
    }
    private void 丄世丁丘不世丗与丞(byte 世丏丛七且东丕丕丞, UnityEngine.Vector3 丁丆丈丂上丙丈丙万, float 东丗上东丘丄东丘世)
    {
        double val_13;
        double val_14;
        UnityEngine.Object val_15;
        val_13 = 东丗上东丘丄东丘世;
        val_14 = 丁丆丈丂上丙丈丙万.y;
        val_15 = this.GetEquipmentByID(丞丅上丏丂且下丅与:  世丏丛七且东丕丕丞);
        if(val_15 == 0)
        {
                return;
        }
        
        if(val_15.isActive == false)
        {
                return;
        }
        
        val_15 = ???;
        val_13 = ???;
        val_14 = ???;
        goto typeof(FortEquipObject).__il2cppRuntimeField_1D8;
    }
    protected abstract void 丑丂业且下上丝丈世(float 丙丁丈丐万丆丟与下, float[] 世丙丟上丘上七万万, float[] 丈且上丆东丞丏万且); // 0
    protected virtual void 不丌上丁丙东上丟东()
    {
        FortEquipObject[] val_5;
        var val_6;
        this.distanceMultupler = 1f;
        if(this != null)
        {
                mem[1152921524528238896] = 1065353216;
            if(137113600 != 0)
        {
                UnityEngine.Object.Destroy(obj:  137113600);
        }
        
        }
        
        val_5 = this.equipObjects;
        if(val_5 == null)
        {
            goto label_9;
        }
        
        val_6 = 0;
        goto label_23;
        label_39:
        if(this.equipObjects[0] != 0)
        {
                FortEquipObject val_6 = this.equipObjects[0];
        }
        
        val_5 = this.equipObjects;
        val_6 = 1;
        label_23:
        if(val_6 < this.equipObjects.Length)
        {
            goto label_39;
        }
        
        return;
        label_9:
        UnityEngine.Debug.LogError(message:  "Пустой форт");
    }
    protected BaseEquipmentController()
    {
        this.distanceMultupler = 1f;
    }

}
