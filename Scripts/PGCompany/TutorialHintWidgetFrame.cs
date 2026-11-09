using UnityEngine;

namespace PGCompany
{
    public sealed class TutorialHintWidgetFrame : PGBehaviour
    {
        // Fields
        private UIWidget _frameWidget;
        private UnityEngine.GameObject _leftSideArrow;
        private UnityEngine.GameObject _rightSideArrow;
        private UnityEngine.GameObject _upSideArrow;
        private UnityEngine.GameObject _downSideArrow;
        private UnityEngine.GameObject _leftSideArrowContainerForMoving;
        private UnityEngine.GameObject _rightSideArrowContainerForMoving;
        private UnityEngine.GameObject _upSideArrowContainerForMoving;
        private UnityEngine.GameObject _downSideArrowContainerForMoving;
        private string 丅七丁丐丑丐三上下;
        private PGCompany.丟丈丛丅一业丙与丘 七丏丗丟一七丙三丛;
        private UIWidget 一东丈丒丏专世三丛;
        
        // Properties
        public string 不丌七丆丏丂丐万丂 { get; }
        public PGCompany.丟丈丛丅一业丙与丘 且丆业丘专三丌丘丟 { get; }
        
        // Methods
        public string get_UniqueId()
        {
            return (string)this.丅七丁丐丑丐三上下;
        }
        public PGCompany.丟丈丛丅一业丙与丘 get_ArrowPosition()
        {
            return (PGCompany.丟丈丛丅一业丙与丘)this.七丏丗丟一七丙三丛;
        }
        internal void 丈且东丑丂且万丒丅(UIWidget 专丘丏一不丏丘丁丒, string 与一七丘丏与万丒七)
        {
            this.丅七丁丐丑丐三上下 = 与一七丘丏与万丒七;
            this.一东丈丒丏专世三丛 = 专丘丏一不丏丘丁丒;
            this.丅不丞且业丝且丄世(专丘丏一不丏丘丁丒:  专丘丏一不丏丘丁丒);
            this.下万不世丏丈丈万丅();
        }
        private void 下万不世丏丈丈万丅()
        {
            PGCompany.丟丈丛丅一业丙与丘 val_5;
            PGCompany.TutorialHintUiSettings val_1 = this.丙丛丈丝三不丕丂上();
            if(val_1 != 0)
            {
                    val_5 = val_1.arrowPosition;
            }
            else
            {
                    val_5 = 0;
            }
            
            this.ShowArrow(丞丐丟丈丝上丗东丁:  val_5);
            if(val_1 != 0)
            {
                    if(val_1 != null)
            {
                goto label_10;
            }
            
            }
            else
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            }
            
            label_10:
            this.丆且丕不丅丕三上丗(与业丂丞一丙与丏东:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        }
        private void 丅不丞且业丝且丄世(UIWidget 专丘丏一不丏丘丁丒)
        {
            if(专丘丏一不丏丘丁丒 == 0)
            {
                    return;
            }
            
            this._frameWidget.width = 专丘丏一不丏丘丁丒.width;
            this._frameWidget.height = 专丘丏一不丏丘丁丒.height;
            UnityEngine.Vector3 val_6 = 不丌丂丁丄一与丆丙.与下丆丒下丝世丝丂(东丒不丘东丐丂丅业:  专丘丏一不丏丘丁丒.transform);
            this._frameWidget.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private void 丅不丞且业丝且丄世()
        {
            this.丅不丞且业丝且丄世(专丘丏一不丏丘丁丒:  this.一东丈丒丏专世三丛);
        }
        private PGCompany.TutorialHintUiSettings 丙丛丈丝三不丕丂上()
        {
            null = null;
            return UnityEngine.Resources.Load<PGCompany.TutorialHintUiSettings>(path:  System.IO.Path.Combine(path1:  PGCompany.丈丌上丑丌上丅七东.且专三丁丐世丞丅丕, path2:  "SO", path3:  this.丅七丁丐丑丐三上下));
        }
        public void ShowArrow(PGCompany.丟丈丛丅一业丙与丘 丞丐丟丈丝上丗东丁)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftSideArrow, 丏业丟一东丂东丘丛:  (丞丐丟丈丝上丗东丁 == 4) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightSideArrow, 丏业丟一东丂东丘丛:  (丞丐丟丈丝上丗东丁 == 3) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upSideArrow, 丏业丟一东丂东丘丛:  (丞丐丟丈丝上丗东丁 == 1) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._downSideArrow, 丏业丟一东丂东丘丛:  (丞丐丟丈丝上丗东丁 == 2) ? 1 : 0);
            this.七丏丗丟一七丙三丛 = 丞丐丟丈丝上丗东丁;
        }
        private void 丆且丕不丅丕三上丗(UnityEngine.Vector2 与业丂丞一丙与丏东)
        {
            PGCompany.丟丈丛丅一业丙与丘 val_3 = this.七丏丗丟一七丙三丛;
            val_3 = val_3 - 1;
            if(val_3 > 3)
            {
                    return;
            }
            
            var val_4 = 106046324 + ((this.七丏丗丟一七丙三丛 - 1)) << 2;
            val_4 = val_4 + 106046324;
            goto (106046324 + ((this.七丏丗丟一七丙三丛 - 1)) << 2 + 106046324);
        }
        private void Update()
        {
            if(this.一东丈丒丏专世三丛 == 0)
            {
                    return;
            }
            
            if(this._frameWidget.width == this.一东丈丒丏专世三丛.width)
            {
                    if(this._frameWidget.height == this.一东丈丒丏专世三丛.height)
            {
                    return;
            }
            
            }
            
            this.丅不丞且业丝且丄世(专丘丏一不丏丘丁丒:  this.一东丈丒丏专世三丛);
            this.下万不世丏丈丈万丅();
        }
        public TutorialHintWidgetFrame()
        {
        
        }
    
    }

}
