namespace MTechSystems.Test.Stages
{
   public class Stage2
   {
		static void Main(string[] args)
		{
			/*
			 1) 
			  Create new class 'TruckWeight' with the following properties
				> TruckID (string)
				> Capacity (decimal)	   
				> Active (bool)	

			  2) 
				Create a list/collection of truck weights

				| TruckID	     |	Capacity	|	Active	|
				----------------------------------------------
				| Fuel Truck      |   10000      |   True    |
				| Tanker          |   22000		|   True	|
				| Trailer		 |   50000		|   True	|
				| Car Transporter |   30000		|   False   |


				3)
				 Find the active trucks with capacity less than 50000
			*/
		}

		public class TruckWeight
		{
			public string TruckId { get; set; }
			public decimal Capacity { get; set; }
			public bool Active { get; set; }

		}
	}
}
