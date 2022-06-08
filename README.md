# IyraObject

Allow derived classes to use `self` instead of `this` to access class members. 

```csharp
using Iyra;

class MyType : IyraObject<MyType>
{
    private int _val = 7;
    public int GetVal() => self._val;
}
```
