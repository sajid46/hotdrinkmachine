using System.Collections.Generic;

namespace HotdrinkMachine.Tests
{
    public interface IDrink<T>
    {
        List<T> DrinkInProcess { get; set; }
        List<T> PrepareDrink();
    }
}
