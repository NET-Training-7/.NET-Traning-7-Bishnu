public class A
{
    // Members: Methods, Fields
    public int x;
    public void Do()
    {        
    }
}

public class B : A         // Single-inheritance: A->B
{    
    public int y;
}

class C: B                  // Multi-level: A->B->C
{
    public int z;
}

interface ID
{
    public void T();
}

class E: A, ID              // Multiple inheritance
{
    public void T()
    {

    }
}

class Test123
{
    void Test1()
    {
        B b = new();
        A a = new();
    }
}
