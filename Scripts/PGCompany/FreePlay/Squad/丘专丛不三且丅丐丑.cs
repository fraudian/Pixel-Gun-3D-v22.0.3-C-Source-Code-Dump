using UnityEngine;

namespace PGCompany.FreePlay.Squad
{
    public class 丘专丛不三且丅丐丑
    {
        // Fields
        private UnityEngine.Coroutine 丆丅丝上丌专七三丌;
        private PGCompany.FreePlay.Squad.SquadUi 专业丗丙且丐丟丏丐;
        private FreePlayModeController 业丗丟七上丒丛丅丅;
        private System.Collections.Generic.List<string> 丘丞七三万万丟丗一;
        private System.Collections.Generic.List<string> 丑上专丘丝丂丛丘业;
        public const float 丏丝专三丞东与万丑 = 50;
        private bool 与丕丛丁且丌丝丙三;
        
        // Properties
        public PGCompany.FreePlay.Squad.SquadUi 丘上丒丞丘丑丘丈万 { get; set; }
        
        // Methods
        public PGCompany.FreePlay.Squad.SquadUi 丕业丐丙丕丆丕丙丆()
        {
            return (PGCompany.FreePlay.Squad.SquadUi)this.专业丗丙且丐丟丏丐;
        }
        public void 丈丙丙丐下丅丒三一(PGCompany.FreePlay.Squad.SquadUi 丙业与丙丗丝不丈东)
        {
            var val_4;
            this.专业丗丙且丐丟丏丐 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == 0)
            {
                    return;
            }
            
