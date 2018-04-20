using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    //declare private variables
    private string _name;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _phone;
    private string _email;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    //constructor
    public Contact(string name, string street, string city, string state, string zip, string phone, string email)
      {
        _name = name;
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _phone = phone;
        _email = email;
        _instances.Add(this);
        _id = _instances.Count;
      }
    //allow public access to variables by declaring 'getters' and 'setters'

    //name
    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    //street address
    public string GetStreet()
    {
      return _street;
    }

    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    //city
    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    //state
    public string GetState()
    {
      return _state;
    }

    public void SetState(string newState)
    {
      _state = newState;
    }

    //zip code
    public string GetZip()
    {
      return _zip;
    }

    public void SetZip(string newZip)
    {
      _zip = newZip;
    }

    //phone number
    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

    //ID value
    public int GetId()
    {
      return _id + 1;
    }

    //save contact instances to list
    public void Save()
    {
      _instances.Add(this);
    }
    //return static list of instances
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    //clear static list of instances
    public static void ClearAll()
    {
      _instances.Clear();
    }
    //declare method for finding instances by id
    public static Contact Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    // //add instances of 'sub class' to a list
    // public void AddAddress(Address address)
    // {
    //   _addresses.Add(address);
    // }
    // //declare method for returning list of 'sub class' items
    // public List<Address> GetAddress()
    // {
    //   return _items;
    // }




  }
}
