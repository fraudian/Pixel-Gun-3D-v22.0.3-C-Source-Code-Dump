using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丂丐与丞业丂丒下丆 : 丏七丁丌世丟丁丅丙
    {
        // Fields
        private string 万丂丘万一丐三世丂;
        
        // Methods
        internal 丂丐与丞业丂丒下丆(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.万丂丘万一丐三世丂 = System.String.alignConst;
            goto typeof(PGCompany.BattlePass.丂丐与丞业丂丒下丆).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂三丐丗一丞三丁丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.三丁丘一一上丏下丆>(object:  this, method:  System.Void PGCompany.BattlePass.丂丐与丞业丂丒下丆::丂丒一一丁且丏丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.三丁丘一一上丏下丆 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙下丐七不一丅丌丁(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.三丁丘一一上丏下丆>(object:  this, method:  System.Void PGCompany.BattlePass.丂丐与丞业丂丒下丆::丂丒一一丁且丏丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.三丁丘一一上丏下丆 丗丛不丁丑专专丂且)));
            this.丈丗丝丂丝丑上三丌();
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            label_41:
            if(((-417566224) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_41;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "weaponSlot", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == false)
            {
                goto label_10;
            }
            
            }
            
            if(((System.String.Equals(a:  val_4.m_stringLength, b:  "my_player_effect", comparisonType:  5)) == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_41;
            }
            
            this.万丂丘万一丐三世丂 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            goto label_41;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_4, ignoreCase:  true));
            this.丛丒丌世万丒上七一(丙业与丙丗丝不丈东:  null);
            goto label_41;
            label_1:
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionWin UpdateParams parameters == null", args:  this);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丂丒一一丁且丏丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.三丁丘一一上丏下丆 丗丛不丁丑专专丂且)
        {
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            Rilisoft.三丁丘一一上丏下丆 val_14 = 丗丛不丁丑专专丂且;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            val_14 = this.业丑丁丆丕丆丂丅万();
            if(val_14.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            if(this.丄丄世七三业丝丛丘() != 1)
            {
                    if(val_14 == null)
            {
                    return;
            }
            
                if(this.丄丄世七三业丝丛丘() != val_14.丄丄世七三业丝丛丘())
            {
                    return;
            }
            
            }
            
            val_15 = this.万丂丘万一丐三世丂;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15)) != true)
            {
                    System.Collections.Generic.List<System.Object> val_8 = new System.Collections.Generic.List<System.Object>();
                object val_10 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_14.丞一万丗上丄丏丁丈());
                val_16 = 0;
                do
            {
                if(0 >= Count)
            {
                    return;
            }
            
                object val_12 = Item[0];
                val_15 = 0 + 1;
            }
            while((System.String.op_Equality(a:  this.万丂丘万一丐三世丂, b:  val_12)) == false);
            
            }
            
            if((null == null) || (val_12 < 1))
            {
                goto label_20;
            }
            
            mem[1152921560024086380] = null;
            if(null == val_12)
            {
                goto label_25;
            }
            
            goto label_26;
            label_20:
            if((null == null) || (val_12 < 1))
            {
                goto label_24;
            }
            
            mem[1152921560024086376] = null;
            if(null == val_12)
            {
                goto label_25;
            }
            
            goto label_26;
            label_24:
            val_17 = 1;
            label_25:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_26:
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂三丐丗一丞三丁丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.三丁丘一一上丏下丆>(object:  this, method:  System.Void PGCompany.BattlePass.丂丐与丞业丂丒下丆::丂丒一一丁且丏丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.三丁丘一一上丏下丆 丗丛不丁丑专专丂且)));
            this.丞上丝丗七丁七丑丘();
        }
    
    }

}