            this.专业丗丙且丐丟丏丐.<丕丅三丒丗上丗丏上>k__BackingField = this;
            val_4 = 1152921504615739392;
            this.专业丗丙且丐丟丏丐.CloseClicked = new System.Action(object:  this, method:  System.Void PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑::丞丒丈丛业专丒丏且());
            this.专业丗丙且丐丟丏丐.LeaveSquadClicked = new System.Action(object:  this, method:  System.Void PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑::世业万丂三丕丛丂丂());
        }
        internal 丘专丛不三且丅丐丑(FreePlayModeController 且与万万丝三一丂丈)
        {
            this.业丗丟七上丒丛丅丅 = 且与万万丝三一丂丈;
        }
        internal void 丗专万下丆丛丏东丒()
        {
            if(this.专业丗丙且丐丟丏丐 == 0)
            {
                    return;
            }
            
            this.专业丗丙且丐丟丏丐.丅与丌专丟一丝业三().SetActive(value:  true);
            this.丄不丟丙下丆丘不丁();
            this.丆丅丝上丌专七三丌 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丕三丁与丏丁丙业七());
        }
        private void 丄不丟丙下丆丘不丁()
        {
            if(this.丆丅丝上丌专七三丌 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丆丅丝上丌专七三丌);
            }
            
            this.丆丅丝上丌专七三丌 = 0;
        }
        private System.Collections.IEnumerator 丕三丁与丏丁丙业七()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丘专丛不三且丅丐丑.丘丁世丆世专丏丌丄();
        }
        private void 一丏丘且丞丙不且上()
        {
            if(this.业丗丟七上丒丛丅丅 == 0)
            {
                    return;
            }
            
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return;
            }
            
            this.专业丗丙且丐丟丏丐.SetSquadCount(丌丒丝东丌下丕丁丅:  this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.且丌世丈下丄三丅丅(), 与业丄丂丂丆下上丞:  this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丏丗丙丄丞丄丝丌丈);
        }
        private void 丌且丟丅七丅丙业不()
        {
            if(this.业丗丟七上丒丛丅丅 == 0)
            {
                    return;
            }
            
            this.专业丗丙且丐丟丏丐.SetBottomView(业世专丕丒万丘与三:  this.业丗丟七上丒丛丅丅.丄丗三丌世东业上丌());
        }
        private void 与丟世且七与一丐丌()
        {
            PGCompany.FreePlay.Squad.SquadUi val_3;
            var val_4;
            bool val_5;
            val_3 = this;
            if(this.业丗丟七上丒丛丅丅 == 0)
            {
                    return;
            }
            
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return;
            }
            
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丌丑丑丙丗丛丟丕丏() == false)
            {
                goto label_8;
            }
            
            this.世丆万三丐下业丟丂(七丌丙三东丌丏下丛:  this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝);
            val_4 = val_3;
            val_5 = 1;
            if(this.与丕丛丁且丌丝丙三 == true)
            {
                goto label_12;
            }
            
            goto label_11;
            label_8:
            this.且丒不东业丏万丆丞(且与万万丝三一丂丈:  this.业丗丟七上丒丛丅丅);
            val_4 = val_3;
            val_5 = false;
            if(this.与丕丛丁且丌丝丙三 == false)
            {
                goto label_12;
            }
            
            label_11:
            val_3 = this.专业丗丙且丐丟丏丐;
            val_3.RepositionList();
            label_12:
            this.与丕丛丁且丌丝丙三 = val_5;
        }
        private void 世丆万三丐下业丟丂(世三丑上丂三专丐丙 七丌丙三东丌丏下丛)
        {
            System.Collections.Generic.List<System.String> val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.List<System.String> val_15;
            val_11 = this.丘丞七三万万丟丗一;
            if(val_11 == null)
            {
                    val_11 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Repeat<System.String>(element:  0, count:  七丌丙三东丌丏下丛.丏丗丙丄丞丄丝丌丈));
                this.丘丞七三万万丟丗一 = val_11;
            }
            
            val_12 = 0;
            goto label_3;
            label_6:
            this.丘丞七三万万丟丗一.set_Item(index:  0, value:  0);
            val_11 = this.丘丞七三万万丟丗一;
            val_12 = 1;
            label_3:
            if(val_12 < val_11.Count)
            {
                goto label_6;
            }
            
            val_13 = 0;
            goto label_7;
            label_14:
            NetworkStartTable val_5 = 七丌丙三东丌丏下丛.丕丄丛丁丆丛东丐丕().Item[0];
            this.丘丞七三万万丟丗一.set_Item(index:  0, value:  val_5.丈三世丞丕万丄七丂);
            val_13 = 1;
            label_7:
            if(val_13 < 七丌丙三东丌丏下丛.丕丄丛丁丆丛东丐丕().Count)
            {
                goto label_14;
            }
            
            val_14 = 0;
            goto label_15;
            label_19:
            if(this.丘丞七三万万丟丗一.Item[0] == null)
            {
                goto label_17;
            }
            
            val_14 = 1;
            label_15:
            val_15 = this.丘丞七三万万丟丗一;
            if(val_14 < val_15.Count)
            {
                goto label_19;
            }
            
            goto label_20;
            label_17:
            val_15 = this.丘丞七三万万丟丗一;
            val_15.set_Item(index:  0, value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            label_20:
            this.专业丗丙且丐丟丏丐.UpdatePlayerList(丅下丏丙丞东丒丕丁:  this.丘丞七三万万丟丗一);
        }
        private void 且丒不东业丏万丆丞(FreePlayModeController 且与万万丝三一丂丈)
        {
            System.Collections.Generic.List<System.String> val_7;
            string val_8;
            var val_9;
            var val_10;
            val_7 = this.丑上专丘丝丂丛丘业;
            if(val_7 == null)
            {
                    val_7 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Repeat<System.String>(element:  0, count:  GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  31)));
                this.丑上专丘丝丂丛丘业 = val_7;
            }
            
            val_8 = 1152921516934571616;
            val_9 = 0;
            goto label_4;
            label_7:
            this.丑上专丘丝丂丛丘业.set_Item(index:  0, value:  0);
            val_7 = this.丑上专丘丝丂丛丘业;
            val_9 = 1;
            label_4:
            if(val_9 < val_7.Count)
            {
                goto label_7;
            }
            
            val_10 = 0;
            goto label_8;
            label_14:
            NetworkStartTable val_5 = Item[0];
            val_8 = val_5.丈三世丞丕万丄七丂;
            this.丑上专丘丝丂丛丘业.set_Item(index:  0, value:  val_8);
            val_10 = 1;
            label_8:
            if(val_10 < this.丑上专丘丝丂丛丘业.Count)
            {
                goto label_14;
            }
            
            this.专业丗丙且丐丟丏丐.UpdatePlayerList(丅下丏丙丞东丒丕丁:  this.丑上专丘丝丂丛丘业);
        }
        internal bool 丏丟丒丆东万丂丕丕(string 丄丒且丙三丆丟与丏)
        {
            string val_9;
            FreePlayModeController val_10;
            var val_11;
            val_9 = this;
            val_10 = this.业丗丟七上丒丛丅丅;
            if(val_10 != 0)
            {
                    val_10 = this.业丗丟七上丒丛丅丅;
                if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 != null)
            {
                    NetworkStartTable val_2 = this.丞丆丛丙丒丙三丘丏(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
                if(val_2 != 0)
            {
                    val_9 = this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丅与丅丛丏万三丙七;
                string val_4 = NetworkStartTable.丏三不丙丐丘丑丞专(专丞上七七且丝七丗:  val_2);
                val_10 = 1152921505284374528;
                if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_9)) != false) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_4)) != false))
            {
                    if((System.String.op_Inequality(a:  val_4, b:  val_9)) != false)
            {
                    val_11 = 1;
                return (bool)val_11;
            }
            
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != false)
            {
                    return 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_4);
            }
            
            }
            
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        internal bool 丗业丌丅丐丘上丞丕(string 丄丒且丙三丆丟与丏)
        {
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            val_10 = this.丞丆丛丙丒丙三丘丏(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
            if(val_10 == 0)
            {
                    val_11 = 1;
                return (bool)((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) > 2500f) ? 1 : 0;
            }
            
            UnityEngine.Vector3 val_4 = val_1.丌丑丛业丈丘世丞丕.丌丟丄业且三丛丕丄().position;
            val_12 = null;
            val_12 = null;
            val_10 = 丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_6 = val_10.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            return (bool)((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) > 2500f) ? 1 : 0;
        }
        private void 丞丒丈丛业专丒丏且()
        {
            this.丆丕东丒丒业丘丕丘();
        }
        private void 世业万丂三丕丛丂丂()
        {
            this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.不三丟丟专丗万业下();
        }
        public void 丆丕东丒丒业丘丕丘()
        {
            this.丄不丟丙下丆丘不丁();
            if(this.专业丗丙且丐丟丏丐 == 0)
            {
                    return;
            }
            
            this.专业丗丙且丐丟丏丐.丅与丌专丟一丝业三().SetActive(value:  false);
        }
        public string 上不东丏下丁丞万丟(string 丄丒且丙三丆丟与丏)
        {
            string val_3;
            if((this.丞丆丛丙丒丙三丘丏(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) == 0)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_3 = val_1.丂丈丐不丏万三七丐;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public bool 丟万与东丐丘丌东上(string 丄丒且丙三丆丟与丏)
        {
            var val_4;
            if((this.丞丆丛丙丒丙三丘丏(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) != 0)
            {
                    var val_3 = (val_1.丞丗丅东业丑不丙丞 == true) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private NetworkStartTable 丞丆丛丙丒丙三丘丏(string 丄丒且丙三丆丟与丏)
        {
            var val_5;
            var val_6;
            val_5 = this;
            .丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
            int val_3 = this.业丗丟七上丒丛丅丅.FindIndex(match:  new System.Predicate<NetworkStartTable>(object:  new 丘专丛不三且丅丐丑.丒丂万丒丂一上丞一(), method:  System.Boolean 丘专丛不三且丅丐丑.丒丂万丒丂一上丞一::丅丒专丕丁丌丛丏丂(NetworkStartTable 三丟东丕丄丄下下丑)));
            if((val_3 & 2147483648) == 0)
            {
                    NetworkStartTable val_4 = this.业丗丟七上丒丛丅丅.Item[val_3];
                return (NetworkStartTable)val_6;
            }
            
            val_6 = 0;
            return (NetworkStartTable)val_6;
        }
        public bool 丞世上与丞世上下万(string 丄丒且丙三丆丟与丏)
        {
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return (bool)this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝;
            }
            
            return this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丟丅丑丄丑丌万一专(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
        }
        public bool 丌不丈丏不三业丑世(string 丄丒且丙三丆丟与丏)
        {
            System.Collections.Generic.List<System.String> val_2 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上();
            if(val_2 != null)
            {
                    return val_2.Contains(item:  丄丒且丙三丆丟与丏);
            }
            
            return val_2.Contains(item:  丄丒且丙三丆丟与丏);
        }
        internal 世三丑上丂三专丐丙.丅不丄一丌下丁丕世 丌丛丑丏且三与丏丆(string 丄丒且丙三丆丟与丏)
        {
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return (丅不丄一丌下丁丕世)this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝;
            }
            
            return this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丌丛丑丏且三与丏丆(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
        }
        internal 世三丑上丂三专丐丙.丅不丄一丌下丁丕世 丟丘下丗东丝丏丅丛(string 丄丒且丙三丆丟与丏)
        {
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return (丅不丄一丌下丁丕世)this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝;
            }
            
            return this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丟丘下丗东丝丏丅丛(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
        }
        public bool 丗三丕丏丏丐业且与(string 丄丒且丙三丆丟与丏)
        {
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 == null)
            {
                    return (bool)this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝;
            }
            
            return this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丞丒三上三专与丏丗(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
        }
        public void 丞七丝丟三与万业丗(string 丄丒且丙三丆丟与丏)
        {
            NetworkStartTable val_1 = this.丞丆丛丙丒丙三丘丏(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
            if(val_1 != null)
            {
                    val_1.丟上丌丑丝与三丂丂();
            }
            
            if(this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝 != null)
            {
                    this.业丗丟七上丒丛丅丅.丕万丝丐不三丂丘丝.丈丈上丅丕丄丙七丂(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
            }
            
            this.与丟世且七与一丐丌();
        }
    
    }

}
