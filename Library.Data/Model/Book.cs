using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Library.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeekDaysList WeekDays { get; set; }
        public string Language { get; set; }

        public List<State> StatesData { get; set; }
        public SelectList CityData { get; set; }
    }

    public enum WeekDaysList
    {
        //Alabama, Alaska, [Display(Name = "American Samoa")] AmericanSamoa, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, [Display(Name = "District of Columbia")] DistrictOfColumbia, Florida, Georgia, Guam, Hawaii, Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland, Massachusetts, Michigan, Minnesota, [Display(Name = "Minor Outlying Islands")] MinorOutlyingIslands, Mississippi, Missouri, Montana, Nebraska, Nevada, [Display(Name = "New Hampshire")] NewHampshire, [Display(Name = "New Jersey")] NewJersey, [Display(Name = "New Mexico")] NewMexico, [Display(Name = " New York")] NewYork, [Display(Name = "North Carolina")] NorthCarolina, [Display(Name = "North Dakota")] NorthDakota, [Display(Name = "Northern Mariana Islands")] NorthernMarianaIslands, Ohio, Oklahoma, Oregon, Pennsylvania, [Display(Name = "Puerto Rico")] PuertoRico, [Display(Name = "District of Columbia")] RhodeIsland, [Display(Name = "South Carolina")] SouthCarolina, [Display(Name = "South Dakota")] SouthDakota, Tennessee, Texas, [Display(Name = "U.S. Virgin Islands")]  USVirginIslands, Utah, Vermont, Virginia, Washington, [Display(Name = "West Virginia")] WestVirginia, Wisconsin, Wyoming
        Monday,
        Tuesday,
        Wednessday,
        Thurday,
        Friday,
        Saturday,
        Sunday
    }

    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
    }
}
