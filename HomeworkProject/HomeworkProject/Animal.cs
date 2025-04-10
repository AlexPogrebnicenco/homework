using System;

namespace HomeworkProject 
{ 
	public class Animal 
	{
		private string _name; // Приватное поле для хранения имени жиовтного

		public string Name	// Публичное свойство позволяет читать и записывать имя
		{
			get { return _name; }  // геттер - возвращает значение _name
			set { _name = value; } // сеттер - присваивает значение переменной _name
		}

		public Animal(string name) // Конструктор класса - вызывается при создании объекта Animal 
		{
			_name = name;
		}

		public virtual void Speak() // Метод Speak, виртуальный - можно переопределить в наследниках
		{
			Console.WriteLine("The animal makes a sound.");  // Выводим фразу по умолчанию
		}

		// Overloading method Speack with parametr
		public void Speak(string mood)
		{
            Console.WriteLine($"{Name} if feeling {mood}");
		}

		public void Eat()
		{
			Console.WriteLine($"{Name} is eating."); // Используем имя животного в тексте
		}
	}
}