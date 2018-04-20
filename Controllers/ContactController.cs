using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class ContactController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Contact> allContacts = Contact.GetAll();
        return View(allContacts);
      }

      [HttpGet("/Contacts/Create")]
      public ActionResult CreateForm()
      {
        return View("Form");
      }

      [HttpPost("/Contacts")]
      public ActionResult SubmitForm()
      {
        string name = Request.Form["name"];
        string street = Request.Form["street"];
        string city = Request.Form["city"];
        string state = Request.Form["state"];
        string zip = Request.Form["zip"];
        string phone = Request.Form["phone"];
        string email = Request.Form["email"];
        Contact newContact = new Contact(name, street, city, state, zip, phone, email);
        // newContact.Save();
        List<Contact> allContacts = Contact.GetAll();
        return RedirectToAction("Contacts", allContacts);
      }

      [HttpGet("/Contacts/{id}")]
      public ActionResult Details(int id)
      {
        Contact contact = Contact.Find(id);
        return View(contact);
      }

      [HttpGet("/Delete")]
      public ActionResult Delete()
      {
        Contact.ClearAll();
        return View("Contacts", allContacts);
      }
    }
}
