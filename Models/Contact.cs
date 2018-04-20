using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contacts
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
    private static List<Contacts> _instances = new List<Contacts> {};

    //constructor
    public Contacts(string name, string street, string city, string state, string zip, string phone, string email)
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

    //get name
    public string GetName()
    {
      return _name;
    }

    //set name
    public void SetName(string newName)
    {
      _name = newName;
    }

    //get street address
    public string GetStreet()
    {
      return _street;
    }

    //set street address
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    //get city
    public string GetCity()
    {
      return _city;
    }

    //set city
    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    //get state
    public string GetState()
    {
      return _state;
    }

    //set state
    public void SetState(string newState)
    {
      _state = newState;
    }

    //get zip code
    public string GetZip()
    {
      return _zip;
    }

    //set zip code
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }

    //get phone number
    public string GetPhone()
    {
      return _phone;
    }

    //set phone number
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

    //get email
    public string GetEmail()
    {
      return _email;
    }
    //set email
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

    //get ID value
    public int GetId()
    {
      return _id + 1;
    }

    //save contact instances to list
    public void Save()
    {
      _instances.Add(this);
    }

    //return list of instances
    public static List<Contacts> GetAll()
    {
      return _instances;
    }

    //clear list of instances
    public static void ClearAll()
    {
      _instances.Clear();
    }

    //declare method for finding instances by id
    public static Contacts Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}

//IGNORE BELOW

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
