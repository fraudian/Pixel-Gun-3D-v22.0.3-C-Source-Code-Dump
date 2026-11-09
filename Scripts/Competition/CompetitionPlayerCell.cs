using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionPlayerCell : PGBehaviour
    {
        // Fields
        private UIWidget _widget;
        private UILabel _placeLabel;
        private UILabel _nickLabel;
        private UILabel _scoreLabel;
        private UnityEngine.GameObject _defaultPlaceContainer;
        private UnityEngine.GameObject _firstPlaceContainer;
        private UnityEngine.GameObject _secondPlaceContainer;
        private UnityEngine.GameObject _thirdPlaceContainer;
        private UnityEngine.GameObject _defaultContainer;
        private UnityEngine.GameObject _myPlayerContainer;
        internal bool 上世丄不丐丁丟丅丒;
        private string <上七东下丏不丕丐丑>k__BackingField;
        
        // Properties
        internal string 下丄丈不与世丐业专 { get; set; }
        
        // Methods
        internal string 业上丙丞丐丄丆丅七()
        {
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        private void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丝丌且丄不世三业上()
        {
            UIWidget val_3;
            if(this._widget == 0)
            {
                    val_3 = this.GetComponent<UIWidget>();
                this._widget = val_3;
                if(val_3 != null)
            {
                    return val_3.height;
            }
            
                return val_3.height;
            }
            
            val_3 = this._widget;
            if(val_3 != null)
            {
                    return val_3.height;
            }
            
            return val_3.height;
        }
        internal void 丂下不丘丑与业东与(string 不丆业丏上丐与丌业)
        {
            if(this._nickLabel == 0)
            {
                    return;
            }
            
            this._nickLabel.text = 不丆业丏上丐与丌业;
        }
        internal void 丈且东丑丂且万丒丅(int 且丒丛与丞世丙丕丌, string 丞丅上丏丂且下丅与, string 不丆业丏上丐与丌业, int 万且丒下丕丝专丟上)
        {
            string val_9;
            UnityEngine.GameObject val_10;
            val_9 = 不丆业丏上丐与丌业;
            bool val_2 = 丞丅上丏丂且下丅与.Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙());
            this.<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
            this.丆丈万丁丕丘丝丕七(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
            if(this._nickLabel != 0)
            {
                    if(val_2 != false)
            {
                    val_9 = ProfileController.丆三丂丂丆上丆丕专();
            }
            
                this._nickLabel.text = val_9;
            }
            
            if(this._scoreLabel != 0)
            {
                    this._scoreLabel.text = 万且丒下丕丝专丟上.ToString();
            }
            
            val_10 = this._myPlayerContainer;
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10 = this._defaultContainer;
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10 = this._myPlayerContainer;
            if(val_10 == null)
            {
                goto label_21;
            }
            
            if(val_2 == false)
            {
                goto label_22;
            }
            
            label_25:
            val_10.SetActive(value:  true);
            this._defaultContainer.SetActive(value:  false);
            this.上世丄不丐丁丟丅丒 = true;
            return;
            label_21:
            if(val_2 == true)
            {
                goto label_25;
            }
            
            label_22:
            val_10.SetActive(value:  false);
            this._defaultContainer.SetActive(value:  true);
            this.上世丄不丐丁丟丅丒 = false;
        }
        private void 丆丈万丁丕丘丝丕七(int 且丒丛与丞世丙丕丌)
        {
            UILabel val_3;
            var val_4;
            UnityEngine.GameObject val_5;
            val_3 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstPlaceContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._secondPlaceContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._thirdPlaceContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultPlaceContainer, 丏业丟一东丂东丘丛:  false);
            if(且丒丛与丞世丙丕丌 == 3)
            {
                goto label_3;
            }
            
            if(且丒丛与丞世丙丕丌 == 2)
            {
                goto label_4;
            }
            
            if(且丒丛与丞世丙丕丌 != 1)
            {
                goto label_5;
            }
            
            val_4 = null;
            val_5 = this._firstPlaceContainer;
            goto label_11;
            label_3:
            val_4 = null;
            val_5 = this._thirdPlaceContainer;
            goto label_11;
            label_4:
            val_4 = null;
            val_5 = this._secondPlaceContainer;
            label_11:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  true);
            return;
            label_5:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultPlaceContainer, 丏业丟一东丂东丘丛:  true);
            if(this._placeLabel == 0)
            {
                    return;
            }
            
            val_3 = this._placeLabel;
            val_3.text = 且丒丛与丞世丙丕丌.ToString();
        }
        public CompetitionPlayerCell()
        {
        
        }
    
    }

}
