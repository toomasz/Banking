using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLearn.Controls
{
    [ContentProperty("CenteredContent")]
    public class CenteringControl : Control
    {
        static CenteringControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CenteringControl), new FrameworkPropertyMetadata(typeof(CenteringControl)));
        }


        public object CenteredContent
        {
            get { return (object)GetValue(CenteredContentProperty); }
            set { SetValue(CenteredContentProperty, value); }
        }

        public static readonly DependencyProperty CenteredContentProperty =
            DependencyProperty.Register("CenteredContent", typeof(object), typeof(CenteringControl),  new UIPropertyMetadata(null));

        
    }
}
