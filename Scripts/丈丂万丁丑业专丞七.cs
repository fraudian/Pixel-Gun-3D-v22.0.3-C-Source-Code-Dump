using UnityEngine;
public class 丈丂万丁丑业专丞七
{
    // Fields
    public readonly string 丟上丞上丆万三丞一;
    public readonly string 丘下丒丙专丏丐丑丛;
    public readonly string 丘丞与万丕丞丌且丝;
    public readonly string 丏丒丘丗丕丛丘丟且;
    public readonly string 丙与丌丐专丄丆丏丟;
    public readonly string 且丕丏丗三专七丟丑;
    public readonly string 丁丄丟丂丄世丙丑丞;
    public readonly string 丛丕丞丗七丆丐丈丂;
    public readonly string 丒丞丕丙丁丁丁丙丏;
    public readonly System.Nullable<double> 丂万丞三世且一丛丏;
    public readonly string 丑与三下丛丏丝丄丒;
    public readonly System.Nullable<double> 丐丄不丕丑七专且丏;
    public readonly string 丐丕且丒业丛丐丂丁;
    public readonly System.Nullable<int> 丝七不世丁丆世与上;
    public readonly string 丂业三丈与三丂丑丄;
    
    // Methods
    public 丈丂万丁丑业专丞七(string 丌且专不丙丕专丅万)
    {
        string val_28;
        var val_29;
        val_28 = 丌且专不丙丕专丅万;
        object val_3 = 0;
        if(val_28 == null)
        {
                return;
        }
        
        this.丂业三丈与三丂丑丄 = val_28;
        System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
        if((IronSourceJSON.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_28)) != null)
        {
                val_29 = (System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8;
            if(val_29 == null)
        {
            goto label_55;
        }
        
        }
        
        val_28 = 0;
        label_55:
        if(((val_28.TryGetValue(key:  "auctionId", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丟上丞上丆万三丞一 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "adUnit", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丘下丒丙专丏丐丑丛 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "country", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丘丞与万丕丞丌且丝 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "ab", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丏丒丘丗丕丛丘丟且 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "segmentName", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丙与丌丐专丄丆丏丟 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "placement", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.且丕丏丗三专七丟丑 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "adNetwork", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丁丄丟丂丄世丙丑丞 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "instanceName", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丛丕丞丗七丆丐丈丂 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "instanceId", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丒丞丕丙丁丁丁丙丏 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "precision", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丑与三下丛丏丝丄丒 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "encryptedCPM", value: out  val_3)) != false) && (val_3 != 0))
        {
                this.丐丕且丒业丛丐丂丁 = val_3;
        }
        
        if(((val_28.TryGetValue(key:  "revenue", value: out  val_3)) != false) && (val_3 != 0))
        {
                if((System.Double.TryParse(s:  System.String.Format(provider:  val_1, format:  "{0}", arg0:  val_3), style:  511, provider:  val_1, result: out  double val_17 = 1.28823597111894E-231)) != false)
        {
                val_29 = 0;
            this.丂万丞三世且一丛丏 = 0;
            mem[1152921526341939648] = val_29;
        }
        
        }
        
        if(((val_28.TryGetValue(key:  "lifetimeRevenue", value: out  val_3)) != false) && (val_3 != 0))
        {
                if((System.Double.TryParse(s:  System.String.Format(provider:  val_1, format:  "{0}", arg0:  val_3), style:  511, provider:  val_1, result: out  double val_21 = 1.28823597111894E-231)) != false)
        {
                this.丐丄不丕丑七专且丏 = 0;
            mem[1152921526341939672] = 0;
        }
        
        }
        
        if((val_28.TryGetValue(key:  "conversionValue", value: out  val_3)) == false)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        if((System.Int32.TryParse(s:  System.String.Format(provider:  val_1, format:  "{0}", arg0:  val_3), style:  511, provider:  val_1, result: out  0)) == false)
        {
                return;
        }
        
        this.丝七不世丁丆世与上 = 0;
    }
    public override string ToString()
    {
        object[] val_1 = new object[29];
        val_1[0] = "IronSourceImpressionData{auctionId=\'";
        val_1[1] = this.丟上丞上丆万三丞一;
        val_1[2] = "\', adUnit=\'";
        val_1[3] = this.丘下丒丙专丏丐丑丛;
        val_1[4] = "\', country=\'";
        val_1[5] = this.丘丞与万丕丞丌且丝;
        val_1[6] = "\', ab=\'";
        val_1[7] = this.丏丒丘丗丕丛丘丟且;
        val_1[8] = "\', segmentName=\'";
        val_1[9] = this.丙与丌丐专丄丆丏丟;
        val_1[10] = "\', placement=\'";
        val_1[11] = this.且丕丏丗三专七丟丑;
        val_1[12] = "\', adNetwork=\'";
        val_1[13] = this.丁丄丟丂丄世丙丑丞;
        val_1[14] = "\', instanceName=\'";
        val_1[15] = this.丛丕丞丗七丆丐丈丂;
        val_1[16] = "\', instanceId=\'";
        val_1[17] = this.丒丞丕丙丁丁丁丙丏;
        val_1[18] = "\', revenue=";
        val_1[19] = this.丂万丞三世且一丛丏;
        val_1[20] = ", precision=\'";
        val_1[21] = this.丑与三下丛丏丝丄丒;
        val_1[22] = "\', lifetimeRevenue=";
        val_1[23] = this.丐丄不丕丑七专且丏;
        val_1[24] = ", encryptedCPM=\'";
        val_1[25] = this.丐丕且丒业丛丐丂丁;
        val_1[26] = "\', conversionValue=";
        val_1[27] = this.丝七不世丁丆世与上;
        val_1[28] = "}";
        return (string)+val_1;
    }

}
