using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class CircularBuffer<T>
    {
        // Fields
        private int <Capacity>k__BackingField;
        private int <Count>k__BackingField;
        private T[] buffer;
        private int startIdx;
        private int endIdx;
        
        // Properties
        public int Capacity { get; set; }
        public int Count { get; set; }
        public T Item { get; set; }
        
        // Methods
        public int get_Capacity()
        {
            return (int)this;
        }
        private void set_Capacity(int value)
        {
            mem[1152921553771408016] = value;
        }
        public int get_Count()
        {
            return (int)this;
        }
        private void set_Count(int value)
        {
            mem[1152921553771632020] = value;
        }
        public T get_Item(int idx)
        {
            int val_4 = idx;
            int val_1 = W22 + val_4;
            val_4 = val_1 - ((val_1 / this) * this);
            BestHTTP.Extensions.CircularBuffer<T> val_3 = this + (((long)(int)((W22 + idx) - (((W22 + idx) / this) * this))) << 2);
            return 0;
        }
        public void set_Item(int idx, T value)
        {
            int val_4 = idx;
            int val_1 = W23 + val_4;
            val_4 = val_1 - ((val_1 / this) * this);
            BestHTTP.Extensions.CircularBuffer<T> val_3 = this + (((long)(int)((W23 + idx) - (((W23 + idx) / this) * this))) << 2);
            mem2[0] = value;
        }
        public CircularBuffer<T>(int capacity)
        {
            if(this != null)
            {
                
            }
        
        }
        public void Add(T element)
        {
            var val_6;
            int val_6 = element;
            if(!=0)
            {
                goto label_1;
            }
            
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem[1152921553772080040] = val_6;
            if(val_6 == 0)
            {
                goto label_3;
            }
            
            label_1:
            var val_1 = val_6 + 4611686215088320064;
            mem2[0] = val_6;
            int val_2 = val_6 + 1;
            val_6 = val_2 - ((val_2 / this) * this);
            mem[1152921553772080052] = val_6;
            if(val_6 == (__RuntimeMethodHiddenParam + 24 + 192))
            {
                    int val_4 = val_6 + 1;
                val_2 = val_4 / this;
                val_4 = val_4 - (val_2 * this);
                mem[1152921553772080048] = val_4;
            }
            
            int val_5 = System.Math.Min(val1:  1920592785, val2:  1920592784);
            goto __RuntimeMethodHiddenParam + 24 + 192 + 32;
            label_3:
        }
        public void Clear()
        {
            mem[1152921553772192064] = 0;
        }
    
    }

}
