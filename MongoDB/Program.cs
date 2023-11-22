using Lab3KM;
using MongoDB;
using MongoDB.Driver;
using Newtonsoft.Json;

internal class Program
{
	private static bool stopRequested = false;

	private static void TimerCallback(object state)
	{
		Console.WriteLine("10 seconds end");
		stopRequested = true;
	}
	private static async Task Main(string[] args)
	{
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
		
		List<Room> rooms = new List<Room>();

		List<Data> datas = new List<Data>();
		//Timer timer = new Timer(TimerCallback, null, 1000, Timeout.Infinite);
		int n = 1;
		for (int i = 1;  i <= 10000000000000; i++)
		{

			for (int j = 0; j < 100;  j++) 
			{
				Data data = new Data();
				datas.Add(data);
				Console.WriteLine($"i: {n++} {JsonConvert.SerializeObject(data)}");
			}
			
			collection.InsertMany(datas);
			await Task.Delay(0);
			datas.Clear();
		}
		//Mongo DB 5237 and 442 за 1 сек
		//SQL 1450 and 770 за 1 сек
	}
}