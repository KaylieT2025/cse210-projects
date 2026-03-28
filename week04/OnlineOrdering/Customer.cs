using System;

public class Customer{

    private string _name;
    private Address _address;

    public Customer(string name, Address address){

        _name = name;
        _address = address;
    }

    public bool LivesInUsa(){

        return _address.IsUsa();
    }

    public string GetDisplayText(){

        return $"Customer: {_name}\n {_address.DisplayAddress()}";
    }

    public Address GetAddress(){

        return _address;
    }
}