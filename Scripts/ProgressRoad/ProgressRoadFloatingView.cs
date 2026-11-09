using UnityEngine;

namespace ProgressRoad
{
    internal class ProgressRoadFloatingView : PGBehaviour
    {
        // Fields
        private PGCompany.UI.FloatingWidget _body;
        private UILabel _levelLabel;
        private UILabel _levelDescription;
        private ItemListUI _itemListUi;
        private int maxItemCount;
        private ProgressRoad.丅丂丅丕下丑丘万一 丘三丌丐丒丒七丑东;
        private SimpleTweenePlayer animationOnSetup;
        
        // Properties
        public ProgressRoad.丅丂丅丕下丑丘万一 丙丒丈不丆下世东业 { get; }
        
        // Methods
        public ProgressRoad.丅丂丅丕下丑丘万一 get_PointData()
        {
            return (ProgressRoad.丅丂丅丕下丑丘万一)this.丘三丌丐丒丒七丑东;
        }
        private void OnEnable()
        {
            this.丏不丘丐丆丙丟丁专();
        }
        internal void 上丒三丅世丁丒丒丙(UIPanel 丁丑下且丛丙丏丂下, UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            this._body.丈且东丑丂且万丒丅(丐丐丒万不丛丐专专:  丆丏七丟不丒与七专, 丁丑下且丛丙丏丂下:  丁丑下且丛丙丏丂下);
        }
        internal void 丈且东丑丂且万丒丅(UIPanel 丁丑下且丛丙丏丂下, UnityEngine.Transform 丆丏七丟不丒与七专, ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
        {
            if(this.丘三丌丐丒丒七丑东 == 东东丗丅与一下丄丈)
            {
                    return;
            }
            
            this.上丒三丅世丁丒丒丙(丁丑下且丛丙丏丂下:  丁丑下且丛丙丏丂下, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专);
            if(this.丘三丌丐丒丒七丑东 != 东东丗丅与一下丄丈)
            {
                    this.丘三丌丐丒丒七丑东 = 东东丗丅与一下丄丈;
                this.丝一丅丆三东丂丞七();
            }
            else
            {
                    if(东东丗丅与一下丄丈 == null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丆丏七丟不丒与七专.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(this.animationOnSetup == null)
            {
                    return;
            }
            
            this.animationOnSetup.Play();
        }
        private void 丝一丅丆三东丂丞七()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.丘三丌丐丒丒七丑东 != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
                this.丏不丘丐丆丙丟丁专();
                if(this.丘三丌丐丒丒七丑东 == null)
            {
                    return;
            }
            
                if(this.丘三丌丐丒丒七丑东.丁丝丒七一一下不丆.Count < 1)
            {
                    return;
            }
            
                PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
                val_6 = this.丘三丌丐丒丒七丑东.丁丝丒七一一下不丆;
                if(this.丘三丌丐丒丒七丑东.丁丝丒七一一下不丆.Count >= this.maxItemCount)
            {
                    val_6 = System.Linq.Enumerable.Take<PGCompany.三东丏不丗世丅丌丄>(source:  val_6, count:  this.maxItemCount);
            }
            
                val_3.AddRange(collection:  val_6);
                this._itemListUi.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_3);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
        }
        public void U_ShowInfo()
        {
            if((ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                goto label_4;
            }
            
            if((ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.万丝专丌丌三丟丆丄) == false)
            {
                goto label_7;
            }
            
            return;
            label_4:
            UnityEngine.Debug.LogError(message:  "cant show point data, Instance == null");
            return;
            label_7:
            ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.ShowPointInfo(东东丗丅与一下丄丈:  this.丘三丌丐丒丒七丑东);
        }
        private void 丏不丘丐丆丙丟丁专()
        {
            if(this.丘三丌丐丒丒七丑东 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  this.丘三丌丐丒丒七丑东.丘丈不不下丙万丌专));
            this = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11105");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelDescription, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  this, arg0:  this.丘三丌丐丒丒七丑东.丘丈不不下丙万丌专));
        }
        public ProgressRoadFloatingView()
        {
            this.maxItemCount = 3;
        }
    
    }

}
