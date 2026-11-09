using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丅丗丐三万丅业丂专 : 丏七丁丌世丟丁丅丙
    {
        // Methods
        internal 丅丗丐三万丅业丂专(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            goto typeof(PGCompany.BattlePass.丅丗丐三万丅业丂专).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().万丅业丑上东丑丘丛(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丙丞下七丏下专专>(object:  this, method:  System.Void PGCompany.BattlePass.丅丗丐三万丅业丂专::丈专专丑丈丌丆丙丐(object 不丟丗丏丛丕不丁丌, Rilisoft.业丙丞下七丏下专专 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丟专世丟万东丞不丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丙丞下七丏下专专>(object:  this, method:  System.Void PGCompany.BattlePass.丅丗丐三万丅业丂专::丈专专丑丈丌丆丙丐(object 不丟丗丏丛丕不丁丌, Rilisoft.业丙丞下七丏下专专 丗丛不丁丑专专丂且)));
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
            label_23:
            if(((-425022096) & 1) == 0)
            {
                goto label_2;
            }
            
            if((((val_3.丐丏七丌丕丗业且上() == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "map", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_23;
            }
            
            this.下东丅世丅专丝专丌(丙业与丙丗丝不丈东:  0);
            goto label_23;
            label_1:
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionWin UpdateParams parameters == null", args:  this);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丈专专丑丈丌丆丙丐(object 不丟丗丏丛丕不丁丌, Rilisoft.业丙丞下七丏下专专 丗丛不丁丑专专丂且)
        {
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            val_13 = this.业丑丁丆丕丆丂丅万();
            if(val_13.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            val_13 = this.丕丆丞丂业东与上丅();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) == true)
            {
                goto label_15;
            }
            
            val_14 = null;
            val_14 = null;
            val_13 = SceneInfoController.丄丘七三上丕世丞业;
            if(val_13 == 0)
            {
                goto label_15;
            }
            
            val_15 = null;
            val_15 = null;
            val_13 = SceneInfoController.丄丘七三上丕世丞业;
            if((val_13.丌且丏世丌丗丕丄丟(专万丟三世业丙丈且:  this.丕丆丞丂业东与上丅(), 丂丛丑东不丅丈一东:  5)) == false)
            {
                goto label_15;
            }
            
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            val_13 = this.丕丆丞丂业东与上丅();
            if((System.String.Equals(a:  val_13, b:  丗丛不丁丑专专丂且.丕丆丞丂业东与上丅(), comparisonType:  5)) == true)
            {
                goto label_17;
            }
            
            return;
            label_15:
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            label_17:
            if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() != 5)
            {
                    return;
            }
            
            if((null == 0) || (0 < 1))
            {
                goto label_22;
            }
            
            mem[1152921560016605932] = 1152921505284374529;
            if(1152921505284374529 == 0)
            {
                goto label_27;
            }
            
            goto label_28;
            label_22:
            if((null == 0) || (0 < 1))
            {
                goto label_26;
            }
            
            mem[1152921560016605928] = 1152921505284374529;
            if(1152921505284374529 == 0)
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            val_16 = 1;
            label_27:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_28:
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().万丅业丑上东丑丘丛(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丙丞下七丏下专专>(object:  this, method:  System.Void PGCompany.BattlePass.丅丗丐三万丅业丂专::丈专专丑丈丌丆丙丐(object 不丟丗丏丛丕不丁丌, Rilisoft.业丙丞下七丏下专专 丗丛不丁丑专专丂且)));
            this.丞上丝丗七丁七丑丘();
        }
    
    }

}
