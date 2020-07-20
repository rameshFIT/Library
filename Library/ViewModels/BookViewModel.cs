using Library.Data.Model;
using Library.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Library.ViewModels
{
    public class BookViewModel
    {
        public string Name { get; set; }

        public string StateName { get; set; }

        public string CityName { get; set; }
        public WeekDaysList WeekDays { get; set; }
        public string Language { get; set; }
        public IList<State> States { get; set; }
        public string SelectedStateId { get; set; }
        public IList<City> Cities { get; set; }
        public string  SelectedCityId { get; set; }
        public string StateID { get; set; }
        public string CityID { get; set; }
        public int StateIdTrack { get; set; }

        public static implicit operator Book(BookViewModel bookViewModel)
        {
            return new Book
            {
                Name = bookViewModel.Name,
                Language = bookViewModel.Language,
                StateID = bookViewModel.StateID,
                CityID = bookViewModel.CityID,
                WeekDays = bookViewModel.WeekDays,
                States = bookViewModel.States,
                Cities = bookViewModel.Cities,
                State = bookViewModel.StateName,
                City = bookViewModel.CityName
                
            };
        }

        public static implicit operator BookViewModel(Book bookModel)
        {
            return new BookViewModel
            {
                Name = bookModel.Name,
                Language = bookModel.Language,
                StateID = bookModel.StateID,
                CityID = bookModel.CityID,
                WeekDays = bookModel.WeekDays,
                States = bookModel.States,
                Cities = bookModel.Cities,
                CityName = bookModel.City,
                StateName = bookModel.State
            };
        }             
    }
}