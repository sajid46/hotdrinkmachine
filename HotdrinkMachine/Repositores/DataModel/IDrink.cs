using System.Collections.Generic;
public interface IDrink<T>
{
    List<T> DrinkInProcess { get; set; }
    List<T> PrepareDrink();
}
