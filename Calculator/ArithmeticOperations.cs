﻿using System;
namespace Calculator
{
	public class ArithmeticOperations
	{
		public ArithmeticOperations()
		{
		}

		public static double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;

        public static double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;

        public static double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

        public static double Divide(double firstNumber, double secondNumber) => firstNumber / secondNumber;
    }
}

