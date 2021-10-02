public static class UiUpdate
{
    public static event Action? OnChange;
    public  static void NotifyStateChanged() => OnChange?.Invoke();
}
