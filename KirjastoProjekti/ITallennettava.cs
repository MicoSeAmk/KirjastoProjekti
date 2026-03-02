using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public interface ITallennettava
    {
        void Tallenna(string polku);
        void Lataa(string polku);
    }
}