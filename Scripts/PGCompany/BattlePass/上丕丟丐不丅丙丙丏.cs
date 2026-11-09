using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 上丕丟丐不丅丙丙丏 : 丏七丁丌世丟丁丅丙
    {
        // Fields
        private bool 丗万丞丄丒丏下丐丘;
        private bool 丞世丗丂丘丆丘世丁;
        internal int 丞丕上丏世丒上丅丄;
        private bool 丐丏七七且丈丟丛专;
        private bool 丘丛世丒七丗丐三丄;
        private bool 丒世丂丐丅下丏三丂;
        private bool 上丂业丏丗丝丒且丒;
        private bool 丘东东丁丂丈丗不丂;
        private string 万丑丑丘丕三业丝世;
        private string 万丂丘万一丐三世丂;
        private bool 丙丈丕三丘七丝专丄;
        
        // Properties
        private System.Collections.Generic.Dictionary<string, string> 不丝丞丌丐专丄丝一 { get; }
        
        // Methods
        internal 上丕丟丐不丅丙丙丏(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.丞丕上丏世丒上丅丄 = 0;
            this.万丑丑丘丕三业丝世 = System.String.alignConst;
            this.万丂丘万一丐三世丂 = System.String.alignConst;
            goto typeof(PGCompany.BattlePass.上丕丟丐不丅丙丙丏).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.BattlePass.上丕丟丐不丅丙丙丏::专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
            this.丈丗丝丂丝丑上三丌();
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_4;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            Rilisoft.七丕丟丏三丈一丄世 val_1 = this.丘丛丆丕且丂业世丌();
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            label_89:
            if(((-436937296) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_5 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == true))
            {
                goto label_89;
            }
            
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "map", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == false)
            {
                goto label_10;
            }
            
            }
            
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "weaponSlot", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == false)
            {
                goto label_14;
            }
            
            }
            
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "headshot", comparisonType:  5)) == false)
            {
                goto label_15;
            }
            
            this.丗万丞丄丒丏下丐丘 = true;
            goto label_89;
            label_15:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "pet", comparisonType:  5)) == false)
            {
                goto label_17;
            }
            
            this.丞世丗丂丘丆丘世丁 = true;
            goto label_89;
            label_10:
            this.下东丅世丅专丝专丌(丙业与丙丗丝不丈东:  0);
            goto label_89;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_5, ignoreCase:  true));
            this.丛丒丌世万丒上七一(丙业与丙丗丝不丈东:  null);
            goto label_89;
            label_17:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "passenger", comparisonType:  5)) == false)
            {
                goto label_27;
            }
            
            this.丐丏七七且丈丟丛专 = true;
            goto label_89;
            label_27:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "MidAir", comparisonType:  5)) == false)
            {
                goto label_29;
            }
            
            this.丘丛世丒七丗丐三丄 = true;
            goto label_89;
            label_29:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "Zoom", comparisonType:  5)) == false)
            {
                goto label_31;
            }
            
            this.丒世丂丐丅下丏三丂 = true;
            goto label_89;
            label_31:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "KillZone", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == false)
            {
                goto label_36;
            }
            
            }
            
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "kill_invisible", comparisonType:  5)) == false)
            {
                goto label_37;
            }
            
            this.上丂业丏丗丝丒且丒 = true;
            goto label_89;
            label_37:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "player_invisible", comparisonType:  5)) == false)
            {
                goto label_39;
            }
            
            this.丘东东丁丂丈丗不丂 = true;
            goto label_89;
            label_36:
            this.万丑丑丘丕三业丝世 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            goto label_89;
            label_39:
            if((System.String.Equals(a:  val_5.m_stringLength, b:  "wave_num", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == false)
            {
                goto label_45;
            }
            
            }
            
            if(((System.String.Equals(a:  val_5.m_stringLength, b:  "my_player_effect", comparisonType:  5)) == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.m_stringLength)) == true))
            {
                goto label_89;
            }
            
            this.万丂丘万一丐三世丂 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            goto label_89;
            label_45:
            if((System.Int32.TryParse(s:  val_5, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) == false)
            {
                goto label_89;
            }
            
            this.丞丕上丏世丒上丅丄 = 0;
            goto label_89;
            label_1:
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionKillPlayers UpdateParams parameters == null", args:  this);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((public System.Void List.Enumerator<PGCompany.BattlePass.BPChallengeParameter>::Dispose()) == 0)
            {
                    return;
            }
            
            if(this.丞丕上丏世丒上丅丄 < 1)
            {
                    return;
            }
            
            mem[1152921560004496804] = this.丞丕上丏世丒上丅丄;
        }
        private void 专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
        {
            string val_55;
            var val_56;
            var val_57;
            string val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            Rilisoft.下丝丅世上与丌丗丛 val_56 = 丗丛不丁丑专专丂且;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            val_55 = this.业丑丁丆丕丆丂丅万();
            if(val_55.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(val_56 == null)
            {
                goto label_4;
            }
            
            int val_4 = val_56.丝一丙丘专七丕不上();
            if(val_56.三丗丙与万丅丈与与() == false)
            {
                goto label_5;
            }
            
            val_55 = 丁下万丟且丟丛下业.丛丝与一丕丆丌丟丏(丗丑丐丕丟丝且下丕:  val_56.丁丅丙丘丝丛丄丗三());
            if(val_55 == null)
            {
                goto label_9;
            }
            
            int val_8 = val_55.业东丅东丌上丗丑不();
            goto label_9;
            label_4:
            int val_9 = val_56.丝一丙丘专七丕不上();
            val_56 = 0;
            val_55 = 0;
            goto label_10;
            label_5:
            val_55 = 0;
            label_9:
            val_56 = 1;
            label_10:
            val_57 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丕丆丞丂业东与上丅())) != true)
            {
                    val_58 = 1152921505254395904;
                val_59 = null;
                val_59 = null;
                if(SceneInfoController.丄丘七三上丕世丞业 != 0)
            {
                    val_60 = null;
                val_60 = null;
                val_58 = this.丕丆丞丂业东与上丅();
                if((SceneInfoController.丄丘七三上丕世丞业.丌且丏世丌丗丕丄丟(专万丟三世业丙丈且:  val_58, 丂丛丑东不丅丈一东:  this.丘丛丆丕且丂业世丌())) != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if((System.String.Equals(a:  this.丕丆丞丂业东与上丅(), b:  val_56.丕丆丞丂业东与上丅(), comparisonType:  5)) == false)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
            if(this.丘丛丆丕且丂业世丌() != 1)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(this.丘丛丆丕且丂业世丌() != val_56.丘丛丆丕且丂业世丌())
            {
                    return;
            }
            
            }
            
            if(this.丄丄世七三业丝丛丘() != 1)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(this.丄丄世七三业丝丛丘() != val_56.丄丄世七三业丝丛丘())
            {
                    return;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.上万与丂世专丁丌不())) != true)
            {
                    var val_27 = (val_55 != 0) ? 1 : 0;
                val_27 = val_56 & val_27;
                if(val_27 != 1)
            {
                    return;
            }
            
                val_55 = val_55.业东丅东丌上丗丑不().ToString();
                if((System.String.Equals(a:  val_55, b:  this.上万与丂世专丁丌不(), comparisonType:  5)) == false)
            {
                    return;
            }
            
            }
            
            val_55 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_56.丁丅丙丘丝丛丄丗三());
            if(this.专丞丑丒丘丆丛丈且() != 67)
            {
                    if(val_55 == null)
            {
                    return;
            }
            
                if((val_56 ^ 1 & 1) != 0)
            {
                    return;
            }
            
                val_55 = val_55.丞丁下丅上不且丐丄();
                if((val_55.Contains(item:  this.专丞丑丒丘丆丛丈且())) == false)
            {
                    return;
            }
            
            }
            
            if(this.丗万丞丄丒丏下丐丘 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.业世丌丞丟丛上丐丁() == false)
            {
                    return;
            }
            
            }
            
            if(this.丞世丗丂丘丆丘世丁 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.丐丌不三丆与上丝与() == false)
            {
                    return;
            }
            
            }
            
            if(this.丐丏七七且丈丟丛专 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.世丐丈丐三丘丂世且() == false)
            {
                    return;
            }
            
            }
            
            if(this.丘丛世丒七丗丐三丄 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.丈不丄丏与丏丐丒丝() == false)
            {
                    return;
            }
            
            }
            
            if(this.上丂业丏丗丝丒且丒 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.上丂丁丗丛丆上丘三() == false)
            {
                    return;
            }
            
            }
            
            if(this.丘东东丁丂丈丗不丂 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.不与丙丕三且丅上丅() == false)
            {
                    return;
            }
            
            }
            
            if(this.丒世丂丐丅下丏三丂 != false)
            {
                    if(val_56 == 0)
            {
                    return;
            }
            
                if(val_56.专丁上丘丐业丁丕丑() == false)
            {
                    return;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.万丑丑丘丕三业丝世)) != true)
            {
                    val_55 = this.万丑丑丘丕三业丝世;
                if((val_55.Equals(value:  val_56.丛丅丈不丟丄专丌专())) == false)
            {
                    return;
            }
            
            }
            
            val_55 = this.万丂丘万一丐三世丂;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_55)) != true)
            {
                    System.Collections.Generic.List<System.Object> val_50 = new System.Collections.Generic.List<System.Object>();
                object val_52 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_56.丞一万丗上丄丏丁丈());
                val_61 = 0;
                val_57 = 1152921523884262800;
                val_55 = 0;
                do
            {
                if(val_55 >= Count)
            {
                    return;
            }
            
                val_58 = Item[0];
                val_55 = val_55 + 1;
            }
            while((System.String.op_Equality(a:  this.万丂丘万一丐三世丂, b:  val_58)) == false);
            
            }
            
            if((null == null) || (val_58 < 1))
            {
                goto label_84;
            }
            
            mem[1152921560004809516] = null;
            if(null == val_58)
            {
                goto label_89;
            }
            
            goto label_90;
            label_84:
            if((null == null) || (val_58 < 1))
            {
                goto label_88;
            }
            
            mem[1152921560004809512] = null;
            if(null == val_58)
            {
                goto label_89;
            }
            
            goto label_90;
            label_88:
            val_62 = 1;
            label_89:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_90:
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.BattlePass.上丕丟丐不丅丙丙丏::专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
            this.丞上丝丗七丁七丑丘();
        }
        private System.Collections.Generic.Dictionary<string, string> 丗丙丂且业一丅丌且()
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "paradise_pool", value:  "Key_6842");
            }
            else
            {
                    val_1.Add(key:  "paradise_pool", value:  "Key_6842");
            }
            
            val_1.Add(key:  "paradise_pool+", value:  "Key_6843");
            return val_1;
        }
    
    }

}
