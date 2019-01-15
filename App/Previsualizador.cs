using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Previsualizador
    {

        public static Previsualizador Instance { get; set; } = null;

        protected Video current { get; set; } = null;
        public event EventHandler<Video> onVideoChanged;
        
        public static Previsualizador Create()
        {
            if (Previsualizador.Instance == null)
                Previsualizador.Instance = new Previsualizador();
            return Previsualizador.Instance;
        }

        public Previsualizador setVideo(Video v)
        {
            this.current = v;
            if(this.onVideoChanged!=null)
                this.onVideoChanged(this, this.current);
            return this;
        }

        public Video getVideo()
        {
            return this.current;
        }

    }
}
