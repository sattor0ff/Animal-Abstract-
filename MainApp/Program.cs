var dog1 = new Dog();
dog1.Name = "Tobby";

var dog2 = new Dog();
dog2.SetName("Momo");

System.Console.WriteLine(dog1.Eat());
System.Console.WriteLine(dog1.GetName());
System.Console.WriteLine(dog2.Eat());