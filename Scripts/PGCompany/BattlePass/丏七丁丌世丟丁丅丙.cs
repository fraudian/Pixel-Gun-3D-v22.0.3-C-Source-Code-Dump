using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丏七丁丌世丟丁丅丙 : 丘丄上丏不丝不丐丐
    {
        // Fields
        internal int 丏丏丞丒丄世丛与丄;
        internal int 丒不世不丏丙上丆丁;
        internal int 丛丗七丝丑丅丝上万;
        internal int 丝丅丑一丛丛丆世且;
        internal int 丒丝丅丕下三下丐丄;
        internal bool 东丌东下三丁丗下丈;
        internal bool 丗丐世专一世七且上;
        internal bool 丅丗丄丂与三丐丑丈;
        internal int 丙丐一丒且丕丗丟丂;
        
        // Methods
        internal 丏七丁丌世丟丁丅丙(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与)
        {
            this.丛丗七丝丑丅丝上万 = 0;
            this.丝丅丑一丛丛丆世且 = 0;
            this.丒丝丅丕下三下丐丄 = 0;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            System.EventHandler<Rilisoft.业丗丒丞万七三丄七> val_2 = new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_1F0);
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丙万丛丂东丒丆万(丙业与丙丗丝不丈东:  null);
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_210));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().上丆万丗丄丌丘丞且(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_200));
            this.丙丐一丒且丕丗丟丂 = 0;
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
            label_29:
            if(((-429755696) & 1) == 0)
            {
                goto label_2;
            }
            
            if((val_3.丐丏七丌丕丗业且上() == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_29;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "per_match", comparisonType:  5)) != false)
            {
                    this.东丌东下三丁丗下丈 = true;
                this.丝丅丑一丛丛丆世且 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "per_live", comparisonType:  5)) != false)
            {
                    this.丗丐世专一世七且上 = true;
                this.丛丗七丝丑丅丝上万 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "streak", comparisonType:  5)) == false)
            {
                goto label_29;
            }
            
            this.丅丗丄丂与三丐丑丈 = true;
            this.丒丝丅丕下三下丐丄 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
            goto label_29;
            label_1:
            this = this.GetType() + " Update_Params parameters == null"(" Update_Params parameters == null");
            UnityEngine.Debug.LogErrorFormat(format:  this, args:  System.Array.Empty<System.Object>());
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal virtual void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丏丏丞丒丄世丛与丄 = 0;
            this.丒不世不丏丙上丆丁 = 0;
        }
        internal virtual void 丟三上丂与专且丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丏丏丞丒丄世丛与丄 = 0;
        }
        internal virtual void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            goto typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_1F8;
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            System.EventHandler<Rilisoft.业丗丒丞万七三丄七> val_2 = new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_210);
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  null);
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().下下丑丕且且业下丆(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_1F0));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌且丈丐丐且丄丙七(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(PGCompany.BattlePass.丏七丁丌世丟丁丅丙).__il2cppRuntimeField_200));
        }
    
    }

}
