// Sealed means == Class ला कोणीही Inherit करू शकत नाही...त्यापासून दुसरा Class तयार (Inherit) करता येत नाही.


class SinglyList
{
    public virtual void Add()
    {
        Console.WriteLine("Add Node");
    }
}

class StringSinglyList : SinglyList
{
    public override void Add()
    {
        Console.WriteLine("Add String Node");
    }
}