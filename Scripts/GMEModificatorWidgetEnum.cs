using UnityEngine;
internal sealed class GMEModificatorWidgetEnum : GMEModificatorWidget
{
    // Fields
    private UILabel value;
    
    // Methods
    protected override void 丁丅丏丈七下丁丝丞()
    {
        UILabel val_5;
        var val_6;
        string val_7;
        var val_8;
        var val_9;
        if(==0)
        {
                return;
        }
        
        ModificatorType val_1 = 不业丙丒丂丞下丆丙();
        if(val_1 == 14)
        {
            goto label_2;
        }
        
        if(val_1 == 17)
        {
            goto label_3;
        }
        
        if(val_1 != 19)
        {
                return;
        }
        
        val_5 = this.value;
        val_6 = null;
        val_6 = null;
        val_7 = mem[PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 + 32];
        val_7 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 + 32;
        goto label_14;
        label_2:
        val_5 = this.value;
        val_8 = null;
        val_8 = null;
        EventMovementScheme val_2 = 丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom");
        System.String[] val_3 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丛万丄七丞丕丝丕丅 + (((long)(int)(val_2)) << 3);
        val_7 = mem[(PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丛万丄七丞丕丝丕丅 + ((long)(int)(val_2)) << 3) + 32];
        val_7 = (PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丛万丄七丞丕丝丕丅 + ((long)(int)(val_2)) << 3) + 32;
        goto label_14;
        label_3:
        val_5 = this.value;
        val_9 = null;
        val_9 = null;
        val_7 = mem[PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 + 40];
        val_7 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 + 40;
        label_14:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7));
    }
    protected override void 丝丂不不世丈丏丟不()
    {
        var val_2;
        var val_3;
        if(true == 14)
        {
            goto label_1;
        }
        
        if(true != 17)
        {
                if(true != 19)
        {
                return;
        }
        
        }
        
        val_2 = null;
        val_2 = null;
        if(PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.value, 丕丗丘丑丛与丑业丒:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.业丝丆上不丏丌专丑 + 32));
        return;
        label_1:
        val_3 = null;
        val_3 = null;
        if(PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丛万丄七丞丕丝丕丅 != null)
        {
            goto label_12;
        }
        
        goto label_13;
    }
    public GMEModificatorWidgetEnum()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
