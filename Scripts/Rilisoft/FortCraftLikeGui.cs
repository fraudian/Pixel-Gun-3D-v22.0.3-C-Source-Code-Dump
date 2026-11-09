using UnityEngine;

namespace Rilisoft
{
    public class FortCraftLikeGui : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.FortCraftLikeGui.丕丟丕丌丒丞世与丅> 三丏万丏专丛丘丁万;
        private Rilisoft.BetterWrapContent _wrap;
        
        // Methods
        private void OnEnable()
        {
            this.不下丌丆东丑丈丕丝();
        }
        private void OnDisable()
        {
        
        }
        private void 不下丌丆东丑丈丕丝()
        {
            var val_6;
            var val_13;
            System.Collections.Generic.List<丕丟丕丌丒丞世与丅> val_1 = new System.Collections.Generic.List<丕丟丕丌丒丞世与丅>();
            val_13 = 与与一丆专丕丄丆丗.丑七不且上丗丁一世().丁下丒丌下丅世丝丈();
            List.Enumerator<T> val_4 = val_13.GetEnumerator();
            label_15:
            if(((-605556416) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            string val_8 = val_7.业丐丐三丕一丗丛丁();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) == true)
            {
                goto label_15;
            }
            
            string val_10 = val_7.东丙上东业丆不丟丘();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) == true)
            {
                goto label_15;
            }
            
            new FortCraftLikeGui.丕丟丕丌丒丞世与丅() = new System.Object();
            if(new FortCraftLikeGui.丕丟丕丌丒丞世与丅() != null)
            {
                    .丐丅与三万丏丏专上 = val_8;
            }
            else
            {
                    mem[24] = val_8;
            }
            
            .业业丁丕丒且万丕上 = val_10;
            val_1.Add(item:  new FortCraftLikeGui.丕丟丕丌丒丞世与丅());
            goto label_15;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.七丄与且且丈不一万(丄东东丗丄万丟丕丝:  val_1);
        }
        private void 七丄与且且丈不一万(System.Collections.Generic.List<Rilisoft.FortCraftLikeGui.丕丟丕丌丒丞世与丅> 丄东东丗丄万丟丕丝)
        {
            this.三丏万丏专丛丘丁万 = 丄东东丗丄万丟丕丝;
            this._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this, method:  System.Int32 Rilisoft.FortCraftLikeGui::且不丏不丝业丛丁丄()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Void Rilisoft.FortCraftLikeGui::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 业丌丆业丘丟丆丁丛)));
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 业丌丆业丘丟丆丁丛)
        {
            Rilisoft.LikeCell val_1 = 丕一一丆丌丝丕业万.GetComponent<Rilisoft.LikeCell>();
        }
        public void ClickToCell(Rilisoft.LikeCell 丌丝万上丅丒一丈丘)
        {
            string val_11 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                    return;
            }
            
            丕丟丕丌丒丞世与丅 val_3 = 丌丝万上丅丒一丈丘.Data;
            val_11 = val_3.丐丅与三万丏丏专上;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true)
            {
                    return;
            }
            
            丕丟丕丌丒丞世与丅 val_5 = 丌丝万上丅丒一丈丘.Data;
            val_11 = val_5.丐丅与三万丏丏专上;
            if((System.String.op_Equality(a:  val_11, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
            val_11 = null;
            val_11 = new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.FortCraftLikeGui::且下专上且丅丈业丙(bool 丌丗丏丏丛东专丁且));
            丕丟丕丌丒丞世与丅 val_10 = 丌丝万上丅丒一丈丘.Data;
            FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  val_10.丐丅与三万丏丏专上, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  null);
        }
        public FortCraftLikeGui()
        {
        
        }
        private int 且不丏不丝业丛丁丄()
        {
            int val_1 = this.三丏万丏专丛丘丁万.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
        private void 且下专上且丅丈业丙(bool 丌丗丏丏丛东专丁且)
        {
            this.gameObject.SetActive(value:  true);
        }
    
    }

}
