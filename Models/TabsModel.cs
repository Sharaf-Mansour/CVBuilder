namespace CVBuilder.Models;
public class TabsModel
{
    public Tabs Tab { get; set; }
    public bool IsSelected { get; set; }
    internal string TabName => Regex.Replace(Tab.ToString(), @"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))", " $0");
}