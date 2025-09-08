// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

List<City> cityDataSet = new List<City>
{ 
    new City()
{ cityId = 1 ,
 cityName = "Banglore"
},
   new City()
{ cityId = 2 ,
 cityName = "Mumbai"
},
            new City()
{ cityId = 3 ,
 cityName = "Pune"
},
                new City()
{ cityId = 4 ,
 cityName = "Hyderabad"
}
};

List<Person> personDataSet = new List<Person>
{ 
    new Person
    { 
        pId = 100,
        personName = "Subhangi",
        cityId = 1
    } ,

    new Person
    {
        pId = 101,
        personName ="Gagan",
        cityId = 2
    },
    new Person
    {
        pId = 100,
        personName = "Subhangi",
        cityId = 1
    } ,

    new Person
    {
        pId = 102,
        personName = "Subhangi",
        cityId = 5
    } ,
     new Person
    {
        pId = 103,
        personName = "Subhangi",
        cityId = 1
    } ,
      new Person
    {
        pId = 104,
        personName = "Subhangi",
        cityId = 1
    },
      new Person
    {
        pId = 105,
        personName ="Gagan",
        cityId = 2
    },
       new Person
    {
        pId = 106,
        personName ="Gagan",
        cityId = 2
    },

};

int n = int.Parse(Console.ReadLine());

/*
 1. iterate through the city 
 2. for each city I will identify number of persons , HaspMap with  <cityId, count>, dictionary<person, int>
 3. Sort it and store the city names in ascending
 4. I can get top n will be least populated 
*/






