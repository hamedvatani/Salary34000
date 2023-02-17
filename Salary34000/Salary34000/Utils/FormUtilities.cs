namespace Salary34000.Utils;

public static class FormUtilities
{
    public static void LoadForm(this Form form, object obj)
    {
        var controls = form.GetAllControls();
        var textBoxes = controls.Where(c => c is TextBox).ToList();
        foreach (var textBox in textBoxes)
        {
            if (textBox.Name.StartsWith("txt") && textBox.Name.Length > 3)
            {
                var propertyName = textBox.Name.Substring(3);
                textBox.Text = obj.GetType().GetProperty(propertyName)?.GetValue(obj)?.ToString();
            }
        }
    }

    private static List<Control> GetAllControls(this Form form)
    {
        List<Control> retVal = new List<Control>();
        foreach (Control control in form.Controls)
            retVal.AddRange(control.GetAllControls());
        return retVal;
    }

    private static List<Control> GetAllControls(this Control control)
    {
        List<Control> retVal = new List<Control> { control };
        foreach (Control childControl in control.Controls)
            retVal.AddRange(childControl.GetAllControls());
        return retVal;
    }
}