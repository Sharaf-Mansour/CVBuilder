namespace CVBuilder.Models;
public static class CVModel {
  public static CV CV { get; set; } = new ();
   public static List<TabsModel> Tabs { get; set; } = new() { new(CVBuilder.Tabs.Personal) { IsSelected = true}, new(CVBuilder.Tabs.Education) { IsSelected = true },
       new(CVBuilder.Tabs.WorkExprince) { IsSelected = true }, new(CVBuilder.Tabs.OtherWorkExprince) { IsSelected = true }, new(CVBuilder.Tabs.Certifications) { IsSelected = true },
       new(CVBuilder.Tabs.ProfessionalAffeilations) { IsSelected = true }, new(CVBuilder.Tabs.Refernces) { IsSelected = true }, new(CVBuilder.Tabs.CV) { IsSelected = true }};

}