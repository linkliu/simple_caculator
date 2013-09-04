using System;
using System.Collections.Generic;

namespace CaculatorTest
{
	public class Caculator
	{
		
		#region decleration of variate
		private double expResult;
		private string myExpress;
		#endregion
		
		
		
		#region  constructor method
		public Caculator()
		{
			expResult = 0;
			myExpress= "no express";
		}
		
		public Caculator(double newResult,string newExpress)
		{
			expResult = newResult;
			myExpress = newExpress;
		}
		#endregion

		
		
		#region  property of the variate
		public double ExpResult
		{
			set
			{
				expResult = value;
			}
			get
			{
				return expResult;
			}
		}
		
		public string MyExpress
		{
			set
			{
				myExpress = value;
			}
			get
			{
				return myExpress;
			}
		}
		#endregion
		
		
		#region  caculatting algorithm
		public void  Computer()
		{
			expResult = putResult();
		}
		
		private double putResult()
		{
			char expOperator = GetCaculator();
		
			switch(expOperator)
			{
				case '+':
				{
					char [] separator = {'+'};
					string [] strArray = myExpress.Split(separator);
					return (Convert.ToDouble(strArray[0])+Convert.ToDouble(strArray[1]));
				}
				case '-':
				{
					char [] separator = {'-'};
					string [] strArray = myExpress.Split(separator);
					return (Convert.ToDouble(strArray[0])-Convert.ToDouble(strArray[1]));
				}
				case '*':
				{
					char [] separator = {'*'};
					string [] strArray = myExpress.Split(separator);
					return (Convert.ToDouble(strArray[0])*Convert.ToDouble(strArray[1]));
				}
				case '/':
				{
					char [] separator = {'/'};
					string [] strArray = myExpress.Split(separator);
					return (Convert.ToDouble(strArray[0])/Convert.ToDouble(strArray[1]));
				}
				default:
				{
					Console.WriteLine("operator error!");
					return -1E10;
					
				}
			}
			
		}
		
		public char GetCaculator()
		{
			string expOperator;
			int index = 0;
			if(((index = myExpress.IndexOf("+"))!=-1)||
			   ((index = myExpress.IndexOf("-"))!=-1)||
			   ((index = myExpress.IndexOf("*"))!=-1)||
			   ((index = myExpress.IndexOf("/"))!=-1))
			{
				expOperator = myExpress.Substring(index,1);
				char [] a = expOperator.ToCharArray();
				return a[0];
			}
			else
				return 'e';
					
			
		}
		#endregion
		
		public static void Main()
		{
			Caculator myCaculator = new Caculator();
			
			while(true)
			{
				Console.WriteLine("Please input a express:");
				myCaculator.myExpress = Console.ReadLine();
				
				myCaculator.Computer();
				
				Console.WriteLine("{0} = {1}",myCaculator.myExpress,myCaculator.expResult);
				
			}
		
		}
	}
}