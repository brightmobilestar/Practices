using System;
namespace turtletest
{
	public class Person
	{
		private string _name;
		private int _age;
		private string _homestead;
		
		public Person(string name, int age, string homestead)
		{
			_name = name;
			_age = age;
			_homestead = homestead;
		}

		public void Introduce()
		{
			Console.WriteLine(string.Format("Hi, I'm {0:0} from {1:0}. I'm {2:0} years old.", this._name, this._homestead, this._age));
		}
	}
}
