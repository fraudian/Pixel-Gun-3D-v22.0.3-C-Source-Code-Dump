using UnityEngine;

namespace PGCompany.FreePlay.Squad
{
    public class SquadUi : PGBehaviour
    {
        // Fields
        private PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 <丕丅三丒丗上丗丏上>k__BackingField;
        public System.Action CloseClicked;
        public System.Action LeaveSquadClicked;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UILabel _squadCountLabel;
        private UnityEngine.GameObject _hintHowCreateSquad;
        private UnityEngine.GameObject _buttonLeaveSquad;
        private WidgetLayout _playerListWidgetLayout;
        private PGCompany.FreePlay.Squad.PlayerUi _playerUiPrefab;
        private UIScrollView _playerListScrollView;
        private DialogWindowController _leaveSquadDialog;
        private System.Collections.Generic.List<PGCompany.FreePlay.Squad.PlayerUi> 不且丑下上丌丟三丗;
        private System.Collections.Generic.List<string> 业丙上丈丕业丙丄丆;
        
        // Properties
        public PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 丘专丛不三且丅丐丑 { get; set; }
        
        // Methods
        public PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 get_SquadUiController()
        {
            return (PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑)this.<丕丅三丒丗上丗丏上>k__BackingField;
        }
        public void set_SquadUiController(PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 丙业与丙丗丝不丈东)
        {
            this.<丕丅三丒丗上丗丏上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void OnEnable()
        {
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.FreePlay.Squad.SquadUi::U_Close()), 与且专丈不万东一万:  "SquadUi");
            this._leaveSquadDialog.CloseWindow();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  86);
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = 0;
            this.业丙上丈丕业丙丄丆.Clear();
        }
        public void RepositionList()
        {
            this._playerListScrollView.ResetPosition();
        }
        public void U_Close()
        {
            if(this.CloseClicked == null)
            {
                    return;
            }
            
            this.CloseClicked.Invoke();
        }
        public void U_LeaveSquad()
        {
            this._leaveSquadDialog.add_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.FreePlay.Squad.SquadUi::丗丛丏丁且一万三万()));
        }
        public void SetSquadCount(int 丌丒丝东丌下丕丁丅, int 与业丄丂丂丆下上丞)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._squadCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11805"), arg0:  System.String.Format(format:  "{0}/{1}", arg0:  丌丒丝东丌下丕丁丅, arg1:  与业丄丂丂丆下上丞)));
        }
        public void SetBottomView(bool 业世专丕丒万丘与三)
        {
            业世专丕丒万丘与三 = (~业世专丕丒万丘与三) & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hintHowCreateSquad, 丏业丟一东丂东丘丛:  业世专丕丒万丘与三);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonLeaveSquad, 丏业丟一东丂东丘丛:  业世专丕丒万丘与三);
        }
        public void UpdatePlayerList(System.Collections.Generic.List<string> 丅下丏丙丞东丒丕丁)
        {
            var val_7;
            var val_8;
            this.丗丏丟业丆丘业七丑(丌丒丝东丌下丕丁丅:  丅下丏丙丞东丒丕丁.Count);
            this.业丅业且下业三丏丄(丅下丏丙丞东丒丕丁:  丅下丏丙丞东丒丕丁);
            val_7 = 0;
            val_8 = 0;
            goto label_2;
            label_7:
            string val_2 = this.业丙上丈丕业丙丄丆.Item[0];
            if(val_2 != null)
            {
                    this.丅丘丟丆上丘丆丆与(且不丈丏东专丑丈一:  this.不且丑下上丌丟三丗.Item[0], 丄丒且丙三丆丟与丏:  val_2);
                val_8 = 1;
            }
            
            val_7 = 1;
            label_2:
            if(val_7 < this.业丙上丈丕业丙丄丆.Count)
            {
                goto label_7;
            }
            
            goto label_8;
            label_13:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.不且丑下上丌丟三丗.Item[1], 丏业丟一东丂东丘丛:  false);
            val_8 = 2;
            label_8:
            if(val_8 < this.不且丑下上丌丟三丗.Count)
            {
                goto label_13;
            }
            
            this._playerListWidgetLayout.Reposition();
        }
        private void 业丅业且下业三丏丄(System.Collections.Generic.List<string> 丅下丏丙丞东丒丕丁)
        {
            System.Collections.Generic.List<System.String> val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_16;
            val_11 = this.业丙上丈丕业丙丄丆;
            if(val_11 == null)
            {
                    System.Collections.Generic.List<System.String> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Collections.Generic.List<System.String>(capacity:  丅下丏丙丞东丒丕丁.Count);
                this.业丙上丈丕业丙丄丆 = val_11;
            }
            
            if(val_2.Count < 丅下丏丙丞东丒丕丁.Count)
            {
                    System.Collections.Generic.List<System.String> val_11 = this.业丙上丈丕业丙丄丆;
                val_11 = 丅下丏丙丞东丒丕丁.Count - val_11.Count;
                if(val_11 >= 1)
            {
                    val_12 = 1152921516107659296;
                do
            {
                this.业丙上丈丕业丙丄丆.Add(item:  0);
                val_11 = val_11 - 1;
            }
            while(val_11 != 0);
            
            }
            
            }
            
            val_13 = 0;
            goto label_11;
            label_19:
            if(丅下丏丙丞东丒丕丁.Count > val_13)
            {
                    val_12 = 丅下丏丙丞东丒丕丁.Item[0];
                val_14 = public System.Void System.Collections.Generic.List<System.String>::set_Item(int index, System.String value);
                val_15 = val_13;
                val_16 = val_12;
            }
            else
            {
                    val_14 = public System.Void System.Collections.Generic.List<System.String>::set_Item(int index, System.String value);
                val_15 = val_13;
                val_16 = 0;
            }
            
            this.业丙上丈丕业丙丄丆.set_Item(index:  0, value:  val_16);
            val_13 = 1;
            label_11:
            if(val_13 < this.业丙上丈丕业丙丄丆.Count)
            {
                goto label_19;
            }
            
            this.业丙上丈丕业丙丄丆.Sort(comparison:  new System.Comparison<System.String>(object:  this, method:  System.Int32 PGCompany.FreePlay.Squad.SquadUi::丂丆世世丕丅丕丅上(string 且万东一丘丅丙丆专, string 上七丗丌七丄丂七丒)));
        }
        private int 丂丆世世丕丅丕丅上(string 且万东一丘丅丙丆专, string 上七丗丌七丄丂七丒)
        {
            var val_21;
            var val_22;
            if((且万东一丘丅丙丆专 | 上七丗丌七丄丂七丒) == null)
            {
                    val_21 = 0;
                return (int)val_21;
            }
            
            var val_2 = (上七丗丌七丄丂七丒 != null) ? (-0) : 0;
            if(且万东一丘丅丙丆专 == null)
            {
                    return (int)val_21;
            }
            
            if(上七丗丌七丄丂七丒 == null)
            {
                    return (int)val_21;
            }
            
            if((System.String.op_Equality(a:  且万东一丘丅丙丆专, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                goto label_4;
            }
            
            label_30:
            val_21 = 0;
            return (int)val_21;
            label_4:
            if((System.String.op_Equality(a:  上七丗丌七丄丂七丒, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                goto label_6;
            }
            
            label_32:
            val_21 = 1;
            return (int)val_21;
            label_6:
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丟万与东丐丘丌东上(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) != false)
            {
                    if((this.<丕丅三丒丗上丗丏上>k__BackingField.丟万与东丐丘丌东上(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) != false)
            {
                    return System.String.Compare(strA:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专), strB:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒), comparisonType:  2);
            }
            
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丟万与东丐丘丌东上(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) == true)
            {
                goto label_30;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丟万与东丐丘丌东上(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) == true)
            {
                goto label_32;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丞世上与丞世上下万(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) != false)
            {
                    if((this.<丕丅三丒丗上丗丏上>k__BackingField.丞世上与丞世上下万(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) == true)
            {
                    return System.String.Compare(strA:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专), strB:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒), comparisonType:  2);
            }
            
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丞世上与丞世上下万(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) == true)
            {
                goto label_30;
            }
            
            val_22 = this.<丕丅三丒丗上丗丏上>k__BackingField;
            if((val_22.丞世上与丞世上下万(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) == true)
            {
                goto label_32;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField) == null)
            {
                    val_22 = 0;
            }
            
            if((val_22.丌不丈丏不三业丑世(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) != false)
            {
                    if((this.<丕丅三丒丗上丗丏上>k__BackingField) == null)
            {
                    val_22 = 0;
            }
            
                if((val_22.丌不丈丏不三业丑世(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) == true)
            {
                    return System.String.Compare(strA:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专), strB:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒), comparisonType:  2);
            }
            
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField) == null)
            {
                    val_22 = 0;
            }
            
            if((val_22.丌不丈丏不三业丑世(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专)) == true)
            {
                goto label_30;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField) == null)
            {
                    val_22 = 0;
            }
            
            if((val_22.丌不丈丏不三业丑世(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒)) == true)
            {
                goto label_32;
            }
            
            return System.String.Compare(strA:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  且万东一丘丅丙丆专), strB:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  上七丗丌七丄丂七丒), comparisonType:  2);
        }
        private void 丅丘丟丆上丘丆丆与(PGCompany.FreePlay.Squad.PlayerUi 且不丈丏东专丑丈一, string 丄丒且丙三丆丟与丏)
        {
            PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 val_13 = this;
            if(且不丈丏东专丑丈一 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  且不丈丏东专丑丈一, 丏业丟一东丂东丘丛:  true);
            if(且不丈丏东专丑丈一 != null)
            {
                    且不丈丏东专丑丈一.丈丆丆丂且丝东丏丂 = 丄丒且丙三丆丟与丏;
            }
            else
            {
                    mem[128] = 丄丒且丙三丆丟与丏;
            }
            
            且不丈丏东专丑丈一.DisableAllStates();
            且不丈丏东专丑丈一.SetName(丞丞下东且丗丄丒丏:  this.<丕丅三丒丗上丗丏上>k__BackingField.上不东丏下丁丞万丟(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏));
            if((System.String.op_Equality(a:  丄丒且丙三丆丟与丏, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    且不丈丏东专丑丈一.SetMyPlayer();
                return;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丟万与东丐丘丌东上(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) != false)
            {
                    且不丈丏东专丑丈一.SetInMySquad();
                return;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丏丟丒丆东万丂丕丕(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) != false)
            {
                    且不丈丏东专丑丈一.SetInOtherSquad();
                return;
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丞世上与丞世上下万(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) != true)
            {
                    if((this.<丕丅三丒丗上丗丏上>k__BackingField.丗三丕丏丏丐业且与(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) == false)
            {
                goto label_21;
            }
            
            }
            
            if((this.<丕丅三丒丗上丗丏上>k__BackingField.丌丛丑丏且三与丏丆(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) == null)
            {
                    val_13 = this.<丕丅三丒丗上丗丏上>k__BackingField;
                丅不丄一丌下丁丕世 val_10 = val_13.丟丘下丗东丝丏丅丛(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
            }
            
            if((val_10.丘且丑丂丑不下丆丝(万丟丟丆丞丟丝一业:  val_10)) == true)
            {
                goto label_29;
            }
            
            且不丈丏东专丑丈一.SetInviteSent();
            return;
            label_21:
            val_13 = this.<丕丅三丒丗上丗丏上>k__BackingField;
            if((val_13.丗业丌丅丐丘上丞丕(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏)) != false)
            {
                    且不丈丏东专丑丈一.SetTooFar();
                return;
            }
            
            label_29:
            且不丈丏东专丑丈一.SetCanInvite();
        }
        private bool 丘且丑丂丑不下丆丝(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 万丟丟丆丞丟丝一业)
        {
            var val_3;
            if(万丟丟丆丞丟丝一业 == null)
            {
                goto label_5;
            }
            
            if(万丟丟丆丞丟丝一业.东业丗不东丄业三丟 > 1)
            {
                goto label_2;
            }
            
            int val_3 = 万丟丟丆丞丟丝一业.上下七丏丐丒专丙七;
            val_3 = PixelTime.丙丅丅业丟丁世丁丗() - val_3;
            if(val_3 > 10)
            {
                goto label_5;
            }
            
            if(万丟丟丆丞丟丝一业.东业丗不东丄业三丟 < 2)
            {
                goto label_9;
            }
            
            label_2:
            int val_4 = 万丟丟丆丞丟丝一业.上下七丏丐丒专丙七;
            val_4 = PixelTime.丙丅丅业丟丁世丁丗() - val_4;
            if(val_4 <= 60)
            {
                goto label_9;
            }
            
            label_5:
            val_3 = 1;
            return (bool)val_3;
            label_9:
            val_3 = 0;
            return (bool)val_3;
        }
        private void 丗丏丟业丆丘业七丑(int 丌丒丝东丌下丕丁丅)
        {
            object val_24;
            System.Collections.Generic.List<PGCompany.FreePlay.Squad.PlayerUi> val_25;
            var val_26;
            var val_29;
            var val_30;
            var val_31;
            var val_34;
            System.Collections.Generic.List<PGCompany.FreePlay.Squad.PlayerUi> val_36;
            val_24 = this;
            val_25 = this.不且丑下上丌丟三丗;
            if(val_25 == null)
            {
                    System.Collections.Generic.List<PGCompany.FreePlay.Squad.PlayerUi> val_2 = null;
                val_25 = val_2;
                val_2 = new System.Collections.Generic.List<PGCompany.FreePlay.Squad.PlayerUi>(capacity:  GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  31));
                this.不且丑下上丌丟三丗 = val_25;
            }
            
            if(val_2.Count == this._playerListWidgetLayout.transform.childCount)
            {
                goto label_44;
            }
            
            System.Collections.IEnumerator val_7 = this._playerListWidgetLayout.transform.GetEnumerator();
            val_26 = 1152921559727962464;
            label_28:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_29 = val_7.Current;
            if(val_29 != null)
            {
                
            }
            
            if(val_29 != null)
            {
                    val_29 = 0;
            }
            
            this.不且丑下上丌丟三丗.Add(item:  val_29.GetComponent<PGCompany.FreePlay.Squad.PlayerUi>());
            goto label_28;
            label_15:
            val_30 = 0;
            val_31 = 0;
            val_34 = 1152921504621703168;
            if(val_7 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_7.Dispose();
            }
            
            label_44:
            val_36 = this.不且丑下上丌丟三丗;
            if(val_36.Count >= 丌丒丝东丌下丕丁丅)
            {
                    return;
            }
            
            val_36 = this.不且丑下上丌丟三丗;
            int val_20 = 丌丒丝东丌下丕丁丅 - val_36.Count;
            if(val_20 >= 1)
            {
                    val_30 = 1152921505284374528;
                val_34 = 1152921504615686144;
                val_26 = 1152921516944179168;
                do
            {
                UnityEngine.GameObject val_23 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerUiPrefab.丅与丌专丟一丝业三(), 丈东丘丏与丌东东下:  this._playerListWidgetLayout.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                this._playerListWidgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_23);
                val_24.InviteClicked = new System.Action<System.String>(object:  this, method:  System.Void PGCompany.FreePlay.Squad.SquadUi::丘丈丄下万专丟世丒(string 丈与丆丆下丅丈丙丙));
                val_36 = this.不且丑下上丌丟三丗;
                val_36.Add(item:  val_23.GetComponent<PGCompany.FreePlay.Squad.PlayerUi>());
                val_20 = val_20 - 1;
            }
            while(val_20 != 0);
            
            }
            
            val_24 = this._playerListScrollView;
            val_24.ResetPosition();
        }
        private void 丘丈丄下万专丟世丒(string 丈与丆丆下丅丈丙丙)
        {
            this.<丕丅三丒丗上丗丏上>k__BackingField.丞七丝丟三与万业丗(丄丒且丙三丆丟与丏:  丈与丆丆下丅丈丙丙);
        }
        public SquadUi()
        {
        
        }
        private void 丗丛丏丁且一万三万()
        {
            if(this.LeaveSquadClicked != null)
            {
                    this.LeaveSquadClicked.Invoke();
            }
            
            this._leaveSquadDialog.CloseWindow();
        }
    
    }

}
