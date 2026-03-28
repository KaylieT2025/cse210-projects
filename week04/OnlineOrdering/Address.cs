using System;

public class Address{

    private string _street;
    private string _city;
    private string _stateOrProvidence;
    private string _country;

    public Address(string street, string city, string stateOrProvidence, string country){

        _street = street;
        _city = city;
        _stateOrProvidence = stateOrProvidence;
        _country = country;
    }

    public bool IsUsa(){

        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    public string DisplayAddress(){

        return $"{_street}\n{_city}, {_stateOrProvidence}\n{_country}";
    }
}