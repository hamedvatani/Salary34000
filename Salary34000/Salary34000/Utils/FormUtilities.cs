using System.Collections;
using System.ComponentModel;

namespace Salary34000.Utils;

public static class FormUtilities
{
    public static void LoadForm(this Form form, object obj)
    {
        var controls = form.GetAllControls();
        
        var textBoxes = controls.Where(c => c is TextBox).Cast<TextBox>().ToList();
        foreach (var textBox in textBoxes)
        {
            if (textBox.Name.StartsWith("txt") && textBox.Name.Length > 3)
            {
                var propertyName = textBox.Name.Substring(3);
                textBox.Text = obj.GetType().GetProperty(propertyName)?.GetValue(obj)?.ToString();
            }
        }

        var comboBoxes = controls.Where(c => c is ComboBox).Cast<ComboBox>().ToList();
        foreach (var comboBox in comboBoxes)
        {
            if (comboBox.Name.StartsWith("cmb") && comboBox.Name.Length > 3)
            {
                var propertyName = comboBox.Name.Substring(3);
                var propertyInfo = obj.GetType().GetProperty(propertyName);
                var objValue = obj.GetType().GetProperty(propertyName)?.GetValue(obj);
                if (propertyInfo != null && propertyInfo.PropertyType.IsEnum)
                {
                    var values = Enum.GetValues(propertyInfo.PropertyType);
                    comboBox.Items.Clear();
                    foreach (var value in values)
                        comboBox.Items.Add(value);

                    if (objValue != null)
                        comboBox.SelectedIndex = comboBox.Items.IndexOf(objValue);
                }
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

    public static ArrayList GetComboItems(this Type enumType)
    {
        var enumValuesAndDescriptions = new ArrayList();
        foreach (var e in Enum.GetValues(enumType))
        {
            enumValuesAndDescriptions.Add(new
            {
                EnumValue = e,
                EnumDescription = (e.GetType().GetMember(e.ToString()).FirstOrDefault()
                        .GetCustomAttributes(typeof(DescriptionAttribute), inherit: false).FirstOrDefault()
                    as DescriptionAttribute)?.Description ?? e.ToString() //defaults to enum name if no description
            });
        }

        return enumValuesAndDescriptions;
    }
}