using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game_Randomizer.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OddFrame : Grid
    {
        public static readonly BindableProperty OddProperty =
BindableProperty.Create("Odd", typeof(double), typeof(OddFrame), null,
         defaultBindingMode: BindingMode.TwoWay);
        public OddFrame()
        {
            InitializeComponent();
        }
        public double Odd
        {
            get { return (double)GetValue(OddProperty); }
            set { SetValue(OddProperty, value); }
        }
    }
}