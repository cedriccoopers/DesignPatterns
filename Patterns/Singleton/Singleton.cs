using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace DesignPatterns.Singleton.Patterns
{
	/**
	 * 
	 *	We want to create one object and use it everywhere
	 *  Things such as Logging, drivers, settings
	 *  
	 *  Reason NOT to use:
	 *		Unit Testing
	 *		Thread Safety
	 *		Maybe a simple static class would be better
	 *		Violates Single Responsibility Principle	
	 **/

	public class Singleton
	{
		
		static Singleton instance;

		public string Settings { get; set; } = "Color blue";

		protected Singleton()
		{

		}


		public static Singleton Instance()
		{
			if(instance == null)
			{
				instance = new Singleton()
;			}
			return instance;
		}
	}
}

