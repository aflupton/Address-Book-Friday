using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class ContactController : Controller
    {
      [HttpGet("/Contacts")] //get index with all existing contacts
      public ActionResult Index()
      {
        List<Contacts> allContacts = Contacts.GetAll();
        return View(allContacts); //return list of existing contacts to the index
      }

      [HttpGet("/Contacts/Create")] //get entry form
      public ActionResult CreateForm()
      {
        return View("Form"); //return the input form
      }

      [HttpPost("/Contacts/Add")] //post item to contacts
      public ActionResult SubmitForm()
      {
        string name = Request.Form["name"];
        string street = Request.Form["street"];
        string city = Request.Form["city"];
        string state = Request.Form["state"];
        string zip = Request.Form["zip"];
        string phone = Request.Form["phone"];
        string email = Request.Form["email"];
        Contacts newContact = new Contacts(name, street, city, state, zip, phone, email);
        newContact.Save();
        List<Contacts> allContacts = Contacts.GetAll();
        return View("Index", allContacts); //return new item to the list
      }

      [HttpGet("/Contacts/{id}")] //get individual contact
      public ActionResult Details(int id)
      {
        Contacts contacts = Contacts.Find(id);
        return View("ContactDetails", contacts); //return contact detail on seperate pages
      }

      [HttpGet("/Delete")] //delete contacts
      public ActionResult Delete(int id)
      {
        Contacts.RemoveContact(id);
        return View("Index"); //return list minus deleted item
      }
    }
}
