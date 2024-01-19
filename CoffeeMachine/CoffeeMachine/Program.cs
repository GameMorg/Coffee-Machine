/*
 * Created by SharpDevelop.
 * User: mylis
 * Date: 19.01.2024
 * Time: 1:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CoffeeMachine
{
	class Program
	{
		public static void Main(string[] args)
			/// Основной метод кофе-машины
		{
			bool run = true; /// Работа кофе машины
			bool check = false; /// Проверка всех основных функций кофемашины
			int money = 0; /// Деньги пользоваеля
			
			while (run)
			{
				check = Checking_readiness();
				Expectation_pass();
				int drink = Choosing_drink();
				
				if (Payment(money))
				{
					Making_drink(drink);
				}
				else{
					Console.WriteLine("У вас недостаточно средств!");
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static bool Checking_readiness()
			/// Проверка готовности систем кофе машины, таких как:
			/// 1) Соединение с интернетом
			/// 2) Связь с платежной системой
			/// 3) Наличие сырья
			/// 4) Готовности оборудования
			/// 5) Стабильности электропитания
		{
			
			bool check = true;
			Console.WriteLine("Кофе машина готова принять заказ");
			return check;
		}
		
		public static void Expectation_pass()
			/// Метод ожидания кофе машины 
		{
			Console.WriteLine("Пожалуйста, выберете напиток");
		}
		
		public static int Choosing_drink()
			/// Метод выбора напитка приготовления кофе машины
		{
			
			int drink = int.Parse(Console.ReadLine());
			return drink;
		}
		public static void Making_drink(int drink)
			/// Метод приготовления выбранного напитка
		{
			
			Console.WriteLine("Выбранный напиток " + drink + " приготовлен");
		}	
		
		public static bool Payment(int money)
			/// Метод для проверки оплаты за напиток
		{
			if (money > 0)
				return true;
			return false;
		}
	}
}