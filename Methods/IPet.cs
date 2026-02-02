using System;

namespace AnimalsCS
{
    // Interface IPet
    public interface IPet
    {
        void Play();
        string Name { get; set; }
    }
}
