using UnityEngine;

namespace PGCompany.Offerwall
{
    internal sealed class 丑丟专一丑丆一丒丙
    {
        // Fields
        private const Progress.与丄东丄丘丐丙丅业 万丄七三丕丛丗丆丆 = 156;
        private static PGCompany.Offerwall.丑丟专一丑丆一丒丙 世丒丞七专三与万丕;
        private readonly System.Collections.Generic.Dictionary<string, string> 与丁万业不东丕丈不;
        
        // Properties
        internal static PGCompany.Offerwall.丑丟专一丑丆一丒丙 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private 丑丟专一丑丆一丒丙()
        {
            this.与丁万业不东丕丈不 = new System.Collections.Generic.Dictionary<System.String, System.String>(comparer:  System.StringComparer.Ordinal);
        }
        internal static PGCompany.Offerwall.丑丟专一丑丆一丒丙 丑七不且上丗丁一世()
        {
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Offerwall.丑丟专一丑丆一丒丙 val_1 = PGCompany.Offerwall.丑丟专一丑丆一丒丙.东丝七业丄丑丒世七();
            PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private static PGCompany.Offerwall.丑丟专一丑丆一丒丙 东丝七业丄丑丒世七()
        {
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PendingResponseStorage.Create] synchronized: "("[PendingResponseStorage.Create] synchronized: ") + AuthSceneController.一不丆丏与丐丏丈丄().ToString() + ", userId: "(", userId: ") + PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三());
            }
            
