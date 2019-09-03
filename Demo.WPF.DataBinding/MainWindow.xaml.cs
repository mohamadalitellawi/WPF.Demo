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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo.WPF.DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public string AuthorName
        {
            get { return (string)GetValue(AuthorNameProperty); }
            set { SetValue(AuthorNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AuthorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AuthorNameProperty =
            DependencyProperty.Register("AuthorName", typeof(string), typeof(MainWindow), new PropertyMetadata("Mohamad Ali"));



        public string BookName
        {
            get { return (string)GetValue(BookNameProperty); }
            set { SetValue(BookNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BookName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookNameProperty =
            DependencyProperty.Register("BookName", typeof(string), typeof(MainWindow), new PropertyMetadata("Visual Studio"));



        public string PublishDate
        {
            get { return (string)GetValue(PublishDateProperty); }
            set { SetValue(PublishDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PublishDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PublishDateProperty =
            DependencyProperty.Register("PublishDate", typeof(string), typeof(MainWindow), new PropertyMetadata("2019"));




    }
}
