using System;

namespace HomeworkProject 
{ 
	public class Animal 
	{
		private string _name; 

		public string Name	
		{
			get { return _name; }  
			set { _name = value; } 
		}
		
		public Animal(string name) 
		{
			_name = name;
		}

		public virtual void Speak()
		{
			Console.WriteLine("The animal makes a sound.");  
		}

		public void Speak(string mood)
		{
            Console.WriteLine($"{Name} if feeling {mood}");
		}

		public void Eat()
		{
			Console.WriteLine($"{Name} is eating."); 
		}
	}
}