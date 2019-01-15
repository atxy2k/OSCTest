using App;
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

namespace Ui
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected string DireccionIp { get; set; } = "192.168.0.1";
        protected List<Video> Videos = new List<Video> {
            new Video{ Name = "Efecto invernadero y calentamiento global", Number = 1, Description= "Ningún hombre tiene una memoria lo suficientemente buena para ser un mentiroso exitoso. – Abraham Lincoln" },
            new Video{ Name = "Precipitaciones", Number = 2, Description= "Cada strike me acerca más al siguiente home run. – Babe Ruth" },
            new Video{ Name = "Terremotos", Number = 3, Description= "Todos nuestros sueños se pueden hacer realidad si tenemos el coraje de perseguirlos. – Walt Disney." },
            new Video{ Name = "Incendios", Number = 4, Description= "La valentía no siempre ruge. A veces, es la vocecita al final del día que dice: mañana lo volveré a intentar.  – Mary Anne Radmacher" },
            new Video{ Name = "Camino del carbón", Number = 5, Description= "Un viaje se mide mejor en amigos que en millas. –  Tim Cahill" },
            new Video{ Name = "Vegetación", Number = 6, Description= "Si piensas que la aventura es peligrosa, prueba la rutina. Es mortal.- Pablo Coelho" },
            new Video{ Name = "Track 7", Number = 7, Description= "El gran placer de la vida es hacer lo que la gente dice que no puedes.  – Walter Bagehot" },
            new Video{ Name = "Track 8", Number = 8, Description= "El éxito es caer siete veces y levantarte ocho. –  Proverbio japonés" },
            new Video{ Name = "Track 9", Number = 9, Description= "Un viajero sin capacidad de observación es como un pájaro sin alas. – Moslih Eddin Saadi" },
            new Video{ Name = "Track 10", Number = 10, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 11", Number = 11, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 12", Number = 12, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 13", Number = 13, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 14", Number = 14, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 15", Number = 15, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 16", Number = 16, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 17", Number = 17, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 18", Number = 18, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 19", Number = 19, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 20", Number = 20, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 21", Number = 21, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 22", Number = 22, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 23", Number = 23, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 24", Number = 24, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 25", Number = 25, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
            new Video{ Name = "Track 26", Number = 26, Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet sem justo. Suspendisse euismod est quis lectus feugiat malesuada. Suspendisse feugiat, est sit amet venenatis aliquet, tellus ex consectetur magna, eu auctor enim libero blandit neque. Aliquam molestie justo leo, tristique viverra purus pretium vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt massa nec magna lacinia, in commodo dolor molestie. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer eros velit, egestas non leo eu, scelerisque volutpat erat. In vitae enim purus. Sed nulla odio, rutrum eleifend vehicula id, laoreet in orci. Sed purus mauris, convallis egestas dolor in, malesuada fringilla justo. Curabitur id pretium velit. Curabitur id mauris libero. Nulla facilisi.\r\n Morbi ac ante ultricies, pulvinar est ut, maximus nulla. Nulla commodo molestie enim vitae dapibus. Sed imperdiet, lectus ac pellentesque faucibus, ex magna suscipit est, eu tincidunt lacus erat et odio. Quisque metus purus, finibus a elit sed, consequat cursus metus. Maecenas commodo arcu eget arcu pellentesque, gravida ornare nibh consequat. Vestibulum sollicitudin mollis ligula, nec auctor velit convallis in. Aenean eget eleifend lorem. Maecenas vitae nunc velit. Suspendisse ac nisl lacus." },
        };

        public MainWindow()
        {
            InitializeComponent();
            Previsualizador.Create().onVideoChanged += (sender, video) =>
            {
                Previsualizacion p = new Previsualizacion();
                p.ShowDialog();
            };
        }

        private void sendMessage(int number)
        {
            var message = new SharpOSC.OscMessage("/mxw/set", (number) + 1, 42.01f, "hello world");
            var sender = new SharpOSC.UDPSender(this.DireccionIp, 7000);
            Video video = this.Videos.First( item => item.Number == number );
            if (video != null)
                Previsualizador.Create().setVideo(video);
            sender.Send(message);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if( sender == btn1 )
            {
                this.sendMessage(1);
            }
            else if( sender == btn2 )
            {
                this.sendMessage(2);
            }
            else if (sender == btn3)
            {
                this.sendMessage(3);
            }
            else if (sender == btn4)
            {
                this.sendMessage(4);
            }
            else if (sender == btn5)
            {
                this.sendMessage(5);
            }
            else if (sender == btn6)
            {
                this.sendMessage(6);
            }
            else if (sender == btn7)
            {
                this.sendMessage(7);
            }
            else if (sender == btn8)
            {
                this.sendMessage(8);
            }
            else if (sender == btn9)
            {
                this.sendMessage(9);
            }
            else if (sender == btn10)
            {
                this.sendMessage(10);
            }
            else if (sender == btn11)
            {
                this.sendMessage(11);
            }
            else if (sender == btn12)
            {
                this.sendMessage(12);
            }
            else if (sender == btn13)
            {
                this.sendMessage(13);
            }
            else if (sender == btn14)
            {
                this.sendMessage(14);
            }
            else if (sender == btn15)
            {
                this.sendMessage(15);
            }
            else if (sender == btn16)
            {
                this.sendMessage(16);
            }
            else if (sender == btn17)
            {
                this.sendMessage(17);
            }
            else if (sender == btn18)
            {
                this.sendMessage(18);
            }
            else if (sender == btn19)
            {
                this.sendMessage(19);
            }
            else if (sender == btn20)
            {
                this.sendMessage(20);
            }
            else if (sender == btn21)
            {
                this.sendMessage(21);
            }
            else if (sender == btn22)
            {
                this.sendMessage(22);
            }
            else if (sender == btn23)
            {
                this.sendMessage(23);
            }
            else if (sender == btn24)
            {
                this.sendMessage(24); 
            }
            else if (sender == btn25)
            {
                this.sendMessage(25);
            }
        }
    }
}
