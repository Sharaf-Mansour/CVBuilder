using CVBuilder.Pages;
namespace CVBuilder;
public static class UiUpdate
{
    public static Tabs SelectedTab { get; set; } = Tabs.HomePage;
    public static Dictionary<Tabs, Type> tabTypeDictionary = new()
    {
        { Tabs.HomePage, typeof(CVForm_HomePage) },
        { Tabs.Personal, typeof(CVForm_Personal) },
        { Tabs.Social, typeof(CVForm_Social) },
        { Tabs.Education, typeof(CVForm_Education) },
        { Tabs.WorkExperience, typeof(CVForm_WorkExperience) },
        { Tabs.OtherWorkExperience, typeof(CVForm_OtherWorkExperience) },
        { Tabs.Skills, typeof(CVForm_Skills) },
        { Tabs.Projects, typeof(CVForm_Projects) },
        { Tabs.Certifications, typeof(CVForm_Certifications) },
        { Tabs.ProfessionalAffiliations, typeof(CVForm_ProfessionalAffiliations) },
        { Tabs.HobbiesAndInterests, typeof(CVForm_HobbiesAndInterests) },
        { Tabs.References, typeof(CVForm_References) },
        { Tabs.CV, typeof(CVForm_CV) },
    };
    public static int SelectedTabIndex { get; set; } = 0;
}