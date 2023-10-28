using System.Globalization; //for CultureInfo Class

//create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1990, 5, 25);
Console.WriteLine("My date of birth is: " + dateOfBirth);

//create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("Şu anki zaman: " + now);

//create a DateTime from a string
DateTime dateFromString = DateTime.Parse("5 25 1990", CultureInfo.InvariantCulture);
//CultureInfo.InvariantCulture = don't be specific to the culture, otherwise exceptions might occur, also System.Globalization needed
Console.WriteLine("dateFromString is: " + dateFromString);

//add additional time
Console.WriteLine("One day from now is: " + now.AddDays(1));
Console.WriteLine("One month from now is: " + now.AddMonths(1));

//ticks from DateTime
Console.WriteLine("Time as numeral is: " + now.Ticks);

//date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("dateOnlyOfBirth is: " + dateOnlyOfBirth);
//dateOfBirth.Date doesn't work like this

//time only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine("timeOnlyOfBirth is: " + timeOnlyOfBirth);

//reformat date
Console.WriteLine("RPA ile uyumlu tarih formatı {0}", dateOfBirth.ToString(format: "dd M yyyy"));