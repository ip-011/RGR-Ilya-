using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RGR_Ilya_.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
