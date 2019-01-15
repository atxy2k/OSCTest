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
using System.Windows.Shapes;
using App;

namespace Ui
{
    /// <summary>
    /// Lógica de interacción para Previsualizacion.xaml
    /// </summary>
    public partial class Previsualizacion : Window
    {
        public Video video { get; set; } = null;
        public Previsualizacion()
        {
            InitializeComponent();
            this.video = Previsualizador.Create().getVideo();
            this.Image.Source = new BitmapImage(new Uri(@"Images/"+this.video.Number+".jpg", UriKind.RelativeOrAbsolute));
            this.Titulo.Content = this.video.Name;
            this.VideoContent.Text = this.video.Description;
        }
    }
}
