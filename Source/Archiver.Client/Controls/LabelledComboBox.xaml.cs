using System.Windows;
using System.Windows.Controls;

namespace Archiver.Client
{
    public partial class LabelledComboBox : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(LabelledComboBox),
                new FrameworkPropertyMetadata("Label"));

        public static readonly DependencyProperty IsEditableProperty =
            DependencyProperty.Register("IsEditable", typeof(bool), 
                typeof(LabelledComboBox), new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(LabelledComboBox),
                new FrameworkPropertyMetadata("",
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public LabelledComboBox()
        {
            InitializeComponent();

            root.DataContext = this;
        }

        public bool IsEditable
        {
            get
            {
                return (bool)GetValue(IsEditableProperty);
            }
            set
            {
                SetValue(IsEditableProperty, value);
            }
        }

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }
        }

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
    }
}
