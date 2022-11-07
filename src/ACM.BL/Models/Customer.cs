﻿namespace ACM.BL.Models;
public class Customer
{
    public Customer() { }
    public Customer(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public string EmailAddress { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName
    {
        get
        {
            var fullName = LastName;
            if (string.IsNullOrWhiteSpace(FirstName))
                return fullName;

            return string.IsNullOrWhiteSpace(fullName)
                ? FirstName
                : fullName += $", {FirstName}";
        }
    }

    // static denotes the member belongs to the class itself,
    // rather than to any specific instance
    public static int InstanceCount { get; set; }

    public bool IsValid() =>
        !string.IsNullOrWhiteSpace(LastName) &&
        !string.IsNullOrWhiteSpace(EmailAddress);
}