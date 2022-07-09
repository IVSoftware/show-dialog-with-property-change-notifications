using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace show_dialog_with_property_change_notifications
{
    public partial class Form2 : Form, INotifyPropertyChanged
    {
        public Form2() => InitializeComponent();
        private void buttonChangeText_Click(object sender, EventArgs e) =>
            BindableText = $"Clicks = {_count++}";
        static int _count = 1;

        string _BindableText = string.Empty;
        public string BindableText
        {
            get => _BindableText;
            set
            {
                if(!Equals(_BindableText, value))
                {
                    _BindableText = value;
                    OnPropertyChanged();
                }
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            if (Visible && (Owner != null))
            {
                Location = new Point(
                    Owner.Location.X + Owner.Width + 10,
                    Owner.Location.Y
                );
            }
            OnPropertyChanged(nameof(Visible));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
