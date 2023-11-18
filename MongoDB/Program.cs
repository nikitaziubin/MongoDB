using Lab3KM;
using MongoDB;
using MongoDB.Driver;
using Newtonsoft.Json;

internal class Program
{
	private static async Task Main(string[] args)
	{
		// TODO:
		// Replace the placeholder connection string below with your
		// Altas cluster specifics. Be sure it includes
		// a valid username and password! Note that in a production environment,
		// you do not want to store your password in plain-text here.

		//var mongoUri = "<mongodb+srv://<nikziu>:<Yyra4HkYbcVZKemI>@fedoruslab2.ccpqawi.mongodb.net/>";
		var mongoUri = "mongodb://localhost:27017";

		IMongoClient client;
		IMongoCollection<Data> collection;
		IMongoDatabase database;

		try
		{
			client = new MongoClient(mongoUri);
		}
		catch (Exception e)
		{
			Console.WriteLine("There was a problem connecting to your " +
				"Atlas cluster. Check that the URI includes a valid " +
				"username and password, and that your IP address is " +
				$"in the Access List. Message: {e.Message}");
			Console.WriteLine(e);
			Console.WriteLine();
			return;
		}
		
		var dbName = "admin";
		//var collectionName = "staff";
		var collectionName = "Measurements";

		collection = client.GetDatabase(dbName)
		   .GetCollection<Data>(collectionName);
		

		//Staff staff1 = new Staff(2, "Nikita", "Ziubin", "Reception", "Administration", "email@gmail.com", "+380123456789");
		//Staff staff2 = new Staff(3, "Nikita", "Ziubin", "Reception", "Administration", "email@gmail.com", "+380123456789");

		//List<Staff> staffs = new List<Staff>();
		//staffs.Add(staff1);
		//staffs.Add(staff2);
		//collection.InsertMany(staffs);

		//var staffs = collection.Find(Builders<Staff>.Filter.Empty)
		//	  .ToList();
		//foreach (var staff in staffs)
		//{
		//	Console.WriteLine(staff.id + " " + staff.firstName + " " + staff.lastName);
		//}

		List<Room> rooms = new List<Room>();

		//Data data1 = new Data(1);
		//await Task.Delay(1000);
		//for (int i = 1; i < 10; i++)
		//{
		//	Sensor sensor = new Sensor(1);
		//	for (int j = 1; j < 10; j++)
		//	{
		//		Data  data = new Data(j);
		//		sensor.datas.Add(data);
		//		//await Task.Delay(1000);
		//	}
		//	Room room = new Room(i, 1, 50, 4, 1, 5, 2, sensor);
		//	rooms.Add(room);
		//}
		
		//collection.InsertMany(rooms);

		//List<Data> datas = new List<Data>();
		for (int i = 1;  i <= 1000000; i++) 
		{

			Data data = new Data();
			Console.WriteLine($"{JsonConvert.SerializeObject(data)}");
			collection.InsertOne(data);
			await Task.Delay(5);
		}

	}
}