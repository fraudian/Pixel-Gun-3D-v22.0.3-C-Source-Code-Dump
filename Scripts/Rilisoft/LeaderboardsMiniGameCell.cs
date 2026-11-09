using UnityEngine;

namespace Rilisoft
{
    internal class LeaderboardsMiniGameCell : MonoBehaviour
    {
        // Fields
        private Rilisoft.七丕丟丏三丈一丄世 下丁上丟业一三丒东;
        private bool 丄丟丘丌丘丆万丟丕;
        private System.Action<Rilisoft.LeaderboardsMiniGameCell> 丞上一丗上丈下万丝;
        private Rilisoft.LeaderboardsMiniGameDataRow <丅不丙丌丟业一业丂>k__BackingField;
        private UnityEngine.GameObject _firstPlaceObj;
        private UnityEngine.GameObject _secondPlaceObj;
        private UnityEngine.GameObject _thirdPlaceObj;
        private UnityEngine.GameObject _selfPlayerHighlighterObj;
        private UnityEngine.GameObject _placeObj;
        private UILabel _placeLabel;
        private UILabel _playerNameLabel;
        private UILabel _ratingLabel;
        private UISprite _gameModeIcon;
        
        // Properties
        public Rilisoft.LeaderboardsMiniGameDataRow 丞丑且东丌与丏丏丁 { get; set; }
        
        // Methods
        public Rilisoft.LeaderboardsMiniGameDataRow get_Data()
        {
            return (Rilisoft.LeaderboardsMiniGameDataRow)this.<丅不丙丌丟业一业丂>k__BackingField;
        }
        private void 丏丝丈丗丄丛丐万丆(Rilisoft.LeaderboardsMiniGameDataRow 丙业与丙丗丝不丈东)
        {
            this.<丅不丙丌丟业一业丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void SetData(Rilisoft.LeaderboardsMiniGameDataRow 一丐丗丁丞丆丅丟丄, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, bool 丏丒丒丘丑丂业丅丕, System.Action<Rilisoft.LeaderboardsMiniGameCell> 丙上专丛上丛一业丙)
        {
            int val_10;
            string val_11;
            bool val_1 = 丏丒丒丘丑丂业丅丕;
            this.丞上一丗上丈下万丝 = 丙上专丛上丛一业丙;
            this.<丅不丙丌丟业一业丂>k__BackingField = 一丐丗丁丞丆丅丟丄;
            this.下丁上丟业一三丒东 = 上且丗一丏丏万丅丌;
            this.丄丟丘丌丘丆万丟丕 = val_1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selfPlayerHighlighterObj, 丏业丟一东丂东丘丛:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstPlaceObj, 丏业丟一东丂东丘丛:  ((this.<丅不丙丌丟业一业丂>k__BackingField.Rank) == 1) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._secondPlaceObj, 丏业丟一东丂东丘丛:  ((this.<丅不丙丌丟业一业丂>k__BackingField.Rank) == 2) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._thirdPlaceObj, 丏业丟一东丂东丘丛:  ((this.<丅不丙丌丟业一业丂>k__BackingField.Rank) == 3) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._placeObj, 丏业丟一东丂东丘丛:  ((this.<丅不丙丌丟业一业丂>k__BackingField.Rank) > 3) ? 1 : 0);
            this._placeLabel.text = this.<丅不丙丌丟业一业丂>k__BackingField.Rank.ToString();
            this._playerNameLabel.text = this.<丅不丙丌丟业一业丂>k__BackingField.PlayerName;
            val_10 = System.String.alignConst;
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Scores) < 1)
            {
                goto label_12;
            }
            
            Rilisoft.七丕丟丏三丈一丄世 val_12 = this.下丁上丟业一三丒东;
            if(val_12 <= 3)
            {
                goto label_13;
            }
            
            if(val_12 > 38)
            {
                goto label_22;
            }
            
            var val_11 = val_12;
            var val_10 = 1;
            val_10 = val_10 << val_11;
            val_10 = val_10 & 3794301440;
            if(val_10 != 0)
            {
                goto label_15;
            }
            
            val_11 = 1 << val_11;
            val_11 = val_11 & 274886296576;
            if(val_11 == 0)
            {
                goto label_22;
            }
            
            val_10 = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  this.<丅不丙丌丟业一业丂>k__BackingField.Scores);
            goto label_26;
            label_12:
            val_10 = "---";
            goto label_26;
            label_13:
            val_12 = val_12 | 2;
            if(val_12 != 3)
            {
                goto label_22;
            }
            
            label_15:
            val_10 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅不丙丌丟业一业丂>k__BackingField.Scores);
            goto label_26;
            label_22:
            object[] val_9 = new object[1];
            val_9[0] = this.下丁上丟业一三丒东;
            UnityEngine.Debug.LogErrorFormat(format:  "fail set scores format, unknown GameMode: \'{0}\'", args:  val_9);
            label_26:
            this._ratingLabel.text = val_10;
            if(this.下丁上丟业一三丒东 <= 12)
            {
                goto label_34;
            }
            
            if(this.下丁上丟业一三丒东 == 13)
            {
                goto label_35;
            }
            
            if(this.下丁上丟业一三丒东 != 23)
            {
                    if(this.下丁上丟业一三丒东 != 38)
            {
                goto label_37;
            }
            
            }
            
            label_40:
            val_11 = "leaderboard_time";
            goto label_42;
            label_34:
            if(this.下丁上丟业一三丒东 == 9)
            {
                goto label_39;
            }
            
            if(this.下丁上丟业一三丒东 == 10)
            {
                goto label_40;
            }
            
            label_37:
            val_11 = "leaderboard_score";
            goto label_42;
            label_35:
            val_11 = "leaderboard_distance";
            goto label_42;
            label_39:
            val_11 = "leaderboard_like";
            label_42:
            this._gameModeIcon.spriteName = val_11;
        }
        private void OnClick()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.丞上一丗上丈下万丝 == null)
            {
                    return;
            }
            
            this.丞上一丗上丈下万丝.Invoke(obj:  this);
        }
        public LeaderboardsMiniGameCell()
        {
        
        }
    
    }

}
