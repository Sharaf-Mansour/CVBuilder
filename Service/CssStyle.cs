namespace CVBuilder;
public class CustomFieldClassProvider : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        => !editContext.GetValidationMessages(fieldIdentifier).Any()
            ? editContext.IsModified(fieldIdentifier) 
            ? "is-valid" : "needs-validation" : "is-invalid";
}