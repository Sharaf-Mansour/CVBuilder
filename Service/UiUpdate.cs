namespace CVBuilder;
public static class UiUpdate
{
    public static event Action? OnChange;
    public static void NotifyStateChanged() => OnChange?.Invoke();
    public static Tabs SelectedTab { get; set; } = Tabs.HomePage;
    public static int SelectedTabIndex { get; set; } = 0;
}