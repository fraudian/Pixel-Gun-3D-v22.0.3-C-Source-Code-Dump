using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丕丐七业丐丟且丄丟 : 丏七丁丌世丟丁丅丙
    {
        // Fields
        private bool 且丘与丑且丟与丐世;
        
        // Properties
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 丕丐七业丐丟且丄丟(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            mem[1152921559987724432] = 0;
            mem[1152921559987724440] = 0;
            val_1 = new PGCompany.BattlePass.丘丄上丏不丝不丐丐(丕下一东丏丅丄不业:  下丝丘丁专丐丅丛丝);
            goto typeof(PGCompany.BattlePass.丕丐七业丐丟且丄丟).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丗不丕丄业专丝丞(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.BattlePass.丕丐七业丐丟且丄丟::与世丛丟一上上丈丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丄且丑丂丑丆丈不三(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.BattlePass.丕丐七业丐丟且丄丟::与世丛丟一上上丈丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
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
            label_25:
            if(((-453394512) & 1) == 0)
            {
                goto label_2;
            }
            
            if((val_3.丐丏七丌丕丗业且上() == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_25;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "map", comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == false)
            {
                goto label_10;
            }
            
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "win", comparisonType:  5)) == false)
            {
                goto label_25;
            }
            
            this.且丘与丑且丟与丐世 = true;
            goto label_25;
            label_10:
            mem[1152921559988039472] = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            goto label_25;
            label_1:
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionWin UpdateParams parameters == null", args:  this);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override int 丛三丙上丞丐三丘丛()
        {
            丘上上万专丙万丟丑 val_1 = this.业丑丁丆丕丆丂丅万();
            if(val_1 != null)
            {
                    if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != false)
            {
                    return this.丐丑七丐一丝七上七();
            }
            
            }
            
            if(W8 != 0)
            {
                    return (int)val_1;
            }
            
            丘上上万专丙万丟丑 val_4 = this.业丑丁丆丕丆丂丅万();
            if(val_4 != null)
            {
                    return val_4.且专丂丐丟一不丌丟();
            }
            
            return val_4.且专丂丐丟一不丌丟();
        }
        internal override void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_7;
            var val_8;
            mem[1152921559988353704] = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  static_value_082CC000)) != true)
            {
                    val_7 = null;
                val_7 = null;
                if(SceneInfoController.丄丘七三上丕世丞业 != 0)
            {
                    val_8 = null;
                val_8 = null;
                if((SceneInfoController.丄丘七三上丕世丞业.丌且丏世丌丗丕丄丟(专万丟三世业丙丈且:  1152921505254395904, 丂丛丑东不丅丈一东:  W23)) != false)
            {
                    if(丗丛不丁丑专专丂且 != null)
            {
                    if((System.String.Equals(a:  SceneInfoController.丄丘七三上丕世丞业, b:  丗丛不丁丑专专丂且.丕丆丞丂业东与上丅(), comparisonType:  5)) == true)
            {
                goto label_14;
            }
            
            }
            
                mem[1152921559988353728] = 0;
            }
            
            }
            
            }
            
            label_14:
            if(SceneInfoController.丄丘七三上丕世丞业 == 1)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且 != null)
            {
                    if(SceneInfoController.丄丘七三上丕世丞业 == 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                    return;
            }
            
            }
            
            mem[1152921559988353728] = 0;
        }
        private void 与世丛丟一上上丈丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            if(true == 0)
            {
                    return;
            }
            
            val_10 = this.业丑丁丆丕丆丂丅万();
            if(val_10.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) != true)
            {
                    val_11 = null;
                val_11 = null;
                if(SceneInfoController.丄丘七三上丕世丞业 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_10 = SceneInfoController.丄丘七三上丕世丞业;
                if((val_10.丌且丏世丌丗丕丄丟(专万丟三世业丙丈且:  1152921505254395904, 丂丛丑东不丅丈一东:  W23)) != false)
            {
                    if((丗丛不丁丑专专丂且 == null) || ((System.String.Equals(a:  val_10, b:  丗丛不丁丑专专丂且.丕丆丞丂业东与上丅(), comparisonType:  5)) == false))
            {
                goto label_23;
            }
            
            }
            
            }
            
            }
            
            if(val_10 != 1)
            {
                    if((丗丛不丁丑专专丂且 == null) || (val_10 != 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌()))
            {
                goto label_23;
            }
            
            }
            
            bool val_10 = this.且丘与丑且丟与丐世;
            if(val_10 != false)
            {
                    if((丗丛不丁丑专专丂且 == null) || (丗丛不丁丑专专丂且.东丐三一业与丘丂丕() == false))
            {
                goto label_23;
            }
            
            }
            
            if(val_10 == false)
            {
                goto label_24;
            }
            
            val_10 = val_10 + 1;
            mem[1152921559988502592] = val_10;
            if(val_10 >= 0)
            {
                goto label_25;
            }
            
            goto label_26;
            label_23:
            mem[1152921559988502592] = 0;
            return;
            label_24:
            val_13 = 1;
            label_25:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_26:
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丗不丕丄业专丝丞(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.BattlePass.丕丐七业丐丟且丄丟::与世丛丟一上上丈丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            this.丞上丝丗七丁七丑丘();
        }
    
    }

}
