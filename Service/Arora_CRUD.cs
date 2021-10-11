using static Arora_CRUD.CRUD;
namespace Arora_CRUD;

    public  static class Extantions
    {
        private static int PrevIndex { get; set; } = -1;
        private static object? TItem { get; set; } = new();
        public static bool IsModelValid<T>(this IList<T> Items) where T : IValidation => Items.All(_ => _.IsVailid());
        public static void Create<T>(this IList<T>? Items) where T : IValidation, new()
        {
            if (!StateHasChanged && Items?.Count < Max && Items.IsModelValid())
                Items.Add(new());
        }
        public static void Set<T>(this IList<T>? items, T item) => items![items.Count - 1] = item;
        public static void StartEdit<T>(this IList<T>? Items, int Index) where T : ICloneable, IValidation
        {
            if (!StateHasChanged)
                (TItem, Items![Index].InEditState, StateHasChanged, PrevIndex) = ((T)Items![Index].Clone(), true, true, Index);
        }
        public static void Cancel<T>(this IList<T>? Items)
        {
            if (StateHasChanged)
            {
                Items![PrevIndex] = (T)TItem!;
                (PrevIndex, StateHasChanged, TItem) = (-1, false, new());
            }
        }
        public static void Delete<T>(this IList<T>? Items) where T : IValidation
        {
            if (StateHasChanged && !Items![PrevIndex].IsVailid())
            {
                Items?.RemoveAt(PrevIndex);
                (PrevIndex, StateHasChanged, TItem) = (-1, false, new());
            }
        }
        public static void Save<T>(this IList<T>? Items) where T : IValidation
        {
            if (StateHasChanged && Items![PrevIndex].IsVailid())
                Items![PrevIndex].InEditState = false;
            (PrevIndex, StateHasChanged, TItem) = (-1, false, new());
        }
        public static void MoveUp<T>(this IList<T>? Items, int Index) where T : IValidation
        {
            if (Index > 0 && Items!.IsModelValid())
                Swap(Items, Index, -1);
        }
        public static void MoveDown<T>(this IList<T>? Items, int Index) where T : IValidation
        {
            if (Index < Items!.Count - 1 && Items!.IsModelValid())
                Swap(Items, Index, +1);
        }
        private static void Swap<T>(IList<T>? Items, int Index, int dir)
        {
            T Current = Items![Index];
            Items![Index] = Items![Index + dir];
            Items![Index + dir] = Current;
        }
    }
    public static class CRUD
    {
        public static int Max { get; set; } = 10; //Allowed Size Of item
        public static bool StateHasChanged { get; set; }
    }
    public interface IValidation
    {
    bool InEditState { get; set; }
    bool IsVailid();
    }