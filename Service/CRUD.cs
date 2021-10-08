/// <summary>
/// Used to perform CRUD in Memory 
/// </summary>
public static class CRUD
{
    public static int Max { get; set; } = 10; //Allowed Size Of item
    public static bool StateHasChanged { get; set; }
    private static int PrevIndex { get; set; } = -1;
    public static void Create<T>(this List<T>? Items) where T : class, Validation, new()
    {
        if (Items?.Count is 0)
        {
            Items.Add(new());
            return;
        }
        if (Items?.Count < Max)
        {
            var last = Items[Items.Count - 1];
            if (last.IsVailid())
                Items.Add(new());
        }
    }
    public static void Set<T>(this List<T>? items, T item) => items![items.Count - 1] = item;
    public static void StartEdit<T>(this List<T>? Items, int Index) where T : class, ICloneable, new()
    {
        T item = (T)Items![Index].Clone();
        if (StateHasChanged)
        {
            return;
        }
        else
        {
            StateHasChanged = true;
            Items?.Add(item); //Clone
            PrevIndex = Index; // Save To prev Index
        }
    }
    public static void Cancel<T>(this List<T>? Items)
    {
        if (StateHasChanged) Items.DeleteCloneItem();
    }
    public static void Delete<T>(this List<T>? Items) where T : Validation
    {
        var last = Items![Items.Count - 1];
        if (StateHasChanged)
            if (!last.IsVailid())
            {
                Items?.RemoveAt(PrevIndex);
                Items.DeleteCloneItem();
            }
        // UiUpdate.NotifyStateChanged();
    }
    public static void Save<T>(this List<T>? Items) where T : class, Validation
    {
        if (StateHasChanged)
        {
            var last = Items![Items.Count - 1];
            if (last.IsVailid())
            {
                Items![PrevIndex] = Items[Items.Count - 1];
                Items.DeleteCloneItem();
            }
        }
    }
    private static void DeleteCloneItem<T>(this List<T>? Items)
    {
        Items?.RemoveAt(Items.Count - 1);
        PrevIndex = -1;
        StateHasChanged = false;
    }
}