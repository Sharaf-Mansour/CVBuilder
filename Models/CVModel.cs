namespace CVBuilder.Models;
public static class CVModel {
  public static CV CV { get; set; } = new ();
   public static List<TabsModel> ListOfTabs { get; set; } = new() {new(Tabs.HomePage) { IsSelected = true }, new(Tabs.Personal) { IsSelected = true}, new(Tabs.Education) { IsSelected = true },
       new(Tabs.WorkExprince) { IsSelected = true }, new(Tabs.OtherWorkExprince) { IsSelected = true }, new(Tabs.Certifications) { IsSelected = true },
       new(Tabs.ProfessionalAffeilations) { IsSelected = true }, new(Tabs.Refernces) { IsSelected = true }, new(Tabs.CV) { IsSelected = true }};
}