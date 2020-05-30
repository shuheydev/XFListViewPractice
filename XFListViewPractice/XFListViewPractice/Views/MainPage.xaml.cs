using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFListViewPractice.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> Items { get; set; } = new List<string>();
        public MainPage()
        {
            InitializeComponent();

            Items.AddRange(new string[] { "hello", "wow", "test" });

            BindingContext = this;
        }
    }
}
