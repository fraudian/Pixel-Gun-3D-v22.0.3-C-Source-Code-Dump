using UnityEngine;

namespace Rilisoft
{
    internal class BasicGrid : MonoBehaviour
    {
        // Fields
        private int _cellWidth;
        private int _cellHeight;
        private int _maxHoirizontalCells;
        private int _maxVerticalCells;
        private bool _verticalPriority;
        private bool _invert;
        
        // Properties
        public int 丑不世与丈丑丝万下 { get; set; }
        public int 丕丙丛丅丟一七一丗 { get; set; }
        public int 丝与丗丐东丝丄专丄 { get; set; }
        public int 且东丁丝丐丘万一丌 { get; set; }
        public bool 丂丅丏七丞丂一上丏 { get; set; }
        public bool 丂东丁丌下丝丈丟丌 { get; set; }
        
        // Methods
        public int get_CellWidth()
        {
            return (int)this._cellWidth;
        }
        public void set_CellWidth(int 丙业与丙丗丝不丈东)
        {
            if(this._cellWidth == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this._cellWidth = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public int get_CellHeight()
        {
            return (int)this._cellHeight;
        }
        public void set_CellHeight(int 丙业与丙丗丝不丈东)
        {
            if(this._cellHeight == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this._cellHeight = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public int get_MaxVerticalCells()
        {
            return (int)this._maxVerticalCells;
        }
        public void set_MaxVerticalCells(int 丙业与丙丗丝不丈东)
        {
            if(this._maxVerticalCells == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this._maxVerticalCells = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public int get_MaxHoirizontalCells()
        {
            return (int)this._maxHoirizontalCells;
        }
        public void set_MaxHoirizontalCells(int 丙业与丙丗丝不丈东)
        {
            if(this._maxHoirizontalCells == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this._maxHoirizontalCells = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public bool get_VerticalPriority()
        {
            return (bool)this._verticalPriority;
        }
        public void set_VerticalPriority(bool 丙业与丙丗丝不丈东)
        {
            var val_1 = (this._verticalPriority == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            this._verticalPriority = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public bool get_Invert()
        {
            return (bool)this._invert;
        }
        public void set_Invert(bool 丙业与丙丗丝不丈东)
        {
            var val_1 = (this._invert == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            this._invert = 丙业与丙丗丝不丈东;
            this.UpdatePositions();
        }
        public void UpdatePositions()
        {
            var val_13;
            var val_14;
            int val_15;
            var val_16;
            val_13 = 0;
            val_14 = 0;
            goto label_0;
            label_13:
            UnityEngine.Transform val_2 = this.transform.GetChild(index:  0);
            if(this._verticalPriority == false)
            {
                goto label_2;
            }
            
            val_15 = this._maxVerticalCells;
            if(0 >= val_15)
            {
                goto label_3;
            }
            
            val_16 = 1;
            goto label_7;
            label_2:
            val_15 = this._maxHoirizontalCells;
            if(val_14 >= val_15)
            {
                goto label_5;
            }
            
            val_14 = 1;
            goto label_7;
            label_3:
            val_14 = 1;
            val_16 = 1;
            goto label_7;
            label_5:
            val_16 = 1;
            val_14 = 1;
            label_7:
            var val_13 = -((this._verticalPriority == true) ? this._cellHeight : 0);
            val_13 = val_13 + (this._cellHeight * val_16);
            int val_5 = (-((this._verticalPriority == true) ? 0 : this._cellWidth)) + (this._cellWidth * val_14);
            var val_6 = (this._invert == true) ? (-val_13) : (val_13);
            var val_7 = (this._invert == true) ? (-val_5) : (val_5);
            UnityEngine.Vector3 val_9 = val_2.transform.localPosition;
            val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_13 = 1;
            label_0:
            if(val_13 < this.transform.childCount)
            {
                goto label_13;
            }
        
        }
        public BasicGrid()
        {
            this._verticalPriority = true;
            this._cellWidth = ;
            this._cellHeight = ;
            this._maxHoirizontalCells = 12884901889;
            this._maxVerticalCells = 3;
        }
    
    }

}
