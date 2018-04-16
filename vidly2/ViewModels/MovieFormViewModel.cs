using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly2.Models;

namespace vidly2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genres> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}