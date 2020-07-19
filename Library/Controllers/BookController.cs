using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Data.Model;
using Library.Data.Services;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        IBookData BookDB;
        // GET: Book
        public ActionResult Index()
        {
            var model = BookDB.GetBooks();
            return View(model);
        }

        public BookController()
        {
            BookDB = new InmemoryBookData();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book objBook)
        {
            int stateid = 1;
            if (TempData["StateId"] != null)
            {
                stateid = (int)TempData["StateId"];
            }

            if (!ModelState.IsValid)
            {
                objBook.States = GetAllStates();
                objBook.Cities = GetAllCities().Where(c => c.StateId == stateid).ToList();
                return View("Create", objBook);
            }

            //var selectedItem = objBook.Cities.Find(p => p.CityName == objBook.CityID.ToString());
            objBook.State = GetAllStates().Where(m => m.Id == stateid).FirstOrDefault().StateName;
            var cModel = GetAllCities().Where(m => m.StateId == stateid);
            SelectList obgcity = new SelectList(cModel, "Id", "CityName",0);

            //var stateName = TempData["selectedStateName"];
            var model = BookDB.AddBook(objBook);
            return View("Index", model);
        }

        [HttpPost]
        public ActionResult GetCityByState(int stateid)
        {
            var model = GetAllCities().Where(m => m.StateId == stateid);
            //SelectList obgcity = new SelectList(model, "Id", "CityName",0);--why this 0 at end?
            SelectList obgcity = new SelectList(model, "Id", "CityName",0);
            TempData["StateId"] = stateid;
            return Json(obgcity /*, JsonRequestBehavior.AllowGet */);
        }        

        [HttpGet]
        public ActionResult Create()
        {
            var model = new Book();
            model.States = GetAllStates();
            model.Cities = GetAllCities().Where(c=>c.StateId == 1).ToList();
            return View("Create", model);
        }

        public List<State> GetAllStates()
        {
            var statesList = new List<State>();
            statesList.Add(new State { Id = 1, StateName = "Virginia" });
            statesList.Add(new State { Id = 2, StateName = "Illinoi" });
            statesList.Add(new State { Id = 3, StateName = "California" });
            statesList.Add(new State { Id = 4, StateName = "Ohio" });
            statesList.Add(new State { Id = 5, StateName = "Maryland" });
            statesList.Add(new State { Id = 6, StateName = "Texas" });
            statesList.Add(new State { Id = 7, StateName = "Colorado" });
            statesList.Add(new State { Id = 8, StateName = "New York" });
            statesList.Add(new State { Id = 9, StateName = "Pensylvania" });
            statesList.Add(new State { Id = 10, StateName = "Michigan" });
            return statesList;
        }

        public List<City> GetAllCities()
        {
            var citiesList = new List<City>();
            citiesList.Add(new City { Id = 1, CityName = "Fairfax", StateId = 1 });
            citiesList.Add(new City { Id = 2, CityName = "Falls Church", StateId = 1 });
            citiesList.Add(new City { Id = 3, CityName = "Richmond", StateId = 1 });
            citiesList.Add(new City { Id = 4, CityName = "Chicago", StateId = 2 });
            citiesList.Add(new City { Id = 5, CityName = "Westmont", StateId = 2 });
            citiesList.Add(new City { Id = 6, CityName = "Sunnyvale", StateId = 3 });
            citiesList.Add(new City { Id = 7, CityName = "Sanjose", StateId = 3 });
            citiesList.Add(new City { Id = 8, CityName = "Gilroy", StateId = 3 });
            citiesList.Add(new City { Id = 9, CityName = "Cleveland", StateId = 4 });
            citiesList.Add(new City { Id = 10, CityName = "Columbus", StateId = 4 });
            citiesList.Add(new City { Id = 11, CityName = "Rockville", StateId = 5 });
            citiesList.Add(new City { Id = 12, CityName = "Chevy Chase", StateId = 5 });
            citiesList.Add(new City { Id = 12, CityName = "Geithersburg", StateId = 5 });
            citiesList.Add(new City { Id = 14, CityName = "Commerce", StateId = 6 });
            citiesList.Add(new City { Id = 15, CityName = "Dallas", StateId = 6 });
            citiesList.Add(new City { Id = 16, CityName = "Greenville", StateId = 6 });
            citiesList.Add(new City { Id = 17, CityName = "Cooper Lake", StateId = 6 });
            citiesList.Add(new City { Id = 18, CityName = "Colorado Springs", StateId = 7 });
            citiesList.Add(new City { Id = 19, CityName = "Denver", StateId = 7 });
            citiesList.Add(new City { Id = 20, CityName = "New York", StateId = 8 });
            citiesList.Add(new City { Id = 21, CityName = "Pittsburg", StateId = 9 });
            citiesList.Add(new City { Id = 22, CityName = "Detroit", StateId = 10});
            return citiesList;
        }
    }
}