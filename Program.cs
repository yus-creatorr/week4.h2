// // Task 1 
// Rectangle rectangle = new Rectangle(3.2, 4.1);
// System.Console.WriteLine(rectangle.CalculateArea());

// Circle circle = new Circle(3.14);
// System.Console.WriteLine(circle.CalculateArea());

// // Task 2
// Car car = new Car();
// car.MoveLeft();
// System.Console.WriteLine("Than, After All");
// car.MoveRight();

// // Task 3

// BankAccount bankAccount = new BankAccount();
// bankAccount.Balance=32000;
// bankAccount.Withdraw(31000);
// System.Console.WriteLine(bankAccount.PrintStatement());

// // Task 4
// Book book0 = new Book("Odina", "S.Ayni", 1997);
// Book book1 = new Book("Odina", "S.Ayni", 1997);
// Book book2 = new Book("Odina", "S.Ayni", 1997);
// Book book3 = new Book("Odina", "S.Ayni", 1997);
// Book book4 = new Book("Odina", "S.Ayni", 1997);
// Library library = new Library("Kitobkhonai maktabi");
// library.AddBook(book0);
// library.AddBook(book1);
// library.AddBook(book2);
// library.AddBook(book3);
// library.AddBook(book4);

// // Task 1
// Student student = new Student("Abdulllo", 12);
// student.Greet();
// Teacher teacher = new Teacher("Dilovar", 23);
// teacher.Greet();
// student.ShowAge();
// student.Study();
// teacher.Greet();
// teacher.Explain();

//     // Task 2
//    Boook myBook = new Boook
//    {
//        Title = "Odina",
//        Author = "S Ayni"
//    };
//    myBook.Read();
//    myBook.Borrow();
//    myBook.ReturnBook();
// // 
// // Task 3
// List<IDevice> smartHomeDevices = new List<IDevice>
//             {
//                 new Lamp(),
//                 new Thermostat(),
//                 new Lock()
//             };

// foreach (var device in smartHomeDevices)
// {
//     device.TurnOn();
//     if (device is Lamp lamp)
//     {
//         lamp.SetBrightness(75);
//     }
//     else if (device is Thermostat thermostat)
//     {
//         thermostat.SetTemperature(24.5);
//     }
//     else if (device is Lock smartLock)
//     {
//         smartLock.UnlockDoor();
//         smartLock.LockDoor(); 
//     }
//     device.TurnOff();
//     Console.WriteLine(new string('-', 50));
// }