﻿
namespace PdC_04_Iterator
{
    public abstract class IteratorEjemplo
    {
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}