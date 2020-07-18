using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public WeekDaysList WeekDays { get; set; }
        public string Language { get; set; }

        public IList<State> States { get; set; }
        public int SelectedStateId { get; set; }
        public IList<City> Cities { get; set; }
        public int  SelectedCityId { get; set; }
    }
}