using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ClassMVC.Models;

namespace ClassMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person { FirstName = "Paul", LastName = "Colon"};
            return View(person);
        }

        public ActionResult SayHello(Person person)
        {
            PersonRepository.AddPerson(person);
            return View(person);
        }

        public ActionResult ShowMeAList()
        {
            return View("ShowMeAList", PersonRepository.GetAllPersons());
        }

        public static class PersonRepository
        {
            private static List<Person> list = new List<Person>()
            {
                new Person() {FirstName = "Luke", LastName = "Skywalker"},
                new Person() {FirstName = "Lela", LastName = "Organa"},
                new Person() {FirstName = "Han", LastName = "Solo"}
            };

            public static List<Person> GetAllPersons()
            {
                return list;
            }

            public static void AddPerson(Person person)
            {
                list.Add(person);
            }
        }


    }
}