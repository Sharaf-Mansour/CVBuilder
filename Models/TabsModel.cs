namespace CVBuilder.Models;
public partial record TabsModel(Tabs Tab, bool IsSelected = true)
{
    public bool IsSelected { get; set; } = IsSelected;
    internal string TabName => MyReg().Replace(Tab.ToString(), " $0");
    [GeneratedRegex(@"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))")]
    private static partial Regex MyReg();
}