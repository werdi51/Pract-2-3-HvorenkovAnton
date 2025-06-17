using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_playlist
{
    public struct Song
    {
        public string Author; //поле автора
        public string Title; //поле названия
        public string Filename; //поле пути файла
    // Переопределение метода ToString для красивого отображения песни
        public override string ToString()
        {
            return $"{Title} {Author}";
        }
    }
}