            PGCompany.Offerwall.丑丟专一丑丆一丒丙 val_7 = new PGCompany.Offerwall.丑丟专一丑丆一丒丙();
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  val_7, method:  System.Void PGCompany.Offerwall.丑丟专一丑丆一丒丙::丆丏专丘丈丗万万上()));
            return val_7;
        }
        private void 丆丏专丘丈丗万万上()
        {
            string val_20;
            string val_21;
            string val_22;
            var val_23;
            string val_24;
            string val_2 = 0;
            string val_3 = 0;
            string val_5 = 0;
            val_20 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            bool val_4 = this.丄丙与丂丌业丑丈丆(万丄丅丝三丈丆世丟:  val_20, 丌且专不丙丕专丅万: out  val_2, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false}, 丏丞专丏业丗丝七丝: out  val_3);
            if(val_4 == false)
            {
                goto label_1;
            }
            
            if((val_4.丌丆上丆业丘一丟丈(丌且专不丙丕专丅万: out  val_5, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false}, 丏丞专丏业丗丝七丝: out  val_3)) == false)
            {
                goto label_2;
            }
            
            val_21 = 0;
            PGCompany.丄丙与丄丛丒丟下丛 val_8 = PGCompany.Offerwall.万丁七三丏专世一丆.丑七不且上丗丁一世().一且丌丛七丛不业专(丈丂丕下丏丈丞丗业:  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false}, 丂丌丌丛丆丆丙丌丈:  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false});
            val_22;
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() != false)
            {
                    string[] val_10 = new string[8];
                val_10[0] = "[PendingResponseStorage.OnProgressWasSynchronized] userId: ";
                val_10[1] = val_20;
                val_10[2] = ", localJson: ";
                val_10[3] = val_2;
                val_10[4] = ", remoteJson: ";
                val_10[5] = val_5;
                val_21 = ", mergedJson: ";
                val_10[6] = val_21;
                val_10[7] = val_22;
                UnityEngine.Debug.Log(message:  +val_10);
            }
            
            bool val_12 = this.与丁万业不东丕丈不.Remove(key:  val_20);
            val_23 = 156;
            val_24 = val_22;
            goto label_35;
            label_1:
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            string[] val_14 = new string[6];
            val_22 = "[PendingResponseStorage.OnProgressWasSynchronized] userId: ";
            val_14[0] = val_22;
            val_14[1] = val_20;
            val_14[2] = ", localJson: ";
            val_14[3] = val_2;
            val_14[4] = ", explanation: ";
            val_14[5] = val_3;
            val_20 = +val_14;
            UnityEngine.Debug.Log(message:  val_20);
            return;
            label_2:
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() != false)
            {
                    string[] val_17 = new string[8];
                val_17[0] = "[PendingResponseStorage.OnProgressWasSynchronized] userId: ";
                val_17[1] = val_20;
                val_17[2] = ", localJson: ";
                val_17[3] = val_2;
                val_17[4] = ", remoteJson: ";
                val_17[5] = val_5;
                val_17[6] = ", explanation: ";
                val_17[7] = val_3;
                val_22 = +val_17;
                UnityEngine.Debug.Log(message:  val_22);
            }
            
            bool val_19 = this.与丁万业不东丕丈不.Remove(key:  val_20);
            val_24 = val_2;
            val_23 = 156;
            label_35:
            PGCompany.丆丁业万丁七专且东.且且世专与丒丌专世(下上丐丆丝丟丝丒不:  156, 丙业与丙丗丝不丈东:  val_24);
        }
        internal bool 下丆与与丛丕丄丌丕(out string 丙业与丙丗丝不丈东)
        {
            System.String[] val_13;
            string val_14;
            bool val_2 = AuthSceneController.一不丆丏与丐丏丈丄();
            bool val_4 = this.下丆与与丛丕丄丌丕(丗丘丌万丅丙且丅专:  val_2, 丙业与丙丗丝不丈东: out  string val_3 = 丙业与丙丗丝不丈东);
            if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() == false)
            {
                    return val_4;
            }
            
            string val_6 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            if(val_4 != false)
            {
                    val_13 = new string[6];
                val_13[0] = "[PendingResponseStorage.TryGetNonWhiteSpaceString] synchronized: ";
                val_13[1] = val_2.ToString();
                val_13[2] = ", userId: ";
                val_13[3] = val_6;
                val_13[4] = ", value: ";
                val_14 = val_3;
            }
            else
            {
                    string[] val_9 = new string[5];
                val_13 = val_9;
                val_13[0] = "[PendingResponseStorage.TryGetNonWhiteSpaceString] synchronized: ";
                val_13[1] = val_2.ToString();
                val_13[2] = ", userId: ";
                val_13[3] = val_6;
                val_14 = ", result: false";
            }
            
            mem2[0] = val_14;
            UnityEngine.Debug.Log(message:  +val_9);
            return val_4;
        }
        internal void 且且世专与丒丌专世(string 丙业与丙丗丝不丈东)
        {
            string val_9;
            string val_10 = 丙业与丙丗丝不丈东;
            if(val_10 != null)
            {
                    bool val_2 = AuthSceneController.一不丆丏与丐丏丈丄();
                this.世丏丁丏上丗东丟丙(丗丘丌万丅丙且丅专:  val_2, 丙业与丙丗丝不丈东:  val_10 = 丙业与丙丗丝不丈东);
                if(PGCompany.Offerwall.丑丟专一丑丆一丒丙.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
                string[] val_5 = new string[6];
                val_5[0] = "[PendingResponseStorage.PutString] synchronized: ";
                val_5[1] = val_2.ToString();
                val_5[2] = ", userId: ";
                val_5[3] = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
                val_9 = ", value: ";
                val_5[4] = val_9;
                val_5[5] = val_10;
                val_10 = +val_5;
                UnityEngine.Debug.Log(message:  val_10);
                return;
            }
            
            System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  "value");
        }
        private bool 下丆与与丛丕丄丌丕(bool 丗丘丌万丅丙且丅专, out string 丙业与丙丗丝不丈东)
        {
            var val_6;
            if(丗丘丌万丅丙且丅专 != false)
            {
                    return PGCompany.丆丁业万丁七专且东.下丆与与丛丕丄丌丕(下上丐丆丝丟丝丒不:  156, 丙业与丙丗丝不丈东: out  string val_1 = 丙业与丙丗丝不丈东);
            }
            
            if((this.与丁万业不东丕丈不.TryGetValue(key:  PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三(), value: out  val_1)) != false)
            {
                    val_6 = (System.String.IsNullOrWhiteSpace(value:  val_1)) ^ 1;
                return (bool)val_6 & 1;
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
        }
        private void 世丏丁丏上丗东丟丙(bool 丗丘丌万丅丙且丅专, string 丙业与丙丗丝不丈东)
        {
            if(丗丘丌万丅丙且丅专 != false)
            {
                    PGCompany.丆丁业万丁七专且东.且且世专与丒丌专世(下上丐丆丝丟丝丒不:  156, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
                return;
            }
            
            this.与丁万业不东丕丈不.set_Item(key:  PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三(), value:  丙业与丙丗丝不丈东);
        }
        private bool 丄丙与丂丌业丑丈丆(string 万丄丅丝三丈丆世丟, out string 丌且专不丙丕专丅万, out PGCompany.丄丙与丄丛丒丟下丛 丙业与丙丗丝不丈东, out string 丏丞专丏业丗丝七丝)
        {
            string val_5;
            丙业与丙丗丝不丈东.<且不三万丒东专丕下>k__BackingField = false;
            mem[1152921559588286041] = 0;
            丙业与丙丗丝不丈东.<丝专丑丛业专世丘丅>k__BackingField = 0;
            丙业与丙丗丝不丈东.<三丄世丝丑丂丄与丟>k__BackingField = 0;
            val_5 = this.与丁万业不东丕丈不;
            if((val_5.TryGetValue(key:  万丄丅丝三丈丆世丟, value: out  string val_1 = 丌且专不丙丕专丅万)) == false)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  bool val_3 = PGCompany.丄丙与丄丛丒丟下丛.东一万丈丘业丂丂丑(丌丏不下一与丛丙丝:  val_5 = val_1, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<丝专丑丛业专世丘丅>k__BackingField = 丙业与丙丗丝不丈东.<丝专丑丛业专世丘丅>k__BackingField, <三丄世丝丑丂丄与丟>k__BackingField = 丙业与丙丗丝不丈东.<三丄世丝丑丂丄与丟>k__BackingField, <且不三万丒东专丕下>k__BackingField = 丙业与丙丗丝不丈东.<且不三万丒东专丕下>k__BackingField}), 丄丙下丝丛丒七丂丘: out  string val_4 = 丏丞专丏业丗丝七丝);
            }
            
            if(val_3 != false)
            {
                    return PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  0, 丄丙下丝丛丒七丂丘: out  val_4);
            }
            
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_3, 丄丙下丝丛丒七丂丘: out  val_4);
        }
        private bool 丌丆上丆业丘一丟丈(out string 丌且专不丙丕专丅万, out PGCompany.丄丙与丄丛丒丟下丛 丙业与丙丗丝不丈东, out string 丏丞专丏业丗丝七丝)
        {
            string val_5;
            丙业与丙丗丝不丈东.<且不三万丒东专丕下>k__BackingField = false;
            mem[1152921559588426601] = 0;
            丙业与丙丗丝不丈东.<丝专丑丛业专世丘丅>k__BackingField = 0;
            丙业与丙丗丝不丈东.<三丄世丝丑丂丄与丟>k__BackingField = 0;
            if((PGCompany.丆丁业万丁七专且东.下丆与与丛丕丄丌丕(下上丐丆丝丟丝丒不:  156, 丙业与丙丗丝不丈东: out  string val_1 = 丌且专不丙丕专丅万)) == false)
            {
                goto label_1;
            }
            
            if((PGCompany.丄丙与丄丛丒丟下丛.东一万丈丘业丂丂丑(丌丏不下一与丛丙丝:  val_1, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<丝专丑丛业专世丘丅>k__BackingField = 丙业与丙丗丝不丈东.<丝专丑丛业专世丘丅>k__BackingField, <三丄世丝丑丂丄与丟>k__BackingField = 丙业与丙丗丝不丈东.<三丄世丝丑丂丄与丟>k__BackingField, <且不三万丒东专丕下>k__BackingField = 丙业与丙丗丝不丈东.<且不三万丒东专丕下>k__BackingField})) == false)
            {
                goto label_2;
            }
            
            return PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  0, 丄丙下丝丛丒七丂丘: out  string val_4 = 丏丞专丏业丗丝七丝);
            label_1:
            val_5 = "TryGetNonWhiteSpaceString: false";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_5 = "TryParse", 丄丙下丝丛丒七丂丘: out  val_4);
            label_2:
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_5, 丄丙下丝丛丒七丂丘: out  val_4);
        }
    
    }

}
