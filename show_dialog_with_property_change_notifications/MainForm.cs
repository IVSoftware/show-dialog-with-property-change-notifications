using System;
using System.Windows.Forms;
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.showdialog?view=windowsdesktop-6.0

namespace show_dialog_with_property_change_notifications
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowForm2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                using (var form2 = new Form2())
                {
                    form2.PropertyChanged += (sender, e) =>
                    {
                        switch (e.PropertyName)
                        {
                            case nameof(form2.BindableText):
                                label1.Text = form2.BindableText;
                                break;
                            case nameof(form2.Visible):
                                checkBoxShowForm2.Checked = form2.Visible;
                                checkBoxShowForm2.Enabled = !form2.Visible;
                                break;
                        }
                    };
                    form2.ShowDialog(owner: this);
                }
            }
        }
    }
}
