namespace CVBuilder.Models;
    public class TabsModel
    {
    public Tabs Tab { get; private set; }
    public bool IsSelected { get; set; }
    public string TabName => Regex.Replace(Tab.ToString(), @"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))", " $0");
    public TabsModel(Tabs _Tab)=>  Tab = _Tab;
    }