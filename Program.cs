using System;
using dio_rpg.src.entities;

namespace dio_rpg{
	class Program{
		static void Main(string[] args){
			Knight arus = new Knight("Arus", 23, "Knight");
			Ninja wedge = new Ninja("Wedge", 62, "Ninja");
			Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
			Wizard topapa = new Wizard("Topapa", 42, "Black Wizard");

			Console.WriteLine(arus.Attack());
			Console.WriteLine(wedge.Attack());
			Console.WriteLine(jenica.Attack(10));
			Console.WriteLine(topapa.Attack(6));
		}
	}
}